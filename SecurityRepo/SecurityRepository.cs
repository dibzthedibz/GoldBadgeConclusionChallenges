using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityRepo
{
    public class SecurityRepository
    {
        private Dictionary<int, string> _idDict = new Dictionary<int, string>();



        public Dictionary<int, string> ViewAllEntries()
        {
            return _idDict;
        }
        public bool AddKeyToCollection(int key, string value)
        {
            int startCount = _idDict.Count();
            _idDict.Add(key, value);

            bool wasAdded = (_idDict.Count > startCount) ? true : false;
            if (wasAdded)
            {
                return wasAdded;
            }
            return false;
        }
       

    }
}
