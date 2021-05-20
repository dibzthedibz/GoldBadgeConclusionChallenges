using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityRepo;
using System;
using System.Collections.Generic;

namespace SecurityTests
{
    [TestClass]
    public class SecurityTests
    {
        private SecurityRepository _repo;
        SecurityID _dude;
        

        [TestMethod]
        public void CreateNewBadgeID()
        {
            List<string> stuff = new List<string>();

            SecurityID dibz = new SecurityID(1, stuff);
            bool wasAdded = _repo.CreateNewBadge(dibz);

            Assert.IsTrue(wasAdded);
        }

        [TestInitialize]
        public void Arrange()
        {
            _repo = new SecurityRepository();
            _dude = new SecurityID();
            _dude.BadgeID = 69;
            _repo.AddDoorToExistingBadge(_dude);
            
            _repo.CreateNewBadge(_dude);
           

        }

       

        [TestMethod]
        public void TestForKey()
        {
            bool badgeExists = _repo.DoesKeyExist(_dude.BadgeID);

            Assert.IsTrue(badgeExists);
        }

        [TestMethod]
        public void AddDoorAccessToBadge()
        {
            List<string> beb = new List<string>();

            _dude.Doors = beb;
            bool doorAdded = _repo.AddDoorToExistingBadge(_dude);

            Assert.IsTrue(doorAdded);
        }
        [TestMethod]
        public void ReturnValuesByKey()
        {            
            bool wasGot = _repo.GetIDByKey(69);

            Assert.IsTrue(wasGot);
        }
    }
}
