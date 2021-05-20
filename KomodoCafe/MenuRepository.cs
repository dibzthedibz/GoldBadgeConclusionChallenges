using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo
{
    public class MenuRepository
    {
        private readonly List<MenuItem> _items = new List<MenuItem>();
        public bool AddItemToMenu(MenuItem newItem)
        {           //  I mean, this is just too perfect. :D
            int startCount = _items.Count;
            _items.Add(newItem);
            //If this condition is true, return true. Ternary expression.
            bool menuItemAdded = (_items.Count > startCount) ? true : false;
            return menuItemAdded;
        }
        public List<MenuItem> GetList()
        {
            return _items;
        }
        
        public MenuItem DisplayItemByName(string mName)
        {
            foreach (MenuItem item in _items)
            {
                if (item.MName.ToLower() == mName.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public bool UpdateExistingItem(string oldName, MenuItem newItem)
        {
            MenuItem oldItem = DisplayItemByName(oldName);            

            if (oldItem != null)
            {
                oldItem.MNum = newItem.MNum;
                oldItem.MName = newItem.MName;
                oldItem.MDesc = newItem.MDesc;
                oldItem.IngList = newItem.IngList;
                oldItem.MPrice = newItem.MPrice;

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteMenuItem(string oldItem)
        {

            MenuItem itemToDelete = DisplayItemByName(oldItem);

            if (itemToDelete == null)
            {
                return false;
            }
            else
            {
                _items.Remove(itemToDelete);
                return true;
            }

        }





    }
}
