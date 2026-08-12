Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucText
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
            Me.gbAlignment = New System.Windows.Forms.GroupBox()
            Me.lAlJustification = New System.Windows.Forms.Label()
            Me.lAlVertical = New System.Windows.Forms.Label()
            Me.lAlHorizontal = New System.Windows.Forms.Label()
            Me.cbAlJustification = New System.Windows.Forms.ComboBox()
            Me.cbAlVertical = New System.Windows.Forms.ComboBox()
            Me.cbAlHorizontal = New System.Windows.Forms.ComboBox()
            Me.gbSpacingBetween = New System.Windows.Forms.GroupBox()
            Me.lSbLines = New System.Windows.Forms.Label()
            Me.lSbLetters = New System.Windows.Forms.Label()
            Me.cbSpacingLinesCustom = New System.Windows.Forms.ComboBox()
            Me.cbSpacingLettersCustom = New System.Windows.Forms.ComboBox()
            Me.tbSpacingLines = New System.Windows.Forms.TextBox()
            Me.tbSpacingLetters = New System.Windows.Forms.TextBox()
            Me.cbSpacingLines = New System.Windows.Forms.ComboBox()
            Me.cbSpacingLetters = New System.Windows.Forms.ComboBox()
            Me.gbTextFlow = New System.Windows.Forms.GroupBox()
            Me.lTfTextDirection = New System.Windows.Forms.Label()
            Me.lTfIndentation = New System.Windows.Forms.Label()
            Me.cbTextFlowDirection = New System.Windows.Forms.ComboBox()
            Me.tbTextFlowIndentation = New System.Windows.Forms.TextBox()
            Me.cbTextFlowCustom = New System.Windows.Forms.ComboBox()
            Me.gbAlignment.SuspendLayout()
            Me.gbSpacingBetween.SuspendLayout()
            Me.gbTextFlow.SuspendLayout()
            Me.SuspendLayout()
            '
            ' gbAlignment
            '
            Me.gbAlignment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbAlignment.Controls.Add(Me.lAlJustification)
            Me.gbAlignment.Controls.Add(Me.lAlVertical)
            Me.gbAlignment.Controls.Add(Me.lAlHorizontal)
            Me.gbAlignment.Controls.Add(Me.cbAlJustification)
            Me.gbAlignment.Controls.Add(Me.cbAlVertical)
            Me.gbAlignment.Controls.Add(Me.cbAlHorizontal)
            Me.gbAlignment.Location = New System.Drawing.Point(3, 3)
            Me.gbAlignment.Name = "gbAlignment"
            Me.gbAlignment.Size = New System.Drawing.Size(454, 107)
            Me.gbAlignment.TabIndex = 0
            Me.gbAlignment.TabStop = False
            Me.gbAlignment.Text = "Alignment"
            '
            ' lAlJustification
            '
            Me.lAlJustification.AutoSize = True
            Me.lAlJustification.Location = New System.Drawing.Point(6, 76)
            Me.lAlJustification.Name = "lAlJustification"
            Me.lAlJustification.Size = New System.Drawing.Size(65, 13)
            Me.lAlJustification.TabIndex = 4
            Me.lAlJustification.Text = "&Justification:"
            '
            ' lAlVertical
            '
            Me.lAlVertical.AutoSize = True
            Me.lAlVertical.Location = New System.Drawing.Point(6, 49)
            Me.lAlVertical.Name = "lAlVertical"
            Me.lAlVertical.Size = New System.Drawing.Size(45, 13)
            Me.lAlVertical.TabIndex = 2
            Me.lAlVertical.Text = "&Vertical:"
            '
            ' lAlHorizontal
            '
            Me.lAlHorizontal.AutoSize = True
            Me.lAlHorizontal.Location = New System.Drawing.Point(6, 22)
            Me.lAlHorizontal.Name = "lAlHorizontal"
            Me.lAlHorizontal.Size = New System.Drawing.Size(57, 13)
            Me.lAlHorizontal.TabIndex = 0
            Me.lAlHorizontal.Text = "&Horizontal:"
            '
            ' cbAlJustification
            '
            Me.cbAlJustification.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbAlJustification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAlJustification.FormattingEnabled = True
            Me.cbAlJustification.Location = New System.Drawing.Point(89, 73)
            Me.cbAlJustification.Name = "cbAlJustification"
            Me.cbAlJustification.Size = New System.Drawing.Size(359, 21)
            Me.cbAlJustification.TabIndex = 5
            '
            ' cbAlVertical
            '
            Me.cbAlVertical.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbAlVertical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAlVertical.FormattingEnabled = True
            Me.cbAlVertical.Location = New System.Drawing.Point(89, 46)
            Me.cbAlVertical.Name = "cbAlVertical"
            Me.cbAlVertical.Size = New System.Drawing.Size(359, 21)
            Me.cbAlVertical.TabIndex = 3
            '
            ' cbAlHorizontal
            '
            Me.cbAlHorizontal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbAlHorizontal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAlHorizontal.FormattingEnabled = True
            Me.cbAlHorizontal.Location = New System.Drawing.Point(89, 19)
            Me.cbAlHorizontal.Name = "cbAlHorizontal"
            Me.cbAlHorizontal.Size = New System.Drawing.Size(359, 21)
            Me.cbAlHorizontal.TabIndex = 1
            '
            ' gbSpacingBetween
            '
            Me.gbSpacingBetween.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbSpacingBetween.Controls.Add(Me.lSbLines)
            Me.gbSpacingBetween.Controls.Add(Me.lSbLetters)
            Me.gbSpacingBetween.Controls.Add(Me.cbSpacingLinesCustom)
            Me.gbSpacingBetween.Controls.Add(Me.cbSpacingLettersCustom)
            Me.gbSpacingBetween.Controls.Add(Me.tbSpacingLines)
            Me.gbSpacingBetween.Controls.Add(Me.tbSpacingLetters)
            Me.gbSpacingBetween.Controls.Add(Me.cbSpacingLines)
            Me.gbSpacingBetween.Controls.Add(Me.cbSpacingLetters)
            Me.gbSpacingBetween.Location = New System.Drawing.Point(3, 116)
            Me.gbSpacingBetween.Name = "gbSpacingBetween"
            Me.gbSpacingBetween.Size = New System.Drawing.Size(454, 83)
            Me.gbSpacingBetween.TabIndex = 1
            Me.gbSpacingBetween.TabStop = False
            Me.gbSpacingBetween.Text = "Spacing between"
            '
            ' lSbLines
            '
            Me.lSbLines.AutoSize = True
            Me.lSbLines.Location = New System.Drawing.Point(6, 49)
            Me.lSbLines.Name = "lSbLines"
            Me.lSbLines.Size = New System.Drawing.Size(35, 13)
            Me.lSbLines.TabIndex = 4
            Me.lSbLines.Text = "&Lines:"
            '
            ' lSbLetters
            '
            Me.lSbLetters.AutoSize = True
            Me.lSbLetters.Location = New System.Drawing.Point(6, 22)
            Me.lSbLetters.Name = "lSbLetters"
            Me.lSbLetters.Size = New System.Drawing.Size(42, 13)
            Me.lSbLetters.TabIndex = 0
            Me.lSbLetters.Text = "L&etters:"
            '
            ' cbSpacingLinesCustom
            '
            Me.cbSpacingLinesCustom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbSpacingLinesCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSpacingLinesCustom.FormattingEnabled = True
            Me.cbSpacingLinesCustom.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbSpacingLinesCustom.Location = New System.Drawing.Point(383, 46)
            Me.cbSpacingLinesCustom.Name = "cbSpacingLinesCustom"
            Me.cbSpacingLinesCustom.Size = New System.Drawing.Size(65, 21)
            Me.cbSpacingLinesCustom.TabIndex = 7
            '
            ' cbSpacingLettersCustom
            '
            Me.cbSpacingLettersCustom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbSpacingLettersCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSpacingLettersCustom.FormattingEnabled = True
            Me.cbSpacingLettersCustom.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbSpacingLettersCustom.Location = New System.Drawing.Point(383, 19)
            Me.cbSpacingLettersCustom.Name = "cbSpacingLettersCustom"
            Me.cbSpacingLettersCustom.Size = New System.Drawing.Size(65, 21)
            Me.cbSpacingLettersCustom.TabIndex = 3
            '
            ' tbSpacingLines
            '
            Me.tbSpacingLines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbSpacingLines.Location = New System.Drawing.Point(277, 46)
            Me.tbSpacingLines.Name = "tbSpacingLines"
            Me.tbSpacingLines.Size = New System.Drawing.Size(100, 20)
            Me.tbSpacingLines.TabIndex = 6
            '
            ' tbSpacingLetters
            '
            Me.tbSpacingLetters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbSpacingLetters.Location = New System.Drawing.Point(277, 19)
            Me.tbSpacingLetters.Name = "tbSpacingLetters"
            Me.tbSpacingLetters.Size = New System.Drawing.Size(100, 20)
            Me.tbSpacingLetters.TabIndex = 2
            '
            ' cbSpacingLines
            '
            Me.cbSpacingLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbSpacingLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSpacingLines.FormattingEnabled = True
            Me.cbSpacingLines.Location = New System.Drawing.Point(89, 46)
            Me.cbSpacingLines.Name = "cbSpacingLines"
            Me.cbSpacingLines.Size = New System.Drawing.Size(182, 21)
            Me.cbSpacingLines.TabIndex = 5
            '
            ' cbSpacingLetters
            '
            Me.cbSpacingLetters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbSpacingLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSpacingLetters.FormattingEnabled = True
            Me.cbSpacingLetters.Location = New System.Drawing.Point(89, 19)
            Me.cbSpacingLetters.Name = "cbSpacingLetters"
            Me.cbSpacingLetters.Size = New System.Drawing.Size(182, 21)
            Me.cbSpacingLetters.TabIndex = 1
            '
            ' gbTextFlow
            '
            Me.gbTextFlow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbTextFlow.Controls.Add(Me.lTfTextDirection)
            Me.gbTextFlow.Controls.Add(Me.lTfIndentation)
            Me.gbTextFlow.Controls.Add(Me.cbTextFlowDirection)
            Me.gbTextFlow.Controls.Add(Me.tbTextFlowIndentation)
            Me.gbTextFlow.Controls.Add(Me.cbTextFlowCustom)
            Me.gbTextFlow.Location = New System.Drawing.Point(3, 205)
            Me.gbTextFlow.Name = "gbTextFlow"
            Me.gbTextFlow.Size = New System.Drawing.Size(454, 83)
            Me.gbTextFlow.TabIndex = 2
            Me.gbTextFlow.TabStop = False
            Me.gbTextFlow.Text = "Text flow"
            '
            ' lTfTextDirection
            '
            Me.lTfTextDirection.AutoSize = True
            Me.lTfTextDirection.Location = New System.Drawing.Point(6, 49)
            Me.lTfTextDirection.Name = "lTfTextDirection"
            Me.lTfTextDirection.Size = New System.Drawing.Size(74, 13)
            Me.lTfTextDirection.TabIndex = 3
            Me.lTfTextDirection.Text = "Te&xt direction:"
            '
            ' lTfIndentation
            '
            Me.lTfIndentation.AutoSize = True
            Me.lTfIndentation.Location = New System.Drawing.Point(6, 22)
            Me.lTfIndentation.Name = "lTfIndentation"
            Me.lTfIndentation.Size = New System.Drawing.Size(63, 13)
            Me.lTfIndentation.TabIndex = 0
            Me.lTfIndentation.Text = "&Indentation:"
            '
            ' cbTextFlowDirection
            '
            Me.cbTextFlowDirection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbTextFlowDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTextFlowDirection.FormattingEnabled = True
            Me.cbTextFlowDirection.Location = New System.Drawing.Point(89, 46)
            Me.cbTextFlowDirection.Name = "cbTextFlowDirection"
            Me.cbTextFlowDirection.Size = New System.Drawing.Size(359, 21)
            Me.cbTextFlowDirection.TabIndex = 4
            '
            ' tbTextFlowIndentation
            '
            Me.tbTextFlowIndentation.Location = New System.Drawing.Point(89, 19)
            Me.tbTextFlowIndentation.Name = "tbTextFlowIndentation"
            Me.tbTextFlowIndentation.Size = New System.Drawing.Size(100, 20)
            Me.tbTextFlowIndentation.TabIndex = 1
            '
            ' cbTextFlowCustom
            '
            Me.cbTextFlowCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTextFlowCustom.FormattingEnabled = True
            Me.cbTextFlowCustom.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbTextFlowCustom.Location = New System.Drawing.Point(195, 19)
            Me.cbTextFlowCustom.Name = "cbTextFlowCustom"
            Me.cbTextFlowCustom.Size = New System.Drawing.Size(60, 21)
            Me.cbTextFlowCustom.TabIndex = 2
            '
            ' ucText
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbTextFlow)
            Me.Controls.Add(Me.gbSpacingBetween)
            Me.Controls.Add(Me.gbAlignment)
            Me.Name = "ucText"
            Me.Size = New System.Drawing.Size(460, 380)
            Me.gbAlignment.ResumeLayout(False)
            Me.gbAlignment.PerformLayout()
            Me.gbSpacingBetween.ResumeLayout(False)
            Me.gbSpacingBetween.PerformLayout()
            Me.gbTextFlow.ResumeLayout(False)
            Me.gbTextFlow.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gbAlignment As GroupBox
        Private gbSpacingBetween As GroupBox
        Private gbTextFlow As GroupBox
        Private lAlJustification As Label
        Private lAlVertical As Label
        Private lAlHorizontal As Label
        Private cbAlJustification As ComboBox
        Private cbAlVertical As ComboBox
        Private WithEvents cbAlHorizontal As ComboBox
        Private lSbLines As Label
        Private lSbLetters As Label
        Private cbSpacingLinesCustom As ComboBox
        Private cbSpacingLettersCustom As ComboBox
        Private tbSpacingLines As TextBox
        Private tbSpacingLetters As TextBox
        Private WithEvents cbSpacingLines As ComboBox
        Private WithEvents cbSpacingLetters As ComboBox
        Private lTfTextDirection As Label
        Private lTfIndentation As Label
        Private cbTextFlowDirection As ComboBox
        Private tbTextFlowIndentation As TextBox
        Private cbTextFlowCustom As ComboBox
    End Class

End Namespace
