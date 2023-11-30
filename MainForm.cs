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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string staffid, string username,string postion)
        {
            InitializeComponent();
            user = username;
            ps = postion;
            sid= staffid;
        }
        string user;
        string ps;
        string sid;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ps == "Manager")
            {
                btCategory.Enabled = true;
                btIncome.Enabled = true;
                btProduct.Enabled = true;
                btStaff.Enabled = true;
                btSale.Enabled = true;
                btInvoice.Enabled = true;
            }
            else if (ps =="Cashier")
            {
                btCategory.Enabled = false;
                btIncome.Enabled = false;
                btProduct.Enabled = false;
                btStaff.Enabled = false;
                btSale.Enabled = true;
                btInvoice.Enabled = false;
            }
            else
            {
                btCategory.Enabled = false;
                btIncome.Enabled = false;
                btProduct.Enabled = true;
                btStaff.Enabled = false;
                btSale.Enabled = false;
                btInvoice.Enabled = false;
            }
            LabelWelcome.Text = "Welcome " + ps + " " + user;
        }

        private void btCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Category(sid,user, ps).Show();
        }

        private void btSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sales(sid,user,ps).Show();
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Staff(sid,user, ps).Show();
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Product(sid,user,ps).Show();
        }

        private void btIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Income(sid,user, ps).Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }
        public static void OpenLogin()
        {
            Application.Run(new StaffLogin());
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Invoice(sid, user,ps).Show();
        }
    }
}
