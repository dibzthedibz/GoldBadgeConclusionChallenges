using ClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClaimsTests
{
    [TestClass]
    public class InsuranceTests
    {
        private Claim _claim1;
        private Claim _claim2;
        private Claim _claim3;
        private ClaimsRepository _repo;
        private Queue<Claim> _currents;

        [TestInitialize]

        public void Arrange()
        {
            _repo = new ClaimsRepository();
            _currents = new Queue<Claim>();
            _claim1 = new Claim(1, "Car accident on 465.", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), ClaimType.Home);
            _claim2 = new Claim(2, "House Fire in Kitchen", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12), ClaimType.Home);
            _claim3 = new Claim(3, "Stolen pancakes.", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 01), ClaimType.Theft);
            _repo.AddNewClaim(_claim1);
            _repo.AddNewClaim(_claim2);
            _repo.AddNewClaim(_claim3);
        }

        [TestMethod]
        public void EnterNewClaim_ReturnIsTrue()
        {
            bool addClaim = _repo.AddNewClaim(_claim1);

            Assert.IsTrue(addClaim);
        }

        [TestMethod]
        public void ViewAllCurrentClaims_ReturnCorrectCollection()
        {
            _repo.SeeAllClaims();

            Assert.IsNotNull(_currents);
        }

        [TestMethod]
        public void SeeNextClaimInQueue_ShouldReturnAreEqual()  //debug stuck here
        {
            Claim peeker = _repo.PeekNextClaim();
            Assert.AreEqual(peeker, _claim1);
        }
        [TestMethod]
        public void DequeueNextClaim_ShouldReturntrue()
        {
            bool toDelete = _repo.DequeueNextClaim();

            Assert.IsTrue(toDelete);
        }


    }
}
