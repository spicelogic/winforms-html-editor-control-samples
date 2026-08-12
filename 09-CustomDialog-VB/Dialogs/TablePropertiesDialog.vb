Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.Abstractions.Entities
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Class TablePropertiesDialog
    ''' </summary>
    Partial Public Class TablePropertiesDialog
        Inherits DialogBase
        Implements ITableDialog

        ''' <summary>
        ''' The _element
        ''' </summary>
        Private _element As TableElement
        ''' <summary>
        ''' The _table cell dialog
        ''' </summary>
        Private ReadOnly _tableCellDialog As ITableCellDialog
        ''' <summary>
        ''' The _background picture URL
        ''' </summary>
        Private _backgroundPictureUrl As String = String.Empty

        Private ReadOnly _propertiesAffected As List(Of String) =
            New List(Of String) From {
            "Rows",
            "Columns",
            "Width",
            "Height",
            "Caption",
            "BorderWidth",
            "CellPadding",
            "CellSpacing",
            "BorderColor",
            "BorderAttr",
            "BorderStyle",
            "BgColor",
            "BorderCollapse",
            "SummaryDescription",
            "ID",
            "Name",
            "CSSClassName",
            "BackGround"
        }

        ''' <summary>
        ''' Initializes a new instance of the <see cref="TablePropertiesDialog" /> class.
        ''' </summary>
        ''' <param name="cellDialog">The cell dialog.</param>
        Public Sub New(cellDialog As ITableCellDialog)
            InitializeComponent()
            ' Spec 019 FR-009: cmbBorderStyle.SelectedIndex = 0 moved to the
            ' .Designer.vb file -- design-time serialization, no runtime override.
            Me._tableCellDialog = cellDialog
            Me.CancelButton = btnCancel

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Handles the Load event of the TablePropertiesDialog control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub TablePropertiesDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btnCellProperties.Visible = Me.getOrInitCellElement() IsNot Nothing
        End Sub

        ''' <summary>
        ''' Gets or sets the element.
        ''' </summary>
        ''' <value>The element.</value>
        Public Property Element As TableElement Implements ITableDialog.Element
            Get
                If _element Is Nothing Then
                    _element = New TableElement(Nothing)
                End If

                _element.ResetValues(Me._propertiesAffected)

                _element.Rows = CInt(numRows.Value)
                _element.Columns = CInt(numCols.Value)

                If chkCellPadding.Checked Then
                    _element.CellPadding = CInt(numCellPadding.Value)
                End If
                If chkCellSpacing.Checked Then
                    _element.CellSpacing = CInt(numCellSpacing.Value)
                End If

                If chkWidth.Checked AndAlso cmbWidthUnit.SelectedItem IsNot Nothing Then
                    _element.Width = Convert.ToInt32(txtWidth.Text.Trim())
                    _element.WidthUnit = cmbWidthUnit.SelectedItem.ToString()
                End If

                If chkHeight.Checked AndAlso cmbHeightUnit.SelectedItem IsNot Nothing Then
                    _element.Height = Convert.ToInt32(txtHeight.Text.Trim())
                    _element.HeightUnit = cmbHeightUnit.SelectedItem.ToString()
                End If

                If chkCaption.Checked Then
                    _element.Caption = txtCaption.Text.Trim()
                End If

                If chkBorderWidth.Checked Then
                    If chkBorderStyle.Checked AndAlso cmbBorderStyle.SelectedItem IsNot Nothing Then
                        _element.BorderStyle = cmbBorderStyle.SelectedItem.ToString()
                        _element.BorderWidth = CInt(numBorderWidth.Value)
                    Else
                        _element.BorderAttr = CInt(numBorderWidth.Value)
                    End If
                End If

                If chklnkBorderColor.Enabled AndAlso chklnkBorderColor.Checked Then
                    _element.BorderColor = ColorTranslator.ToHtml(txtBorderColor.BackColor)
                End If

                If chklnkBgColor.Checked Then
                    _element.BgColor = ColorTranslator.ToHtml(txtBgColor.BackColor)
                End If

                _element.SummaryDescription = txtSummaryDescription.Text
                _element.BorderCollapse = chkBorderCollapse.Enabled AndAlso chkBorderCollapse.Checked
                _element.Id = txtId.Text.Trim()
                _element.Name = txtName.Text.Trim()
                _element.CssClassName = txtClassName.Text.Trim()
                _element.CssStyle = txtCss.Text.Trim()

                If chklnkBackgroundPicture.Checked Then
                    _element.BackGround = pbBackgroundPicture.ImageLocation
                End If

                _element.BorderToAll = chkBorderToAll.Checked

                Return _element
            End Get
            Set(value As TableElement)
                _element = value
                If _element Is Nothing Then
                    Return
                End If

                ' Spec 019 FR-009: every element→UI assignment is gated on the
                ' element carrying data, so design-time defaults survive otherwise.
                If _element.Rows > 0 Then
                    numRows.Value = _element.Rows
                End If
                If _element.Columns > 0 Then
                    numCols.Value = _element.Columns
                End If

                If _element.Width.HasValue Then
                    chkWidth.Checked = True
                    txtWidth.Text = _element.Width.Value.ToString(CultureInfo.InvariantCulture)
                    If _element.WidthUnit IsNot Nothing Then
                        cmbWidthUnit.SelectedItem = _element.WidthUnit
                    End If
                End If

                If _element.Height.HasValue Then
                    chkHeight.Checked = True
                    txtHeight.Text = _element.Height.Value.ToString(CultureInfo.InvariantCulture)
                    If _element.HeightUnit IsNot Nothing Then
                        cmbHeightUnit.SelectedItem = _element.HeightUnit
                    End If
                End If

                If Not String.IsNullOrEmpty(_element.Caption) Then
                    chkCaption.Checked = True
                    txtCaption.Text = _element.Caption
                End If

                If _element.BorderWidth.HasValue OrElse _element.BorderAttr.HasValue Then
                    chkBorderWidth.Checked = True
                End If

                If Not String.IsNullOrEmpty(_element.BorderStyle) Then
                    chkBorderStyle.Checked = True
                    cmbBorderStyle.Enabled = True
                    chkBorderCollapse.Enabled = True
                    chklnkBorderColor.Enabled = True
                    Me.txtBorderColor.Enabled = Me.chklnkBorderColor.Checked
                    cmbBorderStyle.Text = _element.BorderStyle
                    If chkBorderWidth.Checked Then
                        numBorderWidth.Value = If(_element.BorderWidth, 0)
                    End If
                ElseIf chkBorderWidth.Checked Then
                    numBorderWidth.Value = If(_element.BorderAttr, If(_element.BorderWidth, 0))
                End If

                If _element.CellPadding.HasValue Then
                    chkCellPadding.Checked = True
                    numCellPadding.Value = _element.CellPadding.Value
                End If

                If _element.CellSpacing.HasValue Then
                    chkCellSpacing.Checked = True
                    numCellSpacing.Value = _element.CellSpacing.Value
                End If

                If Not String.IsNullOrEmpty(_element.BorderColor) Then
                    chklnkBorderColor.Checked = True
                    Dim converter As ColorConverter = New ColorConverter()
                    txtBorderColor.BackColor = CType(converter.ConvertFromString(_element.BorderColor), Color)
                End If

                If Not String.IsNullOrEmpty(_element.BgColor) Then
                    chklnkBgColor.Checked = True
                    Dim converter As ColorConverter = New ColorConverter()
                    txtBgColor.BackColor = CType(converter.ConvertFromString(_element.BgColor), Color)
                End If

                If _element.BorderCollapse IsNot Nothing AndAlso _element.BorderCollapse.Value Then
                    chkBorderCollapse.Checked = True
                End If
                ' Spec 019 FR-009: preserve design-time defaults on empty fields.
                If Not String.IsNullOrEmpty(_element.SummaryDescription) Then
                    txtSummaryDescription.Text = _element.SummaryDescription
                End If
                If Not String.IsNullOrEmpty(_element.Id) Then
                    txtId.Text = _element.Id
                End If
                If Not String.IsNullOrEmpty(_element.Name) Then
                    txtName.Text = _element.Name
                End If
                If Not String.IsNullOrEmpty(_element.CssClassName) Then
                    txtClassName.Text = _element.CssClassName
                End If
                '///////////////
                If Not String.IsNullOrEmpty(_element.BackGround) Then
                    chklnkBackgroundPicture.Checked = True
                    pbBackgroundPicture.ImageLocation = _element.BackGround
                    pbBackgroundPicture.Load()
                End If

                Dim cssText As String = _element.GetCssStyleWithoutProperties(Me._propertiesAffected)
                If Not String.IsNullOrEmpty(cssText) Then
                    txtCss.Text = cssText
                End If
                chkBorderToAll.Checked = True
            End Set
        End Property

