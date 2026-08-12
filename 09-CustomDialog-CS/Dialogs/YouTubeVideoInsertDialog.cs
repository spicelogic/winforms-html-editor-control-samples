using System;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.Abstractions.Entities;
using SpiceLogic.HtmlEditor.WinForms.Helpers;
using SpiceLogic.HtmlEditor.WinForms.Models.Dialogs;

namespace CustomDialog.Dialogs;

/// <summary>
/// Class YouTubeVideoInsertDialog
/// </summary>
public partial class YouTubeVideoInsertDialog : DialogBase, IYouTubeVideoInsertDialog
{
    /// <summary>
    /// The _the original element
    /// </summary>
    private YouTubeVideoElement _theOriginalElement;

    /// <summary>
    /// Initializes a new instance of the <see cref="YouTubeVideoInsertDialog" /> class.
    /// </summary>
    public YouTubeVideoInsertDialog()
    {
        InitializeComponent();

        Icon = Constants.FormIcon;
    }

    /// <summary>
    /// Gets or sets the element.
    /// </summary>
    /// <value>The element.</value>
    public YouTubeVideoElement Element
    {
        get
        {
            if(_theOriginalElement == null)
            {
                YouTubeVideoElement theElement = new()
                {
                    Url = txtUrl.Text.Trim(),
                    Width = txtWidth.Text,
                    Height = txtHeight.Text
                };
                return theElement;
            }
            _theOriginalElement.Url = txtUrl.Text.Trim();
            _theOriginalElement.Width = txtWidth.Text;
            _theOriginalElement.Height = txtHeight.Text;
            _theOriginalElement.CssStyle = txtCssStyle.Text;
            return _theOriginalElement;
        }
        set {
            this._theOriginalElement = value;
            txtUrl.Text = value.Url;
            txtHeight.Text = value.Height;
            txtWidth.Text = value.Width;
            txtCssStyle.Text = value.CssStyle;
        }
    }

    /// <summary>
    /// Handles the Click event of the btnOK control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void btnOK_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(txtUrl.Text))
        {
            MessageBox.Show("The YouTube URL cannot be empty.");
            txtUrl.Focus();
            return;
        }

        string theUrl = txtUrl.Text.Trim();
        if(theUrl == string.Empty)
        {
            MessageBox.Show("The YouTube URL cannot be empty.");
            txtUrl.Focus();
            return;
        }

        if(!theUrl.ToLower().Contains("youtube.com"))
        {
            MessageBox.Show("The URL you provided does not contain the YouTube Domain name", "Invalid URL");
            return;
        }

        this.DialogResult = DialogResult.OK;
    }
}