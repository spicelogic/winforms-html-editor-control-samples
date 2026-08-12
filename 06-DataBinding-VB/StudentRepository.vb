Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Serialization

''' <summary>
''' Loads and saves the sample student list from a small XML file next to the executable, so
''' the binding navigator's "Save data" button demonstrates writing bound edits back to a real
''' data store instead of just holding them in memory.
''' </summary>
Friend Module StudentRepository

    Private ReadOnly FilePath As String = Path.Combine(Application.StartupPath, "sample-students.xml")

    Public Function Load() As List(Of Student)
        If File.Exists(FilePath) Then
            Try
                Dim serializer As New XmlSerializer(GetType(List(Of Student)))
                Using stream As Stream = File.OpenRead(FilePath)
                    Dim result = TryCast(serializer.Deserialize(stream), List(Of Student))
                    If result IsNot Nothing Then
                        Return result
                    End If
                End Using
            Catch
                ' Fall through to the built-in sample data below if the file is missing, locked,
                ' or was hand-edited into something the serializer can no longer read.
            End Try
        End If

        Return New List(Of Student) From {
            New Student() With {
                .Name = "Mike James",
                .RollNumber = 12,
                .History = "<p>He <u>is</u> a <font color=""#ff0000"">very</font> good boy, but not <strong>great</strong> at sports.</p>"
            },
            New Student() With {
                .Name = "Maria Shelly",
                .RollNumber = 34,
                .History = "<p>What else can be <font color=""#ff0000"">told</font> about her - she is <strong>awesome</strong>.</p>"
            },
            New Student() With {
                .Name = "Sylvia Jackson",
                .RollNumber = 23,
                .History = "<p>Sylvia loves <font color=""#ff0000"">ice cream</font>, but <strong>not milk</strong>.</p>"
            }
        }
    End Function

    Public Sub Save(students As List(Of Student))
        Dim serializer As New XmlSerializer(GetType(List(Of Student)))
        Using stream As Stream = File.Create(FilePath)
            serializer.Serialize(stream, students)
        End Using
    End Sub

End Module
