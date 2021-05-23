using OutingRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingConsole
{
    public class OutingsUI
    {
        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            FillUpList();
            Menu();
        }
        private OutingsRepository _repo = new OutingsRepository();
        private Dictionary<string, int> _mini;
        private List<Outing> _list;
        private Outing _outing;
        private Outing _outing1;
        private Outing _outing2;
        private Outing _outing3;




        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("                                   Please Select From the Following Menu Options: \n" +
                                  "                                                                                 \n" +
                                  "                                           1. Display a list of All Outings.\n" +
                                  "                                             2. Add an Outing to the List.\n" +
                                  "                                                    3. Exit Program.\n" +
                                  "                                                                     \n" +
                                  "                                             Enter Selection(1-3): ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayAllOutingsWithCosts();
                        break;
                    case "2":
                        AddNewOutingToList();
                        break;
                    case "3":
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void DisplayAllOutingsWithCosts()
        {
            Console.Clear();
            _repo.BuildTable();
        }
        private void AddNewOutingToList()
        {
            Console.Clear();
            Outing outing = new Outing();
            Console.Write("Please Enter Location/Type of Event: ");
            outing.Place = Console.ReadLine();

            Console.Write("How Many Were in Attendance?(I.e. 50): ");
            outing.Attendance = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Date of the Event (DD/MM/YYYY): ");
            outing.Date = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Cost per Attendee: ");
            outing.CostPerPerson = Convert.ToInt32(Console.ReadLine());

            bool wasAdded = _repo.AddToList(outing);
            if (wasAdded)
            {
                Console.WriteLine("Outing Successfully Added");
                Console.WriteLine("Press Any Key To Continue...");
            }
        }
        void FillUpList()
        {
            _list = _repo.GetList();
            DateTime outDate = new DateTime(2018, 03, 22);
            DateTime outDate1 = new DateTime(2018, 06, 21);
            _mini = new Dictionary<string, int>();
            _outing = new Outing();
            _outing1 = new Outing();
            _outing2 = new Outing();
            _outing3 = new Outing();

            _outing.Attendance = 50;
            _outing.Date = outDate;
            _outing.CostPerPerson = 60;
            _outing.Place = "Golf";

            _outing1.Attendance = 50;
            _outing1.Date = outDate1;
            _outing1.CostPerPerson = 45;
            _outing1.Place = "Bowling";

            _outing2.Attendance = 50;
            _outing2.Date = outDate1;
            _outing2.CostPerPerson = 125;
            _outing2.Place = "Amusement Park";

            _outing3.Attendance = 50;
            _outing3.Date = outDate1;
            _outing3.CostPerPerson = 75;
            _outing3.Place = "Concert";

            _list.Add(_outing);
            _list.Add(_outing1);
            _list.Add(_outing2);
            _list.Add(_outing3);
        }


    }
}
