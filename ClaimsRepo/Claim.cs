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
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public bool IsValid
        {
            get
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
        public Claim() { }
        public Claim(int claimID, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, ClaimType typeOfClaim)
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            TypeOfClaim = typeOfClaim;
        }


    }
}
