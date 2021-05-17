﻿using ClaimsRepo;
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
                        //EnterNewClaim
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
            

            bool keepItGoing = true;
            while (keepItGoing)
            {
                
                _repo.PeekNextClaim();
                Console.WriteLine("Do you want to remove the next claim in cue and mark it completed?");
                Console.WriteLine("     --------------------------------------------------------     ");
                Console.Write("            Please Choose (y/n): ");
                string input = (Console.ReadLine().ToLower());


                switch (input)
                {
                    case "y":
                        _repo.DequeueNextClaim();
                        Console.WriteLine("Claim Successfully Taken Care Of");
                        break;
                    case "n":
                        keepItGoing = false;
                        break;
                }
                Console.Clear();
            }
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
