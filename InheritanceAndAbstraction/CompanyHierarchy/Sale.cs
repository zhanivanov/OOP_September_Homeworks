using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Sale
    {
        private string productName;
        private string date;
        private int price;

        public Sale(string productName, string date, int price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                this.productName = value;
            }
        }

        public string Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
            }
        }

        private int Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return "\n\t\tProduct name: " + ProductName + "\n\t\tDate: " + Date + "\n\t\tPrice: " + Price;
        }
    }
}
