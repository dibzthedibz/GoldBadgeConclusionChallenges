using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityRepo;
using System;
using System.Collections.Generic;

namespace SecurityTests
{
    [TestClass]
    public class SecurityTests
    {
        private Dictionary<int, string> _dict;
        private SecurityRepository _repo;
        private SecurityID _id;
        [TestInitialize]
        public void Arrange()
        {
            _id = new SecurityID(69, "A4");
            _repo = new SecurityRepository();
            _dict = new Dictionary<int, string>();
            

           
        }
        [TestMethod]
        public void CreateNew()
        {
            bool addInput = _repo.AddKeyToCollection(69, "A4");
            Assert.IsTrue(addInput);
        }
        //[TestMethod]
        //public void UpdateDoorAccessPerID()
        //{

        //}
        //[TestMethod]
        //public void DeleteAllDoorsFromBadge()
        //{

        //}
        [TestMethod]
        public void ShowListOfAllKeyValuePairs()
        {   
            _repo.ViewAllEntries();
            bool dictHasGirth = _dict.ContainsKey(69);
            

            
        }
    }
}
