Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucEdges
    ''' </summary>
    Partial Public Class ucEdges
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
            Me.scMarginsPadding = New System.Windows.Forms.SplitContainer()
            Me.gbMargins = New System.Windows.Forms.GroupBox()
            Me.tbMRight = New System.Windows.Forms.TextBox()
            Me.tbMLeft = New System.Windows.Forms.TextBox()
            Me.tbMBottom = New System.Windows.Forms.TextBox()
            Me.tbMTop = New System.Windows.Forms.TextBox()
            Me.lMRight = New System.Windows.Forms.Label()
            Me.lMLeft = New System.Windows.Forms.Label()
            Me.lMBottom = New System.Windows.Forms.Label()
            Me.lMTop = New System.Windows.Forms.Label()
            Me.cbMRightType = New System.Windows.Forms.ComboBox()
            Me.cbMLeftType = New System.Windows.Forms.ComboBox()
            Me.cbMBottomType = New System.Windows.Forms.ComboBox()
            Me.cbMTopType = New System.Windows.Forms.ComboBox()
            Me.gbPadding = New System.Windows.Forms.GroupBox()
            Me.tbPRight = New System.Windows.Forms.TextBox()
            Me.tbPLeft = New System.Windows.Forms.TextBox()
            Me.tbPBottom = New System.Windows.Forms.TextBox()
            Me.tbPTop = New System.Windows.Forms.TextBox()
            Me.lPRight = New System.Windows.Forms.Label()
            Me.lPLeft = New System.Windows.Forms.Label()
            Me.lPBottom = New System.Windows.Forms.Label()
            Me.lPTop = New System.Windows.Forms.Label()
            Me.cbPRightType = New System.Windows.Forms.ComboBox()
            Me.cbPLeftType = New System.Windows.Forms.ComboBox()
            Me.cbPBottomType = New System.Windows.Forms.ComboBox()
            Me.cbPTopType = New System.Windows.Forms.ComboBox()
            Me.scEdges = New System.Windows.Forms.SplitContainer()
            Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.gbLeft = New System.Windows.Forms.GroupBox()
            Me.btLeftColor = New System.Windows.Forms.Button()
            Me.tbLeftWidth = New System.Windows.Forms.TextBox()
            Me.cbLeftWidthType = New System.Windows.Forms.ComboBox()
            Me.lLeftColor = New System.Windows.Forms.Label()
            Me.lLeftWidth = New System.Windows.Forms.Label()
            Me.lLeftStyle = New System.Windows.Forms.Label()
            Me.cbLeftColor = New System.Windows.Forms.ComboBox()
            Me.cbLeftWidth = New System.Windows.Forms.ComboBox()
            Me.cbLeftStyle = New System.Windows.Forms.ComboBox()
            Me.gbTop = New System.Windows.Forms.GroupBox()
            Me.btTopColor = New System.Windows.Forms.Button()
            Me.tbTopWidth = New System.Windows.Forms.TextBox()
            Me.cbTopWidthType = New System.Windows.Forms.ComboBox()
            Me.lTopColor = New System.Windows.Forms.Label()
            Me.lTopWidth = New System.Windows.Forms.Label()
            Me.lTopStyle = New System.Windows.Forms.Label()
            Me.cbTopColor = New System.Windows.Forms.ComboBox()
            Me.cbTopWidth = New System.Windows.Forms.ComboBox()
            Me.cbTopStyle = New System.Windows.Forms.ComboBox()
            Me.splitContainer3 = New System.Windows.Forms.SplitContainer()
            Me.gbRight = New System.Windows.Forms.GroupBox()
            Me.btRightColor = New System.Windows.Forms.Button()
            Me.tbRightWidth = New System.Windows.Forms.TextBox()
            Me.cbRightWidthType = New System.Windows.Forms.ComboBox()
            Me.lRightColor = New System.Windows.Forms.Label()
            Me.lRightWidth = New System.Windows.Forms.Label()
            Me.lRightStyle = New System.Windows.Forms.Label()
            Me.cbRightColor = New System.Windows.Forms.ComboBox()
            Me.cbRightWidth = New System.Windows.Forms.ComboBox()
            Me.cbRightStyle = New System.Windows.Forms.ComboBox()
            Me.gbBottom = New System.Windows.Forms.GroupBox()
            Me.btBottomColor = New System.Windows.Forms.Button()
            Me.tbBottomWidth = New System.Windows.Forms.TextBox()
            Me.cbBottomWidthType = New System.Windows.Forms.ComboBox()
            Me.lBottomColor = New System.Windows.Forms.Label()
            Me.lBottomWidth = New System.Windows.Forms.Label()
            Me.lBottomStyle = New System.Windows.Forms.Label()
            Me.cbBottomColor = New System.Windows.Forms.ComboBox()
            Me.cbBottomWidth = New System.Windows.Forms.ComboBox()
            Me.cbBottomStyle = New System.Windows.Forms.ComboBox()
            Me.dlgColor = New System.Windows.Forms.ColorDialog()
            Me.scMarginsPadding.Panel1.SuspendLayout()
            Me.scMarginsPadding.Panel2.SuspendLayout()
            Me.scMarginsPadding.SuspendLayout()
            Me.gbMargins.SuspendLayout()
            Me.gbPadding.SuspendLayout()
            Me.scEdges.Panel1.SuspendLayout()
            Me.scEdges.Panel2.SuspendLayout()
            Me.scEdges.SuspendLayout()
            Me.splitContainer2.Panel1.SuspendLayout()
            Me.splitContainer2.Panel2.SuspendLayout()
            Me.splitContainer2.SuspendLayout()
            Me.gbLeft.SuspendLayout()
            Me.gbTop.SuspendLayout()
            Me.splitContainer3.Panel1.SuspendLayout()
            Me.splitContainer3.Panel2.SuspendLayout()
            Me.splitContainer3.SuspendLayout()
            Me.gbRight.SuspendLayout()
            Me.gbBottom.SuspendLayout()
            Me.SuspendLayout()
            '
            ' scMarginsPadding
            '
            Me.scMarginsPadding.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.scMarginsPadding.Location = New System.Drawing.Point(3, 3)
            Me.scMarginsPadding.Name = "scMarginsPadding"
            '
            ' scMarginsPadding.Panel1
            '
            Me.scMarginsPadding.Panel1.Controls.Add(Me.gbMargins)
            '
            ' scMarginsPadding.Panel2
            '
            Me.scMarginsPadding.Panel2.Controls.Add(Me.gbPadding)
            Me.scMarginsPadding.Size = New System.Drawing.Size(454, 142)
            Me.scMarginsPadding.SplitterDistance = 227
            Me.scMarginsPadding.SplitterWidth = 1
            Me.scMarginsPadding.TabIndex = 0
            '
            ' gbMargins
            '
            Me.gbMargins.Controls.Add(Me.tbMRight)
            Me.gbMargins.Controls.Add(Me.tbMLeft)
            Me.gbMargins.Controls.Add(Me.tbMBottom)
            Me.gbMargins.Controls.Add(Me.tbMTop)
            Me.gbMargins.Controls.Add(Me.lMRight)
            Me.gbMargins.Controls.Add(Me.lMLeft)
            Me.gbMargins.Controls.Add(Me.lMBottom)
            Me.gbMargins.Controls.Add(Me.lMTop)
            Me.gbMargins.Controls.Add(Me.cbMRightType)
            Me.gbMargins.Controls.Add(Me.cbMLeftType)
            Me.gbMargins.Controls.Add(Me.cbMBottomType)
            Me.gbMargins.Controls.Add(Me.cbMTopType)
            Me.gbMargins.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbMargins.Location = New System.Drawing.Point(0, 0)
            Me.gbMargins.Name = "gbMargins"
            Me.gbMargins.Size = New System.Drawing.Size(227, 142)
            Me.gbMargins.TabIndex = 0
            Me.gbMargins.TabStop = False
            Me.gbMargins.Text = "&Margins"
            '
            ' tbMRight
            '
            Me.tbMRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbMRight.Location = New System.Drawing.Point(54, 100)
            Me.tbMRight.Name = "tbMRight"
            Me.tbMRight.Size = New System.Drawing.Size(100, 20)
            Me.tbMRight.TabIndex = 11
            '
            ' tbMLeft
            '
            Me.tbMLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbMLeft.Location = New System.Drawing.Point(53, 73)
            Me.tbMLeft.Name = "tbMLeft"
            Me.tbMLeft.Size = New System.Drawing.Size(100, 20)
            Me.tbMLeft.TabIndex = 10
            '
            ' tbMBottom
            '
            Me.tbMBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbMBottom.Location = New System.Drawing.Point(53, 46)
            Me.tbMBottom.Name = "tbMBottom"
            Me.tbMBottom.Size = New System.Drawing.Size(100, 20)
            Me.tbMBottom.TabIndex = 9
            '
            ' tbMTop
            '
            Me.tbMTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbMTop.Location = New System.Drawing.Point(54, 19)
            Me.tbMTop.Name = "tbMTop"
            Me.tbMTop.Size = New System.Drawing.Size(100, 20)
            Me.tbMTop.TabIndex = 8
            '
            ' lMRight
            '
            Me.lMRight.AutoSize = True
            Me.lMRight.Location = New System.Drawing.Point(6, 103)
            Me.lMRight.Name = "lMRight"
            Me.lMRight.Size = New System.Drawing.Size(35, 13)
            Me.lMRight.TabIndex = 7
            Me.lMRight.Text = "Right:"
            '
            ' lMLeft
            '
            Me.lMLeft.AutoSize = True
            Me.lMLeft.Location = New System.Drawing.Point(6, 76)
            Me.lMLeft.Name = "lMLeft"
            Me.lMLeft.Size = New System.Drawing.Size(28, 13)
            Me.lMLeft.TabIndex = 6
            Me.lMLeft.Text = "Left:"
            '
            ' lMBottom
            '
            Me.lMBottom.AutoSize = True
            Me.lMBottom.Location = New System.Drawing.Point(6, 49)
            Me.lMBottom.Name = "lMBottom"
            Me.lMBottom.Size = New System.Drawing.Size(43, 13)
            Me.lMBottom.TabIndex = 5
            Me.lMBottom.Text = "Bottom:"
            '
            ' lMTop
            '
            Me.lMTop.AutoSize = True
            Me.lMTop.Location = New System.Drawing.Point(6, 22)
            Me.lMTop.Name = "lMTop"
            Me.lMTop.Size = New System.Drawing.Size(29, 13)
            Me.lMTop.TabIndex = 4
            Me.lMTop.Text = "Top:"
            '
            ' cbMRightType
            '
            Me.cbMRightType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbMRightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbMRightType.FormattingEnabled = True
            Me.cbMRightType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbMRightType.Location = New System.Drawing.Point(159, 100)
            Me.cbMRightType.Name = "cbMRightType"
            Me.cbMRightType.Size = New System.Drawing.Size(62, 21)
            Me.cbMRightType.TabIndex = 3
            '
            ' cbMLeftType
            '
            Me.cbMLeftType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbMLeftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbMLeftType.FormattingEnabled = True
            Me.cbMLeftType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbMLeftType.Location = New System.Drawing.Point(159, 73)
            Me.cbMLeftType.Name = "cbMLeftType"
            Me.cbMLeftType.Size = New System.Drawing.Size(62, 21)
            Me.cbMLeftType.TabIndex = 2
            '
            ' cbMBottomType
            '
            Me.cbMBottomType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbMBottomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbMBottomType.FormattingEnabled = True
            Me.cbMBottomType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbMBottomType.Location = New System.Drawing.Point(159, 46)
            Me.cbMBottomType.Name = "cbMBottomType"
            Me.cbMBottomType.Size = New System.Drawing.Size(62, 21)
            Me.cbMBottomType.TabIndex = 1
            '
            ' cbMTopType
            '
            Me.cbMTopType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbMTopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbMTopType.FormattingEnabled = True
            Me.cbMTopType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbMTopType.Location = New System.Drawing.Point(160, 19)
            Me.cbMTopType.Name = "cbMTopType"
            Me.cbMTopType.Size = New System.Drawing.Size(62, 21)
            Me.cbMTopType.TabIndex = 0
            '
            ' gbPadding
            '
            Me.gbPadding.Controls.Add(Me.tbPRight)
            Me.gbPadding.Controls.Add(Me.tbPLeft)
            Me.gbPadding.Controls.Add(Me.tbPBottom)
            Me.gbPadding.Controls.Add(Me.tbPTop)
            Me.gbPadding.Controls.Add(Me.lPRight)
            Me.gbPadding.Controls.Add(Me.lPLeft)
            Me.gbPadding.Controls.Add(Me.lPBottom)
            Me.gbPadding.Controls.Add(Me.lPTop)
            Me.gbPadding.Controls.Add(Me.cbPRightType)
            Me.gbPadding.Controls.Add(Me.cbPLeftType)
            Me.gbPadding.Controls.Add(Me.cbPBottomType)
            Me.gbPadding.Controls.Add(Me.cbPTopType)
            Me.gbPadding.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbPadding.Location = New System.Drawing.Point(0, 0)
            Me.gbPadding.Name = "gbPadding"
            Me.gbPadding.Size = New System.Drawing.Size(226, 142)
            Me.gbPadding.TabIndex = 0
            Me.gbPadding.TabStop = False
            Me.gbPadding.Text = "&Padding"
            '
            ' tbPRight
            '
            Me.tbPRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbPRight.Location = New System.Drawing.Point(52, 100)
            Me.tbPRight.Name = "tbPRight"
            Me.tbPRight.Size = New System.Drawing.Size(100, 20)
            Me.tbPRight.TabIndex = 11
            '
            ' tbPLeft
            '
            Me.tbPLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbPLeft.Location = New System.Drawing.Point(52, 73)
            Me.tbPLeft.Name = "tbPLeft"
            Me.tbPLeft.Size = New System.Drawing.Size(100, 20)
            Me.tbPLeft.TabIndex = 10
            '
            ' tbPBottom
            '
            Me.tbPBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbPBottom.Location = New System.Drawing.Point(52, 46)
            Me.tbPBottom.Name = "tbPBottom"
            Me.tbPBottom.Size = New System.Drawing.Size(100, 20)
            Me.tbPBottom.TabIndex = 9
            '
            ' tbPTop
            '
            Me.tbPTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbPTop.Location = New System.Drawing.Point(52, 19)
            Me.tbPTop.Name = "tbPTop"
            Me.tbPTop.Size = New System.Drawing.Size(100, 20)
            Me.tbPTop.TabIndex = 8
            '
            ' lPRight
            '
            Me.lPRight.AutoSize = True
            Me.lPRight.Location = New System.Drawing.Point(6, 103)
            Me.lPRight.Name = "lPRight"
            Me.lPRight.Size = New System.Drawing.Size(35, 13)
            Me.lPRight.TabIndex = 7
            Me.lPRight.Text = "Right:"
            '
            ' lPLeft
            '
            Me.lPLeft.AutoSize = True
            Me.lPLeft.Location = New System.Drawing.Point(5, 76)
            Me.lPLeft.Name = "lPLeft"
            Me.lPLeft.Size = New System.Drawing.Size(28, 13)
            Me.lPLeft.TabIndex = 6
            Me.lPLeft.Text = "Left:"
            '
            ' lPBottom
            '
            Me.lPBottom.AutoSize = True
            Me.lPBottom.Location = New System.Drawing.Point(5, 49)
            Me.lPBottom.Name = "lPBottom"
            Me.lPBottom.Size = New System.Drawing.Size(43, 13)
            Me.lPBottom.TabIndex = 5
            Me.lPBottom.Text = "Bottom:"
            '
            ' lPTop
            '
            Me.lPTop.AutoSize = True
            Me.lPTop.Location = New System.Drawing.Point(5, 22)
            Me.lPTop.Name = "lPTop"
            Me.lPTop.Size = New System.Drawing.Size(29, 13)
            Me.lPTop.TabIndex = 4
            Me.lPTop.Text = "Top:"
            '
            ' cbPRightType
            '
            Me.cbPRightType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbPRightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPRightType.FormattingEnabled = True
            Me.cbPRightType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbPRightType.Location = New System.Drawing.Point(158, 100)
            Me.cbPRightType.Name = "cbPRightType"
            Me.cbPRightType.Size = New System.Drawing.Size(62, 21)
            Me.cbPRightType.TabIndex = 3
            '
            ' cbPLeftType
            '
            Me.cbPLeftType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbPLeftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPLeftType.FormattingEnabled = True
            Me.cbPLeftType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbPLeftType.Location = New System.Drawing.Point(158, 73)
            Me.cbPLeftType.Name = "cbPLeftType"
            Me.cbPLeftType.Size = New System.Drawing.Size(62, 21)
            Me.cbPLeftType.TabIndex = 2
            '
            ' cbPBottomType
            '
            Me.cbPBottomType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbPBottomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPBottomType.FormattingEnabled = True
            Me.cbPBottomType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbPBottomType.Location = New System.Drawing.Point(158, 46)
            Me.cbPBottomType.Name = "cbPBottomType"
            Me.cbPBottomType.Size = New System.Drawing.Size(62, 21)
            Me.cbPBottomType.TabIndex = 1
            '
            ' cbPTopType
            '
            Me.cbPTopType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbPTopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPTopType.FormattingEnabled = True
            Me.cbPTopType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbPTopType.Location = New System.Drawing.Point(158, 19)
            Me.cbPTopType.Name = "cbPTopType"
            Me.cbPTopType.Size = New System.Drawing.Size(62, 21)
            Me.cbPTopType.TabIndex = 0
            '
            ' scEdges
            '
            Me.scEdges.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.scEdges.Location = New System.Drawing.Point(3, 151)
            Me.scEdges.Name = "scEdges"
            '
            ' scEdges.Panel1
            '
            Me.scEdges.Panel1.Controls.Add(Me.splitContainer2)
            '
            ' scEdges.Panel2
            '
            Me.scEdges.Panel2.Controls.Add(Me.splitContainer3)
            Me.scEdges.Size = New System.Drawing.Size(454, 216)
            Me.scEdges.SplitterDistance = 227
            Me.scEdges.SplitterWidth = 1
            Me.scEdges.TabIndex = 1
            '
            ' splitContainer2
            '
            Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer2.Name = "splitContainer2"
            Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            ' splitContainer2.Panel1
            '
            Me.splitContainer2.Panel1.Controls.Add(Me.gbLeft)
            '
            ' splitContainer2.Panel2
            '
            Me.splitContainer2.Panel2.Controls.Add(Me.gbTop)
            Me.splitContainer2.Size = New System.Drawing.Size(227, 216)
            Me.splitContainer2.SplitterDistance = 108
            Me.splitContainer2.SplitterWidth = 1
            Me.splitContainer2.TabIndex = 0
            '
            ' gbLeft
            '
            Me.gbLeft.Controls.Add(Me.btLeftColor)
            Me.gbLeft.Controls.Add(Me.tbLeftWidth)
            Me.gbLeft.Controls.Add(Me.cbLeftWidthType)
            Me.gbLeft.Controls.Add(Me.lLeftColor)
            Me.gbLeft.Controls.Add(Me.lLeftWidth)
            Me.gbLeft.Controls.Add(Me.lLeftStyle)
            Me.gbLeft.Controls.Add(Me.cbLeftColor)
            Me.gbLeft.Controls.Add(Me.cbLeftWidth)
            Me.gbLeft.Controls.Add(Me.cbLeftStyle)
            Me.gbLeft.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbLeft.Location = New System.Drawing.Point(0, 0)
            Me.gbLeft.Name = "gbLeft"
            Me.gbLeft.Size = New System.Drawing.Size(227, 108)
            Me.gbLeft.TabIndex = 0
            Me.gbLeft.TabStop = False
            Me.gbLeft.Text = "Left edge"
            '
            ' btLeftColor
            '
            Me.btLeftColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btLeftColor.Location = New System.Drawing.Point(175, 71)
            Me.btLeftColor.Name = "btLeftColor"
            Me.btLeftColor.Size = New System.Drawing.Size(46, 23)
            Me.btLeftColor.TabIndex = 8
            Me.btLeftColor.Text = "..."
            Me.btLeftColor.UseVisualStyleBackColor = True
            '
            ' tbLeftWidth
            '
            Me.tbLeftWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbLeftWidth.Location = New System.Drawing.Point(121, 46)
            Me.tbLeftWidth.Name = "tbLeftWidth"
            Me.tbLeftWidth.Size = New System.Drawing.Size(48, 20)
            Me.tbLeftWidth.TabIndex = 7
            '
            ' cbLeftWidthType
            '
            Me.cbLeftWidthType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbLeftWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbLeftWidthType.FormattingEnabled = True
            Me.cbLeftWidthType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbLeftWidthType.Location = New System.Drawing.Point(175, 46)
            Me.cbLeftWidthType.Name = "cbLeftWidthType"
            Me.cbLeftWidthType.Size = New System.Drawing.Size(46, 21)
            Me.cbLeftWidthType.TabIndex = 6
            '
            ' lLeftColor
            '
            Me.lLeftColor.AutoSize = True
            Me.lLeftColor.Location = New System.Drawing.Point(6, 76)
            Me.lLeftColor.Name = "lLeftColor"
            Me.lLeftColor.Size = New System.Drawing.Size(34, 13)
            Me.lLeftColor.TabIndex = 5
            Me.lLeftColor.Text = "Color:"
            '
            ' lLeftWidth
            '
            Me.lLeftWidth.AutoSize = True
            Me.lLeftWidth.Location = New System.Drawing.Point(6, 49)
            Me.lLeftWidth.Name = "lLeftWidth"
            Me.lLeftWidth.Size = New System.Drawing.Size(38, 13)
            Me.lLeftWidth.TabIndex = 4
            Me.lLeftWidth.Text = "Width:"
            '
            ' lLeftStyle
            '
            Me.lLeftStyle.AutoSize = True
            Me.lLeftStyle.Location = New System.Drawing.Point(6, 22)
            Me.lLeftStyle.Name = "lLeftStyle"
            Me.lLeftStyle.Size = New System.Drawing.Size(33, 13)
            Me.lLeftStyle.TabIndex = 3
            Me.lLeftStyle.Text = "Style:"
            '
            ' cbLeftColor
            '
            Me.cbLeftColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbLeftColor.FormattingEnabled = True
            Me.cbLeftColor.Items.AddRange(New Object() {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"})
            Me.cbLeftColor.Location = New System.Drawing.Point(54, 73)
            Me.cbLeftColor.Name = "cbLeftColor"
            Me.cbLeftColor.Size = New System.Drawing.Size(115, 21)
            Me.cbLeftColor.TabIndex = 2
            '
            ' cbLeftWidth
            '
            Me.cbLeftWidth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbLeftWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbLeftWidth.FormattingEnabled = True
            Me.cbLeftWidth.Items.AddRange(New Object() {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"})
            Me.cbLeftWidth.Location = New System.Drawing.Point(54, 46)
            Me.cbLeftWidth.Name = "cbLeftWidth"
            Me.cbLeftWidth.Size = New System.Drawing.Size(61, 21)
            Me.cbLeftWidth.TabIndex = 1
            '
            ' cbLeftStyle
            '
            Me.cbLeftStyle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbLeftStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbLeftStyle.FormattingEnabled = True
            Me.cbLeftStyle.Location = New System.Drawing.Point(54, 19)
            Me.cbLeftStyle.Name = "cbLeftStyle"
            Me.cbLeftStyle.Size = New System.Drawing.Size(115, 21)
            Me.cbLeftStyle.TabIndex = 0
            '
            ' gbTop
            '
            Me.gbTop.Controls.Add(Me.btTopColor)
            Me.gbTop.Controls.Add(Me.tbTopWidth)
            Me.gbTop.Controls.Add(Me.cbTopWidthType)
            Me.gbTop.Controls.Add(Me.lTopColor)
            Me.gbTop.Controls.Add(Me.lTopWidth)
            Me.gbTop.Controls.Add(Me.lTopStyle)
            Me.gbTop.Controls.Add(Me.cbTopColor)
            Me.gbTop.Controls.Add(Me.cbTopWidth)
            Me.gbTop.Controls.Add(Me.cbTopStyle)
            Me.gbTop.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbTop.Location = New System.Drawing.Point(0, 0)
            Me.gbTop.Name = "gbTop"
            Me.gbTop.Size = New System.Drawing.Size(227, 107)
            Me.gbTop.TabIndex = 0
            Me.gbTop.TabStop = False
            Me.gbTop.Text = "Top edge"
            '
            ' btTopColor
            '
            Me.btTopColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btTopColor.Location = New System.Drawing.Point(175, 68)
            Me.btTopColor.Name = "btTopColor"
            Me.btTopColor.Size = New System.Drawing.Size(46, 23)
            Me.btTopColor.TabIndex = 17
            Me.btTopColor.Text = "..."
            Me.btTopColor.UseVisualStyleBackColor = True
            '
            ' tbTopWidth
            '
            Me.tbTopWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbTopWidth.Location = New System.Drawing.Point(121, 43)
            Me.tbTopWidth.Name = "tbTopWidth"
            Me.tbTopWidth.Size = New System.Drawing.Size(48, 20)
            Me.tbTopWidth.TabIndex = 16
            '
            ' cbTopWidthType
            '
            Me.cbTopWidthType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbTopWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTopWidthType.FormattingEnabled = True
            Me.cbTopWidthType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbTopWidthType.Location = New System.Drawing.Point(175, 43)
            Me.cbTopWidthType.Name = "cbTopWidthType"
            Me.cbTopWidthType.Size = New System.Drawing.Size(46, 21)
            Me.cbTopWidthType.TabIndex = 15
            '
            ' lTopColor
            '
            Me.lTopColor.AutoSize = True
            Me.lTopColor.Location = New System.Drawing.Point(6, 73)
            Me.lTopColor.Name = "lTopColor"
            Me.lTopColor.Size = New System.Drawing.Size(34, 13)
            Me.lTopColor.TabIndex = 14
            Me.lTopColor.Text = "Color:"
            '
            ' lTopWidth
            '
            Me.lTopWidth.AutoSize = True
            Me.lTopWidth.Location = New System.Drawing.Point(6, 46)
            Me.lTopWidth.Name = "lTopWidth"
            Me.lTopWidth.Size = New System.Drawing.Size(38, 13)
            Me.lTopWidth.TabIndex = 13
            Me.lTopWidth.Text = "Width:"
            '
            ' lTopStyle
            '
            Me.lTopStyle.AutoSize = True
            Me.lTopStyle.Location = New System.Drawing.Point(6, 19)
            Me.lTopStyle.Name = "lTopStyle"
            Me.lTopStyle.Size = New System.Drawing.Size(33, 13)
            Me.lTopStyle.TabIndex = 12
            Me.lTopStyle.Text = "Style:"
            '
            ' cbTopColor
            '
            Me.cbTopColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbTopColor.FormattingEnabled = True
            Me.cbTopColor.Items.AddRange(New Object() {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"})
            Me.cbTopColor.Location = New System.Drawing.Point(54, 70)
            Me.cbTopColor.Name = "cbTopColor"
            Me.cbTopColor.Size = New System.Drawing.Size(115, 21)
            Me.cbTopColor.TabIndex = 11
            '
            ' cbTopWidth
            '
            Me.cbTopWidth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbTopWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTopWidth.FormattingEnabled = True
            Me.cbTopWidth.Items.AddRange(New Object() {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"})
            Me.cbTopWidth.Location = New System.Drawing.Point(54, 43)
            Me.cbTopWidth.Name = "cbTopWidth"
            Me.cbTopWidth.Size = New System.Drawing.Size(61, 21)
            Me.cbTopWidth.TabIndex = 10
            '
            ' cbTopStyle
            '
            Me.cbTopStyle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbTopStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTopStyle.FormattingEnabled = True
            Me.cbTopStyle.Location = New System.Drawing.Point(54, 16)
            Me.cbTopStyle.Name = "cbTopStyle"
            Me.cbTopStyle.Size = New System.Drawing.Size(115, 21)
            Me.cbTopStyle.TabIndex = 9
            '
            ' splitContainer3
            '
            Me.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer3.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer3.Name = "splitContainer3"
            Me.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            ' splitContainer3.Panel1
            '
            Me.splitContainer3.Panel1.Controls.Add(Me.gbRight)
            '
            ' splitContainer3.Panel2
            '
            Me.splitContainer3.Panel2.Controls.Add(Me.gbBottom)
            Me.splitContainer3.Size = New System.Drawing.Size(226, 216)
            Me.splitContainer3.SplitterDistance = 108
            Me.splitContainer3.SplitterWidth = 1
            Me.splitContainer3.TabIndex = 0
            '
            ' gbRight
            '
            Me.gbRight.Controls.Add(Me.btRightColor)
            Me.gbRight.Controls.Add(Me.tbRightWidth)
            Me.gbRight.Controls.Add(Me.cbRightWidthType)
            Me.gbRight.Controls.Add(Me.lRightColor)
            Me.gbRight.Controls.Add(Me.lRightWidth)
            Me.gbRight.Controls.Add(Me.lRightStyle)
            Me.gbRight.Controls.Add(Me.cbRightColor)
            Me.gbRight.Controls.Add(Me.cbRightWidth)
            Me.gbRight.Controls.Add(Me.cbRightStyle)
            Me.gbRight.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbRight.Location = New System.Drawing.Point(0, 0)
            Me.gbRight.Name = "gbRight"
            Me.gbRight.Size = New System.Drawing.Size(226, 108)
            Me.gbRight.TabIndex = 0
            Me.gbRight.TabStop = False
            Me.gbRight.Text = "Right edge"
            '
            ' btRightColor
            '
            Me.btRightColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btRightColor.Location = New System.Drawing.Point(175, 71)
            Me.btRightColor.Name = "btRightColor"
            Me.btRightColor.Size = New System.Drawing.Size(46, 23)
            Me.btRightColor.TabIndex = 17
            Me.btRightColor.Text = "..."
            Me.btRightColor.UseVisualStyleBackColor = True
            '
            ' tbRightWidth
            '
            Me.tbRightWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbRightWidth.Location = New System.Drawing.Point(121, 46)
            Me.tbRightWidth.Name = "tbRightWidth"
            Me.tbRightWidth.Size = New System.Drawing.Size(48, 20)
            Me.tbRightWidth.TabIndex = 16
            '
            ' cbRightWidthType
            '
            Me.cbRightWidthType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbRightWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbRightWidthType.FormattingEnabled = True
            Me.cbRightWidthType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbRightWidthType.Location = New System.Drawing.Point(175, 46)
            Me.cbRightWidthType.Name = "cbRightWidthType"
            Me.cbRightWidthType.Size = New System.Drawing.Size(46, 21)
            Me.cbRightWidthType.TabIndex = 15
            '
            ' lRightColor
            '
            Me.lRightColor.AutoSize = True
            Me.lRightColor.Location = New System.Drawing.Point(6, 76)
            Me.lRightColor.Name = "lRightColor"
            Me.lRightColor.Size = New System.Drawing.Size(34, 13)
            Me.lRightColor.TabIndex = 14
            Me.lRightColor.Text = "Color:"
            '
            ' lRightWidth
            '
            Me.lRightWidth.AutoSize = True
            Me.lRightWidth.Location = New System.Drawing.Point(6, 49)
            Me.lRightWidth.Name = "lRightWidth"
            Me.lRightWidth.Size = New System.Drawing.Size(38, 13)
            Me.lRightWidth.TabIndex = 13
            Me.lRightWidth.Text = "Width:"
            '
            ' lRightStyle
            '
            Me.lRightStyle.AutoSize = True
            Me.lRightStyle.Location = New System.Drawing.Point(6, 22)
            Me.lRightStyle.Name = "lRightStyle"
            Me.lRightStyle.Size = New System.Drawing.Size(33, 13)
            Me.lRightStyle.TabIndex = 12
            Me.lRightStyle.Text = "Style:"
            '
            ' cbRightColor
            '
            Me.cbRightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbRightColor.FormattingEnabled = True
            Me.cbRightColor.Items.AddRange(New Object() {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"})
            Me.cbRightColor.Location = New System.Drawing.Point(54, 73)
            Me.cbRightColor.Name = "cbRightColor"
            Me.cbRightColor.Size = New System.Drawing.Size(115, 21)
            Me.cbRightColor.TabIndex = 11
            '
            ' cbRightWidth
            '
            Me.cbRightWidth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbRightWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbRightWidth.FormattingEnabled = True
            Me.cbRightWidth.Items.AddRange(New Object() {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"})
            Me.cbRightWidth.Location = New System.Drawing.Point(54, 46)
            Me.cbRightWidth.Name = "cbRightWidth"
            Me.cbRightWidth.Size = New System.Drawing.Size(61, 21)
            Me.cbRightWidth.TabIndex = 10
            '
            ' cbRightStyle
            '
            Me.cbRightStyle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbRightStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbRightStyle.FormattingEnabled = True
            Me.cbRightStyle.Location = New System.Drawing.Point(54, 19)
            Me.cbRightStyle.Name = "cbRightStyle"
            Me.cbRightStyle.Size = New System.Drawing.Size(115, 21)
            Me.cbRightStyle.TabIndex = 9
            '
            ' gbBottom
            '
            Me.gbBottom.Controls.Add(Me.btBottomColor)
            Me.gbBottom.Controls.Add(Me.tbBottomWidth)
            Me.gbBottom.Controls.Add(Me.cbBottomWidthType)
            Me.gbBottom.Controls.Add(Me.lBottomColor)
            Me.gbBottom.Controls.Add(Me.lBottomWidth)
            Me.gbBottom.Controls.Add(Me.lBottomStyle)
            Me.gbBottom.Controls.Add(Me.cbBottomColor)
            Me.gbBottom.Controls.Add(Me.cbBottomWidth)
            Me.gbBottom.Controls.Add(Me.cbBottomStyle)
            Me.gbBottom.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbBottom.Location = New System.Drawing.Point(0, 0)
            Me.gbBottom.Name = "gbBottom"
            Me.gbBottom.Size = New System.Drawing.Size(226, 107)
            Me.gbBottom.TabIndex = 0
            Me.gbBottom.TabStop = False
            Me.gbBottom.Text = "Bottom Edge"
            '
            ' btBottomColor
            '
            Me.btBottomColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btBottomColor.Location = New System.Drawing.Point(175, 68)
            Me.btBottomColor.Name = "btBottomColor"
            Me.btBottomColor.Size = New System.Drawing.Size(46, 23)
            Me.btBottomColor.TabIndex = 17
            Me.btBottomColor.Text = "..."
            Me.btBottomColor.UseVisualStyleBackColor = True
            '
            ' tbBottomWidth
            '
            Me.tbBottomWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbBottomWidth.Location = New System.Drawing.Point(121, 43)
            Me.tbBottomWidth.Name = "tbBottomWidth"
            Me.tbBottomWidth.Size = New System.Drawing.Size(48, 20)
            Me.tbBottomWidth.TabIndex = 16
            '
            ' cbBottomWidthType
            '
            Me.cbBottomWidthType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBottomWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBottomWidthType.FormattingEnabled = True
            Me.cbBottomWidthType.Items.AddRange(New Object() {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"})
            Me.cbBottomWidthType.Location = New System.Drawing.Point(175, 43)
            Me.cbBottomWidthType.Name = "cbBottomWidthType"
            Me.cbBottomWidthType.Size = New System.Drawing.Size(46, 21)
            Me.cbBottomWidthType.TabIndex = 15
            '
            ' lBottomColor
            '
            Me.lBottomColor.AutoSize = True
            Me.lBottomColor.Location = New System.Drawing.Point(6, 73)
            Me.lBottomColor.Name = "lBottomColor"
            Me.lBottomColor.Size = New System.Drawing.Size(34, 13)
            Me.lBottomColor.TabIndex = 14
            Me.lBottomColor.Text = "Color:"
            '
            ' lBottomWidth
            '
            Me.lBottomWidth.AutoSize = True
            Me.lBottomWidth.Location = New System.Drawing.Point(6, 46)
            Me.lBottomWidth.Name = "lBottomWidth"
            Me.lBottomWidth.Size = New System.Drawing.Size(38, 13)
            Me.lBottomWidth.TabIndex = 13
            Me.lBottomWidth.Text = "Width:"
            '
            ' lBottomStyle
            '
            Me.lBottomStyle.AutoSize = True
            Me.lBottomStyle.Location = New System.Drawing.Point(6, 19)
            Me.lBottomStyle.Name = "lBottomStyle"
            Me.lBottomStyle.Size = New System.Drawing.Size(33, 13)
            Me.lBottomStyle.TabIndex = 12
            Me.lBottomStyle.Text = "Style:"
            '
            ' cbBottomColor
            '
            Me.cbBottomColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBottomColor.FormattingEnabled = True
            Me.cbBottomColor.Items.AddRange(New Object() {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"})
            Me.cbBottomColor.Location = New System.Drawing.Point(54, 70)
            Me.cbBottomColor.Name = "cbBottomColor"
            Me.cbBottomColor.Size = New System.Drawing.Size(115, 21)
            Me.cbBottomColor.TabIndex = 11
            '
            ' cbBottomWidth
            '
            Me.cbBottomWidth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBottomWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBottomWidth.FormattingEnabled = True
            Me.cbBottomWidth.Items.AddRange(New Object() {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"})
            Me.cbBottomWidth.Location = New System.Drawing.Point(54, 43)
            Me.cbBottomWidth.Name = "cbBottomWidth"
            Me.cbBottomWidth.Size = New System.Drawing.Size(61, 21)
            Me.cbBottomWidth.TabIndex = 10
            '
            ' cbBottomStyle
            '
            Me.cbBottomStyle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBottomStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBottomStyle.FormattingEnabled = True
            Me.cbBottomStyle.Location = New System.Drawing.Point(54, 16)
            Me.cbBottomStyle.Name = "cbBottomStyle"
            Me.cbBottomStyle.Size = New System.Drawing.Size(115, 21)
            Me.cbBottomStyle.TabIndex = 9
            '
            ' ucEdges
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.scEdges)
            Me.Controls.Add(Me.scMarginsPadding)
            Me.Name = "ucEdges"
            Me.Size = New System.Drawing.Size(460, 370)
            Me.scMarginsPadding.Panel1.ResumeLayout(False)
            Me.scMarginsPadding.Panel2.ResumeLayout(False)
            Me.scMarginsPadding.ResumeLayout(False)
            Me.gbMargins.ResumeLayout(False)
            Me.gbMargins.PerformLayout()
            Me.gbPadding.ResumeLayout(False)
            Me.gbPadding.PerformLayout()
            Me.scEdges.Panel1.ResumeLayout(False)
            Me.scEdges.Panel2.ResumeLayout(False)
            Me.scEdges.ResumeLayout(False)
            Me.splitContainer2.Panel1.ResumeLayout(False)
            Me.splitContainer2.Panel2.ResumeLayout(False)
            Me.splitContainer2.ResumeLayout(False)
            Me.gbLeft.ResumeLayout(False)
            Me.gbLeft.PerformLayout()
            Me.gbTop.ResumeLayout(False)
            Me.gbTop.PerformLayout()
            Me.splitContainer3.Panel1.ResumeLayout(False)
            Me.splitContainer3.Panel2.ResumeLayout(False)
            Me.splitContainer3.ResumeLayout(False)
            Me.gbRight.ResumeLayout(False)
            Me.gbRight.PerformLayout()
            Me.gbBottom.ResumeLayout(False)
            Me.gbBottom.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private scMarginsPadding As SplitContainer
        Private gbMargins As GroupBox
        Private gbPadding As GroupBox
        Private tbMRight As TextBox
        Private tbMLeft As TextBox
        Private tbMBottom As TextBox
        Private tbMTop As TextBox
        Private lMRight As Label
        Private lMLeft As Label
        Private lMBottom As Label
        Private lMTop As Label
        Private cbMRightType As ComboBox
        Private cbMLeftType As ComboBox
        Private cbMBottomType As ComboBox
        Private cbMTopType As ComboBox
        Private tbPRight As TextBox
        Private tbPLeft As TextBox
        Private tbPBottom As TextBox
        Private tbPTop As TextBox
        Private lPRight As Label
        Private lPLeft As Label
        Private lPBottom As Label
        Private lPTop As Label
        Private cbPRightType As ComboBox
        Private cbPLeftType As ComboBox
        Private cbPBottomType As ComboBox
        Private cbPTopType As ComboBox
        Private scEdges As SplitContainer
        Private splitContainer2 As SplitContainer
        Private gbLeft As GroupBox
        Private cbLeftColor As ComboBox
        Private WithEvents cbLeftWidth As ComboBox
        Private WithEvents cbLeftStyle As ComboBox
        Private gbTop As GroupBox
        Private splitContainer3 As SplitContainer
        Private gbRight As GroupBox
        Private gbBottom As GroupBox
        Private lLeftColor As Label
        Private lLeftWidth As Label
        Private lLeftStyle As Label
        Private WithEvents btLeftColor As Button
        Private tbLeftWidth As TextBox
        Private cbLeftWidthType As ComboBox
        Private WithEvents btTopColor As Button
        Private tbTopWidth As TextBox
        Private cbTopWidthType As ComboBox
        Private lTopColor As Label
        Private lTopWidth As Label
        Private lTopStyle As Label
        Private cbTopColor As ComboBox
        Private WithEvents cbTopWidth As ComboBox
        Private WithEvents cbTopStyle As ComboBox
        Private WithEvents btRightColor As Button
        Private tbRightWidth As TextBox
        Private cbRightWidthType As ComboBox
        Private lRightColor As Label
        Private lRightWidth As Label
        Private lRightStyle As Label
        Private cbRightColor As ComboBox
        Private WithEvents cbRightWidth As ComboBox
        Private WithEvents cbRightStyle As ComboBox
        Private WithEvents btBottomColor As Button
        Private tbBottomWidth As TextBox
        Private cbBottomWidthType As ComboBox
        Private lBottomColor As Label
        Private lBottomWidth As Label
        Private lBottomStyle As Label
        Private cbBottomColor As ComboBox
        Private WithEvents cbBottomWidth As ComboBox
        Private WithEvents cbBottomStyle As ComboBox
        Private dlgColor As ColorDialog
    End Class

End Namespace
