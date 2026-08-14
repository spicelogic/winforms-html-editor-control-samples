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
        Me._splitContainer = New System.Windows.Forms.SplitContainer()
        Me._templateEditor = New WinFormHtmlEditor()
        Me._previewEditor = New WinFormHtmlEditor()
        Me._buttonPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me._previewButton = New System.Windows.Forms.Button()
        CType(Me._splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._splitContainer.Panel1.SuspendLayout()
        Me._splitContainer.Panel2.SuspendLayout()
        Me._splitContainer.SuspendLayout()
        Me._buttonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _splitContainer
        '
        Me._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me._splitContainer.Location = New System.Drawing.Point(0, 40)
        Me._splitContainer.Name = "_splitContainer"
        ' The template and the preview are stacked rather than side by side, so each
        ' editor keeps the full window width and its complete toolbar stays visible.
        Me._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        ' _splitContainer.Panel1
        '
        Me._splitContainer.Panel1.Controls.Add(Me._templateEditor)
        Me._splitContainer.Panel1MinSize = 200
        '
        ' _splitContainer.Panel2
        '
        Me._splitContainer.Panel2.Controls.Add(Me._previewEditor)
        Me._splitContainer.Panel2MinSize = 200
        Me._splitContainer.Size = New System.Drawing.Size(1000, 720)
        Me._splitContainer.SplitterDistance = 380
        Me._splitContainer.TabIndex = 1
        '
        ' _templateEditor
        '
        Me._templateEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._templateEditor.EditorContextMenuStrip = Nothing
        Me._templateEditor.Location = New System.Drawing.Point(0, 0)
        Me._templateEditor.Name = "_templateEditor"
        Me._templateEditor.Size = New System.Drawing.Size(1000, 380)
        Me._templateEditor.TabIndex = 0
        Me._templateEditor.ToolbarContextMenuStrip = Nothing
        '
        ' _previewEditor
        '
        Me._previewEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._previewEditor.EditorContextMenuStrip = Nothing
        Me._previewEditor.Location = New System.Drawing.Point(0, 0)
        Me._previewEditor.Name = "_previewEditor"
        Me._previewEditor.Size = New System.Drawing.Size(1000, 336)
        Me._previewEditor.TabIndex = 0
        Me._previewEditor.ToolbarContextMenuStrip = Nothing
        '
        ' _buttonPanel
        '
        Me._buttonPanel.Controls.Add(Me._previewButton)
        Me._buttonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me._buttonPanel.Location = New System.Drawing.Point(0, 0)
        Me._buttonPanel.Name = "_buttonPanel"
        Me._buttonPanel.Padding = New System.Windows.Forms.Padding(6)
        Me._buttonPanel.Size = New System.Drawing.Size(1000, 40)
        Me._buttonPanel.TabIndex = 0
        '
        ' _previewButton
        '
        Me._previewButton.AutoSize = True
        Me._previewButton.Location = New System.Drawing.Point(9, 9)
        Me._previewButton.Name = "_previewButton"
        Me._previewButton.Size = New System.Drawing.Size(94, 23)
        Me._previewButton.TabIndex = 0
        Me._previewButton.Text = "Preview merged"
        Me._previewButton.UseVisualStyleBackColor = True
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 760)
        Me.Controls.Add(Me._splitContainer)
        Me.Controls.Add(Me._buttonPanel)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - mail merge template"
        Me._splitContainer.Panel1.ResumeLayout(False)
        Me._splitContainer.Panel2.ResumeLayout(False)
        CType(Me._splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me._splitContainer.ResumeLayout(False)
        Me._buttonPanel.ResumeLayout(False)
        Me._buttonPanel.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

#End Region

    Private _splitContainer As System.Windows.Forms.SplitContainer
    Private _templateEditor As WinFormHtmlEditor
    Private _previewEditor As WinFormHtmlEditor
    Private _buttonPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _previewButton As System.Windows.Forms.Button
End Class
