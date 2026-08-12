using System;
using System.Drawing;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Class SymbolDialog
/// </summary>
public partial class SymbolDialog : DialogBase, ISymbolDialog
{
    /// <summary>
    /// The _ last point
    /// </summary>
    Point _lastPoint;
    /// <summary>
    /// The _ start X
    /// </summary>
    private const int StartX = 7;
    /// <summary>
    /// The _ start Y
    /// </summary>
    private const int StartY = 3;

    /// <summary>
    /// Initializes a new instance of the <see cref="SymbolDialog" /> class.
    /// </summary>
    public SymbolDialog()
    {
        InitializeComponent();
        _lastPoint = new Point(StartX, StartY);//start pos
        this.SuspendLayout();
        try
        {
            buildButtons();
        }
        finally
        {
            this.ResumeLayout();
        }

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        this.ResumeLayout();
    }

    /// <summary>
    /// Occurs when [symbol button clicked].
    /// </summary>
    public event EventHandler<SymbolEventArg> SymbolButtonClicked;

    /// <summary>
    /// Occurs when [dialog closed].
    /// </summary>
    public event EventHandler<EventArgs> DialogClosed;

    /// <summary>
    /// Builds the buttons.
    /// </summary>
    private void buildButtons()
    {
        buildButton(" ", "nbsp");// "#0020");
        buildButton("\"", "quot");//"#22");
        buildButton("¡", "iexcl");//"#00A1");
        buildButton("¢", "cent");// "#00A2");
        buildButton("£", "pound");//"#00A3");
        buildButton("¤", "curren");// "#00A4");
        buildButton("¥", "yen");// "#00A5");
        buildButton("¦", "brvbar");//"#00A6");
        buildButton("§", "sect");// "#00A7");
        buildButton("¨", "uml");// "#00A8");
        buildButton("©", "copy");// "#00A9");
        buildButton("ª", "ordf");// "#00AA");
        buildButton("«", "laquo");// "#00AB");
        buildButton("¬", "not");// "#00AC");
        //empty
        buildButton("®", "reg");// "#00AE");
        buildButton("¯", "macr");// "#00AF");
        buildButton("°", "deg");// "#00B0");
        buildButton("±", "plusmn");// "#00B1");
        buildButton("²", "sup2");// "#00B2");
        buildButton("³", "sup3");// "#00B3");
        buildButton("´", "acute");// "#00B4");
        buildButton("µ", "micro");// "#00B5");
        buildButton("¶", "para");// "#00B6");
        buildButton("·", "middot");// "#00B7");
        buildButton("¸", "cedil");// "#00B8");
        buildButton("¹", "sup1");// "#00B9");
        buildButton("º", "ordm");// "#00BA");
        buildButton("»", "raquo");// "#00BB");
        buildButton("¼", "frac14");// "#00BC");
        buildButton("½", "frac12");// "#00BD");
        buildButton("¾", "frac34");// "#00BE");
        buildButton("¿", "iquest");// "#00BF");
        buildButton("×", "times");// "#00D7");
        buildButton("Ø", "Oslash");// "#00D8");
        buildButton("÷", "divide");// "#00F7");
        buildButton("ø", "oslash");// "#00F8");
        buildButton("ƒ", "fnof");// "#00192");
        buildButton("ˆ", "circ");// "#002C6");
        buildButton("˜", "tilde");// "#002DC");
        buildButton("–", "ndash");// "#002013");
        buildButton("—", "mdash");// "#002014");
        buildButton("‘", "lsquo");// "#002018");
        buildButton("’", "rsquo");// "#002019");
        buildButton("‚", "sbquo");// "#00201A");
        buildButton("“", "ldquo");// "#00201C");
        buildButton("”", "rdquo");// "#00201D");
        buildButton("„", "bdquo");// "#00201E");
        buildButton("†", "dagger");// "#002020");
        buildButton("‡", "Dagger");// "#002021");
        buildButton("•", "bull");// "#002022");
        buildButton("…", "hellip");// "#002026");
        buildButton("‰", "permil");// "#002030");
        buildButton("‹", "lsaquo");// "#002039");
        buildButton("›", "rsaquo");// "#00203A");
        buildButton("€", "euro");// "#0020AC");
        buildButton("™", "trade");// "#002122");
        buildButton("À", "Agrave");// "#00C0");
        buildButton("Á", "Aacute");// "#00C1");
        buildButton("Â", "Acirc");
        buildButton("Ã", "Atilde");// "#00C3");
        buildButton("Ä", "Auml");// "#00C4");
        buildButton("Å", "Aring");// "#00C5");
        buildButton("Æ", "AElig");// "#00C6");
        buildButton("Ç", "Ccedil");// "#00C7");
        buildButton("È", "Egrave");// "#00C8");
        buildButton("É", "Eacute");// "#00C9");

        buildButton("Ê", "Ecirc");// "#00CA");
        buildButton("Ë", "Euml");// "#00CB");
        buildButton("Ì", "Igrave");// "#00CC");
        buildButton("Í", "Iacute");// "#00CD");
        buildButton("Î", "Icirc");// "#00CE");
        buildButton("Ï", "Iuml");// "#00CF");
        buildButton("Ð", "ETH");// "#00D0");
        buildButton("Ñ", "Ntilde");// "#00D1");
        buildButton("Ò", "Ograve");// "#00D2");
        buildButton("Ó", "Oacute");// "#00D3");
        buildButton("Ô", "Ocirc");// "#00D4");
        buildButton("Õ", "Otilde");// "#00D5");
        buildButton("Ö", "Ouml");// "#00D6");
        buildButton("×", "times");// "#00D7");
        buildButton("Ø", "Oslash");// "#00D8");
        buildButton("Ù", "Ugrave");// "#00D9");
        buildButton("Ú", "Uacute");// "#00DA");
        buildButton("Û", "Ucirc");// "#00DB");
        buildButton("Ü", "Uuml");// "#00DC");
        buildButton("Ý", "Yacute");// "#00DD");
        buildButton("Þ", "THORN");// "#00DE");
        buildButton("ß", "szlig");// "#00DF");
        buildButton("à", "agrave");// "#00E0");
        buildButton("á", "aacute");// "#00E1");
        buildButton("â", "acirc");// "#00E2");
        buildButton("ã", "atilde");// "#00E3");
        buildButton("ä", "auml");// "#00E4");
        buildButton("å", "aring");// "#00E5");
        buildButton("æ", "aelig");// "#00E6");
        buildButton("ç", "ccedil");// "#00E7");
        buildButton("è", "egrave");// "#00E8");
        buildButton("é", "eacute");// "#00E9");
        buildButton("ê", "ecirc");// "#00EA");
        buildButton("ë", "euml");// "#00EB");
        buildButton("ì", "igrave");// "#00EC");
        buildButton("í", "iacute");// "#00ED");
        buildButton("î", "icirc");// "#00EE");
        buildButton("ï", "iuml");// "#00EF");
        buildButton("ð", "eth");// "#00F0");
        buildButton("ñ", "ntilde");// "#00F1");
        buildButton("ò", "ograve");// "#00F2");
        buildButton("ó", "oacute");// "#00F3");
        buildButton("ô", "ocirc");// "#00F4");
        buildButton("õ", "otilde");// "#00F5");
        buildButton("ö", "ouml");// "#00F6");
        buildButton("÷", "divide");// "#00F7");
        buildButton("ø", "oslash");// "#00F8");
        buildButton("ù", "ugrave");// "#00F9");
        buildButton("ú", "uacute");// "#00FA");
        buildButton("û", "ucirc");// "#00FB");
        buildButton("ü", "uuml");// "#00FC");
        buildButton("ý", "yacute");// "#00FD");
        buildButton("þ", "thorn");// "#00FE");
        buildButton("ÿ", "yuml");// "#00FF");
        buildButton("Œ", "OElig");// "#0152");
        buildButton("œ", "oelig");// "#0153");
        buildButton("Š", "Scaron");// "#0160");
        buildButton("š", "scaron");// "#0161");
        buildButton("Ÿ", "Yuml");// "#0178");
        buildButton("¢", "cent");// "#00A2");
        buildButton("@", "#64");// "#0040");
        buildButton("Ω", "Omega");// "#03A9");
    }

