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
        public string DoorAccess { get; set; }

        public SecurityID() { }
        public SecurityID(int badgeID, string doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
    }

}
