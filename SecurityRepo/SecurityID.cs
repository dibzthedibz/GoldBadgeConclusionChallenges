using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityRepo
{
    public class SecurityID
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }

        public SecurityID() { }
        public SecurityID(int badgeID, List<string> doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
        //public KeyValuePair<int, string> dictPair = new KeyValuePair<int, string>();
    }

}
