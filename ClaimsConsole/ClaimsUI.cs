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
        private readonly ClaimsRepository _repo = new ClaimsRepository();
        public void Run()
        {
            QEnqueue();
            Menu();
        }
        private void Menu()
        {
            Console.Clear();
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("    Select One Of The Following: \n" +
                                 "                             \n" +
                                 "\t1 -- See All Claim In Queue\n" +
                                 "\t2 -- Take Care of Next Claim\n" +
                                 "\t3 -- Enter New Claim\n" +
                                 "\t4 -- Exit Program\n" +
                                 "                          ");
                Console.WriteLine("Please Enter a Number (1-4): ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void SeeAllClaims()
        {

            Console.Clear();
            _repo.SetWindowSize();
            _repo.BuildTable();

        }
        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            _repo.PeekNextClaim();


        }
        public void EnterNewClaim()
        {
            Console.Clear();
            Claim claim = new Claim();

            Console.Write("Enter New Claim ID: ");
            claim.ClaimID = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("0 = Car, 1 = Home, 2 = Theft");
            Console.WriteLine("                            ");
            Console.Write("Enter New Claim Type:  ");
            int typeAsInt = Convert.ToInt32(Console.ReadLine());
            claim.TypeOfClaim = (ClaimType)typeAsInt;
            Console.Clear();

            Console.Write("Enter New Claim Description: ");
            claim.Description = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter New Claim Amount: ");
            claim.ClaimAmount = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.Write("Enter New Date of Incident: ");
            claim.DateOfIncident = Convert.ToDateTime(Console.ReadLine());
            Console.Clear();

            Console.Write("Enter New Date of Claim: ");
            claim.DateOfClaim = Convert.ToDateTime(Console.ReadLine());
            _repo.AddNewClaim(claim);
            Console.Clear();
        }
        public void QEnqueue()
        {
            Claim claim1 = new Claim(1, "Car accident on 465.", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), ClaimType.Car);
            _repo.AddNewClaim(claim1);
            Claim claim2 = new Claim(2, "House Fire in Kitchen", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12), ClaimType.Home);
            _repo.AddNewClaim(claim2);
            Claim claim3 = new Claim(3, "Stolen pancakes.", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 01), ClaimType.Theft);
            _repo.AddNewClaim(claim3);
            

        }
    }
}
