using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo
{
    public enum ClaimType
    {

        Car,
        Home,
        Theft

    }

    public class Claim
    {
        public int ClaimID { get; set; }
        public string Description { get; set; }
        public int ClaimAmount { get; set; }
    public DateTime DateOfIncident { get; set; }
public DateTime DateOfClaim { get; set; }
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
    }
}
    