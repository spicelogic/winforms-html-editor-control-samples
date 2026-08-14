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
        Me.components = New System.ComponentModel.Container()
        Me._contextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me._imagePropertiesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._linkPropertiesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._cellPropertiesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._tableMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me._tablePropertiesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._insertRowBeforeItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._insertRowAfterItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._deleteRowItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._insertColumnBeforeItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._insertColumnAfterItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._deleteColumnItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._mergeCellsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._youTubeItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._tableSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me._alignmentMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me._alignLeftItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._alignCenterItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._alignRightItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._removeAlignmentItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._clipboardSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me._cutItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._copyItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._pasteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._deleteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._selectAllSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me._selectAllItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._editor = New WinFormHtmlEditor()
        Me._contextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        ' _contextMenu
        '
        Me._contextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me._imagePropertiesItem,
            Me._linkPropertiesItem,
            Me._cellPropertiesItem,
            Me._tableMenu,
            Me._youTubeItem,
            Me._tableSeparator,
            Me._alignmentMenu,
            Me._clipboardSeparator,
            Me._cutItem,
            Me._copyItem,
            Me._pasteItem,
            Me._deleteItem,
            Me._selectAllSeparator,
            Me._selectAllItem})
        Me._contextMenu.Name = "_contextMenu"
        Me._contextMenu.Size = New System.Drawing.Size(216, 264)
        '
        ' _imagePropertiesItem
        '
        Me._imagePropertiesItem.Name = "_imagePropertiesItem"
        Me._imagePropertiesItem.Size = New System.Drawing.Size(215, 22)
        Me._imagePropertiesItem.Text = "Image properties"
        '
        ' _linkPropertiesItem
        '
        Me._linkPropertiesItem.Name = "_linkPropertiesItem"
        Me._linkPropertiesItem.Size = New System.Drawing.Size(215, 22)
        Me._linkPropertiesItem.Text = "Link properties"
        '
        ' _cellPropertiesItem
        '
        Me._cellPropertiesItem.Name = "_cellPropertiesItem"
        Me._cellPropertiesItem.Size = New System.Drawing.Size(215, 22)
        Me._cellPropertiesItem.Text = "Cell properties"
        '
        ' _tableMenu
        '
        Me._tableMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me._tablePropertiesItem,
            Me._insertRowBeforeItem,
            Me._insertRowAfterItem,
            Me._deleteRowItem,
            Me._insertColumnBeforeItem,
            Me._insertColumnAfterItem,
            Me._deleteColumnItem,
            Me._mergeCellsItem})
        Me._tableMenu.Name = "_tableMenu"
        Me._tableMenu.Size = New System.Drawing.Size(215, 22)
        Me._tableMenu.Text = "Table"
        '
        ' _tablePropertiesItem
        '
        Me._tablePropertiesItem.Name = "_tablePropertiesItem"
        Me._tablePropertiesItem.Size = New System.Drawing.Size(196, 22)
        Me._tablePropertiesItem.Text = "Table properties"
        '
        ' _insertRowBeforeItem
        '
        Me._insertRowBeforeItem.Name = "_insertRowBeforeItem"
        Me._insertRowBeforeItem.Size = New System.Drawing.Size(196, 22)
        Me._insertRowBeforeItem.Text = "Insert row (before)"
        '
        ' _insertRowAfterItem
        '
        Me._insertRowAfterItem.Name = "_insertRowAfterItem"
        Me._insertRowAfterItem.Size = New System.Drawing.Size(196, 22)
        Me._insertRowAfterItem.Text = "Insert row (after)"
        '
        ' _deleteRowItem
        '
        Me._deleteRowItem.Name = "_deleteRowItem"
        Me._deleteRowItem.Size = New System.Drawing.Size(196, 22)
        Me._deleteRowItem.Text = "Delete row"
        '
        ' _insertColumnBeforeItem
        '
        Me._insertColumnBeforeItem.Name = "_insertColumnBeforeItem"
        Me._insertColumnBeforeItem.Size = New System.Drawing.Size(196, 22)
        Me._insertColumnBeforeItem.Text = "Insert column (before)"
        '
        ' _insertColumnAfterItem
        '
        Me._insertColumnAfterItem.Name = "_insertColumnAfterItem"
        Me._insertColumnAfterItem.Size = New System.Drawing.Size(196, 22)
        Me._insertColumnAfterItem.Text = "Insert column (after)"
        '
        ' _deleteColumnItem
        '
        Me._deleteColumnItem.Name = "_deleteColumnItem"
        Me._deleteColumnItem.Size = New System.Drawing.Size(196, 22)
        Me._deleteColumnItem.Text = "Delete column"
        '
        ' _mergeCellsItem
        '
        Me._mergeCellsItem.Name = "_mergeCellsItem"
        Me._mergeCellsItem.Size = New System.Drawing.Size(196, 22)
        Me._mergeCellsItem.Text = "Merge cells"
        '
        ' _youTubeItem
        '
        Me._youTubeItem.Name = "_youTubeItem"
        Me._youTubeItem.Size = New System.Drawing.Size(215, 22)
        Me._youTubeItem.Text = "YouTube video properties"
        '
        ' _tableSeparator
        '
        Me._tableSeparator.Name = "_tableSeparator"
        Me._tableSeparator.Size = New System.Drawing.Size(212, 6)
        '
        ' _alignmentMenu
        '
        Me._alignmentMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me._alignLeftItem,
            Me._alignCenterItem,
            Me._alignRightItem,
            Me._removeAlignmentItem})
        Me._alignmentMenu.Name = "_alignmentMenu"
        Me._alignmentMenu.Size = New System.Drawing.Size(215, 22)
        Me._alignmentMenu.Text = "Alignment"
        '
        ' _alignLeftItem
        '
        Me._alignLeftItem.Name = "_alignLeftItem"
        Me._alignLeftItem.Size = New System.Drawing.Size(180, 22)
        Me._alignLeftItem.Text = "Left"
        '
        ' _alignCenterItem
        '
        Me._alignCenterItem.Name = "_alignCenterItem"
        Me._alignCenterItem.Size = New System.Drawing.Size(180, 22)
        Me._alignCenterItem.Text = "Center"
        '
        ' _alignRightItem
        '
        Me._alignRightItem.Name = "_alignRightItem"
        Me._alignRightItem.Size = New System.Drawing.Size(180, 22)
        Me._alignRightItem.Text = "Right"
        '
        ' _removeAlignmentItem
        '
        Me._removeAlignmentItem.Name = "_removeAlignmentItem"
        Me._removeAlignmentItem.Size = New System.Drawing.Size(180, 22)
        Me._removeAlignmentItem.Text = "Remove alignment"
        '
        ' _clipboardSeparator
        '
        Me._clipboardSeparator.Name = "_clipboardSeparator"
        Me._clipboardSeparator.Size = New System.Drawing.Size(212, 6)
        '
        ' _cutItem
        '
        Me._cutItem.Name = "_cutItem"
        Me._cutItem.Size = New System.Drawing.Size(215, 22)
        Me._cutItem.Text = "Cut"
        '
        ' _copyItem
        '
        Me._copyItem.Name = "_copyItem"
        Me._copyItem.Size = New System.Drawing.Size(215, 22)
        Me._copyItem.Text = "Copy"
        '
        ' _pasteItem
        '
        Me._pasteItem.Name = "_pasteItem"
        Me._pasteItem.Size = New System.Drawing.Size(215, 22)
        Me._pasteItem.Text = "Paste"
        '
        ' _deleteItem
        '
        Me._deleteItem.Name = "_deleteItem"
        Me._deleteItem.Size = New System.Drawing.Size(215, 22)
        Me._deleteItem.Text = "Delete"
        '
        ' _selectAllSeparator
        '
        Me._selectAllSeparator.Name = "_selectAllSeparator"
        Me._selectAllSeparator.Size = New System.Drawing.Size(212, 6)
        '
        ' _selectAllItem
        '
        Me._selectAllItem.Name = "_selectAllItem"
        Me._selectAllItem.Size = New System.Drawing.Size(215, 22)
        Me._selectAllItem.Text = "Select all"
        '
        ' _editor
        '
        Me._editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me._editor.EditorContextMenuStrip = Me._contextMenu
        Me._editor.Location = New System.Drawing.Point(0, 0)
        Me._editor.Name = "_editor"
        Me._editor.Size = New System.Drawing.Size(1000, 700)
        Me._editor.TabIndex = 0
        Me._editor.ToolbarContextMenuStrip = Nothing
        '
        ' MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me._editor)
        Me.Name = "MainForm"
        Me.Text = "SpiceLogic WinForms HTML editor - custom context menu"
        Me._contextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

