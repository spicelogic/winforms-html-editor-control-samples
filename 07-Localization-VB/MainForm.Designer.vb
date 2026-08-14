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
        Me._topPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me._languageLabel = New System.Windows.Forms.Label()
        Me._languageCombo = New System.Windows.Forms.ComboBox()
        Me._currentLanguageLabel = New System.Windows.Forms.Label()
        Me._spellCheckLabel = New System.Windows.Forms.Label()
        Me._spellCheckCombo = New System.Windows.Forms.ComboBox()
        Me._jsonOverrideCheckBox = New System.Windows.Forms.CheckBox()
        Me._topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Nothing
        Me._editor.Location = New System.Drawing.Point(0, 44)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 716)
        Me._editor.TabIndex = 1
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' _topPanel
        '
        Me._topPanel.AutoSize = True
        Me._topPanel.Controls.Add(Me._languageLabel)
        Me._topPanel.Controls.Add(Me._languageCombo)
        Me._topPanel.Controls.Add(Me._currentLanguageLabel)
        Me._topPanel.Controls.Add(Me._spellCheckLabel)
        Me._topPanel.Controls.Add(Me._spellCheckCombo)
        Me._topPanel.Controls.Add(Me._jsonOverrideCheckBox)
        Me._topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me._topPanel.Location = New System.Drawing.Point(0, 0)
        Me._topPanel.Name = "_topPanel"
        Me._topPanel.Padding = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me._topPanel.Size = New System.Drawing.Size(1000, 44)
        Me._topPanel.TabIndex = 0
        Me._topPanel.WrapContents = False
        '
        ' _languageLabel
        '
        Me._languageLabel.AutoSize = True
        Me._languageLabel.Location = New System.Drawing.Point(10, 16)
        Me._languageLabel.Margin = New System.Windows.Forms.Padding(0, 6, 5, 0)
        Me._languageLabel.Name = "_languageLabel"
        Me._languageLabel.Size = New System.Drawing.Size(84, 13)
        Me._languageLabel.TabIndex = 0
        Me._languageLabel.Text = "Editor language:"
        '
        ' _languageCombo
        '
        Me._languageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._languageCombo.Location = New System.Drawing.Point(99, 13)
        Me._languageCombo.Margin = New System.Windows.Forms.Padding(0, 3, 15, 0)
        Me._languageCombo.Name = "_languageCombo"
        Me._languageCombo.Size = New System.Drawing.Size(200, 21)
        Me._languageCombo.TabIndex = 1
        '
        ' _currentLanguageLabel
        '
        Me._currentLanguageLabel.AutoSize = True
        Me._currentLanguageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me._currentLanguageLabel.Location = New System.Drawing.Point(314, 16)
        Me._currentLanguageLabel.Margin = New System.Windows.Forms.Padding(0, 6, 15, 0)
        Me._currentLanguageLabel.Name = "_currentLanguageLabel"
        Me._currentLanguageLabel.Size = New System.Drawing.Size(0, 13)
        Me._currentLanguageLabel.TabIndex = 2
        '
        ' _spellCheckLabel
        '
        Me._spellCheckLabel.AutoSize = True
        Me._spellCheckLabel.Location = New System.Drawing.Point(329, 16)
        Me._spellCheckLabel.Margin = New System.Windows.Forms.Padding(0, 6, 5, 0)
        Me._spellCheckLabel.Name = "_spellCheckLabel"
        Me._spellCheckLabel.Size = New System.Drawing.Size(115, 13)
        Me._spellCheckLabel.TabIndex = 3
        Me._spellCheckLabel.Text = "Spell check language:"
        '
        ' _spellCheckCombo
        '
        Me._spellCheckCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._spellCheckCombo.Location = New System.Drawing.Point(449, 13)
        Me._spellCheckCombo.Margin = New System.Windows.Forms.Padding(0, 3, 15, 0)
        Me._spellCheckCombo.Name = "_spellCheckCombo"
        Me._spellCheckCombo.Size = New System.Drawing.Size(200, 21)
        Me._spellCheckCombo.TabIndex = 4
        '
        ' _jsonOverrideCheckBox
        '
        Me._jsonOverrideCheckBox.AutoSize = True
        Me._jsonOverrideCheckBox.Location = New System.Drawing.Point(664, 16)
        Me._jsonOverrideCheckBox.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me._jsonOverrideCheckBox.Name = "_jsonOverrideCheckBox"
        Me._jsonOverrideCheckBox.Size = New System.Drawing.Size(168, 17)
        Me._jsonOverrideCheckBox.TabIndex = 5
        Me._jsonOverrideCheckBox.Text = "Enable JSON override (Polish)"
        Me._jsonOverrideCheckBox.UseVisualStyleBackColor = True
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 760)
        Me.Controls.Add(Me._editor)
        Me.Controls.Add(Me._topPanel)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - localization (VB.NET)"
        Me._topPanel.ResumeLayout(False)
        Me._topPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private _editor As WinFormHtmlEditor
    Private _topPanel As System.Windows.Forms.FlowLayoutPanel
    Private _languageLabel As System.Windows.Forms.Label
    Friend WithEvents _languageCombo As System.Windows.Forms.ComboBox
    Private _currentLanguageLabel As System.Windows.Forms.Label
    Private _spellCheckLabel As System.Windows.Forms.Label
    Friend WithEvents _spellCheckCombo As System.Windows.Forms.ComboBox
    Friend WithEvents _jsonOverrideCheckBox As System.Windows.Forms.CheckBox
End Class
