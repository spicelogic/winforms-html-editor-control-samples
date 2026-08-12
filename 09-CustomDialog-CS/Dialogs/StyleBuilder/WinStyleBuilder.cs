using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.Abstractions;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Parses CSS style string and permits the user to edit it
/// </summary>
public sealed partial class WinStyleBuilder : DialogBase, IStyleBuilderDialog
{
    /// <summary>
    /// User control currently displayed on the right
    /// </summary>
    private Control _selectedPage;

    /// <summary>
    /// Parsed style string
    /// </summary>
    private readonly Dictionary<string, string> _propertiesDict = new();

    #region -------- Constructors ----------

    /// <summary>
    /// Initializes a new instance of the <see cref="WinStyleBuilder" /> class.
    /// </summary>
    public WinStyleBuilder()
    {
        InitializeComponent();
    }

    ///// <summary>
    ///// Initializes a new instance of the <see cref="WinStyleBuilder"/> class.
    ///// </summary>
    ///// <param name="styleArg">The style arg.</param>
    ///// <param name="parsingTolerance">The parsing tolerance.</param>
    //public WinStyleBuilder(string styleArg, ParsingTolerence parsingTolerance)
    //{
    //    ParseStyleArgument(styleArg, parsingTolerance);
    //    InitializeComponent();
    //}

    ///// <summary>
    ///// Initializes a new instance of the <see cref="WinStyleBuilder"/> class.
    ///// </summary>
    ///// <param name="styleArg">The style arg.</param>
    //public WinStyleBuilder(string styleArg)
    //{
    //    ParseStyleArgument(styleArg, ParsingTolerence.NoTolerance);
    //    InitializeComponent();
    //}

    #endregion

    /// <summary>
    /// Selects first page on load
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void frmFontSelector_Load(object sender, EventArgs e)
    {
        // Master-detail runtime init (not a design-time default): selecting
        // page 0 and rendering it must happen after construction because the
        // page-loader reflects over the properties dictionary set after
        // InitializeComponent. Kept here deliberately, like a state preload.
        lbPage.SelectedIndex = 0;
        lbPage_SelectedIndexChanged(sender, e);
    }

    /// <summary>
    /// Updates the currenlty visible page
    /// Iternally this method looks up current assembly using reflection for the appropriate page control to be shown
    /// The page control should be marked with FormSelectorPageAttribute and have a constructor which accepts Dictionary&lt;string, string&gt;
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void lbPage_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Dispose currently selector control if any
        if (_selectedPage != null)
        {
            pnlSelectedPage.Controls.Remove(_selectedPage);
            ((IEditorStylePage)_selectedPage).FlushContent();
            _selectedPage.Dispose();
            _selectedPage = null;
        }

