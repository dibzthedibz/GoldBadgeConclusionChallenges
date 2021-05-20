using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityRepo
{
    public class SecurityRepository
    {



        private Dictionary<int, List<string>> IdDict = new Dictionary<int, List<string>>();




        public Dictionary<int, List<string>> ViewAllEntries()
        {
            return IdDict;
        }


        public bool DoesKeyExist(int key)
        {

            bool doesExist = IdDict.ContainsKey(key);

            return doesExist;
        }
        public string ValuesByKey(int key)
        {
            foreach (KeyValuePair<int, List<string>> door in IdDict)
            {
                if (door.Key == key)
                {
                    string combDoor = string.Join(",", door.Value);
                    return combDoor;
                }
            }
            return null;
        }
        public bool GetIDByKey(int key)
        {
            foreach (KeyValuePair<int, List<string>> door in IdDict)
            {
                if (door.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CreateNewBadge(SecurityID newOne)
        {
            int startCount = IdDict.Count();
            IdDict.Add(newOne.BadgeID, newOne.Doors);

            bool wasAdded = (IdDict.Count > startCount);
            return wasAdded;

        }


        public bool AddDoorToExistingBadge(SecurityID newDoors)
        {

            if (IdDict.ContainsKey(newDoors.BadgeID))
            {
                foreach (string s in newDoors.Doors)
                {
                    IdDict[newDoors.BadgeID].Add(s);
                }
                return true;
            }
            return false;
        }

        public bool RemoveDoorFromExistingBadge(SecurityID oldDoors)
        {
            if (IdDict.ContainsKey(oldDoors.BadgeID))
            {
                foreach (string s in oldDoors.Doors)
                {
                    IdDict[oldDoors.BadgeID].Remove(s);
                }
                return true;
            }
            return false;
        }
    }
}

