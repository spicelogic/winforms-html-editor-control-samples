Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Class ucBackground
    ''' </summary>
    <ToolboxItem(False)>
    <FormSelectorPage("Background", "background-color,background-image,background-repeat,background-attachment,background-position-x,background-position-y")>
    Partial Public Class ucBackground
        Inherits UserControl
        Implements IEditorStylePage

#Region "Preset of possible values"

        ''' <summary>
        ''' The _ bg repeat
        ''' </summary>
        Private ReadOnly _bgRepeat As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ bg attachment
        ''' </summary>
        Private ReadOnly _bgAttachment As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ bg position X
        ''' </summary>
        Private ReadOnly _bgPositionX As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
        ''' <summary>
        ''' The _ bg position Y
        ''' </summary>
        Private ReadOnly _bgPositionY As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
#End Region

        ''' <summary>
        ''' The _dict
        ''' </summary>
        Private ReadOnly _dict As Dictionary(Of String, String)

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ucBackground"/> class.
        ''' </summary>
        ''' <param name="dict">The dict.</param>
        Public Sub New(dict As Dictionary(Of String, String))
#Region "Initialize presets"
            _bgRepeat.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _bgRepeat.Add(New KeyValuePair(Of String, String)("Tile in horizontal direction", "repeat-x"))
            _bgRepeat.Add(New KeyValuePair(Of String, String)("Tile in vertical direction", "repeat-y"))
            _bgRepeat.Add(New KeyValuePair(Of String, String)("Tile in both directions", "repeat"))
            _bgRepeat.Add(New KeyValuePair(Of String, String)("Do not tile", "no-repeat"))

            _bgAttachment.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _bgAttachment.Add(New KeyValuePair(Of String, String)("Scrolling background", "scroll"))
            _bgAttachment.Add(New KeyValuePair(Of String, String)("Fixed background", "fixed"))

            _bgPositionX.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _bgPositionX.Add(New KeyValuePair(Of String, String)("Left", "left"))
            _bgPositionX.Add(New KeyValuePair(Of String, String)("Center", "center"))
            _bgPositionX.Add(New KeyValuePair(Of String, String)("Right", "right"))
            _bgPositionX.Add(New KeyValuePair(Of String, String)("Custom", ""))

            _bgPositionY.Add(New KeyValuePair(Of String, String)("<Not Set>", ""))
            _bgPositionY.Add(New KeyValuePair(Of String, String)("Top", "top"))
            _bgPositionY.Add(New KeyValuePair(Of String, String)("Center", "center"))
            _bgPositionY.Add(New KeyValuePair(Of String, String)("Bottom", "bottom"))
            _bgPositionY.Add(New KeyValuePair(Of String, String)("Custom", ""))
