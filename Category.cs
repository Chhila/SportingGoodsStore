using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        public Category(string staffid,string username, string position)
        {
            InitializeComponent();
            user = username;
            ps = position;
            sid=staffid;
        }
        string user;
        string ps;
        string sid;
        private List<string> cid = new List<string>();

        private void Category_Load(object sender, EventArgs e)
        {
            try
            {
                dataCategory.Rows.Clear();

                string sql = "Select * From tblCategory";
                SqlCommand s= new SqlCommand(sql,DBConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                while (r.Read())
                {
                    string cid=r.GetValue(0).ToString();
                    string cname = r[1].ToString();
                    dataCategory.Rows.Add(cid,cname);
                }
                this.dataCategory.Columns[0].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
                r.Close();
                s.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btProductAvailable_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (dataCategory.SelectedRows.Count>0)
            {
                int row = dataCategory.Rows[0].Index;

                string cid = dataCategory.SelectedRows[0].Cells[0].Value.ToString();
                new ProductAvailable(cid).ShowDialog();
                t = true;
            }
            if (t == false)
            {
                if (dataCategory.SelectedRows.Count > 0)
                {
                    int row = dataCategory.SelectedRows[0].Index;

                    string id= dataCategory.Rows[row].Cells[0].Value.ToString();
                    new ProductAvailable(id).ShowDialog();
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string cname = txtCategoryName.Text.Trim();
            try
            {
                string sql = "Insert Into tblCategory(CategoryName) Values('" + cname + "');";
                SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();

                string title = "Insert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Asterisk;
                MessageBox.Show("Data Inserted into Table Employee Successfully.", title, buttons, Icon);


                Category_Load(sender, e); // Reload DataGridView Through Load Property
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataCategory.SelectedRows.Count > 0 )
            {
                int index = dataCategory.SelectedRows[0].Index;

                string pid = dataCategory.Rows[index].Cells[0].Value.ToString();

                string message = "Are you sure you want to delete this record?";
                string title = "Delete";
                MessageBoxIcon Icon = MessageBoxIcon.Warning;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, Icon);
                if (result == DialogResult.Yes)
                {
                    string sql = "Delete from tblCategory Where CategoryID = " + pid + ";";
                    SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                    s.ExecuteNonQuery();
                    s.Dispose();
                }
                Category_Load(sender, e);
            }
        }

        private void btEditUpdate_Click(object sender, EventArgs e)
        {
            if (btEditUpdate.Text == "Edit" && dataCategory.SelectedRows.Count > 0)
            {
                int row = dataCategory.SelectedRows[0].Index;

                string id = dataCategory.Rows[row].Cells[0].Value.ToString();
                txtCategoryName.Text = dataCategory.Rows[row].Cells[1].Value.ToString();
                labelID.Text = id;
                
                btEditUpdate.Text = "Update";
            }
            else
            {
                if (btEditUpdate.Text == "Update" && txtCategoryName.Text != "")
                {
                    try
                    {
                        string id = labelID.Text;
                        string name = txtCategoryName.Text.Trim();

                        string sql = "Update tblCategory Set CategoryName= '" + name + "' where CategoryID= '" + id + "';";
                        SqlCommand s=new SqlCommand(sql, DBConnection.DataCon);
                        s.ExecuteNonQuery();
                        s.Dispose();

                        string message = "Record was Updated Successfully";
                        string title = "Update";
                        MessageBoxIcon Icon = MessageBoxIcon.Asterisk;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons, Icon);

                        Category_Load(sender,e);

                        labelID.Text = "";
                        btEditUpdate.Text = "Edit";
                        dataCategory.ClearSelection();
                        txtCategoryName.Clear();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void labelID_Click(object sender, EventArgs e)
        {

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

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(sid,user,ps).Show();
        }

        private void dataCategory_SelectionChanged(object sender, EventArgs e)
        {
            btEditUpdate.Text = "Edit";
            txtCategoryName.Text = "";
            labelID.Text = "";
        }
    }
}
