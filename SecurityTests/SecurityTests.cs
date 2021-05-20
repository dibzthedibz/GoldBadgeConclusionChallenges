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


            SecurityID lebowski = new SecurityID();
            SecurityRepository repository = new SecurityRepository();
            lebowski.BadgeID = 24;
            lebowski.Doors.Add("A7");
            bool wasAdded = repository.CreateNewBadge(lebowski);


            Assert.IsTrue(wasAdded);
        }



        [TestInitialize]
        public void Arrange()
        {
            _repo = new SecurityRepository();
            _dude = new SecurityID();
            _dude.BadgeID = 69;
            _dude.Doors.Add("A5");
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



            //SecurityID tina = new SecurityID();
            //SecurityRepository miniRepo = new SecurityRepository();
            //miniRepo.CreateNewBadge(tina);

            //bool wasAdded = miniRepo.AddDoorToExistingBadge(tina);
            //Assert.IsTrue(wasAdded);
        }
        [TestMethod]
        public void ReturnValuesByKey()
        {
            
            _dude.Doors.Add("A7");
            _repo.AddDoorToExistingBadge(_dude);
            bool wasAdded = _repo.GetIDByKey(69);

            Assert.IsTrue(wasAdded);

        }
    }
}
