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

namespace Cricket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private string getUserName()
        {
            //fetch UserName
            con.Open();
            string syntax = "SELECT Username FROM UserTable";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private string getPassward()
        {
            //fetch passward
            con.Open();
            string syntax = "SELECT Passward FROM UserTable";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            string uname = getUserName(), upass = getPassward();
            string passward = textBox2.Text;
            string username= textBox1.Text;

            if (username.Equals(uname) && passward.Equals(upass))
            {
                //login
                label3.Hide();
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();
            }

            else
            {
                label3.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingIn obj = new SingIn();
            this.Hide();
            obj.Show();
        }
    }
}
