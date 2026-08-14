Imports SpiceLogic.HtmlEditor.WinForms

Namespace Global.CustomDialog

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
            Me.descriptionPanel = New System.Windows.Forms.Panel()
            Me.descriptionLabel2 = New System.Windows.Forms.Label()
            Me.descriptionLabel1 = New System.Windows.Forms.Label()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.winFormHtmlEditor1 = New WinFormHtmlEditor()
            Me.descriptionPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            ' descriptionPanel
            '
            Me.descriptionPanel.BackColor = System.Drawing.Color.FromArgb(240, 246, 255)
            Me.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel2)
            Me.descriptionPanel.Controls.Add(Me.descriptionLabel1)
            Me.descriptionPanel.Controls.Add(Me.titleLabel)
            Me.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.descriptionPanel.Location = New System.Drawing.Point(15, 15)
            Me.descriptionPanel.Name = "descriptionPanel"
            Me.descriptionPanel.Padding = New System.Windows.Forms.Padding(14)
            Me.descriptionPanel.Size = New System.Drawing.Size(1000, 130)
            Me.descriptionPanel.TabIndex = 0
            '
            ' titleLabel
            '
            Me.titleLabel.AutoSize = True
            Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Bold)
            Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92)
            Me.titleLabel.Location = New System.Drawing.Point(14, 14)
            Me.titleLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(170, 20)
            Me.titleLabel.TabIndex = 0
            Me.titleLabel.Text = "What This Demo Shows"
            '
            ' descriptionLabel1
            '
            Me.descriptionLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.descriptionLabel1.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51)
            Me.descriptionLabel1.Location = New System.Drawing.Point(14, 40)
            Me.descriptionLabel1.Name = "descriptionLabel1"
            Me.descriptionLabel1.Size = New System.Drawing.Size(970, 36)
            Me.descriptionLabel1.TabIndex = 1
            Me.descriptionLabel1.Text = "The HTML Editor has built-in dialogs for images, hyperlinks, tables, spell checking, symbols, search/replace, YouTube videos, and the style builder. You can fully replace any or all of them with your own custom dialog implementations by implementing the corresponding interface (e.g., IImageDialog, IHyperlinkDialog)."
            '
            ' descriptionLabel2
            '
            Me.descriptionLabel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.descriptionLabel2.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51)
            Me.descriptionLabel2.Location = New System.Drawing.Point(14, 82)
            Me.descriptionLabel2.Name = "descriptionLabel2"
            Me.descriptionLabel2.Size = New System.Drawing.Size(970, 36)
            Me.descriptionLabel2.TabIndex = 2
            Me.descriptionLabel2.Text = "Try it: Click the Hyperlink, Image, Table, Spell Checker, or other toolbar buttons to see the custom dialogs in action. Check the Dialogs folder in this project for the full source code of each custom dialog implementation."
            '
            ' winFormHtmlEditor1
            '
            Me.winFormHtmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.winFormHtmlEditor1.Location = New System.Drawing.Point(15, 145)
            Me.winFormHtmlEditor1.Name = "winFormHtmlEditor1"
            Me.winFormHtmlEditor1.EditorContextMenuStrip = Nothing
            Me.winFormHtmlEditor1.Size = New System.Drawing.Size(1000, 580)
            Me.winFormHtmlEditor1.TabIndex = 1
            Me.winFormHtmlEditor1.ToolbarContextMenuStrip = Nothing
            '
            ' MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1030, 740)
            Me.Padding = New System.Windows.Forms.Padding(15)
            Me.Controls.Add(Me.winFormHtmlEditor1)
            Me.Controls.Add(Me.descriptionPanel)
            Me.Name = "MainForm"
            Me.Text = "SpiceLogic WinForms HTML Editor - Dialog Customization Demo"
            Me.descriptionPanel.ResumeLayout(False)
            Me.descriptionPanel.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region

        Private descriptionPanel As System.Windows.Forms.Panel
        Private titleLabel As System.Windows.Forms.Label
        Private descriptionLabel1 As System.Windows.Forms.Label
        Private descriptionLabel2 As System.Windows.Forms.Label
        Private winFormHtmlEditor1 As WinFormHtmlEditor
    End Class

End Namespace
