using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeRepo;

namespace CafeTests
{
    [TestClass]
    public class MenuTest
    {       //these fields will allow me to call up new instances of my Repository class and my Item class.
        private MenuItem _items;
        private MenuRepository _repo;
        //Set up my TestInitialize before my my TestMethods, to instantiate(?) my objects and my repository.
        //That way i can keep my code a little cleaner down the road.
        [TestInitialize]
        public void Arrange()
        {
            //Going ahead and instantiating my Repository and Item classes, then
            //calling on the methods I will be using to pop.

            _repo = new MenuRepository();

                                  //Populating a menu item so I can call on it later to test my repo methods.
            _items = new MenuItem(1, "Big Mac", "It's Big, Mac", "Mayo, Pickles, Lettuce", 15.00f);
            _repo.AddItemToMenu(_items);


        }
        [TestMethod]
        public void AddItemToMenu_ShouldReturnIsTrue()
        {

        }
    }
}
