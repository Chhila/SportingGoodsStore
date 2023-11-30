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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            
        }
        public void setParameter(int index, object value)
        {
            CrystalReport11.SetParameterValue(index, value);
        }
        public void setSource(List<ReportDetails>arr)
        {
            CrystalReport11.SetDataSource(arr);
        }
        public void Print(int n, bool col,int start, int end)
        {
            CrystalReport11.PrintToPrinter(n, col, start, end);
        }
    }
}
