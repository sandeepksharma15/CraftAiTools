using CraftAiTools.Models;

namespace CraftAiTools.Helpers;

public static class FileHelpers
{
    public static bool ScanModels(string modelsPath)
    {
        if (Directory.Exists(modelsPath))
        {
            // Scan The Models
            string[] files = Directory.GetFiles(modelsPath, "*.gguf", SearchOption.AllDirectories);

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

            return true;
        }
        else
        {
            MessageBox.Show("Directory not found: "
                + modelsPath, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}
