using ClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ClaimsTests
{
    [TestClass]
    public class InsuranceTests
    {

        private Claim _current;
        private ClaimsRepository _repo;

        [TestInitialize]

        public void Arrange()
        {
                      
            _repo = new ClaimsRepository();
            _repo.AddNewClaim(_current);
        }
        [TestMethod]
        public void ViewAllCurrentClaims()
        {
            
            

        }

        //[TestMethod]
        //public void SeeNextClaimInQueue()
        //{

        //}
        [TestMethod]
        public void EnterNewClaim()
        {
            

            bool addClaim = _repo.AddNewClaim(_current);

            Assert.IsTrue(addClaim);
        }
        
    }
}
