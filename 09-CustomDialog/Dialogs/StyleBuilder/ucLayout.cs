using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Class ucLayout
/// </summary>
[ToolboxItem(false)]
[FormSelectorPage("Layout", "clip,visibility,display,float,clear,overflow,page-break-before,page-break-after")]
public partial class ucLayout : UserControl, IEditorStylePage
{
    /// <summary>
    /// The _dict
    /// </summary>
    private readonly Dictionary<string, string> _dict;

    #region Preset of possible value

    /// <summary>
    /// The _ visibility
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _visibility = [];

    /// <summary>
    /// The _ display
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _display = [];

    /// <summary>
    /// The _ float
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _float = [];

    /// <summary>
    /// The _ clear
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _clear = [];

    /// <summary>
    /// The _ overflow
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _overflow = [];

    /// <summary>
    /// The _ page break before
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _pageBreakBefore = [];

    /// <summary>
    /// The _ page break after
    /// </summary>
    private readonly List<KeyValuePair<string, string>> _pageBreakAfter;

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ucLayout"/> class.
    /// </summary>
    /// <param name="dict">The dict.</param>
    public ucLayout(Dictionary<string, string> dict)
    {
        _dict = dict;

        #region Fill lists

        _visibility.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _visibility.Add(new KeyValuePair<string, string>("Hidden", "hidden"));
        _visibility.Add(new KeyValuePair<string, string>("Visible", "visible"));

        _display.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _display.Add(new KeyValuePair<string, string>("Do not display", "none"));
        _display.Add(new KeyValuePair<string, string>("As a block element", "block"));
        _display.Add(new KeyValuePair<string, string>("As an inflow element", "inline"));

        _float.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _float.Add(new KeyValuePair<string, string>("Don't allow text on sides", "none"));
        _float.Add(new KeyValuePair<string, string>("To the right", "right"));
        _float.Add(new KeyValuePair<string, string>("To the left", "left"));

        _clear.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _clear.Add(new KeyValuePair<string, string>("On either side", "none"));
        _clear.Add(new KeyValuePair<string, string>("Only on right", "right"));
        _clear.Add(new KeyValuePair<string, string>("Only on left", "left"));
        _clear.Add(new KeyValuePair<string, string>("Do not allow", "both"));

        _overflow.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _overflow.Add(new KeyValuePair<string, string>("Use scrollbars if needed", "auto"));
        _overflow.Add(new KeyValuePair<string, string>("Always use scrollbars", "scroll"));
        _overflow.Add(new KeyValuePair<string, string>("Content is not clipped", "visible"));
        _overflow.Add(new KeyValuePair<string, string>("Content is clipped", "hidden"));

        _pageBreakBefore.Add(new KeyValuePair<string, string>("<Not Set>", ""));
        _pageBreakBefore.Add(new KeyValuePair<string, string>("Auto", "auto"));
        _pageBreakBefore.Add(new KeyValuePair<string, string>("Force a page break", "always"));
        _pageBreakBefore.Add(new KeyValuePair<string, string>("No page break", "avoid"));
        _pageBreakBefore.Add(new KeyValuePair<string, string>("Until a blank left page", "left"));
        _pageBreakBefore.Add(new KeyValuePair<string, string>("Until a blank right page", "right"));

        _pageBreakAfter = new List<KeyValuePair<string, string>>(_pageBreakBefore);

        #endregion

        InitializeComponent();
    }

    /// <summary>
    /// Flushes the content of the user control back to the dictionary
    /// </summary>
    public void FlushContent()
    {
        _dict.Remove("clip");

        _dict["visibility"] = (string)cbVisibility.SelectedValue;
        _dict["display"] = (string)cbDisplay.SelectedValue;
        _dict["float"] = (string)cbAllowFloatingObject.SelectedValue;
        _dict["clear"] = (string)cbAllowTextToFlow.SelectedValue;
        _dict["overflow"] = (string)cbOverflow.SelectedValue;
        _dict["page-break-before"] = (string)cbPbBefore.SelectedValue;
        _dict["page-break-after"] = (string)cbPbAfter.SelectedValue;

        {
            // clip
            var top = tbTop.Text.Trim();
            var right = tbRight.Text.Trim();
            var bottom = tbBottom.Text.Trim();
            var left = tbLeft.Text.Trim();

            if (top.Length + right.Length + bottom.Length + left.Length > 0)
            {
                // fix values if any
                top = top.Length == 0 ? "auto" : top + cbTopType.Text;

                right = right.Length == 0 ? "auto" : right + cbRightType.Text;

                bottom = bottom.Length == 0 ? "auto" : bottom + cbBottomType.Text;

                left = left.Length == 0 ? "auto" : left + cbLeftType.Text;

                // store to the dictionary
                _dict["clip"] = $"rect({top} {right} {bottom} {left})";
            }
        }
    }

