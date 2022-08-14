using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace BillingSoftware
{
    public partial class Cashier : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RODO9FP\SQLEXPRESS;Initial Catalog=PriceList;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        float price,quantity,tot,dis, dis_tot;
        public Cashier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'priceListDataSet.PriceList1' table. You can move, or remove it, as needed.
           // this.priceList1TableAdapter.Fill(this.priceListDataSet.PriceList1);

            FillDGV();
        }
        void FillDGV()
        {

           // string conn = System.Configuration.ConfigurationManager.ConnectionStrings["BillingSoftware.Properties.Settings.PriceListConnectionString"].ConnectionString;

            //string query = "SELECT * FROM PriceList1";
            //SqlConnection connection = new SqlConnection(conn);

            //SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);

            //PriceListDataSet ds = new PriceListDataSet();

            //connection.Open();

            //dadapter.Fill(ds, "PriceList1");
            //connection.Close();
            //dataGridView1.DataSource = ds; //dgv is datagridview
            //dataGridView1.DataMember = "PriceList1";

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additem f2 = new additem();
            f2.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void billToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.priceList1TableAdapter.bill(this.priceListDataSet1.PriceList1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void qttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void idtxt_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void gridbtn_Click(object sender, EventArgs e)
        {



            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Table] values ('" + txtID.Text + "','" + txtName.Text + "','" + txtPrice.Text + "','" + txtQuantity.Text + "','" + txtDiscount.Text + "','" + txtCashier.Text + "','" + txtBillNo.Text + "','" + dateTimecashier.Text + "','" + lblDiscount_Total.Text + "','" + lblTotal.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inserted Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


        }

        private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dailysales f3 = new dailysales();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("Select * from [Table]", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtCashier.Text = "";
            txtBillNo.Text = "";
            txtDiscount.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lblDiscount_Total.Text = "_________________";
            lblTotal.Text = "_________________";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            price = float.Parse(txtPrice.Text);
            quantity = float.Parse(txtQuantity.Text);
            dis = float.Parse(txtDiscount.Text);

            tot = price * quantity;

            dis_tot = tot - dis;
            lblTotal.Text = tot.ToString();
            lblDiscount_Total.Text = dis_tot.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("STORE", new Font("Arial",26,FontStyle.Regular),Brushes.Black, new Point(400,10));
            e.Graphics.DrawString("------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 60));

            e.Graphics.DrawString("Bill No:    "+ txtBillNo.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Date:       " + DateTime.Now.ToShortDateString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("Cashier:    " + txtCashier.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 160));

            e.Graphics.DrawString("------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Name", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Quantity", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(200, 230));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(380, 230));
            e.Graphics.DrawString("Total Price", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 230));
            e.Graphics.DrawString("------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString(txtName.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString(txtQuantity.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString(txtPrice.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(380, 300));
            e.Graphics.DrawString(lblTotal.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 300));


            e.Graphics.DrawString("------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(25, 380));
            e.Graphics.DrawString("Discount:   "+ lblDiscount_Total.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(450, 450));
            e.Graphics.DrawString("Total :     "+lblTotal.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(450, 500));


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void monthlySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthlysales f4 = new monthlysales();
            f4.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
