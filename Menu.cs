using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApp
{
    //class
    

    
    public class MenuItem
    { //properties
        public string[] Ingrediants = { "tomato", "onion", "cheese", "bacon", "lettuce", "pickles", "mustard", "ketchup" };
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        
    //constructors
    public MenuItem() { }
    public MenuItem(string[] ingrediants, string itemName, int itemNumber, string description)
    {
        Ingrediants = ingrediants;
        ItemName = itemName;
        ItemNumber = itemNumber;
        Description = description;

    }
    }



}
