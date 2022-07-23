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
using System.IO;

namespace Covid_Registration_System
{
    public partial class Database_Grid : Form
    {

        static string path = "Data Source = Users.db; Version = 3;";
        SQLiteConnection Connect = new SQLiteConnection(path);
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader dr;
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt;

        public Database_Grid()
        {
            InitializeComponent();
        }

        private void Database_Grid_Load(object sender, EventArgs e)
        {
            
        }

        private void Back_Sign_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Log_In_Form fr = new Log_In_Form();
            fr.Show();

        }

        //Show DataBase
        private void Show_data_Click(object sender, EventArgs e)
        {
            Connect.Open();

            string strCmd = "SELECT * FROM Register ORDER BY ID";
            cmd = new SQLiteCommand(strCmd, Connect);

            da = new SQLiteDataAdapter(strCmd, Connect);

            ds = new DataSet();
            da.Fill(ds, "Register");

            ViewAllGV.DataSource = ds.Tables["Register"].DefaultView;

            Connect.Close();
        }

        //Export Data to text file
        private void Export_data_Click(object sender, EventArgs e)
        {
            Connect.Open();
            TextWriter writer = new StreamWriter("User_Info.txt");
            int rowcount = ViewAllGV.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                for (int j = 0; j < rowcount - 1; j++)
                {
                    if (j == 3)
                    {
                        continue;
                    }

                    writer.WriteLine(ViewAllGV.Rows[i].Cells[j].Value.ToString());

                }
                writer.WriteLine("=================================");
            }
            writer.Close();     //Close the TextWriter Object(sw)

            MessageBox.Show("Data Successfully Exported!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Connect.Close();
        }
    }
}
