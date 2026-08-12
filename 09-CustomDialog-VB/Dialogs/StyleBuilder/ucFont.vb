Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucFont
    ''' </summary>
    <ToolboxItem(False)>
    <FormSelectorPage("Font", "font;font-family;font-size;text-decoration;font-weight;text-transform;color;font-style;font-variant")>
    Partial Public Class ucFont
        Inherits UserControl
        Implements IEditorStylePage

        ''' <summary>
        ''' The _dict
        ''' </summary>
        Private ReadOnly _dict As Dictionary(Of String, String)

#Region "Preset of possible value"

        ''' <summary>
        ''' The _ system fonts
        ''' </summary>
        Private ReadOnly _SystemFonts As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ font style
        ''' </summary>
        Private ReadOnly _FontStyle As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ font variant
        ''' </summary>
        Private ReadOnly _FontVariant As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ bold absolute
        ''' </summary>
        Private ReadOnly _BoldAbsolute As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ bold relative
        ''' </summary>
        Private ReadOnly _BoldRelative As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ text transform
        ''' </summary>
        Private ReadOnly _TextTransform As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
#End Region

        ''' <summary>
        ''' Creates the lists.
        ''' </summary>
        Protected Sub CreateLists()
#Region "Initialize presets"
            _SystemFonts.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _SystemFonts.Add(New KeyValuePair(Of String, String)("Window caption", "caption"))
            _SystemFonts.Add(New KeyValuePair(Of String, String)("ToolWindow caption", "small-caption"))
            _SystemFonts.Add(New KeyValuePair(Of String, String)("Dialog text", "message-box"))
            _SystemFonts.Add(New KeyValuePair(Of String, String)("Icon labels", "icon"))
            _SystemFonts.Add(New KeyValuePair(Of String, String)("Menu text", "menu"))
            _SystemFonts.Add(New KeyValuePair(Of String, String)("Tooltip text", "status-bar"))

            _FontStyle.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _FontStyle.Add(New KeyValuePair(Of String, String)("Normal", "normal"))
            _FontStyle.Add(New KeyValuePair(Of String, String)("Italic", "italic"))

            _FontVariant.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _FontVariant.Add(New KeyValuePair(Of String, String)("Normal", "normal"))
            _FontVariant.Add(New KeyValuePair(Of String, String)("Small Caps", "small-caps"))

            _BoldAbsolute.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _BoldAbsolute.Add(New KeyValuePair(Of String, String)("Normal", "normal"))
            _BoldAbsolute.Add(New KeyValuePair(Of String, String)("Bold", "bold"))

            _BoldRelative.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _BoldRelative.Add(New KeyValuePair(Of String, String)("Lighter", "lighter"))
            _BoldRelative.Add(New KeyValuePair(Of String, String)("Bolder", "bolder"))

            _TextTransform.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _TextTransform.Add(New KeyValuePair(Of String, String)("None", "none"))
            _TextTransform.Add(New KeyValuePair(Of String, String)("Initial Cap", "capitalize"))
            _TextTransform.Add(New KeyValuePair(Of String, String)("lowercase", "lowercase"))
            _TextTransform.Add(New KeyValuePair(Of String, String)("UPPERCASE", "uppercase"))
#End Region
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ucFont"/> class.
        ''' </summary>
        ''' <param name="dict">The dict.</param>
        Public Sub New(dict As Dictionary(Of String, String))
            _dict = dict
            CreateLists()
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Flushes the content of the user control back to the dictionary
        ''' </summary>
        Public Sub FlushContent() Implements IEditorStylePage.FlushContent
            _dict.Remove("font-family")
            _dict.Remove("font")
            _dict.Remove("color")
            _dict.Remove("font-style")
            _dict.Remove("font-variant")
            _dict.Remove("font-weight")
            _dict.Remove("font-size")
            _dict.Remove("text-decoration")

            Dim sb As StringBuilder = New StringBuilder()
            If cbEffectNone.Checked Then
                sb.Append(" none")
            End If
            If cbEffectUnderline.Checked Then
                sb.Append(" underline")
            End If
            If cbEffectStrikethrough.Checked Then
                sb.Append(" line-through")
            End If
            If cbEffectOverline.Checked Then
                sb.Append(" overline")
            End If
            _dict("text-decoration") = sb.ToString()

            _dict("text-transform") = CStr(cbCapitalization.SelectedValue)

            If rbFamily.Checked Then
                _dict("font-family") = tbFontFamily.Text

                _dict("color") = ColorTranslator.ToHtml(txtForeColor.BackColor) ' cbColor.Text.ToLowerInvariant();
                _dict("font-style") = CStr(cbFontStyle.SelectedValue)
                _dict("font-variant") = CStr(cbFontVariant.SelectedValue)

                ' font-size
                If rbSizeSpecific.Checked Then
                    If tbSpecificSize.Text.Trim().Length > 0 Then
                        _dict("font-size") = tbSpecificSize.Text & cbSpecificSizeType.Text
                    End If
                ElseIf rbSizeAbsolute.Checked Then
                    _dict("font-size") = cbAbsoluteSize.Text.ToLowerInvariant()
                Else
                    _dict("font-size") = cbRelativeSize.Text.ToLowerInvariant()
                End If

                ' font-weight
                If rbBoldAbsolute.Checked Then
                    _dict("font-weight") = CStr(cbBoldAbsolute.SelectedValue)
                Else
                    _dict("font-weight") = CStr(cbBoldRelative.SelectedValue)
                End If
            End If

            If rbSystemFont.Checked Then
                _dict("font") = CStr(cbSystemFont.SelectedValue)
            End If
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ucFont control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub ucFont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "set data sources"
            cbSystemFont.DataSource = _SystemFonts
            cbSystemFont.DisplayMember = "Key"
            cbSystemFont.ValueMember = "Value"

            cbFontStyle.DataSource = _FontStyle
            cbFontStyle.DisplayMember = "Key"
            cbFontStyle.ValueMember = "Value"

            cbFontVariant.DataSource = _FontVariant
            cbFontVariant.DisplayMember = "Key"
            cbFontVariant.ValueMember = "Value"

            cbBoldAbsolute.DataSource = _BoldAbsolute
            cbBoldAbsolute.DisplayMember = "Key"
            cbBoldAbsolute.ValueMember = "Value"

            cbBoldRelative.DataSource = _BoldRelative
            cbBoldRelative.DisplayMember = "Key"
            cbBoldRelative.ValueMember = "Value"

            cbCapitalization.DataSource = _TextTransform
            cbCapitalization.DisplayMember = "Key"
            cbCapitalization.ValueMember = "Value"
