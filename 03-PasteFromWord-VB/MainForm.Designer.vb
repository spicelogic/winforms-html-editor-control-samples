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
        Me._editor = New WinFormHtmlEditor()
        Me._logPanel = New System.Windows.Forms.Panel()
        Me._log = New System.Windows.Forms.TextBox()
        Me._logLabel = New System.Windows.Forms.Label()
        CType(Me._splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._splitContainer.Panel1.SuspendLayout()
        Me._splitContainer.Panel2.SuspendLayout()
        Me._splitContainer.SuspendLayout()
        Me._logPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _splitContainer
        '
        Me._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me._splitContainer.Location = New System.Drawing.Point(0, 0)
        Me._splitContainer.Name = "_splitContainer"
        ' The editor is stacked above the log rather than beside it, so the control keeps
        ' the full window width and every default toolbar button stays visible.
        Me._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        ' _splitContainer.Panel1
        '
        Me._splitContainer.Panel1.Controls.Add(Me._editor)
        Me._splitContainer.Panel1MinSize = 200
        '
        ' _splitContainer.Panel2
        '
        Me._splitContainer.Panel2.Controls.Add(Me._logPanel)
        Me._splitContainer.Panel2MinSize = 100
        Me._splitContainer.Size = New System.Drawing.Size(1000, 724)
        Me._splitContainer.SplitterDistance = 470
        Me._splitContainer.TabIndex = 0
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Nothing
        Me._editor.Location = New System.Drawing.Point(0, 0)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 470)
        Me._editor.TabIndex = 0
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' _logPanel
        '
        Me._logPanel.Controls.Add(Me._log)
        Me._logPanel.Controls.Add(Me._logLabel)
        Me._logPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._logPanel.Location = New System.Drawing.Point(0, 0)
        Me._logPanel.Name = "_logPanel"
        Me._logPanel.Padding = New System.Windows.Forms.Padding(4)
        Me._logPanel.Size = New System.Drawing.Size(1000, 250)
        Me._logPanel.TabIndex = 0
        '
        ' _log
        '
        Me._log.Dock = System.Windows.Forms.DockStyle.Fill
        Me._log.Font = New System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 9.0F)
        Me._log.Location = New System.Drawing.Point(4, 24)
        Me._log.Multiline = True
        Me._log.Name = "_log"
        Me._log.ReadOnly = True
        Me._log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me._log.Size = New System.Drawing.Size(992, 222)
        Me._log.TabIndex = 1
        '
        ' _logLabel
        '
        Me._logLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me._logLabel.Location = New System.Drawing.Point(4, 4)
        Me._logLabel.Name = "_logLabel"
        Me._logLabel.Size = New System.Drawing.Size(992, 20)
        Me._logLabel.TabIndex = 0
        Me._logLabel.Text = "Paste log"
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 724)
        Me.Controls.Add(Me._splitContainer)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - paste from Word"
        Me._splitContainer.Panel1.ResumeLayout(False)
        Me._splitContainer.Panel2.ResumeLayout(False)
        CType(Me._splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me._splitContainer.ResumeLayout(False)
        Me._logPanel.ResumeLayout(False)
        Me._logPanel.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

#End Region

    Private _splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents _editor As WinFormHtmlEditor
    Private _logPanel As System.Windows.Forms.Panel
    Private _log As System.Windows.Forms.TextBox
    Private _logLabel As System.Windows.Forms.Label
End Class
