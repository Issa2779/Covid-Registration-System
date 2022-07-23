using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Covid_Registration_System
{
    public partial class User_Info_Form : Form 
    {

        static string path = "Data Source = Users.db; Version = 3;";
        SQLiteConnection Connect = new SQLiteConnection(path);
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader dr;

        //Setters and getters for the data after logging in from the first form (Form 1 = Log in Form)
        private int ID;
        public void setID(int ID)
        {
            this.ID = ID;
        }
        private int getID()
        {
            return this.ID;
        }


        //Functions
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

        public User_Info_Form()
        {
            InitializeComponent();
        }


        //Function when the form loads
        private void User_Info_Form_Load(object sender, EventArgs e)
        {
            
            Connect.Open();

            cmd.Connection = Connect;

            cmd.CommandText = "select * from Register where ID = '" + getID() + "' ";

            dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {

                MessageBox.Show("ID doesn't exist!");

            }
            else
            {
                while (dr.Read())
                {
                    
                    int dose = Convert.ToInt32(dr["Number_of_Doses"].ToString());

                    if(dose == 0)
                    {
                        Cross_Pic.Show();
                    }
                    else if(dose == 1)
                    {
                        Checked_Box.Show();
                        Cross_small_label.Show();
                        Note_label.Show();
                    }
                    else
                        Checked_Box.Show();

                    /////////////////////////////////////////////////
                    ///
                    
                    First_Name_txtbox.Text = dr["First_Name"].ToString();
                    Last_Name_txtbox.Text = dr["Last_Name"].ToString();
                    Pass_txtBox.Text = dr["Password"].ToString();

                    if (dr["Gender"].ToString() == "Male")
                    {
                        Male_Radio.Checked = true;
                    }
                    else
                        Female_Radio.Checked = true;

                    Birth_Time_pick.Value = Convert.ToDateTime(dr["Birth"]);

                    Age_Numeric.Value = Convert.ToDecimal(dr["Age"]);

                    if (dr["Category"].ToString() == "Adult")
                    {
                        Adult_Radio.Checked = true;
                    }
                    else if (dr["Category"].ToString() == "Teenager")
                    {
                        Teen_Radio.Checked = true;
                    }
                    else
                        Child_Radio.Checked = true;


                    Nationality_Box.SelectedItem = dr["Nationality"].ToString();
                    Address_box.Text = dr["Address"].ToString();
                    Phone_Reg_txtBox.Text = dr["Phone_Number"].ToString();


                    ID_txtBox.Text = dr["ID"].ToString();
                    textBox1.Text = dr["Vaccination_Type"].ToString();
                    textBox2.Text = dr["Number_of_Doses"].ToString();
                    
                    /////////////////////////////////////////////////////////////
                    Location_hosp_clin.Text = dr["Address"].ToString();
                    Situation_combo.SelectedIndex = 0;
                    reason_combo.SelectedIndex = 0;

                }
            }

            
            dr.Close();
            Connect.Close();

        }

        

        /*Vaccine Info Tab*/

        //Function that Import Information about vaccines from a text file
        private void Import_button_Click(object sender, EventArgs e)
        {
            String outp = "";
            String Info = "";

            StreamReader reader = new StreamReader("Vaccines_Info.txt");

            while (!reader.EndOfStream)
            {
                Info = reader.ReadLine();

                outp += Info + "\n";
            }

            MessageBox.Show(outp, "Vaccines Information: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            reader.Close();
        }

        //Function Button when the user exists their account (Directs them back to log in form)
        private void Sign_Out_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Sign Out?", "Sign Out",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using our application :) !", "Information",MessageBoxButtons.OK);

                this.Close();
                Log_In_Form form1 = new Log_In_Form();
                form1.Show();
            }
            
        }

        /*Update Info Tab*/

        //Function that deletes the user's account from the database
        private void Delete_button_Click(object sender, EventArgs e)
        {
            Connect.Open();

            cmd.Connection = Connect;

            cmd.CommandText = "Delete from Register where ID = '" + getID() + "'";

            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?\nYou can't " +
                "retrieve you account after confirmation!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {

                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                    MessageBox.Show("Error, Account has not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Account has been deleted!", "Deletion Complete", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                this.Close();
                Log_In_Form form1 = new Log_In_Form();
                form1.Show();

            }

            Connect.Close();
            
        }

        //Function that updats the user's information
        private void Update_button_Click(object sender, EventArgs e)
        {

            if (First_Name_txtbox.Text == string.Empty || Last_Name_txtbox.Text == string.Empty || Pass_txtBox.Text
                == string.Empty || Address_box.Text == string.Empty || Phone_Reg_txtBox.Text == string.Empty)
            {
                MessageBox.Show("Fill All Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Male_Radio.Checked == false && Female_Radio.Checked == false && Adult_Radio.Checked == false &&
                Teen_Radio.Checked == false && Child_Radio.Checked == false)
            {
                MessageBox.Show("Fill All Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string g = "";
                    string cate = "";

                    g = gender_radio(g);
                    cate = category_radio(cate);

                    Connect.Open();

                    cmd.Connection = Connect;

                    cmd.CommandText = "Update Register Set First_Name = '" + First_Name_txtbox.Text + "'" +
                        ", Last_Name = '" + Last_Name_txtbox.Text + "' " +
                        ", Password = '" + Pass_txtBox.Text + "' , " +
                        " Nationality = '" + Nationality_Box.SelectedItem.ToString() + "' ," +
                        " Address = '" + Address_box.Text + "' ," +
                        " Phone_Number = '" + Phone_Reg_txtBox.Text + "'  , " +
                        " Birth = '" + Birth_Time_pick.Text + "', " +
                        " Age = '" + Age_Numeric.Value + "', " +
                        " Gender = '" + g + "'," +
                        " Category = '" + cate + "' " +
                        " where ID = '" + getID() + "'";

                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        MessageBox.Show("Error, User information has NOT been updated!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("User Information has been updated!", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    Connect.Close();
                }
                catch (FormatException format) //In case ID and Phone Number labels are erased or format changed
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

        /*Appointment Tab*/

        //Object of class appointment and a counter attributes for the 2 functions below
        Appointment appoint = new Appointment();
        private int one_appoint = 0;

        //Function that gives the user an appointment and write it down in a list box
        private void Confirm_appoint_Click(object sender, EventArgs e)
        {

            if (one_appoint == 0)
            {

                Box_Appointment_Info.Items.Add("Doctor ID: " + appoint.generate_docID());
                Box_Appointment_Info.Items.Add("Appointment Number: " + appoint.generate_appoint());

                string type = "";
                if (Clinic_radio.Checked == true)
                {
                    type = "Clinic";
                }
                else if (Hospital_radio.Checked == true)
                {
                    type = "Hospital";
                }
                else
                    type = "";

                appoint.type = type;

                Box_Appointment_Info.Items.Add("Type: " + appoint.type);

                appoint.situation = Situation_combo.SelectedItem.ToString();
                Box_Appointment_Info.Items.Add("Situation: " + appoint.situation);

                appoint.reason = reason_combo.SelectedItem.ToString();
                Box_Appointment_Info.Items.Add("Reason: " + appoint.reason);

                appoint.location = Location_hosp_clin.Text;

                Box_Appointment_Info.Items.Add("Clinic/Hospital Location: " + appoint.location);

                appoint.date = Date_Appoint.Text;
                Box_Appointment_Info.Items.Add("Date to attend: " + appoint.date);

                one_appoint++;

            }
            else
                MessageBox.Show("You can't register more than one appointment!", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        //Function that removes the appointment from the list box
        private void Remove_appoint_button_Click(object sender, EventArgs e)
        {
            if (one_appoint == 1)
            {
                Box_Appointment_Info.Items.Clear();
                one_appoint--;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////
        
        //Event Function for First Name TextBox: Only Characters are allowed
        private void First_Name_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        //Event Function for Last Name TextBox: Only Characters are allowed
        private void Last_Name_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        //Event Function for Phone_Reg_txtBox TextBox: Only Integers are allowed
        private void Phone_Reg_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        //Menu Sign-out function
        private void signOutMenuItem_Click(object sender, EventArgs e)
        {
            Sign_Out_button_Click(sender, e);
        }

        //Function that closes all forms
        private void closeMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        //Empty functions
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void First_Name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Last_Name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Pass_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}