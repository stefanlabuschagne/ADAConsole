using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace tabtest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private tabtest.FunkyButton FunkyButton1;
		private tabtest.FunkyButton funkyButton2;
		private tabtest.FunkyButton funkyButton1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.funkyButton1 = new tabtest.FunkyButton();
			((System.ComponentModel.ISupportInitialize)(this.funkyButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// funkyButton1
			// 
			this.funkyButton1.BackColor = System.Drawing.Color.Blue;
			this.funkyButton1.Location = new System.Drawing.Point(96, 40);
			this.funkyButton1.Name = "funkyButton1";
			this.funkyButton1.Points.AddRange(new System.Drawing.Point[] {
																			 new System.Drawing.Point(207, 6),
																			 new System.Drawing.Point(239, 63),
																			 new System.Drawing.Point(117, 126),
																			 new System.Drawing.Point(83, 69)});
			this.funkyButton1.Size = new System.Drawing.Size(264, 160);
			this.funkyButton1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.funkyButton1});
			this.Name = "Form1";
			this.Text = "Control Test";
			((System.ComponentModel.ISupportInitialize)(this.funkyButton1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
