using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface IProject
    {
        string ProjectStartDate { get; set; }
        string Details { get; set; }
        State StateProp { get; set; }
        void CloseProjcet();
    }
}
