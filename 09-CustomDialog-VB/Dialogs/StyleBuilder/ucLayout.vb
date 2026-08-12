Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucLayout
    ''' </summary>
    <ToolboxItem(False)>
    <FormSelectorPage("Layout", "clip,visibility,display,float,clear,overflow,page-break-before,page-break-after")>
    Partial Public Class ucLayout
        Inherits UserControl
        Implements IEditorStylePage

        ''' <summary>
        ''' The _dict
        ''' </summary>
        Private ReadOnly _dict As Dictionary(Of String, String)

#Region "Preset of possible value"

        ''' <summary>
        ''' The _ visibility
        ''' </summary>
        Private ReadOnly _visibility As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ display
        ''' </summary>
        Private ReadOnly _display As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ float
        ''' </summary>
        Private ReadOnly _float As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ clear
        ''' </summary>
        Private ReadOnly _clear As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ overflow
        ''' </summary>
        Private ReadOnly _overflow As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ page break before
        ''' </summary>
        Private ReadOnly _pageBreakBefore As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ page break after
        ''' </summary>
        Private ReadOnly _pageBreakAfter As List(Of KeyValuePair(Of String, String))
#End Region

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ucLayout"/> class.
        ''' </summary>
        ''' <param name="dict">The dict.</param>
        Public Sub New(dict As Dictionary(Of String, String))
            _dict = dict

#Region "Fill lists"
            _visibility.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _visibility.Add(New KeyValuePair(Of String, String)("Hidden", "hidden"))
            _visibility.Add(New KeyValuePair(Of String, String)("Visible", "visible"))

            _display.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _display.Add(New KeyValuePair(Of String, String)("Do not display", "none"))
            _display.Add(New KeyValuePair(Of String, String)("As a block element", "block"))
            _display.Add(New KeyValuePair(Of String, String)("As an inflow element", "inline"))

            _float.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _float.Add(New KeyValuePair(Of String, String)("Don't allow text on sides", "none"))
            _float.Add(New KeyValuePair(Of String, String)("To the right", "right"))
            _float.Add(New KeyValuePair(Of String, String)("To the left", "left"))

            _clear.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _clear.Add(New KeyValuePair(Of String, String)("On either side", "none"))
            _clear.Add(New KeyValuePair(Of String, String)("Only on right", "right"))
            _clear.Add(New KeyValuePair(Of String, String)("Only on left", "left"))
            _clear.Add(New KeyValuePair(Of String, String)("Do not allow", "both"))

            _overflow.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _overflow.Add(New KeyValuePair(Of String, String)("Use scrollbars if needed", "auto"))
            _overflow.Add(New KeyValuePair(Of String, String)("Always use scrollbars", "scroll"))
            _overflow.Add(New KeyValuePair(Of String, String)("Content is not clipped", "visible"))
            _overflow.Add(New KeyValuePair(Of String, String)("Content is clipped", "hidden"))

            _pageBreakBefore.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _pageBreakBefore.Add(New KeyValuePair(Of String, String)("Auto", "auto"))
            _pageBreakBefore.Add(New KeyValuePair(Of String, String)("Force a page break", "always"))
            _pageBreakBefore.Add(New KeyValuePair(Of String, String)("No page break", "avoid"))
            _pageBreakBefore.Add(New KeyValuePair(Of String, String)("Until a blank left page", "left"))
            _pageBreakBefore.Add(New KeyValuePair(Of String, String)("Until a blank right page", "right"))

            _pageBreakAfter = New List(Of KeyValuePair(Of String, String))(_pageBreakBefore)
#End Region

            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Flushes the content of the user control back to the dictionary
        ''' </summary>
        Public Sub FlushContent() Implements IEditorStylePage.FlushContent
            _dict.Remove("clip")

            _dict("visibility") = CStr(cbVisibility.SelectedValue)
            _dict("display") = CStr(cbDisplay.SelectedValue)
            _dict("float") = CStr(cbAllowFloatingObject.SelectedValue)
            _dict("clear") = CStr(cbAllowTextToFlow.SelectedValue)
            _dict("overflow") = CStr(cbOverflow.SelectedValue)
            _dict("page-break-before") = CStr(cbPbBefore.SelectedValue)
            _dict("page-break-after") = CStr(cbPbAfter.SelectedValue)

            Dim top As String = tbTop.Text.Trim()
            Dim right As String = tbRight.Text.Trim()
            Dim bottom As String = tbBottom.Text.Trim()
            Dim left As String = tbLeft.Text.Trim()

            If top.Length + right.Length + bottom.Length + left.Length > 0 Then
                ' fix values if any
                top = If(top.Length = 0, "auto", top & cbTopType.Text)

                right = If(right.Length = 0, "auto", right & cbRightType.Text)

                bottom = If(bottom.Length = 0, "auto", bottom & cbBottomType.Text)

                left = If(left.Length = 0, "auto", left & cbLeftType.Text)

                ' store to the dictionary
                _dict("clip") = $"rect({top} {right} {bottom} {left})"
            End If
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ucLayout control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub ucLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "set data sources"
            cbVisibility.DataSource = _visibility
            cbVisibility.DisplayMember = "Key"
            cbVisibility.ValueMember = "Value"

            cbDisplay.DataSource = _display
            cbDisplay.DisplayMember = "Key"
            cbDisplay.ValueMember = "Value"

            cbAllowTextToFlow.DataSource = _float
            cbAllowTextToFlow.DisplayMember = "Key"
            cbAllowTextToFlow.ValueMember = "Value"

            cbAllowFloatingObject.DataSource = _clear
            cbAllowFloatingObject.DisplayMember = "Key"
            cbAllowFloatingObject.ValueMember = "Value"

            cbOverflow.DataSource = _overflow
            cbOverflow.DisplayMember = "Key"
            cbOverflow.ValueMember = "Value"

            cbPbBefore.DataSource = _pageBreakBefore
            cbPbBefore.DisplayMember = "Key"
            cbPbBefore.ValueMember = "Value"

            cbPbAfter.DataSource = _pageBreakAfter
            cbPbAfter.DisplayMember = "Key"
            cbPbAfter.ValueMember = "Value"
