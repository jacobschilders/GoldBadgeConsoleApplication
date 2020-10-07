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
            // I realy struggled with the concept of the dictionary and how to implement it into my code.
            //I would like to work on making Challenge 3 correct after I learn more about dictionaries.