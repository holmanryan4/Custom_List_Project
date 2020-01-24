using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class RemovingFromListTest
    {
        [TestMethod]
        public void CustomList_RemovingOneItemFromTheList()
        {
            //Arrange
            CustomList<int> customNumbers = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            customNumbers.Add(4);
            customNumbers.Remove(4);
            actual = customNumbers.Count; 
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void CustomList_RemovingTwoItemsFromTheList()
        {
            //Arrange
            //Act
            //Assert
        }
        public void CustomList_RemoveOneOfTheDuplicatedItemsFromTheList_WithoutRemovingBothItems()
        {
            //Arrange
            //Act
            //Assert
        }
        public void CustomList_WhenRemovingAnItemFromTheList_MakeSureTheOtherItemsInTheListMovesupinTheList()
        {
            //Arrange
            //Act
            //Assert
        }
        public void CustomList_MakeSureItemsThatAreNotInTheList_CanNotBeRemoved()
        {
            //Arrange
            //Act
            //Assert
        }
        public void CustomList_WhenRemovingFiveitemsFromTheList_makeSureTheCapacityDoesNotShrink()
        {
            //Arrange
            //Act
            //Assert
        }

    }

    
}
