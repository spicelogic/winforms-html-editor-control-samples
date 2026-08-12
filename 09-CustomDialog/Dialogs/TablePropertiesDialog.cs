using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.Abstractions.Entities;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Class TablePropertiesDialog
/// </summary>
public partial class TablePropertiesDialog : DialogBase, ITableDialog
{
    /// <summary>
    /// The _element
    /// </summary>
    private TableElement _element;
    /// <summary>
    /// The _table cell dialog
    /// </summary>
    private readonly ITableCellDialog _tableCellDialog;
    /// <summary>
    /// The _background picture URL
    /// </summary>
    private string _backgroundPictureUrl = string.Empty;

    private readonly List<string> _propertiesAffected =
    [
        "Rows",
        "Columns",
        "Width",
        "Height",
        "Caption",
        "BorderWidth",
        "CellPadding",
        "CellSpacing",
        "BorderColor",
        "BorderAttr",
        "BorderStyle",
        "BgColor",
        "BorderCollapse",
        "SummaryDescription",
        "ID",
        "Name",
        "CSSClassName",
        "BackGround"
    ];

    /// <summary>
    /// Initializes a new instance of the <see cref="TablePropertiesDialog" /> class.
    /// </summary>
    /// <param name="cellDialog">The cell dialog.</param>
    public TablePropertiesDialog(ITableCellDialog cellDialog)
    {
        InitializeComponent();
        // Spec 019 FR-009: cmbBorderStyle.SelectedIndex = 0 moved to the
        // .designer.cs file -- design-time serialization, no runtime override.
        this._tableCellDialog = cellDialog;
        this.CancelButton = btnCancel;

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Handles the Load event of the TablePropertiesDialog control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void TablePropertiesDialog_Load(object sender, EventArgs e)
    {
        btnCellProperties.Visible = this.getOrInitCellElement() != null;
    }

    /// <summary>
    /// Gets or sets the element.
    /// </summary>
    /// <value>The element.</value>
    public TableElement Element
    {
        get
        {
            if (_element == null)
                _element = new TableElement(null);

            _element.ResetValues(this._propertiesAffected);

            _element.Rows = (int)numRows.Value;
            _element.Columns = (int)numCols.Value;

            if (chkCellPadding.Checked)
                _element.CellPadding = (int)numCellPadding.Value;
            if (chkCellSpacing.Checked)
                _element.CellSpacing = (int)numCellSpacing.Value;

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

            if (chkCaption.Checked)
                _element.Caption = txtCaption.Text.Trim();

            if (chkBorderWidth.Checked)
            {
                if (chkBorderStyle.Checked && cmbBorderStyle.SelectedItem != null)
                {
                    _element.BorderStyle = cmbBorderStyle.SelectedItem.ToString();
                    _element.BorderWidth = (int)numBorderWidth.Value;
                }
                else
                    _element.BorderAttr = (int)numBorderWidth.Value;
            }

            if (chklnkBorderColor.Enabled && chklnkBorderColor.Checked)
                _element.BorderColor = ColorTranslator.ToHtml(txtBorderColor.BackColor);

            if (chklnkBgColor.Checked)
                _element.BgColor = ColorTranslator.ToHtml(txtBgColor.BackColor);

            _element.SummaryDescription = txtSummaryDescription.Text;
            _element.BorderCollapse = chkBorderCollapse.Enabled && chkBorderCollapse.Checked;
            _element.Id = txtId.Text.Trim();
            _element.Name = txtName.Text.Trim();
            _element.CssClassName = txtClassName.Text.Trim();
            _element.CssStyle = txtCss.Text.Trim();

            if (chklnkBackgroundPicture.Checked)
                _element.BackGround = pbBackgroundPicture.ImageLocation;

            _element.BorderToAll = chkBorderToAll.Checked;

            return _element;
        }
        set
        {
            _element = value;
            if (_element == null)
                return;

            // Spec 019 FR-009: every element→UI assignment is gated on the
            // element carrying data, so design-time defaults survive otherwise.
            if (_element.Rows > 0)
                numRows.Value = _element.Rows;
            if (_element.Columns > 0)
                numCols.Value = _element.Columns;

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

            if (!string.IsNullOrEmpty(_element.Caption))
            {
                chkCaption.Checked = true;
                txtCaption.Text = _element.Caption;
            }

            if (_element.BorderWidth.HasValue || _element.BorderAttr.HasValue)
                chkBorderWidth.Checked = true;

            if (!string.IsNullOrEmpty(_element.BorderStyle))
            {
                chkBorderStyle.Checked = true;
                cmbBorderStyle.Enabled = true;
                chkBorderCollapse.Enabled = true;
                chklnkBorderColor.Enabled = true;
                this.txtBorderColor.Enabled = this.chklnkBorderColor.Checked;
                cmbBorderStyle.Text = _element.BorderStyle;
                if (chkBorderWidth.Checked)
                    numBorderWidth.Value = _element.BorderWidth ?? 0;
            }
            else if (chkBorderWidth.Checked)
            {
                numBorderWidth.Value = _element.BorderAttr ?? (_element.BorderWidth ?? 0);
            }

            if (_element.CellPadding.HasValue)
            {
                chkCellPadding.Checked = true;
                numCellPadding.Value = _element.CellPadding.Value;
            }

            if (_element.CellSpacing.HasValue)
            {
                chkCellSpacing.Checked = true;
                numCellSpacing.Value = _element.CellSpacing.Value;
            }

            if (!string.IsNullOrEmpty(_element.BorderColor))
            {
                chklnkBorderColor.Checked = true;
                ColorConverter converter = new();
                txtBorderColor.BackColor = (Color)converter.ConvertFromString(_element.BorderColor);
            }

            if (!string.IsNullOrEmpty(_element.BgColor))
            {
                chklnkBgColor.Checked = true;
                ColorConverter converter = new();
                txtBgColor.BackColor = (Color)converter.ConvertFromString(_element.BgColor);
            }

            if (_element.BorderCollapse.HasValue && _element.BorderCollapse.Value)
                chkBorderCollapse.Checked = true;
            // Spec 019 FR-009: preserve design-time defaults on empty fields.
            if (!string.IsNullOrEmpty(_element.SummaryDescription))
                txtSummaryDescription.Text = _element.SummaryDescription;
            if (!string.IsNullOrEmpty(_element.Id))
                txtId.Text = _element.Id;
            if (!string.IsNullOrEmpty(_element.Name))
                txtName.Text = _element.Name;
            if (!string.IsNullOrEmpty(_element.CssClassName))
                txtClassName.Text = _element.CssClassName;
            /////////////////
            if (!string.IsNullOrEmpty(_element.BackGround))
            {
                chklnkBackgroundPicture.Checked = true;
                pbBackgroundPicture.ImageLocation = _element.BackGround;
                pbBackgroundPicture.Load();
            }

            string cssText = _element.GetCssStyleWithoutProperties(this._propertiesAffected);
            if (!string.IsNullOrEmpty(cssText))
                txtCss.Text = cssText;
            chkBorderToAll.Checked = true;
        }
    }

    #region ------------ UI Event Handlers --------------

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

    /// <summary>
    /// Handles the CheckedChanged event of the chkBorderWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkBorderWidth_CheckedChanged(object sender, EventArgs e)
    {
        numBorderWidth.Enabled = chkBorderWidth.Checked;

        this.chkBorderStyle.Enabled = this.chkBorderWidth.Checked;

        //            chkBorderStyle.Checked = chkBorderWidth.Checked;
        cmbBorderStyle.Enabled = chkBorderWidth.Checked && chkBorderStyle.Checked;
        if (!chkBorderWidth.Checked) chkBorderToAll.Checked = true;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkCellPadding control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkCellPadding_CheckedChanged(object sender, EventArgs e)
    {
        numCellPadding.Enabled = chkCellPadding.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkCellSpacing control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkCellSpacing_CheckedChanged(object sender, EventArgs e)
    {
        numCellSpacing.Enabled = chkCellSpacing.Checked;
    }

    /// <summary>
    /// Handles the LinkClicked event of the chklnkBorderColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void chklnkBorderColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using ColorDialog myDialog = new()
        {
            AllowFullOpen = true,
            AnyColor = true,
            Color = txtBorderColor.BackColor,
            CustomColors = [ColorTranslator.ToOle(txtBorderColor.BackColor)]
        };
        if (myDialog.ShowDialog() == DialogResult.OK)
            txtBorderColor.BackColor = myDialog.Color;
    }

    /// <summary>
    /// Handles the LinkClicked event of the chklnkBgColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void chklnkBgColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using ColorDialog myDialog = new()
        {
            AllowFullOpen = true,
            AnyColor = true,
            Color = txtBgColor.BackColor,
            CustomColors = [ColorTranslator.ToOle(txtBgColor.BackColor)]
        };
        if (myDialog.ShowDialog() == DialogResult.OK)
            txtBgColor.BackColor = myDialog.Color;
    }

    /// <summary>
    /// Handles the LinkClicked event of the chklnkBackgroundPicture control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void chklnkBackgroundPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            using OpenFileDialog srcUrlDialog = new()
                { Title = @"Please Select an image file.", RestoreDirectory = true, Filter = @"Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*", FilterIndex = 0, Multiselect = false };
            if (srcUrlDialog.ShowDialog() == DialogResult.OK)
            {
                _backgroundPictureUrl = srcUrlDialog.FileName;
                pbBackgroundPicture.Image = Image.FromFile(_backgroundPictureUrl);
                pbBackgroundPicture.ImageLocation = _backgroundPictureUrl;
            }
        }
        catch
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public new DialogResult ShowDialog()
    {
        this._tableCellDialog.Element = null;
        return base.ShowDialog();
    }

