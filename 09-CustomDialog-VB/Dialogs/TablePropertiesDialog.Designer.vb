Imports System.ComponentModel
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms.Helpers.Controls

Namespace Global.CustomDialog.Dialogs

    Partial Public Class TablePropertiesDialog
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TablePropertiesDialog))
            Me.grpLayout = New System.Windows.Forms.GroupBox()
            Me.txtCaption = New System.Windows.Forms.TextBox()
            Me.grpHeight = New System.Windows.Forms.GroupBox()
            Me.cmbHeightUnit = New System.Windows.Forms.ComboBox()
            Me.txtHeight = New System.Windows.Forms.TextBox()
            Me.chkHeight = New System.Windows.Forms.CheckBox()
            Me.grpWidth = New System.Windows.Forms.GroupBox()
            Me.chkWidth = New System.Windows.Forms.CheckBox()
            Me.cmbWidthUnit = New System.Windows.Forms.ComboBox()
            Me.txtWidth = New System.Windows.Forms.TextBox()
            Me.chkCaption = New System.Windows.Forms.CheckBox()
            Me.numCols = New System.Windows.Forms.NumericUpDown()
            Me.numRows = New System.Windows.Forms.NumericUpDown()
            Me.lblColumns = New System.Windows.Forms.Label()
            Me.lblRows = New System.Windows.Forms.Label()
            Me.grpAttributes = New System.Windows.Forms.GroupBox()
            Me.chklnkBackgroundPicture = New CheckboxWithLinklabel()
            Me.chklnkBgColor = New CheckboxWithLinklabel()
            Me.chklnkBorderColor = New CheckboxWithLinklabel()
            Me.chkBorderToAll = New System.Windows.Forms.CheckBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtCss = New System.Windows.Forms.TextBox()
            Me.txtClassName = New System.Windows.Forms.TextBox()
            Me.cmbBorderStyle = New System.Windows.Forms.ComboBox()
            Me.chkBorderStyle = New System.Windows.Forms.CheckBox()
            Me.pbBackgroundPicture = New System.Windows.Forms.PictureBox()
            Me.txtBgColor = New System.Windows.Forms.TextBox()
            Me.txtBorderColor = New System.Windows.Forms.TextBox()
            Me.chkBorderCollapse = New System.Windows.Forms.CheckBox()
            Me.grpSummaryDesc = New System.Windows.Forms.GroupBox()
            Me.txtSummaryDescription = New System.Windows.Forms.TextBox()
            Me.numCellSpacing = New System.Windows.Forms.NumericUpDown()
            Me.numCellPadding = New System.Windows.Forms.NumericUpDown()
            Me.chkCellSpacing = New System.Windows.Forms.CheckBox()
            Me.chkCellPadding = New System.Windows.Forms.CheckBox()
            Me.numBorderWidth = New System.Windows.Forms.NumericUpDown()
            Me.chkBorderWidth = New System.Windows.Forms.CheckBox()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCellProperties = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.grpLayout.SuspendLayout()
            Me.grpHeight.SuspendLayout()
            Me.grpWidth.SuspendLayout()
            CType((Me.numCols), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numRows), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpAttributes.SuspendLayout()
            CType((Me.pbBackgroundPicture), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpSummaryDesc.SuspendLayout()
            CType((Me.numCellSpacing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numCellPadding), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numBorderWidth), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            ' grpLayout
            '
            Me.grpLayout.Controls.Add(Me.txtCaption)
            Me.grpLayout.Controls.Add(Me.grpHeight)
            Me.grpLayout.Controls.Add(Me.grpWidth)
            Me.grpLayout.Controls.Add(Me.chkCaption)
            Me.grpLayout.Controls.Add(Me.numCols)
            Me.grpLayout.Controls.Add(Me.numRows)
            Me.grpLayout.Controls.Add(Me.lblColumns)
            Me.grpLayout.Controls.Add(Me.lblRows)
            Me.grpLayout.Location = New System.Drawing.Point(7, 12)
            Me.grpLayout.Name = "grpLayout"
            Me.grpLayout.Size = New System.Drawing.Size(615, 110)
            Me.grpLayout.TabIndex = 0
            Me.grpLayout.TabStop = False
            Me.grpLayout.Text = "Layout"
            '
            ' txtCaption
            '
            Me.txtCaption.Enabled = False
            Me.txtCaption.Location = New System.Drawing.Point(110, 80)
            Me.txtCaption.Name = "txtCaption"
            Me.txtCaption.Size = New System.Drawing.Size(495, 20)
            Me.txtCaption.TabIndex = 15
            '
            ' grpHeight
            '
            Me.grpHeight.Controls.Add(Me.cmbHeightUnit)
            Me.grpHeight.Controls.Add(Me.txtHeight)
            Me.grpHeight.Controls.Add(Me.chkHeight)
            Me.grpHeight.AutoSize = True
            Me.grpHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.grpHeight.Location = New System.Drawing.Point(450, 19)
            Me.grpHeight.Name = "grpHeight"
            Me.grpHeight.Size = New System.Drawing.Size(160, 60)
            Me.grpHeight.TabIndex = 14
            Me.grpHeight.TabStop = False
            Me.grpHeight.Text = "Height"
            '
            ' cmbHeightUnit
            '
            Me.cmbHeightUnit.Enabled = False
            Me.cmbHeightUnit.FormattingEnabled = True
            Me.cmbHeightUnit.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cmbHeightUnit.Location = New System.Drawing.Point(78, 36)
            Me.cmbHeightUnit.Name = "cmbHeightUnit"
            Me.cmbHeightUnit.Size = New System.Drawing.Size(70, 21)
            Me.cmbHeightUnit.TabIndex = 8
            '
            ' txtHeight
            '
            Me.txtHeight.Enabled = False
            Me.txtHeight.Location = New System.Drawing.Point(7, 38)
            Me.txtHeight.Name = "txtHeight"
            Me.txtHeight.Size = New System.Drawing.Size(65, 20)
            Me.txtHeight.TabIndex = 7
            Me.txtHeight.Text = "100"
            '
            ' chkHeight
            '
            Me.chkHeight.AutoSize = True
            Me.chkHeight.Location = New System.Drawing.Point(58, 19)
            Me.chkHeight.Name = "chkHeight"
            Me.chkHeight.Size = New System.Drawing.Size(15, 14)
            Me.chkHeight.TabIndex = 20
            Me.chkHeight.UseVisualStyleBackColor = True
            '
            ' grpWidth
            '
            Me.grpWidth.Controls.Add(Me.chkWidth)
            Me.grpWidth.Controls.Add(Me.cmbWidthUnit)
            Me.grpWidth.Controls.Add(Me.txtWidth)
            Me.grpWidth.AutoSize = True
            Me.grpWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.grpWidth.Location = New System.Drawing.Point(280, 18)
            Me.grpWidth.Name = "grpWidth"
            Me.grpWidth.Size = New System.Drawing.Size(160, 60)
            Me.grpWidth.TabIndex = 13
            Me.grpWidth.TabStop = False
            Me.grpWidth.Text = "Width"
            '
            ' chkWidth
            '
            Me.chkWidth.AutoSize = True
            Me.chkWidth.Location = New System.Drawing.Point(59, 19)
            Me.chkWidth.Name = "chkWidth"
            Me.chkWidth.Size = New System.Drawing.Size(15, 14)
            Me.chkWidth.TabIndex = 20
            Me.chkWidth.UseVisualStyleBackColor = True
            '
            ' cmbWidthUnit
            '
            Me.cmbWidthUnit.Enabled = False
            Me.cmbWidthUnit.FormattingEnabled = True
            Me.cmbWidthUnit.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cmbWidthUnit.Location = New System.Drawing.Point(78, 36)
            Me.cmbWidthUnit.Name = "cmbWidthUnit"
            Me.cmbWidthUnit.Size = New System.Drawing.Size(70, 21)
            Me.cmbWidthUnit.TabIndex = 8
            '
            ' txtWidth
            '
            Me.txtWidth.Enabled = False
            Me.txtWidth.Location = New System.Drawing.Point(7, 38)
            Me.txtWidth.Name = "txtWidth"
            Me.txtWidth.Size = New System.Drawing.Size(65, 20)
            Me.txtWidth.TabIndex = 7
            Me.txtWidth.Text = "100"
            '
            ' chkCaption
            '
            Me.chkCaption.AutoSize = True
            Me.chkCaption.Location = New System.Drawing.Point(11, 82)
            Me.chkCaption.Name = "chkCaption"
            Me.chkCaption.Size = New System.Drawing.Size(62, 17)
            Me.chkCaption.TabIndex = 12
            Me.chkCaption.Text = "Caption"
            Me.chkCaption.UseVisualStyleBackColor = True
            '
            ' numCols
            '
            Me.numCols.Location = New System.Drawing.Point(110, 45)
            Me.numCols.Maximum = New Decimal(New Integer() {
            50,
            0,
            0,
            0})
            Me.numCols.Minimum = New Decimal(New Integer() {
            1,
            0,
            0,
            0})
            Me.numCols.Name = "numCols"
            Me.numCols.Size = New System.Drawing.Size(58, 20)
            Me.numCols.TabIndex = 4
            Me.numCols.Value = New Decimal(New Integer() {
            3,
            0,
            0,
            0})
            '
            ' numRows
            '
            Me.numRows.Location = New System.Drawing.Point(110, 18)
            Me.numRows.Maximum = New Decimal(New Integer() {
            50,
            0,
            0,
            0})
            Me.numRows.Minimum = New Decimal(New Integer() {
            1,
            0,
            0,
            0})
            Me.numRows.Name = "numRows"
            Me.numRows.Size = New System.Drawing.Size(58, 20)
            Me.numRows.TabIndex = 3
            Me.numRows.Value = New Decimal(New Integer() {
            3,
            0,
            0,
            0})
            '
            ' lblColumns
            '
            Me.lblColumns.AutoSize = True
            Me.lblColumns.Location = New System.Drawing.Point(7, 49)
            Me.lblColumns.Name = "lblColumns"
            Me.lblColumns.Size = New System.Drawing.Size(50, 13)
            Me.lblColumns.TabIndex = 1
            Me.lblColumns.Text = "Columns:"
            '
            ' lblRows
            '
            Me.lblRows.AutoSize = True
            Me.lblRows.Location = New System.Drawing.Point(8, 22)
            Me.lblRows.Name = "lblRows"
            Me.lblRows.Size = New System.Drawing.Size(37, 13)
            Me.lblRows.TabIndex = 0
            Me.lblRows.Text = "Rows:"
            '
            ' grpAttributes
            '
            Me.grpAttributes.Controls.Add(Me.chklnkBackgroundPicture)
            Me.grpAttributes.Controls.Add(Me.chklnkBgColor)
            Me.grpAttributes.Controls.Add(Me.chklnkBorderColor)
            Me.grpAttributes.Controls.Add(Me.chkBorderToAll)
            Me.grpAttributes.Controls.Add(Me.label2)
            Me.grpAttributes.Controls.Add(Me.label1)
            Me.grpAttributes.Controls.Add(Me.txtCss)
            Me.grpAttributes.Controls.Add(Me.txtClassName)
            Me.grpAttributes.Controls.Add(Me.cmbBorderStyle)
            Me.grpAttributes.Controls.Add(Me.chkBorderStyle)
            Me.grpAttributes.Controls.Add(Me.pbBackgroundPicture)
            Me.grpAttributes.Controls.Add(Me.txtBgColor)
            Me.grpAttributes.Controls.Add(Me.txtBorderColor)
            Me.grpAttributes.Controls.Add(Me.chkBorderCollapse)
            Me.grpAttributes.Controls.Add(Me.grpSummaryDesc)
            Me.grpAttributes.Controls.Add(Me.numCellSpacing)
            Me.grpAttributes.Controls.Add(Me.numCellPadding)
            Me.grpAttributes.Controls.Add(Me.chkCellSpacing)
            Me.grpAttributes.Controls.Add(Me.chkCellPadding)
            Me.grpAttributes.Controls.Add(Me.numBorderWidth)
            Me.grpAttributes.Controls.Add(Me.chkBorderWidth)
            Me.grpAttributes.Location = New System.Drawing.Point(7, 130)
            Me.grpAttributes.Name = "grpAttributes"
            Me.grpAttributes.Size = New System.Drawing.Size(615, 350)
            Me.grpAttributes.TabIndex = 1
            Me.grpAttributes.TabStop = False
            Me.grpAttributes.Text = "Attributes"
            '
            ' chklnkBackgroundPicture
            '
            Me.chklnkBackgroundPicture.AutoSize = True
            Me.chklnkBackgroundPicture.Checked = True
            Me.chklnkBackgroundPicture.LinkText = "Background Picture"
            Me.chklnkBackgroundPicture.Location = New System.Drawing.Point(340, 38)
            Me.chklnkBackgroundPicture.Margin = New System.Windows.Forms.Padding(0)
            Me.chklnkBackgroundPicture.Name = "chklnkBackgroundPicture"
            Me.chklnkBackgroundPicture.Size = New System.Drawing.Size(120, 20)
            Me.chklnkBackgroundPicture.TabIndex = 63
            '
            ' chklnkBgColor
            '
            Me.chklnkBgColor.AutoSize = True
            Me.chklnkBgColor.Checked = True
            Me.chklnkBgColor.LinkText = "Background Color"
            Me.chklnkBgColor.Location = New System.Drawing.Point(340, 17)
            Me.chklnkBgColor.Margin = New System.Windows.Forms.Padding(0)
            Me.chklnkBgColor.Name = "chklnkBgColor"
            Me.chklnkBgColor.Size = New System.Drawing.Size(111, 20)
            Me.chklnkBgColor.TabIndex = 62
            '
            ' chklnkBorderColor
            '
            Me.chklnkBorderColor.AutoSize = True
            Me.chklnkBorderColor.Checked = True
            Me.chklnkBorderColor.LinkText = "Border Color"
            Me.chklnkBorderColor.Location = New System.Drawing.Point(10, 40)
            Me.chklnkBorderColor.MinimumSize = New System.Drawing.Size(120, 20)
            Me.chklnkBorderColor.Margin = New System.Windows.Forms.Padding(0)
            Me.chklnkBorderColor.Name = "chklnkBorderColor"
            Me.chklnkBorderColor.Size = New System.Drawing.Size(86, 20)
            Me.chklnkBorderColor.TabIndex = 61
            '
            ' chkBorderToAll
            '
            Me.chkBorderToAll.AutoSize = True
            Me.chkBorderToAll.Checked = True
            Me.chkBorderToAll.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkBorderToAll.Location = New System.Drawing.Point(10, 109)
            Me.chkBorderToAll.Name = "chkBorderToAll"
            Me.chkBorderToAll.Size = New System.Drawing.Size(121, 17)
            Me.chkBorderToAll.TabIndex = 59
            Me.chkBorderToAll.Text = "Apply border to cells"
            Me.chkBorderToAll.UseVisualStyleBackColor = True
            '
            ' label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(8, 201)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(28, 13)
            Me.label2.TabIndex = 58
            Me.label2.Text = "CSS"
            '
            ' label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(8, 180)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(63, 13)
            Me.label1.TabIndex = 58
            Me.label1.Text = "Class Name"
            '
            ' txtCss
            '
            Me.txtCss.Location = New System.Drawing.Point(110, 201)
            Me.txtCss.Multiline = True
            Me.txtCss.Name = "txtCss"
            Me.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtCss.Size = New System.Drawing.Size(495, 50)
            Me.txtCss.TabIndex = 57
            '
            ' txtClassName
            '
            Me.txtClassName.Location = New System.Drawing.Point(110, 177)
            Me.txtClassName.Name = "txtClassName"
            Me.txtClassName.Size = New System.Drawing.Size(160, 20)
            Me.txtClassName.TabIndex = 55
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
            Me.cmbBorderStyle.Location = New System.Drawing.Point(110, 63)
            Me.cmbBorderStyle.Name = "cmbBorderStyle"
            Me.cmbBorderStyle.SelectedIndex = 0
            Me.cmbBorderStyle.Size = New System.Drawing.Size(160, 21)
            Me.cmbBorderStyle.TabIndex = 53
            '
            ' chkBorderStyle
            '
            Me.chkBorderStyle.AutoSize = True
            Me.chkBorderStyle.Location = New System.Drawing.Point(10, 63)
            Me.chkBorderStyle.Name = "chkBorderStyle"
            Me.chkBorderStyle.Size = New System.Drawing.Size(83, 17)
            Me.chkBorderStyle.TabIndex = 52
            Me.chkBorderStyle.Text = "Border Style"
            Me.chkBorderStyle.UseVisualStyleBackColor = True
            '
            ' pbBackgroundPicture
            '
            Me.pbBackgroundPicture.Location = New System.Drawing.Point(340, 58)
            Me.pbBackgroundPicture.Name = "pbBackgroundPicture"
            Me.pbBackgroundPicture.Size = New System.Drawing.Size(270, 95)
            Me.pbBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbBackgroundPicture.TabIndex = 21
            Me.pbBackgroundPicture.TabStop = False
            '
            ' txtBgColor
            '
            Me.txtBgColor.BackColor = System.Drawing.Color.White
            Me.txtBgColor.Enabled = False
            Me.txtBgColor.Location = New System.Drawing.Point(495, 17)
            Me.txtBgColor.Name = "txtBgColor"
            Me.txtBgColor.ReadOnly = True
            Me.txtBgColor.Size = New System.Drawing.Size(115, 20)
            Me.txtBgColor.TabIndex = 18
            '
            ' txtBorderColor
            '
            Me.txtBorderColor.BackColor = System.Drawing.Color.White
            Me.txtBorderColor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtBorderColor.Enabled = False
            Me.txtBorderColor.Location = New System.Drawing.Point(180, 40)
            Me.txtBorderColor.Name = "txtBorderColor"
            Me.txtBorderColor.ReadOnly = True
            Me.txtBorderColor.Size = New System.Drawing.Size(140, 20)
            Me.txtBorderColor.TabIndex = 16
            '
            ' chkBorderCollapse
            '
            Me.chkBorderCollapse.AutoSize = True
            Me.chkBorderCollapse.Location = New System.Drawing.Point(10, 86)
            Me.chkBorderCollapse.Name = "chkBorderCollapse"
            Me.chkBorderCollapse.Size = New System.Drawing.Size(100, 17)
            Me.chkBorderCollapse.TabIndex = 14
            Me.chkBorderCollapse.Text = "Border Collapse"
            Me.chkBorderCollapse.UseVisualStyleBackColor = True
            '
            ' grpSummaryDesc
            '
            Me.grpSummaryDesc.Controls.Add(Me.txtSummaryDescription)
            Me.grpSummaryDesc.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grpSummaryDesc.Location = New System.Drawing.Point(3, 261)
            Me.grpSummaryDesc.Name = "grpSummaryDesc"
            Me.grpSummaryDesc.Size = New System.Drawing.Size(609, 86)
            Me.grpSummaryDesc.TabIndex = 13
            Me.grpSummaryDesc.TabStop = False
            Me.grpSummaryDesc.Text = "Summary Description"
            '
            ' txtSummaryDescription
            '
            Me.txtSummaryDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtSummaryDescription.Location = New System.Drawing.Point(3, 16)
            Me.txtSummaryDescription.Multiline = True
            Me.txtSummaryDescription.Name = "txtSummaryDescription"
            Me.txtSummaryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtSummaryDescription.Size = New System.Drawing.Size(603, 67)
            Me.txtSummaryDescription.TabIndex = 0
            '
            ' numCellSpacing
            '
            Me.numCellSpacing.Enabled = False
            Me.numCellSpacing.Location = New System.Drawing.Point(180, 154)
            Me.numCellSpacing.Maximum = New Decimal(New Integer() {
            99,
            0,
            0,
            0})
            Me.numCellSpacing.Name = "numCellSpacing"
            Me.numCellSpacing.Size = New System.Drawing.Size(58, 20)
            Me.numCellSpacing.TabIndex = 12
            '
            ' numCellPadding
            '
            Me.numCellPadding.Enabled = False
            Me.numCellPadding.Location = New System.Drawing.Point(180, 132)
            Me.numCellPadding.Maximum = New Decimal(New Integer() {
            99,
            0,
            0,
            0})
            Me.numCellPadding.Name = "numCellPadding"
            Me.numCellPadding.Size = New System.Drawing.Size(58, 20)
            Me.numCellPadding.TabIndex = 11
            '
            ' chkCellSpacing
            '
            Me.chkCellSpacing.AutoSize = True
            Me.chkCellSpacing.Location = New System.Drawing.Point(10, 156)
            Me.chkCellSpacing.Name = "chkCellSpacing"
            Me.chkCellSpacing.Size = New System.Drawing.Size(80, 17)
            Me.chkCellSpacing.TabIndex = 10
            Me.chkCellSpacing.Text = "Cellspacing"
            Me.chkCellSpacing.UseVisualStyleBackColor = True
            '
            ' chkCellPadding
            '
            Me.chkCellPadding.AutoSize = True
            Me.chkCellPadding.Location = New System.Drawing.Point(10, 134)
            Me.chkCellPadding.Name = "chkCellPadding"
            Me.chkCellPadding.Size = New System.Drawing.Size(81, 17)
            Me.chkCellPadding.TabIndex = 9
            Me.chkCellPadding.Text = "Cellpadding"
            Me.chkCellPadding.UseVisualStyleBackColor = True
            '
            ' numBorderWidth
            '
            Me.numBorderWidth.Location = New System.Drawing.Point(180, 15)
            Me.numBorderWidth.Maximum = New Decimal(New Integer() {
            99,
            0,
            0,
            0})
            Me.numBorderWidth.Name = "numBorderWidth"
            Me.numBorderWidth.Size = New System.Drawing.Size(58, 20)
            Me.numBorderWidth.TabIndex = 8
            Me.numBorderWidth.Value = New Decimal(New Integer() {
            1,
            0,
            0,
            0})
            '
            ' chkBorderWidth
            '
            Me.chkBorderWidth.AutoSize = True
            Me.chkBorderWidth.Checked = True
            Me.chkBorderWidth.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkBorderWidth.Location = New System.Drawing.Point(10, 20)
            Me.chkBorderWidth.Name = "chkBorderWidth"
            Me.chkBorderWidth.Size = New System.Drawing.Size(88, 17)
            Me.chkBorderWidth.TabIndex = 7
            Me.chkBorderWidth.Text = "Border Width"
            Me.chkBorderWidth.UseVisualStyleBackColor = True
            '
            ' btnCancel
            '
            Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.Location = New System.Drawing.Point(530, 490)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 23)
            Me.btnCancel.TabIndex = 3
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
            Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnOK.Location = New System.Drawing.Point(436, 490)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(90, 23)
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            ' btnCellProperties
            '
            Me.btnCellProperties.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.btnCellProperties.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCellProperties.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCellProperties.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnCellProperties.AutoSize = True
            Me.btnCellProperties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnCellProperties.Location = New System.Drawing.Point(7, 490)
            Me.btnCellProperties.MinimumSize = New System.Drawing.Size(180, 23)
            Me.btnCellProperties.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnCellProperties.Name = "btnCellProperties"
            Me.btnCellProperties.Size = New System.Drawing.Size(180, 23)
            Me.btnCellProperties.TabIndex = 4
            Me.btnCellProperties.Text = "Cell properties"
            Me.btnCellProperties.UseVisualStyleBackColor = True
            '
            ' groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.txtName)
            Me.groupBox1.Controls.Add(Me.txtId)
            Me.groupBox1.Location = New System.Drawing.Point(7, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(615, 42)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Visible = False
            '
            ' label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(228, 16)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(35, 13)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Name"
            '
            ' label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(10, 15)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(18, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "ID"
            '
            ' txtName
            '
            Me.txtName.Location = New System.Drawing.Point(286, 15)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(147, 20)
            Me.txtName.TabIndex = 3
            '
            ' txtId
            '
            Me.txtId.Location = New System.Drawing.Point(94, 16)
            Me.txtId.Name = "txtId"
            Me.txtId.Size = New System.Drawing.Size(118, 20)
            Me.txtId.TabIndex = 1
            '
            ' TablePropertiesDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(630, 520)
            Me.ControlBox = False
            Me.Controls.Add(Me.grpAttributes)
            Me.Controls.Add(Me.grpLayout)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnCellProperties)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "TablePropertiesDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table Properties"
            Me.grpLayout.ResumeLayout(False)
            Me.grpLayout.PerformLayout()
            Me.grpHeight.ResumeLayout(False)
            Me.grpHeight.PerformLayout()
            Me.grpWidth.ResumeLayout(False)
            Me.grpWidth.PerformLayout()
            CType((Me.numCols), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numRows), System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpAttributes.ResumeLayout(False)
            Me.grpAttributes.PerformLayout()
            CType((Me.pbBackgroundPicture), System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpSummaryDesc.ResumeLayout(False)
            Me.grpSummaryDesc.PerformLayout()
            CType((Me.numCellSpacing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numCellPadding), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numBorderWidth), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private grpLayout As GroupBox
        Private grpAttributes As GroupBox
        Private numRows As NumericUpDown
        Private lblColumns As Label
        Private lblRows As Label
        Private numCols As NumericUpDown
        Private cmbWidthUnit As ComboBox
        Private txtWidth As TextBox
        Private WithEvents chkCaption As CheckBox
        Private WithEvents chkBorderWidth As CheckBox
        Private grpSummaryDesc As GroupBox
        Private txtSummaryDescription As TextBox
        Private numCellSpacing As NumericUpDown
        Private numCellPadding As NumericUpDown
        Private WithEvents numBorderWidth As NumericUpDown
        Private chkBorderCollapse As CheckBox
        Private txtBgColor As TextBox
        Private txtBorderColor As TextBox
        Private pbBackgroundPicture As PictureBox
        Private btnCancel As Button
        Private btnOK As Button
        Private grpHeight As GroupBox
        Private WithEvents chkHeight As CheckBox
        Private cmbHeightUnit As ComboBox
        Private txtHeight As TextBox
        Private grpWidth As GroupBox
        Private WithEvents chkWidth As CheckBox
        Private WithEvents btnCellProperties As Button
        Private txtCaption As TextBox
        Private WithEvents chkCellSpacing As CheckBox
        Private WithEvents chkCellPadding As CheckBox
        Private cmbBorderStyle As ComboBox
        Private WithEvents chkBorderStyle As CheckBox
        Private txtCss As TextBox
        Private txtClassName As TextBox
        Private groupBox1 As GroupBox
        Private txtName As TextBox
        Private txtId As TextBox
        Private label2 As Label
        Private label1 As Label
        Private label4 As Label
        Private label3 As Label
        Private chkBorderToAll As CheckBox
        Private WithEvents chklnkBorderColor As CheckboxWithLinklabel
        Private WithEvents chklnkBackgroundPicture As CheckboxWithLinklabel
        Private WithEvents chklnkBgColor As CheckboxWithLinklabel

    End Class

End Namespace
