using SecurityRepo;
using System;
using System.Collections.Generic;
using BetterConsoleTables;

namespace SecurityConsole
{
    public class SecurityUI
    {

        private SecurityRepository _repo = new SecurityRepository();
        public void Run()
        {
            StockUpDict();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin, What would you like to do?");
                Console.WriteLine("1. Add a Badge\n" +
                                  "2. Edit a Badge\n" +
                                  "3. List All Badges\n" +
                                  "4. Exit Program");
                Console.Write("Please Make a Choice (1-4)");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        AddNewBadge();
                        break;
                    case "2":
                        EditDoorAccessonExistingBadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void AddNewBadge()
        {
            Console.Clear();
            SecurityID newDude = new SecurityID();
            List<string> newDoors = new List<string>();


            Console.Write("Please Enter New Badge ID: ");
            int badge = Convert.ToInt32(Console.ReadLine());

            newDude.BadgeID = badge;

            bool coolRunnings = true;

            while (coolRunnings)
            {
                Console.Write("List Door Access Needed: ");
                newDoors.Add(Console.ReadLine());
                newDude.Doors = newDoors;
                Console.Write("Add Another Doors? (y/n)");
                string moreDoors = Console.ReadLine().ToLower();

                if (moreDoors == "y")
                {
                    coolRunnings = true;
                }
                else
                {
                    coolRunnings = false;
                }
            }
            _repo.CreateNewBadge(newDude);
            bool wasAddedCorrectly = _repo.DoesKeyExist(newDude.BadgeID);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("Badge Successfully Created");
                Console.Write("Press Any Key To Continue to Main Menu.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Oops, Something Went Wrong. Try Again.");
            }




        }
        private void EditDoorAccessonExistingBadge()
        {
            SecurityID loaner = new SecurityID();
            Console.Clear();
            Console.Write("Please Enter Badge Number to Alter: ");
            string existingBadge = Convert.ToString(Console.ReadLine());

            int inputAsInt = Convert.ToInt32(existingBadge);

            bool doesItExist = _repo.DoesKeyExist(inputAsInt);
            if (doesItExist != false)
            {
                Console.Write("Enter A Door To Add Access to: ");
                string input = Console.ReadLine();
                _repo.AddDoorToExistingBadge(loaner);
                Console.WriteLine("Would You Like To Add Another Door?");
                string input1 = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("That Badge Doesnt Exist, Please Try Again.");
            }

        }
        private void ListAllBadges()
        {

            Console.Clear();
            Dictionary<int, List<string>> dict = _repo.ViewAllEntries();
            ColumnHeader[] headers = new[]
            {
                new ColumnHeader("Badge ID"),
                new ColumnHeader("DoorAccess", Alignment.Right, Alignment.Right),
            };

            Table viewTable = new Table(headers);
            foreach (KeyValuePair<int, List<string>> keyValuePair in dict)
            {
                string combDoor = string.Join(",", keyValuePair.Value);
                viewTable.AddRow(keyValuePair.Key, combDoor);
            }
            Console.Write(viewTable.ToString());
            Console.ReadLine();


        }


        public void StockUpDict()
        {
            List<string> _id1List = new List<string>();
            _id1List.Add("A7");

            SecurityID id1 = new SecurityID(69, _id1List);

            List<string> _id2List = new List<string>();
            _id2List.Add("A1");
            _id2List.Add("A4");
            _id2List.Add("B1");
            _id2List.Add("B2");
            SecurityID id2 = new SecurityID(70, _id2List);

            List<string> _id3List = new List<string>();
            _id3List.Add("A4");
            _id3List.Add("A5");
            SecurityID id3 = new SecurityID(71, _id3List);

            
            _repo.CreateNewBadge(id1);
            _repo.CreateNewBadge(id2);
            _repo.CreateNewBadge(id3);



        }
    }
}
