using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VS2005Components;
namespace PropertyGridDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pgOriginal.SelectedObject = new Department();
            pgCustom.SelectedObject = new Department();
        }
    }
}