using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaimsRepo
{
    public class ClaimsRepository
    {
        private readonly Queue<Current> _currents = new Queue<Current>();

        public Queue<Current> SeeAllClaims()
        {
            IEnumerator<Current> enumerator = _currents.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                
            };
            return null;
            

        }

        public bool AddNewClaim(Current newClaim)
        {
            int startingCount = _currents.Count;

            _currents.Enqueue(newClaim);

            bool claimAdded = (_currents.Count > startingCount) ? true : false;
            return claimAdded;


        }
       
        


    }
}