#End Region

#Region "parse dictionary's values"
            Dim value As String = Nothing
            If _dict.TryGetValue("overflow", value) Then
                Dim n As Integer = _overflow.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _overflow(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbOverflow.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("visibility", value) Then
                Dim n As Integer = _visibility.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _visibility(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbVisibility.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("display", value) Then
                Dim n As Integer = _display.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _display(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbDisplay.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("float", value) Then
                Dim n As Integer = _float.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _float(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbAllowTextToFlow.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("clear", value) Then
                Dim n As Integer = _clear.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _clear(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbAllowFloatingObject.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("page-break-before", value) Then
                Dim n As Integer = _pageBreakBefore.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _pageBreakBefore(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbPbBefore.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("page-break-after", value) Then
                Dim n As Integer = _pageBreakAfter.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _pageBreakAfter(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbPbAfter.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("clip", value) Then
                If value.StartsWith("rect(", StringComparison.InvariantCultureIgnoreCase) AndAlso value.EndsWith(")") Then
                    Dim inner As String = value.Substring(5, value.Length - 6)
                    Dim parts As String() = inner.Split(" "c)
                    If parts.Length >= 4 Then
                        Dim top As String = parts(0)
                        Dim right As String = parts(1)
                        Dim bottom As String = parts(2)
                        Dim left As String = parts(3)

                        Dim n1 As Integer = cbTopType.Items.Count
                        For i As Integer = 0 To n1 - 1
                            If top.EndsWith(CStr(cbTopType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                                tbTop.Text = top.Substring(0, top.Length - CStr(cbTopType.Items(i)).Length)
                                cbTopType.SelectedIndex = i
                                Exit For
                            End If
                        Next

                        Dim n2 As Integer = cbRightType.Items.Count
                        For i As Integer = 0 To n2 - 1
                            If right.EndsWith(CStr(cbRightType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                                tbRight.Text = right.Substring(0, right.Length - CStr(cbRightType.Items(i)).Length)
                                cbRightType.SelectedIndex = i
                                Exit For
                            End If
                        Next

                        Dim n3 As Integer = cbBottomType.Items.Count
                        For i As Integer = 0 To n3 - 1
                            If bottom.EndsWith(CStr(cbBottomType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                                tbBottom.Text = bottom.Substring(0, bottom.Length - CStr(cbBottomType.Items(i)).Length)
                                cbBottomType.SelectedIndex = i
                                Exit For
                            End If
                        Next

                        Dim n4 As Integer = cbLeftType.Items.Count
                        For i As Integer = 0 To n4 - 1
                            If left.EndsWith(CStr(cbLeftType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                                tbLeft.Text = left.Substring(0, left.Length - CStr(cbLeftType.Items(i)).Length)
                                cbLeftType.SelectedIndex = i
                                Exit For
                            End If
                        Next
                    End If
                End If
            End If
#End Region
        End Sub
    End Class

End Namespace
