using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo
{
    interface IClaim
    {        
        int ClaimID { get; set; }
        string Description { get; set; }
        int ClaimAmount { get; set; }
        DateTime DateOfIncident { get; set; }
        DateTime DateOfClaim { get; set; }
        
    }
}
