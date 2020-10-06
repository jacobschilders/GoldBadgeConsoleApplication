using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Three
{
    public class Badge_Repository

    {
        protected readonly Badge _badgeRepo = new Badge();
        IDictionary<int, List<string>> BadgeDictionary = new Dictionary<int, List<string>>();

        public IDictionary<int, List<string>> AddToDictionary()
        {
           BadgeDictionary.Add(_badgeRepo.BadgeID, _badgeRepo.DoorName);

            try
            {
                BadgeDictionary.Add(9999, null);
            }
            catch
            {
                Console.WriteLine($"An element with key = {_badgeRepo.BadgeID} already exists.");
            }
            return BadgeDictionary;

        }

        public void AddOrUpdateDoorAccess(int BadgeID, List<string> DoorAccess)
        {
            if (BadgeDictionary.ContainsKey(BadgeID))
            {
                BadgeDictionary[BadgeID] = DoorAccess;
            }
            else
            {
                BadgeDictionary.Add(BadgeID, DoorAccess);
            }
        }

        public void DeleteBadge(int BadgeID, List<string> DoorAccess)
        {
            if (BadgeDictionary.ContainsKey(BadgeID))
            {
                BadgeDictionary.Remove(BadgeID);
            }
              
            else
            {
                Console.WriteLine("This Badge ID does not exist.");
            }

        }

        public Badge ShowAllBadges()
        {
            return _badgeRepo;
        }



        

    }
}