    /// <summary>
    /// Handles the Load event of the ucLayout control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ucLayout_Load(object sender, EventArgs e)
    {
        #region set data sources

        cbVisibility.DataSource = _visibility;
        cbVisibility.DisplayMember = "Key";
        cbVisibility.ValueMember = "Value";

        cbDisplay.DataSource = _display;
        cbDisplay.DisplayMember = "Key";
        cbDisplay.ValueMember = "Value";

        cbAllowTextToFlow.DataSource = _float;
        cbAllowTextToFlow.DisplayMember = "Key";
        cbAllowTextToFlow.ValueMember = "Value";

        cbAllowFloatingObject.DataSource = _clear;
        cbAllowFloatingObject.DisplayMember = "Key";
        cbAllowFloatingObject.ValueMember = "Value";

        cbOverflow.DataSource = _overflow;
        cbOverflow.DisplayMember = "Key";
        cbOverflow.ValueMember = "Value";

        cbPbBefore.DataSource = _pageBreakBefore;
        cbPbBefore.DisplayMember = "Key";
        cbPbBefore.ValueMember = "Value";

        cbPbAfter.DataSource = _pageBreakAfter;
        cbPbAfter.DisplayMember = "Key";
        cbPbAfter.ValueMember = "Value";

        #endregion

        #region parse dictionary's values

        if (_dict.TryGetValue("overflow", out var value))
            for (int i = 0, n = _overflow.Count; i < n; ++i)
                if (string.Equals(value, _overflow[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbOverflow.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("visibility", out value))
            for (int i = 0, n = _visibility.Count; i < n; ++i)
                if (string.Equals(value, _visibility[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbVisibility.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("display", out value))
            for (int i = 0, n = _display.Count; i < n; ++i)
                if (string.Equals(value, _display[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbDisplay.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("float", out value))
            for (int i = 0, n = _float.Count; i < n; ++i)
                if (string.Equals(value, _float[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbAllowTextToFlow.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("clear", out value))
            for (int i = 0, n = _clear.Count; i < n; ++i)
                if (string.Equals(value, _clear[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbAllowFloatingObject.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("page-break-before", out value))
            for (int i = 0, n = _pageBreakBefore.Count; i < n; ++i)
                if (string.Equals(value, _pageBreakBefore[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPbBefore.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("page-break-after", out value))
            for (int i = 0, n = _pageBreakAfter.Count; i < n; ++i)
                if (string.Equals(value, _pageBreakAfter[i].Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    cbPbAfter.SelectedIndex = i;
                    break;
                }

        if (_dict.TryGetValue("clip", out value))
            if (value.StartsWith("rect(", StringComparison.InvariantCultureIgnoreCase) && value.EndsWith(")"))
            {
                var inner = value.Substring(5, value.Length - 6);
                var parts = inner.Split(' ');
                if (parts.Length >= 4)
                {
                    var top = parts[0];
                    var right = parts[1];
                    var bottom = parts[2];
                    var left = parts[3];

                    for (int i = 0, n = cbTopType.Items.Count; i < n; ++i)
                        if (top.EndsWith((string)cbTopType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                        {
                            tbTop.Text = top.Substring(0, top.Length - ((string)cbTopType.Items[i]).Length);
                            cbTopType.SelectedIndex = i;
                            break;
                        }

                    for (int i = 0, n = cbRightType.Items.Count; i < n; ++i)
                        if (right.EndsWith((string)cbRightType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                        {
                            tbRight.Text = right.Substring(0, right.Length - ((string)cbRightType.Items[i]).Length);
                            cbRightType.SelectedIndex = i;
                            break;
                        }

                    for (int i = 0, n = cbBottomType.Items.Count; i < n; ++i)
                        if (bottom.EndsWith((string)cbBottomType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                        {
                            tbBottom.Text = bottom.Substring(0, bottom.Length - ((string)cbBottomType.Items[i]).Length);
                            cbBottomType.SelectedIndex = i;
                            break;
                        }

                    for (int i = 0, n = cbLeftType.Items.Count; i < n; ++i)
                        if (left.EndsWith((string)cbLeftType.Items[i], StringComparison.InvariantCultureIgnoreCase))
                        {
                            tbLeft.Text = left.Substring(0, left.Length - ((string)cbLeftType.Items[i]).Length);
                            cbLeftType.SelectedIndex = i;
                            break;
                        }
                }
            }

        #endregion
    }
}