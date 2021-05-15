using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeRepo;
using System.Collections.Generic;

namespace CafeTests
{
    [TestClass]
    public class MenuTest
    {       //these fields will allow me to call up new instances of my Repository class and my Item class.

        private MenuItem _items;
        private MenuRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _items = new MenuItem(1, "BigMac", "Just A Big Mac", "Pickles, Lettuce, Cheese", 4.50f);
            _repo.AddItemToMenu(_items);


        }

        [TestMethod]
        public void AddItemToMenu_ShouldReturnIsTrue()
        {


            MenuItem _items = new MenuItem(1, "BigMac", "Just A Big Mac", "Pickles, Lettuce, Cheese", 4.50f);

            bool addItem = _repo.AddItemToMenu(_items);

            Assert.IsTrue(addItem);

        }

        [TestMethod]
        public void UpdateExistingEntry()

        {
            _repo.UpdateExistingItem("BigMac", new MenuItem(2, "BiggerMac", "Bigger than the Mac", "Lettuce, Pickles, Tomatoes", 5.50f));

            Assert.AreEqual(_items.MName, "BiggerMac");
        }

        [TestMethod]
        public void DeleteThing()
        {
            bool wasDeleted = _repo.DeleteMenuItem("BiggerMac");

            Assert.IsTrue(wasDeleted);

        }

        [TestMethod]
        public void GetFullList()
        {


            _repo.GetList();


        }



    }
}
