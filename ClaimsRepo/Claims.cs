using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo
{
    public class Claims
    {
        public enum ClaimType 
        {
            
            Car, 
            Home, 
            Theft 
        
        }
        public int ClaimID { get; set; }
        public string Description { get; set; }
        public int ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid() 
        { 
            if(DateOfClaim.Month > (DateOfIncident.Month + 1 ))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Claims() { }
        public Claims(int claimID, string description, int claimAmount, DateTime dateOfIncident, DateTime dateOfClaim) 
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }

        public DateTime _incident1 = new DateTime(2018, 4, 25);

    }
}
