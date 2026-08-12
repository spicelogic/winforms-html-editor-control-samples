using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.Abstractions.Entities;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Class ImageDialog
/// </summary>
public partial class ImageDialog : DialogBase, IImageDialog
{
    /// <summary>
    /// The _the original element
    /// </summary>
    private ImageElement _theOriginalElement;
    /// <summary>
    /// The _width to height aspect ratio
    /// </summary>
    private float? _widthToHeightAspectRatio;

    /// <summary>
    /// Whether toolTip1 is shown
    /// </summary>
    private bool _toolTipShown = false;


    /// <summary>
    /// Initializes a new instance of the <see cref="ImageDialog" /> class.
    /// </summary>
    public ImageDialog()
    {
        InitializeComponent();

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Handles the Load event of the ImageInsertDialog control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void ImageInsertDialog_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this._theOriginalElement.BaseUrl))
        {
            rdoWorkingDirFile.Enabled = false;
            toolTip1.SetToolTip(rdoWorkingDirFile, "You need to set Base Url in order to use this option");
        }
    }

    /// <summary>
    /// Handles the Click event of the btnBrowseFile control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void btnBrowseFile_Click(object sender, EventArgs e)
    {
        using OpenFileDialog srcUrlDialog = new()
        {
            RestoreDirectory = true,
            Filter = @"Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*",
            FilterIndex = 0,
            Multiselect = false
        };
        if (srcUrlDialog.ShowDialog() == DialogResult.OK)
        {
            txtURL.Text = srcUrlDialog.FileName;
            string imageFileName = srcUrlDialog.FileName;
            setImageDimensionaAndAspectRatio(imageFileName);
        }
    }

    /// <summary>
    /// Handles the CheckedChanged event of the rdoLocalFile control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void rdoLocalFile_CheckedChanged(object sender, EventArgs e)
    {
        btnBrowseFile.Enabled = rdoLocalFile.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the rdoWorkingDirFile control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void rdoWorkingDirFile_CheckedChanged(object sender, EventArgs e)
    {
        bool? isLocalDir = this._theOriginalElement.IsBaseUrlALocalFolder();

        lnkImportToBaseFolder.Enabled = rdoWorkingDirFile.Enabled && rdoWorkingDirFile.Checked && isLocalDir.HasValue && isLocalDir.Value;
        chkOverwrite.Enabled = rdoWorkingDirFile.Enabled && rdoWorkingDirFile.Checked && isLocalDir.HasValue && isLocalDir.Value;
        lnkBrowseWD.Enabled = rdoWorkingDirFile.Enabled && rdoWorkingDirFile.Checked && isLocalDir.HasValue && isLocalDir.Value;
    }

    /// <summary>
    /// Handles the LinkClicked event of the lnkBrowseWD control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    /// <exception cref="System.Exception">File doesn't exist</exception>
    private void lnkBrowseWD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using OpenFileDialog srcUrlDialog = new()
        {
            RestoreDirectory = true,
            Filter = @"Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*",
            FilterIndex = 0,
            Multiselect = false,
            InitialDirectory = this._theOriginalElement.BaseUrl
        };
        if (srcUrlDialog.ShowDialog() == DialogResult.OK)
        {
            string baseUrl = this._theOriginalElement.BaseUrl ?? string.Empty;
            if (baseUrl.EndsWith("\\") || baseUrl.EndsWith("/"))
                baseUrl = baseUrl.Remove(baseUrl.Length - 1);

            string selectedFileDirectory = Path.GetDirectoryName(srcUrlDialog.FileName);
            if (selectedFileDirectory == null)
                return;

            if (selectedFileDirectory.StartsWith(baseUrl, StringComparison.OrdinalIgnoreCase))
            {
                string relativePath = srcUrlDialog.FileName.Replace(baseUrl, "");
                if (relativePath.StartsWith("\\"))
                    relativePath = relativePath.Remove(0, 1);

                txtURL.Text = relativePath;
            }
            else
            {
                DialogResult dlgResult = MessageBox.Show(@"The image you selected is not from the base directory for relative path. Do you want to import that file to your base directory ? If you choose YES, then it will be imported to the Base Directory, otherwise it will be treated as absolute path image file.", @"Selected image is not from the base directory.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    string newFilePath = Path.Combine(baseUrl, Path.GetFileName(srcUrlDialog.FileName) ?? string.Empty);
                    int i = 0;
                    while (File.Exists(newFilePath) && !chkOverwrite.Checked)
                    {
                        i++;
                        string newFileName = Path.GetFileNameWithoutExtension(srcUrlDialog.FileName) + i + Path.GetExtension(srcUrlDialog.FileName);
                        newFilePath = Path.Combine(baseUrl, newFileName);
                    }
                    if (File.Exists(newFilePath))
                    {
                        try
                        {
                            File.SetAttributes(newFilePath, FileAttributes.Normal);
                            File.Delete(newFilePath);
                            File.Copy(srcUrlDialog.FileName, newFilePath);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, @"Error copying file to the destination");
                        }
                    }
                    else
                        File.Copy(srcUrlDialog.FileName, newFilePath);
                    txtURL.Text = Path.GetFileName(newFilePath);
                }
                else if (dlgResult == DialogResult.No)
                    txtURL.Text = srcUrlDialog.FileName;
            }

            if (!string.IsNullOrEmpty(txtURL.Text))
            {
                string fullImagePath = File.Exists(txtURL.Text) ? txtURL.Text : Path.Combine(baseUrl, txtURL.Text);
                if (File.Exists(fullImagePath))
                    setImageDimensionaAndAspectRatio(fullImagePath);
                else
                    throw new Exception("File doesn't exist");
            }
        }
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkAlignment control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkAlignment_CheckedChanged(object sender, EventArgs e)
    {
        cmbAlign.Enabled = chkAlignment.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkBorderThickness control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkBorderThickness_CheckedChanged(object sender, EventArgs e)
    {
        txtBorder.Enabled = chkBorderThickness.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkHeight control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkHeight_CheckedChanged(object sender, EventArgs e)
    {
        txtHeight.Enabled = chkHeight.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkWidth_CheckedChanged(object sender, EventArgs e)
    {
        txtWidth.Enabled = chkWidth.Checked;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkBorderColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkBorderColor_CheckedChanged(object sender, EventArgs e)
    {
        lnkBgColor.Enabled = chkBorderColor.Checked;
        txtBgColor.Enabled = chkBorderColor.Checked;
    }

    /// <summary>
    /// Handles the LinkClicked event of the lnkBgColor control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void lnkBgColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using ColorDialog myDialog = new()
            { AllowFullOpen = true, AnyColor = true };
        if (myDialog.ShowDialog() == DialogResult.OK)
            txtBgColor.BackColor = myDialog.Color;
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkBorderStyle control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkBorderStyle_CheckedChanged(object sender, EventArgs e)
    {
        cmbBorderStyle.Enabled = chkBorderStyle.Checked;
    }

    /// <summary>
    /// Handles the TextChanged event of the txtHeight control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void txtHeight_TextChanged(object sender, EventArgs e)
    {
        if (txtHeight.Focused && chkLockAspectRatio.Checked && this._widthToHeightAspectRatio is > 0)
        {
            try
            {
                string value = txtHeight.Text;
                getValueAndUnit(value, out var digitPart, out var unitPart);

                if (digitPart.Length > 0)
                {
                    float height = float.Parse(digitPart);
                    if (height > 0)
                    {
                        float width = this._widthToHeightAspectRatio.Value * height;
                        txtWidth.Text = (int)Math.Round(width) + unitPart;
                    }
                }
            }
            catch
            {
                // ignored
            }
        }
    }

    /// <summary>
    /// Handles the TextChanged event of the txtWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void txtWidth_TextChanged(object sender, EventArgs e)
    {
        if (txtWidth.Focused && chkLockAspectRatio.Checked && this._widthToHeightAspectRatio is > 0)
        {
            try
            {
                string value = txtWidth.Text;
                getValueAndUnit(value, out var digitPart, out var unitPart);

                if (digitPart.Length > 0)
                {
                    float width = float.Parse(digitPart);
                    if (width > 0)
                    {
                        float height = width / this._widthToHeightAspectRatio.Value;
                        txtHeight.Text = (int)Math.Round(height) + unitPart;
                    }
                }
            }
            catch
            {
                // ignored
            }
        }
    }

    /// <summary>
    /// Handles the LinkClicked event of the lnkImportToBaseFolder control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void lnkImportToBaseFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using OpenFileDialog myDialog = new()
            { RestoreDirectory = true, Filter = @"Image Files|*.png;*.bmp;*.gif;*.jpg|All files(*.*)|*.*", FilterIndex = 0, Multiselect = false };
        if (myDialog.ShowDialog() == DialogResult.OK)
        {
            string newFilePath = Path.Combine(this._theOriginalElement.BaseUrl, Path.GetFileName(myDialog.FileName) ?? string.Empty);
            int i = 0;
            while (File.Exists(newFilePath) && !chkOverwrite.Checked)
            {
                i++;
                string newFileName = Path.GetFileNameWithoutExtension(myDialog.FileName) + i + Path.GetExtension(myDialog.FileName);
                newFilePath = Path.Combine(this._theOriginalElement.BaseUrl, newFileName);
            }

            if (File.Exists(newFilePath))
            {
                try
                {
                    File.SetAttributes(newFilePath, FileAttributes.Normal);
                    File.Delete(newFilePath);
                    File.Copy(myDialog.FileName, newFilePath);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, @"Error copying file to the destination");
                }
            }
            else
                File.Copy(myDialog.FileName, newFilePath);
            txtURL.Text = Path.GetFileName(newFilePath);
        }
    }

    /// <summary>
    /// Gets or sets the element.
    /// </summary>
    /// <value>The element.</value>
    public ImageElement Element
    {
        get => readUi();
        set
        {
            this._theOriginalElement = value;
            this.updateUi(value);
        }
    }

    /// <summary>
    /// Reads the UI.
    /// </summary>
    /// <returns>ImageElement.</returns>
    private ImageElement readUi()
    {
        string src = null;

        if (chkInsertLocalBase64.Checked)
        {
            try
            {
                if (File.Exists(txtURL.Text))
                {
                    src = ImageElement.GetBase64DataUrlForLocalImage(txtURL.Text);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        ImageElement theElement = new()
        {
            TheActiveHtmlElement = this._theOriginalElement.TheActiveHtmlElement,
            CssStyle = this._theOriginalElement.CssStyle,
            CssClassName = this._theOriginalElement.CssClassName,
            Name = this._theOriginalElement.Name,
            Id = this._theOriginalElement.Id,
            OnClickJavascript = this._theOriginalElement.OnClickJavascript,
            SrcUrl = src ?? txtURL.Text
        };
            
        if (chkWidth.Checked)
            theElement.Width = txtWidth.Text.Trim();
        if (chkHeight.Checked)
            theElement.Height = txtHeight.Text.Trim();
        if (chkBorderColor.Checked)
            theElement.BorderColor = txtBgColor.BackColor;
        if (chkBorderStyle.Checked)
            theElement.BorderStyle = cmbBorderStyle.Text;
        if (chkBorderThickness.Checked && !string.IsNullOrEmpty(txtBorder.Text))
            theElement.Border = Convert.ToInt32(txtBorder.Text);
        theElement.Title = txtToolTip.Text.Trim();
        theElement.AlternativeText = txtAlt.Text.Trim();
        if (chkAlignment.Checked && !string.IsNullOrEmpty(cmbAlign.Text))
            theElement.Align = cmbAlign.Text;
        return theElement;
    }

    /// <summary>
    /// Updates the UI.
    /// </summary>
    /// <param name="element">The element.</param>
    private void updateUi(ImageElement element)
    {
        if (this.IsLocalResourceSelectionDisabled)
        {
            rdoLocalFile.Enabled = false;
            btnBrowseFile.Enabled = false;
        }

        // Spec 019 FR-009: preserve design-time defaults on empty fields.
        if (!string.IsNullOrEmpty(element.SrcUrl))
            txtURL.Text = element.SrcUrl;
        if (element.IsRelativePathOrUrl)
            rdoWorkingDirFile.Checked = true;
        else if (element.IsLocalFilePath && !this.IsLocalResourceSelectionDisabled)
            rdoLocalFile.Checked = true;
        if (!string.IsNullOrEmpty(element.Title))
            txtToolTip.Text = element.Title;
        if (!string.IsNullOrEmpty(element.AlternativeText))
            txtAlt.Text = element.AlternativeText;
        if (!string.IsNullOrEmpty(element.Align))
        {
            cmbAlign.Text = element.Align;
            chkAlignment.Checked = true;
        }
        if (element.Border.HasValue)
        {
            txtBorder.Text = element.Border.Value.ToString(CultureInfo.InvariantCulture);
            chkBorderThickness.Checked = true;
        }
        if (!string.IsNullOrEmpty(element.Width))
        {
            txtWidth.Text = element.Width;
            chkWidth.Checked = true;
        }
        if (!string.IsNullOrEmpty(element.Height))
        {
            txtHeight.Text = element.Height;
            chkHeight.Checked = true;
        }
        if (element.BorderColor.HasValue)
        {
            chkBorderColor.Checked = true;
            txtBgColor.BackColor = element.BorderColor.Value;
        }
        if (!string.IsNullOrEmpty(element.BorderStyle))
        {
            chkBorderStyle.Checked = true;
            cmbBorderStyle.Text = element.BorderStyle;
        }

        if (chkHeight.Checked && chkWidth.Checked)
        {
            try
            {
                string unit;
                getValueAndUnit(txtWidth.Text, out var widthDigitPart, out unit);

                getValueAndUnit(txtHeight.Text, out var heightDigitPart, out unit);
                if (widthDigitPart.Length > 0 && heightDigitPart.Length > 0)
                {
                    float width = float.Parse(widthDigitPart);
                    float height = float.Parse(heightDigitPart);
                    if (width > 0 && height > 0)
                        this._widthToHeightAspectRatio = width / height;
                    else
                        this._widthToHeightAspectRatio = null;
                }
            }
            catch
            {
                this._widthToHeightAspectRatio = null;
            }
        }
        else
            this._widthToHeightAspectRatio = null;
    }

    /// <summary>
    /// Sets the image dimensiona and aspect ratio.
    /// </summary>
    /// <param name="imageFileName">Name of the image file.</param>
    private void setImageDimensionaAndAspectRatio(string imageFileName)
    {
        Size? theImageDimension = ImageUtils.GetImageDimension(imageFileName);
        if (theImageDimension.HasValue)
        {
            chkHeight.Checked = true;
            txtHeight.Text = theImageDimension.Value.Height.ToString(CultureInfo.InvariantCulture);
            chkWidth.Checked = true;
            txtWidth.Text = theImageDimension.Value.Width.ToString(CultureInfo.InvariantCulture);
            if (theImageDimension.Value is { Width: > 0, Height: > 0 })
                this._widthToHeightAspectRatio = theImageDimension.Value.Width / (float)theImageDimension.Value.Height;
            else
                this._widthToHeightAspectRatio = null;
        }
        else
            this._widthToHeightAspectRatio = null;
    }

    /// <summary>
    /// Gets the value and unit.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="digitPart">The digit part.</param>
    /// <param name="unitPart">The unit part.</param>
    private static void getValueAndUnit(string value, out string digitPart, out string unitPart)
    {
        const string digitRegEx = @"\d+";
        digitPart = Regex.Match(value, digitRegEx, RegexOptions.IgnoreCase | RegexOptions.Compiled).Groups[0].Value;
        unitPart = value.Replace(digitPart, "").Trim();
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is local resource selection disabled.
    /// </summary>
    /// <value><c>true</c> if this instance is local resource selection disabled; otherwise, <c>false</c>.</value>
    public bool IsLocalResourceSelectionDisabled { get; set; }

    /// <summary>
    /// When true, the Image dialog writes width/height as inline CSS in
    /// CssStyle ("style=width:240px;height:120px") instead of HTML
    /// width=/height= attributes. Passthrough auto-property so this custom
    /// dialog satisfies the interface contract.
    /// </summary>
    public bool UseInlineStyleForDimensions { get; set; }

    /// <summary>
    /// Handles MouseMove event of the pnlRelativeUrl control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
    private void pnlUrl_MouseMove(object sender, MouseEventArgs e)
    {
        if (sender is not Control parent)
        {
            return;
        }

        Control ctrl = parent.GetChildAtPoint(e.Location);
        if (ctrl != null)
        {
            if (ctrl.Visible && toolTip1.Tag == null && !_toolTipShown)
            {
                string tipstring = toolTip1.GetToolTip(ctrl);
                toolTip1.Show(tipstring.Trim(), ctrl, ctrl.Width / 2, ctrl.Height / 2);
                toolTip1.Tag = ctrl;
                _toolTipShown = true;
            }
        }
        else
        {
            ctrl = toolTip1.Tag as Control;
            if (ctrl != null)
            {
                toolTip1.Hide(ctrl);
                toolTip1.Tag = null;
                _toolTipShown = false;
            }
        }
    }

    /// <summary>
    /// Handles Click event of the btnOK control.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data.</param>
    private void btnOK_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtURL.Text))
        {
            this.DialogResult = DialogResult.None;
            MessageBox.Show("Please provide Image Url");
            txtURL.Focus();
        }
    }

    /// <summary>
    /// Handles CheckedChanged event of rdInternetURL control.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event argument.</param>
    private void rdInternetURL_CheckedChanged(object sender, EventArgs e)
    {
        if (rdInternetURL.Checked)
        {
            chkInsertLocalBase64.Checked = false;
        }

        chkInsertLocalBase64.Enabled = !rdInternetURL.Checked;
    }

    /// <summary>
    /// Handles VisibleChanged event of chkInsertLocalBase64 control.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event argument.</param>
    private void chkInsertLocalBase64_VisibleChanged(object sender, EventArgs e)
    {
        if (this.Visible)
        {
            chkInsertLocalBase64.Checked = false;
        }
    }
}