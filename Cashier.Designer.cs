namespace BillingSoftware
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.priceList1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceListDataSet = new BillingSoftware.PriceListDataSet();
            this.nextcustomer = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dateTimecashier = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.priceList1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.priceListDataSet1 = new BillingSoftware.PriceListDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCashier = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.discounttotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.priceList1TableAdapter = new BillingSoftware.PriceListDataSetTableAdapters.PriceList1TableAdapter();
            this.tableAdapterManager = new BillingSoftware.PriceListDataSetTableAdapters.TableAdapterManager();
            this.lblDiscount_Total = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.priceList1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceList1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceList1BindingSource
            // 
            this.priceList1BindingSource.DataMember = "PriceList1";
            this.priceList1BindingSource.DataSource = this.priceListDataSet;
            // 
            // priceListDataSet
            // 
            this.priceListDataSet.DataSetName = "PriceListDataSet";
            this.priceListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nextcustomer
            // 
            this.nextcustomer.Location = new System.Drawing.Point(681, 457);
            this.nextcustomer.Name = "nextcustomer";
            this.nextcustomer.Size = new System.Drawing.Size(98, 23);
            this.nextcustomer.TabIndex = 1;
            this.nextcustomer.Text = "Next Customer";
            this.nextcustomer.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(599, 457);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dateTimecashier
            // 
            this.dateTimecashier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimecashier.Location = new System.Drawing.Point(579, 40);
            this.dateTimecashier.Name = "dateTimecashier";
            this.dateTimecashier.Size = new System.Drawing.Size(110, 20);
            this.dateTimecashier.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gridbtn);
            this.groupBox1.Location = new System.Drawing.Point(0, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "CALCULATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.priceList1BindingSource1, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(339, 21);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // priceList1BindingSource1
            // 
            this.priceList1BindingSource1.DataMember = "PriceList1";
            this.priceList1BindingSource1.DataSource = this.priceListDataSet1;
            // 
            // priceListDataSet1
            // 
            this.priceListDataSet1.DataSetName = "PriceListDataSet";
            this.priceListDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.priceList1BindingSource1, "Name", true));
            this.txtName.Location = new System.Drawing.Point(192, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.priceList1BindingSource1, "Product_ID", true));
            this.txtID.Location = new System.Drawing.Point(36, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 13;
            this.txtID.TextChanged += new System.EventHandler(this.idtxt_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 187);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(506, 21);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.TextChanged += new System.EventHandler(this.qttxt_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(681, 21);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Discount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            // 
            // gridbtn
            // 
            this.gridbtn.Location = new System.Drawing.Point(614, 267);
            this.gridbtn.Name = "gridbtn";
            this.gridbtn.Size = new System.Drawing.Size(75, 23);
            this.gridbtn.TabIndex = 1;
            this.gridbtn.Text = "ADD";
            this.gridbtn.UseVisualStyleBackColor = true;
            this.gridbtn.Click += new System.EventHandler(this.gridbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill No.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashierToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cashierToolStripMenuItem
            // 
            this.cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            this.cashierToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cashierToolStripMenuItem.Text = "Cashier";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailySalesToolStripMenuItem,
            this.monthlySalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // dailySalesToolStripMenuItem
            // 
            this.dailySalesToolStripMenuItem.Name = "dailySalesToolStripMenuItem";
            this.dailySalesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dailySalesToolStripMenuItem.Text = "Daily Sales";
            this.dailySalesToolStripMenuItem.Click += new System.EventHandler(this.dailySalesToolStripMenuItem_Click);
            // 
            // monthlySalesToolStripMenuItem
            // 
            this.monthlySalesToolStripMenuItem.Name = "monthlySalesToolStripMenuItem";
            this.monthlySalesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.monthlySalesToolStripMenuItem.Text = "Monthly Sales";
            this.monthlySalesToolStripMenuItem.Click += new System.EventHandler(this.monthlySalesToolStripMenuItem_Click);
            // 
            // txtCashier
            // 
            this.txtCashier.Location = new System.Drawing.Point(55, 40);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.Size = new System.Drawing.Size(100, 20);
            this.txtCashier.TabIndex = 6;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(281, 40);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 20);
            this.txtBillNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Discount Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // discounttotal
            // 
            this.discounttotal.AutoSize = true;
            this.discounttotal.Location = new System.Drawing.Point(689, 400);
            this.discounttotal.Name = "discounttotal";
            this.discounttotal.Size = new System.Drawing.Size(0, 13);
            this.discounttotal.TabIndex = 10;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(689, 421);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 11;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // priceList1TableAdapter
            // 
            this.priceList1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PriceList1TableAdapter = this.priceList1TableAdapter;
            this.tableAdapterManager.UpdateOrder = BillingSoftware.PriceListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblDiscount_Total
            // 
            this.lblDiscount_Total.AutoSize = true;
            this.lblDiscount_Total.Location = new System.Drawing.Point(675, 408);
            this.lblDiscount_Total.Name = "lblDiscount_Total";
            this.lblDiscount_Total.Size = new System.Drawing.Size(109, 13);
            this.lblDiscount_Total.TabIndex = 12;
            this.lblDiscount_Total.Text = "_________________";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(675, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "_________________";
            this.lblTotal.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(499, 457);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 492);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount_Total);
            this.Controls.Add(this.total);
            this.Controls.Add(this.discounttotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.txtCashier);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimecashier);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.nextcustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceList1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceList1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextcustomer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DateTimePicker dateTimecashier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlySalesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCashier;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label discounttotal;
        private System.Windows.Forms.Label total;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private PriceListDataSet priceListDataSet;
        private System.Windows.Forms.BindingSource priceList1BindingSource;
        private PriceListDataSetTableAdapters.PriceList1TableAdapter priceList1TableAdapter;
        private PriceListDataSet priceListDataSet1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gridbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.BindingSource priceList1BindingSource1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private PriceListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount_Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

