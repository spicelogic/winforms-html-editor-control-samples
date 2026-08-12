Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Launches the two data binding scenarios: binding the editor's BodyHtml property, and
''' binding its DocumentHtml property, to a field on a bound business object.
''' </summary>
Public Class MainForm
    Inherits Form

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - data binding (VB.NET)"
        Width = 640
        Height = 320
        StartPosition = FormStartPosition.CenterScreen
        Padding = New Padding(15)

        Dim description As New Label() With {
            .Dock = DockStyle.Top,
            .Height = 80,
            .Text = "The WinForms HTML editor supports standard WinForms data binding for both the " &
                    "BodyHtml and DocumentHtml properties, so you can bind editor content to a list, " &
                    "a DataSet, or a business object through a BindingSource - the same way you would " &
                    "bind any other control."
        }

        Dim instructions As New Label() With {
            .Dock = DockStyle.Top,
            .Height = 30,
            .Font = New Font(Font, FontStyle.Bold),
            .Text = "Choose a binding scenario:"
        }

        Dim bodyHtmlButton As New Button() With {
            .Dock = DockStyle.Top,
            .Height = 40,
            .Text = "BodyHtml binding - bind editor content via the BodyHtml property",
            .TextAlign = ContentAlignment.MiddleLeft
        }
        AddHandler bodyHtmlButton.Click, AddressOf OnBodyHtmlButtonClick

        Dim documentHtmlButton As New Button() With {
            .Dock = DockStyle.Top,
            .Height = 40,
            .Text = "DocumentHtml binding - bind the full document HTML, including head and body",
            .TextAlign = ContentAlignment.MiddleLeft
        }
        AddHandler documentHtmlButton.Click, AddressOf OnDocumentHtmlButtonClick

        ' Docked controls stack from the last one added (outermost) to the first (innermost),
        ' so this order puts the description at the very top and the buttons below it.
        Controls.Add(documentHtmlButton)
        Controls.Add(bodyHtmlButton)
        Controls.Add(instructions)
        Controls.Add(description)
    End Sub

    Private Sub OnBodyHtmlButtonClick(sender As Object, e As EventArgs)
        Dim demoForm As New BodyHtmlBindingForm()
        demoForm.Show()
    End Sub

    Private Sub OnDocumentHtmlButtonClick(sender As Object, e As EventArgs)
        Dim demoForm As New DocumentHtmlBindingForm()
        demoForm.Show()
    End Sub

End Class