    /// <summary>
    /// Handles the Click event of the btnCellProperties control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void btnCellProperties_Click(object sender, EventArgs e)
    {
        if (this._tableCellDialog == null)
        {
            MessageBox.Show(
                "Table Cell Dialog reference is NULL. Please set a TableCellDialog implementing ITableCellDialog to the editor's Dialog.TableCellDialog property.",
                "Error");
            return;
        }

        TableCellElement tblCellElement = this.getOrInitCellElement();
        if (tblCellElement == null)
        {
            MessageBox.Show(
                "No cells were found.",
                "Error");
            return;
        }

        this._tableCellDialog.Element = tblCellElement;
        using (this._tableCellDialog.LockOverrideSettingsToAllCells())
        {
            if (this._tableCellDialog.ShowDialog() == DialogResult.OK)
                this.Element.CellElement = this._tableCellDialog.Element;
        }
    }

    private TableCellElement getOrInitCellElement()
    {
        return this.Element.GetFirstCellElement();
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkCaption control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkCaption_CheckedChanged(object sender, EventArgs e)
    {
        txtCaption.Enabled = chkCaption.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkBorderStyle control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkBorderStyle_CheckedChanged(object sender, EventArgs e)
    {
        cmbBorderStyle.Enabled = chkBorderStyle.Checked;
        chkBorderCollapse.Enabled = chkBorderStyle.Checked;
        chklnkBorderColor.Enabled = chkBorderStyle.Checked;
        this.txtBorderColor.Enabled = this.chkBorderStyle.Checked && this.chklnkBorderColor.Checked;
        if (!chkBorderStyle.Checked) chkBorderToAll.Checked = true;
    }

    private void numBorderWidth_ValueChanged(object sender, EventArgs e)
    {
        if (this.numBorderWidth.Value == 0.0m)
            this.chkBorderToAll.Checked = true;
    }

    #endregion
}