using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_GreetingConsole
{
    public class CustUI
    {
        public void Run()
        {
        }

        private void Menu()
        {
            
            bool coolRunnings = true;
            while (coolRunnings)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Customer Database!\n" +
                                  "What Would You Like To do? (1-5)\n" +
                                  "1. Create New Customer File\n" +
                                  "2. View Customer By Full Name\n" +
                                  "3. Update Existing Customer File\n" +
                                  "4. Delete Customer from Directory\n" +
                                  "5. Exit Program");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
