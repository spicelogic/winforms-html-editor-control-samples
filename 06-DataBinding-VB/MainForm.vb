Imports System.Windows.Forms

''' <summary>
''' Launches the two data binding scenarios: binding the editor's BodyHtml property, and
''' binding its DocumentHtml property, to a field on a bound business object.
'''
''' The layout lives in the designer; open MainForm.vb in the Visual Studio designer to see it.
''' </summary>
Partial Public Class MainForm
    Inherits Form

    Public Sub New()
        InitializeComponent()

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.
    End Sub

    Private Sub OnBodyHtmlButtonClick(sender As Object, e As EventArgs) Handles _bodyHtmlButton.Click
        Dim demoForm As New BodyHtmlBindingForm()
        demoForm.Show()
    End Sub

    Private Sub OnDocumentHtmlButtonClick(sender As Object, e As EventArgs) Handles _documentHtmlButton.Click
        Dim demoForm As New DocumentHtmlBindingForm()
        demoForm.Show()
    End Sub

End Class
