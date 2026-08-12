Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucBackground
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
            Me.gbBackgroundColor = New System.Windows.Forms.GroupBox()
            Me.txtBgColor = New System.Windows.Forms.TextBox()
            Me.cbBgColorTransparent = New System.Windows.Forms.CheckBox()
            Me.gbBackgroundImage = New System.Windows.Forms.GroupBox()
            Me.cbDoNotUseBackground = New System.Windows.Forms.CheckBox()
            Me.lScrolling = New System.Windows.Forms.Label()
            Me.bTiling = New System.Windows.Forms.Label()
            Me.gbPosition = New System.Windows.Forms.GroupBox()
            Me.lVertical = New System.Windows.Forms.Label()
            Me.lHorizontal = New System.Windows.Forms.Label()
            Me.tbVerCust = New System.Windows.Forms.TextBox()
            Me.tbHorCust = New System.Windows.Forms.TextBox()
            Me.cbVerCustType = New System.Windows.Forms.ComboBox()
            Me.cbVertical = New System.Windows.Forms.ComboBox()
            Me.cbHorCustType = New System.Windows.Forms.ComboBox()
            Me.cbHorizontal = New System.Windows.Forms.ComboBox()
            Me.cbScrolling = New System.Windows.Forms.ComboBox()
            Me.cbTiling = New System.Windows.Forms.ComboBox()
            Me.lBgImageFile = New System.Windows.Forms.Label()
            Me.tbBgImage = New System.Windows.Forms.TextBox()
            Me.btChooseBgImage = New System.Windows.Forms.Button()
            Me.dlgColorPicker = New System.Windows.Forms.ColorDialog()
            Me.dlgBgImage = New System.Windows.Forms.OpenFileDialog()
            Me.gbBackgroundColor.SuspendLayout()
            Me.gbBackgroundImage.SuspendLayout()
            Me.gbPosition.SuspendLayout()
            Me.SuspendLayout()
            '
            ' gbBackgroundColor
            '
            Me.gbBackgroundColor.Controls.Add(Me.txtBgColor)
            Me.gbBackgroundColor.Controls.Add(Me.cbBgColorTransparent)
            Me.gbBackgroundColor.Location = New System.Drawing.Point(3, 3)
            Me.gbBackgroundColor.Name = "gbBackgroundColor"
            Me.gbBackgroundColor.Size = New System.Drawing.Size(454, 50)
            Me.gbBackgroundColor.TabIndex = 0
            Me.gbBackgroundColor.TabStop = False
            Me.gbBackgroundColor.Text = "Background color"
            '
            ' txtBgColor
            '
            Me.txtBgColor.BackColor = System.Drawing.Color.White
            Me.txtBgColor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtBgColor.Enabled = False
            Me.txtBgColor.Location = New System.Drawing.Point(9, 21)
            Me.txtBgColor.Name = "txtBgColor"
            Me.txtBgColor.ReadOnly = True
            Me.txtBgColor.Size = New System.Drawing.Size(36, 20)
            Me.txtBgColor.TabIndex = 7
            '
            ' cbBgColorTransparent
            '
            Me.cbBgColorTransparent.AutoSize = True
            Me.cbBgColorTransparent.Checked = True
            Me.cbBgColorTransparent.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbBgColorTransparent.Location = New System.Drawing.Point(66, 23)
            Me.cbBgColorTransparent.Name = "cbBgColorTransparent"
            Me.cbBgColorTransparent.Size = New System.Drawing.Size(83, 17)
            Me.cbBgColorTransparent.TabIndex = 3
            Me.cbBgColorTransparent.Text = "Transparent"
            Me.cbBgColorTransparent.UseVisualStyleBackColor = True
            '
            ' gbBackgroundImage
            '
            Me.gbBackgroundImage.Controls.Add(Me.cbDoNotUseBackground)
            Me.gbBackgroundImage.Controls.Add(Me.lScrolling)
            Me.gbBackgroundImage.Controls.Add(Me.bTiling)
            Me.gbBackgroundImage.Controls.Add(Me.gbPosition)
            Me.gbBackgroundImage.Controls.Add(Me.cbScrolling)
            Me.gbBackgroundImage.Controls.Add(Me.cbTiling)
            Me.gbBackgroundImage.Controls.Add(Me.lBgImageFile)
            Me.gbBackgroundImage.Controls.Add(Me.tbBgImage)
            Me.gbBackgroundImage.Controls.Add(Me.btChooseBgImage)
            Me.gbBackgroundImage.Location = New System.Drawing.Point(3, 86)
            Me.gbBackgroundImage.Name = "gbBackgroundImage"
            Me.gbBackgroundImage.Size = New System.Drawing.Size(454, 291)
            Me.gbBackgroundImage.TabIndex = 1
            Me.gbBackgroundImage.TabStop = False
            Me.gbBackgroundImage.Text = "Background Image"
            '
            ' cbDoNotUseBackground
            '
            Me.cbDoNotUseBackground.AutoSize = True
            Me.cbDoNotUseBackground.Location = New System.Drawing.Point(6, 190)
            Me.cbDoNotUseBackground.Name = "cbDoNotUseBackground"
            Me.cbDoNotUseBackground.Size = New System.Drawing.Size(169, 17)
            Me.cbDoNotUseBackground.TabIndex = 8
            Me.cbDoNotUseBackground.Text = "&Do not use background image"
            Me.cbDoNotUseBackground.UseVisualStyleBackColor = True
            '
            ' lScrolling
            '
            Me.lScrolling.AutoSize = True
            Me.lScrolling.Location = New System.Drawing.Point(132, 78)
            Me.lScrolling.Name = "lScrolling"
            Me.lScrolling.Size = New System.Drawing.Size(50, 13)
            Me.lScrolling.TabIndex = 5
            Me.lScrolling.Text = "&Scrolling:"
            '
            ' bTiling
            '
            Me.bTiling.AutoSize = True
            Me.bTiling.Location = New System.Drawing.Point(132, 51)
            Me.bTiling.Name = "bTiling"
            Me.bTiling.Size = New System.Drawing.Size(35, 13)
            Me.bTiling.TabIndex = 3
            Me.bTiling.Text = "&Tiling:"
            '
            ' gbPosition
            '
            Me.gbPosition.Controls.Add(Me.lVertical)
            Me.gbPosition.Controls.Add(Me.lHorizontal)
            Me.gbPosition.Controls.Add(Me.tbVerCust)
            Me.gbPosition.Controls.Add(Me.tbHorCust)
            Me.gbPosition.Controls.Add(Me.cbVerCustType)
            Me.gbPosition.Controls.Add(Me.cbVertical)
            Me.gbPosition.Controls.Add(Me.cbHorCustType)
            Me.gbPosition.Controls.Add(Me.cbHorizontal)
            Me.gbPosition.Location = New System.Drawing.Point(114, 102)
            Me.gbPosition.Name = "gbPosition"
            Me.gbPosition.Size = New System.Drawing.Size(334, 82)
            Me.gbPosition.TabIndex = 7
            Me.gbPosition.TabStop = False
            Me.gbPosition.Text = "Position"
            '
            ' lVertical
            '
            Me.lVertical.AutoSize = True
            Me.lVertical.Location = New System.Drawing.Point(18, 49)
            Me.lVertical.Name = "lVertical"
            Me.lVertical.Size = New System.Drawing.Size(45, 13)
            Me.lVertical.TabIndex = 4
            Me.lVertical.Text = "&Vertical:"
            '
            ' lHorizontal
            '
            Me.lHorizontal.AutoSize = True
            Me.lHorizontal.Location = New System.Drawing.Point(18, 22)
            Me.lHorizontal.Name = "lHorizontal"
            Me.lHorizontal.Size = New System.Drawing.Size(57, 13)
            Me.lHorizontal.TabIndex = 0
            Me.lHorizontal.Text = "&Horizontal:"
            '
            ' tbVerCust
            '
            Me.tbVerCust.Location = New System.Drawing.Point(194, 46)
            Me.tbVerCust.Name = "tbVerCust"
            Me.tbVerCust.Size = New System.Drawing.Size(52, 20)
            Me.tbVerCust.TabIndex = 6
            '
            ' tbHorCust
            '
            Me.tbHorCust.Location = New System.Drawing.Point(194, 19)
            Me.tbHorCust.Name = "tbHorCust"
            Me.tbHorCust.Size = New System.Drawing.Size(52, 20)
            Me.tbHorCust.TabIndex = 2
            '
            ' cbVerCustType
            '
            Me.cbVerCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbVerCustType.FormattingEnabled = True
            Me.cbVerCustType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbVerCustType.Location = New System.Drawing.Point(271, 46)
            Me.cbVerCustType.Name = "cbVerCustType"
            Me.cbVerCustType.Size = New System.Drawing.Size(57, 21)
            Me.cbVerCustType.TabIndex = 7
            '
            ' cbVertical
            '
            Me.cbVertical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbVertical.FormattingEnabled = True
            Me.cbVertical.Location = New System.Drawing.Point(95, 46)
            Me.cbVertical.Name = "cbVertical"
            Me.cbVertical.Size = New System.Drawing.Size(75, 21)
            Me.cbVertical.TabIndex = 5
            '
            ' cbHorCustType
            '
            Me.cbHorCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbHorCustType.FormattingEnabled = True
            Me.cbHorCustType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbHorCustType.Location = New System.Drawing.Point(271, 19)
            Me.cbHorCustType.Name = "cbHorCustType"
            Me.cbHorCustType.Size = New System.Drawing.Size(57, 21)
            Me.cbHorCustType.TabIndex = 3
            '
            ' cbHorizontal
            '
            Me.cbHorizontal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbHorizontal.FormattingEnabled = True
            Me.cbHorizontal.Location = New System.Drawing.Point(95, 19)
            Me.cbHorizontal.Name = "cbHorizontal"
            Me.cbHorizontal.Size = New System.Drawing.Size(75, 21)
            Me.cbHorizontal.TabIndex = 1
            '
            ' cbScrolling
            '
            Me.cbScrolling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbScrolling.FormattingEnabled = True
            Me.cbScrolling.Location = New System.Drawing.Point(209, 75)
            Me.cbScrolling.Name = "cbScrolling"
            Me.cbScrolling.Size = New System.Drawing.Size(239, 21)
            Me.cbScrolling.TabIndex = 6
            '
            ' cbTiling
            '
            Me.cbTiling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTiling.FormattingEnabled = True
            Me.cbTiling.Location = New System.Drawing.Point(209, 48)
            Me.cbTiling.Name = "cbTiling"
            Me.cbTiling.Size = New System.Drawing.Size(239, 21)
            Me.cbTiling.TabIndex = 4
            '
            ' lBgImageFile
            '
            Me.lBgImageFile.AutoSize = True
            Me.lBgImageFile.Location = New System.Drawing.Point(6, 24)
            Me.lBgImageFile.Name = "lBgImageFile"
            Me.lBgImageFile.Size = New System.Drawing.Size(39, 13)
            Me.lBgImageFile.TabIndex = 0
            Me.lBgImageFile.Text = "Image:"
            '
            ' tbBgImage
            '
            Me.tbBgImage.Location = New System.Drawing.Point(135, 21)
            Me.tbBgImage.Name = "tbBgImage"
            Me.tbBgImage.Size = New System.Drawing.Size(265, 20)
            Me.tbBgImage.TabIndex = 1
            '
            ' btChooseBgImage
            '
            Me.btChooseBgImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btChooseBgImage.Location = New System.Drawing.Point(406, 19)
            Me.btChooseBgImage.Name = "btChooseBgImage"
            Me.btChooseBgImage.Size = New System.Drawing.Size(42, 23)
            Me.btChooseBgImage.TabIndex = 2
            Me.btChooseBgImage.Text = "..."
            Me.btChooseBgImage.UseVisualStyleBackColor = True
            '
            ' ucBackground
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbBackgroundImage)
            Me.Controls.Add(Me.gbBackgroundColor)
            Me.Name = "ucBackground"
            Me.Size = New System.Drawing.Size(460, 380)
            Me.gbBackgroundColor.ResumeLayout(False)
            Me.gbBackgroundColor.PerformLayout()
            Me.gbBackgroundImage.ResumeLayout(False)
            Me.gbBackgroundImage.PerformLayout()
            Me.gbPosition.ResumeLayout(False)
            Me.gbPosition.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gbBackgroundColor As GroupBox
        Private gbBackgroundImage As GroupBox
        Private WithEvents cbBgColorTransparent As CheckBox
        Private WithEvents btChooseBgImage As Button
        Private dlgColorPicker As ColorDialog
        Private cbScrolling As ComboBox
        Private cbTiling As ComboBox
        Private lBgImageFile As Label
        Private WithEvents tbBgImage As TextBox
        Private WithEvents cbDoNotUseBackground As CheckBox
        Private lScrolling As Label
        Private bTiling As Label
        Private gbPosition As GroupBox
        Private lVertical As Label
        Private lHorizontal As Label
        Private tbVerCust As TextBox
        Private tbHorCust As TextBox
        Private cbVerCustType As ComboBox
        Private WithEvents cbVertical As ComboBox
        Private cbHorCustType As ComboBox
        Private WithEvents cbHorizontal As ComboBox
        Private dlgBgImage As OpenFileDialog
        Private WithEvents txtBgColor As TextBox
    End Class

End Namespace
