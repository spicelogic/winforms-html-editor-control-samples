Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Form to let user select a (sub)set of fonts
    ''' </summary>
    Partial Public Class frmFontPicker
        Inherits DialogBase

        ''' <summary>
        ''' List of font names
        ''' it is synchronized with the list box of selected fonts
        ''' </summary>
        Private ReadOnly _lSelectedFonts As List(Of String) = New List(Of String)()

#Region "Exposed methods"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="frmFontPicker"/> class.
        ''' </summary>
        ''' <param name="initFontList">The init font list.</param>
        Public Sub New(initFontList As String)
            ' handle selected fonts
            Dim arrFonts As String() = initFontList.Split(","c)
            For Each aFontName As String In arrFonts
                Dim candidate As String = aFontName.Trim()
                If candidate.Length >= 2 AndAlso candidate(0) = "'"c AndAlso candidate(candidate.Length - 1) = "'"c Then
                    candidate = candidate.Substring(1, candidate.Length - 2)
                End If
                If candidate.Length = 0 Then
                    Continue For
                End If
                _lSelectedFonts.Add(candidate)
            Next

            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Comma-separeted list of fonts
        ''' </summary>
        ''' <value>The selected font list.</value>
        Public ReadOnly Property SelectedFontList As String
            Get
                ' Build from list
                Dim sb As StringBuilder = New StringBuilder()
                Dim first As Boolean = True                              ' A flag indicating we're going to write the first entry

                ' Iterate through selected fonts
                For Each aFontname As String In _lSelectedFonts
                    ' Handle first entry
                    If Not first Then
                        sb.Append(", ")
                    Else
                        first = False
                    End If

                    ' Append font's name
                    If aFontname.Contains(" ") Then
                        sb.Append("'"c)
                        sb.Append(aFontname)
                        sb.Append("'"c)
                    Else
                        sb.Append(aFontname)
                    End If
                Next

                ' done
                Return sb.ToString()
            End Get
        End Property
#End Region

        ''' <summary>
        ''' Handles the Load event of the frmFontPicker control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub frmFontPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' populate list of selected fonts
            lbSelectedFonts.SuspendLayout()
            For Each aFont As String In _lSelectedFonts
                lbSelectedFonts.Items.Add(aFont)
            Next
            lbSelectedFonts.ResumeLayout()

            ' populate list of installed fonts
            lbInstalledFonts.SuspendLayout()
            For Each fontFamily As FontFamily In FontFamily.Families
                lbInstalledFonts.Items.Add(fontFamily.Name)
            Next
            lbInstalledFonts.ResumeLayout()

            ' set some buttons' enable status
            lbSelectedFonts_SelectedIndexChanged(Me, EventArgs.Empty)
            tbCustomFont_TextChanged(Me, EventArgs.Empty)
        End Sub

#Region "Adding fonts to the selected list"
        ''' <summary>
        ''' Handles the Click event of the btAddInstalledFont control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btAddInstalledFont_Click(sender As Object, e As EventArgs) Handles btAddInstalledFont.Click
            Dim sFont As String = CStr(lbInstalledFonts.SelectedItem)
            If Not String.IsNullOrEmpty(sFont) Then
                lbSelectedFonts.Items.Add(sFont)
                _lSelectedFonts.Add(sFont)
                lbInstalledFonts.SelectedItem = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btAddGenericFont control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btAddGenericFont_Click(sender As Object, e As EventArgs) Handles btAddGenericFont.Click
            Dim sFont As String = CStr(cbGenericFonts.SelectedItem)
            If Not String.IsNullOrEmpty(sFont) Then
                lbSelectedFonts.Items.Add(sFont)
                _lSelectedFonts.Add(sFont)
                cbGenericFonts.SelectedItem = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the brAddCustomFont control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub brAddCustomFont_Click(sender As Object, e As EventArgs) Handles btAddCustomFont.Click
            lbSelectedFonts.Items.Add(tbCustomFont.Text)
            _lSelectedFonts.Add(tbCustomFont.Text)
        End Sub
#End Region

#Region "Selected fonts handling"
        ''' <summary>
        ''' Handles the Click event of the btMoveUp control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btMoveUp_Click(sender As Object, e As EventArgs) Handles btMoveUp.Click
            Dim sel As Integer = lbSelectedFonts.SelectedIndex
            If sel > 0 Then
                ' exchange items in the list box
                Dim oCurrent As Object = lbSelectedFonts.SelectedItem
                lbSelectedFonts.Items.RemoveAt(sel)
                lbSelectedFonts.Items.Insert(sel - 1, oCurrent)
                lbSelectedFonts.SelectedIndex = sel - 1

                ' exchange items in the local list
                Dim sCurrent As String = _lSelectedFonts(sel)
                _lSelectedFonts(sel) = _lSelectedFonts(sel - 1)
                _lSelectedFonts(sel - 1) = sCurrent
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btMoveDown control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btMoveDown_Click(sender As Object, e As EventArgs) Handles btMoveDown.Click
            Dim sel As Integer = lbSelectedFonts.SelectedIndex
            If sel <> -1 AndAlso sel < lbSelectedFonts.Items.Count - 1 Then
                ' exchange items in the list box
                Dim oCurrent As Object = lbSelectedFonts.SelectedItem
                lbSelectedFonts.Items.RemoveAt(sel)
                lbSelectedFonts.Items.Insert(sel + 1, oCurrent)
                lbSelectedFonts.SelectedIndex = sel + 1

                ' exchange items in the local list
                Dim sCurrent As String = _lSelectedFonts(sel)
                _lSelectedFonts(sel) = _lSelectedFonts(sel + 1)
                _lSelectedFonts(sel + 1) = sCurrent
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btRemove control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
            Dim sel As Integer = lbSelectedFonts.SelectedIndex
            If sel <> -1 Then ' precaution
                ' remove from list box
                lbSelectedFonts.Items.RemoveAt(sel)

                ' remove from local list
                _lSelectedFonts.RemoveAt(sel)
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the lbSelectedFonts control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub lbSelectedFonts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSelectedFonts.SelectedIndexChanged
            Dim sel As Integer = lbSelectedFonts.SelectedIndex
            If sel <> -1 Then
                btRemove.Enabled = True
                btMoveUp.Enabled = sel <> 0
                btMoveDown.Enabled = sel <> lbSelectedFonts.Items.Count - 1
            Else ' sel == -1 => disable some buttons
                btRemove.Enabled = False
                btMoveDown.Enabled = btRemove.Enabled
                btMoveUp.Enabled = btMoveDown.Enabled
            End If
        End Sub
#End Region

        ''' <summary>
        ''' Handles the Click event of the btOk control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btOk_Click(sender As Object, e As EventArgs) Handles btOk.Click
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the btCancel control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub

        ''' <summary>
        ''' Handles the TextChanged event of the tbCustomFont control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub tbCustomFont_TextChanged(sender As Object, e As EventArgs) Handles tbCustomFont.TextChanged
            btAddCustomFont.Enabled = tbCustomFont.Text.Trim().Length > 0 AndAlso Not tbCustomFont.Text.Contains(",")
        End Sub
    End Class

End Namespace
