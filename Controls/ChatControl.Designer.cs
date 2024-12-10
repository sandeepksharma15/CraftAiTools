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
        txtLog.Font = new Font("RobotoMono Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtLog.Location = new Point(3, 3);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ReadOnly = true;
        txtLog.Size = new Size(1044, 512);
        txtLog.TabIndex = 0;
        // 
        // txtUserInput
        // 
        txtUserInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        txtUserInput.Font = new Font("RobotoMono Nerd Font", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtUserInput.Location = new Point(3, 522);
        txtUserInput.Multiline = true;
        txtUserInput.Name = "txtUserInput";
        txtUserInput.Size = new Size(908, 93);
        txtUserInput.TabIndex = 1;
        // 
        // btnSend
        // 
        btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSend.FlatStyle = FlatStyle.System;
        btnSend.Font = new Font("RobotoMono Nerd Font", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSend.Location = new Point(917, 522);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(130, 93);
        btnSend.TabIndex = 2;
        btnSend.Text = "Send";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += BtnSend_Click;
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
