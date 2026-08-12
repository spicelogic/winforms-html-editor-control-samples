using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucPosition
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Position", "position,top,left,width,height,z-index")]
public partial class ucPosition : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    readonly Dictionary<string, string> _dict;

    #region Preset of possible values

    /// <summary>
    /// The _ position
    /// </summary>
    readonly List<KeyValuePair<string, string>> _position = [];
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ucPosition"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucPosition(Dictionary<string, string> dict)
    {
        _dict = dict;

        #region Initialize presets
        _position.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _position.Add(new KeyValuePair<string, string>("Position in normal flow", "static"));
        _position.Add(new KeyValuePair<string, string>("Offset from normal flow", "relative"));
        _position.Add(new KeyValuePair<string, string>("Absolutely position", "absolute"));
        #endregion

        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("position");
        _dict.Remove("top");
        _dict.Remove("left");
        _dict.Remove("width");
        _dict.Remove("height");
        _dict.Remove("z-index");

        if (cbPositionMode.SelectedIndex >= 2)
        {
            if (tbLeft.Text.Trim().Length > 0)
                _dict["left"] = tbLeft.Text + cbLeftType.Text;
            if (tbTop.Text.Trim().Length > 0)
                _dict["top"] = tbTop.Text + cbTopType.Text;

            if (cbPositionMode.SelectedIndex == 3)
                _dict["z-index"] = tbZIndex.Text;
        }

        if (tbHeight.Text.Trim().Length > 0)
            _dict["height"] = tbHeight.Text + cbHeightType.Text;
        if (tbWidth.Text.Trim().Length > 0)
            _dict["width"] = tbWidth.Text + cbWidthType.Text;

        _dict["position"] = (string)cbPositionMode.SelectedValue;
    }

    /// <summary>
    /// Handles the Load event of the ucPosition control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucPosition_Load(object sender, EventArgs e)
    {
        #region set data sources
        cbPositionMode.DataSource = _position;
        cbPositionMode.DisplayMember = "Key";
        cbPositionMode.ValueMember = "Value";
        #endregion

        #region parse
        if (_dict.TryGetValue("left", out string value))
        {
            for (int i = 0, n = cbLeftType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbLeftType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    tbLeft.Text = value.Substring(0, value.Length - ((string)cbLeftType.Items[i]).Length);
                    cbLeftType.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("top", out value))
        {
            for (int i = 0, n = cbTopType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbTopType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    tbTop.Text = value.Substring(0, value.Length - ((string)cbTopType.Items[i]).Length);
                    cbTopType.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("width", out value))
        {
            for (int i = 0, n = cbWidthType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbWidthType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    tbWidth.Text = value.Substring(0, value.Length - ((string)cbWidthType.Items[i]).Length);
                    cbWidthType.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("height", out value))
        {
            for (int i = 0, n = cbHeightType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbHeightType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    tbHeight.Text = value.Substring(0, value.Length - ((string)cbHeightType.Items[i]).Length);
                    cbHeightType.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("z-index", out value))
            tbZIndex.Text = value;

        if (_dict.TryGetValue("position", out value))
        {
            for (int i = 0, n = _position.Count; i < n; ++i)
                if (string.Equals(value, _position[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPositionMode.SelectedIndex = i;
                    break;
                }
        }
        #endregion
    }

    #region UI handlers
    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbPositionMode control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbPositionMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbLeft.Enabled = cbLeftType.Enabled = tbTop.Enabled = cbTopType.Enabled = cbPositionMode.SelectedIndex >= 2;

        tbZIndex.Enabled = cbPositionMode.SelectedIndex == 3;
    }
    #endregion
}