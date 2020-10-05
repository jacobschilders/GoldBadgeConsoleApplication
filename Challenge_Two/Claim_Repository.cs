using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Two
{
    public class Claim_Repository
    {
        protected readonly List<Claim> _claimRepo = new List<Claim>();

        public List<Claim> ShowAllClaims()
        {
            return _claimRepo;
        }

        public bool EnterNewClaim(Claim newClaim)
        {
            int startingCount = _claimRepo.Count;
            _claimRepo.Add(newClaim);
            bool wasAdded = (_claimRepo.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //take care of next claim (queue / dequeue)

        public Queue<Claim> QueueNextClaim()
        {
            Queue<Claim> nextClaim = new Queue<Claim>(_claimRepo);
            nextClaim.Dequeue();
            return nextClaim;
        }

    }
}
