Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucEdges
    ''' </summary>
    <ToolboxItem(False)>
    <FormSelectorPage("Edges", "margin-top,margin-bottom,margin-left,margin-right,padding-top,padding-bottom,padding-left,padding-right,border-top-style,border-bottom-style,border-left-style,border-right-style")>
    Partial Public Class ucEdges
        Inherits UserControl
        Implements IEditorStylePage

        ''' <summary>
        ''' The _dict
        ''' </summary>
        Private ReadOnly _dict As Dictionary(Of String, String)

#Region "Preset of possible value"

        ''' <summary>
        ''' The _ border top style
        ''' </summary>
        Private ReadOnly _borderTopStyle As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ border bottom style
        ''' </summary>
        Private ReadOnly _borderBottomStyle As List(Of KeyValuePair(Of String, String))
        ''' <summary>
        ''' The _ border left style
        ''' </summary>
        Private ReadOnly _borderLeftStyle As List(Of KeyValuePair(Of String, String))
        ''' <summary>
        ''' The _ border right style
        ''' </summary>
        Private ReadOnly _borderRightStyle As List(Of KeyValuePair(Of String, String))
#End Region

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ucEdges"/> class.
        ''' </summary>
        ''' <param name="dict">The dict.</param>
        Public Sub New(dict As Dictionary(Of String, String))
            _dict = dict

