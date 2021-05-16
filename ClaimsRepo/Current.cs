using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo
{
    public class Current
    {        
        int ClaimID { get; }
        string Description { get; }
        int ClaimAmount { get;  }
        DateTime DateOfIncident { get; }
        DateTime DateOfClaim { get; }
        
    }
}
