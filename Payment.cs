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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(double totalamount)
        {
            InitializeComponent();
            TotalAmount = totalamount;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            comboDiscount.SelectedIndex = 0;
            txtTotalAmount.Text = TotalAmount.ToString("$#,##0.00");
        }

        public double TotalAmount { get; set; }

        public double Discount { get; set; }

        public double DisPrice { get; set; }

        public double Pay { get; set; }

        public double CashRecieved { get; set; }

        public double CashReturned { get; set; }

        public Boolean Preview { get; set;}

        private void comboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dis=comboDiscount.SelectedItem.ToString();
            dis=dis.Substring(0, dis.Length-1);
            Discount = double.Parse(dis);
            DisPrice = TotalAmount * Discount / 100;
            Pay= TotalAmount - DisPrice;

            txtDiscountPrice.Text = DisPrice.ToString("$#,##0.00");
            txtPayment.Text = Pay.ToString("$#,##0.00");
        }

        private void txtCashRecieved_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                try
                {
                    string crecieved = txtCashRecieved.Text.Trim();
                    CashRecieved = double.Parse(crecieved);
                    if (CashRecieved >= Pay)
                    {
                        CashReturned = CashRecieved - Pay;
                        txtCashReturned.Text = CashReturned.ToString("$#,##0.00");
                        btPay.Enabled = true;
                    }
                    else
                    {
                        txtCashReturned.Text = "$0.00";
                        btPay.Enabled = false;
                    }
                }
                catch
                {

                }
            }
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            Preview = chkPreview.Checked;
            DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
