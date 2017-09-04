using System;
using System.Windows.Forms;

namespace VulindlelaFTPServer
{
    public partial class frmOnlineUsers : Form
    {
        public frmOnlineUsers()
        {
            InitializeComponent();
            RefreshUsersList(null, null);
        }

        void DisconnectUser(object sender, EventArgs e)
        {
            if (lstOnlineUsers.SelectedItems.Count == 0) return;

            string SelectedConnection_SessionID = lstOnlineUsers.SelectedItems[0].SubItems[0].Text;
            
            foreach (FTPClient ConnUser in FTPServer.FTPClients)
            {
                if (ConnUser.SessionID == SelectedConnection_SessionID)
                {
                    ConnUser.Disconnect();
                    break;
                }
            }
            RefreshUsersList(null, null);
        }

        void ViewConnectionHistory(object sender, EventArgs e)
        {
            MessageBox.Show("This menu is reserved for future implementation. Option is currently unavailable.", "VulindlelaFTPServer");
        }

        void RefreshUsersList(object sender, EventArgs e)
        {
            lstOnlineUsers.Items.Clear();
            foreach (FTPClient ConnUser in FTPServer.FTPClients)
            {
                string[] ItemArray = new string[5];
                ItemArray[0] = ConnUser.SessionID;
                ItemArray[1] = ConnUser.ConnectedUser.UserName;
                ItemArray[2] = ConnUser.EndPoint;
                ItemArray[3] = ConnUser.ConnectedTime.ToString(ApplicationSettings.DateTimeFormat);
                ItemArray[4] = ConnUser.LastInteraction.ToString(ApplicationSettings.DateTimeFormat);
                lstOnlineUsers.Items.Add(new ListViewItem(ItemArray));                
            }
        }
    }
}