using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Form to let user select a (sub)set of fonts
/// </summary>
public partial class frmFontPicker : DialogBase
{
    /// <summary>
    /// List of font names
    /// it is synchronized with the list box of selected fonts
    /// </summary>
    readonly List<string> _lSelectedFonts = [];

    #region Exposed methods
    /// <summary>
    /// Initializes a new instance of the <see cref="frmFontPicker"/> class.
    /// </summary>
    /// <param name="initFontList">The init font list.</param>
    public frmFontPicker(string initFontList)
    {
        // handle selected fonts
        string[] arrFonts = initFontList.Split(',');
        foreach (string aFontName in arrFonts)
        {
            string candidate = aFontName.Trim();
            if (candidate.Length >= 2 && candidate[0] == '\'' && candidate[candidate.Length - 1] == '\'')
                candidate = candidate.Substring(1, candidate.Length - 2);
            if (candidate.Length == 0)
                continue;
            _lSelectedFonts.Add(candidate);
        }

        InitializeComponent();
    }

    /// <summary>
    /// Comma-separeted list of fonts
    /// </summary>
    /// <value>The selected font list.</value>
    public string SelectedFontList
    {
        get
        {
            // Build from list
            StringBuilder sb = new();
            bool first = true;                              // A flag indicating we're going to write the first entry

            // Iterate through selected fonts
            foreach (string aFontname in _lSelectedFonts)
            {
                // Handle first entry
                if (!first)
                    sb.Append(", ");
                else
                    first = false;

                // Append font's name
                if (aFontname.Contains(" "))
                {
                    sb.Append('\'');
                    sb.Append(aFontname);
                    sb.Append('\'');
                }
                else
                    sb.Append(aFontname);
            }

            // done
            return sb.ToString();
        }
    }
    #endregion

    /// <summary>
    /// Handles the Load event of the frmFontPicker control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void frmFontPicker_Load(object sender, EventArgs e)
    {
        // populate list of selected fonts
        lbSelectedFonts.SuspendLayout();
        foreach (string aFont in _lSelectedFonts)
            lbSelectedFonts.Items.Add(aFont);
        lbSelectedFonts.ResumeLayout();

        // populate list of installed fonts
        lbInstalledFonts.SuspendLayout();
        foreach (FontFamily fontFamily in FontFamily.Families)
            lbInstalledFonts.Items.Add(fontFamily.Name);
        lbInstalledFonts.ResumeLayout();

        // set some buttons' enable status
        lbSelectedFonts_SelectedIndexChanged(this, EventArgs.Empty);
        tbCustomFont_TextChanged(this, EventArgs.Empty);
    }

    #region Adding fonts to the selected list
    /// <summary>
    /// Handles the Click event of the btAddInstalledFont control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btAddInstalledFont_Click(object sender, EventArgs e)
    {
        string sFont = (string) lbInstalledFonts.SelectedItem;
        if (!string.IsNullOrEmpty(sFont))
        {
            lbSelectedFonts.Items.Add(sFont);
            _lSelectedFonts.Add(sFont);
            lbInstalledFonts.SelectedItem = null;
        }
    }

    /// <summary>
    /// Handles the Click event of the btAddGenericFont control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btAddGenericFont_Click(object sender, EventArgs e)
    {
        string sFont = (string)cbGenericFonts.SelectedItem;
        if (!string.IsNullOrEmpty(sFont))
        {
            lbSelectedFonts.Items.Add(sFont);
            _lSelectedFonts.Add(sFont);
            cbGenericFonts.SelectedItem = null;
        }
    }

    /// <summary>
    /// Handles the Click event of the brAddCustomFont control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void brAddCustomFont_Click(object sender, EventArgs e)
    {
        lbSelectedFonts.Items.Add(tbCustomFont.Text);
        _lSelectedFonts.Add(tbCustomFont.Text);
    }
    #endregion

    #region Selected fonts handling
    /// <summary>
    /// Handles the Click event of the btMoveUp control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btMoveUp_Click(object sender, EventArgs e)
    {
        int sel = lbSelectedFonts.SelectedIndex;
        if (sel > 0)
        {
            // exchange items in the list box
            object oCurrent = lbSelectedFonts.SelectedItem;
            lbSelectedFonts.Items.RemoveAt(sel);
            lbSelectedFonts.Items.Insert(sel - 1, oCurrent);
            lbSelectedFonts.SelectedIndex = sel - 1;

            // exchange items in the local list
            string sCurrent = _lSelectedFonts[sel];
            _lSelectedFonts[sel] = _lSelectedFonts[sel - 1];
            _lSelectedFonts[sel - 1] = sCurrent;
        }
    }

    /// <summary>
    /// Handles the Click event of the btMoveDown control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btMoveDown_Click(object sender, EventArgs e)
    {
        int sel = lbSelectedFonts.SelectedIndex;
        if (sel != -1 && sel < lbSelectedFonts.Items.Count - 1)
        {
            // exchange items in the list box
            object oCurrent = lbSelectedFonts.SelectedItem;
            lbSelectedFonts.Items.RemoveAt(sel);
            lbSelectedFonts.Items.Insert(sel + 1, oCurrent);
            lbSelectedFonts.SelectedIndex = sel + 1;

            // exchange items in the local list
            string sCurrent = _lSelectedFonts[sel];
            _lSelectedFonts[sel] = _lSelectedFonts[sel + 1];
            _lSelectedFonts[sel + 1] = sCurrent;
        }
    }

    /// <summary>
    /// Handles the Click event of the btRemove control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btRemove_Click(object sender, EventArgs e)
    {
        int sel = lbSelectedFonts.SelectedIndex;
        if (sel != -1) // precaution
        {
            // remove from list box
            lbSelectedFonts.Items.RemoveAt(sel);

            // remove from local list
            _lSelectedFonts.RemoveAt(sel);
        }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the lbSelectedFonts control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void lbSelectedFonts_SelectedIndexChanged(object sender, EventArgs e)
    {
        int sel = lbSelectedFonts.SelectedIndex;
        if (sel != -1)
        {
            btRemove.Enabled = true;
            btMoveUp.Enabled = sel != 0;
            btMoveDown.Enabled = sel != lbSelectedFonts.Items.Count - 1;
        }
        else // sel == -1 => disable some buttons
        {
            btMoveUp.Enabled = btMoveDown.Enabled = btRemove.Enabled = false;
        }
    }
    #endregion

    /// <summary>
    /// Handles the Click event of the btOk control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btOk_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    /// <summary>
    /// Handles the Click event of the btCancel control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    /// <summary>
    /// Handles the TextChanged event of the tbCustomFont control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void tbCustomFont_TextChanged(object sender, EventArgs e)
    {
        btAddCustomFont.Enabled = tbCustomFont.Text.Trim().Length > 0 && !tbCustomFont.Text.Contains(",");
    }
}