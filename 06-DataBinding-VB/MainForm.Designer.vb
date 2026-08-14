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
        Me._documentHtmlButton = New System.Windows.Forms.Button()
        Me._bodyHtmlButton = New System.Windows.Forms.Button()
        Me._instructions = New System.Windows.Forms.Label()
        Me._description = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' _documentHtmlButton
        '
        Me._documentHtmlButton.Dock = System.Windows.Forms.DockStyle.Top
        Me._documentHtmlButton.Location = New System.Drawing.Point(15, 165)
        Me._documentHtmlButton.Name = "_documentHtmlButton"
        Me._documentHtmlButton.Size = New System.Drawing.Size(594, 40)
        Me._documentHtmlButton.TabIndex = 1
        Me._documentHtmlButton.Text = "DocumentHtml binding - bind the full document HTML, including head and body"
        Me._documentHtmlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._documentHtmlButton.UseVisualStyleBackColor = True
        '
        ' _bodyHtmlButton
        '
        Me._bodyHtmlButton.Dock = System.Windows.Forms.DockStyle.Top
        Me._bodyHtmlButton.Location = New System.Drawing.Point(15, 125)
        Me._bodyHtmlButton.Name = "_bodyHtmlButton"
        Me._bodyHtmlButton.Size = New System.Drawing.Size(594, 40)
        Me._bodyHtmlButton.TabIndex = 0
        Me._bodyHtmlButton.Text = "BodyHtml binding - bind editor content via the BodyHtml property"
        Me._bodyHtmlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._bodyHtmlButton.UseVisualStyleBackColor = True
        '
        ' _instructions
        '
        Me._instructions.Dock = System.Windows.Forms.DockStyle.Top
        Me._instructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
        Me._instructions.Location = New System.Drawing.Point(15, 95)
        Me._instructions.Name = "_instructions"
        Me._instructions.Size = New System.Drawing.Size(594, 30)
        Me._instructions.TabIndex = 2
        Me._instructions.Text = "Choose a binding scenario:"
        '
        ' _description
        '
        Me._description.Dock = System.Windows.Forms.DockStyle.Top
        Me._description.Location = New System.Drawing.Point(15, 15)
        Me._description.Name = "_description"
        Me._description.Size = New System.Drawing.Size(594, 80)
        Me._description.TabIndex = 3
        Me._description.Text = "The WinForms HTML editor supports standard WinForms data binding for both the Body" &
    "Html and DocumentHtml properties, so you can bind editor content to a list, a Dat" &
    "aSet, or a business object through a BindingSource - the same way you would bind " &
    "any other control."
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 281)
        ' Docked controls stack from the last one added (outermost) to the first
        ' (innermost), so this order puts the description at the very top and the
        ' buttons below it.
        Me.Controls.Add(Me._documentHtmlButton)
        Me.Controls.Add(Me._bodyHtmlButton)
        Me.Controls.Add(Me._instructions)
        Me.Controls.Add(Me._description)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpiceLogic WinForms HTML editor - data binding (VB.NET)"
        Me.ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents _documentHtmlButton As System.Windows.Forms.Button
    Friend WithEvents _bodyHtmlButton As System.Windows.Forms.Button
    Private _instructions As System.Windows.Forms.Label
    Private _description As System.Windows.Forms.Label
End Class
