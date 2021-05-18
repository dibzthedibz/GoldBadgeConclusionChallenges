using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeRepo;
using System.Collections.Generic;

namespace CafeTests
{
    [TestClass]
    public class MenuTest
    {

        private MenuItem _items;
        private MenuRepository _repo;
        private List<MenuItem> _menu;

        [TestInitialize]
        public void Arrange()
        {
            _menu = new List<MenuItem>();
            _repo = new MenuRepository();
            _items = new MenuItem(1, "BigMac", "Just A Big Mac", "Pickles, Lettuce, Cheese", 4.50m);
            _repo.AddItemToMenu(_items);


        }

        [TestMethod]
        public void AddItemToMenu_ShouldReturnIsTrue()
        {


            MenuItem _items = new MenuItem(1, "BigMac", "Just A Big Mac", "Pickles, Lettuce, Cheese", 4.50m);

            bool addItem = _repo.AddItemToMenu(_items);

            Assert.IsTrue(addItem);

        }

        [TestMethod]
        public void UpdateExistingEntry()

        {


            _repo.UpdateExistingItem("BigMac", new MenuItem(2, "BiggerMac", "Bigger than the Mac", "Lettuce, Pickles, Tomatoes", 5.50m));


            Assert.AreEqual(_items.MName, "BiggerMac");
        }

        [TestMethod]
        public void DeleteThing()
        {
            bool wasDeleted = _repo.DeleteMenuItem("BigMac");

            Assert.IsTrue(wasDeleted);

        }

        [TestMethod]
        public void GetFullList()
        {
            _repo.GetList();
        }



    }
}
