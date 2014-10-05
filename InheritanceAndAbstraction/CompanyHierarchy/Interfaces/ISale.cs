using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface ISale
    {
        string ProductName { get; set; }
        string Date { get; set; }
        int Price { get; set; }
    }
}
