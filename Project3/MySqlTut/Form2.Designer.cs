namespace Project3
{
    partial class Form2
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
            this.lvPops = new System.Windows.Forms.ListView();
            this.clmCountry_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCountry_Population = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loadtbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPops
            // 
            this.lvPops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCountry_Name,
            this.clmCountry_Population});
            this.lvPops.Location = new System.Drawing.Point(24, 23);
            this.lvPops.Name = "lvPops";
            this.lvPops.Size = new System.Drawing.Size(1551, 698);
            this.lvPops.TabIndex = 0;
            this.lvPops.UseCompatibleStateImageBehavior = false;
            this.lvPops.View = System.Windows.Forms.View.Details;
            this.lvPops.SelectedIndexChanged += new System.EventHandler(this.lvPops_SelectedIndexChanged);
            // 
            // clmCountry_Name
            // 
            this.clmCountry_Name.Text = "Country";
            this.clmCountry_Name.Width = 200;
            // 
            // clmCountry_Population
            // 
            this.clmCountry_Population.Text = "Population";
            this.clmCountry_Population.Width = 200;
            // 
            // Loadtbl
            // 
            this.Loadtbl.Location = new System.Drawing.Point(652, 789);
            this.Loadtbl.Name = "Loadtbl";
            this.Loadtbl.Size = new System.Drawing.Size(364, 60);
            this.Loadtbl.TabIndex = 1;
            this.Loadtbl.Text = "Load";
            this.Loadtbl.UseVisualStyleBackColor = true;
            this.Loadtbl.Click += new System.EventHandler(this.Loadtbl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1598, 960);
            this.Controls.Add(this.Loadtbl);
            this.Controls.Add(this.lvPops);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Population";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPops;
        private System.Windows.Forms.Button Loadtbl;
        private System.Windows.Forms.ColumnHeader clmCountry_Name;
        private System.Windows.Forms.ColumnHeader clmCountry_Population;
    }
}