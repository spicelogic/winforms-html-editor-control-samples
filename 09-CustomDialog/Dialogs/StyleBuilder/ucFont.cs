using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucFont
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Font", "font;font-family;font-size;text-decoration;font-weight;text-transform;color;font-style;font-variant")]
public partial class ucFont : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    readonly Dictionary<string, string> _dict;

    #region Preset of possible value

    /// <summary>
    /// The _ system fonts
    /// </summary>
    readonly List<KeyValuePair<string, string>> _SystemFonts = [];
    /// <summary>
    /// The _ font style
    /// </summary>
    readonly List<KeyValuePair<string, string>> _FontStyle = [];
    /// <summary>
    /// The _ font variant
    /// </summary>
    readonly List<KeyValuePair<string, string>> _FontVariant = [];
    /// <summary>
    /// The _ bold absolute
    /// </summary>
    readonly List<KeyValuePair<string, string>> _BoldAbsolute = [];
    /// <summary>
    /// The _ bold relative
    /// </summary>
    readonly List<KeyValuePair<string, string>> _BoldRelative = [];
    /// <summary>
    /// The _ text transform
    /// </summary>
    readonly List<KeyValuePair<string, string>> _TextTransform = [];
    #endregion

    /// <summary>
    /// Creates the lists.
    /// </summary>
    protected void CreateLists()
    {
        #region Initialize presets
        _SystemFonts.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _SystemFonts.Add(new KeyValuePair<string, string>("Window caption", "caption"));
        _SystemFonts.Add(new KeyValuePair<string, string>("ToolWindow caption", "small-caption"));
        _SystemFonts.Add(new KeyValuePair<string, string>("Dialog text", "message-box"));
        _SystemFonts.Add(new KeyValuePair<string, string>("Icon labels", "icon"));
        _SystemFonts.Add(new KeyValuePair<string, string>("Menu text", "menu"));
        _SystemFonts.Add(new KeyValuePair<string, string>("Tooltip text", "status-bar"));

        _FontStyle.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _FontStyle.Add(new KeyValuePair<string, string>("Normal", "normal"));
        _FontStyle.Add(new KeyValuePair<string, string>("Italic", "italic"));

        _FontVariant.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _FontVariant.Add(new KeyValuePair<string, string>("Normal", "normal"));
        _FontVariant.Add(new KeyValuePair<string, string>("Small Caps", "small-caps"));

        _BoldAbsolute.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _BoldAbsolute.Add(new KeyValuePair<string, string>("Normal", "normal"));
        _BoldAbsolute.Add(new KeyValuePair<string, string>("Bold", "bold"));

        _BoldRelative.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _BoldRelative.Add(new KeyValuePair<string, string>("Lighter", "lighter"));
        _BoldRelative.Add(new KeyValuePair<string, string>("Bolder", "bolder"));

        _TextTransform.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _TextTransform.Add(new KeyValuePair<string, string>("None", "none"));
        _TextTransform.Add(new KeyValuePair<string, string>("Initial Cap", "capitalize"));
        _TextTransform.Add(new KeyValuePair<string, string>("lowercase", "lowercase"));
        _TextTransform.Add(new KeyValuePair<string, string>("UPPERCASE", "uppercase"));
        #endregion
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ucFont"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucFont(Dictionary<string, string> dict)
    {
        _dict = dict;
        CreateLists();
        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("font-family");
        _dict.Remove("font");
        _dict.Remove("color");
        _dict.Remove("font-style");
        _dict.Remove("font-variant");
        _dict.Remove("font-weight");
        _dict.Remove("font-size");
        _dict.Remove("text-decoration");

        {   // handle text decoration
            StringBuilder sb = new();
            if (cbEffectNone.Checked)
                sb.Append(" none");
            if (cbEffectUnderline.Checked)
                sb.Append(" underline");
            if (cbEffectStrikethrough.Checked)
                sb.Append(" line-through");
            if (cbEffectOverline.Checked)
                sb.Append(" overline");
            _dict["text-decoration"] = sb.ToString();
        }

        _dict["text-transform"] = (string)cbCapitalization.SelectedValue;

        if (rbFamily.Checked)
        {
            _dict["font-family"] = tbFontFamily.Text;

            _dict["color"] = ColorTranslator.ToHtml(txtForeColor.BackColor); // cbColor.Text.ToLowerInvariant();
            _dict["font-style"] = (string)cbFontStyle.SelectedValue;
            _dict["font-variant"] = (string)cbFontVariant.SelectedValue;

            // font-size
            if (rbSizeSpecific.Checked)
            {
                if (tbSpecificSize.Text.Trim().Length > 0)
                    _dict["font-size"] = tbSpecificSize.Text + cbSpecificSizeType.Text;
            }
            else if (rbSizeAbsolute.Checked)
                _dict["font-size"] = cbAbsoluteSize.Text.ToLowerInvariant();
            else
                _dict["font-size"] = cbRelativeSize.Text.ToLowerInvariant();

            // font-weight
            if (rbBoldAbsolute.Checked)
                _dict["font-weight"] = (string)cbBoldAbsolute.SelectedValue;
            else
                _dict["font-weight"] = (string)cbBoldRelative.SelectedValue;
        }

        if (rbSystemFont.Checked)
            _dict["font"] = (string)cbSystemFont.SelectedValue;
    }

    /// <summary>
    /// Handles the Load event of the ucFont control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucFont_Load(object sender, EventArgs e)
    {
        #region set data sources
        cbSystemFont.DataSource = _SystemFonts;
        cbSystemFont.DisplayMember = "Key";
        cbSystemFont.ValueMember = "Value";

        cbFontStyle.DataSource = _FontStyle;
        cbFontStyle.DisplayMember = "Key";
        cbFontStyle.ValueMember = "Value";

        cbFontVariant.DataSource = _FontVariant;
        cbFontVariant.DisplayMember = "Key";
        cbFontVariant.ValueMember = "Value";

        cbBoldAbsolute.DataSource = _BoldAbsolute;
        cbBoldAbsolute.DisplayMember = "Key";
        cbBoldAbsolute.ValueMember = "Value";

        cbBoldRelative.DataSource = _BoldRelative;
        cbBoldRelative.DisplayMember = "Key";
        cbBoldRelative.ValueMember = "Value";

        cbCapitalization.DataSource = _TextTransform;
        cbCapitalization.DisplayMember = "Key";
        cbCapitalization.ValueMember = "Value";
        #endregion

        // Spec 019 FR-009: all radio-group defaults (rbFamily,
        // rbSizeSpecific, rbBoldAbsolute) are serialized in the
        // .designer.cs file. No runtime seeding -- a host customizer who
        // picks a different default in the designer is honored.

        #region parse

        if (_dict.TryGetValue("color", out string value))
        {
            try
            {
                Match theRegex = Regex.Match(value, @"rgb\(([\d]+),([\d]+),([\d]+)\)", RegexOptions.IgnoreCase | RegexOptions.Multiline);

                if (theRegex.Success)
                {
                    int rValue = int.Parse(theRegex.Groups[1].Value);
                    int gValue = int.Parse(theRegex.Groups[2].Value);
                    int bValue = int.Parse(theRegex.Groups[3].Value);

                    txtForeColor.BackColor = Color.FromArgb(rValue, gValue, bValue);
                }
                else
                {
                    txtForeColor.BackColor = ColorTranslator.FromHtml(value);
                }
            }
            catch (ArgumentException)
            {
                // Syntax error in the regular expression
            }
        }

        if (_dict.TryGetValue("font-style", out value))
        {
            for (int i = 0, n = _FontStyle.Count; i < n; ++i)
            {
                if (string.Equals(value, _FontStyle[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbFontStyle.SelectedIndex = i;
                    break;
                }
            }
        }

        if (_dict.TryGetValue("font-size", out value))
        {
            bool handled = false;

            for (int i = 0, n = cbAbsoluteSize.Items.Count; i < n && !handled; ++i)
                if (string.Equals(value, cbAbsoluteSize.Items[i] as string, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbAbsoluteSize.SelectedIndex = i;
                    rbSizeAbsolute.Checked = true;
                    handled = true;
                }

            for (int i = 0, n = cbRelativeSize.Items.Count; i < n && !handled; ++i)
                if (string.Equals(value, cbRelativeSize.Items[i] as string, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbRelativeSize.SelectedIndex = i;
                    rbSizeRelative.Checked = true;
                    handled = true;
                }

            if (!handled)
            {
                rbSizeSpecific.Checked = true;
                for (int i = 0, n = cbSpecificSizeType.Items.Count; i < n && !handled; ++i)
                {
                    string cbSpecificSizeTypeItem = cbSpecificSizeType.Items[i] as string;
                    if (!string.IsNullOrEmpty(cbSpecificSizeTypeItem) && value.EndsWith(cbSpecificSizeTypeItem, StringComparison.InvariantCultureIgnoreCase))
                    {
                        cbSpecificSizeType.SelectedIndex = i;
                        tbSpecificSize.Text = value.Substring(0, value.Length - ((string)cbSpecificSizeType.Items[i]).Length);
                        handled = true;
                    }
                }
            }
        }

        if (_dict.TryGetValue("font-weight", out value))
        {
            bool handled = false;

            for (int i = 0, n = _BoldAbsolute.Count; i < n && !handled; ++i)
            {
                if (string.Equals(value, _BoldAbsolute[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbBoldAbsolute.SelectedIndex = i;
                    rbBoldAbsolute.Checked = true;
                    handled = true;
                }
            }

            for (int i = 0, n = _BoldRelative.Count; i < n && !handled; ++i)
            {
                if (string.Equals(value, _BoldRelative[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbBoldRelative.SelectedIndex = i;
                    rbBoldRelative.Checked = true;
                    handled = true;
                }
            }
        }

        if (_dict.TryGetValue("text-decoration", out value))
        {
            string loValue = value.ToLowerInvariant();
            cbEffectUnderline.Checked = loValue.Contains("underline");
            cbEffectStrikethrough.Checked = loValue.Contains("line-through") || loValue.Contains("linethrough");
            cbEffectOverline.Checked = loValue.Contains("overline");
            cbEffectNone.Checked = loValue.Contains("none");
        }

        if (_dict.TryGetValue("text-transform", out value))
        {
            for (int i = 0, n = _TextTransform.Count; i < n; ++i)
                if (string.Equals(value, _TextTransform[i].Value, StringComparison.InvariantCultureIgnoreCase))
                    cbCapitalization.SelectedIndex = i;
        }

        if (_dict.TryGetValue("font-family", out value))
        {
            rbFamily.Checked = true;
            tbFontFamily.Text = value;
        }

        if (_dict.TryGetValue("font", out value))
        {
            rbSystemFont.Checked = true;

            for (int i = 0, n = _SystemFonts.Count; i < n; ++i)
            {
                if (string.Equals((value ?? "").Replace("-", "").Trim(), _SystemFonts[i].Value.Replace("-", ""), StringComparison.InvariantCultureIgnoreCase))
                {
                    cbSystemFont.SelectedIndex = i;
                    break;
                }
            }
        }
        #endregion
    }

    #region UI handlers
    /// <summary>
    /// Handles the Click event of the btFontFamilySelect control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btFontFamilySelect_Click(object sender, EventArgs e)
    {
        using frmFontPicker subForm = new(tbFontFamily.Text);
        if (subForm.ShowDialog() == DialogResult.OK)
            tbFontFamily.Text = subForm.SelectedFontList;
    }

    /// <summary>
    /// Fonts the type changed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void FontTypeChanged(object sender, EventArgs e)
    {
        tbFontFamily.Enabled = btFontFamilySelect.Enabled = rbFamily.Checked;
        cbSystemFont.Enabled = !rbFamily.Checked;

        cbFontStyle.Enabled = cbFontVariant.Enabled = gbSize.Enabled = gbBold.Enabled = rbFamily.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the rbSizeSpecific control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void rbSizeSpecific_CheckedChanged(object sender, EventArgs e)
    {
        tbSpecificSize.Enabled = cbSpecificSizeType.Enabled = true;
        cbRelativeSize.Enabled = cbAbsoluteSize.Enabled = false;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the rbSizeAbsolute control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void rbSizeAbsolute_CheckedChanged(object sender, EventArgs e)
    {
        cbAbsoluteSize.Enabled = true;
        tbSpecificSize.Enabled = cbSpecificSizeType.Enabled = cbRelativeSize.Enabled = false;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the rbSizeRelative control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void rbSizeRelative_CheckedChanged(object sender, EventArgs e)
    {
        cbRelativeSize.Enabled = true;
        tbSpecificSize.Enabled = cbSpecificSizeType.Enabled = cbAbsoluteSize.Enabled = false;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the cbEffectNone control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbEffectNone_CheckedChanged(object sender, EventArgs e)
    {
        if (cbEffectNone.Checked)
        {
            cbEffectOverline.Checked = cbEffectStrikethrough.Checked = cbEffectUnderline.Checked = false;
            cbEffectOverline.Enabled = cbEffectStrikethrough.Enabled = cbEffectUnderline.Enabled = false;
        }
        else
        {
            cbEffectOverline.Enabled = cbEffectStrikethrough.Enabled = cbEffectUnderline.Enabled = true;
        }
    }

    /// <summary>
    /// Rbs the bold radio button changed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void rbBoldRadioButtonChanged(object sender, EventArgs e)
    {
        cbBoldAbsolute.Enabled = rbBoldAbsolute.Checked;
        cbBoldRelative.Enabled = rbBoldRelative.Checked;
    }
    #endregion

    /// <summary>
    /// Handles the Click event of the txtForeColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void txtForeColor_Click(object sender, EventArgs e)
    {
        if (dlgColorPicker.ShowDialog() == DialogResult.OK)
            txtForeColor.BackColor = dlgColorPicker.Color;
    }
}