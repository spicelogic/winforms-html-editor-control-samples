''' <summary>
''' A simple business object standing in for a row you would normally pull from a database or
''' business layer. History holds HTML markup - that field is what gets bound to the editor.
''' </summary>
<Serializable>
Public Class Student
    Public Property Name As String = ""
    Public Property RollNumber As Integer
    Public Property History As String = ""
End Class
