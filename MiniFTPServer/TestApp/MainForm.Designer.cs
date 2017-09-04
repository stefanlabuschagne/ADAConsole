namespace TestApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelSettings = new System.Windows.Forms.Panel();
            this.NumDlLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumPort = new System.Windows.Forms.NumericUpDown();
            this.NumUlLimit = new System.Windows.Forms.NumericUpDown();
            this.cbDlLimit = new System.Windows.Forms.CheckBox();
            this.cbUlLimit = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbAllow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LogList = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arguments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Succes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnLogClear = new System.Windows.Forms.Button();
            this.userManager1 = new TestApp.UserManagerControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDlLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUlLimit)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 297);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.PanelSettings);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General settings";
            // 
            // PanelSettings
            // 
            this.PanelSettings.Controls.Add(this.NumDlLimit);
            this.PanelSettings.Controls.Add(this.label3);
            this.PanelSettings.Controls.Add(this.label1);
            this.PanelSettings.Controls.Add(this.label2);
            this.PanelSettings.Controls.Add(this.NumPort);
            this.PanelSettings.Controls.Add(this.NumUlLimit);
            this.PanelSettings.Controls.Add(this.cbDlLimit);
            this.PanelSettings.Controls.Add(this.cbUlLimit);
            this.PanelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSettings.Location = new System.Drawing.Point(3, 3);
            this.PanelSettings.Name = "PanelSettings";
            this.PanelSettings.Size = new System.Drawing.Size(449, 204);
            this.PanelSettings.TabIndex = 14;
            // 
            // NumDlLimit
            // 
            this.NumDlLimit.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TestApp.Properties.Settings.Default, "DownloadSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumDlLimit.Enabled = false;
            this.NumDlLimit.Location = new System.Drawing.Point(86, 75);
            this.NumDlLimit.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.NumDlLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDlLimit.Name = "NumDlLimit";
            this.NumDlLimit.Size = new System.Drawing.Size(120, 20);
            this.NumDlLimit.TabIndex = 6;
            this.NumDlLimit.Value = global::TestApp.Properties.Settings.Default.DownloadSpeed;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kbytes/sec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kbytes/sec";
            // 
            // NumPort
            // 
            this.NumPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TestApp.Properties.Settings.Default, "ServerPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumPort.Location = new System.Drawing.Point(86, 26);
            this.NumPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPort.Name = "NumPort";
            this.NumPort.Size = new System.Drawing.Size(120, 20);
            this.NumPort.TabIndex = 4;
            this.NumPort.Value = global::TestApp.Properties.Settings.Default.ServerPort;
            // 
            // NumUlLimit
            // 
            this.NumUlLimit.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TestApp.Properties.Settings.Default, "UploadSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumUlLimit.Enabled = false;
            this.NumUlLimit.Location = new System.Drawing.Point(86, 124);
            this.NumUlLimit.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.NumUlLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUlLimit.Name = "NumUlLimit";
            this.NumUlLimit.Size = new System.Drawing.Size(120, 20);
            this.NumUlLimit.TabIndex = 11;
            this.NumUlLimit.Value = global::TestApp.Properties.Settings.Default.UploadSpeed;
            // 
            // cbDlLimit
            // 
            this.cbDlLimit.AutoSize = true;
            this.cbDlLimit.Checked = global::TestApp.Properties.Settings.Default.DlLimit;
            this.cbDlLimit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TestApp.Properties.Settings.Default, "DlLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbDlLimit.Location = new System.Drawing.Point(20, 52);
            this.cbDlLimit.Name = "cbDlLimit";
            this.cbDlLimit.Size = new System.Drawing.Size(132, 17);
            this.cbDlLimit.TabIndex = 9;
            this.cbDlLimit.Text = "Download Speed Limit";
            this.cbDlLimit.UseVisualStyleBackColor = true;
            this.cbDlLimit.CheckedChanged += new System.EventHandler(this.cbDlLimit_CheckedChanged);
            // 
            // cbUlLimit
            // 
            this.cbUlLimit.AutoSize = true;
            this.cbUlLimit.Checked = global::TestApp.Properties.Settings.Default.Ullimit;
            this.cbUlLimit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TestApp.Properties.Settings.Default, "Ullimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbUlLimit.Location = new System.Drawing.Point(20, 101);
            this.cbUlLimit.Name = "cbUlLimit";
            this.cbUlLimit.Size = new System.Drawing.Size(118, 17);
            this.cbUlLimit.TabIndex = 10;
            this.cbUlLimit.Text = "Upload Speed Limit";
            this.cbUlLimit.UseVisualStyleBackColor = true;
            this.cbUlLimit.CheckedChanged += new System.EventHandler(this.cbUlLimit_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(367, 213);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 50);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(281, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 50);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userManager1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(455, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ip Ban";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbAllow);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1MinSize = 224;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbBan);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2MinSize = 10;
            this.splitContainer1.Size = new System.Drawing.Size(449, 265);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbAllow
            // 
            this.tbAllow.BackColor = System.Drawing.Color.LightGreen;
            this.tbAllow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApp.Properties.Settings.Default, "AcceptList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAllow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAllow.Location = new System.Drawing.Point(0, 13);
            this.tbAllow.Multiline = true;
            this.tbAllow.Name = "tbAllow";
            this.tbAllow.Size = new System.Drawing.Size(224, 252);
            this.tbAllow.TabIndex = 1;
            this.tbAllow.Text = global::TestApp.Properties.Settings.Default.AcceptList;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alowed IP Adresses: (one/line)";
            // 
            // tbBan
            // 
            this.tbBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApp.Properties.Settings.Default, "BanList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBan.Location = new System.Drawing.Point(0, 13);
            this.tbBan.Multiline = true;
            this.tbBan.Name = "tbBan";
            this.tbBan.Size = new System.Drawing.Size(224, 252);
            this.tbBan.TabIndex = 2;
            this.tbBan.Text = global::TestApp.Properties.Settings.Default.BanList;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Banned IP Adresses: (one/line)";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Mini FTP Server";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.BtnLogClear);
            this.tabPage4.Controls.Add(this.LogList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(455, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            // 
            // LogList
            // 
            this.LogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Event,
            this.Succes,
            this.User,
            this.Arguments});
            this.LogList.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogList.Location = new System.Drawing.Point(3, 3);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(449, 236);
            this.LogList.TabIndex = 0;
            this.LogList.UseCompatibleStateImageBehavior = false;
            this.LogList.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 200;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 100;
            // 
            // Arguments
            // 
            this.Arguments.Text = "Arguments";
            this.Arguments.Width = 300;
            // 
            // Succes
            // 
            this.Succes.Text = "Succes ?";
            // 
            // BtnLogClear
            // 
            this.BtnLogClear.Location = new System.Drawing.Point(8, 242);
            this.BtnLogClear.Name = "BtnLogClear";
            this.BtnLogClear.Size = new System.Drawing.Size(75, 23);
            this.BtnLogClear.TabIndex = 1;
            this.BtnLogClear.Text = "Clear Log";
            this.BtnLogClear.UseVisualStyleBackColor = true;
            this.BtnLogClear.Click += new System.EventHandler(this.BtnLogClear_Click);
            // 
            // userManager1
            // 
            this.userManager1.BackColor = System.Drawing.SystemColors.Control;
            this.userManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManager1.Location = new System.Drawing.Point(3, 3);
            this.userManager1.Name = "userManager1";
            this.userManager1.Size = new System.Drawing.Size(449, 265);
            this.userManager1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 297);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TestApp.Properties.Settings.Default, "WindowPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::TestApp.Properties.Settings.Default.WindowPosition;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mini FTP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PanelSettings.ResumeLayout(false);
            this.PanelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDlLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUlLimit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private UserManagerControl userManager1;
        private System.Windows.Forms.NumericUpDown NumPort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelSettings;
        private System.Windows.Forms.NumericUpDown NumDlLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumUlLimit;
        private System.Windows.Forms.CheckBox cbDlLimit;
        private System.Windows.Forms.CheckBox cbUlLimit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbAllow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView LogList;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Succes;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Arguments;
        private System.Windows.Forms.Button BtnLogClear;
    }
}

