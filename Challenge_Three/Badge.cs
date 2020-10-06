using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Three
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorName { get; set; }

    public Badge() { }

    public Badge(int id, List<string> doorName)
    {
        BadgeID = id;
        DoorName = doorName;
    }
    }
}
