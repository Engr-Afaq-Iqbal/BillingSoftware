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

namespace BillingSoftware
{
    public partial class monthlysales : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RODO9FP\SQLEXPRESS;Initial Catalog=PriceList;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public monthlysales()
        {
            InitializeComponent();
        }

        private void monthlysales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            adpt = new SqlDataAdapter("Select * from Sales_report where (Date BETWEEN '2021-03-01'AND '2021-04-09')", conn);

            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

           // SELECT* from Product_sales where
//(From_date BETWEEN '2013-01-03'AND '2013-01-09')
        }
    }
}
