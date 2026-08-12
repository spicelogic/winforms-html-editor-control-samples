Imports System.Windows.Forms

Module Program

    <STAThread>
    Public Sub Main()
        ' To activate your purchased license, set
        '   SpiceLogic.HtmlEditor.WinForms.WinFormHtmlEditor.LicenseKey = "YOUR-LICENSE-KEY-HERE"
        ' here, before creating any editor instance. Without a key the editor runs a 14-day trial.

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub

End Module
