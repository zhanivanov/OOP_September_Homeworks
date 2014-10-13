using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    [Serializable]
    class Payment
    {
        private string productName;
        private int price;

        public Payment(string productName, int price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return "\n\t-Product name: " + this.productName +
                    "\n\t-Price: " + this.price;
        }
    }
}
