using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_GreetingRepo
{

    public class GreetingRepository
    {
        Dictionary<string, string> CustType = new Dictionary<string, string>();
        private readonly List<Customer> CustDir = new List<Customer>();        
        public List<Customer> ViewAllCustomers()
        {
            return CustDir;
        }
        public void PopDict()
        {
            CustType.Add("Potential", "We currently have the lowest rates on Helicopter Insurance!");
            CustType.Add("Current", "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
            CustType.Add("Past", "It's been a long time since we've heard from you, we want you back.");
        }
        public bool AddCustomerToDirectory(Customer newCust)
        {
            int startCount = CustDir.Count();

            CustDir.Add(newCust);

            bool wasAdded = (CustDir.Count > startCount);
            return wasAdded;
        }
        public Customer GetByCustFullName(string fName, string lName)
        {
            Customer custard = new Customer();
            custard.FName = fName;
            custard.LName = lName;

            foreach (Customer cust in CustDir)
            {
                if (custard.FullName == cust.FullName)
                {
                    return cust;
                }
            }
            return null;
        }
        public bool UpdateCustomerInfo(string fName, string lName, Customer upVal)
        {
            Customer custard = new Customer();
            custard.FName = fName;
            custard.LName = lName;
            Customer oldCust = GetByCustFullName(fName, lName);

            if (oldCust != null)
            {
                oldCust.FName = upVal.FName;
                oldCust.FName = upVal.LName;
                oldCust.FName = upVal.FName;

                return true;
            }
            else { return false; }
        }
        public bool RemoveCustFromDir(string fOldCust, string lOldCust)
        {
            int startCount = CustDir.Count();

            foreach (Customer cust in CustDir)
            {
                if (cust.FName == fOldCust && cust.LName == lOldCust)
                {
                    CustDir.Remove(cust);
                }
            }
            bool wasEnded = (CustDir.Count > startCount);
            return wasEnded;
        }                
    }
}
