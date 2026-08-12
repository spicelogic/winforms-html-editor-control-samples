Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.Abstractions.Entities
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Class ImageDialog
    ''' </summary>
    Partial Public Class ImageDialog
        Inherits DialogBase
        Implements IImageDialog

        ''' <summary>
        ''' The _the original element
        ''' </summary>
        Private _theOriginalElement As ImageElement
        ''' <summary>
        ''' The _width to height aspect ratio
        ''' </summary>
        Private _widthToHeightAspectRatio As Single?

        ''' <summary>
        ''' Whether toolTip1 is shown
        ''' </summary>
        Private _toolTipShown As Boolean = False


        ''' <summary>
        ''' Initializes a new instance of the <see cref="ImageDialog" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ImageInsertDialog control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub ImageInsertDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If String.IsNullOrEmpty(Me._theOriginalElement.BaseUrl) Then
                rdoWorkingDirFile.Enabled = False
                toolTip1.SetToolTip(rdoWorkingDirFile, "You need to set Base Url in order to use this option")
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btnBrowseFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
            Using srcUrlDialog As OpenFileDialog = New OpenFileDialog() With {
                .RestoreDirectory = True,
                .Filter = "Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*",
                .FilterIndex = 0,
                .Multiselect = False
            }
                If srcUrlDialog.ShowDialog() = DialogResult.OK Then
                    txtURL.Text = srcUrlDialog.FileName
                    Dim imageFileName As String = srcUrlDialog.FileName
                    setImageDimensionaAndAspectRatio(imageFileName)
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

            lnkImportToBaseFolder.Enabled = rdoWorkingDirFile.Enabled AndAlso rdoWorkingDirFile.Checked AndAlso isLocalDir.HasValue AndAlso isLocalDir.Value
            chkOverwrite.Enabled = rdoWorkingDirFile.Enabled AndAlso rdoWorkingDirFile.Checked AndAlso isLocalDir.HasValue AndAlso isLocalDir.Value
            lnkBrowseWD.Enabled = rdoWorkingDirFile.Enabled AndAlso rdoWorkingDirFile.Checked AndAlso isLocalDir.HasValue AndAlso isLocalDir.Value
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the lnkBrowseWD control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        ''' <exception cref="System.Exception">File doesn't exist</exception>
        Private Sub lnkBrowseWD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBrowseWD.LinkClicked
            Using srcUrlDialog As OpenFileDialog = New OpenFileDialog() With {
                .RestoreDirectory = True,
                .Filter = "Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*",
                .FilterIndex = 0,
                .Multiselect = False,
                .InitialDirectory = Me._theOriginalElement.BaseUrl
            }
                If srcUrlDialog.ShowDialog() = DialogResult.OK Then
                    Dim baseUrl As String = If(Me._theOriginalElement.BaseUrl, String.Empty)
                    If baseUrl.EndsWith("\") OrElse baseUrl.EndsWith("/") Then
                        baseUrl = baseUrl.Remove(baseUrl.Length - 1)
                    End If

                    Dim selectedFileDirectory As String = Path.GetDirectoryName(srcUrlDialog.FileName)
                    If selectedFileDirectory Is Nothing Then
                        Return
                    End If

                    If selectedFileDirectory.StartsWith(baseUrl, StringComparison.OrdinalIgnoreCase) Then
                        Dim relativePath As String = srcUrlDialog.FileName.Replace(baseUrl, "")
                        If relativePath.StartsWith("\") Then
                            relativePath = relativePath.Remove(0, 1)
                        End If

                        txtURL.Text = relativePath
                    Else
                        Dim dlgResult As DialogResult = MessageBox.Show("The image you selected is not from the base directory for relative path. Do you want to import that file to your base directory ? If you choose YES, then it will be imported to the Base Directory, otherwise it will be treated as absolute path image file.", "Selected image is not from the base directory.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                        If dlgResult = DialogResult.Yes Then
                            Dim newFilePath As String = Path.Combine(baseUrl, If(Path.GetFileName(srcUrlDialog.FileName), String.Empty))
                            Dim i As Integer = 0
                            While File.Exists(newFilePath) AndAlso Not chkOverwrite.Checked
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

                    If Not String.IsNullOrEmpty(txtURL.Text) Then
                        Dim fullImagePath As String = If(File.Exists(txtURL.Text), txtURL.Text, Path.Combine(baseUrl, txtURL.Text))
                        If File.Exists(fullImagePath) Then
                            setImageDimensionaAndAspectRatio(fullImagePath)
                        Else
                            Throw New Exception("File doesn't exist")
                        End If
                    End If
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkAlignment control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkAlignment_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlignment.CheckedChanged
            cmbAlign.Enabled = chkAlignment.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkBorderThickness control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkBorderThickness_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorderThickness.CheckedChanged
            txtBorder.Enabled = chkBorderThickness.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkHeight control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkHeight_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeight.CheckedChanged
            txtHeight.Enabled = chkHeight.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkWidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkWidth.CheckedChanged
            txtWidth.Enabled = chkWidth.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkBorderColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkBorderColor_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorderColor.CheckedChanged
            lnkBgColor.Enabled = chkBorderColor.Checked
            txtBgColor.Enabled = chkBorderColor.Checked
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the lnkBgColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub lnkBgColor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBgColor.LinkClicked
            Using myDialog As ColorDialog = New ColorDialog() With {.AllowFullOpen = True, .AnyColor = True}
                If myDialog.ShowDialog() = DialogResult.OK Then
                    txtBgColor.BackColor = myDialog.Color
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkBorderStyle control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkBorderStyle_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorderStyle.CheckedChanged
            cmbBorderStyle.Enabled = chkBorderStyle.Checked
        End Sub

        ''' <summary>
        ''' Handles the TextChanged event of the txtHeight control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
            If txtHeight.Focused AndAlso chkLockAspectRatio.Checked AndAlso (Me._widthToHeightAspectRatio.HasValue AndAlso Me._widthToHeightAspectRatio.Value > 0) Then
                Try
                    Dim value As String = txtHeight.Text
                    Dim digitPart As String = Nothing
                    Dim unitPart As String = Nothing
                    getValueAndUnit(value, digitPart, unitPart)

                    If digitPart.Length > 0 Then
                        Dim height As Single = Single.Parse(digitPart)
                        If height > 0 Then
                            Dim width As Single = Me._widthToHeightAspectRatio.Value * height
                            txtWidth.Text = CInt(Math.Round(width)) & unitPart
                        End If
                    End If
                Catch
                    ' ignored
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Handles the TextChanged event of the txtWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
            If txtWidth.Focused AndAlso chkLockAspectRatio.Checked AndAlso (Me._widthToHeightAspectRatio.HasValue AndAlso Me._widthToHeightAspectRatio.Value > 0) Then
                Try
                    Dim value As String = txtWidth.Text
                    Dim digitPart As String = Nothing
                    Dim unitPart As String = Nothing
                    getValueAndUnit(value, digitPart, unitPart)

                    If digitPart.Length > 0 Then
                        Dim width As Single = Single.Parse(digitPart)
                        If width > 0 Then
                            Dim height As Single = width / Me._widthToHeightAspectRatio.Value
                            txtHeight.Text = CInt(Math.Round(height)) & unitPart
                        End If
                    End If
                Catch
                    ' ignored
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the lnkImportToBaseFolder control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub lnkImportToBaseFolder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkImportToBaseFolder.LinkClicked
            Using myDialog As OpenFileDialog = New OpenFileDialog() With {.RestoreDirectory = True, .Filter = "Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*", .FilterIndex = 0, .Multiselect = False}
                If myDialog.ShowDialog() = DialogResult.OK Then
                    Dim newFilePath As String = Path.Combine(Me._theOriginalElement.BaseUrl, If(Path.GetFileName(myDialog.FileName), String.Empty))
                    Dim i As Integer = 0
                    While File.Exists(newFilePath) AndAlso Not chkOverwrite.Checked
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
        ''' Gets or sets the element.
        ''' </summary>
        ''' <value>The element.</value>
        Public Property Element As ImageElement Implements IImageDialog.Element
            Get
                Return readUi()
            End Get
            Set(value As ImageElement)
                Me._theOriginalElement = value
                Me.updateUi(value)
            End Set
        End Property

        ''' <summary>
        ''' Reads the UI.
        ''' </summary>
        ''' <returns>ImageElement.</returns>
        Private Function readUi() As ImageElement
            Dim src As String = Nothing

            If chkInsertLocalBase64.Checked Then
                Try
                    If File.Exists(txtURL.Text) Then
                        src = ImageElement.GetBase64DataUrlForLocalImage(txtURL.Text)
                    End If
                Catch __ex As Exception
                    ' ignored
                End Try
            End If

            Dim theElement As ImageElement = New ImageElement With {
                .TheActiveHtmlElement = Me._theOriginalElement.TheActiveHtmlElement,
                .CssStyle = Me._theOriginalElement.CssStyle,
                .CssClassName = Me._theOriginalElement.CssClassName,
                .Name = Me._theOriginalElement.Name,
                .Id = Me._theOriginalElement.Id,
                .OnClickJavascript = Me._theOriginalElement.OnClickJavascript,
                .SrcUrl = If(src, txtURL.Text)
            }

            If chkWidth.Checked Then
                theElement.Width = txtWidth.Text.Trim()
            End If
            If chkHeight.Checked Then
                theElement.Height = txtHeight.Text.Trim()
            End If
            If chkBorderColor.Checked Then
                theElement.BorderColor = txtBgColor.BackColor
            End If
            If chkBorderStyle.Checked Then
                theElement.BorderStyle = cmbBorderStyle.Text
            End If
            If chkBorderThickness.Checked AndAlso Not String.IsNullOrEmpty(txtBorder.Text) Then
                theElement.Border = Convert.ToInt32(txtBorder.Text)
            End If
            theElement.Title = txtToolTip.Text.Trim()
            theElement.AlternativeText = txtAlt.Text.Trim()
            If chkAlignment.Checked AndAlso Not String.IsNullOrEmpty(cmbAlign.Text) Then
                theElement.Align = cmbAlign.Text
            End If
            Return theElement
        End Function

        ''' <summary>
        ''' Updates the UI.
        ''' </summary>
        ''' <param name="element">The element.</param>
        Private Sub updateUi(element As ImageElement)
            If Me.IsLocalResourceSelectionDisabled Then
                rdoLocalFile.Enabled = False
                btnBrowseFile.Enabled = False
            End If

            ' Spec 019 FR-009: preserve design-time defaults on empty fields.
            If Not String.IsNullOrEmpty(element.SrcUrl) Then
                txtURL.Text = element.SrcUrl
            End If
            If element.IsRelativePathOrUrl Then
                rdoWorkingDirFile.Checked = True
            ElseIf element.IsLocalFilePath AndAlso Not Me.IsLocalResourceSelectionDisabled Then
                rdoLocalFile.Checked = True
            End If
            If Not String.IsNullOrEmpty(element.Title) Then
                txtToolTip.Text = element.Title
            End If
            If Not String.IsNullOrEmpty(element.AlternativeText) Then
                txtAlt.Text = element.AlternativeText
            End If
            If Not String.IsNullOrEmpty(element.Align) Then
                cmbAlign.Text = element.Align
                chkAlignment.Checked = True
            End If
            If element.Border.HasValue Then
                txtBorder.Text = element.Border.Value.ToString(CultureInfo.InvariantCulture)
                chkBorderThickness.Checked = True
            End If
            If Not String.IsNullOrEmpty(element.Width) Then
                txtWidth.Text = element.Width
                chkWidth.Checked = True
            End If
            If Not String.IsNullOrEmpty(element.Height) Then
                txtHeight.Text = element.Height
                chkHeight.Checked = True
            End If
            If element.BorderColor.HasValue Then
                chkBorderColor.Checked = True
                txtBgColor.BackColor = element.BorderColor.Value
            End If
            If Not String.IsNullOrEmpty(element.BorderStyle) Then
                chkBorderStyle.Checked = True
                cmbBorderStyle.Text = element.BorderStyle
            End If

            If chkHeight.Checked AndAlso chkWidth.Checked Then
                Try
                    Dim unit As String = Nothing
                    Dim widthDigitPart As String = Nothing
                    getValueAndUnit(txtWidth.Text, widthDigitPart, unit)

                    Dim heightDigitPart As String = Nothing
                    getValueAndUnit(txtHeight.Text, heightDigitPart, unit)
                    If widthDigitPart.Length > 0 AndAlso heightDigitPart.Length > 0 Then
                        Dim width As Single = Single.Parse(widthDigitPart)
                        Dim height As Single = Single.Parse(heightDigitPart)
                        If width > 0 AndAlso height > 0 Then
                            Me._widthToHeightAspectRatio = width / height
                        Else
                            Me._widthToHeightAspectRatio = Nothing
                        End If
                    End If
                Catch
                    Me._widthToHeightAspectRatio = Nothing
                End Try
            Else
                Me._widthToHeightAspectRatio = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Sets the image dimensiona and aspect ratio.
        ''' </summary>
        ''' <param name="imageFileName">Name of the image file.</param>
        Private Sub setImageDimensionaAndAspectRatio(imageFileName As String)
            Dim theImageDimension As Size? = ImageUtils.GetImageDimension(imageFileName)
            If theImageDimension.HasValue Then
                chkHeight.Checked = True
                txtHeight.Text = theImageDimension.Value.Height.ToString(CultureInfo.InvariantCulture)
                chkWidth.Checked = True
                txtWidth.Text = theImageDimension.Value.Width.ToString(CultureInfo.InvariantCulture)
                If theImageDimension.Value.Width > 0 AndAlso theImageDimension.Value.Height > 0 Then
                    Me._widthToHeightAspectRatio = theImageDimension.Value.Width / CSng(theImageDimension.Value.Height)
                Else
                    Me._widthToHeightAspectRatio = Nothing
                End If
            Else
                Me._widthToHeightAspectRatio = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Gets the value and unit.
        ''' </summary>
        ''' <param name="value">The value.</param>
        ''' <param name="digitPart">The digit part.</param>
        ''' <param name="unitPart">The unit part.</param>
        Private Shared Sub getValueAndUnit(value As String, ByRef digitPart As String, ByRef unitPart As String)
            Const digitRegEx As String = "\d+"
            digitPart = Regex.Match(value, digitRegEx, RegexOptions.IgnoreCase Or RegexOptions.Compiled).Groups(0).Value
            unitPart = value.Replace(digitPart, "").Trim()
        End Sub

        ''' <summary>
        ''' Gets or sets a value indicating whether this instance is local resource selection disabled.
        ''' </summary>
        ''' <value><c>true</c> if this instance is local resource selection disabled; otherwise, <c>false</c>.</value>
        Public Property IsLocalResourceSelectionDisabled As Boolean Implements IImageDialog.IsLocalResourceSelectionDisabled

        ''' <summary>
        ''' When true, the Image dialog writes width/height as inline CSS in
        ''' CssStyle ("style=width:240px;height:120px") instead of HTML
        ''' width=/height= attributes. Passthrough auto-property so this custom
        ''' dialog satisfies the interface contract.
        ''' </summary>
        Public Property UseInlineStyleForDimensions As Boolean Implements IImageDialog.UseInlineStyleForDimensions

        ''' <summary>
        ''' Handles MouseMove event of the pnlRelativeUrl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        Private Sub pnlUrl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlUrl.MouseMove
            Dim parent As Control = TryCast(sender, Control)
            If parent Is Nothing Then
                Return
            End If

            Dim ctrl As Control = parent.GetChildAtPoint(e.Location)
            If ctrl IsNot Nothing Then
                If ctrl.Visible AndAlso toolTip1.Tag Is Nothing AndAlso Not _toolTipShown Then
                    Dim tipstring As String = toolTip1.GetToolTip(ctrl)
                    toolTip1.Show(tipstring.Trim(), ctrl, ctrl.Width \ 2, ctrl.Height \ 2)
                    toolTip1.Tag = ctrl
                    _toolTipShown = True
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
        ''' Handles Click event of the btnOK control.
        ''' </summary>
        ''' <param name="sender">The event source.</param>
        ''' <param name="e">The event data.</param>
        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            If String.IsNullOrEmpty(txtURL.Text) Then
                Me.DialogResult = DialogResult.None
                MessageBox.Show("Please provide Image Url")
                txtURL.Focus()
            End If
        End Sub

        ''' <summary>
        ''' Handles CheckedChanged event of rdInternetURL control.
        ''' </summary>
        ''' <param name="sender">The event sender.</param>
        ''' <param name="e">The event argument.</param>
        Private Sub rdInternetURL_CheckedChanged(sender As Object, e As EventArgs) Handles rdInternetURL.CheckedChanged
            If rdInternetURL.Checked Then
                chkInsertLocalBase64.Checked = False
            End If

            chkInsertLocalBase64.Enabled = Not rdInternetURL.Checked
        End Sub

        ''' <summary>
        ''' Handles VisibleChanged event of chkInsertLocalBase64 control.
        ''' </summary>
        ''' <param name="sender">The event sender.</param>
        ''' <param name="e">The event argument.</param>
        Private Sub chkInsertLocalBase64_VisibleChanged(sender As Object, e As EventArgs) Handles chkInsertLocalBase64.VisibleChanged
            If Me.Visible Then
                chkInsertLocalBase64.Checked = False
            End If
        End Sub

        ' VB.NET requires explicit interface implementation for the IDialog
        ' members the WinForms Form base class supplies (ShowDialog from
        ' IDialog, Dispose from IDisposable). C# satisfies these implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
