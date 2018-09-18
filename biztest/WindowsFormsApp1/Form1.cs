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
    public partial class  Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("Data Source=HP\\DIVYANSHUSQL;Initial Catalog=dumpi;Integrated Security=True");
            con.Open();
            MessageBox.Show("connected");
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
