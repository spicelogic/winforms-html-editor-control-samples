Imports System
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Search Window Form
    ''' </summary>
    Partial Public Class SearchWindow
        Inherits DialogBase
        Implements ISearchDialog

        ''' <summary>
        ''' Occurs when [find next clicked].
        ''' </summary>
        Public Event FindNextClicked As EventHandler(Of SearchEventArg) Implements ISearchDialog.FindNextClicked

        ''' <summary>
        ''' Occurs when [dialog closed].
        ''' </summary>
        Public Event DialogClosed As EventHandler(Of EventArgs) Implements ISearchDialog.DialogClosed

        ''' <summary>
        ''' Occurs when [replace clicked]
        ''' </summary>
        Public Event ReplaceClicked As EventHandler(Of ReplaceEventArg) Implements ISearchDialog.ReplaceClicked

        ''' <summary>
        ''' Occures when [replace all clicked]
        ''' </summary>
        Public Event ReplaceAllClicked As EventHandler(Of ReplaceAllEventArg) Implements ISearchDialog.ReplaceAllClicked

        ''' <summary>
        ''' The last
        ''' </summary>
        Private Shared _last As String

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SearchWindow" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            ' Spec 019 FR-009: the .Designer.vb file already serializes
            ' rdoDirectionDown.Checked = True; no runtime override needed.
            ' Preload the last search text only when the host hasn't seeded
            ' a design-time value.
            If String.IsNullOrEmpty(txtSearchBox.Text) AndAlso Not String.IsNullOrEmpty(_last) Then
                txtSearchBox.Text = _last
            End If
            updateButtonsAvailability()
            AddHandler Disposed, AddressOf SearchWindow_Disposed

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Handles the Disposed event of the SearchWindow control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub SearchWindow_Disposed(sender As Object, e As EventArgs)
            _last = txtSearchBox.Text
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SearchWindow" /> class.
        ''' </summary>
        ''' <param name="preloadedSearchText">The preloaded search text.</param>
        Public Sub New(preloadedSearchText As String)
            txtSearchBox.Text = preloadedSearchText
            Me.onFindNextClicked(Me,
                New SearchEventArg(preloadedSearchText, Me) With {
                    .Direction = If(rdoDirectionDown.Checked,
                        SearchEventArg.SearchDirection.Down,
                        SearchEventArg.SearchDirection.Up),
                    .MatchCase = chkMatchCase.Checked,
                    .MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
                }
            )
        End Sub

        ''' <summary>
        ''' Gets or sets the preloaded search text.
        ''' </summary>
        ''' <value>The preloaded search text.</value>
        Public Property PreloadedSearchText As String Implements ISearchDialog.PreloadedSearchText
            Get
                Return Me.txtSearchBox.Text
            End Get
            Set(value As String)
                Me.txtSearchBox.Text = value
            End Set
        End Property

        ''' <summary>
        ''' Called when [search closed].
        ''' </summary>
        ''' <param name="sender">The sender.</param>
        ''' <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        Private Sub onDialogClosed(sender As Object, e As EventArgs)
            RaiseEvent DialogClosed(sender, e)
        End Sub

        ''' <summary>
        ''' Called when [find next clicked].
        ''' </summary>
        ''' <param name="sender">The sender.</param>
        ''' <param name="e">The e.</param>
        Private Sub onFindNextClicked(sender As Object, e As SearchEventArg)
            RaiseEvent FindNextClicked(sender, e)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnFindNext control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
            Me.onFindNextClicked(sender, New SearchEventArg(Me.txtSearchBox.Text, Me) With {
                    .Direction = If(rdoDirectionDown.Checked,
                        SearchEventArg.SearchDirection.Down,
                        SearchEventArg.SearchDirection.Up),
                    .MatchCase = chkMatchCase.Checked,
                    .MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
                }
            )
        End Sub

        ''' <summary>
        ''' Handles the TextChanged event of the txtSearchBox control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
            updateButtonsAvailability()
        End Sub

        ''' <summary>
        ''' Handles the FormClosed event of the SearchWindow control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        Private Sub SearchWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            Me.onDialogClosed(sender, e)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnReplace control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
            RaiseEvent ReplaceClicked(sender, New ReplaceEventArg(txtSearchBox.Text, txtReplaceBox.Text, Me) With {
                .Direction = If(rdoDirectionDown.Checked,
                    ReplaceEventArg.SearchDirection.Down,
                    ReplaceEventArg.SearchDirection.Up),
                .MatchCase = chkMatchCase.Checked,
                .MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
            })
        End Sub

        Private Sub btnReplaceAll_Click(sender As Object, e As EventArgs) Handles btnReplaceAll.Click
            RaiseEvent ReplaceAllClicked(sender, New ReplaceAllEventArg(txtSearchBox.Text, txtReplaceBox.Text, Me) With {
                .MatchCase = chkMatchCase.Checked,
                .MatchWholeWordOnly = chkMatchWholeWordOnly.Checked
            })
        End Sub

        ''' <summary>
        ''' Updates the buttons availability.
        ''' </summary>
        Private Sub updateButtonsAvailability()
            Dim enableButtons As Boolean = txtSearchBox.Text.Length > 0
            btnFindNext.Enabled = enableButtons
            btnReplace.Enabled = enableButtons
            btnReplaceAll.Enabled = enableButtons
        End Sub

        ''' <summary>
        ''' Handles the VisibleChanged event of the SearchWindow control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub SearchWindow_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
            txtSearchBox.Focus()
        End Sub

        ' VB.NET requires explicit interface implementation for the IDialog
        ' members the WinForms Form base class supplies (ShowDialog from
        ' IDialog, Dispose from IDisposable). C# satisfies these implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
