
namespace Covid_Registration_System
{
    partial class Database_Grid
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
            this.Back_Sign_link = new System.Windows.Forms.LinkLabel();
            this.ViewAllGV = new System.Windows.Forms.DataGridView();
            this.Export_data = new System.Windows.Forms.Button();
            this.Show_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Sign_link
            // 
            this.Back_Sign_link.AutoSize = true;
            this.Back_Sign_link.Location = new System.Drawing.Point(1173, 652);
            this.Back_Sign_link.Name = "Back_Sign_link";
            this.Back_Sign_link.Size = new System.Drawing.Size(81, 13);
            this.Back_Sign_link.TabIndex = 18;
            this.Back_Sign_link.TabStop = true;
            this.Back_Sign_link.Text = "Back To Log In";
            this.Back_Sign_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_Sign_link_LinkClicked);
            // 
            // ViewAllGV
            // 
            this.ViewAllGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAllGV.Location = new System.Drawing.Point(-1, 0);
            this.ViewAllGV.Name = "ViewAllGV";
            this.ViewAllGV.Size = new System.Drawing.Size(1266, 436);
            this.ViewAllGV.TabIndex = 19;
            // 
            // Export_data
            // 
            this.Export_data.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Export_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Export_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_data.ForeColor = System.Drawing.Color.Blue;
            this.Export_data.Location = new System.Drawing.Point(880, 522);
            this.Export_data.Name = "Export_data";
            this.Export_data.Size = new System.Drawing.Size(152, 81);
            this.Export_data.TabIndex = 21;
            this.Export_data.Text = "Export Data";
            this.Export_data.UseVisualStyleBackColor = false;
            this.Export_data.Click += new System.EventHandler(this.Export_data_Click);
            // 
            // Show_data
            // 
            this.Show_data.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Show_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Show_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_data.ForeColor = System.Drawing.Color.Blue;
            this.Show_data.Location = new System.Drawing.Point(271, 522);
            this.Show_data.Name = "Show_data";
            this.Show_data.Size = new System.Drawing.Size(152, 81);
            this.Show_data.TabIndex = 22;
            this.Show_data.Text = "Show DataBase";
            this.Show_data.UseVisualStyleBackColor = false;
            this.Show_data.Click += new System.EventHandler(this.Show_data_Click);
            // 
            // Database_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 674);
            this.Controls.Add(this.Show_data);
            this.Controls.Add(this.Export_data);
            this.Controls.Add(this.ViewAllGV);
            this.Controls.Add(this.Back_Sign_link);
            this.Name = "Database_Grid";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back_Sign_link;
        private System.Windows.Forms.DataGridView ViewAllGV;
        private System.Windows.Forms.Button Export_data;
        private System.Windows.Forms.Button Show_data;
    }
}