using LLama;
using LLama.Common;

namespace CraftAiTools.Controls;

public partial class ChatControl : UserControl
{
    private InteractiveExecutor? executor;
    private ChatHistory? chatHistory;
    private ChatSession? session;
    private InferenceParams? inferenceParams;
    private LLamaWeights? model;
    private LLamaContext? context;

    public ChatControl()
    {
        InitializeComponent();

        btnSend.Enabled = false;

        if (Globals.SelectModelPath is null)
        {
            MessageBox.Show("Please select a model first.");
            return;
        }

        var parameters = new ModelParams(Globals.SelectModelPath)
        {
            ContextSize = 1024, // The longest length of chat as memory.
            GpuLayerCount = 5 // How many layers to offload to GPU. Please adjust it according to your GPU memory.
        };

        model = LLamaWeights.LoadFromFile(parameters);
        context = model.CreateContext(parameters);

        btnSend.Enabled = false;

        executor = new InteractiveExecutor(context);

        chatHistory = new ChatHistory();
        chatHistory.AddMessage(AuthorRole.System, "Transcript of a dialog, where the User interacts with an Assistant named Bob. Bob is helpful, kind, honest, good at writing, and never fails to answer the User's requests immediately and with precision.");
        chatHistory.AddMessage(AuthorRole.User, "Hello, Bob.");
        chatHistory.AddMessage(AuthorRole.Assistant, "Hello. How may I help you today?");

        if (executor is not null)
            session = new(executor, chatHistory);

        inferenceParams = new InferenceParams()
        {
            MaxTokens = 1024,
            AntiPrompts = ["User:"] // Stop generation once antiprompts appear.
        };

        txtLog.Text += "The chat session has started...\nUser: ";

        btnSend.Enabled = session is not null;
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        txtLog.Text += txtUserInput.Text + "\n";

        txtLog.Text += "Bob: ";

        await foreach (var text in session!.ChatAsync(new ChatHistory.Message(AuthorRole.User, 
            txtUserInput.Text), inferenceParams))
        {
            txtLog.Text += text;
        }

        txtLog.Text += "\nUser: ";
    }
}
