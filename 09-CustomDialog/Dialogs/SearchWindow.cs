using System;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Search Window Form
/// </summary>
public partial class SearchWindow : DialogBase, ISearchDialog
{
    /// <summary>
    /// Occurs when [find next clicked].
    /// </summary>
    public event EventHandler<SearchEventArg> FindNextClicked;

    /// <summary>
    /// Occurs when [dialog closed].
    /// </summary>
    public event EventHandler<EventArgs> DialogClosed;

    /// <summary>
    /// Occurs when [replace clicked]
    /// </summary>
    public event EventHandler<ReplaceEventArg> ReplaceClicked;

    /// <summary>
    /// Occures when [replace all clicked]
    /// </summary>
    public event EventHandler<ReplaceAllEventArg> ReplaceAllClicked;

    /// <summary>
    /// The last
    /// </summary>
    private static string _last;

    /// <summary>
    /// Initializes a new instance of the <see cref="SearchWindow" /> class.
    /// </summary>
    public SearchWindow()
    {
        InitializeComponent();
        // Spec 019 FR-009: the .designer.cs file already serializes
        // rdoDirectionDown.Checked = true; no runtime override needed.
        // Preload the last search text only when the host hasn't seeded a
        // design-time value.
        if (string.IsNullOrEmpty(txtSearchBox.Text) && !string.IsNullOrEmpty(_last))
            txtSearchBox.Text = _last;
        updateButtonsAvailability();
        Disposed += SearchWindow_Disposed;

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Handles the Disposed event of the SearchWindow control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    void SearchWindow_Disposed(object sender, EventArgs e)
    {
        _last = txtSearchBox.Text;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SearchWindow" /> class.
    /// </summary>
    /// <param name="preloadedSearchText">The preloaded search text.</param>
    public SearchWindow(string preloadedSearchText) 
    {
        txtSearchBox.Text = preloadedSearchText;
        this.onFindNextClicked(this,
            new SearchEventArg(preloadedSearchText, this)
            {
                Direction = rdoDirectionDown.Checked
                    ? SearchEventArg.SearchDirection.Down
                    : SearchEventArg.SearchDirection.Up,
                MatchCase = chkMatchCase.Checked,
                MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
            }
        );
    }

    /// <summary>
    /// Gets or sets the preloaded search text.
    /// </summary>
    /// <value>The preloaded search text.</value>
    public string PreloadedSearchText
    {
        get => this.txtSearchBox.Text;
        set => this.txtSearchBox.Text = value;
    }

    /// <summary>
    /// Called when [search closed].
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void onDialogClosed(object sender, EventArgs e)
    {
        this.DialogClosed?.Invoke(sender, e);
    }

    /// <summary>
    /// Called when [find next clicked].
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The e.</param>
    private void onFindNextClicked(object sender, SearchEventArg e)
    {
        this.FindNextClicked?.Invoke(sender, e);
    }

    /// <summary>
    /// Handles the Click event of the btnFindNext control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void btnFindNext_Click(object sender, EventArgs e)
    {
        this.onFindNextClicked(sender, new SearchEventArg(this.txtSearchBox.Text, this)
            {
                Direction = rdoDirectionDown.Checked
                    ? SearchEventArg.SearchDirection.Down
                    : SearchEventArg.SearchDirection.Up,
                MatchCase = chkMatchCase.Checked,
                MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
            }
        );
    }

    /// <summary>
    /// Handles the TextChanged event of the txtSearchBox control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void txtSearchBox_TextChanged(object sender, EventArgs e)
    {
        updateButtonsAvailability();
    }

    /// <summary>
    /// Handles the FormClosed event of the SearchWindow control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
    private void SearchWindow_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.onDialogClosed(sender, e);
    }

    /// <summary>
    /// Handles the Click event of the btnReplace control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnReplace_Click(object sender, EventArgs e)
    {
        this.ReplaceClicked(sender, new ReplaceEventArg(txtSearchBox.Text, txtReplaceBox.Text, this)
        {
            Direction = rdoDirectionDown.Checked
                ? ReplaceEventArg.SearchDirection.Down
                : ReplaceEventArg.SearchDirection.Up,
            MatchCase = chkMatchCase.Checked,
            MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
        });
    }

    private void btnReplaceAll_Click(object sender, EventArgs e)
    {
        this.ReplaceAllClicked(sender, new ReplaceAllEventArg(txtSearchBox.Text, txtReplaceBox.Text, this)
        {
            MatchCase = chkMatchCase.Checked,
            MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
        });
    }

    /// <summary>
    /// Updates the buttons availability.
    /// </summary>
    private void updateButtonsAvailability()
    {
        bool enableButtons = txtSearchBox.Text.Length > 0;
        btnFindNext.Enabled = enableButtons;
        btnReplace.Enabled = enableButtons;
        btnReplaceAll.Enabled = enableButtons;
    }

    /// <summary>
    /// Handles the VisibleChanged event of the SearchWindow control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void SearchWindow_VisibleChanged(object sender, EventArgs e)
    {
        txtSearchBox.Focus();
    }
}