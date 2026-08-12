using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.Abstractions.Entities;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Class HyperLinkDialog
/// </summary>
public partial class HyperLinkDialog : DialogBase, IHyperlinkDialog
{
    /// <summary>
    /// The _the original element
    /// </summary>
    private HyperlinkElement _theOriginalElement;

    /// <summary>
    /// Whether toolTip1 is shown
    /// </summary>
    private bool _toolTipShown = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="HyperLinkDialog" /> class.
    /// </summary>
    public HyperLinkDialog()
    {
        InitializeComponent();

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Handles the Load event of the HyperLinkDialog control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void HyperLinkDialog_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this._theOriginalElement.BaseUrl))
        {
            rdoWorkingDirFile.Enabled = false;
            toolTip1.SetToolTip(rdoWorkingDirFile, "You need to set Base Url in order to use this option");
        }
    }

    /// <summary>
    /// Gets or sets the element.
    /// </summary>
    /// <value>The element.</value>
    public HyperlinkElement Element
    {
        get => readUi();
        set
        {
            this._theOriginalElement = value;
            this.updateUI(value);
        }
    }

    /// <summary>
    /// Reads the UI.
    /// </summary>
    /// <returns>HyperlinkElement.</returns>
    private HyperlinkElement readUi()
    {
        HyperlinkElement theElement = new()
        {
            TheActiveHtmlElement = this._theOriginalElement.TheActiveHtmlElement,
            CssStyle = this._theOriginalElement.CssStyle,
            CssClassName = this._theOriginalElement.CssClassName,
            Name = this._theOriginalElement.Name,
            Id = this._theOriginalElement.Id,
            OnClickJavascript = this._theOriginalElement.OnClickJavascript,
            HrefUrl = txtURL.Text,
            Title = txtToolTip.Text.Trim(),
            InnerHtml = txtInnerHtml.Text.Trim(),
            Target = chkTargetIncluded.Checked ? cmbTarget.Text : null
        };

        return theElement;
    }

    /// <summary>
    /// Updates the UI.
    /// </summary>
    /// <param name="element">The element.</param>
    private void updateUI(HyperlinkElement element)
    {
        if (this.IsLocalResourceSelectionDisabled)
        {
            rdoLocalFile.Enabled = false;
            btnBrowseFile.Enabled = false;
        }

        // Only overwrite the text fields when the element actually carries a
        // value; otherwise we'd erase any default the customizer set on the
        // TextBox at design time (the whole point of having a customizable
        // sample dialog). For an existing link the element's value wins.
        if (!string.IsNullOrEmpty(element.HrefUrl))
            txtURL.Text = element.HrefUrl;
        if (element.IsRelativePathOrUrl)
            rdoWorkingDirFile.Checked = true;
        else if (element.IsLocalFilePath && !this.IsLocalResourceSelectionDisabled)
            rdoLocalFile.Checked = true;
        if (!string.IsNullOrEmpty(element.Title))
            txtToolTip.Text = element.Title;
        cmbTarget.Text = element.Target;
        chkTargetIncluded.Checked = (!string.IsNullOrEmpty(element.Target));
        if (!string.IsNullOrEmpty(element.InnerHtml))
            txtInnerHtml.Text = element.InnerHtml;
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is local resource selection disabled.
    /// </summary>
    /// <value><c>true</c> if this instance is local resource selection disabled; otherwise, <c>false</c>.</value>
    public bool IsLocalResourceSelectionDisabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [remove link].
    /// </summary>
    /// <value><c>true</c> if [remove link]; otherwise, <c>false</c>.</value>
    public bool RemoveLink
    {
        get => chkRemoveLink.Checked;
        set => chkRemoveLink.Checked = value;
    }

    /// <summary>
    /// When true, the editor sets the tooltip Title to "Ctrl+Click to view"
    /// when the user leaves Title blank. This custom dialog has no UI for
    /// it; honor the option as a passthrough field so the interface
    /// contract is satisfied.
    /// </summary>
    public bool UseCtrlClickTooltipDefault { get; set; }

    /// <summary>
    /// Handles the LinkClicked event of the lnkCheck control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void lnkCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo(txtURL.Text, string.Empty)
            {
                UseShellExecute = true
            });
        }
        catch
        {
            //MessageBox.Show(EditorLangRes.ErrorURL, EditorLangRes.ErrorCallingURL);
        }
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkTargetIncluded control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void chkTargetIncluded_CheckedChanged(object sender, EventArgs e)
    {
        cmbTarget.Enabled = chkTargetIncluded.Checked;
    }

    /// <summary>
    /// Handles the Click event of the btnBrowseFile control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void btnBrowseFile_Click(object sender, EventArgs e)
    {
        using OpenFileDialog myDialog = new();
        if (myDialog.ShowDialog() == DialogResult.OK)
            txtURL.Text = myDialog.FileName;
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

        lnkImportToBaseFolder.Enabled = rdoWorkingDirFile.Enabled && rdoWorkingDirFile.Checked &&
                                        isLocalDir.HasValue && isLocalDir.Value;
        chkOverwrite.Enabled = rdoWorkingDirFile.Enabled && rdoWorkingDirFile.Checked &&
                               isLocalDir.HasValue && isLocalDir.Value;
        lnkBrowseWD.Enabled = rdoWorkingDirFile.Enabled && rdoWorkingDirFile.Checked &&
                              isLocalDir.HasValue && isLocalDir.Value;
    }

    /// <summary>
    /// Handles the LinkClicked event of the lnkBrowseWD control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> instance containing the event data.</param>
    private void lnkBrowseWD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using OpenFileDialog srcUrlDialog = new()
            { InitialDirectory = this._theOriginalElement.BaseUrl };
        if (srcUrlDialog.ShowDialog() == DialogResult.OK)
        {
            string directory = Path.GetDirectoryName(srcUrlDialog.FileName);
            string baseUrl = this._theOriginalElement.BaseUrl;
            if (this._theOriginalElement.BaseUrl.EndsWith("\\") || this._theOriginalElement.BaseUrl.EndsWith("/"))
                baseUrl = this._theOriginalElement.BaseUrl.Remove(this._theOriginalElement.BaseUrl.Length - 1);
            if (baseUrl.Equals(directory, StringComparison.OrdinalIgnoreCase))
                txtURL.Text = Path.GetFileName(srcUrlDialog.FileName);
            else
            {
                DialogResult dlgResult = MessageBox.Show(@"The file you selected is not from the base directory for relative path. Do you want to import that file to your base directory ? If you choose YES, then it will be imported to the Base Directory, otherwise the link target will be treated as absolute path file.", @"Selected file is not from the base directory.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    string newFilePath = Path.Combine(baseUrl, Path.GetFileName(srcUrlDialog.FileName) ?? string.Empty);
                    int i = 0;
                    while (File.Exists(newFilePath) && (!chkOverwrite.Checked))
                    {
                        i++;
                        string newFileName = Path.GetFileNameWithoutExtension(srcUrlDialog.FileName) + i + Path.GetExtension(srcUrlDialog.FileName);
                        newFilePath = Path.Combine(baseUrl, newFileName);
                    }
                    if (File.Exists(newFilePath))
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
                    else
                        File.Copy(srcUrlDialog.FileName, newFilePath);
                    txtURL.Text = Path.GetFileName(newFilePath);
                }
                else
                if (dlgResult == DialogResult.No)
                    txtURL.Text = srcUrlDialog.FileName;
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
        using OpenFileDialog myDialog = new();
        if (myDialog.ShowDialog() == DialogResult.OK)
        {
            string newFilePath = Path.Combine(this._theOriginalElement.BaseUrl, Path.GetFileName(myDialog.FileName) ?? string.Empty);
            int i = 0;
            while (File.Exists(newFilePath) && (!chkOverwrite.Checked))
            {
                i++;
                string newFileName = Path.GetFileNameWithoutExtension(myDialog.FileName) + i + Path.GetExtension(myDialog.FileName);
                newFilePath = Path.Combine(this._theOriginalElement.BaseUrl, newFileName);
            }
            if (File.Exists(newFilePath))
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
            else
                File.Copy(myDialog.FileName, newFilePath);
            txtURL.Text = Path.GetFileName(newFilePath);
        }
    }

    /// <summary>
    /// Handles MouseMove event of the pnlRelativeUrl control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
    private void pnlRelativeUrl_MouseMove(object sender, MouseEventArgs e)
    {
        if (sender is not Control parent)
        {
            return;
        }
        Control ctrl = parent.GetChildAtPoint(e.Location);
        if (ctrl != null)
        {
            if (ctrl.Visible && toolTip1.Tag == null)
            {
                if (!_toolTipShown)
                {
                    string tipstring = toolTip1.GetToolTip(ctrl);
                    toolTip1.Show(tipstring.Trim(), ctrl, ctrl.Width / 2, ctrl.Height / 2);
                    toolTip1.Tag = ctrl;
                    _toolTipShown = true;
                }
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
    /// Handles the Click event of the btnOK control.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event data.</param>
    private void btnOK_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtURL.Text))
        {
            this.DialogResult = DialogResult.None;
            MessageBox.Show("Please provide Url");
            txtURL.Focus();
        }
    }
}