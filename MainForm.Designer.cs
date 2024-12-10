namespace CraftAiTools;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        TS_Main = new ToolStrip();
        TSB_Chat = new ToolStripButton();
        TSB_Image = new ToolStripButton();
        TSB_Code = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        CB_Models = new ToolStripComboBox();
        LBL_Models = new ToolStripLabel();
        SS_Main = new StatusStrip();
        Panel_Main = new Panel();
        TS_Main.SuspendLayout();
        SuspendLayout();
        // 
        // TS_Main
        // 
        TS_Main.Items.AddRange(new ToolStripItem[] { TSB_Chat, TSB_Image, TSB_Code, toolStripSeparator1, CB_Models, LBL_Models });
        TS_Main.Location = new Point(0, 0);
        TS_Main.Name = "TS_Main";
        TS_Main.Size = new Size(1050, 47);
        TS_Main.TabIndex = 0;
        // 
        // TSB_Chat
        // 
        TSB_Chat.BackColor = SystemColors.ButtonFace;
        TSB_Chat.DisplayStyle = ToolStripItemDisplayStyle.Text;
        TSB_Chat.Font = new Font("Roboto", 10F);
        TSB_Chat.ImageTransparentColor = Color.Magenta;
        TSB_Chat.Margin = new Padding(5);
        TSB_Chat.Name = "TSB_Chat";
        TSB_Chat.Padding = new Padding(7);
        TSB_Chat.Size = new Size(110, 37);
        TSB_Chat.Text = "Generic Chat";
        TSB_Chat.Click += TSB_Chat_Click;
        // 
        // TSB_Image
        // 
        TSB_Image.BackColor = SystemColors.ButtonFace;
        TSB_Image.DisplayStyle = ToolStripItemDisplayStyle.Text;
        TSB_Image.Font = new Font("Roboto", 10F);
        TSB_Image.ImageTransparentColor = Color.Magenta;
        TSB_Image.Margin = new Padding(5);
        TSB_Image.Name = "TSB_Image";
        TSB_Image.Padding = new Padding(7);
        TSB_Image.Size = new Size(130, 37);
        TSB_Image.Text = "Generate Image";
        TSB_Image.Click += TSB_Image_Click;
        // 
        // TSB_Code
        // 
        TSB_Code.BackColor = SystemColors.ButtonFace;
        TSB_Code.DisplayStyle = ToolStripItemDisplayStyle.Text;
        TSB_Code.Font = new Font("Roboto", 10F);
        TSB_Code.ImageTransparentColor = Color.Magenta;
        TSB_Code.Margin = new Padding(5);
        TSB_Code.Name = "TSB_Code";
        TSB_Code.Padding = new Padding(7);
        TSB_Code.Size = new Size(113, 37);
        TSB_Code.Text = "Generic Code";
        TSB_Code.Click += TSB_Code_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 47);
        // 
        // CB_Models
        // 
        CB_Models.Alignment = ToolStripItemAlignment.Right;
        CB_Models.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        CB_Models.Name = "CB_Models";
        CB_Models.Size = new Size(225, 47);
        CB_Models.Sorted = true;
        CB_Models.ToolTipText = "Select Model...";
        CB_Models.SelectedIndexChanged += ModelChanged;
        // 
        // LBL_Models
        // 
        LBL_Models.Alignment = ToolStripItemAlignment.Right;
        LBL_Models.Name = "LBL_Models";
        LBL_Models.Size = new Size(47, 44);
        LBL_Models.Text = "Model: ";
        // 
        // SS_Main
        // 
        SS_Main.Location = new Point(0, 670);
        SS_Main.Name = "SS_Main";
        SS_Main.Size = new Size(1050, 22);
        SS_Main.TabIndex = 1;
        // 
        // Panel_Main
        // 
        Panel_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        Panel_Main.BorderStyle = BorderStyle.Fixed3D;
        Panel_Main.Location = new Point(0, 50);
        Panel_Main.Margin = new Padding(0);
        Panel_Main.Name = "Panel_Main";
        Panel_Main.Size = new Size(1050, 617);
        Panel_Main.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1050, 692);
        Controls.Add(Panel_Main);
        Controls.Add(SS_Main);
        Controls.Add(TS_Main);
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        Text = "Craft AI Tools";
        Load += MainForm_Load;
        TS_Main.ResumeLayout(false);
        TS_Main.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip TS_Main;
    private ToolStripButton TSB_Chat;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripComboBox CB_Models;
    private ToolStripButton TSB_Image;
    private ToolStripButton TSB_Code;
    private ToolStripLabel LBL_Models;
    private StatusStrip SS_Main;
    private Panel Panel_Main;
}