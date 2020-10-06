using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Two
{
    public class Claim_Repository
    {
        protected readonly Queue<Claim> _claimRepo = new Queue<Claim>();

        public Queue<Claim> ShowAllClaims()
        {
            return _claimRepo;
        }

        public bool EnterNewClaim(Claim newClaim)
        {
            int startingCount = _claimRepo.Count;
            _claimRepo.Enqueue(newClaim);
            bool wasAdded = (_claimRepo.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //take care of next claim (queue / dequeue)

        public Claim ShowNextQueue()
        {
            _claimRepo.Peek();
            Claim oneClaim = _claimRepo.Peek();
            return oneClaim;
        }

        public void DequeueClaim()
        {
            _claimRepo.Dequeue();
        }
            




    }
}
