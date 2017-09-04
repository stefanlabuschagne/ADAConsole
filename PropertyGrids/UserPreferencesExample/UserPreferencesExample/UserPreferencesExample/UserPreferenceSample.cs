using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserPreferencesExample.Properties;

namespace UserPreferencesExample
{
    public partial class UserPreferenceSample : Form
    {
        Settings defaultSettings;
        public UserPreferenceSample()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (defaultSettings != null)
            {
                //Save button's settings
                defaultSettings.ButtonBackColor = btnSave.BackColor;
                defaultSettings.SaveButtonText = btnSave.Text;

                //Save the Form's Settings
                defaultSettings.FirstFormHeader = this.Text;
                defaultSettings.FormBackColor = this.BackColor;
                defaultSettings.FormForeColor = this.ForeColor;
                defaultSettings.FormOpacity = this.Opacity;
                defaultSettings.FormWindowState = this.WindowState;

                defaultSettings.Save();
            }
        }

        private void MyFirstForm_Load(object sender, EventArgs e)
        {
            defaultSettings = new Settings();
        }

        private void txtFormHeader_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (this.Text.Equals(defaultSettings.FirstFormHeader))
                this.Text = string.Empty;
            else
                this.Text = this.txtFormHeader.Text;
        }

        private void txtButtonText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.btnSave.Text.Equals(defaultSettings.FirstFormHeader))
                this.btnSave.Text = string.Empty;
            else
                this.btnSave.Text = this.txtButtonText.Text;
        }
    }
}
