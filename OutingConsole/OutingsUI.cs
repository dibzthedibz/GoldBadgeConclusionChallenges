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
        //public void Run()
        //{
        //    FillUpList();
        //    DisplayAllOutingsWithCosts();            
        //}
        private OutingsRepository _repo = new OutingsRepository();
        private Dictionary<string, int> _mini;
        private List<Outing> _list;
        private Outing _outing;
        private Outing _outing1;
        private Outing _outing2;
        private Outing _outing3;
        



        //public void Menu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Please Select From the Following Menu Options: \n" +
        //                      "1. Display a list of All Outings.\n" +
        //                      "2. Add an Outing to the List.\n" +
        //                      "3. See Cost of All Outings Per Annum.\n" +
        //                      "4. Find Cost of Outing by Type of Outing.\n" +
        //                      "5. Exit Program.");
        //    string input = Console.ReadLine();
        //    switch (input)
        //    {
        //        case "1":
        //            break;
        //        case "2":
        //            break;
        //        case "3":
        //            break;
        //        case "4":
        //            break;
        //        case "5":
        //            break;
        //        default:
        //            break;
        //    }

        //}
        public void DisplayAllOutingsWithCosts()
        {
            _repo.BuildTable();
            Console.ReadLine();
        }
        public void FillUpList()
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
