using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        public Invoice(string staffid,string username, string position)
        {
            InitializeComponent();
            user = username;
            ps = position;
            sid=staffid;
        }
        string user;
        string ps;
        string sid;

        private void Invoice_Load(object sender, EventArgs e)
        {
            string sql = "Select * From tblInvoice";
            SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            while (r.Read())
            {
                string iid= r[0].ToString();
                DateTime date = (DateTime)r[1];
                double total = double.Parse(r[2].ToString());
                string sid= r[3].ToString();
                dataInvoice.Rows.Add(iid, date.ToString("yyyy-MM-dd"), total.ToString("$#,##0.00"), sid);
                this.dataInvoice.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            r.Close();
            s.Dispose();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(sid,user,ps).Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(txtStaffID.Text !=""&& dateTimePicker1.Text!="" && dateTimePicker2.Text != "")
            {
                try
                {
                    string sdate = dateTimePicker1.Text.ToString();
                    string edate = dateTimePicker2.Text.ToString();
                    string sid = txtStaffID.Text.Trim();

                    string sql = "Select * From tblInvoice Where StaffID = " + sid + " and Date between '" + sdate + "' and '" + edate + "';";
                    SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                    SqlDataReader r = s.ExecuteReader();
                    dataInvoice.Rows.Clear();
                    while(r.Read())
                    {
                        string iid = r[0].ToString();
                        DateTime date = (DateTime)r[1];
                        double total = (double)r[2];
                        string staffid= r[3].ToString();

                        dataInvoice.Rows.Add(iid,date.ToString("yyyy-MM-dd"),total.ToString("$#,##0.00"),staffid);
                    }
                    s.Dispose();
                    r.Close();
                    this.dataInvoice.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value > DateTime.Now)
            {
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
