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
    public partial class dailysales : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RODO9FP\SQLEXPRESS;Initial Catalog=PriceList;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public dailysales()
        {
            InitializeComponent();
        }

        private void dailysales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            adpt = new SqlDataAdapter("Select * from Sales_report where CONVERT(datetime, Date) = '2021-04-08'", conn);
            
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