#End Region

    Private _contextMenu As System.Windows.Forms.ContextMenuStrip
    Private _imagePropertiesItem As System.Windows.Forms.ToolStripMenuItem
    Private _linkPropertiesItem As System.Windows.Forms.ToolStripMenuItem
    Private _cellPropertiesItem As System.Windows.Forms.ToolStripMenuItem
    Private _tableMenu As System.Windows.Forms.ToolStripMenuItem
    Private _tablePropertiesItem As System.Windows.Forms.ToolStripMenuItem
    Private _insertRowBeforeItem As System.Windows.Forms.ToolStripMenuItem
    Private _insertRowAfterItem As System.Windows.Forms.ToolStripMenuItem
    Private _deleteRowItem As System.Windows.Forms.ToolStripMenuItem
    Private _insertColumnBeforeItem As System.Windows.Forms.ToolStripMenuItem
    Private _insertColumnAfterItem As System.Windows.Forms.ToolStripMenuItem
    Private _deleteColumnItem As System.Windows.Forms.ToolStripMenuItem
    Private _mergeCellsItem As System.Windows.Forms.ToolStripMenuItem
    Private _youTubeItem As System.Windows.Forms.ToolStripMenuItem
    Private _tableSeparator As System.Windows.Forms.ToolStripSeparator
    Private _alignmentMenu As System.Windows.Forms.ToolStripMenuItem
    Private _alignLeftItem As System.Windows.Forms.ToolStripMenuItem
    Private _alignCenterItem As System.Windows.Forms.ToolStripMenuItem
    Private _alignRightItem As System.Windows.Forms.ToolStripMenuItem
    Private _removeAlignmentItem As System.Windows.Forms.ToolStripMenuItem
    Private _clipboardSeparator As System.Windows.Forms.ToolStripSeparator
    Private _cutItem As System.Windows.Forms.ToolStripMenuItem
    Private _copyItem As System.Windows.Forms.ToolStripMenuItem
    Private _pasteItem As System.Windows.Forms.ToolStripMenuItem
    Private _deleteItem As System.Windows.Forms.ToolStripMenuItem
    Private _selectAllSeparator As System.Windows.Forms.ToolStripSeparator
    Private _selectAllItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _editor As WinFormHtmlEditor
End Class
