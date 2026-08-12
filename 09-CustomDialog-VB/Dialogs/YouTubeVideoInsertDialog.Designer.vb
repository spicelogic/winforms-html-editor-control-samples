Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs

    Partial Class YouTubeVideoInsertDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YouTubeVideoInsertDialog))
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtUrl = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtCssStyle = New System.Windows.Forms.TextBox()
            Me.txtWidth = New System.Windows.Forms.TextBox()
            Me.txtHeight = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            ' btnCancel
            '
            Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancel.Location = New System.Drawing.Point(438, 157)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 23)
            Me.btnCancel.TabIndex = 40
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            ' btnOK
            '
            Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.Location = New System.Drawing.Point(348, 157)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 23)
            Me.btnOK.TabIndex = 39
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            ' label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(13, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(115, 13)
            Me.label1.TabIndex = 41
            Me.label1.Text = "YouTube Video URL : "
            '
            ' txtUrl
            '
            Me.txtUrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.txtUrl.Location = New System.Drawing.Point(13, 30)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(515, 20)
            Me.txtUrl.TabIndex = 42
            '
            ' label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(14, 124)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(44, 13)
            Me.label2.TabIndex = 43
            Me.label2.Text = "Width : "
            '
            ' label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(180, 124)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(47, 13)
            Me.label3.TabIndex = 45
            Me.label3.Text = "Height : "
            '
            ' label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(12, 70)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(54, 13)
            Me.label4.TabIndex = 47
            Me.label4.Text = "CSS Style"
            '
            ' txtCssStyle
            '
            Me.txtCssStyle.Location = New System.Drawing.Point(13, 86)
            Me.txtCssStyle.Name = "txtCssStyle"
            Me.txtCssStyle.Size = New System.Drawing.Size(515, 20)
            Me.txtCssStyle.TabIndex = 48
            '
            ' txtWidth
            '
            Me.txtWidth.Location = New System.Drawing.Point(70, 120)
            Me.txtWidth.Name = "txtWidth"
            Me.txtWidth.Size = New System.Drawing.Size(70, 20)
            Me.txtWidth.TabIndex = 49
            '
            ' txtHeight
            '
            Me.txtHeight.Location = New System.Drawing.Point(240, 120)
            Me.txtHeight.Name = "txtHeight"
            Me.txtHeight.Size = New System.Drawing.Size(70, 20)
            Me.txtHeight.TabIndex = 50
            '
            ' YouTubeVideoInsertDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(540, 192)
            Me.Controls.Add(Me.txtHeight)
            Me.Controls.Add(Me.txtWidth)
            Me.Controls.Add(Me.txtCssStyle)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnOK)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "YouTubeVideoInsertDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "YouTube Video Insert"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private btnCancel As Button
        Private WithEvents btnOK As Button
        Private label1 As Label
        Private txtUrl As TextBox
        Private label2 As Label
        Private label3 As Label
        Private label4 As Label
        Private txtCssStyle As TextBox
        Private txtWidth As TextBox
        Private txtHeight As TextBox
    End Class

End Namespace
