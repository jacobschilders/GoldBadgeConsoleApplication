using System;
using System.Collections;
using System.Collections.Generic;
using Challenge_Two;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_Two_Tests
{
    [TestClass]
    public class Claim_Repo_Tests
    {
        [TestMethod]
        public void EnterNewClaim_ShouldReturnTrue()
        {
            //Arrange
            Claim claims = new Claim();
            Claim_Repository claim_Repo = new Claim_Repository();

            //Act
            bool wasAdded = claim_Repo.EnterNewClaim(claims);

            //Assert
            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void ShowNextQueue_ShouldReturnTheNextClaim()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);

            //Act
            queue.Peek();

            //Assert
            Assert.AreEqual(queue.Peek(), 5);
        }

        [TestMethod]
        public void ShowAllClaims_ShouldReturnTrue()
        {
            //Arrange
            Claim claim = new Claim();
            Claim_Repository claim_Repository = new Claim_Repository();
            claim_Repository.EnterNewClaim(claim);

            //Act
            Queue<Claim> claims = claim_Repository.ShowAllClaims();

            //Assert
            bool repoHasClaims = claims.Contains(claim);
            Assert.IsTrue(repoHasClaims);
        }
    }
}
