Imports System
Imports System.Windows.Forms
Imports CustomDialog.Dialogs
Imports CustomDialog.Dialogs.StyleBuilder

Namespace Global.CustomDialog

    Partial Public Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' Start maximized so the full editor toolbar is visible at first run.
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            winFormHtmlEditor1.Dialog.ImageDialog = New ImageDialog()
            winFormHtmlEditor1.Dialog.HyperlinkDialog = New HyperLinkDialog()
            winFormHtmlEditor1.Dialog.SpellCheckerDialog = New SpellCheckerDialog With {.Options = winFormHtmlEditor1.SpellCheckOptions}
            winFormHtmlEditor1.Dialog.TableCellDialog = New TableCellPropertiesDialog()
            winFormHtmlEditor1.Dialog.TableDialog = New TablePropertiesDialog(winFormHtmlEditor1.Dialog.TableCellDialog)
            winFormHtmlEditor1.Dialog.SymbolDialog = New SymbolDialog()
            winFormHtmlEditor1.Dialog.SearchDialog = New SearchWindow()
            winFormHtmlEditor1.Dialog.StyleBuilderDialog = New WinStyleBuilder()
            winFormHtmlEditor1.Dialog.YouTubeVideoInsertDialog = New YouTubeVideoInsertDialog()
        End Sub
    End Class

End Namespace
