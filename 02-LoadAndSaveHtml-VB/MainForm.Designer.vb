Imports SpiceLogic.HtmlEditor.WinForms

Partial Class MainForm
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    Private Sub InitializeComponent()
        Me._editor = New WinFormHtmlEditor()
        Me._optionsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me._bodyHtmlOption = New System.Windows.Forms.RadioButton()
        Me._documentHtmlOption = New System.Windows.Forms.RadioButton()
        Me._menuStrip = New System.Windows.Forms.MenuStrip()
        Me._fileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me._openItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._saveItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._optionsPanel.SuspendLayout()
        Me._menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Nothing
        Me._editor.Location = New System.Drawing.Point(0, 56)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 668)
        Me._editor.TabIndex = 2
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' _optionsPanel
        '
        Me._optionsPanel.Controls.Add(Me._bodyHtmlOption)
        Me._optionsPanel.Controls.Add(Me._documentHtmlOption)
        Me._optionsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me._optionsPanel.Location = New System.Drawing.Point(0, 24)
        Me._optionsPanel.Name = "_optionsPanel"
        Me._optionsPanel.Size = New System.Drawing.Size(1000, 32)
        Me._optionsPanel.TabIndex = 1
        '
        ' _bodyHtmlOption
        '
        Me._bodyHtmlOption.AutoSize = True
        Me._bodyHtmlOption.Checked = True
        Me._bodyHtmlOption.Location = New System.Drawing.Point(3, 3)
        Me._bodyHtmlOption.Name = "_bodyHtmlOption"
        Me._bodyHtmlOption.Size = New System.Drawing.Size(186, 17)
        Me._bodyHtmlOption.TabIndex = 0
        Me._bodyHtmlOption.TabStop = True
        Me._bodyHtmlOption.Text = "Use BodyHtml (inner content only)"
        '
        ' _documentHtmlOption
        '
        Me._documentHtmlOption.AutoSize = True
        Me._documentHtmlOption.Location = New System.Drawing.Point(195, 3)
        Me._documentHtmlOption.Name = "_documentHtmlOption"
        Me._documentHtmlOption.Size = New System.Drawing.Size(191, 17)
        Me._documentHtmlOption.TabIndex = 1
        Me._documentHtmlOption.Text = "Use DocumentHtml (full document)"
        '
        ' _menuStrip
        '
        Me._menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._fileMenu})
        Me._menuStrip.Location = New System.Drawing.Point(0, 0)
        Me._menuStrip.Name = "_menuStrip"
        Me._menuStrip.Size = New System.Drawing.Size(1000, 24)
        Me._menuStrip.TabIndex = 0
        '
        ' _fileMenu
        '
        Me._fileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._openItem, Me._saveItem})
        Me._fileMenu.Name = "_fileMenu"
        Me._fileMenu.Size = New System.Drawing.Size(37, 20)
        Me._fileMenu.Text = "File"
        '
        ' _openItem
        '
        Me._openItem.Name = "_openItem"
        Me._openItem.Size = New System.Drawing.Size(126, 22)
        Me._openItem.Text = "Open..."
        '
        ' _saveItem
        '
        Me._saveItem.Name = "_saveItem"
        Me._saveItem.Size = New System.Drawing.Size(126, 22)
        Me._saveItem.Text = "Save as..."
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 724)
        Me.Controls.Add(Me._editor)
        Me.Controls.Add(Me._optionsPanel)
        Me.Controls.Add(Me._menuStrip)
        Me.MainMenuStrip = Me._menuStrip
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - load and save HTML"
        Me._optionsPanel.ResumeLayout(False)
        Me._optionsPanel.PerformLayout()
        Me._menuStrip.ResumeLayout(False)
        Me._menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private _editor As WinFormHtmlEditor
    Private _optionsPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _bodyHtmlOption As System.Windows.Forms.RadioButton
    Private _documentHtmlOption As System.Windows.Forms.RadioButton
    Private _menuStrip As System.Windows.Forms.MenuStrip
    Private _fileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _openItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _saveItem As System.Windows.Forms.ToolStripMenuItem
End Class
