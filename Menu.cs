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


        public List<string> Ingrediants { get; set; } = new List<string>();
       //change to empty list
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        
    //constructors
    public MenuItem() { }
    public MenuItem(List<string> ingrediants, string itemName, int itemNumber, string description)
    {
        List<string> Ingrediants = ingrediants;
        ItemName = itemName;
        ItemNumber = itemNumber;
        Description = description;

    }
    }



}
