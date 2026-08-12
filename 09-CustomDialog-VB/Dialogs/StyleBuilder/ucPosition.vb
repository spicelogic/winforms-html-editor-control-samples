Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucPosition
    ''' </summary>
    <ToolboxItem(False)>
    <FormSelectorPage("Position", "position,top,left,width,height,z-index")>
    Partial Public Class ucPosition
        Inherits UserControl
        Implements IEditorStylePage

        ''' <summary>
        ''' The _dict
        ''' </summary>
        Private ReadOnly _dict As Dictionary(Of String, String)

#Region "Preset of possible values"

        ''' <summary>
        ''' The _ position
        ''' </summary>
        Private ReadOnly _position As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
#End Region

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ucPosition"/> class.
        ''' </summary>
        ''' <param name="dict">The dict.</param>
        Public Sub New(dict As Dictionary(Of String, String))
            _dict = dict

#Region "Initialize presets"
            _position.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _position.Add(New KeyValuePair(Of String, String)("Position in normal flow", "static"))
            _position.Add(New KeyValuePair(Of String, String)("Offset from normal flow", "relative"))
            _position.Add(New KeyValuePair(Of String, String)("Absolutely position", "absolute"))
#End Region

            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Flushes the content of the user control back to the dictionary
        ''' </summary>
        Public Sub FlushContent() Implements IEditorStylePage.FlushContent
            _dict.Remove("position")
            _dict.Remove("top")
            _dict.Remove("left")
            _dict.Remove("width")
            _dict.Remove("height")
            _dict.Remove("z-index")

            If cbPositionMode.SelectedIndex >= 2 Then
                If tbLeft.Text.Trim().Length > 0 Then
                    _dict("left") = tbLeft.Text & cbLeftType.Text
                End If
                If tbTop.Text.Trim().Length > 0 Then
                    _dict("top") = tbTop.Text & cbTopType.Text
                End If

                If cbPositionMode.SelectedIndex = 3 Then
                    _dict("z-index") = tbZIndex.Text
                End If
            End If

            If tbHeight.Text.Trim().Length > 0 Then
                _dict("height") = tbHeight.Text & cbHeightType.Text
            End If
            If tbWidth.Text.Trim().Length > 0 Then
                _dict("width") = tbWidth.Text & cbWidthType.Text
            End If

            _dict("position") = CStr(cbPositionMode.SelectedValue)
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ucPosition control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub ucPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "set data sources"
            cbPositionMode.DataSource = _position
            cbPositionMode.DisplayMember = "Key"
            cbPositionMode.ValueMember = "Value"
#End Region

#Region "parse"
            Dim value As String = Nothing
            If _dict.TryGetValue("left", value) Then
                Dim n As Integer = cbLeftType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbLeftType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        tbLeft.Text = value.Substring(0, value.Length - CStr(cbLeftType.Items(i)).Length)
                        cbLeftType.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("top", value) Then
                Dim n As Integer = cbTopType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbTopType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        tbTop.Text = value.Substring(0, value.Length - CStr(cbTopType.Items(i)).Length)
                        cbTopType.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("width", value) Then
                Dim n As Integer = cbWidthType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbWidthType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        tbWidth.Text = value.Substring(0, value.Length - CStr(cbWidthType.Items(i)).Length)
                        cbWidthType.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("height", value) Then
                Dim n As Integer = cbHeightType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbHeightType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        tbHeight.Text = value.Substring(0, value.Length - CStr(cbHeightType.Items(i)).Length)
                        cbHeightType.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("z-index", value) Then
                tbZIndex.Text = value
            End If

            If _dict.TryGetValue("position", value) Then
                Dim n As Integer = _position.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _position(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbPositionMode.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
#End Region
        End Sub

#Region "UI handlers"
        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbPositionMode control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbPositionMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPositionMode.SelectedIndexChanged
            Dim __chainValue As Boolean = cbPositionMode.SelectedIndex >= 2
            cbTopType.Enabled = __chainValue
            tbTop.Enabled = cbTopType.Enabled
            cbLeftType.Enabled = tbTop.Enabled
            tbLeft.Enabled = cbLeftType.Enabled

            tbZIndex.Enabled = cbPositionMode.SelectedIndex = 3
        End Sub
#End Region
    End Class

End Namespace
