using ClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ClaimsTests
{
    [TestClass]
    public class InsuranceTests
    {

        private Current _current;
        private ClaimsRepository _repo;

        [TestInitialize]

        public void Arrange()
        {
            _current = new Claim1();            
            _repo = new ClaimsRepository();
            _repo.AddNewClaim(_current);
        }
        [TestMethod]
        public void ViewAllCurrentClaims()
        {
            _current = new Claim1();
            _repo = new ClaimsRepository();
            _repo.AddNewClaim(_current);
            Queue<Current> claimDir = _repo.SeeAllClaims();
            bool dirHasGirth = claimDir.Contains(_current);

            Assert.IsTrue(dirHasGirth);
            

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
