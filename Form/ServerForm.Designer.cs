namespace Jasarsoft.Multiplayer
{
    partial class ServerForm
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonServer = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(128, 21);
            this.textBoxAddress.MaxLength = 32;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(220, 22);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.Location = new System.Drawing.Point(12, 21);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(110, 22);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "IP Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 49);
            this.textBoxName.MaxLength = 128;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(128, 77);
            this.textBoxComment.MaxLength = 128;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(220, 22);
            this.textBoxComment.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 22);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Server Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelComment
            // 
            this.labelComment.Location = new System.Drawing.Point(12, 77);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(110, 22);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Optional Comment:";
            this.labelComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonServer
            // 
            this.buttonServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonServer.Location = new System.Drawing.Point(128, 115);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(220, 38);
            this.buttonServer.TabIndex = 8;
            this.buttonServer.Text = "SERVER";
            this.buttonServer.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(15, 115);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(107, 38);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AcceptButton = this.buttonServer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(360, 165);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonServer);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PES6 Tools: ";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.Button buttonReset;
    }
}