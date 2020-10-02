using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApp
{
    class Program 
    {
        static void Main(string[] args)
        {
        }
        private readonly MenuRepository _menuRepo = new MenuRepository();

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Please enter the option number of your choice: \n" +
                    "1. Create New Menu Item \n" +
                    "2. Delete Existing Menu Item \n" +
                    "3. Display all Menu Items \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddNewMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ShowAllItems();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose one of the available options. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void AddNewMenuItem()
        {
            MenuItem item = new MenuItem();

            //Ingrediants string[]
            Console.WriteLine("Please enter the ingrediants for the new item");
            item.Ingrediants = Console.ReadLine(); //add a loop to keep choosing options
            //Item Name string
            Console.WriteLine("Please enter the name of the new item");
            item.ItemName = Console.ReadLine();
            //Item Number int
            Console.WriteLine("Please enter the item number of the new item");
            item.ItemNumber = int.Parse(Console.ReadLine());
            //Description string
            Console.WriteLine("Please enter the description of your new item");
            item.Description = Console.ReadLine();
        }
    }
}
