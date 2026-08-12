using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucBackground
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Background", "background-color,background-image,background-repeat,background-attachment,background-position-x,background-position-y")]
public partial class ucBackground : UserControl, IEditorStylePage
{
    #region Preset of possible values

    /// <summary>
    /// The _ bg repeat
    /// </summary>
    readonly List<KeyValuePair<string, string>> _bgRepeat = [];
    /// <summary>
    /// The _ bg attachment
    /// </summary>
    readonly List<KeyValuePair<string, string>> _bgAttachment = [];
    /// <summary>
    /// The _ bg position X
    /// </summary>
    readonly List<KeyValuePair<string, string>> _bgPositionX = [];
    /// <summary>
    /// The _ bg position Y
    /// </summary>
    readonly List<KeyValuePair<string, string>> _bgPositionY = [];
    #endregion

    /// <summary>
    /// The _dict
    /// </summary>
    readonly Dictionary<string, string> _dict;

    /// <summary>
    /// Initializes a new instance of the <see cref="ucBackground"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucBackground(Dictionary<string, string> dict)
    {
        #region Initialize presets
        _bgRepeat.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _bgRepeat.Add(new KeyValuePair<string, string>("Tile in horizontal direction", "repeat-x"));
        _bgRepeat.Add(new KeyValuePair<string, string>("Tile in vertical direction", "repeat-y"));
        _bgRepeat.Add(new KeyValuePair<string, string>("Tile in both directions", "repeat"));
        _bgRepeat.Add(new KeyValuePair<string, string>("Do not tile", "no-repeat"));

        _bgAttachment.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _bgAttachment.Add(new KeyValuePair<string, string>("Scrolling background", "scroll"));
        _bgAttachment.Add(new KeyValuePair<string, string>("Fixed background", "fixed"));

        _bgPositionX.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _bgPositionX.Add(new KeyValuePair<string, string>("Left", "left"));
        _bgPositionX.Add(new KeyValuePair<string, string>("Center", "center"));
        _bgPositionX.Add(new KeyValuePair<string, string>("Right", "right"));
        _bgPositionX.Add(new KeyValuePair<string, string>("Custom", ""));

        _bgPositionY.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _bgPositionY.Add(new KeyValuePair<string, string>("Top", "top"));
        _bgPositionY.Add(new KeyValuePair<string, string>("Center", "center"));
        _bgPositionY.Add(new KeyValuePair<string, string>("Bottom", "bottom"));
        _bgPositionY.Add(new KeyValuePair<string, string>("Custom", ""));
        #endregion

        _dict = dict;
        InitializeComponent();
    }

