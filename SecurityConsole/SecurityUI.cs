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
        
        private SecurityRepository _repo = new SecurityRepository();
        public void Run()
        {
            StockUpDict();
            Menu();
        }
        public void Menu()
        {
            //string selection = Console.ReadLine();
            //switch (selection)
            //{
            //    case "1":
            //        SeeAllClaims();
            //        break;
            //    case "2":
            //        TakeCareOfNextClaim();
            //        break;
            //    case "3":
            //        EnterNewClaim();
            //        break;
            //    case "4":
            //        keepRunning = false;
            //        break;
            //    default:
            //        break;
            //}
        }



        public void StockUpDict()
        {
            SecurityID id1 = new SecurityID()
            {
                BadgeID = 69,
                DoorAccess = "A4"
            };
            SecurityID id2 = new SecurityID()
            {
                BadgeID = 69,
                DoorAccess = "A4"
            };
            SecurityID id3 = new SecurityID()
            {
                BadgeID = 69,
                DoorAccess = "A4"
            };

            _repo.AddKeyToCollection(id1);
            _repo.AddKeyToCollection(id2);
            _repo.AddKeyToCollection(id3);

        }
    }
}
