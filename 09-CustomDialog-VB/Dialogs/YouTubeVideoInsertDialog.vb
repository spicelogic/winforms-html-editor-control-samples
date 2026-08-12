Imports System
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.Abstractions.Entities
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Class YouTubeVideoInsertDialog
    ''' </summary>
    Partial Public Class YouTubeVideoInsertDialog
        Inherits DialogBase
        Implements IYouTubeVideoInsertDialog

        ''' <summary>
        ''' The _the original element
        ''' </summary>
        Private _theOriginalElement As YouTubeVideoElement

        ''' <summary>
        ''' Initializes a new instance of the <see cref="YouTubeVideoInsertDialog" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Gets or sets the element.
        ''' </summary>
        ''' <value>The element.</value>
        Public Property Element As YouTubeVideoElement Implements IYouTubeVideoInsertDialog.Element
            Get
                If _theOriginalElement Is Nothing Then
                    Dim theElement As YouTubeVideoElement = New YouTubeVideoElement With {
                        .Url = txtUrl.Text.Trim(),
                        .Width = txtWidth.Text,
                        .Height = txtHeight.Text
                    }
                    Return theElement
                End If
                _theOriginalElement.Url = txtUrl.Text.Trim()
                _theOriginalElement.Width = txtWidth.Text
                _theOriginalElement.Height = txtHeight.Text
                _theOriginalElement.CssStyle = txtCssStyle.Text
                Return _theOriginalElement
            End Get
            Set(value As YouTubeVideoElement)
                Me._theOriginalElement = value
                ' Spec 019 FR-009: preserve design-time defaults on empty fields.
                If Not String.IsNullOrEmpty(value.Url) Then
                    txtUrl.Text = value.Url
                End If
                If Not String.IsNullOrEmpty(value.Height) Then
                    txtHeight.Text = value.Height
                End If
                If Not String.IsNullOrEmpty(value.Width) Then
                    txtWidth.Text = value.Width
                End If
                If Not String.IsNullOrEmpty(value.CssStyle) Then
                    txtCssStyle.Text = value.CssStyle
                End If
            End Set
        End Property

        ''' <summary>
        ''' Handles the Click event of the btnOK control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            If String.IsNullOrEmpty(txtUrl.Text) Then
                MessageBox.Show("The YouTube URL cannot be empty.")
                txtUrl.Focus()
                Return
            End If

            Dim theUrl As String = txtUrl.Text.Trim()
            If theUrl = String.Empty Then
                MessageBox.Show("The YouTube URL cannot be empty.")
                txtUrl.Focus()
                Return
            End If

            If Not theUrl.ToLower().Contains("youtube.com") Then
                MessageBox.Show("The URL you provided does not contain the YouTube Domain name", "Invalid URL")
                Return
            End If

            Me.DialogResult = DialogResult.OK
        End Sub

        ' VB.NET requires explicit interface implementation for the IDialog
        ' members the WinForms Form base class supplies (ShowDialog from
        ' IDialog, Dispose from IDisposable). C# satisfies these implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
