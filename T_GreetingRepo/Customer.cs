using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_GreetingRepo
{
    
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
        public Customer() { }
        public Customer(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
    }
}
