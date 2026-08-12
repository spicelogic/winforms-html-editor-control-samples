Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Dialogs
Imports SpiceLogic.HtmlEditor.WinForms.Helpers
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs
Imports SpiceLogic.HtmlEditor.WinForms.Models.Dialogs

Namespace Global.CustomDialog.Dialogs

    ''' <summary>
    ''' Class SymbolDialog
    ''' </summary>
    Partial Public Class SymbolDialog
        Inherits DialogBase
        Implements ISymbolDialog

        ''' <summary>
        ''' The _ last point
        ''' </summary>
        Private _lastPoint As Point
        ''' <summary>
        ''' The _ start X
        ''' </summary>
        Private Const StartX As Integer = 7
        ''' <summary>
        ''' The _ start Y
        ''' </summary>
        Private Const StartY As Integer = 3

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SymbolDialog" /> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _lastPoint = New Point(StartX, StartY) 'start pos
            Me.SuspendLayout()
            Try
                buildButtons()
            Finally
                Me.ResumeLayout()
            End Try

            Icon = Constants.FormIcon
        End Sub

        ''' <summary>
        ''' Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        ''' </summary>
        ''' <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.ResumeLayout()
        End Sub

        ''' <summary>
        ''' Occurs when [symbol button clicked].
        ''' </summary>
        Public Event SymbolButtonClicked As EventHandler(Of SymbolEventArg) Implements ISymbolDialog.SymbolButtonClicked

        ''' <summary>
        ''' Occurs when [dialog closed].
        ''' </summary>
        Public Event DialogClosed As EventHandler(Of EventArgs) Implements ISymbolDialog.DialogClosed

        ''' <summary>
        ''' Builds the buttons.
        ''' </summary>
        Private Sub buildButtons()
            buildButton(" ", "nbsp") ' "#0020");
            buildButton("""", "quot") '"#22");
            buildButton("¡", "iexcl") '"#00A1");
            buildButton("¢", "cent") ' "#00A2");
            buildButton("£", "pound") '"#00A3");
            buildButton("¤", "curren") ' "#00A4");
            buildButton("¥", "yen") ' "#00A5");
            buildButton("¦", "brvbar") '"#00A6");
            buildButton("§", "sect") ' "#00A7");
            buildButton("¨", "uml") ' "#00A8");
            buildButton("©", "copy") ' "#00A9");
            buildButton("ª", "ordf") ' "#00AA");
            buildButton("«", "laquo") ' "#00AB");
            buildButton("¬", "not") ' "#00AC");
            'empty
            buildButton("®", "reg") ' "#00AE");
            buildButton("¯", "macr") ' "#00AF");
            buildButton("°", "deg") ' "#00B0");
            buildButton("±", "plusmn") ' "#00B1");
            buildButton("²", "sup2") ' "#00B2");
            buildButton("³", "sup3") ' "#00B3");
            buildButton("´", "acute") ' "#00B4");
            buildButton("µ", "micro") ' "#00B5");
            buildButton("¶", "para") ' "#00B6");
            buildButton("·", "middot") ' "#00B7");
            buildButton("¸", "cedil") ' "#00B8");
            buildButton("¹", "sup1") ' "#00B9");
            buildButton("º", "ordm") ' "#00BA");
            buildButton("»", "raquo") ' "#00BB");
            buildButton("¼", "frac14") ' "#00BC");
            buildButton("½", "frac12") ' "#00BD");
            buildButton("¾", "frac34") ' "#00BE");
            buildButton("¿", "iquest") ' "#00BF");
            buildButton("×", "times") ' "#00D7");
            buildButton("Ø", "Oslash") ' "#00D8");
            buildButton("÷", "divide") ' "#00F7");
            buildButton("ø", "oslash") ' "#00F8");
            buildButton("ƒ", "fnof") ' "#00192");
            buildButton("ˆ", "circ") ' "#002C6");
            buildButton("˜", "tilde") ' "#002DC");
            buildButton("–", "ndash") ' "#002013");
            buildButton("—", "mdash") ' "#002014");
            buildButton(ChrW(&H2018), "lsquo") ' "#002018");
            buildButton(ChrW(&H2019), "rsquo") ' "#002019");
            buildButton("‚", "sbquo") ' "#00201A");
            buildButton(ChrW(&H201C), "ldquo") ' "#00201C");
            buildButton(ChrW(&H201D), "rdquo") ' "#00201D");
            buildButton("„", "bdquo") ' "#00201E");
            buildButton("†", "dagger") ' "#002020");
            buildButton("‡", "Dagger") ' "#002021");
            buildButton("•", "bull") ' "#002022");
            buildButton("…", "hellip") ' "#002026");
            buildButton("‰", "permil") ' "#002030");
            buildButton("‹", "lsaquo") ' "#002039");
            buildButton("›", "rsaquo") ' "#00203A");
            buildButton("€", "euro") ' "#0020AC");
            buildButton("™", "trade") ' "#002122");
            buildButton("À", "Agrave") ' "#00C0");
            buildButton("Á", "Aacute") ' "#00C1");
            buildButton("Â", "Acirc")
            buildButton("Ã", "Atilde") ' "#00C3");
            buildButton("Ä", "Auml") ' "#00C4");
            buildButton("Å", "Aring") ' "#00C5");
            buildButton("Æ", "AElig") ' "#00C6");
            buildButton("Ç", "Ccedil") ' "#00C7");
            buildButton("È", "Egrave") ' "#00C8");
            buildButton("É", "Eacute") ' "#00C9");

            buildButton("Ê", "Ecirc") ' "#00CA");
            buildButton("Ë", "Euml") ' "#00CB");
            buildButton("Ì", "Igrave") ' "#00CC");
            buildButton("Í", "Iacute") ' "#00CD");
            buildButton("Î", "Icirc") ' "#00CE");
            buildButton("Ï", "Iuml") ' "#00CF");
            buildButton("Ð", "ETH") ' "#00D0");
            buildButton("Ñ", "Ntilde") ' "#00D1");
            buildButton("Ò", "Ograve") ' "#00D2");
            buildButton("Ó", "Oacute") ' "#00D3");
            buildButton("Ô", "Ocirc") ' "#00D4");
            buildButton("Õ", "Otilde") ' "#00D5");
            buildButton("Ö", "Ouml") ' "#00D6");
            buildButton("×", "times") ' "#00D7");
            buildButton("Ø", "Oslash") ' "#00D8");
            buildButton("Ù", "Ugrave") ' "#00D9");
            buildButton("Ú", "Uacute") ' "#00DA");
            buildButton("Û", "Ucirc") ' "#00DB");
            buildButton("Ü", "Uuml") ' "#00DC");
            buildButton("Ý", "Yacute") ' "#00DD");
            buildButton("Þ", "THORN") ' "#00DE");
            buildButton("ß", "szlig") ' "#00DF");
            buildButton("à", "agrave") ' "#00E0");
            buildButton("á", "aacute") ' "#00E1");
            buildButton("â", "acirc") ' "#00E2");
            buildButton("ã", "atilde") ' "#00E3");
            buildButton("ä", "auml") ' "#00E4");
            buildButton("å", "aring") ' "#00E5");
            buildButton("æ", "aelig") ' "#00E6");
            buildButton("ç", "ccedil") ' "#00E7");
            buildButton("è", "egrave") ' "#00E8");
            buildButton("é", "eacute") ' "#00E9");
            buildButton("ê", "ecirc") ' "#00EA");
            buildButton("ë", "euml") ' "#00EB");
            buildButton("ì", "igrave") ' "#00EC");
            buildButton("í", "iacute") ' "#00ED");
            buildButton("î", "icirc") ' "#00EE");
            buildButton("ï", "iuml") ' "#00EF");
            buildButton("ð", "eth") ' "#00F0");
            buildButton("ñ", "ntilde") ' "#00F1");
            buildButton("ò", "ograve") ' "#00F2");
            buildButton("ó", "oacute") ' "#00F3");
            buildButton("ô", "ocirc") ' "#00F4");
            buildButton("õ", "otilde") ' "#00F5");
            buildButton("ö", "ouml") ' "#00F6");
            buildButton("÷", "divide") ' "#00F7");
            buildButton("ø", "oslash") ' "#00F8");
            buildButton("ù", "ugrave") ' "#00F9");
            buildButton("ú", "uacute") ' "#00FA");
            buildButton("û", "ucirc") ' "#00FB");
            buildButton("ü", "uuml") ' "#00FC");
            buildButton("ý", "yacute") ' "#00FD");
            buildButton("þ", "thorn") ' "#00FE");
            buildButton("ÿ", "yuml") ' "#00FF");
            buildButton("Œ", "OElig") ' "#0152");
            buildButton("œ", "oelig") ' "#0153");
            buildButton("Š", "Scaron") ' "#0160");
            buildButton("š", "scaron") ' "#0161");
            buildButton("Ÿ", "Yuml") ' "#0178");
            buildButton("¢", "cent") ' "#00A2");
            buildButton("@", "#64") ' "#0040");
            buildButton("Ω", "Omega") ' "#03A9");
        End Sub

        ''' <summary>
        ''' Builds the button.
        ''' </summary>
        ''' <param name="displayText">The display text.</param>
        ''' <param name="value">The value.</param>
        Private Sub buildButton(displayText As String, value As Object)
            Dim btnNew As Button = New Button() With {.Text = displayText, .Cursor = Cursors.Hand}
            Const width As Integer = 34
            Const height As Integer = 33
            Const gutter As Integer = 3
            btnNew.Size = New Size(width, height) 'button size
            btnNew.AutoSize = True
            If _lastPoint.X >= 500 Then 'line break
                _lastPoint.Offset(-1 * _lastPoint.X + StartX, height + 2) 'new line
            End If
            Dim nextPoint As Point = New Point(_lastPoint.X, _lastPoint.Y)
            btnNew.Location = nextPoint
            Me.Controls.Add(btnNew)
            AddHandler btnNew.Click, Sub(sender, args) insertSymbol($"&{value};")
            nextPoint.Offset(width + gutter, 0) 'next btn pos
            _lastPoint = nextPoint
        End Sub

        ''' <summary>
        ''' Inserts the symbol.
        ''' </summary>
        ''' <param name="symbol">The symbol.</param>
        Private Sub insertSymbol(symbol As String)
            RaiseEvent SymbolButtonClicked(Me, New SymbolEventArg(symbol))
        End Sub

        ''' <summary>
        ''' Handles the FormClosed event of the SymbolDialog control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.FormClosedEventArgs" /> instance containing the event data.</param>
        Private Sub SymbolDialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            RaiseEvent DialogClosed(Me, e)
        End Sub

        ' VB.NET requires explicit interface implementation for the IDialog
        ' members the WinForms Form base class supplies (ShowDialog from
        ' IDialog, Dispose from IDisposable). C# satisfies these implicitly.
        Public Shadows Function ShowDialog() As DialogResult Implements IDialog.ShowDialog
            Return MyBase.ShowDialog()
        End Function
    End Class

End Namespace
