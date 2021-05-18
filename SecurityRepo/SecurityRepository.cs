using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityRepo
{
    public class SecurityRepository
    {
        private Dictionary<int, List<string>> _idDict = new Dictionary<int, List<string>>();



        public Dictionary<int, List<string>> ViewAllEntries()
        {
            return _idDict;
        }

        public bool AddItemToCollection(SecurityID newID)
        {
            int startCount = _idDict.Count();

            _idDict.Add(newID.BadgeID, newID.DoorAccess);

            bool wasAdded = _idDict.Count > startCount;
            return wasAdded;
        }
        //public SecurityID GetByBadgeId(int originalID)
        //{
        //    foreach (KeyValuePair<int, SecurityID> oldId in _idDict)
        //    {
        //        if (oldId.Key == originalID)
        //        {
        //            return oldId.Value;
        //        }
        //    }
        //    return null;
        //}
        //public bool UpdateExistingDoorAccessByBadgeId(int originalBadge, newDetails);
        //{
        //    List<string> doorAcc = _idDict[originalBadge];
        //    doorAcc.Add(newDetails);

        //    if (oldDetails != null)
        //    {
        //        //oldDetails.BadgeID = old
        //        oldDetails.DoorAccess = newDetails.DoorAccess;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
