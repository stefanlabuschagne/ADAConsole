using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibFTPServ.FTP;
using System.IO;

namespace TestApp
{
    public partial class UserManagerControl : UserControl
    {
        private UserManager _um;
        private int _newcounter;
        private bool _modified;

        public UserManagerControl()
        {
            InitializeComponent();
        }

        public UserManager Manager
        {
            set
            {
                _um = value;
                _newcounter = 1;

                if (File.Exists(Helpers.AppDir + @"\users.xml"))
                {
                    try
                    {
                        Stream s = File.OpenRead(Helpers.AppDir + @"\users.xml");
                        _um.Deserialize(s);
                        s.Close();
                        UpdateUserPanel();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Can't load user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void SaveConfiguration()
        {
            try
            {
                if (File.Exists(Helpers.AppDir + @"\users.xml")) File.Delete(Helpers.AppDir + @"\users.xml");
                Stream s = File.Create(Helpers.AppDir + @"\users.xml");
                _um.Serialize(s);
                s.Close();
                UpdateUserPanel();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't save user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserPanel()
        {
            lbUsers.Items.Clear();
            lbUsers.Items.AddRange(_um.UserNames);
        }

        private void SetPermissions(FTPUserPermission perm)
        {
            cbRDelete.Checked = perm.Delete;
            cbRListhidden.Checked = perm.ListHidden;
            cbRRename.Checked = perm.Rename;
            cbRUpload.Checked = perm.Upload;
        }

        private FTPUserPermission SetPermissions()
        {
            FTPUserPermission ret = new FTPUserPermission();
            ret.Upload = cbRUpload.Checked;
            ret.Rename = cbRRename.Checked;
            ret.ListHidden = cbRListhidden.Checked;
            ret.Delete = cbRDelete.Checked;
            return ret;
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0 && lbUsers.SelectedIndex > lbUsers.Items.Count) btnDelete.Enabled = false;
            else
            {
                if (_modified)
                {
                    DialogResult dr = MessageBox.Show("User info changed. Save changes ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) btnSave_Click(sender, e);
                }

                tbUserName.Text = "";
                tbUserPass.Text = "";
                tbUserHome.Text = "";

                FTPUser u = _um[lbUsers.SelectedItem.ToString()];

                tbUserName.Text = u.Name;
                tbUserPass.Text = u.SHA1Password;
                tbUserHome.Text = u.Startupdir;
                SetPermissions(u.Permissions);

                btnDelete.Enabled = true;
                _modified = false;
                btnSave.Enabled = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _um.AddUser(new FTPUser("New user " + _newcounter.ToString(), ""));
            UpdateUserPanel();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FTPUser u = _um[lbUsers.SelectedItem.ToString()];
            u.Name = tbUserName.Text;
            u.SetPassword(tbUserPass.Text);
            u.Permissions = SetPermissions();
            u.Startupdir = tbUserHome.Text;
            btnSave.Enabled = false;
            UpdateUserPanel();
        }

        private void TextfieldChanged(object sender, EventArgs e)
        {
            _modified = true;
            btnSave.Enabled = true;
        }

        private void RightsChanges(object sender, EventArgs e)
        {
            _modified = true;
            btnSave.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUserHome.Text))
                FolderBrowser.SelectedPath = tbUserHome.Text;
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbUserHome.Text = FolderBrowser.SelectedPath;
            }
        }
    }
}
