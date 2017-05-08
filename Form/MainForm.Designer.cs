namespace Jasarsoft.Multiplayer
{
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
            this.listViewServer = new System.Windows.Forms.ListView();
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureHelp = new System.Windows.Forms.PictureBox();
            this.pictureAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewServer
            // 
            this.listViewServer.CheckBoxes = true;
            this.listViewServer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAddress,
            this.columnName,
            this.columnComment});
            this.listViewServer.Location = new System.Drawing.Point(12, 42);
            this.listViewServer.Name = "listViewServer";
            this.listViewServer.ShowGroups = false;
            this.listViewServer.Size = new System.Drawing.Size(474, 132);
            this.listViewServer.TabIndex = 4;
            this.listViewServer.UseCompatibleStateImageBehavior = false;
            this.listViewServer.View = System.Windows.Forms.View.Details;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "IP Address";
            this.columnAddress.Width = 110;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 190;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.Width = 170;
            // 
            // labelHeader
            // 
            this.labelHeader.Location = new System.Drawing.Point(12, 18);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(420, 21);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Select the servers that will be active:";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 32);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(96, 180);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(78, 32);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(180, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 32);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(264, 180);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(78, 32);
            this.buttonRestore.TabIndex = 8;
            this.buttonRestore.Text = "RESTORE";
            this.buttonRestore.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(348, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 32);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "SAVE SETTINGS";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // pictureHelp
            // 
            this.pictureHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureHelp.Image = global::Jasarsoft.Multiplayer.Properties.Resources.question;
            this.pictureHelp.Location = new System.Drawing.Point(465, 18);
            this.pictureHelp.Name = "pictureHelp";
            this.pictureHelp.Size = new System.Drawing.Size(21, 21);
            this.pictureHelp.TabIndex = 10;
            this.pictureHelp.TabStop = false;
            // 
            // pictureAbout
            // 
            this.pictureAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAbout.Image = global::Jasarsoft.Multiplayer.Properties.Resources.information;
            this.pictureAbout.Location = new System.Drawing.Point(438, 18);
            this.pictureAbout.Name = "pictureAbout";
            this.pictureAbout.Size = new System.Drawing.Size(21, 21);
            this.pictureAbout.TabIndex = 11;
            this.pictureAbout.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 224);
            this.Controls.Add(this.pictureAbout);
            this.Controls.Add(this.pictureHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewServer);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PES6 Tools: Multiplayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewServer;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureHelp;
        private System.Windows.Forms.PictureBox pictureAbout;

    }
}