#Region "------------ UI Event Handlers --------------"

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkWidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkWidth.CheckedChanged
            txtWidth.Enabled = chkWidth.Checked
            cmbWidthUnit.Enabled = chkWidth.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkHeight control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkHeight_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeight.CheckedChanged
            txtHeight.Enabled = chkHeight.Checked
            cmbHeightUnit.Enabled = chkHeight.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkBorderWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkBorderWidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorderWidth.CheckedChanged
            numBorderWidth.Enabled = chkBorderWidth.Checked

            Me.chkBorderStyle.Enabled = Me.chkBorderWidth.Checked

            '            chkBorderStyle.Checked = chkBorderWidth.Checked;
            cmbBorderStyle.Enabled = chkBorderWidth.Checked AndAlso chkBorderStyle.Checked
            If Not chkBorderWidth.Checked Then chkBorderToAll.Checked = True
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkCellPadding control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkCellPadding_CheckedChanged(sender As Object, e As EventArgs) Handles chkCellPadding.CheckedChanged
            numCellPadding.Enabled = chkCellPadding.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkCellSpacing control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkCellSpacing_CheckedChanged(sender As Object, e As EventArgs) Handles chkCellSpacing.CheckedChanged
            numCellSpacing.Enabled = chkCellSpacing.Checked
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the chklnkBorderColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub chklnkBorderColor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chklnkBorderColor.LinkClicked
            Using myDialog As ColorDialog = New ColorDialog() With {
                .AllowFullOpen = True,
                .AnyColor = True,
                .Color = txtBorderColor.BackColor,
                .CustomColors = New Integer() {ColorTranslator.ToOle(txtBorderColor.BackColor)}
            }
                If myDialog.ShowDialog() = DialogResult.OK Then
                    txtBorderColor.BackColor = myDialog.Color
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the chklnkBgColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub chklnkBgColor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chklnkBgColor.LinkClicked
            Using myDialog As ColorDialog = New ColorDialog() With {
                .AllowFullOpen = True,
                .AnyColor = True,
                .Color = txtBgColor.BackColor,
                .CustomColors = New Integer() {ColorTranslator.ToOle(txtBgColor.BackColor)}
            }
                If myDialog.ShowDialog() = DialogResult.OK Then
                    txtBgColor.BackColor = myDialog.Color
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Handles the LinkClicked event of the chklnkBackgroundPicture control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub chklnkBackgroundPicture_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chklnkBackgroundPicture.LinkClicked
            Try
                Using srcUrlDialog As OpenFileDialog = New OpenFileDialog() With {.Title = "Please Select an image file.", .RestoreDirectory = True, .Filter = "Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*", .FilterIndex = 0, .Multiselect = False}
                    If srcUrlDialog.ShowDialog() = DialogResult.OK Then
                        _backgroundPictureUrl = srcUrlDialog.FileName
                        pbBackgroundPicture.Image = Image.FromFile(_backgroundPictureUrl)
                        pbBackgroundPicture.ImageLocation = _backgroundPictureUrl
                    End If
                End Using
            Catch
            End Try
        End Sub

        ''' <summary>
        '''
        ''' </summary>
        ''' <returns></returns>
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Me._tableCellDialog.Element = Nothing
            Return MyBase.ShowDialog()
        End Function

        ''' <summary>
        ''' Handles the Click event of the btnCellProperties control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub btnCellProperties_Click(sender As Object, e As EventArgs) Handles btnCellProperties.Click
            If Me._tableCellDialog Is Nothing Then
                MessageBox.Show(
                    "Table Cell Dialog reference is NULL. Please set a TableCellDialog implementing ITableCellDialog to the editor's Dialog.TableCellDialog property.",
                    "Error")
                Return
            End If

            Dim tblCellElement As TableCellElement = Me.getOrInitCellElement()
            If tblCellElement Is Nothing Then
                MessageBox.Show(
                    "No cells were found.",
                    "Error")
                Return
            End If

            Me._tableCellDialog.Element = tblCellElement
            Using Me._tableCellDialog.LockOverrideSettingsToAllCells()
                If Me._tableCellDialog.ShowDialog() = DialogResult.OK Then
                    Me.Element.CellElement = Me._tableCellDialog.Element
                End If
            End Using
        End Sub

        Private Function getOrInitCellElement() As TableCellElement
            Return Me.Element.GetFirstCellElement()
        End Function

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkCaption control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkCaption_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaption.CheckedChanged
            txtCaption.Enabled = chkCaption.Checked
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the chkBorderStyle control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub chkBorderStyle_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorderStyle.CheckedChanged
            cmbBorderStyle.Enabled = chkBorderStyle.Checked
            chkBorderCollapse.Enabled = chkBorderStyle.Checked
            chklnkBorderColor.Enabled = chkBorderStyle.Checked
            Me.txtBorderColor.Enabled = Me.chkBorderStyle.Checked AndAlso Me.chklnkBorderColor.Checked
            If Not chkBorderStyle.Checked Then chkBorderToAll.Checked = True
        End Sub

        Private Sub numBorderWidth_ValueChanged(sender As Object, e As EventArgs) Handles numBorderWidth.ValueChanged
            If Me.numBorderWidth.Value = 0.0D Then
                Me.chkBorderToAll.Checked = True
            End If
        End Sub

#End Region

        ' IDisposable.Dispose is already satisfied by the WinForms Form base
        ' class (which implements IDisposable), so no bridge is needed here.
        ' (ShowDialog is implemented above as the literal "new" shadow that
        ' also fulfills IDialog.ShowDialog.)
    End Class

End Namespace
