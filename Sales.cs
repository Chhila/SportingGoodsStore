using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        List<OrderDetails> orders = new List<OrderDetails>();
        public Sales(string staffid,string username,string position)
        {
            InitializeComponent();
            staffuser = username;
            ps = position;
            sid = staffid;
        }
        string staffuser;
        string ps;
        string sid;
        private void Sales_Load(object sender, EventArgs e)
        {
            dataProduct.Rows.Clear();

            string sql = "Select * From tblProduct";
            SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            while (r.Read())
            {
                string pid = r[0].ToString();
                string pname = r[1].ToString();
                string price = r[2].ToString();
                string sqty = r[3].ToString();
                byte[] img = (byte[])(r[4]);
                string cid = r[5].ToString();
                dataProduct.Rows.Add(pid, pname, price, sqty, img, cid);
            }
            this.dataProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataProduct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            r.Close();
            s.Dispose();

            string sql1 = "Select StaffID From tblStaff Where Username='" + staffuser + "';";
            SqlCommand s1 = new SqlCommand(sql1,DBConnection.DataCon);
            SqlDataReader r1 = s1.ExecuteReader();
            if (r1.Read())
            {
                sid = r1[0].ToString();
            }
            s1.Dispose();
            r1.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string searchname = txtSearch.Text.Trim();
                try
                {
                    string sql = " select * from tblProduct where ProductName like '%" + searchname + "%'; ";
                    SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                    SqlDataReader r = s.ExecuteReader();
                    dataProduct.Rows.Clear();
                    while (r.Read())
                    {
                        string pid = r[0].ToString();
                        string pname = r[1].ToString();
                        string price = r[2].ToString();
                        string sqty = r[3].ToString();
                        byte[] img = (byte[])(r[4]);
                        string cid = r[5].ToString();
                        dataProduct.Rows.Add(pid, pname, price, sqty, img, cid);
                    }
                    this.dataProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dataProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dataProduct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    r.Close();
                    s.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Sales_Load(sender, e);
            }
        }

        private bool orderProduct(int pid)
        {
            string sql = "Select * From tblProduct Where ProductID=" + pid + ";";
            SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            if (r.Read())
            {
                string pname = r[1].ToString();
                int sqty = int.Parse(r[3].ToString());
                int qty;
                if (txtQty.Text == "")
                    qty = 1;
                else 
                    qty = int.Parse(txtQty.Text.Trim());
                int orderqty = int.Parse(txtQty.Text.Trim());
                if (orderqty <= sqty)
                {
                    double price = double.Parse(r[2].ToString());
                    double amount = qty * price;
                    int iid = dataOrder.Rows.Count + 1;

                    dataOrder.Rows.Add(iid, pname, price.ToString("$0.00"), qty, amount.ToString("$#,##0.00"));
                    OrderDetails obj = new OrderDetails(qty, pid, amount);
                    orders.Add(obj);

                }
                else
                {
                    string title = "Product Stock";
                    string message= "Sorry but there aren't enough Stock Quantity for The Order.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(message,title,buttons,icon);
                }
                s.Dispose();
                r.Close();
                return true;
                
            }
            else
            {
                r.Close();
                s.Dispose();
                return false;
            }
        }

        private double TotalAmount()
        {
            double t = 0;
            for(int i = 0; i < dataOrder.RowCount; i++)
            {
                t += double.Parse(dataOrder.Rows[i].Cells[4].Value.ToString().Substring(1));
            }

            return t;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                int pid = int.Parse(txtProductID.Text.Trim());
                
                if (orderProduct(pid))
                {
                    txtProductID.Clear(); txtQty.Clear();
                    txtTotal.Text = TotalAmount().ToString("$#,##0.00");
                }
                else
                {
                    MessageBox.Show("Product is Out of Stock");
                }
                txtProductID.Focus();
            }
        }

        private int InsertInvoice(double pay)
        {
            string ODate = DateTime.Now.ToString("yyyy-MM-dd");
            string seller = sid;
            double total = pay;

            string sql = "Insert into tblInvoice(Date,Total,StaffID) Values('" + ODate + "'," + total + "," + seller + ");";
            SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
            s.ExecuteNonQuery();
            int oId = 0;
            sql = "Select SCOPE_IDENTITY()";
            s = new SqlCommand(sql,DBConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            if (r.Read())
            {
                oId = Convert.ToInt32(r[0]);
            }
            r.Close();
            s.Dispose();

            return oId;
        }

        private void InsertInvoiceDetails(int iID)
        {
            foreach(OrderDetails temp in orders)
            {
                int pid = temp.PID;
                int qty = temp.Qty;
                double amount= temp.Amount;
                //double amount = total;
                string sql = "Insert tblInvoiceDetails Values(" + qty + "," + amount + "," + pid + "," + iID + ");";
                SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();
            }
        }

        private void UpdateStock()
        {
            foreach(OrderDetails temp in orders)
            {
                int qty = temp.Qty;
                int pid = temp.PID;
                string sql = "Update tblProduct Set SQty=SQty-" + qty + " Where ProductID=" + pid + ";";
                SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();
            }
        }

        private void PrintReport(int orID,double discount,double cashReceived, bool preview)
        {
            FormReports report = new FormReports();
            List<ReportDetails> arr = new List<ReportDetails>();
            foreach(DataGridViewRow temp in dataOrder.Rows)
            {
                int no = int.Parse(temp.Cells[0].Value.ToString());
                string pname= temp.Cells[1].Value.ToString();
                double price = double.Parse(temp.Cells[2].Value.ToString(), System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);
                int qty = int.Parse(temp.Cells[3].Value.ToString());
                double amount = double.Parse(temp.Cells[4].Value.ToString(), System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);
                ReportDetails obj = new ReportDetails(no,pname,price,qty);
                arr.Add(obj);
            }
            report.setSource(arr);
            report.setParameter(0, orID);
            report.setParameter(1, staffuser);
            report.setParameter(2, discount);
            report.setParameter(3, cashReceived);
            if(preview)
                report.ShowDialog();
            else
                report.Print(1, true, 1, -1);
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            Payment p = new Payment(TotalAmount());
            if (p.ShowDialog() == DialogResult.OK)
            {
                //Insert Data to tblInvoice
                int inID = InsertInvoice(p.Pay);

                //Insert Data to tblInvoiceDetails
                InsertInvoiceDetails(inID);

                //Update Stock in tblProduct
                UpdateStock();

                //Print Report
                PrintReport(inID, p.Discount, p.CashRecieved,p.Preview);

                // Clear DataGridView to Store New Sales Invoice
                orders = new List<OrderDetails>();
                Sales_Load(sender, e);
                dataOrder.Rows.Clear();
                txtTotal.Clear();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(sid,staffuser,ps).Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataOrder.SelectedRows.Count > 0)
            {
                int index = dataOrder.SelectedRows[0].Index;

                string message = "Are you sure you want to delete this record?";
                string title = "Delete";
                MessageBoxIcon Icon = MessageBoxIcon.Warning;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, Icon);
                if (result == DialogResult.Yes)
                {
                    dataOrder.Rows.RemoveAt(index);
                    orders.RemoveAt(index);
                    txtTotal.Text = TotalAmount().ToString("$#,##0.00");
                }
            }
        }

        //string pid;
        //private void btEditUpdate_Click(object sender, EventArgs e)
        //{
        //    if (dataOrder.SelectedRows.Count > 0)
        //    {
        //        int row = dataOrder.SelectedRows[0].Index;

        //        int iid = int.Parse(dataOrder.Rows[row].Cells[0].Value.ToString());
        //        string pname = dataOrder.Rows[row].Cells[1].Value.ToString();
        //        double price = double.Parse(dataOrder.Rows[row].Cells[2].Value.ToString().Substring(1));
        //        string qty = dataOrder.Rows[row].Cells[3].Value.ToString();
        //        string amount = dataOrder.Rows[row].Cells[4].Value.ToString().Substring(1);
        //        if (btEditUpdate.Text.Trim() == "Edit")
        //        {
        //            string sql = "Select * From tblProduct Where ProductName='" + pname + "';";
        //            SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
        //            SqlDataReader r = s.ExecuteReader();
        //            if (r.Read())
        //            {
        //                pid = r[0].ToString();
        //                txtProductID.Text = pid;
        //                txtProductID.Enabled = false;
        //                txtQty.Text = qty;

        //                //orders.RemoveAt(row);
        //                btEditUpdate.Text = "Update";

        //            }
        //            r.Close();
        //            s.Dispose();
        //        }
        //        else
        //        {
        //            int nqty = int.Parse(txtQty.Text);
        //            double namount = nqty * price;
        //            dataOrder.Rows.RemoveAt(row);
        //            dataOrder.Rows.Add(iid, pname, price.ToString("$#,##0.00"), nqty, namount.ToString("$#,##0.00"));


        //            btEditUpdate.Text = "Edit";
        //            txtProductID.Enabled = true;
        //            txtTotal.Text=TotalAmount().ToString("$#,##0.00");
        //            dataOrder.Sort(dataOrder.Columns[0], ListSortDirection.Ascending);
        //        }
        //    }
        //}

        private void dataOrder_SelectionChanged(object sender, EventArgs e)
        {
            //btEditUpdate.Text = "Edit";
            txtProductID.Enabled = true;
            txtProductID.Clear();
            txtQty.Clear();
        }
    }
}
