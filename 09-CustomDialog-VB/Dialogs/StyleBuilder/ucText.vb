Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucText
    ''' </summary>
    <ToolboxItem(False)>
    <FormSelectorPage("Text", "text-align,vertical-align,text-justify,letter-spacing,line-height,direction,text-indent")>
    Partial Public Class ucText
        Inherits UserControl
        Implements IEditorStylePage

        ''' <summary>
        ''' The _dict
        ''' </summary>
        Private ReadOnly _dict As Dictionary(Of String, String)

#Region "Preset of possible values"

        ''' <summary>
        ''' The _ text align
        ''' </summary>
        Private ReadOnly _textAlign As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ vertical align
        ''' </summary>
        Private ReadOnly _verticalAlign As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ text justify
        ''' </summary>
        Private ReadOnly _textJustify As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ letter spacing
        ''' </summary>
        Private ReadOnly _letterSpacing As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ line height
        ''' </summary>
        Private ReadOnly _lineHeight As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ direction
        ''' </summary>
        Private ReadOnly _direction As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()

#End Region

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ucText"/> class.
        ''' </summary>
        ''' <param name="dict">The dict.</param>
        Public Sub New(dict As Dictionary(Of String, String))
            _dict = dict

#Region "Initialize presets"
            _textAlign.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _textAlign.Add(New KeyValuePair(Of String, String)("Left", "left"))
            _textAlign.Add(New KeyValuePair(Of String, String)("Center", "center"))
            _textAlign.Add(New KeyValuePair(Of String, String)("Right", "right"))
            _textAlign.Add(New KeyValuePair(Of String, String)("Justified", "justify"))

            _verticalAlign.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("baseline", "baseline"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("sub", "sub"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("super", "super"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("top", "top"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("text-top", "text-top"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("middle", "middle"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("bottom", "bottom"))
            _verticalAlign.Add(New KeyValuePair(Of String, String)("text-bottom", "text-bottom"))

            _textJustify.Add(New KeyValuePair(Of String, String)("", ""))
            _textJustify.Add(New KeyValuePair(Of String, String)("Auto", "auto"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Space words", "inter-word"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Newspaper style", "newspaper"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Distribute spacing", "distribute"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Distribute all lines", "dibtribute-all-lines"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Inter-cluster", "inter-cluster"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Inter-ideograph", "inter-ideograph"))
            _textJustify.Add(New KeyValuePair(Of String, String)("Kashida", "kashida"))

            _letterSpacing.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _letterSpacing.Add(New KeyValuePair(Of String, String)("Normal", "normal"))
            _letterSpacing.Add(New KeyValuePair(Of String, String)("Custom", ""))

            _lineHeight.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _lineHeight.Add(New KeyValuePair(Of String, String)("Normal", "normal"))
            _lineHeight.Add(New KeyValuePair(Of String, String)("Custom", ""))

            _direction.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _direction.Add(New KeyValuePair(Of String, String)("Left to right", "ltr"))
            _direction.Add(New KeyValuePair(Of String, String)("Right to left", "rtl"))
#End Region

            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Flushes the content of the user control back to the dictionary
        ''' </summary>
        Public Sub FlushContent() Implements IEditorStylePage.FlushContent
            ' remove previous entries
            _dict.Remove("text-align")
            _dict.Remove("vertical-align")
            _dict.Remove("text-justify")

            _dict.Remove("letter-spacing")
            _dict.Remove("line-height")

            _dict.Remove("direction")
            _dict.Remove("text-indent")

            ' save form's data
            _dict("text-align") = CStr(cbAlHorizontal.SelectedValue)
            If cbAlHorizontal.SelectedIndex = 4 Then
                _dict("text-justify") = CStr(cbAlJustification.SelectedValue)
            End If
            _dict("vertical-align") = CStr(cbAlVertical.SelectedValue)

            _dict("letter-spacing") = If(cbSpacingLetters.SelectedIndex <> 2,
                CStr(cbSpacingLetters.SelectedValue),
                tbSpacingLetters.Text & cbSpacingLettersCustom.Text)

            _dict("line-height") = If(cbSpacingLines.SelectedIndex <> 2,
                CStr(cbSpacingLines.SelectedValue),
                tbSpacingLines.Text & cbSpacingLinesCustom.Text)

            If tbTextFlowIndentation.Text.Trim().Length > 0 Then
                _dict("text-indent") = tbTextFlowIndentation.Text & cbTextFlowCustom.Text
            End If

            _dict("direction") = CStr(cbTextFlowDirection.SelectedValue)
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ucText control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub ucText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "set data sources"
            cbAlHorizontal.DataSource = _textAlign
            cbAlHorizontal.DisplayMember = "Key"
            cbAlHorizontal.ValueMember = "Value"

            cbAlVertical.DataSource = _verticalAlign
            cbAlVertical.DisplayMember = "Key"
            cbAlVertical.ValueMember = "Value"

            cbAlJustification.DataSource = _textJustify
            cbAlJustification.DisplayMember = "Key"
            cbAlJustification.ValueMember = "Value"

            cbSpacingLetters.DataSource = _letterSpacing
            cbSpacingLetters.DisplayMember = "Key"
            cbSpacingLetters.ValueMember = "Value"

            cbSpacingLines.DataSource = _lineHeight
            cbSpacingLines.DisplayMember = "Key"
            cbSpacingLines.ValueMember = "Value"

            cbTextFlowDirection.DataSource = _direction
            cbTextFlowDirection.DisplayMember = "Key"
            cbTextFlowDirection.ValueMember = "Value"
#End Region

#Region "parse alignment"
            Dim value As String = Nothing
            If _dict.TryGetValue("vertical-align", value) Then
                Dim n As Integer = _verticalAlign.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _verticalAlign(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbAlVertical.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("text-justify", value) Then
                Dim n As Integer = _textJustify.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _textJustify(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbAlJustification.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("text-align", value) Then
                Dim n As Integer = _textAlign.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _textAlign(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbAlHorizontal.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
#End Region

#Region "parse spacing"
            If _dict.TryGetValue("letter-spacing", value) Then
                Dim handled As Boolean = False

                Dim n1 As Integer = _letterSpacing.Count
                Dim i1 As Integer = 0
                While i1 < n1 AndAlso Not handled
                    If value.Equals(_letterSpacing(i1).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbSpacingLetters.SelectedIndex = i1
                        handled = True
                    End If
                    i1 += 1
                End While

                If Not handled Then
                    Dim n2 As Integer = cbSpacingLettersCustom.Items.Count
                    For i As Integer = 0 To n2 - 1
                        If value.EndsWith(CStr(cbSpacingLettersCustom.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                            tbSpacingLetters.Text = value.Substring(0, value.Length - CStr(cbSpacingLettersCustom.Items(i)).Length)
                            cbSpacingLettersCustom.SelectedIndex = i
                            cbSpacingLetters.SelectedIndex = 2
                            Exit For
                        End If
                    Next
                End If
            End If

            If _dict.TryGetValue("line-height", value) Then
                Dim handled As Boolean = False

                Dim n1 As Integer = _lineHeight.Count
                Dim i1 As Integer = 0
                While i1 < n1 AndAlso Not handled
                    If value.Equals(_lineHeight(i1).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbSpacingLines.SelectedIndex = i1
                        handled = True
                    End If
                    i1 += 1
                End While

                If Not handled Then
                    Dim n2 As Integer = cbSpacingLinesCustom.Items.Count
                    For i As Integer = 0 To n2 - 1
                        If value.EndsWith(CStr(cbSpacingLinesCustom.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                            tbSpacingLines.Text = value.Substring(0, value.Length - CStr(cbSpacingLinesCustom.Items(i)).Length)
                            cbSpacingLinesCustom.SelectedIndex = i
                            cbSpacingLines.SelectedIndex = 2
                            Exit For
                        End If
                    Next
                End If
            End If
#End Region

#Region "parse text flow"
            If _dict.TryGetValue("text-indent", value) Then
                Dim n As Integer = cbTextFlowCustom.Items.Count
                For i As Integer = 0 To n - 1
                    If value.EndsWith(CStr(cbTextFlowCustom.Items(i)), StringComparison.InvariantCultureIgnoreCase) Then
                        tbTextFlowIndentation.Text = value.Substring(0, value.Length - CStr(cbTextFlowCustom.Items(i)).Length)
                        cbTextFlowCustom.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("direction", value) Then
                Dim n As Integer = _direction.Count
                For i As Integer = 0 To n - 1
                    If value.Equals(_direction(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbTextFlowDirection.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
#End Region
        End Sub

#Region "UI handling"
        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbAlHorizontal control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbAlHorizontal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAlHorizontal.SelectedIndexChanged
            cbAlJustification.Enabled = cbAlHorizontal.SelectedIndex = 4
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbSpacingLetters control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbSpacingLetters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSpacingLetters.SelectedIndexChanged
            Dim __chainValue As Boolean = cbSpacingLetters.SelectedIndex = 2
            cbSpacingLettersCustom.Enabled = __chainValue
            tbSpacingLetters.Enabled = cbSpacingLettersCustom.Enabled
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbSpacingLines control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbSpacingLines_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSpacingLines.SelectedIndexChanged
            Dim __chainValue As Boolean = cbSpacingLines.SelectedIndex = 2
            cbSpacingLinesCustom.Enabled = __chainValue
            tbSpacingLines.Enabled = cbSpacingLinesCustom.Enabled
        End Sub
#End Region
    End Class

End Namespace
