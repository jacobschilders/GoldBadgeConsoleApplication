using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    //class



    public class MenuItem
    { //properties


        public List<string> Ingredients { get; set; } = new List<string>();
        //change to empty list
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }

        //constructors
        public MenuItem() { }
        public MenuItem(List<string> ingredients, string itemName, int itemNumber, string description)
        {
            List<string> Ingredients = ingredients;
            ItemName = itemName;
            ItemNumber = itemNumber;
            Description = description;

        }
    }



}
