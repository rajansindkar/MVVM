using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleWpfApplication.Model;
namespace SampleWpfApplication.ViewModel
{
    class MyViewModel
    {
        Customers objCust = new Customers();
        int i;
        MyViewModel(string name) 
        {
            objCust.CustID = i;
            objCust.CustName = name;
            i++;
        }
        public Customers GetCustomers()
        {
            return objCust;
        }
    }
}
