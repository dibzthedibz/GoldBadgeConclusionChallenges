using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo
{
    public class Claim1 : Current
    {
        public int ClaimID => 1;
        public string Description => "Car Accident On 465";
        public int ClaimAmount => 400;
        public DateTime DateOfIncident => new DateTime(2018, 4, 25);
        public DateTime DateOfClaim => new DateTime(2018, 4, 27);
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
    public class Claim2 : Current
    {
        public int ClaimID => 2;
        public string Description => "House Fire in Kitchen";
        public int ClaimAmount => 4000;
        public DateTime DateOfIncident => new DateTime(2018, 4, 11);
        public DateTime DateOfClaim => new DateTime(2018, 4, 12);
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
    public class Claim3 : Current
    {
        public int ClaimID => 3;
        public string Description => "Stolen Pancakes";
        public int ClaimAmount => 4;
        public DateTime DateOfIncident => new DateTime(2018, 4, 27);
        public DateTime DateOfClaim => new DateTime(2018, 6, 01);
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
