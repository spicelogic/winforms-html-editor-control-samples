Imports SpiceLogic.HtmlEditor.WinForms

Partial Class BodyHtmlBindingForm
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me._bindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._editor = New WinFormHtmlEditor()
        Me._grid = New System.Windows.Forms.DataGridView()
        Me._navigator = New System.Windows.Forms.BindingNavigator(Me._bindingSource)
        Me._saveButton = New System.Windows.Forms.ToolStripButton()
        CType(Me._bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._navigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._navigator.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Nothing
        Me._editor.Location = New System.Drawing.Point(0, 225)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 475)
        Me._editor.TabIndex = 2
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' _grid
        '
        Me._grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._grid.DataSource = Me._bindingSource
        Me._grid.Dock = System.Windows.Forms.DockStyle.Top
        Me._grid.Location = New System.Drawing.Point(0, 25)
        Me._grid.Name = "_grid"
        Me._grid.Size = New System.Drawing.Size(1000, 200)
        Me._grid.TabIndex = 1
        '
        ' _navigator
        '
        Me._navigator.BindingSource = Me._bindingSource
        Me._navigator.Dock = System.Windows.Forms.DockStyle.Top
        Me._navigator.Items.Add(Me._saveButton)
        Me._navigator.Location = New System.Drawing.Point(0, 0)
        Me._navigator.Name = "_navigator"
        Me._navigator.Size = New System.Drawing.Size(1000, 25)
        Me._navigator.TabIndex = 0
        '
        ' _saveButton
        '
        Me._saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._saveButton.Name = "_saveButton"
        Me._saveButton.Size = New System.Drawing.Size(63, 22)
        Me._saveButton.Text = "Save data"
        '
        ' BodyHtmlBindingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me._editor)
        Me.Controls.Add(Me._grid)
        Me.Controls.Add(Me._navigator)
        Me.Name = "BodyHtmlBindingForm"
        Me.Text = "BodyHtml binding demo (VB.NET)"
        CType(Me._bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._navigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me._navigator.ResumeLayout(False)
        Me._navigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

#End Region

    Private _bindingSource As System.Windows.Forms.BindingSource
    Private _editor As WinFormHtmlEditor
    Private _grid As System.Windows.Forms.DataGridView
    Private _navigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents _saveButton As System.Windows.Forms.ToolStripButton
End Class
