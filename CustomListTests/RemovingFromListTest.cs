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

        [TestMethod]
        public void CustomList_RemovingTwoItemsFromTheList()
        {
            //Arrange
            CustomList<int> customNumbers = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            customNumbers.Add(5);
            customNumbers.Add(6);

            customNumbers.Remove(5);
            customNumbers.Remove(6);
            actual = customNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_RemoveOneOfTheDuplicatedItemsFromTheList_WithoutRemovingBothItems()
        {
            //Arrange
            CustomList<string> schoolSupplies = new CustomList<string>();
            string expected = "Notebook";
            string actual;

            //Act
            schoolSupplies.Add("Pen");
            schoolSupplies.Add("Notebook");
            schoolSupplies.Add("Pen");
            schoolSupplies.Add("Folder");

            schoolSupplies.Remove("Pen");
            actual = schoolSupplies[0];


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CustomList_WhenRemovingAnItemFromTheList_MakeSureTheOtherItemsInTheListMovesupinTheList()
        {
            //Arrange
            CustomList<string> schoolSupplies = new CustomList<string>();
            string expected = "Notebook";
            string actual;

            //Act
            schoolSupplies.Add("Pen");
            schoolSupplies.Add("Notebook");
            schoolSupplies.Add("Pen");
            schoolSupplies.Add("Folder");

            schoolSupplies.Remove("Pen");
            actual = schoolSupplies[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_MakeSureItemsThatAreNotInTheList_CanNotBeRemoved()
        {
            //Arrange
            CustomList<string> schoolSupplies = new CustomList<string>();
            int expected = 4;
            int actual;

            //Act
            schoolSupplies.Add("Pen");
            schoolSupplies.Add("Notebook");
            schoolSupplies.Add("Pen");
            schoolSupplies.Add("Folder");

            schoolSupplies.Remove("Computer");
            actual = schoolSupplies.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_WhenRemovingFiveitemsFromTheList_makeSureTheCapacityDoesNotShrink()
        {
            //Arrange
            CustomList<int> customNumbers = new CustomList<int>();
            int expected =8;
            int actual;

            //Act
            customNumbers.Add(2);
            customNumbers.Add(4);
            customNumbers.Add(6);
            customNumbers.Add(8);
            customNumbers.Add(10);
     
            customNumbers.Remove(2);
            customNumbers.Remove(4);
            customNumbers.Remove(6);
            customNumbers.Remove(8);
            customNumbers.Remove(10);
            actual = customNumbers.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }


}
