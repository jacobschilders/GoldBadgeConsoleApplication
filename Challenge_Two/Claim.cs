using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Two
{
        public enum ClaimType
        {
            Car,
            Home,
            Theft,
            Life
        }
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
            TimeSpan result = DateOfClaim.Subtract(DateOfIncident);
                if(result.TotalDays >= 31)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Claim() { }
        public Claim(int id, ClaimType claimType, string description, decimal amount, DateTime doi, DateTime doc, bool isValid)
        {
            ClaimID = id;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = amount;
            DateOfIncident = doi;
            DateOfClaim = doc;
            

        }

    }
}
