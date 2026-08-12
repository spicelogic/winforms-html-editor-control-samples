Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck

''' <summary>
''' A minimal ISpellCheckerEngine implementation. A real-world engine would wrap a
''' dictionary library or a cloud spell-check API (useful for a specialized vocabulary
''' such as medical, legal, or multilingual terms); this demo engine uses a simple rule
''' instead so the behavior is obvious at a glance: every word starting with the letter
''' "a" is treated as misspelled, and any word added through AddToUserDictionary is
''' remembered as correct for the rest of the session.
''' </summary>
Public Class CustomSpellCheckerEngine
    Implements ISpellCheckerEngine

    Private ReadOnly _userDictionary As New HashSet(Of String)()
    Private _fixedUserDictionaryPath As String

    Public Sub Initialize(dictionaryPath As String, affixPath As String, userDictionaryPath As String) Implements ISpellCheckerEngine.Initialize
        InitializeUserDictionary(userDictionaryPath)
    End Sub

    Public Function Spell(word As String) As Boolean Implements ISpellCheckerEngine.Spell
        If String.IsNullOrEmpty(word) Then
            Return True
        End If

        If Not word.StartsWith("a") Then
            Return True
        End If

        Return _userDictionary.Contains(word)
    End Function

    Public Function Suggest(word As String, Optional max As Integer? = Nothing) As IEnumerable(Of String) Implements ISpellCheckerEngine.Suggest
        If Not String.IsNullOrEmpty(word) AndAlso word.StartsWith("a") Then
            Return New String() {"Aesthetics", "Apple"}
        End If

        Return New String() {}
    End Function

    Public Sub AddToUserDictionary(word As String) Implements ISpellCheckerEngine.AddToUserDictionary
        If String.IsNullOrEmpty(word) OrElse String.IsNullOrEmpty(_fixedUserDictionaryPath) Then
            Return
        End If

        Try
            If Not File.Exists(_fixedUserDictionaryPath) Then
                Dim directoryName As String = If(Path.GetDirectoryName(_fixedUserDictionaryPath), String.Empty)
                If Not Directory.Exists(directoryName) Then
                    MessageBox.Show("The user dictionary folder does not exist.")
                    Return
                End If

                Using File.Create(_fixedUserDictionaryPath)
                End Using
            End If

            Dim existingWords As String() = File.ReadAllLines(_fixedUserDictionaryPath)
            If Array.Exists(existingWords, Function(w) w = word) Then
                Return
            End If

            Using writer As StreamWriter = File.AppendText(_fixedUserDictionaryPath)
                writer.WriteLine(word)
            End Using

            _userDictionary.Add(word)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show($"The user dictionary at '{_fixedUserDictionaryPath}' could not be created or updated because of a permission restriction.")
        Catch ex As IOException
            MessageBox.Show($"An unexpected error occurred while creating or updating the user dictionary at '{_fixedUserDictionaryPath}'.")
        End Try
    End Sub

    Public Sub Dispose() Implements ISpellCheckerEngine.Dispose
        ' Nothing to release for this in-memory demo engine.
    End Sub

    Private Sub InitializeUserDictionary(userDictionaryPath As String)
        _fixedUserDictionaryPath = FixDictionaryPath(userDictionaryPath)

        If String.IsNullOrEmpty(_fixedUserDictionaryPath) OrElse Not File.Exists(_fixedUserDictionaryPath) Then
            Return
        End If

        For Each line As String In File.ReadAllLines(_fixedUserDictionaryPath)
            _userDictionary.Add(line)
        Next
    End Sub

    Private Shared Function FixDictionaryPath(filePath As String) As String
        If String.IsNullOrEmpty(filePath) Then
            Return filePath
        End If

        If Not Path.IsPathRooted(filePath) Then
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath)
        End If

        If Not String.Equals(Path.GetExtension(filePath), ".dic", StringComparison.OrdinalIgnoreCase) Then
            filePath = filePath.Trim() & ".dic"
        End If

        Return filePath
    End Function
End Class
