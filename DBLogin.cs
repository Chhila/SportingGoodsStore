using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingGoodsStore
{
    public partial class DBLogin : Form
    {
        public DBLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DBLogin_Load(object sender, EventArgs e)
        {
            comboAuthentication.SelectedIndex = 0;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
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

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="Enter Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor=Color.White;
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

        private void comboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboAuthentication.SelectedIndex == 0)
            {
                labelUsername.Enabled = false;
                labelPassword.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                chkShowPW.Enabled = false;
                panelLineUsername.Enabled = false;
                panelLinePassword.Enabled = false;
            }
            else
            {
                labelUsername.Enabled = true;
                labelPassword.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                chkShowPW.Enabled = true;
                panelLineUsername.Enabled = true;
                panelLinePassword.Enabled = true;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Enter Username")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.White;
            }
        }

        private void labelStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }

        private void labelLoginAs_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = "CHHILA";
                string dbName = "SportingGoodsStoreDB";
                string user = txtUsername.Text;
                string password = txtPassword.Text;
                int index = comboAuthentication.SelectedIndex;
                if (index == 0)
                {
                    user = "Window User";
                    DBConnection.ConnectionDB(ip, dbName);
                }
                else
                {
                    DBConnection.ConnectionDB(ip, dbName, user, password);
                }
                this.Hide();
                new MainForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }
    }
}
