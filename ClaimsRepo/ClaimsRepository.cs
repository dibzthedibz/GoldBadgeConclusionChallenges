using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaimsRepo
{
    public class ClaimsRepository
    {
        
        private Queue<Claim> _currents = new Queue<Claim>();

        public Queue<Claim> SeeAllClaims()
        {
            Queue<Claim>.Enumerator c = _currents.GetEnumerator();

            while(c.MoveNext())
            {
                Console.WriteLine(c.Current);
            }
            return null;

        }
        public Claim PeekNextClaim()
        {
            
                Console.WriteLine(_currents.Peek());
            
            return null;
        }

        public bool DequeueNextClaim()
        {
            int startCount = _currents.Count;

            _currents.Dequeue();

            bool deleted = (_currents.Count < startCount) ? true : false;

            return deleted;


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
