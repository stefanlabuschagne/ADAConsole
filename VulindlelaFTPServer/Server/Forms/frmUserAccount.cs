using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Specialized;

namespace VulindlelaFTPServer
{
    internal partial class frmUserAccount : Form
    {
        public frmUserAccount()
        {
            InitializeComponent();
            UpdateUserList();
        }
        void UpdateUserList()
        {
            ListViewItem lst;
            lstUserList.Items.Clear();
            StringCollection UserList = ApplicationSettings.GetFTPUsers3();
            foreach (string User in UserList)
            {
                ListViewItem UserItem = new ListViewItem(new string[] {User, "RootDirectory", "RootDirectory"});
                lst = lstUserList.Items.Add(UserItem);
            }
        }
        void CreateNewUser_Click(object sender, EventArgs e)
        {
            frmUser NewUser = new frmUser();
            if (NewUser.ShowDialog() == DialogResult.Cancel) return;
            UpdateUserList();
        }
        void EditUser_Click(object sender, EventArgs e)
        {
            if (lstUserList.SelectedItems.Count == 0) return;

            frmUser EditUser = new frmUser(lstUserList.SelectedItems[0].SubItems[0].Text);
            if (EditUser.ShowDialog() == DialogResult.Cancel) return;
            UpdateUserList();
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmUserAccount_Load(object sender, EventArgs e)
        {

        }
    }
}