using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


                                //DISCLAIMER: 
                        //If I get to feeling guilty about
                        //pulling too much from a previous
                        //assignment, I will feel compelled
                        //to explain it out. Probably just 
                        //for one or two files. But I want
                        //to make clear that I understand,
                        //where I cant HELP but draw up a
                        //similar method.


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

            if(oldItem != null)
            {
                oldItem.MNum = newItem.MNum;
                oldItem.MName = newItem.MName;
                oldItem.MDesc = newItem.MDesc;
                oldItem.IngList = newItem.IngList;
                oldItem.MPrice = newItem.MPrice;
            }
            return false;
        }
        public bool DeleteMenuItem(string oldItem)
        {
            
            MenuItem itemToDelete = DisplayItemByName(oldItem);

            if(itemToDelete == null)
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
