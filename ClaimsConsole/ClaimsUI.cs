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
        Queue<Current> qCurrent = new Queue<Current>();

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
                Console.WriteLine("\t1 -- See All Claims In Queue");
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
           
            Claim1 claim1 = new Claim1();
            Claim2 claim2 = new Claim2();
            Claim3 claim3 = new Claim3();

            qCurrent.Enqueue(claim1);
            qCurrent.Enqueue(claim2);
            qCurrent.Enqueue(claim3);
        }
    }
}