        // Check selection and look for the control
        if (lbPage.SelectedItem != null)
        {
            // Name of the page
            string sName = (string)lbPage.SelectedItem;

            // Search this assembly for the appropriate control
            Assembly aThisAssembly = Assembly.GetAssembly(this.GetType());
            foreach (Type t in aThisAssembly.GetTypes())
            {
                Attribute attr = Attribute.GetCustomAttribute(t, typeof(FormSelectorPageAttribute));
                if (attr != null)
                {
                    FormSelectorPageAttribute pageAttr = (FormSelectorPageAttribute)attr;
                    if (pageAttr.PageName == sName)
                    {
                        _selectedPage = (Control)Activator.CreateInstance(t, _propertiesDict);
                        break;
                    }
                }
            }

            // Dummy check
            if (_selectedPage == null)
                throw new NotImplementedException($"Page {sName} is not implemented in Style Page Selector.");

            // add it to the form
            pnlSelectedPage.SuspendLayout();
            pnlSelectedPage.Controls.Add(_selectedPage);
            _selectedPage.Dock = DockStyle.Fill;
            pnlSelectedPage.ResumeLayout();
        }
    }

    /// <summary>
    /// Handles the FormClosed event of the frmFontSelector control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.FormClosedEventArgs" /> instance containing the event data.</param>
    private void frmFontSelector_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (_selectedPage != null)
        {
            pnlSelectedPage.Controls.Remove(_selectedPage);
            ((IEditorStylePage)_selectedPage).FlushContent();
            _selectedPage.Dispose();
            _selectedPage = null;
        }
    }

    /// <summary>
    /// Parses the style argument.
    /// </summary>
    /// <param name="styleArg">The style arg.</param>
    /// <param name="parsingTolerance">The parsing tolerance.</param>
    /// <exception cref="System.ArgumentException">
    /// </exception>
    public void ParseStyleArgument(string styleArg, ParsingTolerance parsingTolerance)
    {
        try
        {
            int position = 0;

            if (string.IsNullOrEmpty(styleArg))
                styleArg = string.Empty;
            styleArg = styleArg.Trim();

            // Handle enclosed quotes
            if (styleArg.Length >= 2 && styleArg[0] == '\"' && styleArg[styleArg.Length - 1] == '\"')
                styleArg = styleArg.Substring(1, styleArg.Length - 2).Trim();

            while (position < styleArg.Length)
            {
                int separatorI = styleArg.IndexOf(':', position);
                if (separatorI != -1) // ':' found
                {
                    // localize tag
                    string tag = styleArg.Substring(position, separatorI - position).Trim().ToLowerInvariant();

                    // localize parameters
                    int nextSemicolonI = styleArg.IndexOf(';', separatorI + 1);
                    if (nextSemicolonI == -1)
                        nextSemicolonI = styleArg.Length;
                    string parameters = styleArg.Substring(separatorI + 1, nextSemicolonI - separatorI - 1).Trim();

                    // store in dictionary
                    _propertiesDict[tag] = parameters;

                    // move starting position
                    position = nextSemicolonI + 1;
                }
                else                 // ':' not found
                {
                    string reminder = styleArg.Substring(position).Trim();
                    if (reminder.Length != 0 && parsingTolerance != ParsingTolerance.TolerateUnknownTags)
                        throw new ArgumentException($"Tag {reminder} has no specification");

                    break;           // no exception was thrown - end parsing
                }
            }

            if (parsingTolerance == ParsingTolerance.NoTolerance)
            {
                // create list of handling classes
                List<FormSelectorPageAttribute> handlingClasses = [];
                Assembly aThisAssembly = Assembly.GetAssembly(this.GetType());
                foreach (Type t in aThisAssembly.GetTypes())
                {
                    Attribute attr = Attribute.GetCustomAttribute(t, typeof(FormSelectorPageAttribute));
                    if (attr != null)
                        handlingClasses.Add((FormSelectorPageAttribute)attr);
                }

                // iterate through tags
                foreach (KeyValuePair<string, string> kvp in _propertiesDict)
                {
                    bool tagHandled = false;
                    // search for a class to handle this attribute
                    foreach (FormSelectorPageAttribute attr in handlingClasses)
                    {
                        if (attr.HandlesTag(kvp.Key))
                        {
                            tagHandled = true;
                            break;
                        }
                    }

                    if (!tagHandled)
                        throw new ArgumentException($"Tag {kvp.Key} can't be handled.");
                }
            }
        }
        catch (Exception err)
        {
            MessageBox.Show(err.Message, @"Error parsing");
        }
    }


    #region ------- Exposed Getters ----------------

    /// <summary>
    /// Gets a value indicating whether [remove style].
    /// </summary>
    /// <value><c>true</c> if [remove style]; otherwise, <c>false</c>.</value>
    public bool RemoveStyle
    {
        get => chkRemoveStyle.Checked;
        set => chkRemoveStyle.Checked = value;
    }

    /// <summary>
    /// Gets the CSS text value.
    /// </summary>
    /// <value>The CSS text value.</value>
    public string CSSTextValue
    {
        get
        {
            // iterate through properties and construct string representation
            StringBuilder sb = new();
            foreach (KeyValuePair<string, string> kvp in _propertiesDict)
            {
                if (kvp.Value.Trim().Length > 0)
                {
                    sb.Append(kvp.Key);
                    sb.Append(": ");
                    sb.Append(kvp.Value);
                    sb.Append("; ");
                }
            }
            return sb.ToString().Trim();
        }
    }

    #endregion

}