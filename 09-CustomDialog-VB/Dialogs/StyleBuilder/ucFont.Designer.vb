Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucFont
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As IContainer = Nothing

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

#Region "Component Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gbFontName = New System.Windows.Forms.GroupBox()
            Me.btFontFamilySelect = New System.Windows.Forms.Button()
            Me.rbSystemFont = New System.Windows.Forms.RadioButton()
            Me.rbFamily = New System.Windows.Forms.RadioButton()
            Me.cbSystemFont = New System.Windows.Forms.ComboBox()
            Me.tbFontFamily = New System.Windows.Forms.TextBox()
            Me.gbFontAttributes = New System.Windows.Forms.GroupBox()
            Me.txtForeColor = New System.Windows.Forms.TextBox()
            Me.cbFontVariant = New System.Windows.Forms.ComboBox()
            Me.cbFontStyle = New System.Windows.Forms.ComboBox()
            Me.gbSize = New System.Windows.Forms.GroupBox()
            Me.rbSizeRelative = New System.Windows.Forms.RadioButton()
            Me.cbRelativeSize = New System.Windows.Forms.ComboBox()
            Me.cbAbsoluteSize = New System.Windows.Forms.ComboBox()
            Me.rbSizeAbsolute = New System.Windows.Forms.RadioButton()
            Me.cbSpecificSizeType = New System.Windows.Forms.ComboBox()
            Me.tbSpecificSize = New System.Windows.Forms.TextBox()
            Me.rbSizeSpecific = New System.Windows.Forms.RadioButton()
            Me.gbEffects = New System.Windows.Forms.GroupBox()
            Me.cbEffectOverline = New System.Windows.Forms.CheckBox()
            Me.cbEffectUnderline = New System.Windows.Forms.CheckBox()
            Me.cbEffectStrikethrough = New System.Windows.Forms.CheckBox()
            Me.cbEffectNone = New System.Windows.Forms.CheckBox()
            Me.dlgColorPicker = New System.Windows.Forms.ColorDialog()
            Me.gbBold = New System.Windows.Forms.GroupBox()
            Me.rbBoldRelative = New System.Windows.Forms.RadioButton()
            Me.rbBoldAbsolute = New System.Windows.Forms.RadioButton()
            Me.cbBoldRelative = New System.Windows.Forms.ComboBox()
            Me.cbBoldAbsolute = New System.Windows.Forms.ComboBox()
            Me.gbCapitalization = New System.Windows.Forms.GroupBox()
            Me.cbCapitalization = New System.Windows.Forms.ComboBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.gbFontName.SuspendLayout()
            Me.gbFontAttributes.SuspendLayout()
            Me.gbSize.SuspendLayout()
            Me.gbEffects.SuspendLayout()
            Me.gbBold.SuspendLayout()
            Me.gbCapitalization.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            ' gbFontName
            '
            Me.gbFontName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbFontName.Controls.Add(Me.btFontFamilySelect)
            Me.gbFontName.Controls.Add(Me.rbSystemFont)
            Me.gbFontName.Controls.Add(Me.rbFamily)
            Me.gbFontName.Controls.Add(Me.cbSystemFont)
            Me.gbFontName.Controls.Add(Me.tbFontFamily)
            Me.gbFontName.Location = New System.Drawing.Point(3, 3)
            Me.gbFontName.Name = "gbFontName"
            Me.gbFontName.Size = New System.Drawing.Size(454, 77)
            Me.gbFontName.TabIndex = 0
            Me.gbFontName.TabStop = False
            Me.gbFontName.Text = "&Font name"
            '
            ' btFontFamilySelect
            '
            Me.btFontFamilySelect.Location = New System.Drawing.Point(368, 21)
            Me.btFontFamilySelect.Name = "btFontFamilySelect"
            Me.btFontFamilySelect.Size = New System.Drawing.Size(37, 23)
            Me.btFontFamilySelect.TabIndex = 2
            Me.btFontFamilySelect.Text = "..."
            Me.btFontFamilySelect.UseVisualStyleBackColor = True
            '
            ' rbSystemFont
            '
            Me.rbSystemFont.AutoSize = True
            Me.rbSystemFont.Location = New System.Drawing.Point(6, 51)
            Me.rbSystemFont.Name = "rbSystemFont"
            Me.rbSystemFont.Size = New System.Drawing.Size(83, 17)
            Me.rbSystemFont.TabIndex = 3
            Me.rbSystemFont.Text = "System font:"
            Me.rbSystemFont.UseVisualStyleBackColor = True
            '
            ' rbFamily
            '
            Me.rbFamily.AutoSize = True
            Me.rbFamily.Checked = True
            Me.rbFamily.Location = New System.Drawing.Point(6, 20)
            Me.rbFamily.Name = "rbFamily"
            Me.rbFamily.Size = New System.Drawing.Size(54, 17)
            Me.rbFamily.TabIndex = 0
            Me.rbFamily.TabStop = True
            Me.rbFamily.Text = "Family"
            Me.rbFamily.UseVisualStyleBackColor = True
            '
            ' cbSystemFont
            '
            Me.cbSystemFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSystemFont.FormattingEnabled = True
            Me.cbSystemFont.Location = New System.Drawing.Point(95, 50)
            Me.cbSystemFont.Name = "cbSystemFont"
            Me.cbSystemFont.Size = New System.Drawing.Size(310, 21)
            Me.cbSystemFont.TabIndex = 4
            '
            ' tbFontFamily
            '
            Me.tbFontFamily.Location = New System.Drawing.Point(95, 21)
            Me.tbFontFamily.Name = "tbFontFamily"
            Me.tbFontFamily.Size = New System.Drawing.Size(267, 20)
            Me.tbFontFamily.TabIndex = 1
            '
            ' gbFontAttributes
            '
            Me.gbFontAttributes.Controls.Add(Me.txtForeColor)
            Me.gbFontAttributes.Location = New System.Drawing.Point(9, 122)
            Me.gbFontAttributes.Name = "gbFontAttributes"
            Me.gbFontAttributes.Size = New System.Drawing.Size(49, 39)
            Me.gbFontAttributes.TabIndex = 1
            Me.gbFontAttributes.TabStop = False
            Me.gbFontAttributes.Text = "Color"
            '
            ' txtForeColor
            '
            Me.txtForeColor.BackColor = System.Drawing.Color.Black
            Me.txtForeColor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtForeColor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtForeColor.Location = New System.Drawing.Point(3, 16)
            Me.txtForeColor.Name = "txtForeColor"
            Me.txtForeColor.ReadOnly = True
            Me.txtForeColor.Size = New System.Drawing.Size(43, 20)
            Me.txtForeColor.TabIndex = 7
            '
            ' cbFontVariant
            '
            Me.cbFontVariant.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cbFontVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbFontVariant.FormattingEnabled = True
            Me.cbFontVariant.Location = New System.Drawing.Point(3, 16)
            Me.cbFontVariant.Name = "cbFontVariant"
            Me.cbFontVariant.Size = New System.Drawing.Size(80, 21)
            Me.cbFontVariant.TabIndex = 6
            '
            ' cbFontStyle
            '
            Me.cbFontStyle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cbFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbFontStyle.FormattingEnabled = True
            Me.cbFontStyle.Location = New System.Drawing.Point(3, 16)
            Me.cbFontStyle.Name = "cbFontStyle"
            Me.cbFontStyle.Size = New System.Drawing.Size(109, 21)
            Me.cbFontStyle.TabIndex = 4
            '
            ' gbSize
            '
            Me.gbSize.Controls.Add(Me.rbSizeRelative)
            Me.gbSize.Controls.Add(Me.cbRelativeSize)
            Me.gbSize.Controls.Add(Me.cbAbsoluteSize)
            Me.gbSize.Controls.Add(Me.rbSizeAbsolute)
            Me.gbSize.Controls.Add(Me.cbSpecificSizeType)
            Me.gbSize.Controls.Add(Me.tbSpecificSize)
            Me.gbSize.Controls.Add(Me.rbSizeSpecific)
            Me.gbSize.Location = New System.Drawing.Point(3, 207)
            Me.gbSize.Name = "gbSize"
            Me.gbSize.Size = New System.Drawing.Size(215, 110)
            Me.gbSize.TabIndex = 2
            Me.gbSize.TabStop = False
            Me.gbSize.Text = "&Size"
            '
            ' rbSizeRelative
            '
            Me.rbSizeRelative.AutoSize = True
            Me.rbSizeRelative.Location = New System.Drawing.Point(6, 74)
            Me.rbSizeRelative.Name = "rbSizeRelative"
            Me.rbSizeRelative.Size = New System.Drawing.Size(64, 17)
            Me.rbSizeRelative.TabIndex = 5
            Me.rbSizeRelative.TabStop = True
            Me.rbSizeRelative.Text = "Relative"
            Me.rbSizeRelative.UseVisualStyleBackColor = True
            '
            ' cbRelativeSize
            '
            Me.cbRelativeSize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbRelativeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbRelativeSize.FormattingEnabled = True
            Me.cbRelativeSize.Items.AddRange(New Object() {
            "Larger",
            "Smaller"})
            Me.cbRelativeSize.Location = New System.Drawing.Point(95, 73)
            Me.cbRelativeSize.Name = "cbRelativeSize"
            Me.cbRelativeSize.Size = New System.Drawing.Size(114, 21)
            Me.cbRelativeSize.TabIndex = 6
            '
            ' cbAbsoluteSize
            '
            Me.cbAbsoluteSize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbAbsoluteSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAbsoluteSize.FormattingEnabled = True
            Me.cbAbsoluteSize.Items.AddRange(New Object() {
            "XX-Small",
            "X-Small",
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "XX-Large"})
            Me.cbAbsoluteSize.Location = New System.Drawing.Point(95, 46)
            Me.cbAbsoluteSize.Name = "cbAbsoluteSize"
            Me.cbAbsoluteSize.Size = New System.Drawing.Size(114, 21)
            Me.cbAbsoluteSize.TabIndex = 4
            '
            ' rbSizeAbsolute
            '
            Me.rbSizeAbsolute.AutoSize = True
            Me.rbSizeAbsolute.Location = New System.Drawing.Point(6, 47)
            Me.rbSizeAbsolute.Name = "rbSizeAbsolute"
            Me.rbSizeAbsolute.Size = New System.Drawing.Size(66, 17)
            Me.rbSizeAbsolute.TabIndex = 3
            Me.rbSizeAbsolute.TabStop = True
            Me.rbSizeAbsolute.Text = "Absolute"
            Me.rbSizeAbsolute.UseVisualStyleBackColor = True
            '
            ' cbSpecificSizeType
            '
            Me.cbSpecificSizeType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbSpecificSizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSpecificSizeType.FormattingEnabled = True
            Me.cbSpecificSizeType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbSpecificSizeType.Location = New System.Drawing.Point(144, 19)
            Me.cbSpecificSizeType.Name = "cbSpecificSizeType"
            Me.cbSpecificSizeType.Size = New System.Drawing.Size(65, 21)
            Me.cbSpecificSizeType.TabIndex = 2
            '
            ' tbSpecificSize
            '
            Me.tbSpecificSize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbSpecificSize.Location = New System.Drawing.Point(95, 19)
            Me.tbSpecificSize.Name = "tbSpecificSize"
            Me.tbSpecificSize.Size = New System.Drawing.Size(43, 20)
            Me.tbSpecificSize.TabIndex = 1
            '
            ' rbSizeSpecific
            '
            Me.rbSizeSpecific.AutoSize = True
            Me.rbSizeSpecific.Checked = True
            Me.rbSizeSpecific.Location = New System.Drawing.Point(6, 20)
            Me.rbSizeSpecific.Name = "rbSizeSpecific"
            Me.rbSizeSpecific.Size = New System.Drawing.Size(63, 17)
            Me.rbSizeSpecific.TabIndex = 0
            Me.rbSizeSpecific.TabStop = True
            Me.rbSizeSpecific.Text = "Specific"
            Me.rbSizeSpecific.UseVisualStyleBackColor = True
            '
            ' gbEffects
            '
            Me.gbEffects.Controls.Add(Me.cbEffectOverline)
            Me.gbEffects.Controls.Add(Me.cbEffectUnderline)
            Me.gbEffects.Controls.Add(Me.cbEffectStrikethrough)
            Me.gbEffects.Controls.Add(Me.cbEffectNone)
            Me.gbEffects.Location = New System.Drawing.Point(347, 189)
            Me.gbEffects.Name = "gbEffects"
            Me.gbEffects.Size = New System.Drawing.Size(98, 128)
            Me.gbEffects.TabIndex = 3
            Me.gbEffects.TabStop = False
            Me.gbEffects.Text = "Effects"
            '
            ' cbEffectOverline
            '
            Me.cbEffectOverline.AutoSize = True
            Me.cbEffectOverline.Location = New System.Drawing.Point(6, 85)
            Me.cbEffectOverline.Name = "cbEffectOverline"
            Me.cbEffectOverline.Size = New System.Drawing.Size(65, 17)
            Me.cbEffectOverline.TabIndex = 3
            Me.cbEffectOverline.Text = "Overline"
            Me.cbEffectOverline.UseVisualStyleBackColor = True
            '
            ' cbEffectUnderline
            '
            Me.cbEffectUnderline.AutoSize = True
            Me.cbEffectUnderline.Location = New System.Drawing.Point(6, 39)
            Me.cbEffectUnderline.Name = "cbEffectUnderline"
            Me.cbEffectUnderline.Size = New System.Drawing.Size(71, 17)
            Me.cbEffectUnderline.TabIndex = 1
            Me.cbEffectUnderline.Text = "Underline"
            Me.cbEffectUnderline.UseVisualStyleBackColor = True
            '
            ' cbEffectStrikethrough
            '
            Me.cbEffectStrikethrough.AutoSize = True
            Me.cbEffectStrikethrough.Location = New System.Drawing.Point(6, 62)
            Me.cbEffectStrikethrough.Name = "cbEffectStrikethrough"
            Me.cbEffectStrikethrough.Size = New System.Drawing.Size(89, 17)
            Me.cbEffectStrikethrough.TabIndex = 2
            Me.cbEffectStrikethrough.Text = "Strikethrough"
            Me.cbEffectStrikethrough.UseVisualStyleBackColor = True
            '
            ' cbEffectNone
            '
            Me.cbEffectNone.AutoSize = True
            Me.cbEffectNone.Location = New System.Drawing.Point(6, 19)
            Me.cbEffectNone.Name = "cbEffectNone"
            Me.cbEffectNone.Size = New System.Drawing.Size(52, 17)
            Me.cbEffectNone.TabIndex = 0
            Me.cbEffectNone.Text = "None"
            Me.cbEffectNone.UseVisualStyleBackColor = True
            '
            ' dlgColorPicker
            '
            Me.dlgColorPicker.AnyColor = True
            Me.dlgColorPicker.FullOpen = True
            '
            ' gbBold
            '
            Me.gbBold.Controls.Add(Me.rbBoldRelative)
            Me.gbBold.Controls.Add(Me.rbBoldAbsolute)
            Me.gbBold.Controls.Add(Me.cbBoldRelative)
            Me.gbBold.Controls.Add(Me.cbBoldAbsolute)
            Me.gbBold.Location = New System.Drawing.Point(67, 103)
            Me.gbBold.Name = "gbBold"
            Me.gbBold.Size = New System.Drawing.Size(204, 82)
            Me.gbBold.TabIndex = 4
            Me.gbBold.TabStop = False
            Me.gbBold.Text = "Bold"
            '
            ' rbBoldRelative
            '
            Me.rbBoldRelative.AutoSize = True
            Me.rbBoldRelative.Location = New System.Drawing.Point(6, 47)
            Me.rbBoldRelative.Name = "rbBoldRelative"
            Me.rbBoldRelative.Size = New System.Drawing.Size(64, 17)
            Me.rbBoldRelative.TabIndex = 3
            Me.rbBoldRelative.TabStop = True
            Me.rbBoldRelative.Text = "Relative"
            Me.rbBoldRelative.UseVisualStyleBackColor = True
            '
            ' rbBoldAbsolute
            '
            Me.rbBoldAbsolute.AutoSize = True
            Me.rbBoldAbsolute.Checked = True
            Me.rbBoldAbsolute.Location = New System.Drawing.Point(6, 20)
            Me.rbBoldAbsolute.Name = "rbBoldAbsolute"
            Me.rbBoldAbsolute.Size = New System.Drawing.Size(66, 17)
            Me.rbBoldAbsolute.TabIndex = 2
            Me.rbBoldAbsolute.TabStop = True
            Me.rbBoldAbsolute.Text = "Absolute"
            Me.rbBoldAbsolute.UseVisualStyleBackColor = True
            '
            ' cbBoldRelative
            '
            Me.cbBoldRelative.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBoldRelative.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBoldRelative.FormattingEnabled = True
            Me.cbBoldRelative.Location = New System.Drawing.Point(95, 46)
            Me.cbBoldRelative.Name = "cbBoldRelative"
            Me.cbBoldRelative.Size = New System.Drawing.Size(103, 21)
            Me.cbBoldRelative.TabIndex = 1
            '
            ' cbBoldAbsolute
            '
            Me.cbBoldAbsolute.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBoldAbsolute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBoldAbsolute.FormattingEnabled = True
            Me.cbBoldAbsolute.Location = New System.Drawing.Point(95, 19)
            Me.cbBoldAbsolute.Name = "cbBoldAbsolute"
            Me.cbBoldAbsolute.Size = New System.Drawing.Size(103, 21)
            Me.cbBoldAbsolute.TabIndex = 0
            '
            ' gbCapitalization
            '
            Me.gbCapitalization.Controls.Add(Me.cbCapitalization)
            Me.gbCapitalization.Location = New System.Drawing.Point(240, 202)
            Me.gbCapitalization.Name = "gbCapitalization"
            Me.gbCapitalization.Size = New System.Drawing.Size(86, 40)
            Me.gbCapitalization.TabIndex = 5
            Me.gbCapitalization.TabStop = False
            Me.gbCapitalization.Text = "Capitalization"
            '
            ' cbCapitalization
            '
            Me.cbCapitalization.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cbCapitalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbCapitalization.FormattingEnabled = True
            Me.cbCapitalization.Location = New System.Drawing.Point(3, 16)
            Me.cbCapitalization.Name = "cbCapitalization"
            Me.cbCapitalization.Size = New System.Drawing.Size(80, 21)
            Me.cbCapitalization.TabIndex = 0
            '
            ' groupBox1
            '
            Me.groupBox1.Controls.Add(Me.cbFontStyle)
            Me.groupBox1.Location = New System.Drawing.Point(330, 110)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(115, 48)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Italic"
            '
            ' groupBox2
            '
            Me.groupBox2.Controls.Add(Me.cbFontVariant)
            Me.groupBox2.Location = New System.Drawing.Point(240, 248)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(86, 43)
            Me.groupBox2.TabIndex = 6
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Small caps"
            '
            ' ucFont
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbCapitalization)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gbBold)
            Me.Controls.Add(Me.gbEffects)
            Me.Controls.Add(Me.gbSize)
            Me.Controls.Add(Me.gbFontAttributes)
            Me.Controls.Add(Me.gbFontName)
            Me.Name = "UcFont"
            Me.Size = New System.Drawing.Size(460, 380)
            Me.gbFontName.ResumeLayout(False)
            Me.gbFontName.PerformLayout()
            Me.gbFontAttributes.ResumeLayout(False)
            Me.gbFontAttributes.PerformLayout()
            Me.gbSize.ResumeLayout(False)
            Me.gbSize.PerformLayout()
            Me.gbEffects.ResumeLayout(False)
            Me.gbEffects.PerformLayout()
            Me.gbBold.ResumeLayout(False)
            Me.gbBold.PerformLayout()
            Me.gbCapitalization.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gbFontName As GroupBox
        Private WithEvents btFontFamilySelect As Button
        Private WithEvents rbSystemFont As RadioButton
        Private WithEvents rbFamily As RadioButton
        Private cbSystemFont As ComboBox
        Private tbFontFamily As TextBox
        Private gbFontAttributes As GroupBox
        Private cbFontVariant As ComboBox
        Private cbFontStyle As ComboBox
        Private gbSize As GroupBox
        Private WithEvents rbSizeRelative As RadioButton
        Private cbRelativeSize As ComboBox
        Private cbAbsoluteSize As ComboBox
        Private WithEvents rbSizeAbsolute As RadioButton
        Private cbSpecificSizeType As ComboBox
        Private tbSpecificSize As TextBox
        Private WithEvents rbSizeSpecific As RadioButton
        Private gbEffects As GroupBox
        Private cbEffectOverline As CheckBox
        Private cbEffectUnderline As CheckBox
        Private cbEffectStrikethrough As CheckBox
        Private WithEvents cbEffectNone As CheckBox
        Private dlgColorPicker As ColorDialog
        Private gbBold As GroupBox
        Private WithEvents rbBoldRelative As RadioButton
        Private WithEvents rbBoldAbsolute As RadioButton
        Private cbBoldRelative As ComboBox
        Private cbBoldAbsolute As ComboBox
        Private gbCapitalization As GroupBox
        Private cbCapitalization As ComboBox
        Private WithEvents txtForeColor As TextBox
        Private groupBox1 As GroupBox
        Private groupBox2 As GroupBox
    End Class

End Namespace
