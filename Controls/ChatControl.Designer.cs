namespace CraftAiTools.Controls;

partial class ChatControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtLog = new TextBox();
        txtUserInput = new TextBox();
        btnSend = new Button();
        SuspendLayout();
        // 
        // txtLog
        // 
        txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLog.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtLog.Location = new Point(18, 18);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ReadOnly = true;
        txtLog.Size = new Size(1017, 487);
        txtLog.TabIndex = 0;
        // 
        // txtUserInput
        // 
        txtUserInput.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtUserInput.Location = new Point(18, 521);
        txtUserInput.Multiline = true;
        txtUserInput.Name = "txtUserInput";
        txtUserInput.Size = new Size(893, 78);
        txtUserInput.TabIndex = 1;
        // 
        // btnSend
        // 
        btnSend.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSend.Location = new Point(917, 521);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(118, 78);
        btnSend.TabIndex = 2;
        btnSend.Text = "Send";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        // 
        // ChatControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(btnSend);
        Controls.Add(txtUserInput);
        Controls.Add(txtLog);
        Name = "ChatControl";
        Size = new Size(1050, 617);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtLog;
    private TextBox txtUserInput;
    private Button btnSend;
}
