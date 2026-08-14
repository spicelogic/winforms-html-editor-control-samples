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
        Me._tabs = New System.Windows.Forms.TabControl()
        Me._buildTab = New System.Windows.Forms.TabPage()
        Me._customToolbarEditor = New WinFormHtmlEditor()
        Me._customStrip = New System.Windows.Forms.ToolStrip()
        Me._overrideTab = New System.Windows.Forms.TabPage()
        Me._overrideEditor = New WinFormHtmlEditor()
        Me._tabs.SuspendLayout()
        Me._buildTab.SuspendLayout()
        Me._overrideTab.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _tabs
        '
        Me._tabs.Controls.Add(Me._buildTab)
        Me._tabs.Controls.Add(Me._overrideTab)
        Me._tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tabs.Location = New System.Drawing.Point(0, 0)
        Me._tabs.Name = "_tabs"
        Me._tabs.SelectedIndex = 0
        Me._tabs.Size = New System.Drawing.Size(1000, 724)
        Me._tabs.TabIndex = 0
        '
        ' _buildTab
        '
        Me._buildTab.Controls.Add(Me._customToolbarEditor)
        Me._buildTab.Controls.Add(Me._customStrip)
        Me._buildTab.Location = New System.Drawing.Point(4, 22)
        Me._buildTab.Name = "_buildTab"
        Me._buildTab.Size = New System.Drawing.Size(992, 698)
        Me._buildTab.TabIndex = 0
        Me._buildTab.Text = "Build a custom toolbar"
        Me._buildTab.UseVisualStyleBackColor = True
        '
        ' _customToolbarEditor
        '
        Me._customToolbarEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._customToolbarEditor.EditorContextMenuStrip = Nothing
        Me._customToolbarEditor.Location = New System.Drawing.Point(0, 25)
        Me._customToolbarEditor.Name = "_customToolbarEditor"
        Me._customToolbarEditor.Size = New System.Drawing.Size(992, 673)
        Me._customToolbarEditor.TabIndex = 1
        Me._customToolbarEditor.ToolbarContextMenuStrip = Nothing
        '
        ' _customStrip
        '
        Me._customStrip.Location = New System.Drawing.Point(0, 0)
        Me._customStrip.Name = "_customStrip"
        Me._customStrip.Size = New System.Drawing.Size(992, 25)
        Me._customStrip.TabIndex = 0
        '
        ' _overrideTab
        '
        Me._overrideTab.Controls.Add(Me._overrideEditor)
        Me._overrideTab.Location = New System.Drawing.Point(4, 22)
        Me._overrideTab.Name = "_overrideTab"
        Me._overrideTab.Size = New System.Drawing.Size(992, 698)
        Me._overrideTab.TabIndex = 1
        Me._overrideTab.Text = "Customize the built-in toolbars"
        Me._overrideTab.UseVisualStyleBackColor = True
        '
        ' _overrideEditor
        '
        Me._overrideEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._overrideEditor.EditorContextMenuStrip = Nothing
        Me._overrideEditor.Location = New System.Drawing.Point(0, 0)
        Me._overrideEditor.Name = "_overrideEditor"
        Me._overrideEditor.Size = New System.Drawing.Size(992, 698)
        Me._overrideEditor.TabIndex = 0
        Me._overrideEditor.ToolbarContextMenuStrip = Nothing
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 724)
        Me.Controls.Add(Me._tabs)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - toolbar customization (VB.NET)"
        Me._tabs.ResumeLayout(False)
        Me._buildTab.ResumeLayout(False)
        Me._buildTab.PerformLayout()
        Me._overrideTab.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

#End Region

    Private _tabs As System.Windows.Forms.TabControl
    Private _buildTab As System.Windows.Forms.TabPage
    Private _customToolbarEditor As WinFormHtmlEditor
    Private _customStrip As System.Windows.Forms.ToolStrip
    Private _overrideTab As System.Windows.Forms.TabPage
    Private _overrideEditor As WinFormHtmlEditor
End Class
