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
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }
        public NewCategory(string staffid, string username, string position)
        {
            InitializeComponent();
            user = username;
            ps = position;
            sid = staffid;
        }
        string user;
        string ps;
        string sid;

        private void NewCategory_Load(object sender, EventArgs e)
        {
            dataCategory.Rows.Clear();
            txtCategoryName.Focus();
            try
            {
                string sql = "Select * From tblCategory;";
                SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                while (r.Read())
                {
                    string cid= r[0].ToString();
                    string cname= r[1].ToString();

                    dataCategory.Rows.Add(cid,cname);
                }
                s.Dispose();
                r.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string cname = txtCategoryName.Text.Trim();

                string sql = "Insert into tblCategory(CategoryName) Values('" + cname + "');";
                SqlCommand s = new SqlCommand(@sql,DBConnection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();

                NewCategory_Load(sender, e);
                txtCategoryName.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Product(sid,user,ps).Show();
        }
    }
}
