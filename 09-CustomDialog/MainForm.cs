using System;
using System.Windows.Forms;
using CustomDialog.Dialogs;
using CustomDialog.Dialogs.StyleBuilder;

namespace CustomDialog;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        // Start maximized so the full editor toolbar is visible at first run.
        this.WindowState = FormWindowState.Maximized;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        winFormHtmlEditor1.Dialog.ImageDialog = new ImageDialog();
        winFormHtmlEditor1.Dialog.HyperlinkDialog = new HyperLinkDialog();
        winFormHtmlEditor1.Dialog.SpellCheckerDialog = new SpellCheckerDialog { Options = winFormHtmlEditor1.SpellCheckOptions };
        winFormHtmlEditor1.Dialog.TableCellDialog = new TableCellPropertiesDialog();
        winFormHtmlEditor1.Dialog.TableDialog = new TablePropertiesDialog(winFormHtmlEditor1.Dialog.TableCellDialog);
        winFormHtmlEditor1.Dialog.SymbolDialog = new SymbolDialog();
        winFormHtmlEditor1.Dialog.SearchDialog = new SearchWindow();
        winFormHtmlEditor1.Dialog.StyleBuilderDialog = new WinStyleBuilder();
        winFormHtmlEditor1.Dialog.YouTubeVideoInsertDialog = new YouTubeVideoInsertDialog();
    }
}
