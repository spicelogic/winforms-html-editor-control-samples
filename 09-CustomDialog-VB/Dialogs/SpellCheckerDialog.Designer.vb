Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs

    Partial Class SpellCheckerDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpellCheckerDialog))
            Me.suggestionList = New System.Windows.Forms.ListBox()
            Me.statusPaneWord = New System.Windows.Forms.StatusStrip()
            Me.statusPaneCount = New System.Windows.Forms.StatusStrip()
            Me.statusPaneIndex = New System.Windows.Forms.StatusStrip()
            Me.btnAddToDictionary = New System.Windows.Forms.Button()
            Me.richTxtDocument = New System.Windows.Forms.RichTextBox()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.lblSuggessions = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnReplaceAll = New System.Windows.Forms.Button()
            Me.btnIgnoreAll = New System.Windows.Forms.Button()
            Me.btnReplace = New System.Windows.Forms.Button()
            Me.btnIgnore = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.messageToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.wordCountToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.wordStatusLabel = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtReplacementWord = New System.Windows.Forms.TextBox()
            Me.panel1.SuspendLayout()
            Me.statusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            ' suggestionList
            '
            Me.suggestionList.Location = New System.Drawing.Point(10, 203)
            Me.suggestionList.Name = "suggestionList"
            Me.suggestionList.Size = New System.Drawing.Size(478, 121)
            Me.suggestionList.TabIndex = 18
            '
            ' statusPaneWord
            '
            Me.statusPaneWord.AutoSize = True
            Me.statusPaneWord.Name = "statusPaneWord"
            Me.statusPaneWord.Width = 270
            '
            ' statusPaneCount
            '
            Me.statusPaneCount.Name = "statusPaneCount"
            Me.statusPaneCount.Text = "Word: 0 of 0"
            '
            ' statusPaneIndex
            '
            Me.statusPaneIndex.Name = "statusPaneIndex"
            Me.statusPaneIndex.Text = "Index: 0"
            Me.statusPaneIndex.Width = 80
            '
            ' btnAddToDictionary
            '
            Me.btnAddToDictionary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnAddToDictionary.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddToDictionary.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnAddToDictionary.AutoSize = True
            Me.btnAddToDictionary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnAddToDictionary.Location = New System.Drawing.Point(498, 97)
            Me.btnAddToDictionary.MinimumSize = New System.Drawing.Size(140, 23)
            Me.btnAddToDictionary.Name = "btnAddToDictionary"
            Me.btnAddToDictionary.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnAddToDictionary.Size = New System.Drawing.Size(140, 23)
            Me.btnAddToDictionary.TabIndex = 21
            Me.btnAddToDictionary.Text = "&Add to Dictionary"
            '
            ' richTxtDocument
            '
            Me.richTxtDocument.BackColor = System.Drawing.SystemColors.Window
            Me.richTxtDocument.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTxtDocument.DetectUrls = False
            Me.richTxtDocument.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTxtDocument.Location = New System.Drawing.Point(0, 0)
            Me.richTxtDocument.Name = "richTxtDocument"
            Me.richTxtDocument.ReadOnly = True
            Me.richTxtDocument.Size = New System.Drawing.Size(476, 113)
            Me.richTxtDocument.TabIndex = 1
            Me.richTxtDocument.TabStop = False
            Me.richTxtDocument.Text = ""
            '
            ' panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.richTxtDocument)
            Me.panel1.Location = New System.Drawing.Point(11, 47)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(478, 115)
            Me.panel1.TabIndex = 26
            '
            ' lblSuggessions
            '
            Me.lblSuggessions.AutoSize = True
            Me.lblSuggessions.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblSuggessions.Location = New System.Drawing.Point(8, 183)
            Me.lblSuggessions.Name = "lblSuggessions"
            Me.lblSuggessions.Size = New System.Drawing.Size(74, 13)
            Me.lblSuggessions.TabIndex = 17
            Me.lblSuggessions.Text = "Replace &With:"
            '
            ' btnCancel
            '
            Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnCancel.Location = New System.Drawing.Point(498, 301)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(140, 23)
            Me.btnCancel.TabIndex = 25
            Me.btnCancel.Text = "&Cancel"
            '
            ' btnReplaceAll
            '
            Me.btnReplaceAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnReplaceAll.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReplaceAll.Enabled = False
            Me.btnReplaceAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnReplaceAll.AutoSize = True
            Me.btnReplaceAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnReplaceAll.Location = New System.Drawing.Point(498, 203)
            Me.btnReplaceAll.MinimumSize = New System.Drawing.Size(140, 23)
            Me.btnReplaceAll.Name = "btnReplaceAll"
            Me.btnReplaceAll.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnReplaceAll.Size = New System.Drawing.Size(140, 23)
            Me.btnReplaceAll.TabIndex = 23
            Me.btnReplaceAll.Text = "Replace A&ll"
            '
            ' btnIgnoreAll
            '
            Me.btnIgnoreAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnIgnoreAll.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnIgnoreAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnIgnoreAll.AutoSize = True
            Me.btnIgnoreAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnIgnoreAll.Location = New System.Drawing.Point(498, 72)
            Me.btnIgnoreAll.MinimumSize = New System.Drawing.Size(140, 23)
            Me.btnIgnoreAll.Name = "btnIgnoreAll"
            Me.btnIgnoreAll.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnIgnoreAll.Size = New System.Drawing.Size(140, 23)
            Me.btnIgnoreAll.TabIndex = 20
            Me.btnIgnoreAll.Text = "I&gnore All"
            '
            ' btnReplace
            '
            Me.btnReplace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReplace.Enabled = False
            Me.btnReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnReplace.AutoSize = True
            Me.btnReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnReplace.Location = New System.Drawing.Point(498, 178)
            Me.btnReplace.MinimumSize = New System.Drawing.Size(140, 23)
            Me.btnReplace.Name = "btnReplace"
            Me.btnReplace.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnReplace.Size = New System.Drawing.Size(140, 23)
            Me.btnReplace.TabIndex = 22
            Me.btnReplace.Text = "&Replace"
            '
            ' btnIgnore
            '
            Me.btnIgnore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnIgnore.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnIgnore.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnIgnore.AutoSize = True
            Me.btnIgnore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnIgnore.Location = New System.Drawing.Point(498, 47)
            Me.btnIgnore.MinimumSize = New System.Drawing.Size(140, 23)
            Me.btnIgnore.Name = "btnIgnore"
            Me.btnIgnore.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnIgnore.Size = New System.Drawing.Size(140, 23)
            Me.btnIgnore.TabIndex = 19
            Me.btnIgnore.Text = "&Ignore Once"
            '
            ' btnDelete
            '
            Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnDelete.AutoSize = True
            Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnDelete.Location = New System.Drawing.Point(498, 122)
            Me.btnDelete.MinimumSize = New System.Drawing.Size(140, 23)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnDelete.Size = New System.Drawing.Size(140, 23)
            Me.btnDelete.TabIndex = 27
            Me.btnDelete.Text = "&Delete"
            '
            ' statusStrip1
            '
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.messageToolStripStatusLabel,
            Me.wordCountToolStripStatusLabel})
            Me.statusStrip1.Location = New System.Drawing.Point(0, 336)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.Size = New System.Drawing.Size(660, 22)
            Me.statusStrip1.SizingGrip = False
            Me.statusStrip1.TabIndex = 28
            Me.statusStrip1.Text = "statusStrip1"
            '
            ' messageToolStripStatusLabel
            '
            Me.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel"
            Me.messageToolStripStatusLabel.Size = New System.Drawing.Size(386, 17)
            Me.messageToolStripStatusLabel.Spring = True
            Me.messageToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            ' wordCountToolStripStatusLabel
            '
            Me.wordCountToolStripStatusLabel.Name = "wordCountToolStripStatusLabel"
            Me.wordCountToolStripStatusLabel.Size = New System.Drawing.Size(83, 17)
            Me.wordCountToolStripStatusLabel.Text = "Word 0 from 0"
            Me.wordCountToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            ' wordStatusLabel
            '
            Me.wordStatusLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.wordStatusLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.wordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.wordStatusLabel.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.wordStatusLabel.Location = New System.Drawing.Point(0, 0)
            Me.wordStatusLabel.Name = "wordStatusLabel"
            Me.wordStatusLabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.wordStatusLabel.Size = New System.Drawing.Size(660, 31)
            Me.wordStatusLabel.TabIndex = 29
            Me.wordStatusLabel.Text = "Misspelled word: Maaango"
            Me.wordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            ' groupBox1
            '
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupBox1.Location = New System.Drawing.Point(0, 31)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(660, 2)
            Me.groupBox1.TabIndex = 30
            Me.groupBox1.TabStop = False
            '
            ' txtReplacementWord
            '
            Me.txtReplacementWord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.txtReplacementWord.Location = New System.Drawing.Point(110, 179)
            Me.txtReplacementWord.Name = "txtReplacementWord"
            Me.txtReplacementWord.Size = New System.Drawing.Size(378, 21)
            Me.txtReplacementWord.TabIndex = 31
            '
            ' SpellCheckerDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(660, 358)
            Me.Controls.Add(Me.txtReplacementWord)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.wordStatusLabel)
            Me.Controls.Add(Me.statusStrip1)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.suggestionList)
            Me.Controls.Add(Me.btnAddToDictionary)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.lblSuggessions)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnReplaceAll)
            Me.Controls.Add(Me.btnIgnoreAll)
            Me.Controls.Add(Me.btnReplace)
            Me.Controls.Add(Me.btnIgnore)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SpellCheckerDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Spell Check"
            Me.panel1.ResumeLayout(False)
            Me.statusStrip1.ResumeLayout(False)
            Me.statusStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents suggestionList As ListBox
        Private statusPaneWord As StatusStrip
        Private statusPaneCount As StatusStrip
        Private statusPaneIndex As StatusStrip
        Private WithEvents btnAddToDictionary As Button
        Private richTxtDocument As RichTextBox
        Private panel1 As Panel
        Private lblSuggessions As Label
        Private btnCancel As Button
        Private WithEvents btnReplaceAll As Button
        Private WithEvents btnIgnoreAll As Button
        Private WithEvents btnReplace As Button
        Private WithEvents btnIgnore As Button
        Private WithEvents btnDelete As Button
        Private statusStrip1 As StatusStrip
        Private messageToolStripStatusLabel As ToolStripStatusLabel
        Private wordCountToolStripStatusLabel As ToolStripStatusLabel
        Private wordStatusLabel As Label
        Private groupBox1 As GroupBox
        Private WithEvents txtReplacementWord As TextBox
    End Class

End Namespace
