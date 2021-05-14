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
                                    //If this condition is true, return true. Ternary expression.
            bool menuItemAdded = (_items.Count > startCount) ? true : false;
            return menuItemAdded;
        }
        public void DisplayAllItemsByName() 
        { 
        
        }
        public void DeleteMenuItem() 
        { 
        
        }


    }
}
