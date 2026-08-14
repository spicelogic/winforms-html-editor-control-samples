Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Demonstrates the difference between the two properties you can persist:
'''
'''   BodyHtml     - inner content only, no &lt;html&gt;/&lt;head&gt; wrapper.
'''                  This is what you typically store in a database column,
'''                  because it is easy to drop into an email body or another
'''                  page without fighting a nested &lt;html&gt; tag.
'''
'''   DocumentHtml - the complete document, including &lt;html&gt;, &lt;head&gt;
'''                  and any style/meta content. Use this when you want a
'''                  file that can be opened standalone in a browser.
'''
''' The layout (menu, radio buttons, docked editor) lives in the designer; open
''' MainForm.vb in the Visual Studio designer to see it. A radio button lets you pick
''' which property Open/Save uses, so you can see the difference in the saved .html file.
''' </summary>
Partial Public Class MainForm
    Inherits Form

    Public Sub New()
        InitializeComponent()

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _editor.DocumentTitle = "Sample document"
        _editor.BodyHtml = "<p>Open or save this content as HTML using the File menu above.</p>"
    End Sub

    Private Sub OnOpenClick(ByVal sender As Object, ByVal e As EventArgs) Handles _openItem.Click
        Using dialog As New OpenFileDialog() With {
            .Filter = "HTML files (*.html;*.htm)|*.html;*.htm|All files (*.*)|*.*",
            .Title = "Open HTML file"
        }
            If dialog.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            Dim html As String = File.ReadAllText(dialog.FileName)

            If _bodyHtmlOption.Checked Then
                _editor.BodyHtml = html
            Else
                _editor.DocumentHtml = html
            End If
        End Using
    End Sub

    Private Sub OnSaveClick(ByVal sender As Object, ByVal e As EventArgs) Handles _saveItem.Click
        Using dialog As New SaveFileDialog() With {
            .Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*",
            .Title = "Save HTML file",
            .FileName = If(_bodyHtmlOption.Checked, "body-content.html", "full-document.html")
        }
            If dialog.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            ' BodyHtml gives inner content only (good for a database column or an email body).
            ' DocumentHtml gives a complete, standalone document (good for a file you can open in a browser).
            Dim html As String = If(_bodyHtmlOption.Checked, _editor.BodyHtml, _editor.DocumentHtml)

            File.WriteAllText(dialog.FileName, html)

            MessageBox.Show(Me,
                $"Saved using {If(_bodyHtmlOption.Checked, "BodyHtml", "DocumentHtml")}.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End Using
    End Sub
End Class
