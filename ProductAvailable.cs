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
    public partial class ProductAvailable : Form
    {
        public ProductAvailable()
        {
            InitializeComponent();
        }
        public ProductAvailable(string cid)
        {
            InitializeComponent();
            CategoryID = int.Parse(cid);
        }
        int CategoryID;
        private void ProductAvailable_Load(object sender, EventArgs e)
        {
            try
            {
                dataProductAvailable.Rows.Clear();

                string sql = "Select * From tblProduct Where CategoryID=" + CategoryID + ";";
                SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                while (r.Read())
                {
                    string pid = r.GetValue(0).ToString();
                    string pname = r.GetValue(1).ToString();
                    string price= r.GetValue(2).ToString();
                    string sqty= r[3].ToString();
                    string picture= r[4].ToString();

                    string t;
                    if (picture != null)
                        t = "Yes";
                    else
                        t = "No";
                    string cid = CategoryID.ToString();
                    dataProductAvailable.Rows.Add(pid, pname, price, sqty, t, cid);
                }
                r.Close();
                s.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
