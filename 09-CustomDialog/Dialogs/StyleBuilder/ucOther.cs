using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucOther
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Other", "filter,behavior,cursor,border-collapse,table-layout")]
public partial class ucOther : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    readonly Dictionary<string, string> _dict;

    #region Preset of possible values

    /// <summary>
    /// The _ cursor
    /// </summary>
    readonly List<KeyValuePair<string, string>> _cursor = [];
    /// <summary>
    /// The _ border collapse
    /// </summary>
    readonly List<KeyValuePair<string, string>> _borderCollapse = [];
    /// <summary>
    /// The _ table layout
    /// </summary>
    readonly List<KeyValuePair<string, string>> _tableLayout = [];
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ucOther"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucOther(Dictionary<string, string> dict)
    {
        _dict = dict;

        #region Fill presets
        _cursor.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _cursor.Add(new KeyValuePair<string, string>("Auto", "auto"));
        _cursor.Add(new KeyValuePair<string, string>("Default", "default"));
        _cursor.Add(new KeyValuePair<string, string>("Crosshair", "crosshair"));
        _cursor.Add(new KeyValuePair<string, string>("Hand", "hand"));
        _cursor.Add(new KeyValuePair<string, string>("Move", "move"));
        _cursor.Add(new KeyValuePair<string, string>("Top resize", "n-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Bottom resize", "s-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Left resize", "w-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Right resize", "e-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Top-left resize", "nw-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Bottom-left resize", "sw-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Top-right resize", "ne-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Bottom-right resize", "se-resize"));
        _cursor.Add(new KeyValuePair<string, string>("Text", "text"));
        _cursor.Add(new KeyValuePair<string, string>("Hourglass", "wait"));
        _cursor.Add(new KeyValuePair<string, string>("Help", "help"));

        _borderCollapse.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _borderCollapse.Add(new KeyValuePair<string, string>("Separate cell borders", "separate"));
        _borderCollapse.Add(new KeyValuePair<string, string>("Collapse cell borders", "collapse"));

        _tableLayout.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _tableLayout.Add(new KeyValuePair<string, string>("Auto", "auto"));
        _tableLayout.Add(new KeyValuePair<string, string>("Fixed layout", "fixed"));
        #endregion

        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("filter");
        _dict.Remove("behavior");

        _dict["cursor"] = (string)cbCursor.SelectedValue;
        _dict["border-collapse"] = (string)cbBorders.SelectedValue;
        _dict["table-layout"] = (string)cbLayout.SelectedValue;

        if (tbFilter.Text.Trim().Length > 0)
            _dict["filter"] = tbFilter.Text;
        if (tbURL.Text.Trim().Length > 0)
            _dict["behavior"] = $"url({tbURL.Text})";
    }

    /// <summary>
    /// Handles the Load event of the ucOther control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucOther_Load(object sender, EventArgs e)
    {
        #region set data sources
        cbCursor.DataSource = _cursor;
        cbCursor.DisplayMember = "Key";
        cbCursor.ValueMember = "Value";

        cbBorders.DataSource = _borderCollapse;
        cbBorders.DisplayMember = "Key";
        cbBorders.ValueMember = "Value";

        cbLayout.DataSource = _tableLayout;
        cbLayout.DisplayMember = "Key";
        cbLayout.ValueMember = "Value";
        #endregion

        #region parse
        if (_dict.TryGetValue("cursor", out string value))
        {
            for (int i = 0, n = _cursor.Count; i < n; ++i)
                if (string.Equals(value, _cursor[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbCursor.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("border-collapse", out value))
        {
            for (int i = 0, n = _borderCollapse.Count; i < n; ++i)
                if (string.Equals(value, _borderCollapse[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbBorders.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("table-layout", out value))
        {
            for (int i = 0, n = _tableLayout.Count; i < n; ++i)
                if (string.Equals(value, _tableLayout[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbLayout.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("filter", out value))
        {
            tbFilter.Text = value;
        }

        if (_dict.TryGetValue("behavior", out value))
        {
            if (value.StartsWith("url(", StringComparison.InvariantCultureIgnoreCase) && value.EndsWith(")"))
            {
                tbURL.Text = value.Substring(4, value.Length - 5);
            }
        }
        #endregion
    }
}