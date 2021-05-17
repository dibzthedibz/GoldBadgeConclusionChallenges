using SecurityRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityConsole
{
    class SecurityUI
    {
        private Dictionary<int, string> _idDict;
        public void Run()
        {
            StockUpDict();
            Menu();
        }
        public void Menu()
        {

        }
        public void StockUpDict()
        {
            SecurityID id1 = new SecurityID(69, "A7");
            SecurityID id2 = new SecurityID(70, "A1, A4, B1, B2");
            SecurityID id3 = new SecurityID(80, "A4, A5");

            
        }
    }
}
