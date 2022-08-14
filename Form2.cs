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
    public partial class additem : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RODO9FP\SQLEXPRESS;Initial Catalog=PriceList;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public object Dv { get; private set; }

        public additem()
        {
            InitializeComponent();
        }

        private void priceList1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.priceList1BindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.priceListDataSet);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into PriceList1 values ('" + txtProduct_ID.Text + "','" + txtName.Text + "','" + txtPrice.Text +"')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inserted Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void additem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'priceListDataSet.PriceList1' table. You can move, or remove it, as needed.
          //  this.priceList1TableAdapter.Fill(this.priceListDataSet.PriceList1);

        }

        private void product_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //this.priceList1BindingSource.Find("Name", toolStripTextBox1.Text);
           // this.priceList1BindingSource.Position = this.priceList1BindingSource.Find("Name", toolStripTextBox1.Text);
        }

        private void priceList1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void priceList1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("Select * from PriceList1", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from PriceList1 where Product_ID = @parm1", conn);
                cmd.Parameters.AddWithValue("@parm1", toolStripTextBox1.Text);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("Product ID = " + reader1.GetValue(0).ToString() + "\n" + "Name = " + reader1.GetValue(1).ToString() + "\n" + "Price = " + reader1.GetValue(2).ToString() , "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Not Found...", "Search Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtProduct_ID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from PriceList1 where Product_ID = '" + txtProduct_ID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted Successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

