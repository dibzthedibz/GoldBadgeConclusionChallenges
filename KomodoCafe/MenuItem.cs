using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo

{
    public class MenuItem
    {
        public int MNum { get; set; }
        public string MName { get; set; }
        public string MDesc { get; set; }
        public string IngList { get; set; }
        public float FPrice { get; set; }

        public MenuItem() { }
        public MenuItem(int mNum, string mName, string mDesc, string ingList, float fPrice)
        {
            MNum = mNum;
            MName = mName;
            MDesc = mDesc;
            IngList = ingList;
            FPrice = fPrice;
        }

    }
}
