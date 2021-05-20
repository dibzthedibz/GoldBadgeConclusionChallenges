using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutingRepo;
using System;
using System.Collections.Generic;

namespace OutingTests
{
    [TestClass]
    public class OutingTest
    {

        [TestMethod]
        public void AddOutingToList_ShouldReturnIsTrue()
        {
            Outing outing = new Outing();
            OutingsRepository _repo = new OutingsRepository();

            bool addThing = _repo.AddToList(outing);

            Assert.IsTrue(addThing);
        }
        private OutingsRepository _repo1;
        private Outing _outing;
        Dictionary<string, int> _miniDict;
        [TestInitialize]
        public void Arrange()
        {
            _repo1 = new OutingsRepository();
            _outing = new Outing();
            _miniDict = _repo1.GetMiniDict();
        }
        [TestMethod]
        public Dictionary<string, int> AddTypetoDict()
        {
           

            
            
        }
        [TestMethod]
        public void TotalCostAllOutings_ShouldReturnOutingCost()
        {

        }
    }
}
