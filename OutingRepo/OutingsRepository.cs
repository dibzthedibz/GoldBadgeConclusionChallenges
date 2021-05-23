using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingRepo
{
    public class OutingsRepository
    {
        private readonly List<Outing> OutList = new List<Outing>();

        public List<Outing> GetList()
        {
            return OutList;
        }

        public void BuildTable()
        {
            Console.WindowWidth = 125;

            DataTable Table = new DataTable();
            DataColumn Place = new DataColumn("Place", typeof(string));
            DataColumn Date = new DataColumn("Date Of Event", typeof(DateTime));
            DataColumn Attendance = new DataColumn("Attendance", typeof(int));
            DataColumn CostPerP = new DataColumn("Cost Per Person", typeof(int));
            DataColumn CostPerE = new DataColumn("Cost Per Event", typeof(int));
            Table.Columns.Add(Place);
            Table.Columns.Add(Attendance);
            Table.Columns.Add(Date);
            Table.Columns.Add(CostPerP);
            Table.Columns.Add(CostPerE);

            DataRow topRow;

            foreach (Outing outing in OutList)
            {
                topRow = Table.NewRow();

                topRow["Place"] = outing.Place;
                topRow["Date Of Event"] = outing.Date;
                topRow["Attendance"] = outing.Attendance;
                topRow["Cost Per Person"] = outing.CostPerPerson;
                topRow["Cost Per Event"] = outing.CostPerEvent;
                Table.Rows.Add(topRow);
            }
            //decimal Total = Convert.ToDecimal(Table.Compute("Sum(Cost Per Event)", "Cost Per Event"));

            PrintDataTable(Table);

            Console.WriteLine();
        }
        public static void PrintDataTable(DataTable Table)
        {
            Console.SetCursorPosition(0, 6);

            Console.WriteLine("          =====             =============       ==========      ===============            ==============");

            Console.WriteLine("{0,15}\t{1,25}\t{2,10}\t{3,15}\t{4,25}",
                "Place",
                "Date Of Event",
                "Attendance",
                "Cost Per Person",
                "Cost Per Event"
                );
            Console.WriteLine("          =====             =============       ==========      ===============            ==============");
            Console.WriteLine("                                                                                                         ");
            foreach (DataRow row in Table.Rows)
            {
                Console.WriteLine("{0,15}\t{1,25}\t{2,10}\t{3,15}\t{4,25}",
                   row["Place"],
                   row["Date Of Event"],
                   row["Attendance"],
                   row["Cost Per Person"],
                   row["Cost Per Event"]
                   );
                Console.WriteLine("                                                                                                         ");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                                                                                         ");
            }
            int Total = Table.AsEnumerable().Sum(row => row.Field<int>("Cost Per Event"));
            Console.WriteLine("                                                                              ---------------------------");
            Console.WriteLine("                                                                              Total Cost Per Annum: {0}", Total);
            Console.WriteLine("                                                                              ---------------------------");
            Console.Write("Press Any Key To Continue...                                                                             ");

            Console.ReadLine();
        }
        public bool AddToList(Outing newOne)
        {
            int startCount = OutList.Count();
            OutList.Add(newOne);
            bool wasAdded = (OutList.Count > startCount);

            return wasAdded;
        }
        public int TotalCostAllOutings()
        {
            foreach (Outing outing in OutList)
            {
                int totalSum = outing.CostPerEvent * OutList.Count;

                if (totalSum > 0)
                {
                    return totalSum;
                }
            }
            return OutList.Count;
        }

    }
}

