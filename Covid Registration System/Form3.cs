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
    public partial class Forgot_Form : Form
    {


        static string path = "Data Source = Users.db; Version = 3;";
        SQLiteConnection Connect = new SQLiteConnection(path);
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader dr;

        
        public Forgot_Form()
        {
            InitializeComponent();
        }

        //Hide the new Password text and Change pass button when the form loads
        private void Forgot_Form_Load(object sender, EventArgs e)
        {
            
            New_Pass_txtBox.Hide();
            label3.Hide();
            Change_Pass_button.Hide();
        }

        //Directs back to the Log In form (Form 1)
        private void Back_Sign_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Log_In_Form fr = new Log_In_Form();
            fr.Show();
        }

        //Check to confirm if the user exists
        private void Check_button_Click(object sender, EventArgs e)
        {
            //checks if the labels are empty or not
            if (ID_Forg_txtBox.Text == string.Empty || Phone_Forg_txtBox.Text == string.Empty)
            {
                MessageBox.Show("Fill All Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    Connect.Open();

                    cmd.Connection = Connect;

                    
                    cmd.CommandText = "Select * from Register where ID = '" + int.Parse(ID_Forg_txtBox.Text) + 
                        "' and Phone_Number = " +
                        " '" + int.Parse(Phone_Forg_txtBox.Text) + "' ";


                    dr = cmd.ExecuteReader();

                    
                    if (!dr.HasRows)
                    {
                        User_label.Show();

                        New_Pass_txtBox.Hide();
                        label3.Hide();
                        Change_Pass_button.Hide();

                        dr.Close();
                        Connect.Close();
                    }
                    else
                    {
                        User_label.Hide();
                        New_Pass_txtBox.Show();
                        label3.Show();
                        Change_Pass_button.Show();


                        dr.Close();
                        Connect.Close();

                    }
                }
                catch (OverflowException over) //In case an Error occurs due to overflow in ID or Phone Number integer
                {
                    MessageBox.Show("" + over.Message + "\n\n" + "ID or Phone Number should NOT Exceed 10 Numbers!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (FormatException format) //In case an Error accours due to fomat in ID or Phone Number
                {
                    MessageBox.Show("" + format.Message + "\n\n" + "Letters are NOT Allowed in ID or Phone Number labels!"
                        , "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    Connect.Close();
                }
                
            }
        }

        //Update password Function
        private void Change_Pass_button_Click(object sender, EventArgs e)
        {

            if (New_Pass_txtBox.Text == string.Empty)
            {
                MessageBox.Show("No Password has been Inserted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    //Opens the connection to the datbase
                    Connect.Open();

                    cmd.Connection = Connect;

                    //Command to update the user's password
                    cmd.CommandText = "Update Register Set Password = '" + New_Pass_txtBox.Text + "' " +
                        "where ID = '" + int.Parse(ID_Forg_txtBox.Text) + "' and " +
                        "Phone_Number = '" + int.Parse(Phone_Forg_txtBox.Text) + "' ";

                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        MessageBox.Show("Error.... Password did not Change!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Password Successfully Changed!", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    Connect.Close();
                }
                catch(FormatException format) //In case ID and Phone Number labels are erased or format changed
                {
                    MessageBox.Show("" + format.Message + "\n\n" + "ID or Phone Number label is Empty or Wrong Format!"
                        , "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException over) //In case an Error occurs due to overflow in ID or Phone Number integer
                {
                    MessageBox.Show("" + over.Message + "\n\n" + "ID or Phone Number should NOT Exceed 10 Numbers!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connect.Close();
                }
            }
        }

        //Event Function for ID_Forget TextBox: Only Integers are allowed
        private void ID_Forg_txtBox_KeyPress(object sender, KeyPressEventArgs e)
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

        //Event Function for Phone_Forget TextBox: Only Integers are allowed
        private void Phone_Forg_txtBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void ID_Forg_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (ID_Forg_txtBox.Text.Length > 10)
            {
                ID_label_length.Show();
            }
            else
                ID_label_length.Hide();
        }

        //string function for Phone Number if it exceeds 10 Integers
        private void Phone_Forg_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (Phone_Forg_txtBox.Text.Length > 10)
            {
                Phone_label_Length.Show();
            }
            else
                Phone_label_Length.Hide();
        }
    }
}
