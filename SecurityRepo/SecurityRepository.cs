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



        private Dictionary<int, List<string>> _idDict = new Dictionary<int, List<string>>();




        public Dictionary<int, List<string>> ViewAllEntries()
        {
            return _idDict;
        }


        public bool DoesKeyExist(int key)
        {

            bool doesExist = _idDict.ContainsKey(key);

            return doesExist;
        }
        public string ValuesByKey(int key)
        {
            foreach (KeyValuePair<int, List<string>> door in _idDict)
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
            foreach (KeyValuePair<int, List<string>> door in _idDict)
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
            int startCount = _idDict.Count();
            _idDict.Add(newOne.BadgeID, newOne.Doors);

            bool wasAdded = (_idDict.Count > startCount);
            return wasAdded;

        }


        public bool AddDoorToExistingBadge(SecurityID newDoors)
        {

            if (_idDict.ContainsKey(newDoors.BadgeID))
            {
                foreach (string s in newDoors.Doors)
                {
                    _idDict[newDoors.BadgeID].Add(s);
                }
                return true;
            }
            return false;
        }

        public bool RemoveDoorFromExistingBadge(SecurityID oldDoors)
        {
            if (_idDict.ContainsKey(oldDoors.BadgeID))
            {
                foreach (string s in oldDoors.Doors)
                {
                    _idDict[oldDoors.BadgeID].Remove(s);
                }
                return true;
            }
            return false;
        }
    }
}

