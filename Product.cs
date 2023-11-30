using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        public Product(string staffid,string username,string position)
        {
            InitializeComponent();
            user = username;
            ps = position;
            sid = staffid;
        }
        string user;
        string ps;
        string sid;
        public void ClearAll()
        {
            txtProductName.Text = string.Empty;txtPrice.Text = string.Empty;txtSQty.Text = string.Empty;comboCategoryName.SelectedIndex = 0/*;txtSearch.Text = string.Empty*/;
            picProduct.Image = Properties.Resources.No_Image_Available;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLogin));
            t.Start();
            this.Close();
        }
        public static void OpenLogin()
        {
            Application.Run(new StaffLogin());
        }

        List<string> cID = new List<string>();
        private void Product_Load(object sender, EventArgs e)
        {
            try
            {
                dataProduct.Rows.Clear();
                comboCategoryName.Items.Clear();

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

                string sql1 = "Select * From tblCategory";
                SqlCommand s1 = new SqlCommand(sql1, DBConnection.DataCon);
                SqlDataReader r1 = s1.ExecuteReader();
                while (r1.Read())
                {
                    string cid = r1.GetValue(0).ToString();
                    cID.Add(cid);
                    string cname = r1[1].ToString();
                    comboCategoryName.Items.Add(cname);
                }
                comboCategoryName.Text = "Soccer";
                r1.Close();
                s1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            //if (txtSearch.Text != "")
            //{
            //    string searchname = txtSearch.Text.Trim();
            //    try
            //    {
            //        string sql = " select * from tblProduct where ProductName like '%" + searchname + "%'; ";
            //        SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
            //        SqlDataReader r = s.ExecuteReader();
            //        dataProduct.Rows.Clear();
            //        while (r.Read())
            //        {
            //            string pid = r[0].ToString();
            //            string pname = r[1].ToString();
            //            string price = r[2].ToString();
            //            string sqty = r[3].ToString();
            //            byte[] img = (byte[])(r[4]);
            //            string cid = r[5].ToString();
            //            dataProduct.Rows.Add(pid, pname, price, sqty, img, cid);
            //        }
            //        this.dataProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //        this.dataProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //        this.dataProduct.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //        r.Close();
            //        s.Dispose();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    Product_Load(sender, e);
            //}

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataProduct.SelectedRows.Count > 0)
            {
                int index = dataProduct.SelectedRows[0].Index;
                string pid = dataProduct.Rows[index].Cells[0].Value.ToString();

                string message = "Are you sure you want to delete this record?";
                string title = "Delete";
                MessageBoxIcon Icon = MessageBoxIcon.Warning;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, Icon);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from tblProduct Where ProductID = " + pid + ";";
                    SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                    s.ExecuteNonQuery();
                    s.Dispose();

                    ClearAll();
                    Product_Load(sender, e);
                }
            }
        }

        string imgLocation = "";
        private void picProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileName = new OpenFileDialog();
            fileName.Filter = "Image Files(.PNG;*.JPG;*.GIF;)|*.PNG;*.JPG;*.GIF;*.JPEG|All files(*.*)|*.*";
            if(fileName.ShowDialog() == DialogResult.OK)
            {
                imgLocation = fileName.FileName.ToString();
                picProduct.ImageLocation = imgLocation;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           if(txtProductName.Text!="" && txtPrice.Text !="" && txtSQty.Text != "" && comboCategoryName.Text != "")
            {
                try
                {
                    string pname = txtProductName.Text.Trim();
                    string price = txtPrice.Text.Trim();
                    string sqty = txtSQty.Text.Trim();
                    string cname = comboCategoryName.Text.Trim();
                    byte[] image = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);


                    string sql = "Insert Into tblProduct(ProductName,Price,SQty,Picture,CategoryID) Values('" + pname + "'," + price + "," + sqty + ",@image," + cateID + ");";
                    SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                    s.Parameters.Add(new SqlParameter("@image", image));
                    s.ExecuteNonQuery();
                    s.Dispose();

                    string title = "Insert";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon Icon = MessageBoxIcon.Asterisk;
                    MessageBox.Show("Data Inserted into Table Employee Successfully.", title, buttons, Icon);

                    ClearAll();
                    Product_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        string cateID;
        private void comboCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboCategoryName.SelectedIndex;
            cateID = cID[index].ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(sid, user,ps).Show();
        }

        private void btEditUpdate_Click(object sender, EventArgs e)
        {
            int row = dataProduct.SelectedRows[0].Index;
            if (btEditUpdate.Text == "Edit" && dataProduct.SelectedRows.Count > 0)
            {
                string id = dataProduct.Rows[row].Cells[0].Value.ToString();
                txtProductName.Text = dataProduct.Rows[row].Cells[1].Value.ToString();
                txtPrice.Text = dataProduct.Rows[row].Cells[2].Value.ToString();
                txtSQty.Text = dataProduct.Rows[row].Cells[3].Value.ToString();
                //Picture From DataGridView from PicBox( Conversion )
                byte[] img = (byte[])dataProduct.Rows[row].Cells[4].Value;
                MemoryStream ms = new MemoryStream(img);
                picProduct.Image = Image.FromStream(ms);
                string cid = dataProduct.Rows[row].Cells[5].Value.ToString();

                string cname; /*= Convert.ToInt32(dataProduct.Rows[row].Cells[5].Value.ToString());*/
                //comboCategoryName.SelectedIndex = cid - 1; 

                string sql = "Select CategoryName from tblCategory Where CategoryID = '" + cid + "';";
                SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                if (r.Read())
                {
                    cname = r[0].ToString();
                    comboCategoryName.Text = cname.ToString();
                }
                s.Dispose();
                r.Close();
                btEditUpdate.Text = "Update";
            }
            else
            {
                if (btEditUpdate.Text == "Update" && txtProductName.Text != "")
                {
                    try
                    {
                        string pid = dataProduct.Rows[row].Cells[0].Value.ToString();
                        string pname = txtProductName.Text.Trim();
                        string price = txtPrice.Text.Trim();
                        string sqty = txtSQty.Text.Trim();

                        byte[] image = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        image = brs.ReadBytes((int)stream.Length);

                        string sql = "Update tblProduct Set ProductName='" + pname + "', Price = " + price + ", SQty=" + sqty + ", Picture=@image, CategoryID = " + cateID + " Where ProductID = " + pid + ";";
                        SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                        s.Parameters.Add(new SqlParameter("@image", image));
                        s.ExecuteNonQuery();
                        s.Dispose();

                        string message = "Record was Updated Successfully";
                        string title = "Update";
                        MessageBoxIcon Icon = MessageBoxIcon.Asterisk;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons, Icon);

                        Product_Load(sender, e);

                        btEditUpdate.Text = "Edit";
                        dataProduct.ClearSelection();
                        ClearAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataProduct_SelectionChanged(object sender, EventArgs e)
        {
            txtProductName.Clear(); txtPrice.Clear();/* txtSearch.Clear()*/; txtSQty.Clear();comboCategoryName.Text = "Soccer";
            btEditUpdate.Text = "Edit";
            picProduct.Image = Properties.Resources.No_Image_Available;
        }

        private void btAddNewCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewCategory(sid,user,ps).Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string search = txtSearch.Text.Trim();
                try
                {
                    string sql = "select * from tblProduct where ProductName like '%" + search + "%';";
                    SqlCommand s1 = new SqlCommand(sql, DBConnection.DataCon);
                    SqlDataReader r1 = s1.ExecuteReader();
                    dataProduct.Rows.Clear();
                    while (r1.Read())
                    {
                        string pid = r1[0].ToString();
                        string pname = r1[1].ToString();
                        string price = r1[2].ToString();
                        string sqty = r1[3].ToString();
                        byte[] img = (byte[])r1[4];
                        string cid = r1[5].ToString();
                        dataProduct.Rows.Add(pid, pname, price, sqty, img, cid);
                    }
                    s1.Dispose();
                    r1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Product_Load(sender, e);
            }
        }
    }
}
