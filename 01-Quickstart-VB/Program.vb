Imports System.Windows.Forms

Module Program

    <STAThread>
    Sub Main()
        ' The C# sample uses the SDK's source-generated ApplicationConfiguration.Initialize()
        ' on .NET 6 and newer, but that generator only targets C# projects. VB.NET sets the
        ' same defaults the classic way on every target framework.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub

End Module
