using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge_Three
{
    class ProgramUI
    {
        protected readonly Badge_Repository _badgeRepo = new Badge_Repository();
        protected readonly Dictionary<int, List<string>> BadgeDictionary = new Dictionary<int, List<string>>();
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
                Console.WriteLine("Enter the number of the option you would like to select: \n" +
                    "1. Add a badge \n" +
                    "2. Edit a badge \n" +
                    "3. List all Badges \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 4 \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

        }

        private void AddBadge()
        {
            Console.Clear();
            Badge badge = new Badge();
            
            
            Console.WriteLine("What is the number on the badge:");
            badge.BadgeID = int.Parse(Console.ReadLine());
            
           

            Console.WriteLine("List a door it needs access to:");
            bool continueAdding = true;
            List<string> doorName = new List<string>();
            while (continueAdding)
            {
                string answer = Console.ReadLine();
                doorName.Add(answer);
                Console.WriteLine("Do you want to add another door?:");
                string anotherAnswer = Console.ReadLine();
                if(anotherAnswer == "yes")
                {
                    Console.WriteLine("List another door it needs access to:");
                    string secondAnswer = Console.ReadLine();
                    doorName.Add(secondAnswer);
                }
                else
                {
                    continueAdding = false;
                }
            }

            _badgeRepo.AddToDictionary(badge);
        
        }

        private void EditBadge()
        {
            Badge badge = new Badge();
            Console.Clear();
            Console.WriteLine("What is the badge number you would like to update?:");
            int answer = int.Parse(Console.ReadLine());
            if (BadgeDictionary.ContainsKey(answer))
            {
                Console.WriteLine($"{BadgeDictionary[answer]} has access to doors {BadgeDictionary.Values}." );
                Console.WriteLine("What would you like to do? \n" +
                    "1. Remove a door \n"+
                    "2. Add a door");
                int input = int.Parse(Console.ReadLine());
                List<string> DoorName = new List<string>();
                if(input == 1)
                {
                    Console.WriteLine("Which door would you like to remove?");
                    string door = Console.ReadLine();
                    badge.DoorName.Contains(door);

                    if (BadgeDictionary.ContainsKey(input) && badge.DoorName.Contains(door))
                    {
                        badge.DoorName.Remove(door); 
                        Console.WriteLine("Door Removed");
                    }
                    else
                    {
                        Console.WriteLine("No access found");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the door you would like access to:");
                    string newDoor = Console.ReadLine();
                    badge.DoorName.Add(newDoor);
                }
               
            }
            else
            {
                Console.WriteLine("Badge ID is not valid");
                Console.ReadKey();
                RunMenu();
            }


        }

        private void ListAllBadges()
        {
            Console.Clear();
            Badge badge = _badgeRepo.ShowAllBadges();
            foreach (Badge item in _badgeRepo)
            {
                Console.WriteLine($"Badge #      DoorAccess \n" +
                    $"{item.BadgeID}      {item.DoorName}");

            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

         

                
    }
}
