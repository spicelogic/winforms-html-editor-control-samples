Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucOther
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
            Me.gbUserInterface = New System.Windows.Forms.GroupBox()
            Me.lCursor = New System.Windows.Forms.Label()
            Me.cbCursor = New System.Windows.Forms.ComboBox()
            Me.gbTables = New System.Windows.Forms.GroupBox()
            Me.scBordersLayout = New System.Windows.Forms.SplitContainer()
            Me.lBorders = New System.Windows.Forms.Label()
            Me.cbBorders = New System.Windows.Forms.ComboBox()
            Me.lLayout = New System.Windows.Forms.Label()
            Me.cbLayout = New System.Windows.Forms.ComboBox()
            Me.gbVisualEffects = New System.Windows.Forms.GroupBox()
            Me.tbFilter = New System.Windows.Forms.TextBox()
            Me.lFilter = New System.Windows.Forms.Label()
            Me.gbBehavior = New System.Windows.Forms.GroupBox()
            Me.tbURL = New System.Windows.Forms.TextBox()
            Me.lURL = New System.Windows.Forms.Label()
            Me.gbUserInterface.SuspendLayout()
            Me.gbTables.SuspendLayout()
            Me.scBordersLayout.Panel1.SuspendLayout()
            Me.scBordersLayout.Panel2.SuspendLayout()
            Me.scBordersLayout.SuspendLayout()
            Me.gbVisualEffects.SuspendLayout()
            Me.gbBehavior.SuspendLayout()
            Me.SuspendLayout()
            '
            ' gbUserInterface
            '
            Me.gbUserInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbUserInterface.Controls.Add(Me.cbCursor)
            Me.gbUserInterface.Controls.Add(Me.lCursor)
            Me.gbUserInterface.Location = New System.Drawing.Point(3, 3)
            Me.gbUserInterface.Name = "gbUserInterface"
            Me.gbUserInterface.Size = New System.Drawing.Size(454, 65)
            Me.gbUserInterface.TabIndex = 0
            Me.gbUserInterface.TabStop = False
            Me.gbUserInterface.Text = "User interface"
            '
            ' lCursor
            '
            Me.lCursor.AutoSize = True
            Me.lCursor.Location = New System.Drawing.Point(6, 16)
            Me.lCursor.Name = "lCursor"
            Me.lCursor.Size = New System.Drawing.Size(40, 13)
            Me.lCursor.TabIndex = 0
            Me.lCursor.Text = "&Cursor:"
            '
            ' cbCursor
            '
            Me.cbCursor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbCursor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbCursor.FormattingEnabled = True
            Me.cbCursor.Location = New System.Drawing.Point(6, 32)
            Me.cbCursor.Name = "cbCursor"
            Me.cbCursor.Size = New System.Drawing.Size(442, 21)
            Me.cbCursor.TabIndex = 1
            '
            ' gbTables
            '
            Me.gbTables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbTables.Controls.Add(Me.scBordersLayout)
            Me.gbTables.Location = New System.Drawing.Point(3, 74)
            Me.gbTables.Name = "gbTables"
            Me.gbTables.Size = New System.Drawing.Size(454, 74)
            Me.gbTables.TabIndex = 1
            Me.gbTables.TabStop = False
            Me.gbTables.Text = "Tables"
            '
            ' scBordersLayout
            '
            Me.scBordersLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.scBordersLayout.Location = New System.Drawing.Point(3, 16)
            Me.scBordersLayout.Name = "scBordersLayout"
            '
            ' scBordersLayout.Panel1
            '
            Me.scBordersLayout.Panel1.Controls.Add(Me.cbBorders)
            Me.scBordersLayout.Panel1.Controls.Add(Me.lBorders)
            '
            ' scBordersLayout.Panel2
            '
            Me.scBordersLayout.Panel2.Controls.Add(Me.cbLayout)
            Me.scBordersLayout.Panel2.Controls.Add(Me.lLayout)
            Me.scBordersLayout.Size = New System.Drawing.Size(448, 55)
            Me.scBordersLayout.SplitterDistance = 224
            Me.scBordersLayout.SplitterWidth = 1
            Me.scBordersLayout.TabIndex = 0
            '
            ' lBorders
            '
            Me.lBorders.AutoSize = True
            Me.lBorders.Location = New System.Drawing.Point(3, 1)
            Me.lBorders.Name = "lBorders"
            Me.lBorders.Size = New System.Drawing.Size(46, 13)
            Me.lBorders.TabIndex = 0
            Me.lBorders.Text = "&Borders:"
            '
            ' cbBorders
            '
            Me.cbBorders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBorders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBorders.FormattingEnabled = True
            Me.cbBorders.Location = New System.Drawing.Point(3, 18)
            Me.cbBorders.Name = "cbBorders"
            Me.cbBorders.Size = New System.Drawing.Size(218, 21)
            Me.cbBorders.TabIndex = 1
            '
            ' lLayout
            '
            Me.lLayout.AutoSize = True
            Me.lLayout.Location = New System.Drawing.Point(3, 1)
            Me.lLayout.Name = "lLayout"
            Me.lLayout.Size = New System.Drawing.Size(42, 13)
            Me.lLayout.TabIndex = 0
            Me.lLayout.Text = "&Layout:"
            '
            ' cbLayout
            '
            Me.cbLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbLayout.FormattingEnabled = True
            Me.cbLayout.Location = New System.Drawing.Point(6, 18)
            Me.cbLayout.Name = "cbLayout"
            Me.cbLayout.Size = New System.Drawing.Size(214, 21)
            Me.cbLayout.TabIndex = 1
            '
            ' gbVisualEffects
            '
            Me.gbVisualEffects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbVisualEffects.Controls.Add(Me.lFilter)
            Me.gbVisualEffects.Controls.Add(Me.tbFilter)
            Me.gbVisualEffects.Location = New System.Drawing.Point(3, 154)
            Me.gbVisualEffects.Name = "gbVisualEffects"
            Me.gbVisualEffects.Size = New System.Drawing.Size(454, 54)
            Me.gbVisualEffects.TabIndex = 2
            Me.gbVisualEffects.TabStop = False
            Me.gbVisualEffects.Text = "Visual effects"
            '
            ' tbFilter
            '
            Me.tbFilter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbFilter.Location = New System.Drawing.Point(109, 19)
            Me.tbFilter.Name = "tbFilter"
            Me.tbFilter.Size = New System.Drawing.Size(339, 20)
            Me.tbFilter.TabIndex = 0
            '
            ' lFilter
            '
            Me.lFilter.AutoSize = True
            Me.lFilter.Location = New System.Drawing.Point(6, 22)
            Me.lFilter.Name = "lFilter"
            Me.lFilter.Size = New System.Drawing.Size(32, 13)
            Me.lFilter.TabIndex = 1
            Me.lFilter.Text = "&Filter:"
            '
            ' gbBehavior
            '
            Me.gbBehavior.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbBehavior.Controls.Add(Me.lURL)
            Me.gbBehavior.Controls.Add(Me.tbURL)
            Me.gbBehavior.Location = New System.Drawing.Point(3, 214)
            Me.gbBehavior.Name = "gbBehavior"
            Me.gbBehavior.Size = New System.Drawing.Size(454, 55)
            Me.gbBehavior.TabIndex = 3
            Me.gbBehavior.TabStop = False
            Me.gbBehavior.Text = "Behavior"
            '
            ' tbURL
            '
            Me.tbURL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.tbURL.Location = New System.Drawing.Point(109, 19)
            Me.tbURL.Name = "tbURL"
            Me.tbURL.Size = New System.Drawing.Size(339, 20)
            Me.tbURL.TabIndex = 0
            '
            ' lURL
            '
            Me.lURL.AutoSize = True
            Me.lURL.Location = New System.Drawing.Point(6, 22)
            Me.lURL.Name = "lURL"
            Me.lURL.Size = New System.Drawing.Size(32, 13)
            Me.lURL.TabIndex = 1
            Me.lURL.Text = "&URL:"
            '
            ' ucOther
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbBehavior)
            Me.Controls.Add(Me.gbVisualEffects)
            Me.Controls.Add(Me.gbTables)
            Me.Controls.Add(Me.gbUserInterface)
            Me.Name = "ucOther"
            Me.Size = New System.Drawing.Size(460, 380)
            Me.gbUserInterface.ResumeLayout(False)
            Me.gbUserInterface.PerformLayout()
            Me.gbTables.ResumeLayout(False)
            Me.scBordersLayout.Panel1.ResumeLayout(False)
            Me.scBordersLayout.Panel1.PerformLayout()
            Me.scBordersLayout.Panel2.ResumeLayout(False)
            Me.scBordersLayout.Panel2.PerformLayout()
            Me.scBordersLayout.ResumeLayout(False)
            Me.gbVisualEffects.ResumeLayout(False)
            Me.gbVisualEffects.PerformLayout()
            Me.gbBehavior.ResumeLayout(False)
            Me.gbBehavior.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gbUserInterface As GroupBox
        Private cbCursor As ComboBox
        Private lCursor As Label
        Private gbTables As GroupBox
        Private scBordersLayout As SplitContainer
        Private cbBorders As ComboBox
        Private lBorders As Label
        Private cbLayout As ComboBox
        Private lLayout As Label
        Private gbVisualEffects As GroupBox
        Private lFilter As Label
        Private tbFilter As TextBox
        Private gbBehavior As GroupBox
        Private lURL As Label
        Private tbURL As TextBox
    End Class

End Namespace
