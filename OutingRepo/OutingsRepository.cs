using System;
using System.Collections.Generic;
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
        public Dictionary<string, int> GetMiniDict()
        {
            Outing duder = new Outing();
            Dictionary<string, int> miniDict = duder.Place;
            miniDict.Add("Golf", 3000);
            miniDict.Add("Bowling", 2000);
            miniDict.Add("Amusement Park", 9000);
            miniDict.Add("Concert", 8000);
            return miniDict;

        }

        public bool AddToList(Outing newOne)
        {
            int startCount = OutList.Count();
            OutList.Add(newOne);
            bool wasAdded = (OutList.Count > startCount);

            return wasAdded;
        }
        public int TotalCostAllOutings
        {
            get
            {
                foreach (Outing outing in OutList)
                {
                    int totalSum = outing.CostPerEvent * OutList.Count;
                    if(totalSum > 0)
                    {
                        return totalSum;
                    }                    
                }
                return OutList.Count;
            }
        }
    }
}
