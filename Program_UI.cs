using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApp
{
    public class Program_UI
    {
        private readonly MenuRepository _menuRepo = new MenuRepository();
        protected readonly List<MenuItem> _itemDirectory = new List<MenuItem>();

        public void Run()
        {
            RunMenu();
        }

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

            //Ingrediants List<string>

            bool continueAdding = true;
            List<string> Ingredients = new List<string>();
            while (continueAdding)
            {
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Please enter an ingrediant for the new item");
                    string ingredientanswer = Console.ReadLine();
                    item.Ingredients.Add(ingredientanswer);

                }
                else
                {
                    continueAdding = false;
                }
            }
            //add a loop to keep choosing options
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
        private void DeleteMenuItem()
        {
            Console.WriteLine("Please enter the number of the item you wish to delete...");
            List<MenuItem> menuItem = _menuRepo.ShowAllItems();
            int count = 0;
            foreach (var item in menuItem)
            {
                count++;
                Console.WriteLine($"{count}. {item}");
            }

            int targetItem = int.Parse(Console.ReadLine());
            int correctItem = targetItem - 1;
            if (correctItem >= 0 && correctItem < menuItem.Count)
            {
                MenuItem desiredItem = menuItem[correctItem];
                if (_itemDirectory.Remove(desiredItem))
                {
                    Console.WriteLine($"{desiredItem.ItemName} removed successfully.");
                }
                else
                {
                    Console.WriteLine("I cannot do that");
                }
            }
            else
            {
                Console.WriteLine("Invalid Option.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();





        }

        public void ShowAllItems()
        {
            Console.Clear();
            List<MenuItem> menuItems = _menuRepo.ShowAllItems();
            foreach (MenuItem item in menuItems)
            {
                Console.WriteLine($"{item.ItemName} \n" +
                    $"{item.ItemNumber} \n" +
                    $"{item.Description} \n" +
                    $"{item.Ingredients} \n" +
                    $"-------------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
