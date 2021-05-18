using CafeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole
{
    public class CafeUI
    {
        private MenuRepository _repo = new MenuRepository();


        public void Run()
        {
            SeedMenu();
            MainMenu();
        }


        public void MainMenu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("Select From The Menu Options: \n" +
                    "1. View All Menu Items\n" +
                    "2. Create New Menu Item\n" +
                    "3. Update Existing Menu Item\n" +
                    "4. Delete Existing Menu Item\n" +
                    "5. Exit Application");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        ViewList();
                        break;
                    case "2":
                    case "two":
                        CreateItem();
                        break;
                    case "3":
                    case "three":
                        UpdateItem();
                        break;
                    case "4":
                    case "four":
                        DeleteItem();
                        break;
                    case "5":
                    case "five"://Exit();
                        keeprunning = false;
                        break;
                    //Exit
                    default:
                        Console.WriteLine("Please enter a valid number choice.");
                        break;
                }
                Console.WriteLine("Please Press Any Key To Continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void ViewList()
        {
            Console.Clear();
            List<MenuItem> allItems = _repo.GetList();
            foreach (MenuItem item in allItems)
            {
                //Try to list in order everything even after change. This is MVP.
                Console.WriteLine($"{item.MNum}. {item.MName}\n" +
                    $"What it is: {item.MDesc}\n" +
                    $"Price: ${item.MPrice}\n");

            }
        }
        private void CreateItem()
        {
            Console.Clear();
            MenuItem newItem = new MenuItem();

            Console.WriteLine("Please enter the name of the new item to be added:");
            newItem.MName = Console.ReadLine();

            Console.WriteLine("What Menu Number Would you Like This New Item to be?");
            newItem.MNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Description for the New Item: ");
            newItem.MDesc = Console.ReadLine();

            Console.WriteLine("Please Enter the Ingredient List for the New Item: ");
            newItem.IngList = Console.ReadLine();

            Console.WriteLine("Please Enter the Price of the New Item: ");
            newItem.MPrice = Convert.ToDecimal(Console.ReadLine());

            bool ItemAdded = _repo.AddItemToMenu(newItem);
            if (ItemAdded)
            {
                Console.WriteLine("Item Added Successfully");
            }
            else
            {
                Console.WriteLine("Something Went Wrong! Try Again");
            }
        }
        private void UpdateItem()
        {
            Console.Clear();
            ViewList();
            Console.WriteLine("Please Enter the name of the item you would like to update: ");
            string oldItem = Console.ReadLine();

            MenuItem updatedItem = new MenuItem();

            Console.WriteLine("Please enter new the name of the item to be added:");
            updatedItem.MName = Console.ReadLine();

            Console.WriteLine("What Menu Number Would you Like This Item to be?");
            updatedItem.MNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the New Description for the Item: ");
            updatedItem.MDesc = Console.ReadLine();

            Console.WriteLine("Please Enter the New Ingredient List for the Item: ");
            updatedItem.IngList = Console.ReadLine();

            Console.WriteLine("Please Enter the New Price of the Item: ");
            updatedItem.MPrice = Convert.ToDecimal(Console.ReadLine());



            bool ItemAdded = _repo.UpdateExistingItem(oldItem, updatedItem);
            if (ItemAdded)
            {
                Console.WriteLine("Item Added Successfully");
            }
            else
            {
                Console.WriteLine("Something Went Wrong! Try Again");
            }
        }
        private void DeleteItem()
        {
            Console.Clear();
            ViewList();

            Console.WriteLine("Please Enter Name Of Item You Would Like to Delete: ");
            bool deleted = _repo.DeleteMenuItem(Console.ReadLine());
            if (deleted)
            {
                Console.WriteLine("You Deleted the Item Successfully!");
            }
            else
            {
                Console.WriteLine("Well, That Didnt Work...Try Again!");
            }


        }

        private void SeedMenu()
        {
            MenuItem dirty = new MenuItem(1, "Big Mac", "Its big, Mac.", "Pickles, Lettuce, Tomato, Sodium", 5.00m);
            MenuItem clean = new MenuItem(2, "Tuna Delight", "We're gonna need a bigger boat", "Tuna, Mayonnaise, Sodium", 3.50m);
            MenuItem diablo = new MenuItem(3, "Toilet Fire", "Make sure to turn your smoke alarms off when you hit the head!", "Jalapeños, Sausage, Sodium", 7.50m);

            _repo.AddItemToMenu(dirty);
            _repo.AddItemToMenu(clean);
            _repo.AddItemToMenu(diablo);
        }

    }
}


