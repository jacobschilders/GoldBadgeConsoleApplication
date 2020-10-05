using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Two
{
    class ProgramUI
    {
        private readonly Claim_Repository claim_Repository = new Claim_Repository();

        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you would liek to select: \n" +
                    "1. Show All Claims \n" +
                    "2. Enter a New Claim \n" +
                    "3. Take Care of Next Claim \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        EnterNewClaim();
                        break;
                    case "3":
                        QueueNextClaim();
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

        private void ShowAllClaims()
        {
            Console.Clear();
            PrintLine();
            PrintRow("Claim ID", "Claim Type", "Description", "Claim Amount", "Date of Incident", "Date of Claim", "Is Valid?");
            PrintLine();
            

            List<Claim> listOfClaims = claim_Repository.ShowAllClaims();
            foreach(Claim claim in listOfClaims)
            {
                Console.WriteLine("{0}",claim.ClaimID, claim.ClaimType, claim.Description, claim.ClaimAmount, claim.DateOfIncident, claim.DateOfClaim, claim.IsValid);
            }
            PrintLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void EnterNewClaim()
        {
            Claim item = new Claim();
            Console.WriteLine("Please enter the ID number of the new claim");
            item.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please select the claim type: \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Theft \n" +
                "4. Life");
            string typeResponse = Console.ReadLine();
            int reponseID = int.Parse(typeResponse);
            item.ClaimType = (ClaimType)reponseID;

            Console.WriteLine("Please enter a breif description of the claim");
            item.Description = Console.ReadLine();

            Console.WriteLine("Please enter the claim amount");
            item.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of the incident YYYY,MM,DD");
            item.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of the claim YYYY,MM,DD");
            item.DateOfClaim = DateTime.Parse(Console.ReadLine());


            claim_Repository.EnterNewClaim(item);
            
        }

        private void QueueNextClaim()
        {
            Queue<Claim> nextClaim = new Queue<Claim>();
            foreach(Object obj in nextClaim)
            {
                Console.WriteLine("Claim ID:", nextClaim.Peek());
                Console.WriteLine("Claim Type:", nextClaim.Peek());
                Console.WriteLine("Description:", nextClaim.Peek());
                Console.WriteLine("Amount:", nextClaim.Peek());
                Console.WriteLine("DateOfAccident:", nextClaim.Peek());
                Console.WriteLine("DateOfClaim:", nextClaim.Peek());
                Console.WriteLine("Is Valid:", nextClaim.Peek());
            }
            Console.WriteLine("Do you want to deal with this claim now(y/n)?");
            char response = char.Parse(Console.ReadLine());
            if(response != 'n' && response == 'y')
            {
                nextClaim.Dequeue();
            }
            else
            {
                Console.Clear();
                RunMenu();
            }
        }

           
           
            
            
                    


        private void SeedContent()
        {
            var claimOne = new Claim(1, ClaimType.Car, "This Car was totaled on I-65", 20000.80m, new DateTime(2019,11,20), new DateTime(2019,12,02), true);
            var claimTwo = new Claim(2, ClaimType.Home, "Wind damage to the roof", 1800.50m, new DateTime(2020, 3, 10), new DateTime(2020, 3, 20), true);
            var claimThree = new Claim(3, ClaimType.Life, "Husband fell from ladder - deceased", 100000.00m, new DateTime(2020, 5, 10), new DateTime(2020, 6, 8), true);

            claim_Repository.EnterNewClaim(claimOne);
            claim_Repository.EnterNewClaim(claimTwo);
            claim_Repository.EnterNewClaim(claimThree);
        }
        static int tableWidth = 100;

        private void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        private void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCenter(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        private string AlignCenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
