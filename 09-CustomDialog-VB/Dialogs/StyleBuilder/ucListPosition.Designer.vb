Imports System.ComponentModel
Imports System.Windows.Forms

Imports CustomDialog.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    Partial Public Class ucListPosition
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

#Region "Component Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gbBullets = New System.Windows.Forms.GroupBox()
            Me.lPosition = New System.Windows.Forms.Label()
            Me.cbBulletPosition = New System.Windows.Forms.ComboBox()
            Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
            Me.gbBullets.SuspendLayout()
            Me.SuspendLayout()
            '
            ' gbBullets
            '
            Me.gbBullets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.gbBullets.Controls.Add(Me.lPosition)
            Me.gbBullets.Controls.Add(Me.cbBulletPosition)
            Me.gbBullets.Location = New System.Drawing.Point(3, 3)
            Me.gbBullets.Name = "gbBullets"
            Me.gbBullets.Size = New System.Drawing.Size(454, 54)
            Me.gbBullets.TabIndex = 2
            Me.gbBullets.TabStop = False
            Me.gbBullets.Text = "Bullets"
            '
            ' lPosition
            '
            Me.lPosition.AutoSize = True
            Me.lPosition.Location = New System.Drawing.Point(6, 23)
            Me.lPosition.Name = "lPosition"
            Me.lPosition.Size = New System.Drawing.Size(44, 13)
            Me.lPosition.TabIndex = 8
            Me.lPosition.Text = "&Position"
            '
            ' cbBulletPosition
            '
            Me.cbBulletPosition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbBulletPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBulletPosition.FormattingEnabled = True
            Me.cbBulletPosition.Location = New System.Drawing.Point(112, 20)
            Me.cbBulletPosition.Name = "cbBulletPosition"
            Me.cbBulletPosition.Size = New System.Drawing.Size(285, 21)
            Me.cbBulletPosition.TabIndex = 1
            '
            ' ucListPosition
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbBullets)
            Me.Name = "ucListPosition"
            Me.Size = New System.Drawing.Size(460, 219)
            Me.gbBullets.ResumeLayout(False)
            Me.gbBullets.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gbBullets As GroupBox
        Private cbBulletPosition As ComboBox
        Private lPosition As Label
        Private dlgOpen As OpenFileDialog
    End Class

End Namespace
