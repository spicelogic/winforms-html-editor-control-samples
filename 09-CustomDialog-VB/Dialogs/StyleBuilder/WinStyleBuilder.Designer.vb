Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public NotInheritable Class WinStyleBuilder
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
            Me.lbPage = New System.Windows.Forms.ListBox()
            Me.pnlSelectedPage = New System.Windows.Forms.Panel()
            Me.btOk = New System.Windows.Forms.Button()
            Me.btCancel = New System.Windows.Forms.Button()
            Me.chkRemoveStyle = New System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            '
            ' lbPage
            '
            Me.lbPage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.lbPage.FormattingEnabled = True
            Me.lbPage.Items.AddRange(New Object() {
            "Font",
            "Background",
            "Text",
            "Position",
            "Layout",
            "Edges",
            "List Position",
            "Other"})
            Me.lbPage.Location = New System.Drawing.Point(12, 12)
            Me.lbPage.Name = "lbPage"
            Me.lbPage.Size = New System.Drawing.Size(123, 433)
            Me.lbPage.TabIndex = 0
            '
            ' pnlSelectedPage
            '
            Me.pnlSelectedPage.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pnlSelectedPage.Location = New System.Drawing.Point(141, 12)
            Me.pnlSelectedPage.Name = "pnlSelectedPage"
            Me.pnlSelectedPage.Size = New System.Drawing.Size(517, 433)
            Me.pnlSelectedPage.TabIndex = 1
            '
            ' btOk
            '
            Me.btOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btOk.Location = New System.Drawing.Point(502, 451)
            Me.btOk.Name = "btOk"
            Me.btOk.Size = New System.Drawing.Size(75, 23)
            Me.btOk.TabIndex = 2
            Me.btOk.Text = "OK"
            Me.btOk.UseVisualStyleBackColor = True
            '
            ' btCancel
            '
            Me.btCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btCancel.Location = New System.Drawing.Point(583, 451)
            Me.btCancel.Name = "btCancel"
            Me.btCancel.Size = New System.Drawing.Size(75, 23)
            Me.btCancel.TabIndex = 3
            Me.btCancel.Text = "Cancel"
            Me.btCancel.UseVisualStyleBackColor = True
            '
            ' chkRemoveStyle
            '
            Me.chkRemoveStyle.AutoSize = True
            Me.chkRemoveStyle.Location = New System.Drawing.Point(13, 456)
            Me.chkRemoveStyle.Name = "chkRemoveStyle"
            Me.chkRemoveStyle.Size = New System.Drawing.Size(278, 17)
            Me.chkRemoveStyle.TabIndex = 4
            Me.chkRemoveStyle.Text = "Remove Style (Return Empty String for Style Attribute)"
            Me.chkRemoveStyle.UseVisualStyleBackColor = True
            '
            ' WinStyleBuilder
            '
            Me.AcceptButton = Me.btOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btCancel
            Me.ClientSize = New System.Drawing.Size(670, 486)
            Me.ControlBox = False
            Me.Controls.Add(Me.chkRemoveStyle)
            Me.Controls.Add(Me.btCancel)
            Me.Controls.Add(Me.btOk)
            Me.Controls.Add(Me.pnlSelectedPage)
            Me.Controls.Add(Me.lbPage)
            Me.Name = "WinStyleBuilder"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Style Builder"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents lbPage As ListBox
        Private pnlSelectedPage As Panel
        Private btOk As Button
        Private btCancel As Button
        Private chkRemoveStyle As CheckBox
    End Class

End Namespace
