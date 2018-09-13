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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP\\DIVYANSHUSQL;Initial Catalog=dumpi;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select*from emp1", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp1");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "emp1";



        }
    }
}
