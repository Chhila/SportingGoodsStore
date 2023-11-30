using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingGoodsStore
{
    internal class OrderDetails
    {
        private int qty;

        public int Qty { get => qty; set => qty = value; }

        public int PID { get; set; }

        public double Amount { get; set; }

        public OrderDetails()
        {

        }

        public OrderDetails(int qty, int pID, double amount)
        {
            Qty = qty;
            PID = pID;
            this.Amount = amount;
        }
    }
}
