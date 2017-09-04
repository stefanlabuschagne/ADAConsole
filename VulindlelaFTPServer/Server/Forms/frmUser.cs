using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VulindlelaFTPServer
{
    public partial class frmUser : Form
    {
        string OldUserName;
        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(string UserName)
        {
            InitializeComponent();
            OldUserName = UserName;
            Text = "Vulindlela FTP Server :: Edit User";
            lblHeader.Text = "Edit User";

            string Password = null, StartUpPath = null, PermissionSet = null;
            bool EnableUser = false;
            if (ApplicationSettings.GetUser(UserName, out Password, out StartUpPath, out PermissionSet, out EnableUser))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                txtStartUpPath.Text = StartUpPath;
                chkEnableUser.Checked = EnableUser;

                char[] Permissions = PermissionSet.ToCharArray();
                chkAllowStoreFiles.Checked = Permissions[0] == '1';
                chkAllowStoreFolders.Checked = Permissions[1] == '1';
                chkAllowRenameFiles.Checked = Permissions[2] == '1';
                chkAllowRenameFolders.Checked = Permissions[3] == '1';
                chkAllowDeleteFiles.Checked = Permissions[4] == '1';
                chkAllowDeleteFolders.Checked = Permissions[5] == '1';
                chkAllowCopyFiles.Checked = Permissions[6] == '1';
                chkAllowViewHiddenFiles.Checked = Permissions[7] == '1';
                chkAllowViewHiddenFolders.Checked = Permissions[8] == '1';
            }
            else
            {
                MessageBox.Show("The user with the name " + OldUserName + " does not exist.", "Vulindlela FTP Server");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        void BrowseRootFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Select the Root Folder for the user";
            FBD.ShowNewFolderButton = true;
            FBD.SelectedPath = txtStartUpPath.Text;
            if (FBD.ShowDialog() == DialogResult.Cancel) return;
            txtStartUpPath.Text = FBD.SelectedPath;
        }

        void SaveUser_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtUserName.Text.Trim();
            txtStartUpPath.Text = txtStartUpPath.Text.Trim();

            string Message = string.Empty;

            if (txtUserName.Text.Length < 2) Message = "User Name cannot be lesser than 2 chars\n ";
            if (txtPassword.Text.Length < 2) Message += "Password cannot be lesser than 2 chars\n";
            if (!System.IO.Directory.Exists(txtStartUpPath.Text)) Message += "The selected root path does not exists\n";

            string PermissionSet = string.Empty;

            PermissionSet += (chkAllowStoreFiles.Checked) ? "1" : "0";
            PermissionSet += (chkAllowStoreFolders.Checked) ? "1" : "0";
            PermissionSet += (chkAllowRenameFiles.Checked) ? "1" : "0";
            PermissionSet += (chkAllowRenameFolders.Checked) ? "1" : "0";
            PermissionSet += (chkAllowDeleteFiles.Checked) ? "1" : "0";
            PermissionSet += (chkAllowDeleteFolders.Checked) ? "1" : "0";
            PermissionSet += (chkAllowCopyFiles.Checked) ? "1" : "0";

            if (PermissionSet.IndexOf('1') == -1) Message += "The user requires atleast a single permission.\n";

            PermissionSet += (chkAllowViewHiddenFiles.Checked) ? "1" : "0";
            PermissionSet += (chkAllowViewHiddenFolders.Checked) ? "1" : "0";

            if (Message.Length != 0)
            {
                MessageBox.Show(Message, "Vulindlela FTP Server");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string servername = FTPUser.GetDCString();
            Collection m = new Collection();
            m = FTPUser.GetUserGroups(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            foreach (string item in m)
            {
                try
                {
                    MessageBox.Show(item.ToString(), "Vulindlela FTP Server");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
            return;
        }

        void EncryptSettingsFile(string Path)
        {
            FileStream FS = new FileStream(Path, FileMode.Open, FileAccess.ReadWrite);
            byte[] Buffer = new byte[(int)FS.Length];
            FS.Read(Buffer, 0, Buffer.Length);
            FS.Position = 0;
            // jOHAN vERMEULEN
            ///FS.Write(Crypt(Buffer), 0, Buffer.Length);
            FS.Write(Buffer, 0, Buffer.Length);
            FS.Close();
            FS = null;
        }

        byte[] Crypt(byte[] Buffer)
        {
            for (int i = 0; i < Buffer.Length; i++)
            {
                Buffer[i] ^= 36;
            }
            return Buffer;
        }
    }
}

