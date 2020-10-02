using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApp
{
    public class MenuRepository
    {
        protected readonly List<MenuItem> _itemDirectory = new List<MenuItem>();

        public bool AddNewMenuItem(MenuItem menuItem)
        {
            int startingCount = _itemDirectory.Count;
            _itemDirectory.Add(menuItem);
            bool wasAdded = (_itemDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<MenuItem> ShowAllItems()
        {
            return _itemDirectory;
        }

        public bool DeleteMenuItem(MenuItem existingItem)
        {
            bool deleteItem = _itemDirectory.Remove(existingItem);
            return deleteItem;
        }
    }
}
