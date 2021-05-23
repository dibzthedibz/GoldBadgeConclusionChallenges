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

        
        [TestMethod]
        public void TotalCostAllOutings_ReturningHasValue()
        {
            Outing _outing = new Outing();
            OutingsRepository _repo = new OutingsRepository();
            _outing.Attendance = 50;
            _outing.CostPerPerson = 60;
            _repo.AddToList(_outing);
            int totalSum = _repo.TotalCostAllOutings();

            bool sumHasGirth = (totalSum > 0);

            Assert.IsTrue(sumHasGirth);
        }

    }
}











//private List<Outing> _list;
//private OutingsRepository _repo1;
//private Outing _outing;
//[TestInitialize]
//public void Arrange()
//{

//    _repo1 = new OutingsRepository();
//    _outing = new Outing();
//    DateTime outDate = new DateTime(2018, 03, 22);

//    _outing.Attendance = 50;
//    _outing.Date = outDate;
//    _outing.CostPerPerson = 60;
//    _outing.Place = "Golf";

//    _list = _repo1.GetList();
//    _list.Add(_outing);

