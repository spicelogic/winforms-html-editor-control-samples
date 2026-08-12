Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs

    Partial Public Class HyperLinkDialog
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As IContainer

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
            components = New Container()
            btnCancel = New Button()
            btnOK = New Button()
            grpInnerHtml = New GroupBox()
            txtInnerHtml = New TextBox()
            grpURL = New GroupBox()
            pnlRelativeUrl = New Panel()
            txtURL = New TextBox()
            cmbTarget = New ComboBox()
            rdoWorkingDirFile = New RadioButton()
            chkTargetIncluded = New CheckBox()
            lnkImportToBaseFolder = New LinkLabel()
            btnBrowseFile = New Button()
            lnkBrowseWD = New LinkLabel()
            rdoLocalFile = New RadioButton()
            chkOverwrite = New CheckBox()
            rdInternetURL = New RadioButton()
            lnkCheck = New LinkLabel()
            chkRemoveLink = New CheckBox()
            grpToolTip = New GroupBox()
            txtToolTip = New TextBox()
            toolTip1 = New ToolTip(components)
            grpInnerHtml.SuspendLayout()
            grpURL.SuspendLayout()
            pnlRelativeUrl.SuspendLayout()
            grpToolTip.SuspendLayout()
            SuspendLayout()
            ' 
            ' btnCancel
            ' 
            btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            btnCancel.Cursor = Cursors.Hand
            btnCancel.DialogResult = DialogResult.Cancel
            btnCancel.ForeColor = Drawing.SystemColors.ControlText
            btnCancel.ImageAlign = Drawing.ContentAlignment.MiddleRight
            btnCancel.Location = New System.Drawing.Point(1647, 810)
            btnCancel.Margin = New Padding(7, 8, 7, 8)
            btnCancel.Name = "btnCancel"
            btnCancel.Size = New System.Drawing.Size(210, 64)
            btnCancel.TabIndex = 5
            btnCancel.Text = "Cancel"
            btnCancel.UseVisualStyleBackColor = True
            ' 
            ' btnOK
            ' 
            btnOK.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            btnOK.Cursor = Cursors.Hand
            btnOK.DialogResult = DialogResult.OK
            btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
            btnOK.ForeColor = Drawing.SystemColors.ControlText
            btnOK.ImageAlign = Drawing.ContentAlignment.MiddleRight
            btnOK.Location = New System.Drawing.Point(1423, 810)
            btnOK.Margin = New Padding(7, 8, 7, 8)
            btnOK.Name = "btnOK"
            btnOK.Size = New System.Drawing.Size(210, 64)
            btnOK.TabIndex = 4
            btnOK.Text = "OK"
            btnOK.UseVisualStyleBackColor = True
            ' 
            ' grpInnerHtml
            ' 
            grpInnerHtml.Controls.Add(txtInnerHtml)
            grpInnerHtml.Dock = DockStyle.Top
            grpInnerHtml.Location = New System.Drawing.Point(19, 22)
            grpInnerHtml.Margin = New Padding(7, 8, 7, 8)
            grpInnerHtml.Name = "grpInnerHtml"
            grpInnerHtml.Padding = New Padding(7, 8, 7, 8)
            grpInnerHtml.Size = New System.Drawing.Size(1829, 266)
            grpInnerHtml.TabIndex = 6
            grpInnerHtml.TabStop = False
            grpInnerHtml.Text = "InnerHtml (or Text)"
            ' 
            ' txtInnerHtml
            ' 
            txtInnerHtml.BackColor = Drawing.Color.WhiteSmoke
            txtInnerHtml.Dock = DockStyle.Fill
            txtInnerHtml.Location = New System.Drawing.Point(7, 43)
            txtInnerHtml.Margin = New Padding(7, 8, 7, 8)
            txtInnerHtml.Multiline = True
            txtInnerHtml.Name = "txtInnerHtml"
            txtInnerHtml.ScrollBars = ScrollBars.Both
            txtInnerHtml.Size = New System.Drawing.Size(1815, 215)
            txtInnerHtml.TabIndex = 0
            ' 
            ' grpURL
            ' 
            grpURL.Controls.Add(pnlRelativeUrl)
            grpURL.Dock = DockStyle.Top
            grpURL.Location = New System.Drawing.Point(19, 288)
            grpURL.Margin = New Padding(7, 8, 7, 8)
            grpURL.Name = "grpURL"
            grpURL.Padding = New Padding(7, 8, 7, 8)
            grpURL.Size = New System.Drawing.Size(1829, 371)
            grpURL.TabIndex = 7
            grpURL.TabStop = False
            grpURL.Text = "URL"
            ' 
            ' pnlRelativeUrl
            ' 
            pnlRelativeUrl.Controls.Add(txtURL)
            pnlRelativeUrl.Controls.Add(cmbTarget)
            pnlRelativeUrl.Controls.Add(rdoWorkingDirFile)
            pnlRelativeUrl.Controls.Add(chkTargetIncluded)
            pnlRelativeUrl.Controls.Add(lnkImportToBaseFolder)
            pnlRelativeUrl.Controls.Add(btnBrowseFile)
            pnlRelativeUrl.Controls.Add(lnkBrowseWD)
            pnlRelativeUrl.Controls.Add(rdoLocalFile)
            pnlRelativeUrl.Controls.Add(chkOverwrite)
            pnlRelativeUrl.Controls.Add(rdInternetURL)
            pnlRelativeUrl.Location = New System.Drawing.Point(14, 53)
            pnlRelativeUrl.Margin = New Padding(7, 8, 7, 8)
            pnlRelativeUrl.Name = "pnlRelativeUrl"
            pnlRelativeUrl.Size = New System.Drawing.Size(1848, 318)
            pnlRelativeUrl.TabIndex = 41
            ' 
            ' txtURL
            ' 
            txtURL.BackColor = Drawing.Color.WhiteSmoke
            txtURL.Dock = DockStyle.Top
            txtURL.Location = New System.Drawing.Point(0, 0)
            txtURL.Margin = New Padding(7, 8, 7, 8)
            txtURL.Multiline = True
            txtURL.Name = "txtURL"
            txtURL.ScrollBars = ScrollBars.Both
            txtURL.Size = New System.Drawing.Size(1848, 131)
            txtURL.TabIndex = 41
            ' 
            ' cmbTarget
            ' 
            cmbTarget.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            cmbTarget.Enabled = False
            cmbTarget.FormattingEnabled = True
            cmbTarget.Items.AddRange(New Object() {"_blank", "_parent", "_search", "_self", "_top"})
            cmbTarget.Location = New System.Drawing.Point(1587, 222)
            cmbTarget.Margin = New Padding(7, 8, 7, 8)
            cmbTarget.Name = "cmbTarget"
            cmbTarget.Size = New System.Drawing.Size(228, 44)
            cmbTarget.TabIndex = 38
            ' 
            ' rdoWorkingDirFile
            ' 
            rdoWorkingDirFile.AutoSize = True
            rdoWorkingDirFile.Location = New System.Drawing.Point(747, 155)
            rdoWorkingDirFile.Margin = New Padding(7, 8, 7, 8)
            rdoWorkingDirFile.Name = "rdoWorkingDirFile"
            rdoWorkingDirFile.Size = New System.Drawing.Size(266, 40)
            rdoWorkingDirFile.TabIndex = 6
            rdoWorkingDirFile.Text = "Relative to Base Url"
            rdoWorkingDirFile.UseVisualStyleBackColor = True
            ' 
            ' chkTargetIncluded
            ' 
            chkTargetIncluded.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            chkTargetIncluded.AutoSize = True
            chkTargetIncluded.Location = New System.Drawing.Point(1423, 165)
            chkTargetIncluded.Margin = New Padding(7, 8, 7, 8)
            chkTargetIncluded.Name = "chkTargetIncluded"
            chkTargetIncluded.Size = New System.Drawing.Size(118, 40)
            chkTargetIncluded.TabIndex = 37
            chkTargetIncluded.Text = "Target"
            chkTargetIncluded.UseVisualStyleBackColor = True
            ' 
            ' lnkImportToBaseFolder
            ' 
            lnkImportToBaseFolder.AutoSize = True
            lnkImportToBaseFolder.Enabled = False
            lnkImportToBaseFolder.Location = New System.Drawing.Point(747, 260)
            lnkImportToBaseFolder.Margin = New Padding(7, 0, 7, 0)
            lnkImportToBaseFolder.Name = "lnkImportToBaseFolder"
            lnkImportToBaseFolder.Size = New System.Drawing.Size(363, 36)
            lnkImportToBaseFolder.TabIndex = 40
            lnkImportToBaseFolder.TabStop = True
            lnkImportToBaseFolder.Text = "Import a file to the base folder"
            ' 
            ' btnBrowseFile
            ' 
            btnBrowseFile.AutoSize = True
            btnBrowseFile.AutoSizeMode = AutoSizeMode.GrowAndShrink
            btnBrowseFile.Cursor = Cursors.Hand
            btnBrowseFile.Enabled = False
            btnBrowseFile.Font = New System.Drawing.Font("Verdana", 7F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
            btnBrowseFile.ImageAlign = Drawing.ContentAlignment.MiddleLeft
            btnBrowseFile.Location = New System.Drawing.Point(397, 216)
            btnBrowseFile.Margin = New Padding(7, 8, 7, 8)
            btnBrowseFile.MinimumSize = New System.Drawing.Size(210, 66)
            btnBrowseFile.Name = "btnBrowseFile"
            btnBrowseFile.Padding = New Padding(19, 0, 19, 0)
            btnBrowseFile.Size = New System.Drawing.Size(210, 66)
            btnBrowseFile.TabIndex = 3
            btnBrowseFile.Text = "Browse"
            btnBrowseFile.TextAlign = Drawing.ContentAlignment.MiddleRight
            toolTip1.SetToolTip(btnBrowseFile, "Browse File")
            btnBrowseFile.UseVisualStyleBackColor = True
            ' 
            ' lnkBrowseWD
            ' 
            lnkBrowseWD.AutoSize = True
            lnkBrowseWD.Enabled = False
            lnkBrowseWD.Location = New System.Drawing.Point(747, 210)
            lnkBrowseWD.Margin = New Padding(7, 0, 7, 0)
            lnkBrowseWD.Name = "lnkBrowseWD"
            lnkBrowseWD.Size = New System.Drawing.Size(198, 36)
            lnkBrowseWD.TabIndex = 39
            lnkBrowseWD.TabStop = True
            lnkBrowseWD.Text = "Browse for a file"
            ' 
            ' rdoLocalFile
            ' 
            rdoLocalFile.AutoSize = True
            rdoLocalFile.Location = New System.Drawing.Point(7, 224)
            rdoLocalFile.Margin = New Padding(7, 8, 7, 8)
            rdoLocalFile.Name = "rdoLocalFile"
            rdoLocalFile.Size = New System.Drawing.Size(370, 40)
            rdoLocalFile.TabIndex = 5
            rdoLocalFile.Text = "Local File with absolute path"
            rdoLocalFile.UseVisualStyleBackColor = True
            ' 
            ' chkOverwrite
            ' 
            chkOverwrite.AutoSize = True
            chkOverwrite.Enabled = False
            chkOverwrite.Location = New System.Drawing.Point(1237, 258)
            chkOverwrite.Margin = New Padding(7, 8, 7, 8)
            chkOverwrite.Name = "chkOverwrite"
            chkOverwrite.Size = New System.Drawing.Size(159, 40)
            chkOverwrite.TabIndex = 8
            chkOverwrite.Text = "Overwrite"
            chkOverwrite.UseVisualStyleBackColor = True
            ' 
            ' rdInternetURL
            ' 
            rdInternetURL.AutoSize = True
            rdInternetURL.Checked = True
            rdInternetURL.Location = New System.Drawing.Point(7, 155)
            rdInternetURL.Margin = New Padding(7, 8, 7, 8)
            rdInternetURL.Name = "rdInternetURL"
            rdInternetURL.Size = New System.Drawing.Size(191, 40)
            rdInternetURL.TabIndex = 4
            rdInternetURL.TabStop = True
            rdInternetURL.Text = "Internet URL"
            rdInternetURL.UseVisualStyleBackColor = True
            ' 
            ' lnkCheck
            ' 
            lnkCheck.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            lnkCheck.AutoSize = True
            lnkCheck.Cursor = Cursors.Hand
            lnkCheck.Location = New System.Drawing.Point(275, 823)
            lnkCheck.Margin = New Padding(7, 0, 7, 0)
            lnkCheck.Name = "lnkCheck"
            lnkCheck.Size = New System.Drawing.Size(138, 36)
            lnkCheck.TabIndex = 8
            lnkCheck.TabStop = True
            lnkCheck.Text = "Check URL"
            ' 
            ' chkRemoveLink
            ' 
            chkRemoveLink.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            chkRemoveLink.AutoSize = True
            chkRemoveLink.Location = New System.Drawing.Point(7, 828)
            chkRemoveLink.Margin = New Padding(7, 8, 7, 8)
            chkRemoveLink.Name = "chkRemoveLink"
            chkRemoveLink.Size = New System.Drawing.Size(192, 40)
            chkRemoveLink.TabIndex = 9
            chkRemoveLink.Text = "Remove Link"
            chkRemoveLink.UseVisualStyleBackColor = True
            ' 
            ' grpToolTip
            ' 
            grpToolTip.Controls.Add(txtToolTip)
            grpToolTip.Dock = DockStyle.Top
            grpToolTip.Location = New System.Drawing.Point(19, 659)
            grpToolTip.Margin = New Padding(7, 8, 7, 8)
            grpToolTip.Name = "grpToolTip"
            grpToolTip.Padding = New Padding(7, 8, 7, 8)
            grpToolTip.Size = New System.Drawing.Size(1829, 116)
            grpToolTip.TabIndex = 36
            grpToolTip.TabStop = False
            grpToolTip.Text = "ToolTip"
            ' 
            ' txtToolTip
            ' 
            txtToolTip.Dock = DockStyle.Fill
            txtToolTip.Location = New System.Drawing.Point(7, 43)
            txtToolTip.Margin = New Padding(7, 8, 7, 8)
            txtToolTip.Name = "txtToolTip"
            txtToolTip.ScrollBars = ScrollBars.Both
            txtToolTip.Size = New System.Drawing.Size(1815, 42)
            txtToolTip.TabIndex = 0
            ' 
            ' HyperLinkDialog
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(14F, 36F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(1867, 884)
            Controls.Add(grpToolTip)
            Controls.Add(chkRemoveLink)
            Controls.Add(lnkCheck)
            Controls.Add(grpURL)
            Controls.Add(grpInnerHtml)
            Controls.Add(btnCancel)
            Controls.Add(btnOK)
            Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Margin = New Padding(7, 8, 7, 8)
            Name = "HyperLinkDialog"
            Padding = New Padding(19, 22, 19, 22)
            StartPosition = FormStartPosition.CenterScreen
            Text = "Hyperlink Editor"
            grpInnerHtml.ResumeLayout(False)
            grpInnerHtml.PerformLayout()
            grpURL.ResumeLayout(False)
            pnlRelativeUrl.ResumeLayout(False)
            pnlRelativeUrl.PerformLayout()
            grpToolTip.ResumeLayout(False)
            grpToolTip.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private btnCancel As Button
        Private WithEvents btnOK As Button
        Private grpInnerHtml As GroupBox
        Private txtInnerHtml As TextBox
        Private grpURL As GroupBox
        Private WithEvents lnkCheck As LinkLabel
        Private chkRemoveLink As CheckBox
        Private cmbTarget As ComboBox
        Private grpToolTip As GroupBox
        Private txtToolTip As TextBox
        Private WithEvents chkTargetIncluded As CheckBox
        Private WithEvents btnBrowseFile As Button
        Private toolTip1 As ToolTip
        Private WithEvents rdoWorkingDirFile As RadioButton
        Private WithEvents rdoLocalFile As RadioButton
        Private rdInternetURL As RadioButton
        Private chkOverwrite As CheckBox
        Private WithEvents lnkBrowseWD As LinkLabel
        Private WithEvents lnkImportToBaseFolder As LinkLabel
        Private WithEvents pnlRelativeUrl As Panel
        Private txtURL As TextBox
    End Class

End Namespace
