using System;
using System.Collections.Generic;
using Challenge1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_One_Repo_Tests
{
    [TestClass]
    public class Menu_Repo_Tests
    {
        [TestMethod]
        public void AddNewMenuItem_ShouldGetCorrectBoolean()
        {
            //Arrange
            MenuItem menuItem = new MenuItem();
            MenuRepository repository = new MenuRepository();

            //ACT
            bool wasAdded = repository.AddNewMenuItem(menuItem);

            //Assert
            Assert.IsTrue(wasAdded);
        }

        [TestMethod]

        public void ShowAllItems_ShouldDisplayAllItemsInDirectory()
        {
            //Arrange
            MenuItem menuItem = new MenuItem();
            MenuRepository repo = new MenuRepository();
            repo.AddNewMenuItem(menuItem);

            //Act
            List<MenuItem> allItems = repo.ShowAllItems();

            //Assert
            bool repoHasItems = allItems.Contains(menuItem);
            Assert.IsTrue(repoHasItems);
        }
        private List<MenuItem> _menuRepo;
        private List<string> Ingredients;
        [TestMethod]

        public void DeleteMenuItems_ShouldReturnTrue()
    
        {
            //Arrange
            
        }
    }
}
