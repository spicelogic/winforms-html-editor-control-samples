Imports System.ComponentModel
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms.Helpers.Controls

Namespace Global.CustomDialog.Dialogs

    Partial Public Class TableCellPropertiesDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableCellPropertiesDialog))
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.chkHeight = New System.Windows.Forms.CheckBox()
            Me.cmbHeightUnit = New System.Windows.Forms.ComboBox()
            Me.txtHeight = New System.Windows.Forms.TextBox()
            Me.groupBox4 = New System.Windows.Forms.GroupBox()
            Me.chkWidth = New System.Windows.Forms.CheckBox()
            Me.cmbWidthUnit = New System.Windows.Forms.ComboBox()
            Me.txtWidth = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.cmbHorizontalAlign = New System.Windows.Forms.ComboBox()
            Me.cmbVerticalAlign = New System.Windows.Forms.ComboBox()
            Me.chkNoWrap = New System.Windows.Forms.CheckBox()
            Me.txtBgColor = New System.Windows.Forms.TextBox()
            Me.chkOverrideSettings4Cells = New System.Windows.Forms.CheckBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtClassName = New System.Windows.Forms.TextBox()
            Me.txtCss = New System.Windows.Forms.TextBox()
            Me.chklnkBgColor = New CheckboxWithLinklabel()
            Me.groupBox5.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            ' btnCancel
            '
            Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.Location = New System.Drawing.Point(345, 281)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(85, 23)
            Me.btnCancel.TabIndex = 5
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
            Me.btnOK.Location = New System.Drawing.Point(255, 281)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(85, 23)
            Me.btnOK.TabIndex = 4
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            ' groupBox5
            '
            Me.groupBox5.Controls.Add(Me.chkHeight)
            Me.groupBox5.Controls.Add(Me.cmbHeightUnit)
            Me.groupBox5.Controls.Add(Me.txtHeight)
            Me.groupBox5.AutoSize = True
            Me.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.groupBox5.Location = New System.Drawing.Point(220, 12)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(160, 60)
            Me.groupBox5.TabIndex = 16
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Height"
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
            ' cmbHeightUnit
            '
            Me.cmbHeightUnit.Enabled = False
            Me.cmbHeightUnit.FormattingEnabled = True
            Me.cmbHeightUnit.Items.AddRange(New Object() {
            "px",
            "%"})
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
            ' groupBox4
            '
            Me.groupBox4.Controls.Add(Me.chkWidth)
            Me.groupBox4.Controls.Add(Me.cmbWidthUnit)
            Me.groupBox4.Controls.Add(Me.txtWidth)
            Me.groupBox4.AutoSize = True
            Me.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.groupBox4.Location = New System.Drawing.Point(15, 12)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(160, 60)
            Me.groupBox4.TabIndex = 15
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Width"
            '
            ' chkWidth
            '
            Me.chkWidth.AutoSize = True
            Me.chkWidth.Location = New System.Drawing.Point(56, 19)
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
            "%"})
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
            ' label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(15, 85)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(80, 13)
            Me.label1.TabIndex = 17
            Me.label1.Text = "Horizontal Align"
            '
            ' label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(15, 112)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(68, 13)
            Me.label2.TabIndex = 18
            Me.label2.Text = "Vertical Align"
            '
            ' cmbHorizontalAlign
            '
            Me.cmbHorizontalAlign.FormattingEnabled = True
            Me.cmbHorizontalAlign.Items.AddRange(New Object() {
            "NotSet",
            "right",
            "center",
            "left",
            "middle"})
            Me.cmbHorizontalAlign.Location = New System.Drawing.Point(220, 80)
            Me.cmbHorizontalAlign.Name = "cmbHorizontalAlign"
            Me.cmbHorizontalAlign.Size = New System.Drawing.Size(160, 21)
            Me.cmbHorizontalAlign.TabIndex = 19
            '
            ' cmbVerticalAlign
            '
            Me.cmbVerticalAlign.FormattingEnabled = True
            Me.cmbVerticalAlign.Items.AddRange(New Object() {
            "NotSet",
            "top",
            "middle",
            "bottom",
            "baseline"})
            Me.cmbVerticalAlign.Location = New System.Drawing.Point(220, 107)
            Me.cmbVerticalAlign.Name = "cmbVerticalAlign"
            Me.cmbVerticalAlign.Size = New System.Drawing.Size(160, 21)
            Me.cmbVerticalAlign.TabIndex = 20
            '
            ' chkNoWrap
            '
            Me.chkNoWrap.AutoSize = True
            Me.chkNoWrap.Location = New System.Drawing.Point(9, 145)
            Me.chkNoWrap.Name = "chkNoWrap"
            Me.chkNoWrap.Size = New System.Drawing.Size(69, 17)
            Me.chkNoWrap.TabIndex = 21
            Me.chkNoWrap.Text = "No Wrap"
            Me.chkNoWrap.UseVisualStyleBackColor = True
            '
            ' txtBgColor
            '
            Me.txtBgColor.BackColor = System.Drawing.Color.White
            Me.txtBgColor.Enabled = False
            Me.txtBgColor.Location = New System.Drawing.Point(290, 145)
            Me.txtBgColor.Name = "txtBgColor"
            Me.txtBgColor.ReadOnly = True
            Me.txtBgColor.Size = New System.Drawing.Size(90, 20)
            Me.txtBgColor.TabIndex = 25
            '
            ' chkOverrideSettings4Cells
            '
            Me.chkOverrideSettings4Cells.AutoSize = True
            Me.chkOverrideSettings4Cells.Location = New System.Drawing.Point(9, 175)
            Me.chkOverrideSettings4Cells.Name = "chkOverrideSettings4Cells"
            Me.chkOverrideSettings4Cells.Size = New System.Drawing.Size(157, 17)
            Me.chkOverrideSettings4Cells.TabIndex = 27
            Me.chkOverrideSettings4Cells.Text = "Overrride settings to all cells"
            Me.chkOverrideSettings4Cells.UseVisualStyleBackColor = True
            '
            ' label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(6, 205)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(63, 13)
            Me.label3.TabIndex = 28
            Me.label3.Text = "Class Name"
            '
            ' label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(6, 229)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(28, 13)
            Me.label4.TabIndex = 28
            Me.label4.Text = "CSS"
            '
            ' txtClassName
            '
            Me.txtClassName.Location = New System.Drawing.Point(110, 202)
            Me.txtClassName.Name = "txtClassName"
            Me.txtClassName.Size = New System.Drawing.Size(270, 20)
            Me.txtClassName.TabIndex = 29
            '
            ' txtCss
            '
            Me.txtCss.Location = New System.Drawing.Point(110, 226)
            Me.txtCss.Multiline = True
            Me.txtCss.Name = "txtCss"
            Me.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtCss.Size = New System.Drawing.Size(270, 49)
            Me.txtCss.TabIndex = 29
            '
            ' chklnkBgColor
            '
            Me.chklnkBgColor.AutoSize = True
            Me.chklnkBgColor.Checked = False
            Me.chklnkBgColor.LinkText = "Background Color"
            Me.chklnkBgColor.Location = New System.Drawing.Point(160, 145)
            Me.chklnkBgColor.Margin = New System.Windows.Forms.Padding(0)
            Me.chklnkBgColor.Name = "chklnkBgColor"
            Me.chklnkBgColor.Size = New System.Drawing.Size(113, 20)
            Me.chklnkBgColor.TabIndex = 30
            '
            ' TableCellPropertiesDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(440, 320)
            Me.ControlBox = False
            Me.Controls.Add(Me.chklnkBgColor)
            Me.Controls.Add(Me.txtCss)
            Me.Controls.Add(Me.txtClassName)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.chkOverrideSettings4Cells)
            Me.Controls.Add(Me.txtBgColor)
            Me.Controls.Add(Me.chkNoWrap)
            Me.Controls.Add(Me.cmbVerticalAlign)
            Me.Controls.Add(Me.cmbHorizontalAlign)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.groupBox5)
            Me.Controls.Add(Me.groupBox4)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Name = "TableCellPropertiesDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table Cell Properties"
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private btnCancel As Button
        Private btnOK As Button
        Private groupBox5 As GroupBox
        Private WithEvents chkHeight As CheckBox
        Private cmbHeightUnit As ComboBox
        Private txtHeight As TextBox
        Private groupBox4 As GroupBox
        Private WithEvents chkWidth As CheckBox
        Private cmbWidthUnit As ComboBox
        Private txtWidth As TextBox
        Private label1 As Label
        Private label2 As Label
        Private cmbHorizontalAlign As ComboBox
        Private cmbVerticalAlign As ComboBox
        Private chkNoWrap As CheckBox
        Private txtBgColor As TextBox
        Private chkOverrideSettings4Cells As CheckBox
        Private label3 As Label
        Private label4 As Label
        Private txtClassName As TextBox
        Private txtCss As TextBox
        Private WithEvents chklnkBgColor As CheckboxWithLinklabel
    End Class

End Namespace