#Region "Initialize presets"
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("None", "none"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Dotted", "dotted"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Dashed", "dashed"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Solid line", "solid"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Double line", "double"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Groove", "groove"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Ridge", "ridge"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Inset", "inset"))
            _borderTopStyle.Add(New KeyValuePair(Of String, String)("Outset", "outset"))

            _borderBottomStyle = New List(Of KeyValuePair(Of String, String))(_borderTopStyle)
            _borderLeftStyle = New List(Of KeyValuePair(Of String, String))(_borderTopStyle)
            _borderRightStyle = New List(Of KeyValuePair(Of String, String))(_borderTopStyle)
#End Region

            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Flushes the content of the user control back to the dictionary
        ''' </summary>
        Public Sub FlushContent() Implements IEditorStylePage.FlushContent
            _dict.Remove("margin-top")
            _dict.Remove("margin-bottom")
            _dict.Remove("margin-left")
            _dict.Remove("margin-right")
            _dict.Remove("padding-top")
            _dict.Remove("padding-bottom")
            _dict.Remove("padding-left")
            _dict.Remove("padding-right")

            _dict.Remove("border-top-style")
            _dict.Remove("border-bottom-style")
            _dict.Remove("border-left-style")
            _dict.Remove("border-right-style")

            If tbMTop.Text.Trim().Length > 0 Then
                _dict("margin-top") = String.Concat(tbMTop.Text, cbMTopType.Text)
            End If
            If tbMBottom.Text.Trim().Length > 0 Then
                _dict("margin-bottom") = String.Concat(tbMBottom.Text, cbMBottomType.Text)
            End If
            If tbMLeft.Text.Trim().Length > 0 Then
                _dict("margin-left") = String.Concat(tbMLeft.Text, cbMLeftType.Text)
            End If
            If tbMRight.Text.Trim().Length > 0 Then
                _dict("margin-right") = String.Concat(tbMRight.Text, cbMRightType.Text)
            End If

            If tbPTop.Text.Trim().Length > 0 Then
                _dict("padding-top") = String.Concat(tbPTop.Text, cbPTopType.Text)
            End If
            If tbPBottom.Text.Trim().Length > 0 Then
                _dict("padding-bottom") = String.Concat(tbPBottom.Text, cbPBottomType.Text)
            End If
            If tbPLeft.Text.Trim().Length > 0 Then
                _dict("padding-left") = String.Concat(tbPLeft.Text, cbPLeftType.Text)
            End If
            If tbPRight.Text.Trim().Length > 0 Then
                _dict("padding-right") = String.Concat(tbPRight.Text, cbPRightType.Text)
            End If

            Dim sbLeft As StringBuilder = New StringBuilder()
            If cbLeftStyle.SelectedIndex > 0 Then
                sbLeft.Append(CStr(cbLeftStyle.SelectedValue))
                sbLeft.Append(" "c)

                If cbLeftWidth.SelectedIndex > 0 Then
                    If cbLeftWidth.SelectedIndex = 4 Then
                        If tbLeftWidth.Text.Trim().Length > 0 Then
                            sbLeft.Append(String.Concat(tbLeftWidth.Text.Trim(), cbLeftWidthType.Text))
                            sbLeft.Append(" "c)
                        End If
                    Else
                        sbLeft.Append(cbLeftWidth.Text.ToLowerInvariant())
                        sbLeft.Append(" "c)
                    End If
                End If

                sbLeft.Append(cbLeftColor.Text.ToLowerInvariant())
            End If
            _dict("border-left-style") = sbLeft.ToString()

            Dim sbRight As StringBuilder = New StringBuilder()
            If cbRightStyle.SelectedIndex > 0 Then
                sbRight.Append(CStr(cbRightStyle.SelectedValue))
                sbRight.Append(" "c)

                If cbRightWidth.SelectedIndex > 0 Then
                    If cbRightWidth.SelectedIndex = 4 Then
                        If tbRightWidth.Text.Trim().Length > 0 Then
                            sbRight.Append(String.Concat(tbRightWidth.Text.Trim(), cbRightWidthType.Text))
                            sbRight.Append(" "c)
                        End If
                    Else
                        sbRight.Append(cbRightWidth.Text.ToLowerInvariant())
                        sbRight.Append(" "c)
                    End If
                End If

                sbRight.Append(cbRightColor.Text.ToLowerInvariant())
            End If
            _dict("border-right-style") = sbRight.ToString()

            Dim sbTop As StringBuilder = New StringBuilder()
            If cbTopStyle.SelectedIndex > 0 Then
                sbTop.Append(CStr(cbTopStyle.SelectedValue))
                sbTop.Append(" "c)

                If cbTopWidth.SelectedIndex > 0 Then
                    If cbTopWidth.SelectedIndex = 4 Then
                        If tbTopWidth.Text.Trim().Length > 0 Then
                            sbTop.Append(String.Concat(tbTopWidth.Text.Trim(), cbTopWidthType.Text))
                            sbTop.Append(" "c)
                        End If
                    Else
                        sbTop.Append(cbTopWidth.Text.ToLowerInvariant())
                        sbTop.Append(" "c)
                    End If
                End If

                sbTop.Append(cbTopColor.Text.ToLowerInvariant())
            End If
            _dict("border-top-style") = sbTop.ToString()

            Dim sbBottom As StringBuilder = New StringBuilder()
            If cbBottomStyle.SelectedIndex > 0 Then
                sbBottom.Append(CStr(cbBottomStyle.SelectedValue))
                sbBottom.Append(" "c)

                If cbBottomWidth.SelectedIndex > 0 Then
                    If cbBottomWidth.SelectedIndex = 4 Then
                        If tbBottomWidth.Text.Trim().Length > 0 Then
                            sbBottom.Append(String.Concat(tbBottomWidth.Text.Trim(), cbBottomWidthType.Text))
                            sbBottom.Append(" "c)
                        End If
                    Else
                        sbBottom.Append(cbBottomWidth.Text.ToLowerInvariant())
                        sbBottom.Append(" "c)
                    End If
                End If

                sbBottom.Append(cbBottomColor.Text.ToLowerInvariant())
            End If
            _dict("border-bottom-style") = sbBottom.ToString()
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ucEdges control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub ucEdges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "set data sources"
            cbLeftStyle.DataSource = _borderLeftStyle
            cbLeftStyle.DisplayMember = "Key"
            cbLeftStyle.ValueMember = "Value"

            cbRightStyle.DataSource = _borderRightStyle
            cbRightStyle.DisplayMember = "Key"
            cbRightStyle.ValueMember = "Value"

            cbTopStyle.DataSource = _borderTopStyle
            cbTopStyle.DisplayMember = "Key"
            cbTopStyle.ValueMember = "Value"

            cbBottomStyle.DataSource = _borderBottomStyle
            cbBottomStyle.DisplayMember = "Key"
            cbBottomStyle.ValueMember = "Value"

            cbLeftWidth.SelectedIndex = 0
            cbRightWidth.SelectedIndex = 0
            cbTopWidth.SelectedIndex = 0
            cbBottomWidth.SelectedIndex = 0
#End Region

            Dim value As String = Nothing
#Region "parse margins"
            If _dict.TryGetValue("margin-top", value) Then
                Dim n As Integer = cbMTopType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbMTopType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbMTopType.SelectedIndex = i
                        tbMTop.Text = value.Substring(0, value.Length - CStr(cbMTopType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
            If _dict.TryGetValue("margin-bottom", value) Then
                Dim n As Integer = cbMBottomType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbMBottomType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbMBottomType.SelectedIndex = i
                        tbMBottom.Text = value.Substring(0, value.Length - CStr(cbMBottomType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
            If _dict.TryGetValue("margin-left", value) Then
                Dim n As Integer = cbMLeftType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbMLeftType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbMLeftType.SelectedIndex = i
                        tbMLeft.Text = value.Substring(0, value.Length - CStr(cbMLeftType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
            If _dict.TryGetValue("margin-right", value) Then
                Dim n As Integer = cbMRightType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbMRightType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbMRightType.SelectedIndex = i
                        tbMRight.Text = value.Substring(0, value.Length - CStr(cbMRightType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
#End Region

#Region "parse padding"
            If _dict.TryGetValue("padding-top", value) Then
                Dim n As Integer = cbPTopType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbPTopType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbPTopType.SelectedIndex = i
                        tbPTop.Text = value.Substring(0, value.Length - CStr(cbPTopType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
            If _dict.TryGetValue("padding-bottom", value) Then
                Dim n As Integer = cbPBottomType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbPBottomType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbPBottomType.SelectedIndex = i
                        tbPBottom.Text = value.Substring(0, value.Length - CStr(cbPBottomType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
            If _dict.TryGetValue("padding-left", value) Then
                Dim n As Integer = cbPLeftType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbPLeftType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbPLeftType.SelectedIndex = i
                        tbPLeft.Text = value.Substring(0, value.Length - CStr(cbPLeftType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
            If _dict.TryGetValue("padding-right", value) Then
                Dim n As Integer = cbPRightType.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbPRightType.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        cbPRightType.SelectedIndex = i
                        tbPRight.Text = value.Substring(0, value.Length - CStr(cbPRightType.Items(i)).Length)
                        Exit For
                    End If
                Next
            End If
#End Region

#Region "parse left border"
            If _dict.TryGetValue("border-left-style", value) Then
                Dim values As List(Of String) = New List(Of String)(value.Split(" "c))
                ' Filter empty
                Dim i As Integer = 0
                While i < values.Count
                    If values(i).Trim().Length = 0 Then
                        values.RemoveAt(i)
                        i -= 1
                    End If
                    i += 1
                End While

                Dim styleFound As Boolean = False

                Dim valI As Integer = 0
                While valI < values.Count AndAlso Not styleFound
                    value = values(valI)
                    Dim n As Integer = _borderLeftStyle.Count
                    Dim k As Integer = 0
                    While k < n AndAlso Not styleFound
                        If String.Equals(value, _borderLeftStyle(k).Value, StringComparison.InvariantCultureIgnoreCase) Then
                            cbLeftStyle.SelectedIndex = k
                            values.RemoveAt(valI)
                            styleFound = True
                        End If
                        k += 1
                    End While
                    valI += 1
                End While

                If styleFound AndAlso cbLeftStyle.SelectedIndex >= 2 Then
                    Dim widthFound As Boolean = False

                    Dim vi As Integer = 0
                    While vi < values.Count AndAlso Not widthFound
                        value = values(vi)
                        Dim ii As Integer = 1
                        While ii < 4 AndAlso Not widthFound
                            If String.Equals(value, CStr(cbLeftWidth.Items(ii)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbLeftWidth.SelectedIndex = ii
                                values.RemoveAt(vi)
                                widthFound = True
                            End If
                            ii += 1
                        End While
                        vi += 1
                    End While

                    If Not widthFound Then
                        Dim vj As Integer = 0
                        While vj < values.Count AndAlso Not widthFound
                            value = values(vj)
                            Dim n As Integer = cbLeftWidthType.Items.Count
                            Dim ij As Integer = 0
                            While ij < n AndAlso Not widthFound
                                If value.EndsWith(CStr(cbLeftWidthType.Items(ij)), StringComparison.InvariantCultureIgnoreCase) Then
                                    cbLeftWidth.SelectedIndex = 4
                                    cbLeftWidthType.SelectedIndex = ij
                                    tbLeftWidth.Text = value.Substring(0, value.Length - CStr(cbLeftWidthType.Items(ij)).Length)
                                    values.RemoveAt(vj)
                                    widthFound = True
                                End If
                                ij += 1
                            End While
                            vj += 1
                        End While
                    End If

                    Dim colorFound As Boolean = False

                    Dim vk As Integer = 0
                    While vk < values.Count AndAlso Not colorFound
                        value = values(vk)
                        Dim n As Integer = cbLeftColor.Items.Count
                        Dim ik As Integer = 0
                        While ik < n AndAlso Not colorFound
                            If String.Equals(value, CStr(cbLeftColor.Items(ik)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbLeftColor.SelectedIndex = ik
                                values.RemoveAt(vk)
                                colorFound = True
                            End If
                            ik += 1
                        End While
                        vk += 1
                    End While

                    If Not colorFound Then
                        Dim vl As Integer = 0
                        While vl < values.Count AndAlso Not colorFound
                            value = values(vl)
                            If value.StartsWith("#") Then
                                cbLeftColor.Text = value
                                values.RemoveAt(vl)
                                colorFound = True
                            End If
                            vl += 1
                        End While
                    End If
                End If
            End If
#End Region

#Region "parse Right border"
            If _dict.TryGetValue("border-right-style", value) Then
                Dim values As List(Of String) = New List(Of String)(value.Split(" "c))
                ' Filter empty
                Dim i As Integer = 0
                While i < values.Count
                    If values(i).Trim().Length = 0 Then
                        values.RemoveAt(i)
                        i -= 1
                    End If
                    i += 1
                End While

                Dim styleFound As Boolean = False

                Dim valI As Integer = 0
                While valI < values.Count AndAlso Not styleFound
                    value = values(valI)
                    Dim n As Integer = _borderRightStyle.Count
                    Dim k As Integer = 0
                    While k < n AndAlso Not styleFound
                        If String.Equals(value, _borderRightStyle(k).Value, StringComparison.InvariantCultureIgnoreCase) Then
                            cbRightStyle.SelectedIndex = k
                            values.RemoveAt(valI)
                            styleFound = True
                        End If
                        k += 1
                    End While
                    valI += 1
                End While

                If styleFound AndAlso cbRightStyle.SelectedIndex >= 2 Then
                    Dim widthFound As Boolean = False

                    Dim vi As Integer = 0
                    While vi < values.Count AndAlso Not widthFound
                        value = values(vi)
                        Dim ii As Integer = 1
                        While ii < 4 AndAlso Not widthFound
                            If String.Equals(value, CStr(cbRightWidth.Items(ii)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbRightWidth.SelectedIndex = ii
                                values.RemoveAt(vi)
                                widthFound = True
                            End If
                            ii += 1
                        End While
                        vi += 1
                    End While

                    If Not widthFound Then
                        Dim vj As Integer = 0
                        While vj < values.Count AndAlso Not widthFound
                            value = values(vj)
                            Dim n As Integer = cbRightWidthType.Items.Count
                            Dim ij As Integer = 0
                            While ij < n AndAlso Not widthFound
                                If value.EndsWith(CStr(cbRightWidthType.Items(ij)), StringComparison.InvariantCultureIgnoreCase) Then
                                    cbRightWidth.SelectedIndex = 4
                                    cbRightWidthType.SelectedIndex = ij
                                    tbRightWidth.Text = value.Substring(0, value.Length - CStr(cbRightWidthType.Items(ij)).Length)
                                    values.RemoveAt(vj)
                                    widthFound = True
                                End If
                                ij += 1
                            End While
                            vj += 1
                        End While
                    End If

                    Dim colorFound As Boolean = False

                    Dim vk As Integer = 0
                    While vk < values.Count AndAlso Not colorFound
                        value = values(vk)
                        Dim n As Integer = cbRightColor.Items.Count
                        Dim ik As Integer = 0
                        While ik < n AndAlso Not colorFound
                            If String.Equals(value, CStr(cbRightColor.Items(ik)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbRightColor.SelectedIndex = ik
                                values.RemoveAt(vk)
                                colorFound = True
                            End If
                            ik += 1
                        End While
                        vk += 1
                    End While

                    If Not colorFound Then
                        Dim vl As Integer = 0
                        While vl < values.Count AndAlso Not colorFound
                            value = values(vl)
                            If value.StartsWith("#") Then
                                cbRightColor.Text = value
                                values.RemoveAt(vl)
                                colorFound = True
                            End If
                            vl += 1
                        End While
                    End If
                End If
            End If
#End Region

#Region "parse Top border"
            If _dict.TryGetValue("border-top-style", value) Then
                Dim values As List(Of String) = New List(Of String)(value.Split(" "c))
                ' Filter empty
                Dim i As Integer = 0
                While i < values.Count
                    If values(i).Trim().Length = 0 Then
                        values.RemoveAt(i)
                        i -= 1
                    End If
                    i += 1
                End While

                Dim styleFound As Boolean = False

                Dim valI As Integer = 0
                While valI < values.Count AndAlso Not styleFound
                    value = values(valI)
                    Dim n As Integer = _borderTopStyle.Count
                    Dim k As Integer = 0
                    While k < n AndAlso Not styleFound
                        If String.Equals(value, _borderTopStyle(k).Value, StringComparison.InvariantCultureIgnoreCase) Then
                            cbTopStyle.SelectedIndex = k
                            values.RemoveAt(valI)
                            styleFound = True
                        End If
                        k += 1
                    End While
                    valI += 1
                End While

                If styleFound AndAlso cbTopStyle.SelectedIndex >= 2 Then
                    Dim widthFound As Boolean = False

                    Dim vi As Integer = 0
                    While vi < values.Count AndAlso Not widthFound
                        value = values(vi)
                        Dim ii As Integer = 1
                        While ii < 4 AndAlso Not widthFound
                            If String.Equals(value, CStr(cbTopWidth.Items(ii)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbTopWidth.SelectedIndex = ii
                                values.RemoveAt(vi)
                                widthFound = True
                            End If
                            ii += 1
                        End While
                        vi += 1
                    End While

                    If Not widthFound Then
                        Dim vj As Integer = 0
                        While vj < values.Count AndAlso Not widthFound
                            value = values(vj)
                            Dim n As Integer = cbTopWidthType.Items.Count
                            Dim ij As Integer = 0
                            While ij < n AndAlso Not widthFound
                                If value.EndsWith(CStr(cbTopWidthType.Items(ij)), StringComparison.InvariantCultureIgnoreCase) Then
                                    cbTopWidth.SelectedIndex = 4
                                    cbTopWidthType.SelectedIndex = ij
                                    tbTopWidth.Text = value.Substring(0, value.Length - CStr(cbTopWidthType.Items(ij)).Length)
                                    values.RemoveAt(vj)
                                    widthFound = True
                                End If
                                ij += 1
                            End While
                            vj += 1
                        End While
                    End If

                    Dim colorFound As Boolean = False

                    Dim vk As Integer = 0
                    While vk < values.Count AndAlso Not colorFound
                        value = values(vk)
                        Dim n As Integer = cbTopColor.Items.Count
                        Dim ik As Integer = 0
                        While ik < n AndAlso Not colorFound
                            If String.Equals(value, CStr(cbTopColor.Items(ik)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbTopColor.SelectedIndex = ik
                                values.RemoveAt(vk)
                                colorFound = True
                            End If
                            ik += 1
                        End While
                        vk += 1
                    End While

                    If Not colorFound Then
                        Dim vl As Integer = 0
                        While vl < values.Count AndAlso Not colorFound
                            value = values(vl)
                            If value.StartsWith("#") Then
                                cbTopColor.Text = value
                                values.RemoveAt(vl)
                                colorFound = True
                            End If
                            vl += 1
                        End While
                    End If
                End If
            End If
#End Region

#Region "parse Bottom border"
            If _dict.TryGetValue("border-bottom-style", value) Then
                Dim values As List(Of String) = New List(Of String)(value.Split(" "c))
                ' Filter empty
                Dim i As Integer = 0
                While i < values.Count
                    If values(i).Trim().Length = 0 Then
                        values.RemoveAt(i)
                        i -= 1
                    End If
                    i += 1
                End While

                Dim styleFound As Boolean = False

                Dim valI As Integer = 0
                While valI < values.Count AndAlso Not styleFound
                    value = values(valI)
                    Dim n As Integer = _borderBottomStyle.Count
                    Dim k As Integer = 0
                    While k < n AndAlso Not styleFound
                        If String.Equals(value, _borderBottomStyle(k).Value, StringComparison.InvariantCultureIgnoreCase) Then
                            cbBottomStyle.SelectedIndex = k
                            values.RemoveAt(valI)
                            styleFound = True
                        End If
                        k += 1
                    End While
                    valI += 1
                End While

                If styleFound AndAlso cbBottomStyle.SelectedIndex >= 2 Then
                    Dim widthFound As Boolean = False

                    Dim vi As Integer = 0
                    While vi < values.Count AndAlso Not widthFound
                        value = values(vi)
                        Dim ii As Integer = 1
                        While ii < 4 AndAlso Not widthFound
                            If String.Equals(value, CStr(cbBottomWidth.Items(ii)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbBottomWidth.SelectedIndex = ii
                                values.RemoveAt(vi)
                                widthFound = True
                            End If
                            ii += 1
                        End While
                        vi += 1
                    End While

                    If Not widthFound Then
                        Dim vj As Integer = 0
                        While vj < values.Count AndAlso Not widthFound
                            value = values(vj)
                            Dim n As Integer = cbBottomWidthType.Items.Count
                            Dim ij As Integer = 0
                            While ij < n AndAlso Not widthFound
                                If value.EndsWith(CStr(cbBottomWidthType.Items(ij)), StringComparison.InvariantCultureIgnoreCase) Then
                                    cbBottomWidth.SelectedIndex = 4
                                    cbBottomWidthType.SelectedIndex = ij
                                    tbBottomWidth.Text = value.Substring(0, value.Length - CStr(cbBottomWidthType.Items(ij)).Length)
                                    values.RemoveAt(vj)
                                    widthFound = True
                                End If
                                ij += 1
                            End While
                            vj += 1
                        End While
                    End If

                    Dim colorFound As Boolean = False

                    Dim vk As Integer = 0
                    While vk < values.Count AndAlso Not colorFound
                        value = values(vk)
                        Dim n As Integer = cbBottomColor.Items.Count
                        Dim ik As Integer = 0
                        While ik < n AndAlso Not colorFound
                            If String.Equals(value, CStr(cbBottomColor.Items(ik)), StringComparison.InvariantCultureIgnoreCase) Then
                                cbBottomColor.SelectedIndex = ik
                                values.RemoveAt(vk)
                                colorFound = True
                            End If
                            ik += 1
                        End While
                        vk += 1
                    End While

                    If Not colorFound Then
                        Dim vl As Integer = 0
                        While vl < values.Count AndAlso Not colorFound
                            value = values(vl)
                            If value.StartsWith("#") Then
                                cbBottomColor.Text = value
                                values.RemoveAt(vl)
                                colorFound = True
                            End If
                            vl += 1
                        End While
                    End If
                End If
            End If
#End Region
        End Sub

#Region "left border edge handlers"
        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbLeftWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbLeftWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLeftWidth.SelectedIndexChanged
            Dim __chainValue As Boolean = cbLeftWidth.SelectedIndex = 4
            cbLeftWidthType.Enabled = __chainValue
            tbLeftWidth.Enabled = cbLeftWidthType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btLeftColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btLeftColor_Click(sender As Object, e As EventArgs) Handles btLeftColor.Click
            If dlgColor.ShowDialog() = DialogResult.OK Then
                cbLeftColor.Text = $"#{(dlgColor.Color.ToArgb() And &HFFFFF).ToString("X6")}"
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbLeftStyle control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbLeftStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLeftStyle.SelectedIndexChanged
            If cbLeftStyle.SelectedIndex >= 2 Then
                btLeftColor.Enabled = True
                cbLeftColor.Enabled = btLeftColor.Enabled
                cbLeftWidthType.Enabled = cbLeftColor.Enabled
                tbLeftWidth.Enabled = cbLeftWidthType.Enabled
                cbLeftWidth.Enabled = tbLeftWidth.Enabled
                cbLeftWidth_SelectedIndexChanged(Me, EventArgs.Empty)
            Else
                btLeftColor.Enabled = False
                cbLeftColor.Enabled = btLeftColor.Enabled
                cbLeftWidthType.Enabled = cbLeftColor.Enabled
                tbLeftWidth.Enabled = cbLeftWidthType.Enabled
                cbLeftWidth.Enabled = tbLeftWidth.Enabled
            End If
        End Sub
#End Region

#Region "Right border edge handlers"
        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbRightWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbRightWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRightWidth.SelectedIndexChanged
            Dim __chainValue As Boolean = cbRightWidth.SelectedIndex = 4
            cbRightWidthType.Enabled = __chainValue
            tbRightWidth.Enabled = cbRightWidthType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btRightColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btRightColor_Click(sender As Object, e As EventArgs) Handles btRightColor.Click
            If dlgColor.ShowDialog() = DialogResult.OK Then
                cbRightColor.Text = $"#{(dlgColor.Color.ToArgb() And &HFFFFF).ToString("X6")}"
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbRightStyle control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbRightStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRightStyle.SelectedIndexChanged
            If cbRightStyle.SelectedIndex >= 2 Then
                btRightColor.Enabled = True
                cbRightColor.Enabled = btRightColor.Enabled
                cbRightWidthType.Enabled = cbRightColor.Enabled
                tbRightWidth.Enabled = cbRightWidthType.Enabled
                cbRightWidth.Enabled = tbRightWidth.Enabled
                cbRightWidth_SelectedIndexChanged(Me, EventArgs.Empty)
            Else
                btRightColor.Enabled = False
                cbRightColor.Enabled = btRightColor.Enabled
                cbRightWidthType.Enabled = cbRightColor.Enabled
                tbRightWidth.Enabled = cbRightWidthType.Enabled
                cbRightWidth.Enabled = tbRightWidth.Enabled
            End If
        End Sub
#End Region

#Region "Top border edge handlers"
        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbTopWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbTopWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTopWidth.SelectedIndexChanged
            Dim __chainValue As Boolean = cbTopWidth.SelectedIndex = 4
            cbTopWidthType.Enabled = __chainValue
            tbTopWidth.Enabled = cbTopWidthType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btTopColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btTopColor_Click(sender As Object, e As EventArgs) Handles btTopColor.Click
            If dlgColor.ShowDialog() = DialogResult.OK Then
                cbTopColor.Text = $"#{(dlgColor.Color.ToArgb() And &HFFFFF).ToString("X6")}"
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbTopStyle control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbTopStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTopStyle.SelectedIndexChanged
            If cbTopStyle.SelectedIndex >= 2 Then
                btTopColor.Enabled = True
                cbTopColor.Enabled = btTopColor.Enabled
                cbTopWidthType.Enabled = cbTopColor.Enabled
                tbTopWidth.Enabled = cbTopWidthType.Enabled
                cbTopWidth.Enabled = tbTopWidth.Enabled
                cbTopWidth_SelectedIndexChanged(Me, EventArgs.Empty)
            Else
                btTopColor.Enabled = False
                cbTopColor.Enabled = btTopColor.Enabled
                cbTopWidthType.Enabled = cbTopColor.Enabled
                tbTopWidth.Enabled = cbTopWidthType.Enabled
                cbTopWidth.Enabled = tbTopWidth.Enabled
            End If
        End Sub
#End Region

#Region "Bottom border edge handlers"
        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbBottomWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbBottomWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBottomWidth.SelectedIndexChanged
            Dim __chainValue As Boolean = cbBottomWidth.SelectedIndex = 4
            cbBottomWidthType.Enabled = __chainValue
            tbBottomWidth.Enabled = cbBottomWidthType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btBottomColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btBottomColor_Click(sender As Object, e As EventArgs) Handles btBottomColor.Click
            If dlgColor.ShowDialog() = DialogResult.OK Then
                cbBottomColor.Text = $"#{(dlgColor.Color.ToArgb() And &HFFFFF).ToString("X6")}"
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbBottomStyle control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbBottomStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBottomStyle.SelectedIndexChanged
            If cbBottomStyle.SelectedIndex >= 2 Then
                btBottomColor.Enabled = True
                cbBottomColor.Enabled = btBottomColor.Enabled
                cbBottomWidthType.Enabled = cbBottomColor.Enabled
                tbBottomWidth.Enabled = cbBottomWidthType.Enabled
                cbBottomWidth.Enabled = tbBottomWidth.Enabled
                cbBottomWidth_SelectedIndexChanged(Me, EventArgs.Empty)
            Else
                btBottomColor.Enabled = False
                cbBottomColor.Enabled = btBottomColor.Enabled
                cbBottomWidthType.Enabled = cbBottomColor.Enabled
                tbBottomWidth.Enabled = cbBottomWidthType.Enabled
                cbBottomWidth.Enabled = tbBottomWidth.Enabled
            End If
        End Sub
#End Region
    End Class

End Namespace