#End Region

            _dict = dict
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Handles the Load event of the ucBackground control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub ucBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cbTiling.DataSource = _bgRepeat
            cbTiling.DisplayMember = "Key"
            cbTiling.ValueMember = "Value"

            cbScrolling.DataSource = _bgAttachment
            cbScrolling.DisplayMember = "Key"
            cbScrolling.ValueMember = "Value"

            cbHorizontal.DataSource = _bgPositionX
            cbHorizontal.DisplayMember = "Key"
            cbHorizontal.ValueMember = "Value"

            cbVertical.DataSource = _bgPositionY
            cbVertical.DisplayMember = "Key"
            cbVertical.ValueMember = "Value"

            Dim value As String = Nothing
            If _dict.TryGetValue("background-color", value) Then
                If If(value, "").Trim().Equals("transparent", StringComparison.InvariantCultureIgnoreCase) Then
                    cbBgColorTransparent.Checked = True
                Else
                    txtBgColor.BackColor = ColorTranslator.FromHtml(value)
                    cbBgColorTransparent.Checked = False
                End If
            End If

            If _dict.TryGetValue("background-repeat", value) Then
                Dim val As String = value.Trim().ToLowerInvariant()
                For i As Integer = 0 To _bgRepeat.Count - 1
                    If String.Equals(val, _bgRepeat(i).Value) Then
                        cbTiling.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("background-attachment", value) Then
                Dim val As String = value.Trim().ToLowerInvariant()
                For i As Integer = 0 To _bgAttachment.Count - 1
                    If String.Equals(val, _bgAttachment(i).Value) Then
                        cbScrolling.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If _dict.TryGetValue("background-position-x", value) Then
                Dim handled As Boolean = False

                Dim i As Integer = 0
                While i < _bgPositionX.Count AndAlso Not handled
                    If String.Equals(value, _bgPositionX(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbHorizontal.SelectedIndex = i
                        handled = True
                    End If
                    i += 1
                End While

                If Not handled Then
                    For j As Integer = 0 To cbHorCustType.Items.Count - 1
                        If value.EndsWith(CStr(cbHorCustType.Items(j)), StringComparison.InvariantCultureIgnoreCase) Then
                            cbHorizontal.SelectedIndex = 4 ' Custom
                            cbHorCustType.SelectedIndex = j
                            tbHorCust.Text = value.Substring(0, value.Length - CStr(cbHorCustType.Items(j)).Length)
                            Exit For
                        End If
                    Next
                End If
            End If

            If _dict.TryGetValue("background-position-y", value) Then
                Dim handled As Boolean = False

                Dim i As Integer = 0
                While i < _bgPositionY.Count AndAlso Not handled
                    If String.Equals(value, _bgPositionY(i).Value, StringComparison.InvariantCultureIgnoreCase) Then
                        cbVertical.SelectedIndex = i
                        handled = True
                    End If
                    i += 1
                End While

                If Not handled Then
                    For j As Integer = 0 To cbVerCustType.Items.Count - 1
                        If value.EndsWith(CStr(cbVerCustType.Items(j)), StringComparison.InvariantCultureIgnoreCase) Then
                            cbVertical.SelectedIndex = 4 ' Custom
                            cbVerCustType.SelectedIndex = j
                            tbVerCust.Text = value.Substring(0, value.Length - CStr(cbVerCustType.Items(j)).Length)
                            Exit For
                        End If
                    Next
                End If
            End If

            If _dict.TryGetValue("background-image", value) Then
                If If(value, "").Trim().Equals("none", StringComparison.InvariantCultureIgnoreCase) Then
                    cbDoNotUseBackground.Checked = True
                Else
                    cbDoNotUseBackground.Checked = False
                    Try
                        tbBgImage.Text = Regex.Match(value, "url\((.+?)\)", RegexOptions.IgnoreCase).Groups(1).Value
                    Catch
                        tbBgImage.Text = value
                    End Try
                End If
            Else
                tbBgImage_TextChanged(Me, EventArgs.Empty)
            End If
        End Sub

#Region "UI handling"
        ''' <summary>
        ''' Handles the CheckedChanged event of the cbBgColorTransparent control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbBgColorTransparent_CheckedChanged(sender As Object, e As EventArgs) Handles cbBgColorTransparent.CheckedChanged
            txtBgColor.Enabled = Not cbBgColorTransparent.Checked
        End Sub

        ''' <summary>
        ''' Handles the TextChanged event of the tbBgImage control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub tbBgImage_TextChanged(sender As Object, e As EventArgs) Handles tbBgImage.TextChanged
            Dim __chainValue As Boolean = tbBgImage.Text.Trim().Length > 0
            gbPosition.Enabled = __chainValue
            cbScrolling.Enabled = gbPosition.Enabled
            cbTiling.Enabled = cbScrolling.Enabled
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbHorizontal control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbHorizontal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHorizontal.SelectedIndexChanged
            Dim __chainValue As Boolean = cbHorizontal.SelectedIndex = 4
            cbHorCustType.Enabled = __chainValue
            tbHorCust.Enabled = cbHorCustType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the cbVertical control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbVertical_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVertical.SelectedIndexChanged
            Dim __chainValue As Boolean = cbVertical.SelectedIndex = 4
            cbVerCustType.Enabled = __chainValue
            tbVerCust.Enabled = cbVerCustType.Enabled
        End Sub

        ''' <summary>
        ''' Handles the CheckedChanged event of the cbDoNotUseBackground control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub cbDoNotUseBackground_CheckedChanged(sender As Object, e As EventArgs) Handles cbDoNotUseBackground.CheckedChanged
            If cbDoNotUseBackground.Checked Then
                gbPosition.Enabled = False
                cbScrolling.Enabled = gbPosition.Enabled
                cbTiling.Enabled = cbScrolling.Enabled
                btChooseBgImage.Enabled = cbTiling.Enabled
                tbBgImage.Enabled = btChooseBgImage.Enabled
            Else
                gbPosition.Enabled = True
                cbScrolling.Enabled = gbPosition.Enabled
                cbTiling.Enabled = cbScrolling.Enabled
                btChooseBgImage.Enabled = cbTiling.Enabled
                tbBgImage.Enabled = btChooseBgImage.Enabled
                tbBgImage_TextChanged(Me, EventArgs.Empty)
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btChooseBgImage control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btChooseBgImage_Click(sender As Object, e As EventArgs) Handles btChooseBgImage.Click
            If dlgBgImage.ShowDialog() = DialogResult.OK Then
                tbBgImage.Text = dlgBgImage.FileName
            End If
        End Sub
#End Region

        ''' <summary>
        ''' Flushes the content of the user control back to the dictionary
        ''' </summary>
        Public Sub FlushContent() Implements IEditorStylePage.FlushContent
            _dict.Remove("background-color")
            _dict.Remove("background-image")
            _dict.Remove("background-repeat")
            _dict.Remove("background-attachment")
            _dict.Remove("background-position-x")
            _dict.Remove("background-position-y")

            _dict("background-color") = If(cbBgColorTransparent.Checked, "transparent", ColorTranslator.ToHtml(txtBgColor.BackColor))

            If cbDoNotUseBackground.Checked Then
                _dict("background-image") = "none"
            Else
                _dict("background-image") = If(String.IsNullOrEmpty(tbBgImage.Text.Trim()), String.Empty, $"url({tbBgImage.Text.Trim()})")
                _dict("background-repeat") = CStr(cbTiling.SelectedValue)
                _dict("background-attachment") = CStr(cbScrolling.SelectedValue)

                If cbHorizontal.SelectedIndex <> 4 Then
                    _dict("background-position-x") = CStr(cbHorizontal.SelectedValue)
                Else
                    _dict("background-position-x") = tbHorCust.Text & cbHorCustType.Text
                End If

                If cbVertical.SelectedIndex <> 4 Then
                    _dict("background-position-y") = CStr(cbVertical.SelectedValue)
                Else
                    _dict("background-position-y") = tbVerCust.Text & cbVerCustType.Text
                End If
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the txtBgColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub txtBgColor_Click(sender As Object, e As EventArgs) Handles txtBgColor.Click
            If dlgColorPicker.ShowDialog() = DialogResult.OK Then
                txtBgColor.BackColor = dlgColorPicker.Color
            End If
        End Sub

    End Class

End Namespace
