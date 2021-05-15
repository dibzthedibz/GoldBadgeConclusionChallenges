using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsConsole
{
    class ClaimsUI
    {
        public void SeedQ() 
        {
            Claims claim1 = new Claims(1, "Car Accident on 465", 400);
            Claims claim2 = new Claims(2, "House fire in kitchen.", 4000, 2018, 4, 11, 2018, 4, 12);
            Claims claim3 = new Claims(3, "Stolen pancakes.", 400, 2018, 4, 27, 2018, 6, 1);
        }
    }
}
