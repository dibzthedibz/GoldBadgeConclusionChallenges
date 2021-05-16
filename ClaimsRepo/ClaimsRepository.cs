using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaimsRepo
{
    public class ClaimsRepository
    {
        private readonly Queue<Claim> _currents = new Queue<Claim>();

        public Queue<Claim> SeeAllClaims()
        {
            IEnumerator<Claim> enumerator = _currents.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                
            };
            return null;
            

        }

        public bool AddNewClaim(Claim newClaim)
        {
            int startingCount = _currents.Count;

            _currents.Enqueue(newClaim);

            bool claimAdded = (_currents.Count > startingCount) ? true : false;
            return claimAdded;


        }
       
        


    }
}
