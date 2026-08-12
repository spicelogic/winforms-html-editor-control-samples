Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucLayout
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
            Me.lVisibility = New System.Windows.Forms.Label()
            Me.cbVisibility = New System.Windows.Forms.ComboBox()
            Me.lDisplay = New System.Windows.Forms.Label()
            Me.cbDisplay = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.cbAllowTextToFlow = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.cbAllowFloatingObject = New System.Windows.Forms.ComboBox()
            Me.gbContent = New System.Windows.Forms.GroupBox()
            Me.gbClipping = New System.Windows.Forms.GroupBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.tbRight = New System.Windows.Forms.TextBox()
            Me.tbBottom = New System.Windows.Forms.TextBox()
            Me.tbLeft = New System.Windows.Forms.TextBox()
            Me.tbTop = New System.Windows.Forms.TextBox()
            Me.cbRightType = New System.Windows.Forms.ComboBox()
            Me.cbBottomType = New System.Windows.Forms.ComboBox()
            Me.cbLeftType = New System.Windows.Forms.ComboBox()
            Me.cbTopType = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.cbOverflow = New System.Windows.Forms.ComboBox()
            Me.gbPageBreaks = New System.Windows.Forms.GroupBox()
            Me.lAfter = New System.Windows.Forms.Label()
            Me.lBefore = New System.Windows.Forms.Label()
            Me.cbPbAfter = New System.Windows.Forms.ComboBox()
            Me.cbPbBefore = New System.Windows.Forms.ComboBox()
            Me.gbContent.SuspendLayout()
            Me.gbClipping.SuspendLayout()
            Me.gbPageBreaks.SuspendLayout()
            Me.SuspendLayout()
            '
            ' lVisibility
            '
            Me.lVisibility.AutoSize = True
            Me.lVisibility.Location = New System.Drawing.Point(3, 2)
            Me.lVisibility.Name = "lVisibility"
            Me.lVisibility.Size = New System.Drawing.Size(46, 13)
            Me.lVisibility.TabIndex = 0
            Me.lVisibility.Text = "&Visibility:"
            '
            ' cbVisibility
            '
            Me.cbVisibility.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbVisibility.FormattingEnabled = True
            Me.cbVisibility.Location = New System.Drawing.Point(3, 18)
            Me.cbVisibility.Name = "cbVisibility"
            Me.cbVisibility.Size = New System.Drawing.Size(454, 21)
            Me.cbVisibility.TabIndex = 1
            '
            ' lDisplay
            '
            Me.lDisplay.AutoSize = True
            Me.lDisplay.Location = New System.Drawing.Point(3, 44)
            Me.lDisplay.Name = "lDisplay"
            Me.lDisplay.Size = New System.Drawing.Size(44, 13)
            Me.lDisplay.TabIndex = 2
            Me.lDisplay.Text = "&Display:"
            '
            ' cbDisplay
            '
            Me.cbDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbDisplay.FormattingEnabled = True
            Me.cbDisplay.Location = New System.Drawing.Point(3, 60)
            Me.cbDisplay.Name = "cbDisplay"
            Me.cbDisplay.Size = New System.Drawing.Size(454, 21)
            Me.cbDisplay.TabIndex = 3
            '
            ' label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(3, 86)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(89, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Allow te&xt to flow:"
            '
            ' cbAllowTextToFlow
            '
            Me.cbAllowTextToFlow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbAllowTextToFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAllowTextToFlow.FormattingEnabled = True
            Me.cbAllowTextToFlow.Location = New System.Drawing.Point(3, 102)
            Me.cbAllowTextToFlow.Name = "cbAllowTextToFlow"
            Me.cbAllowTextToFlow.Size = New System.Drawing.Size(454, 21)
            Me.cbAllowTextToFlow.TabIndex = 5
            '
            ' label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(3, 128)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(109, 13)
            Me.label4.TabIndex = 6
            Me.label4.Text = "Allow &floating objects:"
            '
            ' cbAllowFloatingObject
            '
            Me.cbAllowFloatingObject.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbAllowFloatingObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAllowFloatingObject.FormattingEnabled = True
            Me.cbAllowFloatingObject.Location = New System.Drawing.Point(3, 144)
            Me.cbAllowFloatingObject.Name = "cbAllowFloatingObject"
            Me.cbAllowFloatingObject.Size = New System.Drawing.Size(454, 21)
            Me.cbAllowFloatingObject.TabIndex = 7
            '
            ' gbContent
            '
            Me.gbContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbContent.Controls.Add(Me.gbClipping)
            Me.gbContent.Controls.Add(Me.label5)
            Me.gbContent.Controls.Add(Me.cbOverflow)
            Me.gbContent.Location = New System.Drawing.Point(3, 171)
            Me.gbContent.Name = "gbContent"
            Me.gbContent.Size = New System.Drawing.Size(454, 129)
            Me.gbContent.TabIndex = 8
            Me.gbContent.TabStop = False
            Me.gbContent.Text = "Content"
            '
            ' gbClipping
            '
            Me.gbClipping.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbClipping.Controls.Add(Me.label9)
            Me.gbClipping.Controls.Add(Me.label8)
            Me.gbClipping.Controls.Add(Me.label7)
            Me.gbClipping.Controls.Add(Me.label6)
            Me.gbClipping.Controls.Add(Me.tbRight)
            Me.gbClipping.Controls.Add(Me.tbBottom)
            Me.gbClipping.Controls.Add(Me.tbLeft)
            Me.gbClipping.Controls.Add(Me.tbTop)
            Me.gbClipping.Controls.Add(Me.cbRightType)
            Me.gbClipping.Controls.Add(Me.cbBottomType)
            Me.gbClipping.Controls.Add(Me.cbLeftType)
            Me.gbClipping.Controls.Add(Me.cbTopType)
            Me.gbClipping.Location = New System.Drawing.Point(6, 46)
            Me.gbClipping.Name = "gbClipping"
            Me.gbClipping.Size = New System.Drawing.Size(442, 77)
            Me.gbClipping.TabIndex = 2
            Me.gbClipping.TabStop = False
            Me.gbClipping.Text = "Clipping"
            '
            ' label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(223, 49)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(35, 13)
            Me.label9.TabIndex = 11
            Me.label9.Text = "&Right:"
            '
            ' label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(223, 22)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(43, 13)
            Me.label8.TabIndex = 10
            Me.label8.Text = "&Bottom:"
            '
            ' label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(6, 49)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(28, 13)
            Me.label7.TabIndex = 9
            Me.label7.Text = "&Left:"
            '
            ' label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(6, 22)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(29, 13)
            Me.label6.TabIndex = 8
            Me.label6.Text = "&Top:"
            '
            ' tbRight
            '
            Me.tbRight.Location = New System.Drawing.Point(303, 46)
            Me.tbRight.Name = "tbRight"
            Me.tbRight.Size = New System.Drawing.Size(70, 20)
            Me.tbRight.TabIndex = 7
            '
            ' tbBottom
            '
            Me.tbBottom.Location = New System.Drawing.Point(303, 19)
            Me.tbBottom.Name = "tbBottom"
            Me.tbBottom.Size = New System.Drawing.Size(70, 20)
            Me.tbBottom.TabIndex = 6
            '
            ' tbLeft
            '
            Me.tbLeft.Location = New System.Drawing.Point(78, 46)
            Me.tbLeft.Name = "tbLeft"
            Me.tbLeft.Size = New System.Drawing.Size(70, 20)
            Me.tbLeft.TabIndex = 5
            '
            ' tbTop
            '
            Me.tbTop.Location = New System.Drawing.Point(78, 19)
            Me.tbTop.Name = "tbTop"
            Me.tbTop.Size = New System.Drawing.Size(70, 20)
            Me.tbTop.TabIndex = 4
            '
            ' cbRightType
            '
            Me.cbRightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbRightType.FormattingEnabled = True
            Me.cbRightType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbRightType.Location = New System.Drawing.Point(379, 46)
            Me.cbRightType.Name = "cbRightType"
            Me.cbRightType.Size = New System.Drawing.Size(63, 21)
            Me.cbRightType.TabIndex = 3
            '
            ' cbBottomType
            '
            Me.cbBottomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBottomType.FormattingEnabled = True
            Me.cbBottomType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbBottomType.Location = New System.Drawing.Point(379, 19)
            Me.cbBottomType.Name = "cbBottomType"
            Me.cbBottomType.Size = New System.Drawing.Size(63, 21)
            Me.cbBottomType.TabIndex = 2
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
            Me.cbLeftType.Location = New System.Drawing.Point(154, 46)
            Me.cbLeftType.Name = "cbLeftType"
            Me.cbLeftType.Size = New System.Drawing.Size(63, 21)
            Me.cbLeftType.TabIndex = 1
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
            Me.cbTopType.Location = New System.Drawing.Point(154, 19)
            Me.cbTopType.Name = "cbTopType"
            Me.cbTopType.Size = New System.Drawing.Size(63, 21)
            Me.cbTopType.TabIndex = 0
            '
            ' label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(6, 22)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(52, 13)
            Me.label5.TabIndex = 1
            Me.label5.Text = "&Overflow:"
            '
            ' cbOverflow
            '
            Me.cbOverflow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbOverflow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbOverflow.FormattingEnabled = True
            Me.cbOverflow.Location = New System.Drawing.Point(114, 19)
            Me.cbOverflow.Name = "cbOverflow"
            Me.cbOverflow.Size = New System.Drawing.Size(334, 21)
            Me.cbOverflow.TabIndex = 0
            '
            ' gbPageBreaks
            '
            Me.gbPageBreaks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbPageBreaks.Controls.Add(Me.lAfter)
            Me.gbPageBreaks.Controls.Add(Me.lBefore)
            Me.gbPageBreaks.Controls.Add(Me.cbPbAfter)
            Me.gbPageBreaks.Controls.Add(Me.cbPbBefore)
            Me.gbPageBreaks.Location = New System.Drawing.Point(3, 306)
            Me.gbPageBreaks.Name = "gbPageBreaks"
            Me.gbPageBreaks.Size = New System.Drawing.Size(454, 78)
            Me.gbPageBreaks.TabIndex = 3
            Me.gbPageBreaks.TabStop = False
            Me.gbPageBreaks.Text = "Printing page breaks"
            '
            ' lAfter
            '
            Me.lAfter.AutoSize = True
            Me.lAfter.Location = New System.Drawing.Point(6, 49)
            Me.lAfter.Name = "lAfter"
            Me.lAfter.Size = New System.Drawing.Size(29, 13)
            Me.lAfter.TabIndex = 3
            Me.lAfter.Text = "&After"
            '
            ' lBefore
            '
            Me.lBefore.AutoSize = True
            Me.lBefore.Location = New System.Drawing.Point(6, 22)
            Me.lBefore.Name = "lBefore"
            Me.lBefore.Size = New System.Drawing.Size(41, 13)
            Me.lBefore.TabIndex = 2
            Me.lBefore.Text = "B&efore:"
            '
            ' cbPbAfter
            '
            Me.cbPbAfter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbPbAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPbAfter.FormattingEnabled = True
            Me.cbPbAfter.Location = New System.Drawing.Point(114, 46)
            Me.cbPbAfter.Name = "cbPbAfter"
            Me.cbPbAfter.Size = New System.Drawing.Size(334, 21)
            Me.cbPbAfter.TabIndex = 1
            '
            ' cbPbBefore
            '
            Me.cbPbBefore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbPbBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPbBefore.FormattingEnabled = True
            Me.cbPbBefore.Location = New System.Drawing.Point(114, 19)
            Me.cbPbBefore.Name = "cbPbBefore"
            Me.cbPbBefore.Size = New System.Drawing.Size(334, 21)
            Me.cbPbBefore.TabIndex = 0
            '
            ' ucLayout
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbPageBreaks)
            Me.Controls.Add(Me.gbContent)
            Me.Controls.Add(Me.cbAllowFloatingObject)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.cbAllowTextToFlow)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.cbDisplay)
            Me.Controls.Add(Me.lDisplay)
            Me.Controls.Add(Me.cbVisibility)
            Me.Controls.Add(Me.lVisibility)
            Me.Name = "ucLayout"
            Me.Size = New System.Drawing.Size(460, 387)
            Me.gbContent.ResumeLayout(False)
            Me.gbContent.PerformLayout()
            Me.gbClipping.ResumeLayout(False)
            Me.gbClipping.PerformLayout()
            Me.gbPageBreaks.ResumeLayout(False)
            Me.gbPageBreaks.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private lVisibility As Label
        Private cbVisibility As ComboBox
        Private lDisplay As Label
        Private cbDisplay As ComboBox
        Private label3 As Label
        Private cbAllowTextToFlow As ComboBox
        Private label4 As Label
        Private cbAllowFloatingObject As ComboBox
        Private gbContent As GroupBox
        Private gbClipping As GroupBox
        Private label9 As Label
        Private label8 As Label
        Private label7 As Label
        Private label6 As Label
        Private tbRight As TextBox
        Private tbBottom As TextBox
        Private tbLeft As TextBox
        Private tbTop As TextBox
        Private cbRightType As ComboBox
        Private cbBottomType As ComboBox
        Private cbLeftType As ComboBox
        Private cbTopType As ComboBox
        Private label5 As Label
        Private cbOverflow As ComboBox
        Private gbPageBreaks As GroupBox
        Private lAfter As Label
        Private lBefore As Label
        Private cbPbAfter As ComboBox
        Private cbPbBefore As ComboBox
    End Class

End Namespace
