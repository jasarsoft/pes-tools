using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jasarsoft.Multiplayer
{
    public partial class MainForm : Form
    {
        private Host host;

        public MainForm()
        {
            InitializeComponent();

            host = new Host();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.listViewServer.Items.Clear();
            
            this.buttonSave.Enabled = true;
            this.buttonAdd.Enabled = true;
            this.buttonEdit.Enabled = false;
            this.buttonDelete.Enabled = false;
            this.buttonRestore.Enabled = false;
            
            if (host.Valid() && host.Read())
            {
                foreach (string server in host.Server)
                {
                    string temp = server;
                    ListViewItem item = new ListViewItem();

                    RemoveWhitespace(ref temp);
                    if (temp.StartsWith("#"))
                    {
                        item.Checked = false;
                        temp = temp.Remove(0, 1);
                    }
                    RemoveWhitespace(ref temp);
                    //address
                    item.Text = temp.Remove(temp.IndexOf(" "));
                    //name
                    temp = temp.Remove(0, temp.IndexOf(" ") + 1);
                    item.SubItems.Add(temp.Remove(temp.IndexOf("#") - 1));
                    //comment
                    item.SubItems.Add(temp.Remove(0, temp.IndexOf("#") + 1));

                    this.listViewServer.Items.Add(item);
                }
            }

            this.buttonSave.Select();
        }

        private void RemoveWhitespace(ref string line)
        {
            bool done = false;

            do
            {
                if (line.StartsWith(" "))
                    line = line.Remove(0, 1);
                else
                    done = true;
            } while (done);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ServerForm sf = new ServerForm();

            sf.ShowDialog(this);
            if(sf.Saved)
            {
                ListViewItem item = new ListViewItem();

                item.Checked = true;
                item.Text = Server.Address;
                item.SubItems.Add(Server.Name);
                item.SubItems.Add(Server.Comment);
                this.listViewServer.Items.Add(item);
                this.buttonRestore.Enabled = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listViewServer.SelectedItems.Count == 0)
            {
                Title caption = new Title();
                string text = "Please select the server form the list that you want to delete.";
                MessageBox.Show(text, caption.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ServerForm sf = new ServerForm();
            int index = this.listViewServer.Items.IndexOf(this.listViewServer.SelectedItems[0]);
            
            Server.Address = this.listViewServer.Items[index].Text;
            Server.Name = this.listViewServer.Items[index].SubItems[1].Text;
            Server.Comment = this.listViewServer.Items[index].SubItems[2].Text;

            sf.ShowDialog(this);
            if (sf.Saved)
            {
                this.listViewServer.Items[index].Text = Server.Address;
                this.listViewServer.Items[index].SubItems[1].Text = Server.Name;
                this.listViewServer.Items[index].SubItems[2].Text = Server.Comment;
            }

            this.buttonRestore.Enabled = true;
            this.listViewServer.Items[index].Selected = false;
        }

        private void listViewServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewServer.SelectedItems.Count > 0)
            {
                this.buttonEdit.Enabled = true;
                this.buttonDelete.Enabled = true;
            }  
            else
            {
                this.buttonEdit.Enabled = false;
                this.buttonDelete.Enabled = false;
            }

            this.buttonSave.Select();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listViewServer.SelectedItems.Count == 0)
            {
                Title caption = new Title();
                string text = "Please select the server form the list that you want to delete.";
                MessageBox.Show(text, caption.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int index = this.listViewServer.Items.IndexOf(this.listViewServer.SelectedItems[0]);
            this.listViewServer.Items[index].Remove();
            this.buttonRestore.Enabled = true;
            this.buttonSave.Select();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            this.MainForm_Load(sender, e);
        }

    }
}