    /// <summary>
    /// Handles the Load event of the ucBackground control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucBackground_Load(object sender, EventArgs e)
    {
        cbTiling.DataSource = _bgRepeat;
        cbTiling.DisplayMember = "Key";
        cbTiling.ValueMember = "Value";

        cbScrolling.DataSource = _bgAttachment;
        cbScrolling.DisplayMember = "Key";
        cbScrolling.ValueMember = "Value";

        cbHorizontal.DataSource = _bgPositionX;
        cbHorizontal.DisplayMember = "Key";
        cbHorizontal.ValueMember = "Value";

        cbVertical.DataSource = _bgPositionY;
        cbVertical.DisplayMember = "Key";
        cbVertical.ValueMember = "Value";

        if (_dict.TryGetValue("background-color", out string value))
        {
            if ((value ?? "").Trim().Equals("transparent", StringComparison.InvariantCultureIgnoreCase))
                cbBgColorTransparent.Checked = true;
            else
            {
                txtBgColor.BackColor = ColorTranslator.FromHtml(value);
                cbBgColorTransparent.Checked = false;
            }
        }

        if (_dict.TryGetValue("background-repeat", out value))
        {
            string val = value.Trim().ToLowerInvariant();
            for (int i = 0; i < _bgRepeat.Count; ++i)
            {
                if (string.Equals(val, _bgRepeat[i].Value))
                {
                    cbTiling.SelectedIndex = i;
                    break;
                }
            }
        }

        if (_dict.TryGetValue("background-attachment", out value))
        {
            string val = value.Trim().ToLowerInvariant();
            for (int i = 0; i < _bgAttachment.Count; ++i)
            {
                if (string.Equals(val, _bgAttachment[i].Value))
                {
                    cbScrolling.SelectedIndex = i;
                    break;
                }
            }
        }

        if (_dict.TryGetValue("background-position-x", out value))
        {
            bool handled = false;

            for (int i = 0; i < _bgPositionX.Count && !handled; ++i)
                if (string.Equals(value, _bgPositionX[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbHorizontal.SelectedIndex = i;
                    handled = true;
                }

            if (!handled)
            {
                for (int i = 0; i < cbHorCustType.Items.Count; ++i)
                {
                    if (value.EndsWith((string)cbHorCustType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbHorizontal.SelectedIndex = 4; // Custom
                        cbHorCustType.SelectedIndex = i;
                        tbHorCust.Text = value.Substring(0, value.Length - ((string)cbHorCustType.Items[i]).Length);
                        break;
                    }
                }
            }
        }

        if (_dict.TryGetValue("background-position-y", out value))
        {
            bool handled = false;

            for (int i = 0; i < _bgPositionY.Count && !handled; ++i)
            {
                if (string.Equals(value, _bgPositionY[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbVertical.SelectedIndex = i;
                    handled = true;
                }
            }

            if (!handled)
            {
                for (int i = 0; i < cbVerCustType.Items.Count; ++i)
                {
                    if (value.EndsWith((string)cbVerCustType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbVertical.SelectedIndex = 4; // Custom
                        cbVerCustType.SelectedIndex = i;
                        tbVerCust.Text = value.Substring(0, value.Length - ((string)cbVerCustType.Items[i]).Length);
                        break;
                    }
                }
            }
        }

        if (_dict.TryGetValue("background-image", out value))
        {
            if ((value ?? "").Trim().Equals("none", StringComparison.InvariantCultureIgnoreCase))
                cbDoNotUseBackground.Checked = true;
            else
            {
                cbDoNotUseBackground.Checked = false;
                try
                {
                    tbBgImage.Text = Regex.Match(value, @"url\((.+?)\)", RegexOptions.IgnoreCase).Groups[1].Value;
                }
                catch 
                {
                    tbBgImage.Text = value;
                }
            }
        }
        else
            tbBgImage_TextChanged(this, EventArgs.Empty);
    }

    #region UI handling
    /// <summary>
    /// Handles the CheckedChanged event of the cbBgColorTransparent control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbBgColorTransparent_CheckedChanged(object sender, EventArgs e)
    {
        txtBgColor.Enabled = !cbBgColorTransparent.Checked;
    }

    /// <summary>
    /// Handles the TextChanged event of the tbBgImage control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void tbBgImage_TextChanged(object sender, EventArgs e)
    {
        cbTiling.Enabled = cbScrolling.Enabled = gbPosition.Enabled = tbBgImage.Text.Trim().Length > 0;
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbHorizontal control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbHorizontal_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbHorCust.Enabled = cbHorCustType.Enabled = cbHorizontal.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbVertical control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbVertical_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbVerCust.Enabled = cbVerCustType.Enabled = cbVertical.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the cbDoNotUseBackground control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbDoNotUseBackground_CheckedChanged(object sender, EventArgs e)
    {
        if (cbDoNotUseBackground.Checked)
            tbBgImage.Enabled = btChooseBgImage.Enabled = cbTiling.Enabled = cbScrolling.Enabled = gbPosition.Enabled = false;
        else
        {
            tbBgImage.Enabled = btChooseBgImage.Enabled = cbTiling.Enabled = cbScrolling.Enabled = gbPosition.Enabled = true;
            tbBgImage_TextChanged(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Handles the Click event of the btChooseBgImage control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btChooseBgImage_Click(object sender, EventArgs e)
    {
        if (dlgBgImage.ShowDialog() == DialogResult.OK)
            tbBgImage.Text = dlgBgImage.FileName;
    }
    #endregion

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("background-color");
        _dict.Remove("background-image");
        _dict.Remove("background-repeat");
        _dict.Remove("background-attachment");
        _dict.Remove("background-position-x");
        _dict.Remove("background-position-y");

        _dict["background-color"] = cbBgColorTransparent.Checked ? "transparent" : ColorTranslator.ToHtml(txtBgColor.BackColor);

        if (cbDoNotUseBackground.Checked)
            _dict["background-image"] = "none";
        else
        {
            _dict["background-image"] = string.IsNullOrEmpty(tbBgImage.Text.Trim()) ? string.Empty : $"url({tbBgImage.Text.Trim()})";
            _dict["background-repeat"] = (string)cbTiling.SelectedValue;
            _dict["background-attachment"] = (string)cbScrolling.SelectedValue;

            if (cbHorizontal.SelectedIndex != 4)
                _dict["background-position-x"] = (string)cbHorizontal.SelectedValue;
            else
                _dict["background-position-x"] = tbHorCust.Text + cbHorCustType.Text;

            if (cbVertical.SelectedIndex != 4)
                _dict["background-position-y"] = (string)cbVertical.SelectedValue;
            else
                _dict["background-position-y"] = tbVerCust.Text + cbVerCustType.Text;
        }
    }

    /// <summary>
    /// Handles the Click event of the txtBgColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void txtBgColor_Click(object sender, EventArgs e)
    {
        if (dlgColorPicker.ShowDialog() == DialogResult.OK)
            txtBgColor.BackColor = dlgColorPicker.Color;
    }

}