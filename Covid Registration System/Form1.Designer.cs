
namespace Covid_Registration_System
{
    partial class Log_In_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In_Form));
            this.Pass_Label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.Register_link = new System.Windows.Forms.LinkLabel();
            this.Forgot_link = new System.Windows.Forms.LinkLabel();
            this.Sign_In_button = new System.Windows.Forms.Button();
            this.Pass_txtBox = new System.Windows.Forms.TextBox();
            this.wrong_label = new System.Windows.Forms.Label();
            this.Only_int_label = new System.Windows.Forms.Label();
            this.String_Id_length = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Label.Location = new System.Drawing.Point(91, 188);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(86, 20);
            this.Pass_Label.TabIndex = 1;
            this.Pass_Label.Text = "Password: ";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(91, 133);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(92, 20);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "National ID:";
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.Location = new System.Drawing.Point(183, 133);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.Size = new System.Drawing.Size(164, 20);
            this.ID_txtBox.TabIndex = 2;
            this.ID_txtBox.TextChanged += new System.EventHandler(this.ID_txtBox_TextChanged);
            this.ID_txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_txtBox_KeyDown);
            this.ID_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_txtBox_KeyPress);
            // 
            // Register_link
            // 
            this.Register_link.AutoSize = true;
            this.Register_link.Location = new System.Drawing.Point(92, 227);
            this.Register_link.Name = "Register_link";
            this.Register_link.Size = new System.Drawing.Size(46, 13);
            this.Register_link.TabIndex = 7;
            this.Register_link.TabStop = true;
            this.Register_link.Text = "Register";
            this.Register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_link_LinkClicked);
            // 
            // Forgot_link
            // 
            this.Forgot_link.AutoSize = true;
            this.Forgot_link.Location = new System.Drawing.Point(373, 227);
            this.Forgot_link.Name = "Forgot_link";
            this.Forgot_link.Size = new System.Drawing.Size(92, 13);
            this.Forgot_link.TabIndex = 6;
            this.Forgot_link.TabStop = true;
            this.Forgot_link.Text = "Forgot Password?";
            this.Forgot_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgot_link_LinkClicked);
            // 
            // Sign_In_button
            // 
            this.Sign_In_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In_button.Location = new System.Drawing.Point(203, 307);
            this.Sign_In_button.Name = "Sign_In_button";
            this.Sign_In_button.Size = new System.Drawing.Size(123, 30);
            this.Sign_In_button.TabIndex = 8;
            this.Sign_In_button.Text = "Sign In ";
            this.Sign_In_button.UseVisualStyleBackColor = true;
            this.Sign_In_button.Click += new System.EventHandler(this.Sign_In_button_Click);
            // 
            // Pass_txtBox
            // 
            this.Pass_txtBox.Location = new System.Drawing.Point(183, 188);
            this.Pass_txtBox.Name = "Pass_txtBox";
            this.Pass_txtBox.Size = new System.Drawing.Size(164, 20);
            this.Pass_txtBox.TabIndex = 3;
            this.Pass_txtBox.UseSystemPasswordChar = true;
            // 
            // wrong_label
            // 
            this.wrong_label.AutoSize = true;
            this.wrong_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrong_label.ForeColor = System.Drawing.Color.Red;
            this.wrong_label.Location = new System.Drawing.Point(180, 224);
            this.wrong_label.Name = "wrong_label";
            this.wrong_label.Size = new System.Drawing.Size(166, 16);
            this.wrong_label.TabIndex = 10;
            this.wrong_label.Text = "Wrong ID or Password!";
            this.wrong_label.Visible = false;
            // 
            // Only_int_label
            // 
            this.Only_int_label.AutoSize = true;
            this.Only_int_label.ForeColor = System.Drawing.Color.Red;
            this.Only_int_label.Location = new System.Drawing.Point(353, 146);
            this.Only_int_label.Name = "Only_int_label";
            this.Only_int_label.Size = new System.Drawing.Size(112, 13);
            this.Only_int_label.TabIndex = 11;
            this.Only_int_label.Text = "Only Integers Allowed!";
            this.Only_int_label.Visible = false;
            // 
            // String_Id_length
            // 
            this.String_Id_length.AutoSize = true;
            this.String_Id_length.ForeColor = System.Drawing.Color.Red;
            this.String_Id_length.Location = new System.Drawing.Point(353, 128);
            this.String_Id_length.Name = "String_Id_length";
            this.String_Id_length.Size = new System.Drawing.Size(163, 13);
            this.String_Id_length.TabIndex = 12;
            this.String_Id_length.Text = "ID should be only be 10 Integers!\r\n";
            this.String_Id_length.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to the COVID Reigestraion System";
            // 
            // Admin_link
            // 
            this.Admin_link.AutoSize = true;
            this.Admin_link.Location = new System.Drawing.Point(242, 265);
            this.Admin_link.Name = "Admin_link";
            this.Admin_link.Size = new System.Drawing.Size(36, 13);
            this.Admin_link.TabIndex = 15;
            this.Admin_link.TabStop = true;
            this.Admin_link.Text = "Admin";
            this.Admin_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Admin_link_LinkClicked);
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.Admin_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.String_Id_length);
            this.Controls.Add(this.Only_int_label);
            this.Controls.Add(this.wrong_label);
            this.Controls.Add(this.Pass_txtBox);
            this.Controls.Add(this.Sign_In_button);
            this.Controls.Add(this.Forgot_link);
            this.Controls.Add(this.Register_link);
            this.Controls.Add(this.ID_txtBox);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Pass_Label);
            this.Name = "Log_In_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox ID_txtBox;
        private System.Windows.Forms.LinkLabel Register_link;
        private System.Windows.Forms.LinkLabel Forgot_link;
        private System.Windows.Forms.Button Sign_In_button;
        private System.Windows.Forms.TextBox Pass_txtBox;
        private System.Windows.Forms.Label wrong_label;
        private System.Windows.Forms.Label Only_int_label;
        private System.Windows.Forms.Label String_Id_length;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Admin_link;
    }
}

