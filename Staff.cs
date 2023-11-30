using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        public Staff(string staffid, string username,string position)
        {
            InitializeComponent();
            user = username;
            ps = position;
            sid = staffid;
        }
        string user;
        string ps;
        string sid;
        private void ClearALL()
        {
            txtName.Clear();txtPassword.Clear();txtPosition.Clear();txtSalary.Clear();txtUsername.Clear();
            comboGender.SelectedIndex = 0;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            try
            {
                dataStaff.Rows.Clear();

                string sql = "Select * From tblStaff";
                SqlCommand s = new SqlCommand(sql,DBConnection.DataCon);
                SqlDataReader r= s.ExecuteReader();
                while (r.Read())
                {
                    string id=r.GetValue(0).ToString();
                    string name=r.GetValue(1).ToString();
                    string sex=r.GetValue(2).ToString();
                    string position=r.GetValue(3).ToString();
                    string salary = r[4].ToString();
                    string username = r[5].ToString();
                    string password = r[6].ToString();

                    dataStaff.Rows.Add(id,name,sex,position,salary,username,password);
                }
                r.Close();
                s.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string gender = comboGender.Text.Trim();
                string position = txtPosition.Text.Trim();
                string salary = txtSalary.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                string sql = "Insert Into tblStaff(StaffName,Gender,Position,Salary,Username,Password) Values('" + name + "','" + gender + "','" + position + "','" + salary + "','" + username + "','" + password + "');";
                SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();

                string title = "Insert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Asterisk;
                MessageBox.Show("Data Inserted into Table Employee Successfully.", title, buttons, Icon);

                ClearALL();
                Staff_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataStaff.SelectedRows.Count > 0)
            {
                try
                {
                    int row = dataStaff.SelectedRows[0].Index;
                    string id = dataStaff.Rows[row].Cells[0].Value.ToString();

                    string message = "Are you sure you want to delete this record?";
                    string title = "Delete";
                    MessageBoxIcon Icon = MessageBoxIcon.Warning;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, Icon);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "Delete From tblStaff Where StaffID=" + id + ";";
                        SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                        s.ExecuteNonQuery();
                        s.Dispose();
                    }
                    Staff_Load(sender,e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btEditUpdate_Click(object sender, EventArgs e)
        {
            if (btEditUpdate.Text.Trim() == "Edit" && dataStaff.SelectedRows.Count > 0)
            {
                int row = dataStaff.SelectedRows[0].Index;

                string id = dataStaff.Rows[row].Cells[0].Value.ToString();
                txtName.Text = dataStaff.Rows[row].Cells[1].Value.ToString();
                if (dataStaff.Rows[row].Cells[2].Value.ToString().Equals("Male"))
                {
                    comboGender.SelectedIndex = 0;
                }
                else
                {
                    comboGender.SelectedIndex = 1;
                }
                txtPosition.Text = dataStaff.Rows[row].Cells[3].Value.ToString();
                txtSalary.Text = dataStaff.Rows[row].Cells[4].Value.ToString();
                txtUsername.Text = dataStaff.Rows[row].Cells[5].Value.ToString();
                txtPassword.Text = dataStaff.Rows[row].Cells[6].Value.ToString();

                labelID.Text = id;
                btEditUpdate.Text= "Update";
            }
            else
            {
                if (btEditUpdate.Text.Trim() == "Update" && txtName.Text != "")
                {
                    try
                    {
                        string id = labelID.Text;
                        string name = txtName.Text.Trim();
                        string gender = comboGender.Text.Trim();
                        string position = txtPosition.Text.Trim();
                        string salary = txtSalary.Text.Trim();
                        string username = txtUsername.Text.Trim();
                        string password = txtPassword.Text.Trim();

                        string sql = "Update tblStaff Set StaffName= '" + name + "', Gender='" + gender + "', Position='" + position + "', Salary=" + salary + ", Username='" + username + "', Password='" + password + "' where StaffID=" + id + " ;";
                        SqlCommand s= new SqlCommand(sql,DBConnection.DataCon);
                        s.ExecuteNonQuery();
                        s.Dispose();

                        string message = "Record was Updated Successfully";
                        string title = "Update";
                        MessageBoxIcon Icon = MessageBoxIcon.Asterisk;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons, Icon);

                        Staff_Load(sender, e);

                        labelID.Text = "";
                        btEditUpdate.Text = "Edit";
                        dataStaff.ClearSelection();
                        ClearALL();
                        comboGender.Text = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm(sid,user,ps).Show();
        }

        private void dataStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataStaff_SelectionChanged(object sender, EventArgs e)
        {
            btEditUpdate.Text = "Edit";
            txtName.Clear();
            txtPassword.Clear();
            txtPosition.Clear();
            txtSalary.Clear();
            txtUsername.Clear();
            labelID.Text = "";
        }
    }
}
