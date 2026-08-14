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
        Me._statusStrip = New System.Windows.Forms.StatusStrip()
        Me._charCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me._statusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Nothing
        Me._editor.Location = New System.Drawing.Point(0, 0)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 678)
        Me._editor.TabIndex = 0
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' _statusStrip
        '
        Me._statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._charCountLabel})
        Me._statusStrip.Location = New System.Drawing.Point(0, 678)
        Me._statusStrip.Name = "_statusStrip"
        Me._statusStrip.Size = New System.Drawing.Size(1000, 22)
        Me._statusStrip.TabIndex = 1
        '
        ' _charCountLabel
        '
        Me._charCountLabel.Name = "_charCountLabel"
        Me._charCountLabel.Size = New System.Drawing.Size(133, 17)
        Me._charCountLabel.Text = "Html length: 0 characters"
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me._editor)
        Me.Controls.Add(Me._statusStrip)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - quickstart"
        Me._statusStrip.ResumeLayout(False)
        Me._statusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Friend WithEvents _editor As WinFormHtmlEditor
    Private _statusStrip As System.Windows.Forms.StatusStrip
    Private _charCountLabel As System.Windows.Forms.ToolStripStatusLabel
End Class
