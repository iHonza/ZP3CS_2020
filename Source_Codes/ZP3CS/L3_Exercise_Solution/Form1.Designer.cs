namespace L3_Exercise_Solution
{
    partial class Form1
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
            this.colorDropDown = new System.Windows.Forms.ComboBox();
            this.showColorBtn = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.Ginput = new System.Windows.Forms.TextBox();
            this.Rinput = new System.Windows.Forms.TextBox();
            this.Binput = new System.Windows.Forms.TextBox();
            this.panelRGB = new System.Windows.Forms.Panel();
            this.ColorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // colorDropDown
            // 
            this.colorDropDown.FormattingEnabled = true;
            this.colorDropDown.Location = new System.Drawing.Point(25, 15);
            this.colorDropDown.Name = "colorDropDown";
            this.colorDropDown.Size = new System.Drawing.Size(213, 21);
            this.colorDropDown.TabIndex = 0;
            this.colorDropDown.SelectedIndexChanged += new System.EventHandler(this.colorDropDown_SelectedIndexChanged);
            // 
            // showColorBtn
            // 
            this.showColorBtn.Location = new System.Drawing.Point(25, 53);
            this.showColorBtn.Name = "showColorBtn";
            this.showColorBtn.Size = new System.Drawing.Size(212, 23);
            this.showColorBtn.TabIndex = 1;
            this.showColorBtn.Text = "Show selected color";
            this.showColorBtn.UseVisualStyleBackColor = true;
            this.showColorBtn.Click += new System.EventHandler(this.ShowColorBtn_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(25, 120);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(212, 181);
            this.colorPanel.TabIndex = 2;
            // 
            // Ginput
            // 
            this.Ginput.Location = new System.Drawing.Point(559, 16);
            this.Ginput.Name = "Ginput";
            this.Ginput.Size = new System.Drawing.Size(51, 20);
            this.Ginput.TabIndex = 3;
            this.Ginput.Text = "0";
            this.Ginput.TextChanged += new System.EventHandler(this.Ginput_TextChanged);
            // 
            // Rinput
            // 
            this.Rinput.Location = new System.Drawing.Point(457, 16);
            this.Rinput.Name = "Rinput";
            this.Rinput.Size = new System.Drawing.Size(51, 20);
            this.Rinput.TabIndex = 4;
            this.Rinput.Text = "0";
            this.Rinput.TextChanged += new System.EventHandler(this.Rinput_TextChanged);
            // 
            // Binput
            // 
            this.Binput.Location = new System.Drawing.Point(653, 16);
            this.Binput.Name = "Binput";
            this.Binput.Size = new System.Drawing.Size(51, 20);
            this.Binput.TabIndex = 5;
            this.Binput.Text = "0";
            this.Binput.TextChanged += new System.EventHandler(this.Binput_TextChanged);
            // 
            // panelRGB
            // 
            this.panelRGB.Location = new System.Drawing.Point(457, 73);
            this.panelRGB.Name = "panelRGB";
            this.panelRGB.Size = new System.Drawing.Size(247, 228);
            this.panelRGB.TabIndex = 3;
            // 
            // ColorName
            // 
            this.ColorName.Location = new System.Drawing.Point(457, 330);
            this.ColorName.Name = "ColorName";
            this.ColorName.Size = new System.Drawing.Size(153, 20);
            this.ColorName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorName);
            this.Controls.Add(this.panelRGB);
            this.Controls.Add(this.Binput);
            this.Controls.Add(this.Rinput);
            this.Controls.Add(this.Ginput);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.showColorBtn);
            this.Controls.Add(this.colorDropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox colorDropDown;
        private System.Windows.Forms.Button showColorBtn;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.TextBox Ginput;
        private System.Windows.Forms.TextBox Rinput;
        private System.Windows.Forms.TextBox Binput;
        private System.Windows.Forms.Panel panelRGB;
        private System.Windows.Forms.TextBox ColorName;
    }
}

