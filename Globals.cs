using CraftAiTools.Models;

using LLama;

namespace CraftAiTools;

public static class Globals
{
    public const string ModelsPath = @"H:\AI_Models";

    public static List<LLamaModel> Models { get; set; } = [];

    public static string? SelectModelName { get; set; }
    public static string? SelectModelPath { get; set; }
}
