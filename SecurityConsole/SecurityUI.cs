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
            Console.Clear();
            Console.Write("Please Enter Badge Number to Alter: ");
            int input = Convert.ToInt32(Console.ReadLine());

            string doors = _repo.ValuesByKey(input);

            if (doors != null)
            {
                Console.Write("Badge Number: {0} has access to door(s): {1}", input, doors);
                Console.Clear();
                Console.WriteLine("What Would You Like To Do?\n" +
                                  "1. Remove Door Access\n" +
                                  "2. Add Door Access\n" +
                                  "3.Exit to Main Menu");
                string input1 = Console.ReadLine().ToLower();
                switch (input1)
                {
                    case "1":
                        RoomRemover(input);
                        break;
                    case "2":
                        RoomAdderToUi(input);
                        break;
                    case "3":
                        Menu();
                        break;
                    default:
                        break;
                }
            }
            else if (doors == null)
            {
                Console.WriteLine("                                                      ");
                Console.WriteLine("Oops, Couldn't Find that Badge! Try Adding it First.\n" +
                                  "                                                      ");
                Console.Write("Press Any Key to Continue to Main Menu.");
                Console.ReadLine();
            }

        }
        public void RoomAdderToUi(int loanerAdd)
        {
            SecurityID newSteve = RoomAdder(loanerAdd);

            bool wasAdded = _repo.AddDoorToExistingBadge(newSteve);
            if (wasAdded)
            {
                Console.WriteLine("Door Access Added Successfully");
            }
            else
            {
                Console.WriteLine("Looks Like Something Went Wrong");
            }
        }
        public SecurityID RoomAdder(int loaner)
        {

            SecurityID Steve = new SecurityID();
            List<string> newDoors = new List<string>();

            Steve.BadgeID = loaner;

            bool coolRunnings = true;

            while (coolRunnings)
            {
                Console.WriteLine("Which room do we need to Add?");
                newDoors.Add(Console.ReadLine());

                Steve.Doors = newDoors;

                Console.WriteLine("Add another room? (y/n)");
                string input = Console.ReadLine();
                bool affirmative = (input == "y");

                if (affirmative == true)
                {

                    coolRunnings = true;
                }
                else
                {

                    coolRunnings = false;
                }

            }

            return Steve;

        }



        public void RoomRemover(int loaner)
        {
            SecurityID Steve1 = new SecurityID();
            List<string> oldDoors = new List<string>();

            Steve1.BadgeID = loaner;

            bool coolRunnings = true;

            while (coolRunnings)
            {
                Console.WriteLine("Which room do we need to Remove?");
                oldDoors.Add(Console.ReadLine());

                Steve1.Doors = oldDoors;

                Console.WriteLine("Remove another room? (y/n)");
                string input = Console.ReadLine();

                bool affirmative = (input == "y");

                if (affirmative == true)
                {

                    coolRunnings = true;
                }
                else
                {

                    coolRunnings = false;
                }

            }

            bool wasAdded = _repo.RemoveDoorFromExistingBadge(Steve1);
            if (wasAdded)
            {
                Console.WriteLine("Door Access Removed");
            }
            else
            {
                Console.WriteLine("Something Went Wrong");
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