    /// <summary>
    /// Builds the button.
    /// </summary>
    /// <param name="displayText">The display text.</param>
    /// <param name="value">The value.</param>
    private void buildButton(string displayText, object value)
    {
        Button btnNew = new() { Text = displayText, Cursor = Cursors.Hand };
        const int width = 34;
        const int height = 33;
        const int gutter = 3;
        btnNew.Size = new Size(width, height);//button size
        btnNew.AutoSize = true;
        if (_lastPoint.X >= 500) //line break
            _lastPoint.Offset(-1*_lastPoint.X + StartX, height + 2); //new line
        Point nextPoint = new(_lastPoint.X, _lastPoint.Y);
        btnNew.Location = nextPoint;
        this.Controls.Add(btnNew);
        btnNew.Click += (sender, args) => insertSymbol($"&{value};");
        nextPoint.Offset(width + gutter, 0);//next btn pos
        _lastPoint = nextPoint;
    }

    /// <summary>
    /// Inserts the symbol.
    /// </summary>
    /// <param name="symbol">The symbol.</param>
    private void insertSymbol(string symbol)
    {
        SymbolButtonClicked?.Invoke(this, new SymbolEventArg(symbol));
    }

    /// <summary>
    /// Handles the FormClosed event of the SymbolDialog control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.FormClosedEventArgs" /> instance containing the event data.</param>
    private void SymbolDialog_FormClosed(object sender, FormClosedEventArgs e)
    {
        DialogClosed?.Invoke(this, e);
    }
}