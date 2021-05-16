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
        private ClaimsRepository _repo = new ClaimsRepository();
        private Queue<Claim> qCurrent = new Queue<Claim>();
        private Claim claim = new Claim();
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
                        //TakeCareOfNextClaim():
                        break;
                    case "3":
                        //EnterNewClaim
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Please Press Any Key To Continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void SeeAllClaims()
        {
            
            Console.Clear();
            _repo.SeeAllClaims();
            Console.Clear();
            Console.WriteLine($"{claim.ClaimID}      {claim.Description}     {claim.ClaimAmount}     {claim.DateOfIncident}      {claim.DateOfClaim}       {claim.TypeOfClaim}       {claim.IsValid}");

        }
        private void TakeCareOfNextClaim()
        {
            //peek and dequeue
            Console.Clear();

        }



        public void QEnqueue()
        {

            Claim claim1 = new Claim(1, "Car accident on 465.", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), ClaimType.Car);
            Claim claim2 = new Claim(2, "House Fire in Kitchen", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12), ClaimType.Home);
            Claim claim3 = new Claim(3, "Stolen pancakes.", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 01), ClaimType.Theft);

            qCurrent.Enqueue(claim1);
            qCurrent.Enqueue(claim2);
            qCurrent.Enqueue(claim3);
        }
    }
}
