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
        //public List<string> DoorAccess { get; set; }
        public List<string> Doors { get; set; }

        public SecurityID() { }
        public SecurityID(int badgeID, List<string> doors)
        {
            BadgeID = badgeID;
            Doors = doors;
        }

    }

}
