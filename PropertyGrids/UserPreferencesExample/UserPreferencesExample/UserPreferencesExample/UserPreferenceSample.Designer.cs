namespace UserPreferencesExample
{
    partial class UserPreferenceSample
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbcMyTab = new System.Windows.Forms.TabControl();
            this.tbPage1 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tbPage2 = new System.Windows.Forms.TabPage();
            this.propertyGridButton = new System.Windows.Forms.PropertyGrid();
            this.txtFormHeader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtButtonText = new System.Windows.Forms.TextBox();
            this.tbcMyTab.SuspendLayout();
            this.tbPage1.SuspendLayout();
            this.tbPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = global::UserPreferencesExample.Properties.Settings.Default.ButtonBackColor;
            this.btnSave.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UserPreferencesExample.Properties.Settings.Default, "SaveButtonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSave.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::UserPreferencesExample.Properties.Settings.Default, "ButtonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSave.Location = new System.Drawing.Point(345, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = global::UserPreferencesExample.Properties.Settings.Default.SaveButtonText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbcMyTab
            // 
            this.tbcMyTab.Controls.Add(this.tbPage1);
            this.tbcMyTab.Controls.Add(this.tbPage2);
            this.tbcMyTab.Location = new System.Drawing.Point(12, 29);
            this.tbcMyTab.Name = "tbcMyTab";
            this.tbcMyTab.SelectedIndex = 0;
            this.tbcMyTab.Size = new System.Drawing.Size(408, 409);
            this.tbcMyTab.TabIndex = 1;
            // 
            // tbPage1
            // 
            this.tbPage1.Controls.Add(this.propertyGrid1);
            this.tbPage1.Location = new System.Drawing.Point(4, 22);
            this.tbPage1.Name = "tbPage1";
            this.tbPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage1.Size = new System.Drawing.Size(400, 383);
            this.tbPage1.TabIndex = 0;
            this.tbPage1.Text = "Form Properties";
            this.tbPage1.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this;
            this.propertyGrid1.Size = new System.Drawing.Size(394, 377);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tbPage2
            // 
            this.tbPage2.Controls.Add(this.propertyGridButton);
            this.tbPage2.Location = new System.Drawing.Point(4, 22);
            this.tbPage2.Name = "tbPage2";
            this.tbPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage2.Size = new System.Drawing.Size(400, 383);
            this.tbPage2.TabIndex = 1;
            this.tbPage2.Text = "Button Properties";
            this.tbPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGridButton
            // 
            this.propertyGridButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridButton.Location = new System.Drawing.Point(3, 3);
            this.propertyGridButton.Name = "propertyGridButton";
            this.propertyGridButton.SelectedObject = this.btnSave;
            this.propertyGridButton.Size = new System.Drawing.Size(394, 377);
            this.propertyGridButton.TabIndex = 0;
            // 
            // txtFormHeader
            // 
            this.txtFormHeader.Location = new System.Drawing.Point(83, 3);
            this.txtFormHeader.Name = "txtFormHeader";
            this.txtFormHeader.Size = new System.Drawing.Size(100, 20);
            this.txtFormHeader.TabIndex = 2;
            this.txtFormHeader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormHeader_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Form Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buton Text";
            // 
            // txtButtonText
            // 
            this.txtButtonText.Location = new System.Drawing.Point(264, 3);
            this.txtButtonText.Name = "txtButtonText";
            this.txtButtonText.Size = new System.Drawing.Size(100, 20);
            this.txtButtonText.TabIndex = 4;
            this.txtButtonText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtButtonText_KeyPress);
            // 
            // UserPreferenceSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::UserPreferencesExample.Properties.Settings.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(432, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtButtonText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormHeader);
            this.Controls.Add(this.tbcMyTab);
            this.Controls.Add(this.btnSave);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UserPreferencesExample.Properties.Settings.Default, "FirstFormHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::UserPreferencesExample.Properties.Settings.Default, "FormWindowState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::UserPreferencesExample.Properties.Settings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Opacity", global::UserPreferencesExample.Properties.Settings.Default, "FormOpacity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::UserPreferencesExample.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::UserPreferencesExample.Properties.Settings.Default.FormForeColor;
            this.Name = "UserPreferenceSample";
            this.Opacity = global::UserPreferencesExample.Properties.Settings.Default.FormOpacity;
            this.Text = global::UserPreferencesExample.Properties.Settings.Default.FirstFormHeader;
            this.WindowState = global::UserPreferencesExample.Properties.Settings.Default.FormWindowState;
            this.Load += new System.EventHandler(this.MyFirstForm_Load);
            this.tbcMyTab.ResumeLayout(false);
            this.tbPage1.ResumeLayout(false);
            this.tbPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tbcMyTab;
        private System.Windows.Forms.TabPage tbPage1;
        private System.Windows.Forms.TabPage tbPage2;
        private System.Windows.Forms.PropertyGrid propertyGridButton;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox txtFormHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtButtonText;
        private System.Windows.Forms.Label label1;
    }
}