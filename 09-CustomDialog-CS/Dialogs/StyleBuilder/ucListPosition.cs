using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucLists
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("List Position", "list-style-position")]
public partial class ucListPosition : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    readonly Dictionary<string, string> _dict;

    #region Preset of possible values

    /// <summary>
    /// The _ list style position
    /// </summary>
    readonly List<KeyValuePair<string, string>> _listStylePosition = [];
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ucListPosition"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucListPosition(Dictionary<string, string> dict)
    {
        _dict = dict;

        #region Initialize presets
        _listStylePosition.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _listStylePosition.Add(new KeyValuePair<string, string>("Outside (text is indented in)", "outside"));
        _listStylePosition.Add(new KeyValuePair<string, string>("Inside (text is not indented)", "inside"));
        #endregion

        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("list-style-position");
        _dict["list-style-position"] = (string)cbBulletPosition.SelectedValue;
    }

    /// <summary>
    /// Handles the Load event of the ucLists control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucLists_Load(object sender, EventArgs e)
    {
        #region set data sources
            
        cbBulletPosition.DataSource = _listStylePosition;
        cbBulletPosition.DisplayMember = "Key";
        cbBulletPosition.ValueMember = "Value";
            
        #endregion


        #region parse
            
        if (_dict.TryGetValue("list-style-position", out var value))
        {
            for (int i = 0, n = _listStylePosition.Count; i < n; ++i)
                if (string.Equals(value, _listStylePosition[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbBulletPosition.SelectedIndex = i;
                    break;
                }
        }

        #endregion
    }

}