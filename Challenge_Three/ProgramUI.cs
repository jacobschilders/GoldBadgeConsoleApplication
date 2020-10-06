using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Three
{
    class ProgramUI
    {
        private readonly Badge_Repository _badgeRepo = new Badge_Repository();
        public void Run()
        {

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
            BadgeDictionary dictionary = dictionary.AddToDictionary();
            
            
            Console.WriteLine("What is the number on the badge:");
            badge.BadgeID = int.Parse(Console.ReadLine());
           

            Console.WriteLine("List a door it needs access to:");
            badge.DoorName = List<string>Console.ReadLine();

            _badgeRepo.AddToDictionary(badge);
        
        }

         

                
    }
}
