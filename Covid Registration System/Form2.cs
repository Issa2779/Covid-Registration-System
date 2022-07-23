using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Covid_Registration_System
{
    public partial class Registration_Form : Form
    {

        //Database Path 
        static string path = "Data Source = Users.db;Version = 3;";
        
        //Database Properties
        SQLiteConnection Connect = new SQLiteConnection(path);
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader dr;


        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

            First_Name_txtbox.Focus();

            Age_Numeric.Value = 18;
            
            Nationality_Box.SelectedIndex = 99;
          
            string phone_code = "07";
            Phone_Reg_txtBox.Text = phone_code.ToString();

        }


        //Functions created for a radio and check boxes
        private string gender_radio(string g)
        {

            if (Male_Radio.Checked)
            {
                g = "Male";
            }
            else if (Female_Radio.Checked)
            {
                g = "Female";
            }

            return g;
        }
        private string category_radio(string cate = "")
        {
            if (Adult_Radio.Checked)
            {
                cate = "Adult";
            }
            else if (Teen_Radio.Checked)
            {
                cate = "Teenager";
            }
            else if (Child_Radio.Checked)
            {
                cate = "Child";
            }

            return cate;
        }
        private string type_radio(string type = "")
        {
            if (Pfizer_Radio.Checked)
            {
                type = "Pfizer";
            }
            else if (Moderna_Radio.Checked)
            {
                type = "Moderna";
            }
            else if (Johnson_Radio.Checked)
            {
                type = "Johnson & Johnson’s Janssen";
            }
            else if (None_Radio.Checked)
            {
                type = "";
            }
            return type;
        }
        private int check_boxes(int count = 0)
        {

            if (CheckBox_Dose1.Checked)
            {
                count++;
            }
            if (CheckBox_Dose2.Checked)
            {
                count++;
            }
            return count;
        }

        //Disable Number of Doses CheckBoxes if the user inputs the none radio button
        private void None_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (None_Radio.Checked)
            {
                Check_box_panel.Enabled = false;
                CheckBox_Dose1.Checked = false;
                CheckBox_Dose2.Checked = false;
            }
            else
                Check_box_panel.Enabled = true;
        }
        
        //Functions to check at least one dose is taken if other than the none radio is checked!
        private void Johnson_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Johnson_Radio.Checked)
            {
                CheckBox_Dose1.Checked = true;
            }
          
        }
        private void Moderna_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Moderna_Radio.Checked)
            {
                CheckBox_Dose1.Checked = true;
            }
        }
        private void Pfizer_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Pfizer_Radio.Checked)
            {
                CheckBox_Dose1.Checked = true;
            }
        }

        //Checks Category boxes automatically depending on the user's age
        private void Age_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (Age_Numeric.Value < 1)
            {
                MessageBox.Show("Only Age Above 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Age_Numeric.Value = 1;
            }
            if (Age_Numeric.Value > 100)
            {
                MessageBox.Show("Only Age below 100", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Age_Numeric.Value = 99;
            }
            if (Age_Numeric.Value < 18)
            {
                Adult_Radio.Checked = false;
                Teen_Radio.Checked = true;
                Child_Radio.Checked = false;
            }
            if (Age_Numeric.Value < 12)
            {
                Adult_Radio.Checked = false;
                Teen_Radio.Checked = false;
                Child_Radio.Checked = true;
            }
            if (Age_Numeric.Value > 18)
            {
                Adult_Radio.Checked = true;
                Teen_Radio.Checked = false;
                Child_Radio.Checked = false;
            }

        }

        //Can not disable the checked dose if the one of the vaccine type radios is checked (Except the none radio)
        private void CheckBox_Dose1_CheckedChanged(object sender, EventArgs e)
        {
            if (Johnson_Radio.Checked || Pfizer_Radio.Checked || Moderna_Radio.Checked)
            {
                CheckBox_Dose1.Checked = true;
            }
        }

        //Register User Function
        private void Register_Button_Click(object sender, EventArgs e)
        {

            string length1 = ID_txtBox.Text; 

            //Check if there are Empty Controls
            if (First_Name_txtbox.Text == string.Empty || Last_Name_txtbox.Text == string.Empty || ID_txtBox.Text ==
                string.Empty || Pass_txtBox.Text == string.Empty || Address_box.Text == string.Empty || Phone_Reg_txtBox.Text
                == string.Empty)
            {
                MessageBox.Show("Fill All Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if(Male_Radio.Checked == false && Female_Radio.Checked == false && Adult_Radio.Checked == false &&
                Teen_Radio.Checked == false && Child_Radio.Checked == false && Pfizer_Radio.Checked == false &&
                Moderna_Radio.Checked == false && Johnson_Radio.Checked == false && None_Radio.Checked == false)
            {
                MessageBox.Show("Fill All Radio Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                try
                {

                    int count = 0;  
                    string g = "";  
                    string cate = ""; 
                    string type = ""; 

                    // Calling these functions to save the checked radio buttons and checkboxes as strings (Functions
                    // at the top)

                    g = gender_radio(g);
                    cate = category_radio(cate);
                    type = type_radio(type);
                    count = check_boxes(count);

                    Connect.Open();   

                    cmd.Connection = Connect;

                    

                    cmd.CommandText = "Insert Into Register (First_Name, Last_Name, ID, Password, Gender, Birth, Age," +
                        " Category, Nationality, Address, Phone_Number, Vaccination_Type, Number_of_Doses) " +
                        " values ('" + First_Name_txtbox.Text + "', '" + Last_Name_txtbox.Text + "', '" + int.Parse(ID_txtBox.Text) + "' " +
                        ", '" + Pass_txtBox.Text + "', '" + g + "', '" + Birth_Time_pick.Text + "', '" + Age_Numeric.Value + "' " +
                        ", '" + cate + "', '" + Nationality_Box.SelectedItem.ToString() + "', '" + Address_box.Text + "'" +
                        ", '" + int.Parse(Phone_Reg_txtBox.Text) + "' " +
                        ", '" + type + "', '" + count + "')";    


                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                        MessageBox.Show("User is Not Registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Registration Success", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    
                    Connect.Close();
                }
                catch (SQLiteException Error)  //In case an Error occurs due to a database constraint
                {
                    MessageBox.Show(""+Error.Message+"\n\n"+"ID Number is Already Registered!", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch(OverflowException over) //In case an Error occurs due to overflow in ID or Phone Number integer
                {
                    MessageBox.Show(""+over.Message+"\n\n"+"ID or Phone Number should NOT Exceed 10 Numbers!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException format) //In case an Error accours due to fomat in ID or Phone Number
                {
                    MessageBox.Show("" + format.Message + "\n\n" + "Letters are NOT Allowed in ID or Phone Number labels !"
                        , "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    Connect.Close();
                }
            }
        }

        //Back to Log in Link: Go Back to Form 1 (Log-in Form)
        private void Log_In_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Log_In_Form fr = new Log_In_Form();
            fr.Show();

        }

        //Event Function for First Name TextBox: Only Characters are allowed
        private void First_Name_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Only_char_label.Show();
            }
            else
            {
                e.Handled = false;
                Only_char_label.Hide();
            }
        }

        //Event Function for Last Name TextBox: Only Characters are allowed
        private void Last_Name_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Only_char_label2.Show();
            }
            else
            {
                e.Handled = false;
                Only_char_label2.Hide();
            }
        }

        //Event Function for ID TextBox: Only Integers are allowed
        private void ID_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Only_int_label.Show();
            }
            else
            {
                e.Handled = false;
                Only_int_label.Hide();
            }
        }

        //Event Function for Phone Number: Only Integers are allowed
        private void Phone_Reg_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Only_int_label2.Show();
            }
            else
            {
                e.Handled = false;
                Only_int_label2.Hide();
            }
        }

        //string function for National ID if it exceeds 10 Integers
        private void ID_txtBox_TextChanged(object sender, EventArgs e)
        {

            if (ID_txtBox.Text.Length > 10)
            {
                String_Id_length.Show();
            }
            else
                String_Id_length.Hide();
          
        }

        //string function for Phone Number if it exceeds 10 Integers
        private void Phone_Reg_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (Phone_Reg_txtBox.Text.Length > 10)
            {
                Phone_length_label.Show();
            }
            else
                Phone_length_label.Hide();

        }
        
        /********************************************/
        
        //Empty Functions 
        private void Adult_Radio_CheckedChanged(object sender, EventArgs e)
        {
            
          
        }
        private void Teen_Radio_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void Child_Radio_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
