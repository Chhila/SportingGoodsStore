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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string ip = "CHHILA";
                string dbName = "SportingGoodsStoreDB";
                DBConnection.ConnectionDB(ip, dbName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StaffLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text =="Enter Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.White;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor= Color.White;
            if (chkShowPW.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPW.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void labelDatabaseUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DBLogin().Show();
        }

        private void labelLoginAs_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DBLogin().Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = System.Drawing.Color.White;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string position;
            bool t = false;
            if(username != "") 
            { 
                try
                {
                    string sql = "Select * From tblStaff";
                    SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
                    SqlDataReader r = s.ExecuteReader();
                    while (r.Read())
                    {
                        position = r[3].ToString();
                        string sid = r[0].ToString();
                        string staffuser = r.GetValue(5).ToString();
                        string staffpw = r.GetValue(6).ToString();
                        if (staffuser.Equals(username) && staffpw.Equals(password))
                        {
                            this.Hide();
                            new MainForm(sid,username,position).Show();
                            t = true;
                        }
                    }
                    if (t == false)
                    {
                        MessageBox.Show("Your User is Invalid");
                    }
                    s.Dispose();
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
