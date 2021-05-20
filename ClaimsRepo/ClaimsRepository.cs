using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaimsRepo
{
    public class ClaimsRepository
    {

        private Queue<Claim> _currents = new Queue<Claim>();
        private DataTable claimTable = new DataTable();
        private int Window_Height = 45;
        private int Window_Width = 165;


        public void SetWindowSize()
        {
            Console.BufferHeight =
            Console.BufferHeight = Console.WindowHeight = Window_Height;
            Console.BufferWidth = Console.WindowWidth = Window_Width;
            Console.Title = "Claims Department   Version: 1.00";
            Console.CursorVisible = false;
            //Console.ForegroundColor = ConsoleColor.Red;
        }
        public void BuildTable()
        {

            DataTable claimTable = new DataTable();

            DataColumn id = new DataColumn("Claim ID", typeof(int));
            DataColumn claimType = new DataColumn("Type", typeof(string));
            DataColumn desc = new DataColumn("Description", typeof(string));
            DataColumn amt = new DataColumn("         Amount", typeof(decimal));
            DataColumn dOI = new DataColumn("Date Of Accident", typeof(DateTime));
            DataColumn dOC = new DataColumn("Date Of Claim", typeof(DateTime));
            DataColumn isValid = new DataColumn("Claim Valid", typeof(bool));

            claimTable.Columns.Add(id);
            claimTable.Columns.Add(claimType);
            claimTable.Columns.Add(desc);
            claimTable.Columns.Add(amt);
            claimTable.Columns.Add(dOI);
            claimTable.Columns.Add(dOC);
            claimTable.Columns.Add(isValid);

            DataRow topRow;

            foreach (Claim claim in _currents)
            {
                topRow = claimTable.NewRow();
                topRow["Claim ID"] = claim.ClaimID;
                topRow["Type"] = claim.TypeOfClaim;
                topRow["Description"] = claim.Description;
                topRow["         Amount"] = claim.ClaimAmount;
                topRow["Date Of Accident"] = claim.DateOfIncident;
                topRow["Date Of Claim"] = claim.DateOfClaim;
                topRow["Claim Valid"] = claim.IsValid;
                claimTable.Rows.Add(topRow);
            }

            PrintDataTable(claimTable);
            Console.WriteLine();
        }



        private static void PrintDataTable(DataTable table)
        {
            Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t{3,10}\t{4,25}\t{5,25}\t{6,10}",
               "Claim ID",
               "Claim Type",
               "Description",
               "          Amount",
               "Date of Accident",
               "Date of Claim",
               "Valid Claim"
               );
            Console.WriteLine("                            ");

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("{0,10}\t{1,10}\t{2,10}\t{3,10}\t{4,25}\t{5,25}\t{6,10}",
                    row["Claim ID"],
                    row["Type"],
                    row["Description"],
                    row["         Amount"],
                    row["Date of Accident"],
                    row["Date of Claim"],
                    row["Claim Valid"]
                    );
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please Press Any Key To Continue");

            Console.ReadLine();
            Console.Clear();
        }

        public Queue<Claim> SeeAllClaims()
        {

            foreach (Claim claim in _currents)
            {
                Console.WriteLine(" " + claim.ClaimID + "   " + claim.TypeOfClaim + "      " + claim.Description + "     " + claim.ClaimAmount + "     " + claim.DateOfIncident + "     " + claim.DateOfClaim + "     " + claim.IsValid);
            }
            return null;

        }

        public Claim PeekNextClaim()
        {
            Console.Clear();
            Console.WindowWidth = 205;


            if (_currents.Count == 0)
            {
                Console.WriteLine("Press any Key to Continue...");
            }


            else if (_currents.Count >= 1)
            {
                bool keepItGoing = true;

                while (keepItGoing)
                {
                    if (_currents.Count == 0)
                    {
                        keepItGoing = false;
                    }
                    else
                    {
                        Claim claim = _currents.Peek();
                        Console.WriteLine("Claim ID       Type     Description              Amount     Date of Accident           Date of Claim             Claim is Valid       ");
                        Console.WriteLine("---------      -----    ------------             -------    -----------------          --------------            ---------------");
                        Console.WriteLine(claim.ClaimID + "              " + claim.TypeOfClaim + "      " + claim.Description + "     " + claim.ClaimAmount + "     " + claim.DateOfIncident + "      " + claim.DateOfClaim + "     " + claim.IsValid);

                        Console.WriteLine("                                                   ");
                        Console.WriteLine("     Do you want to remove the next claim in queue and mark it complete?");
                        Console.WriteLine("     --------------------------------------------------------     ");
                        Console.Write("            Please Choose (y/n): ");
                        string input = (Console.ReadLine().ToLower());


                        switch (input)
                        {
                            case "y":
                                Console.WriteLine("Claim Successfully Taken Care Of");
                                DequeueNextClaim();
                                break;
                            case "n":
                                keepItGoing = false;
                                break;
                        }
                        Console.Clear();
                    }
                }
            }
            return null;
        }






        public bool DequeueNextClaim()
        {
            int startCount = _currents.Count;

            _currents.Dequeue();

            bool deleted = (_currents.Count < startCount);

            return deleted;
        }

        public bool AddNewClaim(Claim newClaim)
        {
;
            
            int startingCount = _currents.Count;

            _currents.Enqueue(newClaim);

            bool added = (_currents.Count > startingCount) ? true : false;
            return added;
        }
        public void AddNewColumn(DataColumn newColumn)
        {
            claimTable.Columns.Add(newColumn);
        }



    }
}

