using System;
using System.Collections.Generic;
using Challenge_Three;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_Three_Tests
{
    [TestClass]
    public class BadgeRepoTests
    {
        [TestMethod]
        public void AddToDictionary_ShouldReturnNewItemAndSave()
        {
            //Arrange
            Dictionary<int, List<string>> BadgeDictionary = new Dictionary<int, List<string>>();
            Badge newBadge = new Badge();

            //Act
            bool wasAdded = BadgeDictionary.AddToDictionary();
        }
    }
}
