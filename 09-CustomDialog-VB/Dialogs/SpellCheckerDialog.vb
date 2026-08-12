Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports mshtml
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck
Imports SpiceLogic.HtmlEditor.Abstractions.Options
Imports SpiceLogic.HtmlEditor.WinForms.Helpers

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Spell Checker Dialog implementation.
    ''' </summary>
    Partial Public Class SpellCheckerDialog
        Inherits DialogBase
        Implements ISpellCheckerDialog

        ''' <summary>
        ''' Indicates that dialog is currently in searching mode
        ''' </summary>
        Private _isSearching As Boolean = True

        ''' <summary>
        ''' Holds current spell checking node
        ''' </summary>
        Private _node As SpellCheckerNode

        ''' <summary>
        ''' Maximum length for replacement word
        ''' </summary>
        Private Const ReplacementWordMaxLength As Integer = 150

        ''' <summary>
        ''' Color to mark current spelling word in text
        ''' </summary>
        Private Shared ReadOnly currentSpellingWordColor As Color = Color.Red

        ''' <summary>
        ''' Creates a new instance of <see cref="SpellCheckerDialog" />
        ''' and initialize spell checker options reference
        ''' </summary>
        Public Sub New()
            InitializeComponent()

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Gets current spelling node
        ''' </summary>
        Public Property Node As SpellCheckerNode Implements ISpellCheckerDialog.Node
            Get
                Return _node
            End Get
            Private Set(value As SpellCheckerNode)
                _node = value
            End Set
        End Property

        ''' <summary>
        ''' Gets range of current misspelled word
        ''' </summary>
        Private _currentWordRange As IHTMLTxtRange

        ''' <summary>
        ''' The actual Spell Checker options reference
        ''' </summary>
        ''' <value>The options.</value>
        Public Property Options As ISpellCheckerOption Implements ISpellCheckerDialog.Options

        ''' <summary>
        ''' The text that is under spell checking at the moment
        ''' </summary>
        ''' <value>The document text.</value>
        Public Property DocumentText As String Implements ISpellCheckerDialog.DocumentText
            Get
                Return richTxtDocument.Text
            End Get
            Set(value As String)
                richTxtDocument.Text = value
                updateMisspelledWordStyle(False)
                updateWindowState()
            End Set
        End Property

        ''' <summary>
        ''' Indicates that dialog is currently in searching mode
        ''' </summary>
        ''' <value><c>true</c> if this instance is searching; otherwise, <c>false</c>.</value>
        Private Property isSearching As Boolean
            Get
                Return _isSearching
            End Get
            Set(value As Boolean)
                If _isSearching <> value Then
                    _isSearching = value
                    updateWindowState()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Updates all window controls state using current context
        ''' </summary>
        Private Sub updateWindowState()
            updateSuggestionList()
            updateDialogButtons()
            updateStatusBar()
        End Sub

        ''' <summary>
        ''' Updates the status bar.
        ''' </summary>
        Private Sub updateStatusBar()
            If Me.isSearching Then
                wordStatusLabel.Text = Me.Options.WaitAlertMessage
            ElseIf Me.Node IsNot Nothing Then
                wordStatusLabel.Text = getFormattedSpellingWord(Me.Node.Word)
                wordCountToolStripStatusLabel.Text = $"Word {Me.Node.WordIndex + 1} from {Me.WordCount}"
            End If
        End Sub

        ''' <summary>
        ''' An event that raises when a user choose a one of actions (Ignore, Delete, Replace etc.)
        ''' </summary>
        Public Event SpellingActionRequested As EventHandler(Of SpellingActionEventArgs) Implements ISpellCheckerDialog.SpellingActionRequested

        ''' <summary>
        ''' Gets or sets an overall words count
        ''' </summary>
        Public Property WordCount As Integer Implements ISpellCheckerDialog.WordCount

        ''' <summary>
        ''' Gets currently spelling word surrounded by some extra information
        ''' about concrete spelling error kind such as: Misspelled word: [Word], Duplicate word: [Word]
        ''' </summary>
        ''' <param name="word">Current spelling word</param>
        ''' <returns>Formatted string contains current spelling word</returns>
        Private Function getFormattedSpellingWord(word As String) As String
            Dim wordStatusFormat As String
            Select Case Me.Node.ErrorKind
                Case SpellingErrorKind.MisspelledWord
                    wordStatusFormat = "Misspelled word: {0}"
                Case SpellingErrorKind.DuplicateWord
                    wordStatusFormat = "Duplicate word: {0}"
                Case Else
                    wordStatusFormat = "Current word: {0}"
            End Select

            Return String.Format(wordStatusFormat, word)
        End Function

        ''' <summary>
        ''' Updates all dialog buttons
        ''' </summary>
        Private Sub updateDialogButtons()
            suggestionList.Enabled = Not Me.isSearching
            btnIgnore.Enabled = Me.Node IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.DocumentText) AndAlso Not Me.isSearching
            btnIgnoreAll.Enabled = Me.Node IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.DocumentText) AndAlso Not Me.isSearching
            btnDelete.Enabled = Me.Node IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.DocumentText) AndAlso Not Me.isSearching
            btnAddToDictionary.Enabled = Me.Node IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.DocumentText) AndAlso Not Me.isSearching AndAlso
                                         Me.Node.ErrorKind = SpellingErrorKind.MisspelledWord
            btnReplace.Enabled = Me.Node IsNot Nothing AndAlso isReplacementWordValid(txtReplacementWord.Text) AndAlso Not Me.isSearching
            btnReplaceAll.Enabled = Me.Node IsNot Nothing AndAlso isReplacementWordValid(txtReplacementWord.Text) AndAlso Not Me.isSearching

            Me.btnAddToDictionary.Text = Me.Options.AddToDictionaryText
            Me.btnAddToDictionary.Visible = Me.Options.DictionaryFile.EnableUserDictionary AndAlso
                                            (Me.Node IsNot Nothing AndAlso Me.Node.ErrorKind <> SpellingErrorKind.DuplicateWord)
            Me.btnDelete.Text = If(Me.Node IsNot Nothing AndAlso Me.Node.ErrorKind = SpellingErrorKind.DuplicateWord,
                Me.Options.DeleteDuplicateText, Me.Options.DeleteText)
            Me.btnIgnore.Text = Me.Options.IgnoreText
            Me.btnIgnoreAll.Text = Me.Options.IgnoreAllText
        End Sub

        Private Shared Function isReplacementWordValid(replacementWord As String) As Boolean
            Return Not String.IsNullOrEmpty(replacementWord) AndAlso replacementWord.Length <= ReplacementWordMaxLength
        End Function

        ''' <summary>
        ''' Update suggestion list using current context
        ''' </summary>
        Private Sub updateSuggestionList()
            txtReplacementWord.Text = String.Empty

            suggestionList.BeginUpdate()
            Try
                suggestionList.DataSource = Nothing
                If Me.Node IsNot Nothing AndAlso Me.Node.HasSuggestions Then
                    Dim constrainedSuggestionsList As List(Of String) = New List(Of String)()
                    Dim i As Integer = 0
                    While i < Me.Options.MaxSuggestionsForDialogs AndAlso i < Me.Node.Suggestions.Length
                        constrainedSuggestionsList.Add(Me.Node.Suggestions(i))
                        i += 1
                    End While

                    suggestionList.DataSource = constrainedSuggestionsList
                    suggestionList.SelectedIndex = 0
                End If
            Finally
                suggestionList.EndUpdate()
                ' Move caret cursot to the end of current replacement word
                txtReplacementWord.Select(txtReplacementWord.Text.Length, 0)
                txtReplacementWord.Focus()
            End Try
        End Sub

        ''' <summary>
        ''' Updates document selecting misspelled words
        ''' </summary>
        ''' <param name="selected">Indicating that misspelled word should be selected</param>
        Private Sub updateMisspelledWordStyle(selected As Boolean)
            If Me.Node Is Nothing OrElse String.IsNullOrEmpty(Me.DocumentText) Then
                Return
            End If

            ' Here we should count "\r" symbols count because Rich Text Editor expands
            ' short line ending pair "\r\n" to single "\n"
            Dim originalText As String = Me.DocumentText.Replace(vbLf, vbCrLf)

            Dim textBeforeWord As String = If(Me.Node.TextPosition < originalText.Length, originalText.Remove(Me.Node.TextPosition), originalText)

            Dim rCount As Integer = textBeforeWord.Count(Function(t) t = ChrW(13))

            Dim selectionStart As Integer = Me.Node.TextPosition - rCount
            If selectionStart >= 0 Then
                'reset color and font
                richTxtDocument.Select(0, richTxtDocument.TextLength)
                richTxtDocument.SelectionColor = richTxtDocument.ForeColor
                richTxtDocument.SelectionFont = richTxtDocument.Font

                richTxtDocument.Select(selectionStart, Node.Word.Length)
                richTxtDocument.SelectionColor = If(selected, currentSpellingWordColor, richTxtDocument.ForeColor)
                Dim currentFont As Font = richTxtDocument.SelectionFont
                richTxtDocument.SelectionFont = If((selected AndAlso currentFont IsNot Nothing),
                    New Font(currentFont, FontStyle.Underline),
                    richTxtDocument.Font)

                ' Scroll window to show current misspelled word
                richTxtDocument.Select(selectionStart, 0)
                richTxtDocument.ScrollToCaret()
            End If

            Me.isSearching = False
        End Sub

#Region "Spell Check Dialog handlers"

        ''' <summary>
        ''' Handles the Click event of the btnIgnore control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnIgnore_Click(sender As Object, e As EventArgs) Handles btnIgnore.Click
            Try
                Dim handler As EventHandler(Of SpellingActionEventArgs) = SpellingActionRequestedEvent
                If handler IsNot Nothing Then
                    Dim eventArgs As SpellingActionEventArgs = New SpellingActionEventArgs(Me.Node, Me._currentWordRange, SpellingActionType.Ignore)
                    handler(Me, eventArgs)
                End If
                Me.isSearching = True
            Catch
                ' ignored
            End Try
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnIgnoreAll control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnIgnoreAll_Click(sender As Object, e As EventArgs) Handles btnIgnoreAll.Click
            Try
                Dim handler As EventHandler(Of SpellingActionEventArgs) = SpellingActionRequestedEvent
                If handler IsNot Nothing Then
                    Dim eventArgs As SpellingActionEventArgs = New SpellingActionEventArgs(Me.Node, Me._currentWordRange, SpellingActionType.IgnoreAll)
                    handler(Me, eventArgs)
                End If

                Me.isSearching = True
            Catch
                ' ignored
            End Try
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnAddtoDictionary control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnAddtoDictionary_Click(sender As Object, e As EventArgs) Handles btnAddToDictionary.Click
            Try
                Dim handler As EventHandler(Of SpellingActionEventArgs) = SpellingActionRequestedEvent
                If handler IsNot Nothing Then
                    Dim eventArgs As SpellingActionEventArgs = New SpellingActionEventArgs(Me.Node, Me._currentWordRange, SpellingActionType.AddToDictionary)
                    handler(Me, eventArgs)
                End If

                Me.isSearching = True
            Catch
                ' ignored
            End Try
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnDelete control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            Try
                Dim handler As EventHandler(Of SpellingActionEventArgs) = SpellingActionRequestedEvent
                If handler IsNot Nothing Then
                    Dim eventArgs As SpellingActionEventArgs = New SpellingActionEventArgs(Me.Node, Me._currentWordRange, SpellingActionType.Delete)
                    handler(Me, eventArgs)
                End If

                Me.isSearching = True
            Catch
                ' ignored
            End Try
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnReplace control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click, suggestionList.DoubleClick
            Try
                Dim handler As EventHandler(Of SpellingActionEventArgs) = SpellingActionRequestedEvent
                If handler IsNot Nothing Then
                    Dim replacementWord As String = txtReplacementWord.Text
                    Dim eventArgs As ReplaceActionEventArgs = New ReplaceActionEventArgs(Me.Node, Me._currentWordRange, replacementWord)
                    handler(Me, eventArgs)
                End If

                Me.isSearching = True
            Catch
                ' ignored
            End Try
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnReplaceAll control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnReplaceAll_Click(sender As Object, e As EventArgs) Handles btnReplaceAll.Click
            Try
                Dim handler As EventHandler(Of SpellingActionEventArgs) = SpellingActionRequestedEvent
                If handler IsNot Nothing Then
                    Dim replacementWord As String = txtReplacementWord.Text
                    Dim eventArgs As ReplaceActionEventArgs = New ReplaceActionEventArgs(Me.Node, Me._currentWordRange, replacementWord, SpellingActionType.ReplaceAll)
                    handler(Me, eventArgs)
                End If

                Me.isSearching = True
            Catch
                ' ignored
            End Try
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the suggestionList control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub suggestionList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles suggestionList.SelectedIndexChanged
            txtReplacementWord.Text = suggestionList.Text
            validateReplacementWord(txtReplacementWord.Text)
        End Sub

        ''' <summary>
        ''' Validates the replacement word.
        ''' </summary>
        ''' <param name="replacementWord">The replacement word.</param>
        Private Sub validateReplacementWord(replacementWord As String)
            If isReplacementWordValid(replacementWord) Then
                messageToolStripStatusLabel.Text = String.Empty
            ElseIf Me.Node IsNot Nothing AndAlso Me.Node.ErrorKind = SpellingErrorKind.MisspelledWord Then
                If String.IsNullOrEmpty(replacementWord) Then
                    messageToolStripStatusLabel.Text = "No replacement word specified"
                ElseIf replacementWord.Length > ReplacementWordMaxLength Then
                    messageToolStripStatusLabel.Text =
                        $"Replacement word length shouldn't exceed {ReplacementWordMaxLength} chars"
                End If
            End If

            updateDialogButtons()
        End Sub

        ''' <summary>
        ''' Handles replace word text box TextChanged event.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub txtReplaceWord_TextChanged(sender As Object, e As EventArgs) Handles txtReplacementWord.TextChanged
            validateReplacementWord(txtReplacementWord.Text)
        End Sub

#End Region



        ''' <summary>
        ''' Sets the current node.
        ''' </summary>
        ''' <param name="node">The node.</param>
        ''' <param name="currentWordRange">The current word range.</param>
        ''' <exception cref="System.ArgumentNullException">
        ''' node
        ''' or
        ''' currentWordRange
        ''' </exception>
        Public Sub SetCurrentNode(node As SpellCheckerNode, currentWordRange As IHTMLTxtRange) Implements ISpellCheckerDialog.SetCurrentNode
            If node Is Nothing Then
                Throw New ArgumentNullException(NameOf(node))
            End If
            _node = node
            If currentWordRange Is Nothing Then
                Throw New ArgumentNullException(NameOf(currentWordRange))
            End If
            Me._currentWordRange = currentWordRange

            Me.isSearching = True
            updateMisspelledWordStyle(True)
            updateWindowState()
        End Sub

        ''' <summary>
        ''' Raises the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event.
        ''' </summary>
        ''' <param name="e">The <see cref="T:System.Windows.Forms.FormClosedEventArgs" /> that contains the event data.</param>
        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            MyBase.OnFormClosed(e)
            updateMisspelledWordStyle(False)
            Me.Node = Nothing
            suggestionList.DataSource = Nothing
            Me._isSearching = True ' Reset this flag without update
        End Sub

        ''' <summary>
        ''' Closes the dialog with predefined result based on <paramref name="canceled"/>
        ''' </summary>
        ''' <param name="canceled">if set to True then DialogResult is Cancel, otherwise DialogResult is OK.</param>
        Public Overloads Sub Close(canceled As Boolean) Implements ISpellCheckerDialog.Close
            Me.DialogResult = If(canceled, DialogResult.Cancel, DialogResult.OK)
        End Sub

        ''' <summary>
        ''' Raises when dialog windows is loaded
        ''' </summary>
        Public Event DialogLoaded As EventHandler Implements ISpellCheckerDialog.DialogLoaded

        ''' <summary>
        ''' Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        ''' </summary>
        ''' <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            ' Raise dialog loaded event
            Dim dialogLoadedHandler As EventHandler = DialogLoadedEvent
            If dialogLoadedHandler IsNot Nothing Then
                dialogLoadedHandler(Me, e)
            End If

            updateWindowState()
        End Sub

        ''' <summary>
        ''' Indicates whether the dialog is currently visible. C# satisfies
        ''' ISpellCheckerDialog.Visible implicitly with Form.Visible; VB needs
        ''' an explicit interface member, so this read-only bridge forwards to
        ''' the base Form.Visible without shadowing it (shadowing would block
        ''' the framework from setting Visible during ShowDialog).
        ''' </summary>
        Private ReadOnly Property ISpellCheckerDialog_Visible As Boolean Implements ISpellCheckerDialog.Visible
            Get
                Return MyBase.Visible
            End Get
        End Property

        ' VB.NET requires explicit interface implementation for the IDialog
        ' members the WinForms Form base class supplies (ShowDialog from
        ' IDialog, Dispose from IDisposable). C# satisfies these implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
