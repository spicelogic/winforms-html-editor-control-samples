using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.Abstractions.Entities;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Class TableCellPropertiesDialog
/// </summary>
public partial class TableCellPropertiesDialog : DialogBase, ITableCellDialog
{
    /// <summary>
    /// The _element
    /// </summary>
    private TableCellElement _element;

    private readonly List<string> _propertiesAffected =
    [
        "BgColor",
        "CSSClassName",
        "Width",
        "WidthUnit",
        "Height",
        "HeightUnit",
        "HorizontalAlign",
        "VerticalAlign",
        "NoWrap"
    ];

    /// <summary>
    /// Initializes a new instance of the <see cref="TableCellPropertiesDialog" /> class.
    /// </summary>
    public TableCellPropertiesDialog()
    {
        InitializeComponent();
        this.CancelButton = btnCancel;

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Gets or sets the element.
    /// </summary>
    /// <value>The element.</value>
    public TableCellElement Element
    {
        get
        {
            _element.ResetStyles(this._propertiesAffected);

//                _element.BgColor = chkBgColor.Checked ? ColorTranslator.ToHtml(txtBgColor.BackColor) : null;
            _element.BgColor = chklnkBgColor.Checked ? ColorTranslator.ToHtml(txtBgColor.BackColor) : null;
            _element.CssClassName = txtClassName.Text.Trim();
            _element.CssStyle = txtCss.Text.Trim();

            if (chkWidth.Checked && cmbWidthUnit.SelectedItem != null)
            {
                _element.Width = Convert.ToInt32(txtWidth.Text.Trim());
                _element.WidthUnit = cmbWidthUnit.SelectedItem.ToString();
            }

            if (chkHeight.Checked && cmbHeightUnit.SelectedItem != null)
            {
                _element.Height = Convert.ToInt32(txtHeight.Text.Trim());
                _element.HeightUnit = cmbHeightUnit.SelectedItem.ToString();
            }

            if (cmbHorizontalAlign.SelectedItem != null)
                _element.HorizontalAlign = cmbHorizontalAlign.SelectedItem.ToString();

            if (cmbVerticalAlign.SelectedItem != null)
                _element.VerticalAlign = cmbVerticalAlign.SelectedItem.ToString();
            _element.NoWrap = chkNoWrap.Checked;
            _element.OverrideSettingsToAllCells = chkOverrideSettings4Cells.Checked;
            return _element;
        }
        set
        {
            _element = value;

            if (_element == null)
                return;

            chklnkBgColor.Checked = !string.IsNullOrEmpty(_element.BgColor);
            if (chklnkBgColor.Checked)
            {
                ColorConverter converter = new();
                object convertFromString = converter.ConvertFromString(_element.BgColor);
                if (convertFromString != null)
                    txtBgColor.BackColor = (Color)convertFromString;
            }

            // Spec 019 FR-009: preserve design-time defaults on empty fields.
            if (!string.IsNullOrEmpty(_element.CssClassName))
                txtClassName.Text = _element.CssClassName;
            if (_element.Width.HasValue)
            {
                chkWidth.Checked = true;
                txtWidth.Text = _element.Width.Value.ToString(CultureInfo.InvariantCulture);
                if (_element.WidthUnit != null)
                    cmbWidthUnit.SelectedItem = _element.WidthUnit;
            }

            if (_element.Height.HasValue)
            {
                chkHeight.Checked = true;
                txtHeight.Text = _element.Height.Value.ToString(CultureInfo.InvariantCulture);
                if (_element.HeightUnit != null)
                    cmbHeightUnit.SelectedItem = _element.HeightUnit;
            }

            if (_element.HorizontalAlign != null)
                cmbHorizontalAlign.SelectedItem = _element.HorizontalAlign;

            if (_element.VerticalAlign != null)
                cmbVerticalAlign.SelectedItem = _element.VerticalAlign;
            if (_element.NoWrap)
                chkNoWrap.Checked = true;
            if (_element.OverrideSettingsToAllCells)
                chkOverrideSettings4Cells.Checked = true;

            string cssText = _element.GetCssStyleWithoutProperties(this._propertiesAffected);
            if (!string.IsNullOrEmpty(cssText))
                txtCss.Text = cssText;
        }
    }
    /// <summary>
    /// Gets the cell attribute collection.
    /// </summary>
    /// <value>The cell attribute collection.</value>
    public NameValueCollection CellAttributeCollection
    {
        get
        {
            NameValueCollection myColl = new();

            if (chkWidth.Checked)
                myColl.Add("width", string.Concat(txtWidth.Text.Trim(), cmbWidthUnit.Text.Trim()));

            if (chkHeight.Checked)
                myColl.Add("height", string.Concat(txtHeight.Text.Trim(), cmbHeightUnit.Text.Trim()));

            if (chklnkBgColor.Checked)
                myColl.Add("bgcolor", ColorTranslator.ToHtml(txtBgColor.BackColor));

            if (cmbHorizontalAlign.SelectedIndex != 0)
                myColl.Add("align", cmbHorizontalAlign.Text);

            if (cmbVerticalAlign.SelectedIndex != 0)
                myColl.Add("valign", cmbVerticalAlign.Text);

            if (chkNoWrap.Checked)
                myColl.Add("nowrap", "nowrap");

            return myColl;
        }
    }

    /// <summary>
    /// Gets the table cell attribute string.
    /// </summary>
    /// <value>The table cell attribute string.</value>
    public string TableCellAttributeString
    {
        get
        {
            string[] tableCellAttributes = [];
            string[] tableCellStyleAttributes = [];

            if (chkWidth.Checked)
            {
                Array.Resize(ref tableCellStyleAttributes, tableCellStyleAttributes.Length + 1);
                tableCellStyleAttributes[tableCellStyleAttributes.Length - 1] =
                    $"width: {txtWidth.Text.Trim()}{cmbWidthUnit.Text.Trim()}";
            }

            if (chkHeight.Checked)
            {
                Array.Resize(ref tableCellStyleAttributes, tableCellStyleAttributes.Length + 1);
                tableCellStyleAttributes[tableCellStyleAttributes.Length - 1] =
                    $"height: {txtHeight.Text.Trim()}{cmbHeightUnit.Text.Trim()}";
            }

            if (chklnkBgColor.Checked)
            {
                Array.Resize(ref tableCellStyleAttributes, tableCellStyleAttributes.Length + 1);
                tableCellStyleAttributes[tableCellStyleAttributes.Length - 1] =
                    $"background-color: {ColorTranslator.ToHtml(txtBgColor.BackColor)}";
            }

            if (tableCellStyleAttributes.Length != 0)
            {
                string tableCellStyleText = $"style = \"{string.Join("; ", tableCellStyleAttributes)}\"";
                Array.Resize(ref tableCellAttributes, tableCellAttributes.Length + 1);
                tableCellAttributes[tableCellAttributes.Length - 1] = tableCellStyleText;
            }

            if (cmbHorizontalAlign.SelectedIndex != 0)
            {
                Array.Resize(ref tableCellAttributes, tableCellAttributes.Length + 1);
                tableCellAttributes[tableCellAttributes.Length - 1] = $"align=\"{cmbHorizontalAlign.Text}\"";
            }

            if (cmbVerticalAlign.SelectedIndex != 0)
            {
                Array.Resize(ref tableCellAttributes, tableCellAttributes.Length + 1);
                tableCellAttributes[tableCellAttributes.Length - 1] = $"valign=\"{cmbVerticalAlign.Text}\"";
            }

            if (chkNoWrap.Checked)
            {
                Array.Resize(ref tableCellAttributes, tableCellAttributes.Length + 1);
                tableCellAttributes[tableCellAttributes.Length - 1] = "nowrap=\"nowrap\"";
            }

            if (!string.IsNullOrEmpty(txtClassName.Text.Trim()))
            {
                Array.Resize(ref tableCellAttributes, tableCellAttributes.Length + 1);
                tableCellAttributes[tableCellAttributes.Length - 1] = "class=\"" + txtClassName.Text.Trim() + "\"";
            }

            return string.Join(" ", tableCellAttributes);
        }
    }

    /// <summary>
    /// Get a lock for a property [override cell attributes].
    /// </summary>
    public IDisposable LockOverrideSettingsToAllCells()
    {
        return new lockOverrideSettingsToAllCellsClass(this);
    }

    /// <summary>
    /// Gets a value indicating whether [override cell attributes].
    /// </summary>
    /// <value><c>true</c> if [override cell attributes]; otherwise, <c>false</c>.</value>
    public bool OverrideCellAttributes => chkOverrideSettings4Cells.Checked;

    #region --------------- UI Event Handlers ------------------

    /// <summary>
    /// Handles the CheckedChanged event of the chkWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkWidth_CheckedChanged(object sender, EventArgs e)
    {
        txtWidth.Enabled = chkWidth.Checked;
        cmbWidthUnit.Enabled = chkWidth.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkHeight control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkHeight_CheckedChanged(object sender, EventArgs e)
    {
        txtHeight.Enabled = chkHeight.Checked;
        cmbHeightUnit.Enabled = chkHeight.Checked;
    }

    #endregion

    private class lockOverrideSettingsToAllCellsClass : IDisposable
    {
        private readonly TableCellPropertiesDialog _dialog;
        private readonly bool _initallyEnabled;

        public lockOverrideSettingsToAllCellsClass(TableCellPropertiesDialog dialog)
        {
            _dialog = dialog;
            _initallyEnabled = _dialog.chkOverrideSettings4Cells.Enabled;
            _dialog.chkOverrideSettings4Cells.Enabled = false;
        }

        public void Dispose()
        {
            _dialog.chkOverrideSettings4Cells.Enabled = _initallyEnabled;
        }
    }

    /// <summary>
    /// Handles the LinkClicked event of the chklnkBgColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void chklnkBgColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        showDialogForChoosingColor();
    }

    private void showDialogForChoosingColor()
    {
        using ColorDialog myDialog = new()
        {
            AllowFullOpen = true,
            AnyColor = true,
            Color = this.txtBgColor.BackColor,
            CustomColors = [ColorTranslator.ToOle(this.txtBgColor.BackColor)]
        };
        if (myDialog.ShowDialog() == DialogResult.OK)
            this.txtBgColor.BackColor = myDialog.Color;
    }

    private void TableCellPropertiesDialog_Load(object sender, EventArgs e)
    {

    }
}