using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_GreetingRepo
{
    public enum CustType { Potential, Current, Past }
    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FName} {LName}";
            }
        }
        public CustType TypeCust { get; set; }
        public Customer() { }
        public Customer(string fName, string lName, CustType typeCust)
        {
            FName = fName;
            LName = lName;
            TypeCust = typeCust;
        }
    }
}
