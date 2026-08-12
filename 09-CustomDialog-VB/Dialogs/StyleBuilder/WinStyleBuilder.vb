Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Parses CSS style string and permits the user to edit it
    ''' </summary>
    Partial Public NotInheritable Class WinStyleBuilder
        Inherits DialogBase
        Implements IStyleBuilderDialog

        ''' <summary>
        ''' User control currently displayed on the right
        ''' </summary>
        Private _selectedPage As Control

        ''' <summary>
        ''' Parsed style string
        ''' </summary>
        Private ReadOnly _propertiesDict As Dictionary(Of String, String) = New Dictionary(Of String, String)()

#Region "-------- Constructors ----------"

        ''' <summary>
        ''' Initializes a new instance of the <see cref="WinStyleBuilder" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
        End Sub

        '''' <summary>
        '''' Initializes a new instance of the <see cref="WinStyleBuilder"/> class.
        '''' </summary>
        '''' <param name="styleArg">The style arg.</param>
        '''' <param name="parsingTolerance">The parsing tolerance.</param>
        'public WinStyleBuilder(string styleArg, ParsingTolerence parsingTolerance)
        '{
        '    ParseStyleArgument(styleArg, parsingTolerance);
        '    InitializeComponent();
        '}

        '''' <summary>
        '''' Initializes a new instance of the <see cref="WinStyleBuilder"/> class.
        '''' </summary>
        '''' <param name="styleArg">The style arg.</param>
        'public WinStyleBuilder(string styleArg)
        '{
        '    ParseStyleArgument(styleArg, ParsingTolerence.NoTolerance);
        '    InitializeComponent();
        '}

