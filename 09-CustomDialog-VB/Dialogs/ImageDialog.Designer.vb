Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs

    Partial Public Class ImageDialog
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As IContainer

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageDialog))
            Me.txtToolTip = New System.Windows.Forms.TextBox()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnBrowseFile = New System.Windows.Forms.Button()
            Me.chkInsertLocalBase64 = New System.Windows.Forms.CheckBox()
            Me.grpToolTip = New System.Windows.Forms.GroupBox()
            Me.grpURL = New System.Windows.Forms.GroupBox()
            Me.pnlUrl = New System.Windows.Forms.Panel()
            Me.lnkImportToBaseFolder = New System.Windows.Forms.LinkLabel()
            Me.lnkBrowseWD = New System.Windows.Forms.LinkLabel()
            Me.rdoWorkingDirFile = New System.Windows.Forms.RadioButton()
            Me.chkOverwrite = New System.Windows.Forms.CheckBox()
            Me.rdoLocalFile = New System.Windows.Forms.RadioButton()
            Me.rdInternetURL = New System.Windows.Forms.RadioButton()
            Me.txtURL = New System.Windows.Forms.TextBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtAlt = New System.Windows.Forms.TextBox()
            Me.cmbAlign = New System.Windows.Forms.ComboBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.cmbBorderStyle = New System.Windows.Forms.ComboBox()
            Me.chkBorderColor = New System.Windows.Forms.CheckBox()
            Me.chkBorderStyle = New System.Windows.Forms.CheckBox()
            Me.txtBorder = New System.Windows.Forms.TextBox()
            Me.lnkBgColor = New System.Windows.Forms.LinkLabel()
            Me.chkBorderThickness = New System.Windows.Forms.CheckBox()
            Me.chkAlignment = New System.Windows.Forms.CheckBox()
            Me.txtBgColor = New System.Windows.Forms.TextBox()
            Me.groupBox4 = New System.Windows.Forms.GroupBox()
            Me.chkLockAspectRatio = New System.Windows.Forms.CheckBox()
            Me.txtHeight = New System.Windows.Forms.TextBox()
            Me.txtWidth = New System.Windows.Forms.TextBox()
            Me.chkWidth = New System.Windows.Forms.CheckBox()
            Me.chkHeight = New System.Windows.Forms.CheckBox()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.grpToolTip.SuspendLayout()
            Me.grpURL.SuspendLayout()
            Me.pnlUrl.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            ' txtToolTip
            '
            Me.txtToolTip.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtToolTip.Location = New System.Drawing.Point(3, 16)
            Me.txtToolTip.Name = "txtToolTip"
            Me.txtToolTip.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtToolTip.Size = New System.Drawing.Size(734, 20)
            Me.txtToolTip.TabIndex = 0
            '
            ' btnBrowseFile
            '
            Me.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBrowseFile.Enabled = False
            Me.btnBrowseFile.Font = New System.Drawing.Font("Verdana", 7.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBrowseFile.AutoSize = True
            Me.btnBrowseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBrowseFile.Location = New System.Drawing.Point(22, 110)
            Me.btnBrowseFile.MinimumSize = New System.Drawing.Size(90, 24)
            Me.btnBrowseFile.Name = "btnBrowseFile"
            Me.btnBrowseFile.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnBrowseFile.Size = New System.Drawing.Size(90, 24)
            Me.btnBrowseFile.TabIndex = 53
            Me.btnBrowseFile.Text = "Browse"
            Me.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.btnBrowseFile, "Browse File")
            Me.btnBrowseFile.UseVisualStyleBackColor = True
            '
            ' chkInsertLocalBase64
            '
            Me.chkInsertLocalBase64.AutoSize = True
            Me.chkInsertLocalBase64.Enabled = False
            Me.chkInsertLocalBase64.Location = New System.Drawing.Point(5, 145)
            Me.chkInsertLocalBase64.Name = "chkInsertLocalBase64"
            Me.chkInsertLocalBase64.Size = New System.Drawing.Size(160, 17)
            Me.chkInsertLocalBase64.TabIndex = 60
            Me.chkInsertLocalBase64.Text = "Insert local image as base64"
            Me.chkInsertLocalBase64.UseVisualStyleBackColor = True
            '
            ' grpToolTip
            '
            Me.grpToolTip.Controls.Add(Me.txtToolTip)
            Me.grpToolTip.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpToolTip.Location = New System.Drawing.Point(0, 195)
            Me.grpToolTip.Name = "grpToolTip"
            Me.grpToolTip.Size = New System.Drawing.Size(740, 42)
            Me.grpToolTip.TabIndex = 42
            Me.grpToolTip.TabStop = False
            Me.grpToolTip.Text = "ToolTip"
            '
            ' grpURL
            '
            Me.grpURL.Controls.Add(Me.pnlUrl)
            Me.grpURL.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpURL.Location = New System.Drawing.Point(0, 0)
            Me.grpURL.Name = "grpURL"
            Me.grpURL.Size = New System.Drawing.Size(740, 195)
            Me.grpURL.TabIndex = 40
            Me.grpURL.TabStop = False
            Me.grpURL.Text = "Picture Source URL"
            '
            ' pnlUrl
            '
            Me.pnlUrl.Controls.Add(Me.chkInsertLocalBase64)
            Me.pnlUrl.Controls.Add(Me.lnkImportToBaseFolder)
            Me.pnlUrl.Controls.Add(Me.lnkBrowseWD)
            Me.pnlUrl.Controls.Add(Me.btnBrowseFile)
            Me.pnlUrl.Controls.Add(Me.rdoWorkingDirFile)
            Me.pnlUrl.Controls.Add(Me.chkOverwrite)
            Me.pnlUrl.Controls.Add(Me.rdoLocalFile)
            Me.pnlUrl.Controls.Add(Me.rdInternetURL)
            Me.pnlUrl.Controls.Add(Me.txtURL)
            Me.pnlUrl.Location = New System.Drawing.Point(8, 17)
            Me.pnlUrl.Name = "pnlUrl"
            Me.pnlUrl.Size = New System.Drawing.Size(729, 168)
            Me.pnlUrl.TabIndex = 52
            '
            ' lnkImportToBaseFolder
            '
            Me.lnkImportToBaseFolder.AutoSize = True
            Me.lnkImportToBaseFolder.Enabled = False
            Me.lnkImportToBaseFolder.Location = New System.Drawing.Point(370, 115)
            Me.lnkImportToBaseFolder.Name = "lnkImportToBaseFolder"
            Me.lnkImportToBaseFolder.Size = New System.Drawing.Size(146, 13)
            Me.lnkImportToBaseFolder.TabIndex = 59
            Me.lnkImportToBaseFolder.TabStop = True
            Me.lnkImportToBaseFolder.Text = "Import a file to the base folder"
            '
            ' lnkBrowseWD
            '
            Me.lnkBrowseWD.AutoSize = True
            Me.lnkBrowseWD.Enabled = False
            Me.lnkBrowseWD.Location = New System.Drawing.Point(370, 81)
            Me.lnkBrowseWD.Name = "lnkBrowseWD"
            Me.lnkBrowseWD.Size = New System.Drawing.Size(82, 13)
            Me.lnkBrowseWD.TabIndex = 58
            Me.lnkBrowseWD.TabStop = True
            Me.lnkBrowseWD.Text = "Browse for a file"
            '
            ' rdoWorkingDirFile
            '
            Me.rdoWorkingDirFile.AutoSize = True
            Me.rdoWorkingDirFile.Location = New System.Drawing.Point(370, 56)
            Me.rdoWorkingDirFile.Name = "rdoWorkingDirFile"
            Me.rdoWorkingDirFile.Size = New System.Drawing.Size(119, 17)
            Me.rdoWorkingDirFile.TabIndex = 56
            Me.rdoWorkingDirFile.Text = "Relative to Base Url"
            Me.rdoWorkingDirFile.UseVisualStyleBackColor = True
            '
            ' chkOverwrite
            '
            Me.chkOverwrite.AutoSize = True
            Me.chkOverwrite.Enabled = False
            Me.chkOverwrite.Location = New System.Drawing.Point(560, 115)
            Me.chkOverwrite.Name = "chkOverwrite"
            Me.chkOverwrite.Size = New System.Drawing.Size(71, 17)
            Me.chkOverwrite.TabIndex = 57
            Me.chkOverwrite.Text = "Overwrite"
            Me.chkOverwrite.UseVisualStyleBackColor = True
            '
            ' rdoLocalFile
            '
            Me.rdoLocalFile.AutoSize = True
            Me.rdoLocalFile.Location = New System.Drawing.Point(4, 81)
            Me.rdoLocalFile.Name = "rdoLocalFile"
            Me.rdoLocalFile.Size = New System.Drawing.Size(159, 17)
            Me.rdoLocalFile.TabIndex = 55
            Me.rdoLocalFile.Text = "Local File with absolute path"
            Me.rdoLocalFile.UseVisualStyleBackColor = True
            '
            ' rdInternetURL
            '
            Me.rdInternetURL.AutoSize = True
            Me.rdInternetURL.Checked = True
            Me.rdInternetURL.Location = New System.Drawing.Point(3, 56)
            Me.rdInternetURL.Name = "rdInternetURL"
            Me.rdInternetURL.Size = New System.Drawing.Size(86, 17)
            Me.rdInternetURL.TabIndex = 54
            Me.rdInternetURL.TabStop = True
            Me.rdInternetURL.Text = "Internet URL"
            Me.rdInternetURL.UseVisualStyleBackColor = True
            '
            ' txtURL
            '
            Me.txtURL.BackColor = System.Drawing.SystemColors.Window
            Me.txtURL.Dock = System.Windows.Forms.DockStyle.Top
            Me.txtURL.Location = New System.Drawing.Point(0, 0)
            Me.txtURL.Multiline = True
            Me.txtURL.Name = "txtURL"
            Me.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtURL.Size = New System.Drawing.Size(729, 50)
            Me.txtURL.TabIndex = 52
            '
            ' groupBox1
            '
            Me.groupBox1.Controls.Add(Me.txtAlt)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupBox1.Location = New System.Drawing.Point(0, 237)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(740, 42)
            Me.groupBox1.TabIndex = 43
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Alternative Text"
            '
            ' txtAlt
            '
            Me.txtAlt.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtAlt.Location = New System.Drawing.Point(3, 16)
            Me.txtAlt.Name = "txtAlt"
            Me.txtAlt.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtAlt.Size = New System.Drawing.Size(734, 20)
            Me.txtAlt.TabIndex = 0
            '
            ' cmbAlign
            '
            Me.cmbAlign.Enabled = False
            Me.cmbAlign.FormattingEnabled = True
            Me.cmbAlign.Items.AddRange(New Object() {
            "Left",
            "Right",
            "Bottom",
            "Middle",
            "Top"})
            Me.cmbAlign.Location = New System.Drawing.Point(82, 18)
            Me.cmbAlign.Name = "cmbAlign"
            Me.cmbAlign.Size = New System.Drawing.Size(88, 21)
            Me.cmbAlign.TabIndex = 44
            '
            ' groupBox2
            '
            Me.groupBox2.Controls.Add(Me.cmbBorderStyle)
            Me.groupBox2.Controls.Add(Me.chkBorderColor)
            Me.groupBox2.Controls.Add(Me.chkBorderStyle)
            Me.groupBox2.Controls.Add(Me.txtBorder)
            Me.groupBox2.Controls.Add(Me.lnkBgColor)
            Me.groupBox2.Controls.Add(Me.chkBorderThickness)
            Me.groupBox2.Controls.Add(Me.chkAlignment)
            Me.groupBox2.Controls.Add(Me.txtBgColor)
            Me.groupBox2.Controls.Add(Me.cmbAlign)
            Me.groupBox2.Location = New System.Drawing.Point(3, 285)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(470, 70)
            Me.groupBox2.TabIndex = 46
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Layout"
            '
            ' cmbBorderStyle
            '
            Me.cmbBorderStyle.Enabled = False
            Me.cmbBorderStyle.FormattingEnabled = True
            Me.cmbBorderStyle.Items.AddRange(New Object() {
            "Dotted",
            "Dashed",
            "Solid",
            "Double",
            "Groove",
            "Ridge",
            "Inset",
            "Outset"})
            Me.cmbBorderStyle.Location = New System.Drawing.Point(370, 42)
            Me.cmbBorderStyle.Name = "cmbBorderStyle"
            Me.cmbBorderStyle.Size = New System.Drawing.Size(82, 21)
            Me.cmbBorderStyle.TabIndex = 51
            '
            ' chkBorderColor
            '
            Me.chkBorderColor.AutoSize = True
            Me.chkBorderColor.Location = New System.Drawing.Point(245, 20)
            Me.chkBorderColor.Name = "chkBorderColor"
            Me.chkBorderColor.Size = New System.Drawing.Size(15, 14)
            Me.chkBorderColor.TabIndex = 48
            Me.chkBorderColor.UseVisualStyleBackColor = True
            '
            ' chkBorderStyle
            '
            Me.chkBorderStyle.AutoSize = True
            Me.chkBorderStyle.Location = New System.Drawing.Point(245, 44)
            Me.chkBorderStyle.Name = "chkBorderStyle"
            Me.chkBorderStyle.Size = New System.Drawing.Size(83, 17)
            Me.chkBorderStyle.TabIndex = 47
            Me.chkBorderStyle.Text = "Border Style"
            Me.chkBorderStyle.UseVisualStyleBackColor = True
            '
            ' txtBorder
            '
            Me.txtBorder.Enabled = False
            Me.txtBorder.Location = New System.Drawing.Point(113, 42)
            Me.txtBorder.Name = "txtBorder"
            Me.txtBorder.Size = New System.Drawing.Size(57, 20)
            Me.txtBorder.TabIndex = 45
            '
            ' lnkBgColor
            '
            Me.lnkBgColor.AutoSize = True
            Me.lnkBgColor.Enabled = False
            Me.lnkBgColor.Location = New System.Drawing.Point(260, 21)
            Me.lnkBgColor.Name = "lnkBgColor"
            Me.lnkBgColor.Size = New System.Drawing.Size(65, 13)
            Me.lnkBgColor.TabIndex = 50
            Me.lnkBgColor.TabStop = True
            Me.lnkBgColor.Text = "Border Color"
            '
            ' chkBorderThickness
            '
            Me.chkBorderThickness.AutoSize = True
            Me.chkBorderThickness.Location = New System.Drawing.Point(7, 44)
            Me.chkBorderThickness.Name = "chkBorderThickness"
            Me.chkBorderThickness.Size = New System.Drawing.Size(109, 17)
            Me.chkBorderThickness.TabIndex = 1
            Me.chkBorderThickness.Text = "Border Thickness"
            Me.chkBorderThickness.UseVisualStyleBackColor = True
            '
            ' chkAlignment
            '
            Me.chkAlignment.AutoSize = True
            Me.chkAlignment.Location = New System.Drawing.Point(7, 20)
            Me.chkAlignment.Name = "chkAlignment"
            Me.chkAlignment.Size = New System.Drawing.Size(72, 17)
            Me.chkAlignment.TabIndex = 0
            Me.chkAlignment.Text = "Alignment"
            Me.chkAlignment.UseVisualStyleBackColor = True
            '
            ' txtBgColor
            '
            Me.txtBgColor.BackColor = System.Drawing.Color.White
            Me.txtBgColor.Enabled = False
            Me.txtBgColor.Location = New System.Drawing.Point(370, 17)
            Me.txtBgColor.Name = "txtBgColor"
            Me.txtBgColor.ReadOnly = True
            Me.txtBgColor.Size = New System.Drawing.Size(95, 20)
            Me.txtBgColor.TabIndex = 49
            '
            ' groupBox4
            '
            Me.groupBox4.Controls.Add(Me.chkLockAspectRatio)
            Me.groupBox4.Controls.Add(Me.txtHeight)
            Me.groupBox4.Controls.Add(Me.txtWidth)
            Me.groupBox4.Controls.Add(Me.chkWidth)
            Me.groupBox4.Controls.Add(Me.chkHeight)
            Me.groupBox4.AutoSize = True
            Me.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.groupBox4.Location = New System.Drawing.Point(479, 285)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(255, 95)
            Me.groupBox4.TabIndex = 48
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Size"
            '
            ' chkLockAspectRatio
            '
            Me.chkLockAspectRatio.AutoSize = True
            Me.chkLockAspectRatio.Checked = True
            Me.chkLockAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkLockAspectRatio.Location = New System.Drawing.Point(6, 19)
            Me.chkLockAspectRatio.Name = "chkLockAspectRatio"
            Me.chkLockAspectRatio.Size = New System.Drawing.Size(114, 17)
            Me.chkLockAspectRatio.TabIndex = 48
            Me.chkLockAspectRatio.Text = "Lock Aspect Ratio"
            Me.chkLockAspectRatio.UseVisualStyleBackColor = True
            '
            ' txtHeight
            '
            Me.txtHeight.Enabled = False
            Me.txtHeight.Location = New System.Drawing.Point(110, 42)
            Me.txtHeight.Name = "txtHeight"
            Me.txtHeight.Size = New System.Drawing.Size(57, 20)
            Me.txtHeight.TabIndex = 46
            '
            ' txtWidth
            '
            Me.txtWidth.Enabled = False
            Me.txtWidth.Location = New System.Drawing.Point(110, 67)
            Me.txtWidth.Name = "txtWidth"
            Me.txtWidth.Size = New System.Drawing.Size(57, 20)
            Me.txtWidth.TabIndex = 47
            '
            ' chkWidth
            '
            Me.chkWidth.AutoSize = True
            Me.chkWidth.Location = New System.Drawing.Point(6, 67)
            Me.chkWidth.Name = "chkWidth"
            Me.chkWidth.Size = New System.Drawing.Size(54, 17)
            Me.chkWidth.TabIndex = 2
            Me.chkWidth.Text = "Width"
            Me.chkWidth.UseVisualStyleBackColor = True
            '
            ' chkHeight
            '
            Me.chkHeight.AutoSize = True
            Me.chkHeight.Location = New System.Drawing.Point(6, 44)
            Me.chkHeight.Name = "chkHeight"
            Me.chkHeight.Size = New System.Drawing.Size(57, 17)
            Me.chkHeight.TabIndex = 1
            Me.chkHeight.Text = "Height"
            Me.chkHeight.UseVisualStyleBackColor = True
            '
            ' btnCancel
            '
            Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancel.Location = New System.Drawing.Point(647, 401)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 23)
            Me.btnCancel.TabIndex = 38
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            ' btnOK
            '
            Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.Location = New System.Drawing.Point(557, 401)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 23)
            Me.btnOK.TabIndex = 37
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            ' ImageDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(740, 436)
            Me.Controls.Add(Me.groupBox4)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.grpToolTip)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.grpURL)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ImageDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Image Insert Dialog"
            Me.grpToolTip.ResumeLayout(False)
            Me.grpToolTip.PerformLayout()
            Me.grpURL.ResumeLayout(False)
            Me.pnlUrl.ResumeLayout(False)
            Me.pnlUrl.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private toolTip1 As ToolTip
        Private txtToolTip As TextBox
        Private grpToolTip As GroupBox
        Private btnCancel As Button
        Private WithEvents btnOK As Button
        Private grpURL As GroupBox
        Private groupBox1 As GroupBox
        Private txtAlt As TextBox
        Private cmbAlign As ComboBox
        Private groupBox2 As GroupBox
        Private txtBorder As TextBox
        Private WithEvents chkBorderThickness As CheckBox
        Private WithEvents chkAlignment As CheckBox
        Private groupBox4 As GroupBox
        Private WithEvents txtWidth As TextBox
        Private WithEvents txtHeight As TextBox
        Private WithEvents chkWidth As CheckBox
        Private WithEvents chkHeight As CheckBox
        Private WithEvents chkBorderStyle As CheckBox
        Private cmbBorderStyle As ComboBox
        Private WithEvents chkBorderColor As CheckBox
        Private WithEvents lnkBgColor As LinkLabel
        Private txtBgColor As TextBox
        Private chkLockAspectRatio As CheckBox
        Private WithEvents pnlUrl As Panel
        Private WithEvents lnkImportToBaseFolder As LinkLabel
        Private WithEvents lnkBrowseWD As LinkLabel
        Private WithEvents btnBrowseFile As Button
        Private WithEvents rdoWorkingDirFile As RadioButton
        Private chkOverwrite As CheckBox
        Private WithEvents rdoLocalFile As RadioButton
        Private WithEvents rdInternetURL As RadioButton
        Private txtURL As TextBox
        Private WithEvents chkInsertLocalBase64 As CheckBox
    End Class

End Namespace
