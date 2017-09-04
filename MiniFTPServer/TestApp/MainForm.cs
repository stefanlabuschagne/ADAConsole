using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibFTPServ.FTP;
using LibFTPServ.VFS;

namespace TestApp
{
    public partial class MainForm : Form
    {
        FTPServer _serv;

        public MainForm()
        {
            InitializeComponent();
            _serv = new FTPServer();
            _serv.OnLogEvent += new FTPLogEventHandler(_serv_OnLogEvent);
            _serv.DownloadSpeedLimit = 120 * 1024;
            userManager1.Manager = _serv.Users;
        }

        void _serv_OnLogEvent(object sender, FTPLogEventArgs e)
        {
            ListViewItem litem = new ListViewItem();
            litem.Text = e.EventDate.ToShortTimeString();
            litem.SubItems.Add(Helpers.FtpEventToString(e.EventType));
            litem.SubItems.Add(Helpers.BoolConvert(e.Succes));
            litem.SubItems.Add(e.User);

            StringBuilder args = new StringBuilder();
            foreach (string arg in e.arguments)
            {
                args.Append(arg);
                args.Append(", ");
            }
            litem.SubItems.Add(args.ToString());
            LogList.Items.Add(litem);
        }

        bool CanStart()
        {
            if (_serv.Users.Count < 1) return false;
            if (_serv.Port < 1) return false;
            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress addr;
            if (CanStart())
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                PanelSettings.Enabled = false;

                if (cbDlLimit.Checked) _serv.DownloadSpeedLimit = (int)(NumDlLimit.Value * 1024);
                else _serv.DownloadSpeedLimit = -1;

                if (cbUlLimit.Checked) _serv.UploadSpeedLimit = (int)(NumUlLimit.Value * 1024);
                else _serv.UploadSpeedLimit = -1;

                foreach (string ip in tbAllow.Lines)
                {
                    System.Net.IPAddress.TryParse(ip, out addr);
                    _serv.AcceptedAdresses.Add(addr);
                }

                foreach (string ip in tbBan.Lines)
                {
                    System.Net.IPAddress.TryParse(ip, out addr);
                    _serv.BannedAdresses.Add(addr);
                }

                _serv.Port = (int)NumPort.Value;
                _serv.Start();
            }
            else MessageBox.Show("Server can't start, because there are no users defined.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            PanelSettings.Enabled = true;
            _serv.Stop();
        }

        private void cbUlLimit_CheckedChanged(object sender, EventArgs e)
        {
            NumUlLimit.Enabled = cbUlLimit.Checked;
        }

        private void cbDlLimit_CheckedChanged(object sender, EventArgs e)
        {
            NumDlLimit.Enabled = cbDlLimit.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnStart.Enabled) btnStop_Click(sender, null);
            Properties.Settings.Default.Save();
            userManager1.SaveConfiguration();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.Visible = false;
            else this.Visible = true;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Visible = true;
                this.BringToFront();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
            }
        }

        private void BtnLogClear_Click(object sender, EventArgs e)
        {
            LogList.Items.Clear();
        }
    }
}
