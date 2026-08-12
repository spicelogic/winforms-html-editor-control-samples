Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.Abstractions.Entities
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Class TableCellPropertiesDialog
    ''' </summary>
    Partial Public Class TableCellPropertiesDialog
        Inherits DialogBase
        Implements ITableCellDialog

        ''' <summary>
        ''' The _element
        ''' </summary>
        Private _element As TableCellElement

        Private ReadOnly _propertiesAffected As List(Of String) =
            New List(Of String) From {
            "BgColor",
            "CSSClassName",
            "Width",
            "WidthUnit",
            "Height",
            "HeightUnit",
            "HorizontalAlign",
            "VerticalAlign",
            "NoWrap"
        }

        ''' <summary>
        ''' Initializes a new instance of the <see cref="TableCellPropertiesDialog" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            Me.CancelButton = btnCancel

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Gets or sets the element.
        ''' </summary>
        ''' <value>The element.</value>
        Public Property Element As TableCellElement Implements ITableCellDialog.Element
            Get
                _element.ResetStyles(Me._propertiesAffected)

                '                _element.BgColor = chkBgColor.Checked ? ColorTranslator.ToHtml(txtBgColor.BackColor) : null;
                _element.BgColor = If(chklnkBgColor.Checked, ColorTranslator.ToHtml(txtBgColor.BackColor), Nothing)
                _element.CssClassName = txtClassName.Text.Trim()
                _element.CssStyle = txtCss.Text.Trim()

                If chkWidth.Checked AndAlso cmbWidthUnit.SelectedItem IsNot Nothing Then
                    _element.Width = Convert.ToInt32(txtWidth.Text.Trim())
                    _element.WidthUnit = cmbWidthUnit.SelectedItem.ToString()
                End If

                If chkHeight.Checked AndAlso cmbHeightUnit.SelectedItem IsNot Nothing Then
                    _element.Height = Convert.ToInt32(txtHeight.Text.Trim())
                    _element.HeightUnit = cmbHeightUnit.SelectedItem.ToString()
                End If

                If cmbHorizontalAlign.SelectedItem IsNot Nothing Then
                    _element.HorizontalAlign = cmbHorizontalAlign.SelectedItem.ToString()
                End If

                If cmbVerticalAlign.SelectedItem IsNot Nothing Then
                    _element.VerticalAlign = cmbVerticalAlign.SelectedItem.ToString()
                End If
                _element.NoWrap = chkNoWrap.Checked
                _element.OverrideSettingsToAllCells = chkOverrideSettings4Cells.Checked
                Return _element
            End Get
            Set(value As TableCellElement)
                _element = value

                If _element Is Nothing Then
                    Return
                End If

                chklnkBgColor.Checked = Not String.IsNullOrEmpty(_element.BgColor)
                If chklnkBgColor.Checked Then
                    Dim converter As ColorConverter = New ColorConverter()
                    Dim convertFromString As Object = converter.ConvertFromString(_element.BgColor)
                    If convertFromString IsNot Nothing Then
                        txtBgColor.BackColor = CType(convertFromString, Color)
                    End If
                End If

                ' Spec 019 FR-009: preserve design-time defaults on empty fields.
                If Not String.IsNullOrEmpty(_element.CssClassName) Then
                    txtClassName.Text = _element.CssClassName
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

                If _element.HorizontalAlign IsNot Nothing Then
                    cmbHorizontalAlign.SelectedItem = _element.HorizontalAlign
                End If

                If _element.VerticalAlign IsNot Nothing Then
                    cmbVerticalAlign.SelectedItem = _element.VerticalAlign
                End If
                If _element.NoWrap Then
                    chkNoWrap.Checked = True
                End If
                If _element.OverrideSettingsToAllCells Then
                    chkOverrideSettings4Cells.Checked = True
                End If

                Dim cssText As String = _element.GetCssStyleWithoutProperties(Me._propertiesAffected)
                If Not String.IsNullOrEmpty(cssText) Then
                    txtCss.Text = cssText
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets the cell attribute collection.
        ''' </summary>
        ''' <value>The cell attribute collection.</value>
        Public ReadOnly Property CellAttributeCollection As NameValueCollection
            Get
                Dim myColl As NameValueCollection = New NameValueCollection()

                If chkWidth.Checked Then
                    myColl.Add("width", String.Concat(txtWidth.Text.Trim(), cmbWidthUnit.Text.Trim()))
                End If

                If chkHeight.Checked Then
                    myColl.Add("height", String.Concat(txtHeight.Text.Trim(), cmbHeightUnit.Text.Trim()))
                End If

                If chklnkBgColor.Checked Then
                    myColl.Add("bgcolor", ColorTranslator.ToHtml(txtBgColor.BackColor))
                End If

                If cmbHorizontalAlign.SelectedIndex <> 0 Then
                    myColl.Add("align", cmbHorizontalAlign.Text)
                End If

                If cmbVerticalAlign.SelectedIndex <> 0 Then
                    myColl.Add("valign", cmbVerticalAlign.Text)
                End If

                If chkNoWrap.Checked Then
                    myColl.Add("nowrap", "nowrap")
                End If

                Return myColl
            End Get
        End Property

        ''' <summary>
        ''' Gets the table cell attribute string.
        ''' </summary>
        ''' <value>The table cell attribute string.</value>
        Public ReadOnly Property TableCellAttributeString As String
            Get
                Dim tableCellAttributes As String() = New String() {}
                Dim tableCellStyleAttributes As String() = New String() {}

                If chkWidth.Checked Then
                    Array.Resize(tableCellStyleAttributes, tableCellStyleAttributes.Length + 1)
                    tableCellStyleAttributes(tableCellStyleAttributes.Length - 1) =
                        $"width: {txtWidth.Text.Trim()}{cmbWidthUnit.Text.Trim()}"
                End If

                If chkHeight.Checked Then
                    Array.Resize(tableCellStyleAttributes, tableCellStyleAttributes.Length + 1)
                    tableCellStyleAttributes(tableCellStyleAttributes.Length - 1) =
                        $"height: {txtHeight.Text.Trim()}{cmbHeightUnit.Text.Trim()}"
                End If

                If chklnkBgColor.Checked Then
                    Array.Resize(tableCellStyleAttributes, tableCellStyleAttributes.Length + 1)
                    tableCellStyleAttributes(tableCellStyleAttributes.Length - 1) =
                        $"background-color: {ColorTranslator.ToHtml(txtBgColor.BackColor)}"
                End If

                If tableCellStyleAttributes.Length <> 0 Then
                    Dim tableCellStyleText As String = $"style = ""{String.Join("; ", tableCellStyleAttributes)}"""
                    Array.Resize(tableCellAttributes, tableCellAttributes.Length + 1)
                    tableCellAttributes(tableCellAttributes.Length - 1) = tableCellStyleText
                End If

                If cmbHorizontalAlign.SelectedIndex <> 0 Then
                    Array.Resize(tableCellAttributes, tableCellAttributes.Length + 1)
                    tableCellAttributes(tableCellAttributes.Length - 1) = $"align=""{cmbHorizontalAlign.Text}"""
                End If

                If cmbVerticalAlign.SelectedIndex <> 0 Then
                    Array.Resize(tableCellAttributes, tableCellAttributes.Length + 1)
                    tableCellAttributes(tableCellAttributes.Length - 1) = $"valign=""{cmbVerticalAlign.Text}"""
                End If

                If chkNoWrap.Checked Then
                    Array.Resize(tableCellAttributes, tableCellAttributes.Length + 1)
                    tableCellAttributes(tableCellAttributes.Length - 1) = "nowrap=""nowrap"""
                End If

                If Not String.IsNullOrEmpty(txtClassName.Text.Trim()) Then
                    Array.Resize(tableCellAttributes, tableCellAttributes.Length + 1)
                    tableCellAttributes(tableCellAttributes.Length - 1) = "class=""" & txtClassName.Text.Trim() & """"
                End If

                Return String.Join(" ", tableCellAttributes)
            End Get
        End Property

        ''' <summary>
        ''' Get a lock for a property [override cell attributes].
        ''' </summary>
        Public Function LockOverrideSettingsToAllCells() As IDisposable Implements ITableCellDialog.LockOverrideSettingsToAllCells
            Return New lockOverrideSettingsToAllCellsClass(Me)
        End Function

        ''' <summary>
        ''' Gets a value indicating whether [override cell attributes].
        ''' </summary>
        ''' <value><c>true</c> if [override cell attributes]; otherwise, <c>false</c>.</value>
        Public ReadOnly Property OverrideCellAttributes As Boolean
            Get
                Return chkOverrideSettings4Cells.Checked
            End Get
        End Property

#Region "--------------- UI Event Handlers ------------------"

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

#End Region

        Private Class lockOverrideSettingsToAllCellsClass
            Implements IDisposable

            Private ReadOnly _dialog As TableCellPropertiesDialog
            Private ReadOnly _initallyEnabled As Boolean

            Public Sub New(dialog As TableCellPropertiesDialog)
                _dialog = dialog
                _initallyEnabled = _dialog.chkOverrideSettings4Cells.Enabled
                _dialog.chkOverrideSettings4Cells.Enabled = False
            End Sub

            Public Sub Dispose() Implements IDisposable.Dispose
                _dialog.chkOverrideSettings4Cells.Enabled = _initallyEnabled
            End Sub
        End Class

        ''' <summary>
        ''' Handles the LinkClicked event of the chklnkBgColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
        Private Sub chklnkBgColor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chklnkBgColor.LinkClicked
            showDialogForChoosingColor()
        End Sub

        Private Sub showDialogForChoosingColor()
            Using myDialog As ColorDialog = New ColorDialog() With {
                .AllowFullOpen = True,
                .AnyColor = True,
                .Color = Me.txtBgColor.BackColor,
                .CustomColors = New Integer() {ColorTranslator.ToOle(Me.txtBgColor.BackColor)}
            }
                If myDialog.ShowDialog() = DialogResult.OK Then
                    Me.txtBgColor.BackColor = myDialog.Color
                End If
            End Using
        End Sub

        Private Sub TableCellPropertiesDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        ' VB.NET requires an explicit Implements clause for IDialog.ShowDialog
        ' even though the WinForms Form base class already supplies a matching
        ' ShowDialog. (IDisposable.Dispose is already satisfied by Form, which
        ' implements IDisposable, so no bridge is needed for it.) C# satisfies
        ' both implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
