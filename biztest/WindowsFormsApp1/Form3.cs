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
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = HP\\DIVYANSHUSQL; Initial Catalog = dumpi; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
        private void Form3_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select*from emp1", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data availble to read");


        }

        private void btnnext_Click(object sender, EventArgs e)
        {
             if(dr.Read()==true)
            {
                txtId.Text = dr[0].ToString();
                txtname.Text = dr[1].ToString();
                txtaddress.Text = dr[2].ToString();
                txtsalary.Text = dr[3].ToString();

            }
            else
            {
                MessageBox.Show("there is no record to read");
                con.Close();
                txtId.Text = txtname.Text = txtaddress.Text = txtsalary.Text = "";
                btnnext.Enabled = false;
            }
        }
    }
}
