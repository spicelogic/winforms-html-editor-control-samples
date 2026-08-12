Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs

    Partial Class SearchWindow
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchWindow))
            Me.chkMatchCase = New System.Windows.Forms.CheckBox()
            Me.chkMatchWholeWordOnly = New System.Windows.Forms.CheckBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdoDirectionDown = New System.Windows.Forms.RadioButton()
            Me.rdoDirectionUp = New System.Windows.Forms.RadioButton()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnFindNext = New System.Windows.Forms.Button()
            Me.txtSearchBox = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtReplaceBox = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.btnReplaceAll = New System.Windows.Forms.Button()
            Me.btnReplace = New System.Windows.Forms.Button()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            ' chkMatchCase
            '
            Me.chkMatchCase.AutoSize = True
            Me.chkMatchCase.Location = New System.Drawing.Point(14, 104)
            Me.chkMatchCase.Name = "chkMatchCase"
            Me.chkMatchCase.Size = New System.Drawing.Size(82, 17)
            Me.chkMatchCase.TabIndex = 3
            Me.chkMatchCase.Text = "Match &case"
            Me.chkMatchCase.UseVisualStyleBackColor = True
            '
            ' chkMatchWholeWordOnly
            '
            Me.chkMatchWholeWordOnly.AutoSize = True
            Me.chkMatchWholeWordOnly.Location = New System.Drawing.Point(14, 78)
            Me.chkMatchWholeWordOnly.Name = "chkMatchWholeWordOnly"
            Me.chkMatchWholeWordOnly.Size = New System.Drawing.Size(135, 17)
            Me.chkMatchWholeWordOnly.TabIndex = 2
            Me.chkMatchWholeWordOnly.Text = "Match &whole word only"
            Me.chkMatchWholeWordOnly.UseVisualStyleBackColor = True
            '
            ' groupBox1
            '
            Me.groupBox1.Controls.Add(Me.rdoDirectionDown)
            Me.groupBox1.Controls.Add(Me.rdoDirectionUp)
            Me.groupBox1.Location = New System.Drawing.Point(170, 74)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(112, 47)
            Me.groupBox1.TabIndex = 4
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Direction"
            '
            ' rdoDirectionDown
            '
            Me.rdoDirectionDown.AutoSize = True
            Me.rdoDirectionDown.Checked = True
            Me.rdoDirectionDown.Location = New System.Drawing.Point(51, 19)
            Me.rdoDirectionDown.Name = "rdoDirectionDown"
            Me.rdoDirectionDown.Size = New System.Drawing.Size(53, 17)
            Me.rdoDirectionDown.TabIndex = 1
            Me.rdoDirectionDown.TabStop = True
            Me.rdoDirectionDown.Text = "&Down"
            Me.rdoDirectionDown.UseVisualStyleBackColor = True
            '
            ' rdoDirectionUp
            '
            Me.rdoDirectionUp.AutoSize = True
            Me.rdoDirectionUp.Location = New System.Drawing.Point(6, 19)
            Me.rdoDirectionUp.Name = "rdoDirectionUp"
            Me.rdoDirectionUp.Size = New System.Drawing.Size(39, 17)
            Me.rdoDirectionUp.TabIndex = 0
            Me.rdoDirectionUp.TabStop = True
            Me.rdoDirectionUp.Text = "&Up"
            Me.rdoDirectionUp.UseVisualStyleBackColor = True
            '
            ' btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(420, 103)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 23)
            Me.btnCancel.TabIndex = 8
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            ' btnFindNext
            '
            Me.btnFindNext.AutoSize = True
            Me.btnFindNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnFindNext.Location = New System.Drawing.Point(420, 13)
            Me.btnFindNext.MinimumSize = New System.Drawing.Size(90, 23)
            Me.btnFindNext.Name = "btnFindNext"
            Me.btnFindNext.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnFindNext.Size = New System.Drawing.Size(90, 23)
            Me.btnFindNext.TabIndex = 5
            Me.btnFindNext.Text = "&Find Next"
            Me.btnFindNext.UseVisualStyleBackColor = True
            '
            ' txtSearchBox
            '
            Me.txtSearchBox.Location = New System.Drawing.Point(105, 14)
            Me.txtSearchBox.Name = "txtSearchBox"
            Me.txtSearchBox.Size = New System.Drawing.Size(300, 20)
            Me.txtSearchBox.TabIndex = 0
            '
            ' label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(11, 14)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(59, 13)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Fi&nd What:"
            '
            ' txtReplaceBox
            '
            Me.txtReplaceBox.Location = New System.Drawing.Point(105, 43)
            Me.txtReplaceBox.Name = "txtReplaceBox"
            Me.txtReplaceBox.Size = New System.Drawing.Size(300, 20)
            Me.txtReplaceBox.TabIndex = 1
            '
            ' label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(11, 43)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(75, 13)
            Me.label2.TabIndex = 16
            Me.label2.Text = "Re&place With:"
            '
            ' btnReplaceAll
            '
            Me.btnReplaceAll.AutoSize = True
            Me.btnReplaceAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnReplaceAll.Location = New System.Drawing.Point(420, 73)
            Me.btnReplaceAll.MinimumSize = New System.Drawing.Size(90, 23)
            Me.btnReplaceAll.Name = "btnReplaceAll"
            Me.btnReplaceAll.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnReplaceAll.Size = New System.Drawing.Size(90, 23)
            Me.btnReplaceAll.TabIndex = 7
            Me.btnReplaceAll.Text = "Replace &All"
            Me.btnReplaceAll.UseVisualStyleBackColor = True
            '
            ' btnReplace
            '
            Me.btnReplace.AutoSize = True
            Me.btnReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnReplace.Location = New System.Drawing.Point(420, 43)
            Me.btnReplace.MinimumSize = New System.Drawing.Size(90, 23)
            Me.btnReplace.Name = "btnReplace"
            Me.btnReplace.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.btnReplace.Size = New System.Drawing.Size(90, 23)
            Me.btnReplace.TabIndex = 6
            Me.btnReplace.Text = "&Replace"
            Me.btnReplace.UseVisualStyleBackColor = True
            '
            ' SearchWindow
            '
            Me.AcceptButton = Me.btnFindNext
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(525, 139)
            Me.Controls.Add(Me.btnReplaceAll)
            Me.Controls.Add(Me.btnReplace)
            Me.Controls.Add(Me.txtReplaceBox)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.chkMatchCase)
            Me.Controls.Add(Me.chkMatchWholeWordOnly)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnFindNext)
            Me.Controls.Add(Me.txtSearchBox)
            Me.Controls.Add(Me.label1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SearchWindow"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Search"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private chkMatchCase As CheckBox
        Private chkMatchWholeWordOnly As CheckBox
        Private groupBox1 As GroupBox
        Private rdoDirectionDown As RadioButton
        Private rdoDirectionUp As RadioButton
        Private btnCancel As Button
        Private WithEvents btnFindNext As Button
        Private WithEvents txtSearchBox As TextBox
        Private label1 As Label
        Private txtReplaceBox As TextBox
        Private label2 As Label
        Private WithEvents btnReplaceAll As Button
        Private WithEvents btnReplace As Button
    End Class

End Namespace
