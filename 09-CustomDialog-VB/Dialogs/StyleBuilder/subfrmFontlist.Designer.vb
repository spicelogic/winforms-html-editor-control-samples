Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class frmFontPicker
    ''' </summary>
    Partial Public Class frmFontPicker
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private ReadOnly components As IContainer = Nothing

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
            Me.lHint = New System.Windows.Forms.Label()
            Me.lInstalledFonts = New System.Windows.Forms.Label()
            Me.lbInstalledFonts = New System.Windows.Forms.ListBox()
            Me.lGenericFonts = New System.Windows.Forms.Label()
            Me.cbGenericFonts = New System.Windows.Forms.ComboBox()
            Me.lCustomFont = New System.Windows.Forms.Label()
            Me.tbCustomFont = New System.Windows.Forms.TextBox()
            Me.btAddInstalledFont = New System.Windows.Forms.Button()
            Me.btAddGenericFont = New System.Windows.Forms.Button()
            Me.btAddCustomFont = New System.Windows.Forms.Button()
            Me.lbSelectedFonts = New System.Windows.Forms.ListBox()
            Me.btMoveUp = New System.Windows.Forms.Button()
            Me.btMoveDown = New System.Windows.Forms.Button()
            Me.btRemove = New System.Windows.Forms.Button()
            Me.btOk = New System.Windows.Forms.Button()
            Me.btCancel = New System.Windows.Forms.Button()
            Me.lSelectedFontsTitle = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            ' lHint
            '
            Me.lHint.AutoSize = True
            Me.lHint.Location = New System.Drawing.Point(12, 9)
            Me.lHint.Name = "lHint"
            Me.lHint.Size = New System.Drawing.Size(225, 13)
            Me.lHint.TabIndex = 0
            Me.lHint.Text = "Create a font sequence in order of preference:"
            '
            ' lInstalledFonts
            '
            Me.lInstalledFonts.AutoSize = True
            Me.lInstalledFonts.Location = New System.Drawing.Point(12, 33)
            Me.lInstalledFonts.Name = "lInstalledFonts"
            Me.lInstalledFonts.Size = New System.Drawing.Size(78, 13)
            Me.lInstalledFonts.TabIndex = 1
            Me.lInstalledFonts.Text = "&Installed Fonts:"
            '
            ' lbInstalledFonts
            '
            Me.lbInstalledFonts.FormattingEnabled = True
            Me.lbInstalledFonts.Location = New System.Drawing.Point(15, 49)
            Me.lbInstalledFonts.Name = "lbInstalledFonts"
            Me.lbInstalledFonts.Size = New System.Drawing.Size(222, 160)
            Me.lbInstalledFonts.TabIndex = 2
            '
            ' lGenericFonts
            '
            Me.lGenericFonts.AutoSize = True
            Me.lGenericFonts.Location = New System.Drawing.Point(12, 215)
            Me.lGenericFonts.Name = "lGenericFonts"
            Me.lGenericFonts.Size = New System.Drawing.Size(76, 13)
            Me.lGenericFonts.TabIndex = 3
            Me.lGenericFonts.Text = "&Generic Fonts:"
            '
            ' cbGenericFonts
            '
            Me.cbGenericFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbGenericFonts.FormattingEnabled = True
            Me.cbGenericFonts.Items.AddRange(New Object() {
            "Monospace",
            "Serif",
            "Sans-Serif",
            "Cursive",
            "Fantasy"})
            Me.cbGenericFonts.Location = New System.Drawing.Point(15, 231)
            Me.cbGenericFonts.Name = "cbGenericFonts"
            Me.cbGenericFonts.Size = New System.Drawing.Size(222, 21)
            Me.cbGenericFonts.TabIndex = 4
            '
            ' lCustomFont
            '
            Me.lCustomFont.AutoSize = True
            Me.lCustomFont.Location = New System.Drawing.Point(12, 264)
            Me.lCustomFont.Name = "lCustomFont"
            Me.lCustomFont.Size = New System.Drawing.Size(66, 13)
            Me.lCustomFont.TabIndex = 5
            Me.lCustomFont.Text = "&Custom font:"
            '
            ' tbCustomFont
            '
            Me.tbCustomFont.Location = New System.Drawing.Point(12, 280)
            Me.tbCustomFont.Name = "tbCustomFont"
            Me.tbCustomFont.Size = New System.Drawing.Size(225, 20)
            Me.tbCustomFont.TabIndex = 6
            '
            ' btAddInstalledFont
            '
            Me.btAddInstalledFont.Location = New System.Drawing.Point(243, 49)
            Me.btAddInstalledFont.Name = "btAddInstalledFont"
            Me.btAddInstalledFont.Size = New System.Drawing.Size(48, 23)
            Me.btAddInstalledFont.TabIndex = 7
            Me.btAddInstalledFont.Text = ">>>"
            Me.btAddInstalledFont.UseVisualStyleBackColor = True
            '
            ' btAddGenericFont
            '
            Me.btAddGenericFont.Location = New System.Drawing.Point(243, 229)
            Me.btAddGenericFont.Name = "btAddGenericFont"
            Me.btAddGenericFont.Size = New System.Drawing.Size(48, 23)
            Me.btAddGenericFont.TabIndex = 8
            Me.btAddGenericFont.Text = ">>>"
            Me.btAddGenericFont.UseVisualStyleBackColor = True
            '
            ' btAddCustomFont
            '
            Me.btAddCustomFont.Location = New System.Drawing.Point(243, 278)
            Me.btAddCustomFont.Name = "btAddCustomFont"
            Me.btAddCustomFont.Size = New System.Drawing.Size(48, 23)
            Me.btAddCustomFont.TabIndex = 9
            Me.btAddCustomFont.Text = ">>>"
            Me.btAddCustomFont.UseVisualStyleBackColor = True
            '
            ' lbSelectedFonts
            '
            Me.lbSelectedFonts.FormattingEnabled = True
            Me.lbSelectedFonts.Location = New System.Drawing.Point(297, 49)
            Me.lbSelectedFonts.Name = "lbSelectedFonts"
            Me.lbSelectedFonts.Size = New System.Drawing.Size(241, 251)
            Me.lbSelectedFonts.TabIndex = 10
            '
            ' btMoveUp
            '
            Me.btMoveUp.Location = New System.Drawing.Point(544, 49)
            Me.btMoveUp.Name = "btMoveUp"
            Me.btMoveUp.Size = New System.Drawing.Size(75, 23)
            Me.btMoveUp.TabIndex = 11
            Me.btMoveUp.Text = "Move &Up"
            Me.btMoveUp.UseVisualStyleBackColor = True
            '
            ' btMoveDown
            '
            Me.btMoveDown.Location = New System.Drawing.Point(544, 78)
            Me.btMoveDown.Name = "btMoveDown"
            Me.btMoveDown.Size = New System.Drawing.Size(75, 23)
            Me.btMoveDown.TabIndex = 12
            Me.btMoveDown.Text = "Move &Down"
            Me.btMoveDown.UseVisualStyleBackColor = True
            '
            ' btRemove
            '
            Me.btRemove.Location = New System.Drawing.Point(544, 277)
            Me.btRemove.Name = "btRemove"
            Me.btRemove.Size = New System.Drawing.Size(75, 23)
            Me.btRemove.TabIndex = 13
            Me.btRemove.Text = "&Remove"
            Me.btRemove.UseVisualStyleBackColor = True
            '
            ' btOk
            '
            Me.btOk.Location = New System.Drawing.Point(463, 313)
            Me.btOk.Name = "btOk"
            Me.btOk.Size = New System.Drawing.Size(75, 23)
            Me.btOk.TabIndex = 14
            Me.btOk.Text = "OK"
            Me.btOk.UseVisualStyleBackColor = True
            '
            ' btCancel
            '
            Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btCancel.Location = New System.Drawing.Point(546, 313)
            Me.btCancel.Name = "btCancel"
            Me.btCancel.Size = New System.Drawing.Size(75, 23)
            Me.btCancel.TabIndex = 15
            Me.btCancel.Text = "Cancel"
            Me.btCancel.UseVisualStyleBackColor = True
            '
            ' lSelectedFontsTitle
            '
            Me.lSelectedFontsTitle.AutoSize = True
            Me.lSelectedFontsTitle.Location = New System.Drawing.Point(294, 33)
            Me.lSelectedFontsTitle.Name = "lSelectedFontsTitle"
            Me.lSelectedFontsTitle.Size = New System.Drawing.Size(81, 13)
            Me.lSelectedFontsTitle.TabIndex = 16
            Me.lSelectedFontsTitle.Text = "&Selected Fonts:"
            '
            ' frmFontPicker
            '
            Me.AcceptButton = Me.btOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btCancel
            Me.ClientSize = New System.Drawing.Size(633, 348)
            Me.Controls.Add(Me.lSelectedFontsTitle)
            Me.Controls.Add(Me.btCancel)
            Me.Controls.Add(Me.btOk)
            Me.Controls.Add(Me.btRemove)
            Me.Controls.Add(Me.btMoveDown)
            Me.Controls.Add(Me.btMoveUp)
            Me.Controls.Add(Me.lbSelectedFonts)
            Me.Controls.Add(Me.btAddCustomFont)
            Me.Controls.Add(Me.btAddGenericFont)
            Me.Controls.Add(Me.btAddInstalledFont)
            Me.Controls.Add(Me.tbCustomFont)
            Me.Controls.Add(Me.lCustomFont)
            Me.Controls.Add(Me.cbGenericFonts)
            Me.Controls.Add(Me.lGenericFonts)
            Me.Controls.Add(Me.lbInstalledFonts)
            Me.Controls.Add(Me.lInstalledFonts)
            Me.Controls.Add(Me.lHint)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MinimizeBox = False
            Me.Name = "frmFontPicker"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Font Picker"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        ''' <summary>
        ''' The l hint
        ''' </summary>
        Private lHint As Label
        ''' <summary>
        ''' The l installed fonts
        ''' </summary>
        Private lInstalledFonts As Label
        ''' <summary>
        ''' The lb installed fonts
        ''' </summary>
        Private lbInstalledFonts As ListBox
        ''' <summary>
        ''' The l generic fonts
        ''' </summary>
        Private lGenericFonts As Label
        ''' <summary>
        ''' The cb generic fonts
        ''' </summary>
        Private cbGenericFonts As ComboBox
        ''' <summary>
        ''' The l custom font
        ''' </summary>
        Private lCustomFont As Label
        ''' <summary>
        ''' The tb custom font
        ''' </summary>
        Private WithEvents tbCustomFont As TextBox
        ''' <summary>
        ''' The bt add installed font
        ''' </summary>
        Private WithEvents btAddInstalledFont As Button
        ''' <summary>
        ''' The bt add generic font
        ''' </summary>
        Private WithEvents btAddGenericFont As Button
        ''' <summary>
        ''' The bt add custom font
        ''' </summary>
        Private WithEvents btAddCustomFont As Button
        ''' <summary>
        ''' The lb selected fonts
        ''' </summary>
        Private WithEvents lbSelectedFonts As ListBox
        ''' <summary>
        ''' The bt move up
        ''' </summary>
        Private WithEvents btMoveUp As Button
        ''' <summary>
        ''' The bt move down
        ''' </summary>
        Private WithEvents btMoveDown As Button
        ''' <summary>
        ''' The bt remove
        ''' </summary>
        Private WithEvents btRemove As Button
        ''' <summary>
        ''' The bt ok
        ''' </summary>
        Private WithEvents btOk As Button
        ''' <summary>
        ''' The bt cancel
        ''' </summary>
        Private WithEvents btCancel As Button
        ''' <summary>
        ''' The l selected fonts title
        ''' </summary>
        Private lSelectedFontsTitle As Label
    End Class

End Namespace
