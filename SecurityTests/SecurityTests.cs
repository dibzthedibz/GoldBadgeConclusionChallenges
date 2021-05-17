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
            bool wasAdded = _repo.AddKeyToCollection(_id);

            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void UpdateDoorAccessByBadge()
        {

        }
        
        
        
        
        
        [TestMethod]
        public void ShowListOfAllKeyValuePairs()
        {
            _repo.AddKeyToCollection(_id);
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
