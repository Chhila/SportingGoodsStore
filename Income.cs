using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }
        public Income(string staffid,string username, string position)
        {
            InitializeComponent();
            user = username;
            ps = position;
            sid = staffid;
        }
        string user;
        string ps;
        string sid;
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(sid,user, ps).Show();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "")
            {
                try
                {
                    string sdate = dateTimePicker1.Text.Trim();
                    string edate = dateTimePicker2.Text.Trim();
                    double totalamount = 0 ;

                    string sql = "Select sum(Total) from tblInvoice where Date between '" + sdate + "' and '" + edate + "';";
                    SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
                    SqlDataReader r = s.ExecuteReader();
                    if (r.Read())
                    {
                        totalamount = (double)r[0];
                    }
                    r.Close();
                    s.Dispose();

                    txtTotalAmount.Text = totalamount.ToString("$#,##0.00");

                    string sql1 = "Insert Into tblIncome(StartDate,EndDate,TotalAmount,StaffID) Values('" + sdate + "','" + edate + "'," + totalamount + "," + sid + "); ";
                    SqlCommand s1 = new SqlCommand(sql1, DBConnection.DataCon);
                    s1.ExecuteNonQuery();
                    s1.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > DateTime.Now)
            {
                dateTimePicker2.Value = DateTime.Now;
            }
        }
    }
}
