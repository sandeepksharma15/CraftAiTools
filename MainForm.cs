using CraftAiTools.Controls;
using CraftAiTools.Helpers;
using CraftAiTools.Models;

namespace CraftAiTools;

public partial class MainForm : Form
{
    private UserControl? currentUserControl = null;

    public MainForm()
    {
        InitializeComponent();

        // Load Models From Disk
        FileHelpers.ScanModels(Globals.ModelsPath);

        // Load Models In ComboBox
        LoadModels();
    }

    private void LoadModels()
    {
        CB_Models.Items.Clear();

        foreach (LLamaModel model in Globals.Models)
            CB_Models.Items.Add(model.Name ?? "");
    }

    private void MainForm_Load(object sender, EventArgs e) => LoadUserControl(new ChatControl());
    private void TSB_Chat_Click(object sender, EventArgs e) => LoadUserControl(new ChatControl());
    private void TSB_Image_Click(object sender, EventArgs e) => LoadUserControl(new ImageControl());
    private void TSB_Code_Click(object sender, EventArgs e) => LoadUserControl(new CodeControl());

    private void ModelChanged(object sender, EventArgs e)
    {
        // Get The Item
        var selectedItem = CB_Models.SelectedItem?.ToString();

        if (selectedItem is null) return;

        var model = Globals.Models?.FirstOrDefault(x => x.Name == selectedItem);
        
        if (model == null) return;

        Globals.SelectModelName = model.Name;
        Globals.SelectModelPath = model.Path;

        // Reload the current UserControl
        if (currentUserControl is not null)
            LoadUserControl((CustomControl)(Activator.CreateInstance(currentUserControl.GetType()) ?? new ChatControl()));
    }

    private void LoadUserControl(CustomControl userControl)
    {
        Panel_Main.Controls.Clear();
        userControl.Dock = DockStyle.Fill;
        Panel_Main.Controls.Add(userControl);

        // Set The Accept Button
        AcceptButton = ((ChatControl)Panel_Main.Controls[0]).DefaultButton;

        // Get A Reference To The Current User Control
        currentUserControl = userControl;
    }
}
