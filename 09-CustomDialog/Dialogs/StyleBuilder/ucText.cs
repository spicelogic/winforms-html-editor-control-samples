using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucText
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Text", "text-align,vertical-align,text-justify,letter-spacing,line-height,direction,text-indent")]
public partial class ucText : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    readonly Dictionary<string, string> _dict;

    #region Preset of possible values

    /// <summary>
    /// The _ text align
    /// </summary>
    readonly List<KeyValuePair<string, string>> _textAlign = [];
    /// <summary>
    /// The _ vertical align
    /// </summary>
    readonly List<KeyValuePair<string, string>> _verticalAlign = [];
    /// <summary>
    /// The _ text justify
    /// </summary>
    readonly List<KeyValuePair<string, string>> _textJustify = [];
    /// <summary>
    /// The _ letter spacing
    /// </summary>
    readonly List<KeyValuePair<string, string>> _letterSpacing = [];
    /// <summary>
    /// The _ line height
    /// </summary>
    readonly List<KeyValuePair<string, string>> _lineHeight = [];
    /// <summary>
    /// The _ direction
    /// </summary>
    readonly List<KeyValuePair<string, string>> _direction = [];

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ucText"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucText(Dictionary<string, string> dict)
    {
        _dict = dict;

        #region Initialize presets
        _textAlign.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _textAlign.Add(new KeyValuePair<string, string>("Left", "left"));
        _textAlign.Add(new KeyValuePair<string, string>("Center", "center"));
        _textAlign.Add(new KeyValuePair<string, string>("Right", "right"));
        _textAlign.Add(new KeyValuePair<string, string>("Justified", "justify"));

        _verticalAlign.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _verticalAlign.Add(new KeyValuePair<string, string>("baseline", "baseline"));
        _verticalAlign.Add(new KeyValuePair<string, string>("sub", "sub"));
        _verticalAlign.Add(new KeyValuePair<string, string>("super", "super"));
        _verticalAlign.Add(new KeyValuePair<string, string>("top", "top"));
        _verticalAlign.Add(new KeyValuePair<string, string>("text-top", "text-top"));
        _verticalAlign.Add(new KeyValuePair<string, string>("middle", "middle"));
        _verticalAlign.Add(new KeyValuePair<string, string>("bottom", "bottom"));
        _verticalAlign.Add(new KeyValuePair<string, string>("text-bottom", "text-bottom"));

        _textJustify.Add(new KeyValuePair<string, string>("", ""));
        _textJustify.Add(new KeyValuePair<string, string>("Auto", "auto"));
        _textJustify.Add(new KeyValuePair<string, string>("Space words", "inter-word"));
        _textJustify.Add(new KeyValuePair<string, string>("Newspaper style", "newspaper"));
        _textJustify.Add(new KeyValuePair<string, string>("Distribute spacing", "distribute"));
        _textJustify.Add(new KeyValuePair<string, string>("Distribute all lines", "dibtribute-all-lines"));
        _textJustify.Add(new KeyValuePair<string, string>("Inter-cluster", "inter-cluster"));
        _textJustify.Add(new KeyValuePair<string, string>("Inter-ideograph", "inter-ideograph"));
        _textJustify.Add(new KeyValuePair<string, string>("Kashida", "kashida"));

        _letterSpacing.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _letterSpacing.Add(new KeyValuePair<string, string>("Normal", "normal"));
        _letterSpacing.Add(new KeyValuePair<string, string>("Custom", ""));

        _lineHeight.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _lineHeight.Add(new KeyValuePair<string, string>("Normal", "normal"));
        _lineHeight.Add(new KeyValuePair<string, string>("Custom", ""));

        _direction.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _direction.Add(new KeyValuePair<string, string>("Left to right", "ltr"));
        _direction.Add(new KeyValuePair<string, string>("Right to left", "rtl"));
        #endregion

        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        // remove previous entries
        _dict.Remove("text-align");
        _dict.Remove("vertical-align");
        _dict.Remove("text-justify");

        _dict.Remove("letter-spacing");
        _dict.Remove("line-height");

        _dict.Remove("direction");
        _dict.Remove("text-indent");

        // save form's data
        _dict["text-align"] = (string)cbAlHorizontal.SelectedValue;
        if (cbAlHorizontal.SelectedIndex == 4)
            _dict["text-justify"] = (string)cbAlJustification.SelectedValue;
        _dict["vertical-align"] = (string)cbAlVertical.SelectedValue;

        _dict["letter-spacing"] = cbSpacingLetters.SelectedIndex != 2 ? 
            (string)cbSpacingLetters.SelectedValue : 
            tbSpacingLetters.Text + cbSpacingLettersCustom.Text;

        _dict["line-height"] = cbSpacingLines.SelectedIndex != 2 ? 
            (string)cbSpacingLines.SelectedValue : 
            tbSpacingLines.Text + cbSpacingLinesCustom.Text;

        if (tbTextFlowIndentation.Text.Trim().Length > 0)
            _dict["text-indent"] = tbTextFlowIndentation.Text + cbTextFlowCustom.Text;

        _dict["direction"] = (string) cbTextFlowDirection.SelectedValue;
    }

    /// <summary>
    /// Handles the Load event of the ucText control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucText_Load(object sender, EventArgs e)
    {
        #region set data sources
        cbAlHorizontal.DataSource = _textAlign;
        cbAlHorizontal.DisplayMember = "Key";
        cbAlHorizontal.ValueMember = "Value";

        cbAlVertical.DataSource = _verticalAlign;
        cbAlVertical.DisplayMember = "Key";
        cbAlVertical.ValueMember = "Value";

        cbAlJustification.DataSource = _textJustify;
        cbAlJustification.DisplayMember = "Key";
        cbAlJustification.ValueMember = "Value";

        cbSpacingLetters.DataSource = _letterSpacing;
        cbSpacingLetters.DisplayMember = "Key";
        cbSpacingLetters.ValueMember = "Value";

        cbSpacingLines.DataSource = _lineHeight;
        cbSpacingLines.DisplayMember = "Key";
        cbSpacingLines.ValueMember = "Value";

        cbTextFlowDirection.DataSource = _direction;
        cbTextFlowDirection.DisplayMember = "Key";
        cbTextFlowDirection.ValueMember = "Value";
        #endregion

        #region parse alignment
        if (_dict.TryGetValue("vertical-align", out string value))
        {
            for (int i = 0, n = _verticalAlign.Count; i < n; ++i)
                if (string.Equals(value, _verticalAlign[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbAlVertical.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("text-justify", out value))
        {
            for (int i = 0, n = _textJustify.Count; i < n; ++i)
                if (string.Equals(value, _textJustify[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbAlJustification.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("text-align", out value))
        {
            for (int i = 0, n = _textAlign.Count; i < n; ++i)
                if (string.Equals(value, _textAlign[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbAlHorizontal.SelectedIndex = i;
                    break;
                }
        }
        #endregion

        #region parse spacing
        if (_dict.TryGetValue("letter-spacing", out value))
        {
            bool handled = false;

            for (int i = 0, n = _letterSpacing.Count; i < n && !handled; ++i)
                if (value.Equals(_letterSpacing[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbSpacingLetters.SelectedIndex = i;
                    handled = true;
                }

            if (!handled)
            {
                for (int i = 0, n = cbSpacingLettersCustom.Items.Count; i < n; ++i)
                    if (value.EndsWith((string)cbSpacingLettersCustom.Items[i], StringComparison.InvariantCultureIgnoreCase))
                    {
                        tbSpacingLetters.Text = value.Substring(0, value.Length - ((string)cbSpacingLettersCustom.Items[i]).Length);
                        cbSpacingLettersCustom.SelectedIndex = i;
                        cbSpacingLetters.SelectedIndex = 2;
                        break;
                    }
            }
        }

        if (_dict.TryGetValue("line-height", out value))
        {
            bool handled = false;

            for (int i = 0, n = _lineHeight.Count; i < n && !handled; ++i)
                if (value.Equals(_lineHeight[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbSpacingLines.SelectedIndex = i;
                    handled = true;
                }

            if (!handled)
            {
                for (int i = 0, n = cbSpacingLinesCustom.Items.Count; i < n; ++i)
                    if (value.EndsWith((string)cbSpacingLinesCustom.Items[i], StringComparison.InvariantCultureIgnoreCase))
                    {
                        tbSpacingLines.Text = value.Substring(0, value.Length - ((string)cbSpacingLinesCustom.Items[i]).Length);
                        cbSpacingLinesCustom.SelectedIndex = i;
                        cbSpacingLines.SelectedIndex = 2;
                        break;
                    }
            }
        }
        #endregion

        #region parse text flow
        if (_dict.TryGetValue("text-indent", out value))
        {
            for (int i = 0, n = cbTextFlowCustom.Items.Count; i < n; ++i)
                if (value.EndsWith((string)cbTextFlowCustom.Items[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    tbTextFlowIndentation.Text = value.Substring(0, value.Length - ((string)cbTextFlowCustom.Items[i]).Length);
                    cbTextFlowCustom.SelectedIndex = i;
                    break;
                }
        }

        if (_dict.TryGetValue("direction", out value))
        {
            for (int i = 0, n = _direction.Count; i < n; ++i)
                if (value.Equals(_direction[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbTextFlowDirection.SelectedIndex = i;
                    break;
                }
        }
        #endregion
    }

    #region UI handling
    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbAlHorizontal control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbAlHorizontal_SelectedIndexChanged(object sender, EventArgs e)
    {
        cbAlJustification.Enabled = cbAlHorizontal.SelectedIndex == 4;
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbSpacingLetters control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbSpacingLetters_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbSpacingLetters.Enabled = cbSpacingLettersCustom.Enabled = cbSpacingLetters.SelectedIndex == 2;
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the cbSpacingLines control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cbSpacingLines_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbSpacingLines.Enabled = cbSpacingLinesCustom.Enabled = cbSpacingLines.SelectedIndex == 2;
    }
    #endregion
}