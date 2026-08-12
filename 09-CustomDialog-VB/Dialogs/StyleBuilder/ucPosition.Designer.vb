Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucPosition
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private ReadOnly components As IContainer = Nothing

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
            Me.lPositionMode = New System.Windows.Forms.Label()
            Me.cbPositionMode = New System.Windows.Forms.ComboBox()
            Me.cbTopType = New System.Windows.Forms.ComboBox()
            Me.cbLeftType = New System.Windows.Forms.ComboBox()
            Me.cbHeightType = New System.Windows.Forms.ComboBox()
            Me.cbWidthType = New System.Windows.Forms.ComboBox()
            Me.tbTop = New System.Windows.Forms.TextBox()
            Me.tbLeft = New System.Windows.Forms.TextBox()
            Me.tbHeight = New System.Windows.Forms.TextBox()
            Me.tbWidth = New System.Windows.Forms.TextBox()
            Me.lTop = New System.Windows.Forms.Label()
            Me.lLeft = New System.Windows.Forms.Label()
            Me.lHeight = New System.Windows.Forms.Label()
            Me.lWidth = New System.Windows.Forms.Label()
            Me.lZIndex = New System.Windows.Forms.Label()
            Me.tbZIndex = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            ' lPositionMode
            '
            Me.lPositionMode.AutoSize = True
            Me.lPositionMode.Location = New System.Drawing.Point(3, 0)
            Me.lPositionMode.Name = "lPositionMode"
            Me.lPositionMode.Size = New System.Drawing.Size(76, 13)
            Me.lPositionMode.TabIndex = 0
            Me.lPositionMode.Text = "&Position mode:"
            '
            ' cbPositionMode
            '
            Me.cbPositionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPositionMode.FormattingEnabled = True
            Me.cbPositionMode.Location = New System.Drawing.Point(3, 19)
            Me.cbPositionMode.Name = "cbPositionMode"
            Me.cbPositionMode.Size = New System.Drawing.Size(454, 21)
            Me.cbPositionMode.TabIndex = 1
            '
            ' cbTopType
            '
            Me.cbTopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTopType.FormattingEnabled = True
            Me.cbTopType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbTopType.Location = New System.Drawing.Point(136, 46)
            Me.cbTopType.Name = "cbTopType"
            Me.cbTopType.Size = New System.Drawing.Size(68, 21)
            Me.cbTopType.TabIndex = 4
            '
            ' cbLeftType
            '
            Me.cbLeftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbLeftType.FormattingEnabled = True
            Me.cbLeftType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbLeftType.Location = New System.Drawing.Point(136, 73)
            Me.cbLeftType.Name = "cbLeftType"
            Me.cbLeftType.Size = New System.Drawing.Size(68, 21)
            Me.cbLeftType.TabIndex = 7
            '
            ' cbHeightType
            '
            Me.cbHeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbHeightType.FormattingEnabled = True
            Me.cbHeightType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbHeightType.Location = New System.Drawing.Point(389, 46)
            Me.cbHeightType.Name = "cbHeightType"
            Me.cbHeightType.Size = New System.Drawing.Size(68, 21)
            Me.cbHeightType.TabIndex = 10
            '
            ' cbWidthType
            '
            Me.cbWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbWidthType.FormattingEnabled = True
            Me.cbWidthType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbWidthType.Location = New System.Drawing.Point(389, 73)
            Me.cbWidthType.Name = "cbWidthType"
            Me.cbWidthType.Size = New System.Drawing.Size(68, 21)
            Me.cbWidthType.TabIndex = 13
            '
            ' tbTop
            '
            Me.tbTop.Location = New System.Drawing.Point(52, 46)
            Me.tbTop.Name = "tbTop"
            Me.tbTop.Size = New System.Drawing.Size(76, 20)
            Me.tbTop.TabIndex = 3
            '
            ' tbLeft
            '
            Me.tbLeft.Location = New System.Drawing.Point(52, 73)
            Me.tbLeft.Name = "tbLeft"
            Me.tbLeft.Size = New System.Drawing.Size(76, 20)
            Me.tbLeft.TabIndex = 6
            '
            ' tbHeight
            '
            Me.tbHeight.Location = New System.Drawing.Point(307, 46)
            Me.tbHeight.Name = "tbHeight"
            Me.tbHeight.Size = New System.Drawing.Size(76, 20)
            Me.tbHeight.TabIndex = 9
            '
            ' tbWidth
            '
            Me.tbWidth.Location = New System.Drawing.Point(307, 73)
            Me.tbWidth.Name = "tbWidth"
            Me.tbWidth.Size = New System.Drawing.Size(76, 20)
            Me.tbWidth.TabIndex = 12
            '
            ' lTop
            '
            Me.lTop.AutoSize = True
            Me.lTop.Location = New System.Drawing.Point(3, 49)
            Me.lTop.Name = "lTop"
            Me.lTop.Size = New System.Drawing.Size(29, 13)
            Me.lTop.TabIndex = 2
            Me.lTop.Text = "&Top:"
            '
            ' lLeft
            '
            Me.lLeft.AutoSize = True
            Me.lLeft.Location = New System.Drawing.Point(3, 76)
            Me.lLeft.Name = "lLeft"
            Me.lLeft.Size = New System.Drawing.Size(28, 13)
            Me.lLeft.TabIndex = 5
            Me.lLeft.Text = "&Left:"
            '
            ' lHeight
            '
            Me.lHeight.AutoSize = True
            Me.lHeight.Location = New System.Drawing.Point(222, 49)
            Me.lHeight.Name = "lHeight"
            Me.lHeight.Size = New System.Drawing.Size(41, 13)
            Me.lHeight.TabIndex = 8
            Me.lHeight.Text = "&Height:"
            '
            ' lWidth
            '
            Me.lWidth.AutoSize = True
            Me.lWidth.Location = New System.Drawing.Point(222, 76)
            Me.lWidth.Name = "lWidth"
            Me.lWidth.Size = New System.Drawing.Size(38, 13)
            Me.lWidth.TabIndex = 11
            Me.lWidth.Text = "&Width:"
            '
            ' lZIndex
            '
            Me.lZIndex.AutoSize = True
            Me.lZIndex.Location = New System.Drawing.Point(3, 111)
            Me.lZIndex.Name = "lZIndex"
            Me.lZIndex.Size = New System.Drawing.Size(46, 13)
            Me.lZIndex.TabIndex = 14
            Me.lZIndex.Text = "&Z-Index:"
            '
            ' tbZIndex
            '
            Me.tbZIndex.Location = New System.Drawing.Point(6, 127)
            Me.tbZIndex.Name = "tbZIndex"
            Me.tbZIndex.Size = New System.Drawing.Size(76, 20)
            Me.tbZIndex.TabIndex = 15
            '
            ' ucPosition
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tbZIndex)
            Me.Controls.Add(Me.lZIndex)
            Me.Controls.Add(Me.lWidth)
            Me.Controls.Add(Me.lHeight)
            Me.Controls.Add(Me.lLeft)
            Me.Controls.Add(Me.lTop)
            Me.Controls.Add(Me.tbWidth)
            Me.Controls.Add(Me.tbHeight)
            Me.Controls.Add(Me.tbLeft)
            Me.Controls.Add(Me.tbTop)
            Me.Controls.Add(Me.cbWidthType)
            Me.Controls.Add(Me.cbHeightType)
            Me.Controls.Add(Me.cbLeftType)
            Me.Controls.Add(Me.cbTopType)
            Me.Controls.Add(Me.cbPositionMode)
            Me.Controls.Add(Me.lPositionMode)
            Me.Name = "ucPosition"
            Me.Size = New System.Drawing.Size(460, 380)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private lPositionMode As Label
        Private WithEvents cbPositionMode As ComboBox
        Private cbTopType As ComboBox
        Private cbLeftType As ComboBox
        Private cbHeightType As ComboBox
        Private cbWidthType As ComboBox
        Private tbTop As TextBox
        Private tbLeft As TextBox
        Private tbHeight As TextBox
        Private tbWidth As TextBox
        Private lTop As Label
        Private lLeft As Label
        Private lHeight As Label
        Private lWidth As Label
        Private lZIndex As Label
        Private tbZIndex As TextBox
    End Class

End Namespace
