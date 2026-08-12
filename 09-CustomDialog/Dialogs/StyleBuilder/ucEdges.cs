using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucEdges
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Edges",
    "margin-top,margin-bottom,margin-left,margin-right,padding-top,padding-bottom,padding-left,padding-right,border-top-style,border-bottom-style,border-left-style,border-right-style")]
public partial class ucEdges : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    private readonly Dictionary<string, string> _dict;

    #region Preset of possible value

    /// <summary>
    /// The _ border top style
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _borderTopStyle = [];

    /// <summary>
    /// The _ border bottom style
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _borderBottomStyle;

    /// <summary>
    /// The _ border left style
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _borderLeftStyle;

    /// <summary>
    /// The _ border right style
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _borderRightStyle;

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ucEdges"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucEdges(Dictionary<string, string> dict)
    {
        _dict = dict;

        #region Initialize presets

        _borderTopStyle.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _borderTopStyle.Add(new KeyValuePair<string, string>("None", "none"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Dotted", "dotted"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Dashed", "dashed"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Solid line", "solid"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Double line", "double"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Groove", "groove"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Ridge", "ridge"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Inset", "inset"));
        _borderTopStyle.Add(new KeyValuePair<string, string>("Outset", "outset"));

        _borderBottomStyle = new List<KeyValuePair<string, string>>(_borderTopStyle);
        _borderLeftStyle = new List<KeyValuePair<string, string>>(_borderTopStyle);
        _borderRightStyle = new List<KeyValuePair<string, string>>(_borderTopStyle);

        #endregion

        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("margin-top");
        _dict.Remove("margin-bottom");
        _dict.Remove("margin-left");
        _dict.Remove("margin-right");
        _dict.Remove("padding-top");
        _dict.Remove("padding-bottom");
        _dict.Remove("padding-left");
        _dict.Remove("padding-right");

        _dict.Remove("border-top-style");
        _dict.Remove("border-bottom-style");
        _dict.Remove("border-left-style");
        _dict.Remove("border-right-style");

        if (tbMTop.Text.Trim().Length > 0)
            _dict["margin-top"] = string.Concat(tbMTop.Text, cbMTopType.Text);
        if (tbMBottom.Text.Trim().Length > 0)
            _dict["margin-bottom"] = string.Concat(tbMBottom.Text, cbMBottomType.Text);
        if (tbMLeft.Text.Trim().Length > 0)
            _dict["margin-left"] = string.Concat(tbMLeft.Text, cbMLeftType.Text);
        if (tbMRight.Text.Trim().Length > 0)
            _dict["margin-right"] = string.Concat(tbMRight.Text, cbMRightType.Text);

        if (tbPTop.Text.Trim().Length > 0)
            _dict["padding-top"] = string.Concat(tbPTop.Text, cbPTopType.Text);
        if (tbPBottom.Text.Trim().Length > 0)
            _dict["padding-bottom"] = string.Concat(tbPBottom.Text, cbPBottomType.Text);
        if (tbPLeft.Text.Trim().Length > 0)
            _dict["padding-left"] = string.Concat(tbPLeft.Text, cbPLeftType.Text);
        if (tbPRight.Text.Trim().Length > 0)
            _dict["padding-right"] = string.Concat(tbPRight.Text, cbPRightType.Text);

        {
            // left border
            StringBuilder sb = new();
            if (cbLeftStyle.SelectedIndex > 0)
            {
                sb.Append((string)cbLeftStyle.SelectedValue);
                sb.Append(' ');

                if (cbLeftWidth.SelectedIndex > 0)
                {
                    if (cbLeftWidth.SelectedIndex == 4)
                    {
                        if (tbLeftWidth.Text.Trim().Length > 0)
                        {
                            sb.Append(string.Concat(tbLeftWidth.Text.Trim(), cbLeftWidthType.Text));
                            sb.Append(' ');
                        }
                    }
                    else
                    {
                        sb.Append(cbLeftWidth.Text.ToLowerInvariant());
                        sb.Append(' ');
                    }
                }

                sb.Append(cbLeftColor.Text.ToLowerInvariant());
            }

            _dict["border-left-style"] = sb.ToString();
        }

        {
            // right border
            StringBuilder sb = new();
            if (cbRightStyle.SelectedIndex > 0)
            {
                sb.Append((string)cbRightStyle.SelectedValue);
                sb.Append(' ');

                if (cbRightWidth.SelectedIndex > 0)
                {
                    if (cbRightWidth.SelectedIndex == 4)
                    {
                        if (tbRightWidth.Text.Trim().Length > 0)
                        {
                            sb.Append(string.Concat(tbRightWidth.Text.Trim(), cbRightWidthType.Text));
                            sb.Append(' ');
                        }
                    }
                    else
                    {
                        sb.Append(cbRightWidth.Text.ToLowerInvariant());
                        sb.Append(' ');
                    }
                }

                sb.Append(cbRightColor.Text.ToLowerInvariant());
            }

            _dict["border-right-style"] = sb.ToString();
        }

        {
            // top border
            StringBuilder sb = new();
            if (cbTopStyle.SelectedIndex > 0)
            {
                sb.Append((string)cbTopStyle.SelectedValue);
                sb.Append(' ');

                if (cbTopWidth.SelectedIndex > 0)
                {
                    if (cbTopWidth.SelectedIndex == 4)
                    {
                        if (tbTopWidth.Text.Trim().Length > 0)
                        {
                            sb.Append(string.Concat(tbTopWidth.Text.Trim(), cbTopWidthType.Text));
                            sb.Append(' ');
                        }
                    }
                    else
                    {
                        sb.Append(cbTopWidth.Text.ToLowerInvariant());
                        sb.Append(' ');
                    }
                }

                sb.Append(cbTopColor.Text.ToLowerInvariant());
            }

            _dict["border-top-style"] = sb.ToString();
        }

        {
            // bottom border
            StringBuilder sb = new();
            if (cbBottomStyle.SelectedIndex > 0)
            {
                sb.Append((string)cbBottomStyle.SelectedValue);
                sb.Append(' ');

                if (cbBottomWidth.SelectedIndex > 0)
                {
                    if (cbBottomWidth.SelectedIndex == 4)
                    {
                        if (tbBottomWidth.Text.Trim().Length > 0)
                        {
                            sb.Append(string.Concat(tbBottomWidth.Text.Trim(), cbBottomWidthType.Text));
                            sb.Append(' ');
                        }
                    }
                    else
                    {
                        sb.Append(cbBottomWidth.Text.ToLowerInvariant());
                        sb.Append(' ');
                    }
                }

                sb.Append(cbBottomColor.Text.ToLowerInvariant());
            }

            _dict["border-bottom-style"] = sb.ToString();
        }
    }

    /// <summary>
    /// Handles the Load event of the ucEdges control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucEdges_Load(object sender, EventArgs e)
    {
        #region set data sources

        cbLeftStyle.DataSource = _borderLeftStyle;
        cbLeftStyle.DisplayMember = "Key";
        cbLeftStyle.ValueMember = "Value";

        cbRightStyle.DataSource = _borderRightStyle;
        cbRightStyle.DisplayMember = "Key";
        cbRightStyle.ValueMember = "Value";

        cbTopStyle.DataSource = _borderTopStyle;
        cbTopStyle.DisplayMember = "Key";
        cbTopStyle.ValueMember = "Value";

        cbBottomStyle.DataSource = _borderBottomStyle;
        cbBottomStyle.DisplayMember = "Key";
        cbBottomStyle.ValueMember = "Value";

        cbLeftWidth.SelectedIndex = 0;
        cbRightWidth.SelectedIndex = 0;
        cbTopWidth.SelectedIndex = 0;
        cbBottomWidth.SelectedIndex = 0;

        #endregion

        #region parse margins

        if (_dict.TryGetValue("margin-top", out var value))
            for (int i = 0, n = cbMTopType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbMTopType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbMTopType.SelectedIndex = i;
                    tbMTop.Text = value.Substring(0, value.Length - ((string)cbMTopType.Items[i]).Length);
                    break;
                }

        if (_dict.TryGetValue("margin-bottom", out value))
            for (int i = 0, n = cbMBottomType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbMBottomType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbMBottomType.SelectedIndex = i;
                    tbMBottom.Text = value.Substring(0, value.Length - ((string)cbMBottomType.Items[i]).Length);
                    break;
                }

        if (_dict.TryGetValue("margin-left", out value))
            for (int i = 0, n = cbMLeftType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbMLeftType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbMLeftType.SelectedIndex = i;
                    tbMLeft.Text = value.Substring(0, value.Length - ((string)cbMLeftType.Items[i]).Length);
                    break;
                }

        if (_dict.TryGetValue("margin-right", out value))
            for (int i = 0, n = cbMRightType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbMRightType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbMRightType.SelectedIndex = i;
                    tbMRight.Text = value.Substring(0, value.Length - ((string)cbMRightType.Items[i]).Length);
                    break;
                }

        #endregion

        #region parse padding

        if (_dict.TryGetValue("padding-top", out value))
            for (int i = 0, n = cbPTopType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbPTopType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPTopType.SelectedIndex = i;
                    tbPTop.Text = value.Substring(0, value.Length - ((string)cbPTopType.Items[i]).Length);
                    break;
                }

        if (_dict.TryGetValue("padding-bottom", out value))
            for (int i = 0, n = cbPBottomType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbPBottomType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPBottomType.SelectedIndex = i;
                    tbPBottom.Text = value.Substring(0, value.Length - ((string)cbPBottomType.Items[i]).Length);
                    break;
                }

        if (_dict.TryGetValue("padding-left", out value))
            for (int i = 0, n = cbPLeftType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbPLeftType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPLeftType.SelectedIndex = i;
                    tbPLeft.Text = value.Substring(0, value.Length - ((string)cbPLeftType.Items[i]).Length);
                    break;
                }

        if (_dict.TryGetValue("padding-right", out value))
            for (int i = 0, n = cbPRightType.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbPRightType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPRightType.SelectedIndex = i;
                    tbPRight.Text = value.Substring(0, value.Length - ((string)cbPRightType.Items[i]).Length);
                    break;
                }

        #endregion

        #region parse left border

        if (_dict.TryGetValue("border-left-style", out value))
        {
            List<string> values = new(value.Split(' '));
            // Filter empty
            for (var i = 0; i < values.Count; ++i)
                if (values[i].Trim().Length == 0)
                {
                    values.RemoveAt(i);
                    --i;
                }

            var styleFound = false;

            for (var valI = 0; valI < values.Count && !styleFound; ++valI)
            {
                value = values[valI];
                for (int i = 0, n = _borderLeftStyle.Count; i < n && !styleFound; ++i)
                    if (string.Equals(value, _borderLeftStyle[i].Value, StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbLeftStyle.SelectedIndex = i;
                        values.RemoveAt(valI);
                        styleFound = true;
                    }
            }

            if (styleFound && cbLeftStyle.SelectedIndex >= 2)
            {
                var widthFound = false;

                for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                {
                    value = values[valI];
                    for (var i = 1; i < 4 && !widthFound; ++i)
                        if (string.Equals(value, (string)cbLeftWidth.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbLeftWidth.SelectedIndex = i;
                            values.RemoveAt(valI);
                            widthFound = true;
                        }
                }

                if (!widthFound)
                    for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                    {
                        value = values[valI];
                        for (int i = 0, n = cbLeftWidthType.Items.Count; i < n && !widthFound; ++i)
                            if (value.EndsWith((string)cbLeftWidthType.Items[i],
                                    StringComparison.InvariantCultureIgnoreCase))
                            {
                                cbLeftWidth.SelectedIndex = 4;
                                cbLeftWidthType.SelectedIndex = i;
                                tbLeftWidth.Text = value.Substring(0,
                                    value.Length - ((string)cbLeftWidthType.Items[i]).Length);
                                values.RemoveAt(valI);
                                widthFound = true;
                            }
                    }

                var colorFound = false;

                for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                {
                    value = values[valI];
                    for (int i = 0, n = cbLeftColor.Items.Count; i < n && !colorFound; ++i)
                        if (string.Equals(value, (string)cbLeftColor.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbLeftColor.SelectedIndex = i;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                }

                if (!colorFound)
                    for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                    {
                        value = values[valI];
                        if (value.StartsWith("#"))
                        {
                            cbLeftColor.Text = value;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                    }
            }
        }

        #endregion

        #region parse Right border

        if (_dict.TryGetValue("border-right-style", out value))
        {
            List<string> values = new(value.Split(' '));
            // Filter empty
            for (var i = 0; i < values.Count; ++i)
                if (values[i].Trim().Length == 0)
                {
                    values.RemoveAt(i);
                    --i;
                }

            var styleFound = false;

            for (var valI = 0; valI < values.Count && !styleFound; ++valI)
            {
                value = values[valI];
                for (int i = 0, n = _borderRightStyle.Count; i < n && !styleFound; ++i)
                    if (string.Equals(value, _borderRightStyle[i].Value, StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbRightStyle.SelectedIndex = i;
                        values.RemoveAt(valI);
                        styleFound = true;
                    }
            }

            if (styleFound && cbRightStyle.SelectedIndex >= 2)
            {
                var widthFound = false;

                for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                {
                    value = values[valI];
                    for (var i = 1; i < 4 && !widthFound; ++i)
                        if (string.Equals(value, (string)cbRightWidth.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbRightWidth.SelectedIndex = i;
                            values.RemoveAt(valI);
                            widthFound = true;
                        }
                }

                if (!widthFound)
                    for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                    {
                        value = values[valI];
                        for (int i = 0, n = cbRightWidthType.Items.Count; i < n && !widthFound; ++i)
                            if (value.EndsWith((string)cbRightWidthType.Items[i],
                                    StringComparison.InvariantCultureIgnoreCase))
                            {
                                cbRightWidth.SelectedIndex = 4;
                                cbRightWidthType.SelectedIndex = i;
                                tbRightWidth.Text = value.Substring(0,
                                    value.Length - ((string)cbRightWidthType.Items[i]).Length);
                                values.RemoveAt(valI);
                                widthFound = true;
                            }
                    }

                var colorFound = false;

                for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                {
                    value = values[valI];
                    for (int i = 0, n = cbRightColor.Items.Count; i < n && !colorFound; ++i)
                        if (string.Equals(value, (string)cbRightColor.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbRightColor.SelectedIndex = i;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                }

                if (!colorFound)
                    for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                    {
                        value = values[valI];
                        if (value.StartsWith("#"))
                        {
                            cbRightColor.Text = value;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                    }
            }
        }

        #endregion

        #region parse Top border

        if (_dict.TryGetValue("border-top-style", out value))
        {
            List<string> values = new(value.Split(' '));
            // Filter empty
            for (var i = 0; i < values.Count; ++i)
                if (values[i].Trim().Length == 0)
                {
                    values.RemoveAt(i);
                    --i;
                }

            var styleFound = false;

            for (var valI = 0; valI < values.Count && !styleFound; ++valI)
            {
                value = values[valI];
                for (int i = 0, n = _borderTopStyle.Count; i < n && !styleFound; ++i)
                    if (string.Equals(value, _borderTopStyle[i].Value, StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbTopStyle.SelectedIndex = i;
                        values.RemoveAt(valI);
                        styleFound = true;
                    }
            }

            if (styleFound && cbTopStyle.SelectedIndex >= 2)
            {
                var widthFound = false;

                for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                {
                    value = values[valI];
                    for (var i = 1; i < 4 && !widthFound; ++i)
                        if (string.Equals(value, (string)cbTopWidth.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbTopWidth.SelectedIndex = i;
                            values.RemoveAt(valI);
                            widthFound = true;
                        }
                }

                if (!widthFound)
                    for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                    {
                        value = values[valI];
                        for (int i = 0, n = cbTopWidthType.Items.Count; i < n && !widthFound; ++i)
                            if (value.EndsWith((string)cbTopWidthType.Items[i],
                                    StringComparison.InvariantCultureIgnoreCase))
                            {
                                cbTopWidth.SelectedIndex = 4;
                                cbTopWidthType.SelectedIndex = i;
                                tbTopWidth.Text = value.Substring(0,
                                    value.Length - ((string)cbTopWidthType.Items[i]).Length);
                                values.RemoveAt(valI);
                                widthFound = true;
                            }
                    }

                var colorFound = false;

                for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                {
                    value = values[valI];
                    for (int i = 0, n = cbTopColor.Items.Count; i < n && !colorFound; ++i)
                        if (string.Equals(value, (string)cbTopColor.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbTopColor.SelectedIndex = i;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                }

                if (!colorFound)
                    for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                    {
                        value = values[valI];
                        if (value.StartsWith("#"))
                        {
                            cbTopColor.Text = value;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                    }
            }
        }

        #endregion

        #region parse Bottom border

        if (_dict.TryGetValue("border-bottom-style", out value))
        {
            List<string> values = new(value.Split(' '));
            // Filter empty
            for (var i = 0; i < values.Count; ++i)
                if (values[i].Trim().Length == 0)
                {
                    values.RemoveAt(i);
                    --i;
                }

            var styleFound = false;

            for (var valI = 0; valI < values.Count && !styleFound; ++valI)
            {
                value = values[valI];
                for (int i = 0, n = _borderBottomStyle.Count; i < n && !styleFound; ++i)
                    if (string.Equals(value, _borderBottomStyle[i].Value, StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbBottomStyle.SelectedIndex = i;
                        values.RemoveAt(valI);
                        styleFound = true;
                    }
            }

            if (styleFound && cbBottomStyle.SelectedIndex >= 2)
            {
                var widthFound = false;

                for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                {
                    value = values[valI];
                    for (var i = 1; i < 4 && !widthFound; ++i)
                        if (string.Equals(value, (string)cbBottomWidth.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbBottomWidth.SelectedIndex = i;
                            values.RemoveAt(valI);
                            widthFound = true;
                        }
                }

                if (!widthFound)
                    for (var valI = 0; valI < values.Count && !widthFound; ++valI)
                    {
                        value = values[valI];
                        for (int i = 0, n = cbBottomWidthType.Items.Count; i < n && !widthFound; ++i)
                            if (value.EndsWith((string)cbBottomWidthType.Items[i],
                                    StringComparison.InvariantCultureIgnoreCase))
                            {
                                cbBottomWidth.SelectedIndex = 4;
                                cbBottomWidthType.SelectedIndex = i;
                                tbBottomWidth.Text = value.Substring(0,
                                    value.Length - ((string)cbBottomWidthType.Items[i]).Length);
                                values.RemoveAt(valI);
                                widthFound = true;
                            }
                    }

                var colorFound = false;

                for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                {
                    value = values[valI];
                    for (int i = 0, n = cbBottomColor.Items.Count; i < n && !colorFound; ++i)
                        if (string.Equals(value, (string)cbBottomColor.Items[i],
                                StringComparison.InvariantCultureIgnoreCase))
                        {
                            cbBottomColor.SelectedIndex = i;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                }

                if (!colorFound)
                    for (var valI = 0; valI < values.Count && !colorFound; ++valI)
                    {
                        value = values[valI];
                        if (value.StartsWith("#"))
                        {
                            cbBottomColor.Text = value;
                            values.RemoveAt(valI);
                            colorFound = true;
                        }
                    }
            }
        }

        #endregion
    }

    #region left border edge handlers

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbLeftWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbLeftWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbLeftWidth.Enabled = cbLeftWidthType.Enabled = cbLeftWidth.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the Click event of the btLeftColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btLeftColor_Click(object sender, EventArgs e)
    {
        if (dlgColor.ShowDialog() == DialogResult.OK)
            cbLeftColor.Text = System.Drawing.ColorTranslator.ToHtml(dlgColor.Color);
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbLeftStyle control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbLeftStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbLeftStyle.SelectedIndex >= 2)
        {
            cbLeftWidth.Enabled = tbLeftWidth.Enabled =
                cbLeftWidthType.Enabled = cbLeftColor.Enabled = btLeftColor.Enabled = true;
            cbLeftWidth_SelectedIndexChanged(this, EventArgs.Empty);
        }
        else
        {
            cbLeftWidth.Enabled = tbLeftWidth.Enabled =
                cbLeftWidthType.Enabled = cbLeftColor.Enabled = btLeftColor.Enabled = false;
        }
    }

    #endregion

    #region Right border edge handlers

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbRightWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbRightWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbRightWidth.Enabled = cbRightWidthType.Enabled = cbRightWidth.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the Click event of the btRightColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btRightColor_Click(object sender, EventArgs e)
    {
        if (dlgColor.ShowDialog() == DialogResult.OK)
            cbRightColor.Text = System.Drawing.ColorTranslator.ToHtml(dlgColor.Color);
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbRightStyle control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbRightStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbRightStyle.SelectedIndex >= 2)
        {
            cbRightWidth.Enabled = tbRightWidth.Enabled =
                cbRightWidthType.Enabled = cbRightColor.Enabled = btRightColor.Enabled = true;
            cbRightWidth_SelectedIndexChanged(this, EventArgs.Empty);
        }
        else
        {
            cbRightWidth.Enabled = tbRightWidth.Enabled =
                cbRightWidthType.Enabled = cbRightColor.Enabled = btRightColor.Enabled = false;
        }
    }

    #endregion

    #region Top border edge handlers

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbTopWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbTopWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbTopWidth.Enabled = cbTopWidthType.Enabled = cbTopWidth.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the Click event of the btTopColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btTopColor_Click(object sender, EventArgs e)
    {
        if (dlgColor.ShowDialog() == DialogResult.OK)
            cbTopColor.Text = System.Drawing.ColorTranslator.ToHtml(dlgColor.Color);
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbTopStyle control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbTopStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbTopStyle.SelectedIndex >= 2)
        {
            cbTopWidth.Enabled = tbTopWidth.Enabled =
                cbTopWidthType.Enabled = cbTopColor.Enabled = btTopColor.Enabled = true;
            cbTopWidth_SelectedIndexChanged(this, EventArgs.Empty);
        }
        else
        {
            cbTopWidth.Enabled = tbTopWidth.Enabled =
                cbTopWidthType.Enabled = cbTopColor.Enabled = btTopColor.Enabled = false;
        }
    }

    #endregion

    #region Bottom border edge handlers

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbBottomWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbBottomWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbBottomWidth.Enabled = cbBottomWidthType.Enabled = cbBottomWidth.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the Click event of the btBottomColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btBottomColor_Click(object sender, EventArgs e)
    {
        if (dlgColor.ShowDialog() == DialogResult.OK)
            cbBottomColor.Text = System.Drawing.ColorTranslator.ToHtml(dlgColor.Color);
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbBottomStyle control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbBottomStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbBottomStyle.SelectedIndex >= 2)
        {
            cbBottomWidth.Enabled = tbBottomWidth.Enabled =
                cbBottomWidthType.Enabled = cbBottomColor.Enabled = btBottomColor.Enabled = true;
            cbBottomWidth_SelectedIndexChanged(this, EventArgs.Empty);
        }
        else
        {
            cbBottomWidth.Enabled = tbBottomWidth.Enabled =
                cbBottomWidthType.Enabled = cbBottomColor.Enabled = btBottomColor.Enabled = false;
        }
    }

    #endregion
}