using System;
using System.Collections;
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
    }
}
