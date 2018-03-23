namespace Project3
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Sub1 = new System.Windows.Forms.Button();
            this.Sub2 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Sub3 = new System.Windows.Forms.Button();
            this.Form2 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Sub1
            // 
            this.Sub1.Location = new System.Drawing.Point(8, 8);
            this.Sub1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sub1.Name = "Sub1";
            this.Sub1.Size = new System.Drawing.Size(109, 44);
            this.Sub1.TabIndex = 0;
            this.Sub1.Text = "Sub1";
            this.Sub1.UseVisualStyleBackColor = true;
            this.Sub1.Click += new System.EventHandler(this.Sub1_Click_1);
            // 
            // Sub2
            // 
            this.Sub2.Location = new System.Drawing.Point(8, 56);
            this.Sub2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sub2.Name = "Sub2";
            this.Sub2.Size = new System.Drawing.Size(109, 44);
            this.Sub2.TabIndex = 2;
            this.Sub2.Text = "Sub2";
            this.Sub2.UseVisualStyleBackColor = true;
            this.Sub2.Click += new System.EventHandler(this.Sub2_Click);
            // 
            // Help
            // 
            this.Help.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Help.Location = new System.Drawing.Point(8, 387);
            this.Help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(45, 37);
            this.Help.TabIndex = 4;
            this.Help.Text = "?";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Sub3
            // 
            this.Sub3.Location = new System.Drawing.Point(8, 104);
            this.Sub3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sub3.Name = "Sub3";
            this.Sub3.Size = new System.Drawing.Size(109, 45);
            this.Sub3.TabIndex = 5;
            this.Sub3.Text = "Sub3";
            this.Sub3.UseVisualStyleBackColor = true;
            this.Sub3.Click += new System.EventHandler(this.Sub3_Click_1);
            // 
            // Form2
            // 
            this.Form2.Location = new System.Drawing.Point(8, 153);
            this.Form2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(109, 44);
            this.Form2.TabIndex = 6;
            this.Form2.Text = "Form2";
            this.Form2.UseVisualStyleBackColor = true;
            this.Form2.Click += new System.EventHandler(this.Form2_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage")));
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel1.Location = new System.Drawing.Point(131, 8);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(699, 416);
            this.Panel1.TabIndex = 7;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Form2);
            this.Controls.Add(this.Sub3);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Sub2);
            this.Controls.Add(this.Sub1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sub1;
        private System.Windows.Forms.Button Sub2;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Sub3;
        private System.Windows.Forms.Button Form2;
        private System.Windows.Forms.Panel Panel1;
    }
}