#End Region

            ' Spec 019 FR-009: all radio-group defaults (rbFamily,
            ' rbSizeSpecific, rbBoldAbsolute) are serialized in the
            ' .Designer.vb file. No runtime seeding -- a host customizer who
            ' picks a different default in the designer is honored.

#Region "parse"

            Dim value As String = Nothing
            If _dict.TryGetValue("color", value) Then
                Try
                    Dim theRegex As Match = Regex.Match(value, "rgb\(([\d]+),([\d]+),([\d]+)\)", RegexOptions.IgnoreCase Or RegexOptions.Multiline)

                    If theRegex.Success Then
                        Dim rValue As Integer = Integer.Parse(theRegex.Groups(1).Value)
                        Dim gValue As Integer = Integer.Parse(theRegex.Groups(2).Value)
                        Dim bValue As Integer = Integer.Parse(theRegex.Groups(3).Value)

                        txtForeColor.BackColor = Color.FromArgb(rValue, gValue, bValue)
                    Else
                        txtForeColor.BackColor = ColorTranslator.FromHtml(value)
                    End If
                Catch __ex As ArgumentException
                    ' Syntax error in the regular expression
                End Try
            End If

            If _dict.TryGetValue("font-style", value) Then
                Dim n As Integer = _FontStyle.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _FontStyle(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbFontStyle.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("font-size", value) Then
                Dim handled As Boolean = False

                Dim n1 As Integer = cbAbsoluteSize.Items.Count
                Dim i1 As Integer = 0
                While i1 < n1 AndAlso Not handled
                    If String.Equals(value, TryCast(cbAbsoluteSize.Items(i1), String), StringComparison.InvariantCultureIgnoreCase) Then
                        cbAbsoluteSize.SelectedIndex = i1
                        rbSizeAbsolute.Checked = True
                        handled = True
                    End If
                    i1 += 1
                End While

                Dim n2 As Integer = cbRelativeSize.Items.Count
                Dim i2 As Integer = 0
                While i2 < n2 AndAlso Not handled
                    If String.Equals(value, TryCast(cbRelativeSize.Items(i2), String), StringComparison.InvariantCultureIgnoreCase) Then
                        cbRelativeSize.SelectedIndex = i2
                        rbSizeRelative.Checked = True
                        handled = True
                    End If
                    i2 += 1
                End While

                If Not handled Then
                    rbSizeSpecific.Checked = True
                    Dim n3 As Integer = cbSpecificSizeType.Items.Count
                    Dim i3 As Integer = 0
                    While i3 < n3 AndAlso Not handled
                        Dim cbSpecificSizeTypeItem As String = TryCast(cbSpecificSizeType.Items(i3), String)
                        If Not String.IsNullOrEmpty(cbSpecificSizeTypeItem) AndAlso value.EndsWith(cbSpecificSizeTypeItem, StringComparison.InvariantCultureIgnoreCase) Then
                            cbSpecificSizeType.SelectedIndex = i3
                            tbSpecificSize.Text = value.Substring(0, value.Length - CStr(cbSpecificSizeType.Items(i3)).Length)
                            handled = True
                        End If
                        i3 += 1
                    End While
                End If
            End If

            If _dict.TryGetValue("font-weight", value) Then
                Dim handled As Boolean = False

                Dim n1 As Integer = _BoldAbsolute.Count
                Dim i1 As Integer = 0
                While i1 < n1 AndAlso Not handled
                    If String.Equals(value, _BoldAbsolute(i1).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbBoldAbsolute.SelectedIndex = i1
                        rbBoldAbsolute.Checked = True
                        handled = True
                    End If
                    i1 += 1
                End While

                Dim n2 As Integer = _BoldRelative.Count
                Dim i2 As Integer = 0
                While i2 < n2 AndAlso Not handled
                    If String.Equals(value, _BoldRelative(i2).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbBoldRelative.SelectedIndex = i2
                        rbBoldRelative.Checked = True
                        handled = True
                    End If
                    i2 += 1
                End While
            End If

            If _dict.TryGetValue("text-decoration", value) Then
                Dim loValue As String = value.ToLowerInvariant()
                cbEffectUnderline.Checked = loValue.Contains("underline")
                cbEffectStrikethrough.Checked = loValue.Contains("line-through") OrElse loValue.Contains("linethrough")
                cbEffectOverline.Checked = loValue.Contains("overline")
                cbEffectNone.Checked = loValue.Contains("none")
            End If

            If _dict.TryGetValue("text-transform", value) Then
                Dim n As Integer = _TextTransform.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(value, _TextTransform(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbCapitalization.SelectedIndex = i
                    End If
                Next
            End If

            If _dict.TryGetValue("font-family", value) Then
                rbFamily.Checked = True
                tbFontFamily.Text = value
            End If

            If _dict.TryGetValue("font", value) Then
                rbSystemFont.Checked = True

                Dim n As Integer = _SystemFonts.Count
                For i As Integer = 0 To n - 1
                    If String.Equals(If(value, "").Replace("-", "").Trim(), _SystemFonts(i).Value.Replace("-", ""), StringComparison.InvariantCultureIgnoreCase) Then
                        cbSystemFont.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
#End Region
        End Sub

#Region "UI handlers"
        ''' <summary>
        ''' Handles the Click event of the btFontFamilySelect control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btFontFamilySelect_Click(sender As Object, e As EventArgs) Handles btFontFamilySelect.Click
            Using subForm As frmFontPicker = New frmFontPicker(tbFontFamily.Text)
                If subForm.ShowDialog() = DialogResult.OK Then
                    tbFontFamily.Text = subForm.SelectedFontList
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Fonts the type changed.
        ''' </summary>
        ''' <param name="sender">The sender.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub FontTypeChanged(sender As Object, e As EventArgs) Handles rbSystemFont.CheckedChanged, rbFamily.CheckedChanged
            btFontFamilySelect.Enabled = rbFamily.Checked
            tbFontFamily.Enabled = btFontFamilySelect.Enabled
            cbSystemFont.Enabled = Not rbFamily.Checked

            gbBold.Enabled = rbFamily.Checked
            gbSize.Enabled = gbBold.Enabled
            cbFontVariant.Enabled = gbSize.Enabled
            cbFontStyle.Enabled = cbFontVariant.Enabled
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the rbSizeSpecific control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub rbSizeSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles rbSizeSpecific.CheckedChanged
            cbSpecificSizeType.Enabled = True
            tbSpecificSize.Enabled = cbSpecificSizeType.Enabled
            cbAbsoluteSize.Enabled = False
            cbRelativeSize.Enabled = cbAbsoluteSize.Enabled
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the rbSizeAbsolute control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub rbSizeAbsolute_CheckedChanged(sender As Object, e As EventArgs) Handles rbSizeAbsolute.CheckedChanged
            cbAbsoluteSize.Enabled = True
            cbRelativeSize.Enabled = False
            cbSpecificSizeType.Enabled = cbRelativeSize.Enabled
            tbSpecificSize.Enabled = cbSpecificSizeType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the rbSizeRelative control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub rbSizeRelative_CheckedChanged(sender As Object, e As EventArgs) Handles rbSizeRelative.CheckedChanged
            cbRelativeSize.Enabled = True
            cbAbsoluteSize.Enabled = False
            cbSpecificSizeType.Enabled = cbAbsoluteSize.Enabled
            tbSpecificSize.Enabled = cbSpecificSizeType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the cbEffectNone control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbEffectNone_CheckedChanged(sender As Object, e As EventArgs) Handles cbEffectNone.CheckedChanged
            If cbEffectNone.Checked Then
                cbEffectUnderline.Checked = False
                cbEffectStrikethrough.Checked = cbEffectUnderline.Checked
                cbEffectOverline.Checked = cbEffectStrikethrough.Checked
                cbEffectUnderline.Enabled = False
                cbEffectStrikethrough.Enabled = cbEffectUnderline.Enabled
                cbEffectOverline.Enabled = cbEffectStrikethrough.Enabled
            Else
                cbEffectUnderline.Enabled = True
                cbEffectStrikethrough.Enabled = cbEffectUnderline.Enabled
                cbEffectOverline.Enabled = cbEffectStrikethrough.Enabled
            End If
        End Sub

        ''' <summary>
        ''' Rbs the bold radio button changed.
        ''' </summary>
        ''' <param name="sender">The sender.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub rbBoldRadioButtonChanged(sender As Object, e As EventArgs) Handles rbBoldRelative.CheckedChanged, rbBoldAbsolute.CheckedChanged
            cbBoldAbsolute.Enabled = rbBoldAbsolute.Checked
            cbBoldRelative.Enabled = rbBoldRelative.Checked
        End Sub
#End Region

        ''' <summary>
        ''' Handles the Click event of the txtForeColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub txtForeColor_Click(sender As Object, e As EventArgs) Handles txtForeColor.Click
            If dlgColorPicker.ShowDialog() = DialogResult.OK Then
                txtForeColor.BackColor = dlgColorPicker.Color
            End If
        End Sub
    End Class

End Namespace
