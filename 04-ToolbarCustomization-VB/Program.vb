Imports System.Windows.Forms

Module Program

    <STAThread>
    Sub Main()
        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub

End Module
