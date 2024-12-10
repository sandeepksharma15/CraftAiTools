using CraftAiTools.Controls;
using CraftAiTools.Models;

using LLama;
using LLama.Common;

namespace CraftAiTools;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        ScanModels();
        LoadModels();
    }

    private void LoadModels()
    {
        CB_Models.Items.Clear();

        foreach (LLamaModel model in Globals.Models)
            CB_Models.Items.Add(model.Name ?? "");
    }

    private static void ScanModels()
    {
        if (Directory.Exists(Globals.ModelsPath))
        {
            // Scan The Models
            string[] files = Directory.GetFiles(Globals.ModelsPath, "*.gguf", SearchOption.AllDirectories);

            // Clear The Pevious Models
            Globals.Models.Clear();

            foreach (string file in files)
            {
                Globals.Models.Add(new LLamaModel
                {
                    Name = Path.GetFileNameWithoutExtension(file),
                    Path = file
                });
            }
        }
        else
        {
            MessageBox.Show("Directory not found: " + Globals.ModelsPath);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadUserControl(new ChatControl());
    }

    private void LoadUserControl(UserControl userControl)
    {
        Panel_Main.Controls.Clear();
        userControl.Dock = DockStyle.Fill;
        Panel_Main.Controls.Add(userControl);
    }

    private void TSB_Chat_Click(object sender, EventArgs e)
    {
        LoadUserControl(new ChatControl());
    }

    private void TSB_Image_Click(object sender, EventArgs e)
    {
        LoadUserControl(new ImageControl());
    }

    private void TSB_Code_Click(object sender, EventArgs e)
    {
        LoadUserControl(new CodeControl());
    }

    private void ModelChanged(object sender, EventArgs e)
    {
        // Get The Item
        var selectedItem = CB_Models.SelectedItem?.ToString();

        if (selectedItem is null) return;

        var model = Globals.Models?.FirstOrDefault(x => x.Name == selectedItem);
        
        if (model == null) return;

        Globals.SelectModelName = model.Name;
        Globals.SelectModelPath = model.Path;
    }
}
