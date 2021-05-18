using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityRepo;
using System;
using System.Collections.Generic;

namespace SecurityTests
{
    [TestClass]
    public class SecurityTests
    {
        private Dictionary<int, SecurityID> _dict;
        private SecurityRepository _repo;
        private SecurityID _id;



        [TestInitialize]
        public void Arrange()
        {
            _dict = new Dictionary<int, SecurityID>();
            _repo = new SecurityRepository();
            _id = new SecurityID()
            {
                BadgeID = 69,
                DoorAccess = "A5"
            };
        }



        [TestMethod]
        public void CreateNew()
        {
            bool wasAdded = _repo.AddItemToCollection(_id);

            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void UpdateDoorAccessByBadge()
        {
            _repo.UpdateExistingDoorAccessByBadgeId(69, "A4");

            Assert.AreEqual(_id.DoorAccess, );
        }
        
        
        
        
        
        [TestMethod]
        public void ShowListOfAllKeyValuePairs()
        {
            _repo.AddItemToCollection(_id);
            _repo.ViewAllEntries();
            bool dictHasGirth = _dict.ContainsKey(_id.BadgeID);
            
            Assert.IsTrue(dictHasGirth);
        }









        //[TestMethod]
        //public void UpdateDoorAccessPerID()
        //{

        //}
        //[TestMethod]
        //public void DeleteAllDoorsFromBadge()
        //{

        //}

    }
}
