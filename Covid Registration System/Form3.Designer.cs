
namespace Covid_Registration_System
{
    partial class Forgot_Form
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
            this.Change_Pass_button = new System.Windows.Forms.Button();
            this.New_Pass_txtBox = new System.Windows.Forms.TextBox();
            this.Phone_Forg_txtBox = new System.Windows.Forms.TextBox();
            this.ID_Forg_txtBox = new System.Windows.Forms.TextBox();
            this.Check_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User_label = new System.Windows.Forms.Label();
            this.Only_int_label = new System.Windows.Forms.Label();
            this.Only_int_label2 = new System.Windows.Forms.Label();
            this.ID_label_length = new System.Windows.Forms.Label();
            this.Phone_label_Length = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_Sign_link
            // 
            this.Back_Sign_link.AutoSize = true;
            this.Back_Sign_link.Location = new System.Drawing.Point(445, 428);
            this.Back_Sign_link.Name = "Back_Sign_link";
            this.Back_Sign_link.Size = new System.Drawing.Size(81, 13);
            this.Back_Sign_link.TabIndex = 17;
            this.Back_Sign_link.TabStop = true;
            this.Back_Sign_link.Text = "Back To Log In";
            this.Back_Sign_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_Sign_link_LinkClicked);
            // 
            // Change_Pass_button
            // 
            this.Change_Pass_button.Location = new System.Drawing.Point(239, 340);
            this.Change_Pass_button.Name = "Change_Pass_button";
            this.Change_Pass_button.Size = new System.Drawing.Size(111, 23);
            this.Change_Pass_button.TabIndex = 16;
            this.Change_Pass_button.Text = "Change Password";
            this.Change_Pass_button.UseVisualStyleBackColor = true;
            this.Change_Pass_button.Click += new System.EventHandler(this.Change_Pass_button_Click);
            // 
            // New_Pass_txtBox
            // 
            this.New_Pass_txtBox.Location = new System.Drawing.Point(228, 287);
            this.New_Pass_txtBox.Name = "New_Pass_txtBox";
            this.New_Pass_txtBox.Size = new System.Drawing.Size(129, 20);
            this.New_Pass_txtBox.TabIndex = 15;
            this.New_Pass_txtBox.UseSystemPasswordChar = true;
            // 
            // Phone_Forg_txtBox
            // 
            this.Phone_Forg_txtBox.Location = new System.Drawing.Point(228, 147);
            this.Phone_Forg_txtBox.Name = "Phone_Forg_txtBox";
            this.Phone_Forg_txtBox.Size = new System.Drawing.Size(129, 20);
            this.Phone_Forg_txtBox.TabIndex = 14;
            this.Phone_Forg_txtBox.TextChanged += new System.EventHandler(this.Phone_Forg_txtBox_TextChanged);
            this.Phone_Forg_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_Forg_txtBox_KeyPress);
            // 
            // ID_Forg_txtBox
            // 
            this.ID_Forg_txtBox.Location = new System.Drawing.Point(228, 87);
            this.ID_Forg_txtBox.Name = "ID_Forg_txtBox";
            this.ID_Forg_txtBox.Size = new System.Drawing.Size(129, 20);
            this.ID_Forg_txtBox.TabIndex = 13;
            this.ID_Forg_txtBox.TextChanged += new System.EventHandler(this.ID_Forg_txtBox_TextChanged);
            this.ID_Forg_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_Forg_txtBox_KeyPress);
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(246, 199);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(92, 23);
            this.Check_button.TabIndex = 12;
            this.Check_button.Text = "Check";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "National ID:";
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.ForeColor = System.Drawing.Color.Red;
            this.User_label.Location = new System.Drawing.Point(209, 243);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(158, 20);
            this.User_label.TabIndex = 18;
            this.User_label.Text = "User Doesn\'t Exist";
            this.User_label.Visible = false;
            // 
            // Only_int_label
            // 
            this.Only_int_label.AutoSize = true;
            this.Only_int_label.ForeColor = System.Drawing.Color.Red;
            this.Only_int_label.Location = new System.Drawing.Point(363, 97);
            this.Only_int_label.Name = "Only_int_label";
            this.Only_int_label.Size = new System.Drawing.Size(112, 13);
            this.Only_int_label.TabIndex = 19;
            this.Only_int_label.Text = "Only Integers Allowed!";
            this.Only_int_label.Visible = false;
            // 
            // Only_int_label2
            // 
            this.Only_int_label2.AutoSize = true;
            this.Only_int_label2.ForeColor = System.Drawing.Color.Red;
            this.Only_int_label2.Location = new System.Drawing.Point(363, 156);
            this.Only_int_label2.Name = "Only_int_label2";
            this.Only_int_label2.Size = new System.Drawing.Size(112, 13);
            this.Only_int_label2.TabIndex = 20;
            this.Only_int_label2.Text = "Only Integers Allowed!";
            this.Only_int_label2.Visible = false;
            // 
            // ID_label_length
            // 
            this.ID_label_length.AutoSize = true;
            this.ID_label_length.ForeColor = System.Drawing.Color.Red;
            this.ID_label_length.Location = new System.Drawing.Point(363, 84);
            this.ID_label_length.Name = "ID_label_length";
            this.ID_label_length.Size = new System.Drawing.Size(163, 13);
            this.ID_label_length.TabIndex = 29;
            this.ID_label_length.Text = "ID should be only be 10 Integers!\r\n";
            this.ID_label_length.Visible = false;
            // 
            // Phone_label_Length
            // 
            this.Phone_label_Length.AutoSize = true;
            this.Phone_label_Length.ForeColor = System.Drawing.Color.Red;
            this.Phone_label_Length.Location = new System.Drawing.Point(363, 143);
            this.Phone_label_Length.Name = "Phone_label_Length";
            this.Phone_label_Length.Size = new System.Drawing.Size(183, 13);
            this.Phone_label_Length.TabIndex = 30;
            this.Phone_label_Length.Text = "Phone should be only be 10 Integers!\r\n";
            this.Phone_label_Length.Visible = false;
            // 
            // Forgot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.Phone_label_Length);
            this.Controls.Add(this.ID_label_length);
            this.Controls.Add(this.Only_int_label2);
            this.Controls.Add(this.Only_int_label);
            this.Controls.Add(this.User_label);
            this.Controls.Add(this.Back_Sign_link);
            this.Controls.Add(this.Change_Pass_button);
            this.Controls.Add(this.New_Pass_txtBox);
            this.Controls.Add(this.Phone_Forg_txtBox);
            this.Controls.Add(this.ID_Forg_txtBox);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgot_Form";
            this.Text = "Forgot Password?";
            this.Load += new System.EventHandler(this.Forgot_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back_Sign_link;
        private System.Windows.Forms.Button Change_Pass_button;
        private System.Windows.Forms.TextBox New_Pass_txtBox;
        private System.Windows.Forms.TextBox Phone_Forg_txtBox;
        private System.Windows.Forms.TextBox ID_Forg_txtBox;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Label Only_int_label;
        private System.Windows.Forms.Label Only_int_label2;
        private System.Windows.Forms.Label ID_label_length;
        private System.Windows.Forms.Label Phone_label_Length;
    }
}