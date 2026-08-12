using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using mshtml;
using SpiceLogic.HtmlEditor.Abstractions.Dialogs;
using SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck;
using SpiceLogic.HtmlEditor.Abstractions.Options;
using SpiceLogic.HtmlEditor.WinForms.Helpers;

namespace CustomDialog.Dialogs;

/// <summary>
/// Spell Checker Dialog implementation.
/// </summary>
public partial class SpellCheckerDialog : DialogBase, ISpellCheckerDialog
{
    /// <summary>
    /// Indicates that dialog is currently in searching mode
    /// </summary>
    private bool _isSearching = true;

    /// <summary>
    /// Holds current spell checking node
    /// </summary>
    private SpellCheckerNode _node;

    /// <summary>
    /// Maximum length for replacement word
    /// </summary>
    private const int ReplacementWordMaxLength = 150;

    /// <summary>
    /// Color to mark current spelling word in text
    /// </summary>
    private static readonly Color currentSpellingWordColor = Color.Red;

    /// <summary>
    /// Creates a new instance of <see cref="SpellCheckerDialog" />
    /// and initialize spell checker options reference
    /// </summary>
    public SpellCheckerDialog()
    {
        InitializeComponent();

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Gets current spelling node
    /// </summary>
    public SpellCheckerNode Node
    {
        get => _node;
        private set => _node = value;
    }

    /// <summary>
    /// Gets range of current misspelled word
    /// </summary>
    private IHTMLTxtRange _currentWordRange;

    /// <summary>
    /// The actual Spell Checker options reference
    /// </summary>
    /// <value>The options.</value>
    public ISpellCheckerOption Options { get; set; }

    /// <summary>
    /// The text that is under spell checking at the moment
    /// </summary>
    /// <value>The document text.</value>
    public string DocumentText
    {
        get => richTxtDocument.Text;
        set
        {
            richTxtDocument.Text = value;
            updateMisspelledWordStyle(false);
            updateWindowState();
        }
    }

    /// <summary>
    /// Indicates that dialog is currently in searching mode
    /// </summary>
    /// <value><c>true</c> if this instance is searching; otherwise, <c>false</c>.</value>
    private bool isSearching
    {
        get => _isSearching;
        set
        {
            if (_isSearching != value)
            {
                _isSearching = value;
                updateWindowState();
            }
        }
    }

    /// <summary>
    /// Updates all window controls state using current context
    /// </summary>
    private void updateWindowState()
    {
        updateSuggestionList();
        updateDialogButtons();
        updateStatusBar();
    }

    /// <summary>
    /// Updates the status bar.
    /// </summary>
    private void updateStatusBar()
    {
        if (this.isSearching)
            wordStatusLabel.Text = this.Options.WaitAlertMessage;
        else if (this.Node != null)
        {
            wordStatusLabel.Text = getFormattedSpellingWord(this.Node.Word);
            wordCountToolStripStatusLabel.Text = $"Word {this.Node.WordIndex + 1} from {this.WordCount}";
        }
    }

    /// <summary>
    /// An event that raises when a user choose a one of actions (Ignore, Delete, Replace etc.)
    /// </summary>
    public event EventHandler<SpellingActionEventArgs> SpellingActionRequested;

    /// <summary>
    /// Gets or sets an overall words count
    /// </summary>
    public int WordCount { get; set; }

    /// <summary>
    /// Gets currently spelling word surrounded by some extra information
    /// about concrete spelling error kind such as: Misspelled word: [Word], Duplicate word: [Word]
    /// </summary>
    /// <param name="word">Current spelling word</param>
    /// <returns>Formatted string contains current spelling word</returns>
    private string getFormattedSpellingWord(string word)
    {
        string wordStatusFormat;
        switch (this.Node.ErrorKind)
        {
            case SpellingErrorKind.MisspelledWord:
                wordStatusFormat = "Misspelled word: {0}";
                break;
            case SpellingErrorKind.DuplicateWord:
                wordStatusFormat = "Duplicate word: {0}";
                break;
            default:
                wordStatusFormat = "Current word: {0}";
                break;
        }

        return string.Format(wordStatusFormat, word);
    }

    /// <summary>
    /// Updates all dialog buttons
    /// </summary>
    private void updateDialogButtons()
    {
        suggestionList.Enabled = !this.isSearching;
        btnIgnore.Enabled = this.Node != null && !string.IsNullOrEmpty(this.DocumentText) && !this.isSearching;
        btnIgnoreAll.Enabled = this.Node != null && !string.IsNullOrEmpty(this.DocumentText) && !this.isSearching;
        btnDelete.Enabled = this.Node != null && !string.IsNullOrEmpty(this.DocumentText) && !this.isSearching;
        btnAddToDictionary.Enabled = this.Node != null && !string.IsNullOrEmpty(this.DocumentText) && !this.isSearching &&
                                     this.Node.ErrorKind == SpellingErrorKind.MisspelledWord;
        btnReplace.Enabled = this.Node != null && isReplacementWordValid(txtReplacementWord.Text) && !this.isSearching;
        btnReplaceAll.Enabled = this.Node != null && isReplacementWordValid(txtReplacementWord.Text) && !this.isSearching;

        this.btnAddToDictionary.Text = this.Options.AddToDictionaryText;
        this.btnAddToDictionary.Visible = this.Options.DictionaryFile.EnableUserDictionary &&
                                          (this.Node != null && this.Node.ErrorKind != SpellingErrorKind.DuplicateWord);
        this.btnDelete.Text = this.Node is { ErrorKind: SpellingErrorKind.DuplicateWord } ?
            this.Options.DeleteDuplicateText : this.Options.DeleteText;
        this.btnIgnore.Text = this.Options.IgnoreText;
        this.btnIgnoreAll.Text = this.Options.IgnoreAllText;
    }

    private static bool isReplacementWordValid(string replacementWord)
    {
        return !string.IsNullOrEmpty(replacementWord) && replacementWord.Length <= ReplacementWordMaxLength;
    }

    /// <summary>
    /// Update suggestion list using current context
    /// </summary>
    private void updateSuggestionList()
    {
        txtReplacementWord.Text = string.Empty;

        suggestionList.BeginUpdate();
        try
        {
            suggestionList.DataSource = null;
            if (this.Node is { HasSuggestions: true })
            {
                List<string> constrainedSuggestionsList = [];
                for (int i = 0; i < this.Options.MaxSuggestionsForDialogs && i < this.Node.Suggestions.Length; ++i)
                {
                    constrainedSuggestionsList.Add(this.Node.Suggestions[i]);
                }

                suggestionList.DataSource = constrainedSuggestionsList;
                suggestionList.SelectedIndex = 0;
            }
        }
        finally
        {
            suggestionList.EndUpdate();
            // Move caret cursot to the end of current replacement word
            txtReplacementWord.Select(txtReplacementWord.Text.Length, 0);
            txtReplacementWord.Focus();
        }
    }

    /// <summary>
    /// Updates document selecting misspelled words
    /// </summary>
    /// <param name="selected">Indicating that misspelled word should be selected</param>
    private void updateMisspelledWordStyle(bool selected)
    {
        if (this.Node == null || string.IsNullOrEmpty(this.DocumentText))
            return;

        // Here we should count "\r" symbols count because Rich Text Editor expands 
        // short line ending pair "\r\n" to single "\n"
        string originalText = this.DocumentText.Replace("\n", "\r\n");

        string textBeforeWord = this.Node.TextPosition < originalText.Length ? originalText.Remove(this.Node.TextPosition) : originalText;

        int rCount = textBeforeWord.Count(t => t == '\r');

        int selectionStart = this.Node.TextPosition - rCount;
        if (selectionStart >= 0)
        {
            //reset color and font
            richTxtDocument.Select(0, richTxtDocument.TextLength);
            richTxtDocument.SelectionColor = richTxtDocument.ForeColor;
            richTxtDocument.SelectionFont = richTxtDocument.Font;

            richTxtDocument.Select(selectionStart, Node.Word.Length);
            richTxtDocument.SelectionColor = selected ? currentSpellingWordColor : richTxtDocument.ForeColor;
            Font currentFont = richTxtDocument.SelectionFont;
            richTxtDocument.SelectionFont = (selected && currentFont != null) 
                ? new Font(currentFont, FontStyle.Underline) 
                : richTxtDocument.Font;

            // Scroll window to show current misspelled word
            richTxtDocument.Select(selectionStart, 0);
            richTxtDocument.ScrollToCaret();
        }

        this.isSearching = false;
    }

    #region Spell Check Dialog handlers

    /// <summary>
    /// Handles the Click event of the btnIgnore control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnIgnore_Click(object sender, EventArgs e)
    {
        try
        {
            EventHandler<SpellingActionEventArgs> handler = this.SpellingActionRequested;
            if (handler != null)
            {
                SpellingActionEventArgs eventArgs = new(this.Node, this._currentWordRange, SpellingActionType.Ignore);
                handler(this, eventArgs);
            }
            this.isSearching = true;
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    /// Handles the Click event of the btnIgnoreAll control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnIgnoreAll_Click(object sender, EventArgs e)
    {
        try
        {
            EventHandler<SpellingActionEventArgs> handler = this.SpellingActionRequested;
            if (handler != null)
            {
                SpellingActionEventArgs eventArgs = new(this.Node, this._currentWordRange, SpellingActionType.IgnoreAll);
                handler(this, eventArgs);
            }

            this.isSearching = true;
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    /// Handles the Click event of the btnAddtoDictionary control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnAddtoDictionary_Click(object sender, EventArgs e)
    {
        try
        {
            EventHandler<SpellingActionEventArgs> handler = this.SpellingActionRequested;
            if (handler != null)
            {
                SpellingActionEventArgs eventArgs = new(this.Node, this._currentWordRange, SpellingActionType.AddToDictionary);
                handler(this, eventArgs);
            }

            this.isSearching = true;
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    /// Handles the Click event of the btnDelete control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            EventHandler<SpellingActionEventArgs> handler = this.SpellingActionRequested;
            if (handler != null)
            {
                SpellingActionEventArgs eventArgs = new(this.Node, this._currentWordRange, SpellingActionType.Delete);
                handler(this, eventArgs);
            }

            this.isSearching = true;
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    /// Handles the Click event of the btnReplace control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnReplace_Click(object sender, EventArgs e)
    {
        try
        {
            EventHandler<SpellingActionEventArgs> handler = this.SpellingActionRequested;
            if (handler != null)
            {
                string replacementWord = txtReplacementWord.Text;
                ReplaceActionEventArgs eventArgs = new(this.Node, this._currentWordRange, replacementWord);
                handler(this, eventArgs);
            }

            this.isSearching = true;
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    /// Handles the Click event of the btnReplaceAll control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnReplaceAll_Click(object sender, EventArgs e)
    {
        try
        {
            EventHandler<SpellingActionEventArgs> handler = this.SpellingActionRequested;
            if (handler != null)
            {
                string replacementWord = txtReplacementWord.Text;
                ReplaceActionEventArgs eventArgs = new(this.Node, this._currentWordRange, replacementWord, SpellingActionType.ReplaceAll);
                handler(this, eventArgs);
            }

            this.isSearching = true;
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the suggestionList control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void suggestionList_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtReplacementWord.Text = suggestionList.Text;
        validateReplacementWord(txtReplacementWord.Text);
    }

    /// <summary>
    /// Validates the replacement word.
    /// </summary>
    /// <param name="replacementWord">The replacement word.</param>
    private void validateReplacementWord(string replacementWord)
    {
        if (isReplacementWordValid(replacementWord))
            messageToolStripStatusLabel.Text = string.Empty;
        else if (this.Node is { ErrorKind: SpellingErrorKind.MisspelledWord })
        {
            if (string.IsNullOrEmpty(replacementWord))
                messageToolStripStatusLabel.Text = @"No replacement word specified";
            else if (replacementWord.Length > ReplacementWordMaxLength)
                messageToolStripStatusLabel.Text =
                    $"Replacement word length shouldn\'t exceed {ReplacementWordMaxLength} chars";
        }

        updateDialogButtons();
    }

    /// <summary>
    /// Handles replace word text box TextChanged event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void txtReplaceWord_TextChanged(object sender, EventArgs e)
    {
        validateReplacementWord(txtReplacementWord.Text);
    }

    #endregion



    /// <summary>
    /// Sets the current node.
    /// </summary>
    /// <param name="node">The node.</param>
    /// <param name="currentWordRange">The current word range.</param>
    /// <exception cref="System.ArgumentNullException">
    /// node
    /// or
    /// currentWordRange
    /// </exception>
        
    public void SetCurrentNode(SpellCheckerNode node, IHTMLTxtRange currentWordRange)
    {
        _node = node ?? throw new ArgumentNullException(nameof(node));
        this._currentWordRange = currentWordRange ?? throw new ArgumentNullException(nameof(currentWordRange));

        this.isSearching = true;
        updateMisspelledWordStyle(true);
        updateWindowState();
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event.
    /// </summary>
    /// <param name="e">The <see cref="T:System.Windows.Forms.FormClosedEventArgs" /> that contains the event data.</param>
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        updateMisspelledWordStyle(false);
        this.Node = null;
        suggestionList.DataSource = null;
        this._isSearching = true; // Reset this flag without update
    }

    /// <summary>
    /// Closes the dialog with predefined result based on <paramref name="canceled"/>
    /// </summary>
    /// <param name="canceled">if set to True then DialogResult is Cancel, otherwise DialogResult is OK.</param>
    public void Close(bool canceled)
    {
        this.DialogResult = canceled ? DialogResult.Cancel : DialogResult.OK;
    }

    /// <summary>
    /// Raises when dialog windows is loaded
    /// </summary>
    public event EventHandler DialogLoaded;

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // Raise dialog loaded event
        this.DialogLoaded?.Invoke(this, e);

        updateWindowState();
    }
}