using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace VulindlelaFTPServer
{
    public partial class frmMain : Form
    {
        #region Initialisation

        frmUserAccount UserAccount;
        frmViewService ViewService;
        frmCommonSettings CommonSettings;        
        frmErrorLogs ErrorLog;
        frmOnlineUsers OnlineUsers;

        ///About AboutWindow;

        public delegate void ProcessNewInstanceDelegate();

        public void ProcessNewInstance()
        {
            this.TrayIcon.ShowBalloonTip(5000, "Vulindlela FTP Server", "Vulindlela FTP Server is already running in background. Cannot start a new instance.", ToolTipIcon.Warning);
        }

        public frmMain()
        {
            InitializeComponent();
        }

        void StartApplication(object sender, EventArgs e)
        {
            ApplicationSettings.ReadSettings();
            if (ApplicationSettings.AutoStartFTP)
            {
                ApplicationSettings.FtpServer = new FTPServer();
                ApplicationSettings.FtpServer.Start();
                mnuEnableFTPService.Checked = true;
            }
            mnuOpenFTP.Enabled = mnuEnableFTPService.Checked;
        }

        void EndApplication(object sender, FormClosingEventArgs e)
        {
            if (ApplicationSettings.FtpServer != null) ApplicationSettings.FtpServer.Stop();
        }

        void HideForm(object sender, EventArgs e)
        {
            Hide();
        }

        #endregion

        #region Config Menu Methods

        void ViewUserAccount_Click(object sender, EventArgs e)
        {
            if (UserAccount == null || !UserAccount.Visible)
                UserAccount = new frmUserAccount();
            UserAccount.Show();
        }

        void ViewService_Click(object sender, EventArgs e)
        {
            if (ViewService == null || !ViewService.Visible)
                ViewService = new frmViewService();
            ViewService.Show();
        }

        void CommonSettings_Click(object sender, EventArgs e)
        {
            if (CommonSettings == null || !CommonSettings.Visible)
                CommonSettings = new frmCommonSettings();
            CommonSettings.Show();
        }

        #endregion

        #region View Menu Methods
        void ViewOnlineUsers_Click(object sender, EventArgs e)
        {
            if (OnlineUsers == null || !OnlineUsers.Visible)
                OnlineUsers = new frmOnlineUsers();
            OnlineUsers.Show();
        }

        void ViewErrorLogs_Click(object sender, EventArgs e)
        {
            if (ErrorLog == null || !ErrorLog.Visible)
                ErrorLog = new frmErrorLogs();
            ErrorLog.Show();
        }
        #endregion

        #region Shortcut Menu Methods

        //void OpenHTTP_Click(object sender, EventArgs e)
        //{
        //    Process.Start("http://" + ApplicationSettings.HostName + ":" + ApplicationSettings.HTTPPort);
        //}

        void OpenFTP_Click(object sender, EventArgs e)
        {
            //Process.Start("ftp://" + ApplicationSettings.HostName + ":" + ApplicationSettings.FTPPort);
            Process.Start("ftp://" + VulindlelaFTPServer.Properties.Settings.Default.HostName + ":" + VulindlelaFTPServer.Properties.Settings.Default.FTP_PORT);
            //Session s;

        }

        void EnableFTPService_Click(object sender, EventArgs e)
        {
            if (mnuEnableFTPService.Checked = !mnuEnableFTPService.Checked)
            {
                ApplicationSettings.FtpServer.Start();
            }
            else
            {
                ApplicationSettings.FtpServer.Stop();
            }
            mnuOpenFTP.Enabled = mnuEnableFTPService.Checked;
        }

        //void EnableHTTPService_Click(object sender, EventArgs e)
        //{
        //    if (mnuEnableHTTPService.Checked = !mnuEnableHTTPService.Checked)
        //     {
        //        ApplicationSettings.HttpServer.Stop();
        //        ///ApplicationSettings.HttpServer.Start();
        //     }
        //     else
        //     {
        //        ApplicationSettings.HttpServer.Stop();
        //     }
        //    mnuOpenHTTP.Enabled = mnuEnableHTTPService.Checked;
        //}

        #endregion

        #region Other Menus
        void ExitApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit Vulindlela FTP Server?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        void TrayContext_Opened(object sender, EventArgs e)
        {
            mnuEnableFTPService.Checked = ApplicationSettings.FtpServer != null && ApplicationSettings.FtpServer.IsRunning;
            //mnuEnableHTTPService.Checked = ApplicationSettings.HttpServer != null && ApplicationSettings.HttpServer.IsRunning;
        }

        #endregion
    }
}