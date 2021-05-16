using ClaimsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ClaimsConsole
{
    public class ClaimsUI
    {
        Queue<Claim> qCurrent = new Queue<Claim>();

        public void Run()
        {
            QEnqueue();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select One Of The Following:");
                Console.WriteLine("                             ");
                Console.WriteLine("\t1 -- See All Claim In Queue");
                Console.WriteLine("\t2 -- Take Care of Next Claim");
                Console.WriteLine("\t3 -- Enter New Claim");
                Console.WriteLine("\t4 -- Exit Program");
                Console.WriteLine("                          ");
                Console.Write("Please Enter a Number (1-4): ");
                string selection = Console.ReadLine();
                int selToInt = Convert.ToInt32(selection);
                switch (selToInt)
                {
                    case 1:
                        //SeeAllClaims();
                        break;
                    case 2:
                        //TakeCareOfNextClaim():
                        break;
                    case 3:
                        //EnterNewClaim
                        break;
                    case 4:
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
            }            
        }
        private void SeeAllClaims()
            {
            

            
            }
        private void TakeCareOfNextClaim()
        {
            

        }
        
        
        
        public void QEnqueue()
        {
           
            Claim claim1 = new Claim(2, "House Fire in Kitchen", 4000.00m, (2018, 4, 11), (2018, 4, 12));
            Claim claim2 = new Claim();
            Claim claim3 = new Claim();

            qCurrent.Enqueue(claim1);
            qCurrent.Enqueue(claim2);
            qCurrent.Enqueue(claim3);
        }
    }
}