#End Region

        ''' <summary>
        ''' Selects first page on load
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        Private Sub frmFontSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Master-detail runtime init (not a design-time default): selecting
            ' page 0 and rendering it must happen after construction because the
            ' page-loader reflects over the properties dictionary set after
            ' InitializeComponent. Kept here deliberately, like a state preload.
            lbPage.SelectedIndex = 0
            lbPage_SelectedIndexChanged(sender, e)
        End Sub

        ''' <summary>
        ''' Updates the currenlty visible page
        ''' Iternally this method looks up current assembly using reflection for the appropriate page control to be shown
        ''' The page control should be marked with FormSelectorPageAttribute and have a constructor which accepts Dictionary&lt;string, string&gt;
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        ''' <exception cref="System.NotImplementedException"></exception>
        Private Sub lbPage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPage.SelectedIndexChanged
            ' Dispose currently selector control if any
            If _selectedPage IsNot Nothing Then
                pnlSelectedPage.Controls.Remove(_selectedPage)
                CType(_selectedPage, IEditorStylePage).FlushContent()
                _selectedPage.Dispose()
                _selectedPage = Nothing
            End If

            ' Check selection and look for the control
            If lbPage.SelectedItem IsNot Nothing Then
                ' Name of the page
                Dim sName As String = CStr(lbPage.SelectedItem)

                ' Search this assembly for the appropriate control
                Dim aThisAssembly As Assembly = Assembly.GetAssembly(Me.GetType())
                For Each t As Type In aThisAssembly.GetTypes()
                    Dim attr As Attribute = Attribute.GetCustomAttribute(t, GetType(FormSelectorPageAttribute))
                    If attr IsNot Nothing Then
                        Dim pageAttr As FormSelectorPageAttribute = CType(attr, FormSelectorPageAttribute)
                        If pageAttr.PageName = sName Then
                            _selectedPage = CType(Activator.CreateInstance(t, _propertiesDict), Control)
                            Exit For
                        End If
                    End If
                Next

                ' Dummy check
                If _selectedPage Is Nothing Then
                    Throw New NotImplementedException($"Page {sName} is not implemented in Style Page Selector.")
                End If

                ' add it to the form
                pnlSelectedPage.SuspendLayout()
                pnlSelectedPage.Controls.Add(_selectedPage)
                _selectedPage.Dock = DockStyle.Fill
                pnlSelectedPage.ResumeLayout()
            End If
        End Sub

        ''' <summary>
        ''' Handles the FormClosed event of the frmFontSelector control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.FormClosedEventArgs" /> instance containing the event data.</param>
        Private Sub frmFontSelector_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            If _selectedPage IsNot Nothing Then
                pnlSelectedPage.Controls.Remove(_selectedPage)
                CType(_selectedPage, IEditorStylePage).FlushContent()
                _selectedPage.Dispose()
                _selectedPage = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Parses the style argument.
        ''' </summary>
        ''' <param name="styleArg">The style arg.</param>
        ''' <param name="parsingTolerance">The parsing tolerance.</param>
        ''' <exception cref="System.ArgumentException">
        ''' </exception>
        Public Sub ParseStyleArgument(styleArg As String, parsingTolerance As ParsingTolerance) Implements IStyleBuilderDialog.ParseStyleArgument
            Try
                Dim position As Integer = 0

                If String.IsNullOrEmpty(styleArg) Then
                    styleArg = String.Empty
                End If
                styleArg = styleArg.Trim()

                ' Handle enclosed quotes
                If styleArg.Length >= 2 AndAlso styleArg(0) = """"c AndAlso styleArg(styleArg.Length - 1) = """"c Then
                    styleArg = styleArg.Substring(1, styleArg.Length - 2).Trim()
                End If

                While position < styleArg.Length
                    Dim separatorI As Integer = styleArg.IndexOf(":"c, position)
                    If separatorI <> -1 Then ' ':' found
                        ' localize tag
                        Dim tag As String = styleArg.Substring(position, separatorI - position).Trim().ToLowerInvariant()

                        ' localize parameters
                        Dim nextSemicolonI As Integer = styleArg.IndexOf(";"c, separatorI + 1)
                        If nextSemicolonI = -1 Then
                            nextSemicolonI = styleArg.Length
                        End If
                        Dim parameters As String = styleArg.Substring(separatorI + 1, nextSemicolonI - separatorI - 1).Trim()

                        ' store in dictionary
                        _propertiesDict(tag) = parameters

                        ' move starting position
                        position = nextSemicolonI + 1
                    Else                 ' ':' not found
                        Dim reminder As String = styleArg.Substring(position).Trim()
                        If reminder.Length <> 0 AndAlso parsingTolerance <> ParsingTolerance.TolerateUnknownTags Then
                            Throw New ArgumentException($"Tag {reminder} has no specification")
                        End If

                        Exit While           ' no exception was thrown - end parsing
                    End If
                End While

                If parsingTolerance = ParsingTolerance.NoTolerance Then
                    ' create list of handling classes
                    Dim handlingClasses As List(Of FormSelectorPageAttribute) = New List(Of FormSelectorPageAttribute)()
                    Dim aThisAssembly As Assembly = Assembly.GetAssembly(Me.GetType())
                    For Each t As Type In aThisAssembly.GetTypes()
                        Dim attr As Attribute = Attribute.GetCustomAttribute(t, GetType(FormSelectorPageAttribute))
                        If attr IsNot Nothing Then
                            handlingClasses.Add(CType(attr, FormSelectorPageAttribute))
                        End If
                    Next

                    ' iterate through tags
                    For Each kvp As KeyValuePair(Of String, String) In _propertiesDict
                        Dim tagHandled As Boolean = False
                        ' search for a class to handle this attribute
                        For Each attr As FormSelectorPageAttribute In handlingClasses
                            If attr.HandlesTag(kvp.Key) Then
                                tagHandled = True
                                Exit For
                            End If
                        Next

                        If Not tagHandled Then
                            Throw New ArgumentException($"Tag {kvp.Key} can't be handled.")
                        End If
                    Next
                End If
            Catch err As Exception
                MessageBox.Show(err.Message, "Error parsing")
            End Try
        End Sub


#Region "------- Exposed Getters ----------------"

        ''' <summary>
        ''' Gets a value indicating whether [remove style].
        ''' </summary>
        ''' <value><c>true</c> if [remove style]; otherwise, <c>false</c>.</value>
        Public Property RemoveStyle As Boolean Implements IStyleBuilderDialog.RemoveStyle
            Get
                Return chkRemoveStyle.Checked
            End Get
            Set(value As Boolean)
                chkRemoveStyle.Checked = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the CSS text value.
        ''' </summary>
        ''' <value>The CSS text value.</value>
        Public ReadOnly Property CSSTextValue As String Implements IStyleBuilderDialog.CSSTextValue
            Get
                ' iterate through properties and construct string representation
                Dim sb As StringBuilder = New StringBuilder()
                For Each kvp As KeyValuePair(Of String, String) In _propertiesDict
                    If kvp.Value.Trim().Length > 0 Then
                        sb.Append(kvp.Key)
                        sb.Append(": ")
                        sb.Append(kvp.Value)
                        sb.Append("; ")
                    End If
                Next
                Return sb.ToString().Trim()
            End Get
        End Property

#End Region

        ' VB.NET requires explicit interface implementation for the IDialog
        ' members the WinForms Form base class supplies (ShowDialog from
        ' IDialog, Dispose from IDisposable). C# satisfies these implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
