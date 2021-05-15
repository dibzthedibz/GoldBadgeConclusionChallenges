using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo.Claims
{
    public class Claim1 : IClaim
    {
        public int ClaimID => 1;
        public string Description => ;
        public int ClaimAmount => ;
        public DateTime DateOfIncident => ;
        public DateTime DateOfClaim => ;
        bool IsValid()
        {
            if (DateOfClaim.Month > (DateOfIncident.Month + 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        enum ClaimType
        {

            Car,
            Home,
            Theft

        }
    }
    public class Claim2 : IClaim
    {
        public int ClaimID => ;
        public string Description => ;
        public int ClaimAmount => ;
        public DateTime DateOfIncident => ;
        public DateTime DateOfClaim => ;
        bool IsValid()
        {
            if (DateOfClaim.Month > (DateOfIncident.Month + 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        enum ClaimType
        {

            Car,
            Home,
            Theft

        }
    }
    public class Claim3 : IClaim
    {
        public int ClaimID => ;
        public string Description => ;
        public int ClaimAmount => ;
        public DateTime DateOfIncident => ;
        public DateTime DateOfClaim => ;
        bool IsValid()
        {
            if (DateOfClaim.Month > (DateOfIncident.Month + 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        enum ClaimType
        {

            Car,
            Home,
            Theft

        }
    }
}
