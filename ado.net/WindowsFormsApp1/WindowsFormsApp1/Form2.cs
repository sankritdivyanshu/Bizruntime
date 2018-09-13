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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = HP\\DIVYANSHUSQL; Initial Catalog = dumpi; Integrated Security = True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into emp1 values(" +txtId.Text+", '"+txtname.Text+ "','"+txtaddress.Text+"', "+txtsalary.Text+")",con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is inserted");
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update emp1 set name ='"+ txtname.Text+"', address='"+txtaddress.Text+"' , salary=" +txtsalary.Text+" where id="+txtId.Text+"", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is updated");
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from emp1 where id=" +txtId.Text, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is deletesd");
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //txtId.Text = "";
            //txtname.Text = "";
            //txtaddress.Text = "";
            //txtsalary.Text = "";
            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
