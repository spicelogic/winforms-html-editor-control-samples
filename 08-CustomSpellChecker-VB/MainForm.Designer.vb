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
        Me._builtInOption = New System.Windows.Forms.RadioButton()
        Me._customOption = New System.Windows.Forms.RadioButton()
        Me._optionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Nothing
        Me._editor.Location = New System.Drawing.Point(0, 32)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 668)
        Me._editor.TabIndex = 1
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' _optionsPanel
        '
        Me._optionsPanel.Controls.Add(Me._builtInOption)
        Me._optionsPanel.Controls.Add(Me._customOption)
        Me._optionsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me._optionsPanel.Location = New System.Drawing.Point(0, 0)
        Me._optionsPanel.Name = "_optionsPanel"
        Me._optionsPanel.Size = New System.Drawing.Size(1000, 32)
        Me._optionsPanel.TabIndex = 0
        '
        ' _builtInOption
        '
        Me._builtInOption.AutoSize = True
        Me._builtInOption.Checked = True
        Me._builtInOption.Location = New System.Drawing.Point(3, 3)
        Me._builtInOption.Name = "_builtInOption"
        Me._builtInOption.Size = New System.Drawing.Size(97, 17)
        Me._builtInOption.TabIndex = 0
        Me._builtInOption.TabStop = True
        Me._builtInOption.Text = "Built-in engine"
        Me._builtInOption.UseVisualStyleBackColor = True
        '
        ' _customOption
        '
        Me._customOption.AutoSize = True
        Me._customOption.Location = New System.Drawing.Point(106, 3)
        Me._customOption.Name = "_customOption"
        Me._customOption.Size = New System.Drawing.Size(134, 17)
        Me._customOption.TabIndex = 1
        Me._customOption.Text = "Custom engine (demo)"
        Me._customOption.UseVisualStyleBackColor = True
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me._editor)
        Me.Controls.Add(Me._optionsPanel)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - custom spell checker"
        Me._optionsPanel.ResumeLayout(False)
        Me._optionsPanel.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

#End Region

    Private _editor As WinFormHtmlEditor
    Private _optionsPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _builtInOption As System.Windows.Forms.RadioButton
    Private _customOption As System.Windows.Forms.RadioButton
End Class
