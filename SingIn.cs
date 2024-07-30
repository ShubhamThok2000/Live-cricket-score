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


    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert = "INSERT INTO UserTable (UserName,Passward,Fname,Lname) VALUES('" +textBox3.Text+ "','" + textBox4.Text+ "','" + textBox1.Text+ "','" + textBox2.Text+"')";
            cmd = new SqlCommand(insert , con);
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Sign In succesfully");
                Form1 obj = new Form1();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("error, plese retry");
            }
            con.Close();
        }
    }
}
