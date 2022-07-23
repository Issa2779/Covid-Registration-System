using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Covid_Registration_System
{
    public partial class Log_In_Form : Form
    {

        

        static string path = "Data Source = Users.db; Version = 3;";
        SQLiteConnection Connect = new SQLiteConnection(path);
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader dr;

        public Log_In_Form()
        {
            InitializeComponent();
        }

        //Log-in Form Load function
        private void Form1_Load(object sender, EventArgs e)
        {

            ID_txtBox.Focus(); //Focus on the ID text when the form loads

        }

        //Function that sign in the user if the information is correct
        private void Sign_In_button_Click(object sender, EventArgs e)
        {
            //Check if there are Empty Controls
            if (ID_txtBox.Text == string.Empty || Pass_txtBox.Text == string.Empty)
            {
                MessageBox.Show("Fill All Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Opens the Connection to DataBase
                    Connect.Open();

                    cmd.Connection = Connect;

                    //Command to read Data from Database
                    cmd.CommandText = "Select * from Register where ID = '" + int.Parse(ID_txtBox.Text) + "' " +
                        "and Password = '" + Pass_txtBox.Text + "'";

                    //Reads the command
                    dr = cmd.ExecuteReader();

                    //Checks if the data exists
                    if (!dr.HasRows)
                    {
                        wrong_label.Show(); //Shows a message as a label to show that Id or password is wrong
                    }
                    else
                    {
                        //Directs to user's Form (Form 4)
                        this.Hide();
                        User_Info_Form user_form = new User_Info_Form();

                        user_form.setID(int.Parse(ID_txtBox.Text)); //Set the ID data to be used in Form 4 (Classes)
                        user_form.Show();
                    }

                    //Closes the reader property and closes the connection
                    dr.Close();
                    Connect.Close();
                }
                catch (FormatException format) //In case an Error accours due to fomat in ID or Phone Number
                {
                    MessageBox.Show("" + format.Message + "\n\n" + "Letters are NOT Allowed in the ID label!"
                        , "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException over) //In case an Error occurs due to overflow in ID or Phone Number integer
                {
                    MessageBox.Show("" + over.Message + "\n\n" + "ID should NOT Exceed 10 Numbers!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connect.Close();
                }
            }
        }
        
        //Directs to the Forgot Password Form (Form 3)
        private void Forgot_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forgot_Form forgot_form = new Forgot_Form();
            forgot_form.Show();
        }

        //Directs to the Registration Form (Form 2)
        private void Register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Registration_Form Reg_form = new Registration_Form();
            Reg_form.Show();
        }

        //Directs to Admin form
        private void Admin_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Database_Grid data_form = new Database_Grid();
            data_form.Show();

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

        //string function for National ID if it exceeds 10 Integers
        private void ID_txtBox_TextChanged(object sender, EventArgs e)
        {
            string string1 = ID_txtBox.Text;

            if (string1.Length > 10)
            {
                String_Id_length.Show();
            }
            else
                String_Id_length.Hide();


        }

        //Empty Function
        private void ID_txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        
    }
}
