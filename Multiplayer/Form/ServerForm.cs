using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jasarsoft.Multiplayer
{
    public partial class ServerForm : Form
    {
        private bool saved;
        
        public ServerForm()
        {
            InitializeComponent();

            Server.Default();
            this.saved = false;
        }


        public bool IsSaved
        {
            get { return this.saved; }
        }


        private void ServerForm_Load(object sender, EventArgs e)
        {
            this.textBoxName.Text = Server.Name;
            this.textBoxAddress.Text = Server.Address;
            this.textBoxComment.Text = Server.Comment;
        }

        private void ServerForm_Shown(object sender, EventArgs e)
        {
            this.textBoxAddress.Focus();
        }

        public bool Valid()
        {
            ServerDefault sd = new ServerDefault();

            if (this.textBoxName.Text.ToLower() == sd.Name) return false;
            if (this.textBoxAddress.Text.ToLower() == sd.Address) return false;
            if (this.textBoxComment.Text.ToLower() == sd.Comment) return false;

            return true;
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            if (this.Valid())
            {
                this.saved = true;
                Server.Name = this.textBoxName.Text;
                Server.Address = this.textBoxAddress.Text;
                Server.Comment = this.textBoxComment.Text;

                this.Close();
                return;
            }

            Title caption = new Title();
            MessageBox.Show("Values in text fields can not be default.", caption.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
