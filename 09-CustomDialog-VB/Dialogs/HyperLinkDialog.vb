Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.Abstractions.Entities
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Class HyperLinkDialog
    ''' </summary>
    Partial Public Class HyperLinkDialog
        Inherits DialogBase
        Implements IHyperlinkDialog

        ''' <summary>
        ''' The _the original element
        ''' </summary>
        Private _theOriginalElement As HyperlinkElement

        ''' <summary>
        ''' Whether toolTip1 is shown
        ''' </summary>
        Private _toolTipShown As Boolean = False

        ''' <summary>
        ''' Initializes a new instance of the <see cref="HyperLinkDialog" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Handles the Load event of the HyperLinkDialog control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub HyperLinkDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If String.IsNullOrEmpty(Me._theOriginalElement.BaseUrl) Then
                rdoWorkingDirFile.Enabled = False
                toolTip1.SetToolTip(rdoWorkingDirFile, "You need to set Base Url in order to use this option")
            End If
        End Sub

        ''' <summary>
        ''' Gets or sets the element.
        ''' </summary>
        ''' <value>The element.</value>
        Public Property Element As HyperlinkElement Implements IHyperlinkDialog.Element
            Get
                Return readUi()
            End Get
            Set(value As HyperlinkElement)
                Me._theOriginalElement = value
                Me.updateUI(value)
            End Set
        End Property

        ''' <summary>
        ''' Reads the UI.
        ''' </summary>
        ''' <returns>HyperlinkElement.</returns>
        Private Function readUi() As HyperlinkElement
            Dim theElement As HyperlinkElement = New HyperlinkElement With {
                .TheActiveHtmlElement = Me._theOriginalElement.TheActiveHtmlElement,
                .CssStyle = Me._theOriginalElement.CssStyle,
                .CssClassName = Me._theOriginalElement.CssClassName,
                .Name = Me._theOriginalElement.Name,
                .Id = Me._theOriginalElement.Id,
                .OnClickJavascript = Me._theOriginalElement.OnClickJavascript,
                .HrefUrl = txtURL.Text,
                .Title = txtToolTip.Text.Trim(),
                .InnerHtml = txtInnerHtml.Text.Trim(),
                .Target = If(chkTargetIncluded.Checked, cmbTarget.Text, Nothing)
            }

            Return theElement
        End Function

        ''' <summary>
        ''' Updates the UI.
        ''' </summary>
        ''' <param name="element">The element.</param>
        Private Sub updateUI(element As HyperlinkElement)
            If Me.IsLocalResourceSelectionDisabled Then
                rdoLocalFile.Enabled = False
                btnBrowseFile.Enabled = False
            End If

            ' Only overwrite the text fields when the element actually carries a
            ' value; otherwise we'd erase any default the customizer set on the
            ' TextBox at design time (the whole point of having a customizable
            ' sample dialog). For an existing link the element's value wins.
            If Not String.IsNullOrEmpty(element.HrefUrl) Then
                txtURL.Text = element.HrefUrl
            End If
            If element.IsRelativePathOrUrl Then
                rdoWorkingDirFile.Checked = True
            ElseIf element.IsLocalFilePath AndAlso Not Me.IsLocalResourceSelectionDisabled Then
                rdoLocalFile.Checked = True
            End If
            If Not String.IsNullOrEmpty(element.Title) Then
                txtToolTip.Text = element.Title
            End If
            cmbTarget.Text = element.Target
            chkTargetIncluded.Checked = (Not String.IsNullOrEmpty(element.Target))
            If Not String.IsNullOrEmpty(element.InnerHtml) Then
                txtInnerHtml.Text = element.InnerHtml
            End If
        End Sub

        ''' <summary>
        ''' Gets or sets a value indicating whether this instance is local resource selection disabled.
        ''' </summary>
        ''' <value><c>true</c> if this instance is local resource selection disabled; otherwise, <c>false</c>.</value>
        Public Property IsLocalResourceSelectionDisabled As Boolean Implements IHyperlinkDialog.IsLocalResourceSelectionDisabled

        ''' <summary>
        ''' Gets or sets a value indicating whether [remove link].
        ''' </summary>
        ''' <value><c>true</c> if [remove link]; otherwise, <c>false</c>.</value>
        Public Property RemoveLink As Boolean Implements IHyperlinkDialog.RemoveLink
            Get
                Return chkRemoveLink.Checked
            End Get
            Set(value As Boolean)
                chkRemoveLink.Checked = value
            End Set
        End Property

        ''' <summary>
        ''' When true, the editor sets the tooltip Title to "Ctrl+Click to view"
        ''' when the user leaves Title blank. This custom dialog has no UI for
        ''' it; honor the option as a passthrough field so the interface
        ''' contract is satisfied.
        ''' </summary>
        Public Property UseCtrlClickTooltipDefault As Boolean Implements IHyperlinkDialog.UseCtrlClickTooltipDefault

        ''' <summary>
        ''' Handles the LinkClicked event of the lnkCheck control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub lnkCheck_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCheck.LinkClicked
            Try
                Process.Start(New ProcessStartInfo(txtURL.Text, String.Empty) With {
                    .UseShellExecute = True
                })
            Catch
                'MessageBox.Show(EditorLangRes.ErrorURL, EditorLangRes.ErrorCallingURL);
            End Try
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkTargetIncluded control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkTargetIncluded_CheckedChanged(sender As Object, e As EventArgs) Handles chkTargetIncluded.CheckedChanged
            cmbTarget.Enabled = chkTargetIncluded.Checked
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnBrowseFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
            Using myDialog As OpenFileDialog = New OpenFileDialog()
                If myDialog.ShowDialog() = DialogResult.OK Then
                    txtURL.Text = myDialog.FileName
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the rdoLocalFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub rdoLocalFile_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLocalFile.CheckedChanged
            btnBrowseFile.Enabled = rdoLocalFile.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the rdoWorkingDirFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub rdoWorkingDirFile_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWorkingDirFile.CheckedChanged
            Dim isLocalDir As Boolean? = Me._theOriginalElement.IsBaseUrlALocalFolder()

            lnkImportToBaseFolder.Enabled = rdoWorkingDirFile.Enabled AndAlso rdoWorkingDirFile.Checked AndAlso
                                            isLocalDir.HasValue AndAlso isLocalDir.Value
            chkOverwrite.Enabled = rdoWorkingDirFile.Enabled AndAlso rdoWorkingDirFile.Checked AndAlso
                                   isLocalDir.HasValue AndAlso isLocalDir.Value
            lnkBrowseWD.Enabled = rdoWorkingDirFile.Enabled AndAlso rdoWorkingDirFile.Checked AndAlso
                                  isLocalDir.HasValue AndAlso isLocalDir.Value
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the lnkBrowseWD control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub lnkBrowseWD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBrowseWD.LinkClicked
            Using srcUrlDialog As OpenFileDialog = New OpenFileDialog() With {.InitialDirectory = Me._theOriginalElement.BaseUrl}
                If srcUrlDialog.ShowDialog() = DialogResult.OK Then
                    Dim directory As String = Path.GetDirectoryName(srcUrlDialog.FileName)
                    Dim baseUrl As String = Me._theOriginalElement.BaseUrl
                    If Me._theOriginalElement.BaseUrl.EndsWith("\") OrElse Me._theOriginalElement.BaseUrl.EndsWith("/") Then
                        baseUrl = Me._theOriginalElement.BaseUrl.Remove(Me._theOriginalElement.BaseUrl.Length - 1)
                    End If
                    If baseUrl.Equals(directory, StringComparison.OrdinalIgnoreCase) Then
                        txtURL.Text = Path.GetFileName(srcUrlDialog.FileName)
                    Else
                        Dim dlgResult As DialogResult = MessageBox.Show("The file you selected is not from the base directory for relative path. Do you want to import that file to your base directory ? If you choose YES, then it will be imported to the Base Directory, otherwise the link target will be treated as absolute path file.", "Selected file is not from the base directory.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                        If dlgResult = DialogResult.Yes Then
                            Dim newFilePath As String = Path.Combine(baseUrl, If(Path.GetFileName(srcUrlDialog.FileName), String.Empty))
                            Dim i As Integer = 0
                            While File.Exists(newFilePath) AndAlso (Not chkOverwrite.Checked)
                                i += 1
                                Dim newFileName As String = Path.GetFileNameWithoutExtension(srcUrlDialog.FileName) & i & Path.GetExtension(srcUrlDialog.FileName)
                                newFilePath = Path.Combine(baseUrl, newFileName)
                            End While
                            If File.Exists(newFilePath) Then
                                Try
                                    File.SetAttributes(newFilePath, FileAttributes.Normal)
                                    File.Delete(newFilePath)
                                    File.Copy(srcUrlDialog.FileName, newFilePath)
                                Catch err As Exception
                                    MessageBox.Show(err.Message, "Error copying file to the destination")
                                End Try
                            Else
                                File.Copy(srcUrlDialog.FileName, newFilePath)
                            End If
                            txtURL.Text = Path.GetFileName(newFilePath)
                        ElseIf dlgResult = DialogResult.No Then
                            txtURL.Text = srcUrlDialog.FileName
                        End If
                    End If
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the lnkImportToBaseFolder control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub lnkImportToBaseFolder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkImportToBaseFolder.LinkClicked
            Using myDialog As OpenFileDialog = New OpenFileDialog()
                If myDialog.ShowDialog() = DialogResult.OK Then
                    Dim newFilePath As String = Path.Combine(Me._theOriginalElement.BaseUrl, If(Path.GetFileName(myDialog.FileName), String.Empty))
                    Dim i As Integer = 0
                    While File.Exists(newFilePath) AndAlso (Not chkOverwrite.Checked)
                        i += 1
                        Dim newFileName As String = Path.GetFileNameWithoutExtension(myDialog.FileName) & i & Path.GetExtension(myDialog.FileName)
                        newFilePath = Path.Combine(Me._theOriginalElement.BaseUrl, newFileName)
                    End While
                    If File.Exists(newFilePath) Then
                        Try
                            File.SetAttributes(newFilePath, FileAttributes.Normal)
                            File.Delete(newFilePath)
                            File.Copy(myDialog.FileName, newFilePath)
                        Catch err As Exception
                            MessageBox.Show(err.Message, "Error copying file to the destination")
                        End Try
                    Else
                        File.Copy(myDialog.FileName, newFilePath)
                    End If
                    txtURL.Text = Path.GetFileName(newFilePath)
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles MouseMove event of the pnlRelativeUrl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        Private Sub pnlRelativeUrl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlRelativeUrl.MouseMove
            Dim parent As Control = TryCast(sender, Control)
            If parent Is Nothing Then
                Return
            End If
            Dim ctrl As Control = parent.GetChildAtPoint(e.Location)
            If ctrl IsNot Nothing Then
                If ctrl.Visible AndAlso toolTip1.Tag Is Nothing Then
                    If Not _toolTipShown Then
                        Dim tipstring As String = toolTip1.GetToolTip(ctrl)
                        toolTip1.Show(tipstring.Trim(), ctrl, ctrl.Width \ 2, ctrl.Height \ 2)
                        toolTip1.Tag = ctrl
                        _toolTipShown = True
                    End If
                End If
            Else
                ctrl = TryCast(toolTip1.Tag, Control)
                If ctrl IsNot Nothing Then
                    toolTip1.Hide(ctrl)
                    toolTip1.Tag = Nothing
                    _toolTipShown = False
                End If
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnOK control.
        ''' </summary>
        ''' <param name="sender">The event source.</param>
        ''' <param name="e">The event data.</param>
        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            If String.IsNullOrEmpty(txtURL.Text) Then
                Me.DialogResult = DialogResult.None
                MessageBox.Show("Please provide Url")
                txtURL.Focus()
            End If
        End Sub

        ' VB.NET requires an explicit Implements clause for IDialog.ShowDialog
        ' even though the WinForms Form base class already supplies a matching
        ' ShowDialog. (IDisposable.Dispose is already satisfied by Form, which
        ' implements IDisposable, so no bridge is needed for it.) C# satisfies
        ' both implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
