using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityRepo
{
    public class SecurityRepository
    {
        private Dictionary<int, SecurityID> _idDict = new Dictionary<int, SecurityID>();



        public Dictionary<int, SecurityID> ViewAllEntries()
        {
            return _idDict;
        }

        public bool AddKeyToCollection(SecurityID newID)
        {
            int startCount = _idDict.Count();

            _idDict.Add(newID.BadgeID, newID);

            bool wasAdded = _idDict.Count > startCount;
            return wasAdded;
        }

        public Dictionary<int, SecurityID> ShowFullList()
        {
            return _idDict;
        }


    }
}
