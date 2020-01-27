using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class AddingToListTest
    {
        [TestMethod]
        public void CustomList_AddingOneItem_ToTheList_AndMakingItShows_AsTheFirstItemInTheList()
        {
            //Arrange 
            CustomList<int> custom = new CustomList<int>();
            int actual;
            int expected = 1;
            // Act
            custom.Add(5);
            actual = custom.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_AddingAnItemToList_AndHavingItShowUpInTheZeroindexSpace()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int actual;
            int expected = 12;

            //Act
            custom.Add(12);
            actual = custom[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListt_AddingSecondItemToTheList_AndhavingTheitemShowInTheList_InSecondPlaceonList()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int firstNumber = 12;
            int secondNumber = 4;
            int actual;
            int expected = 4;
            //Act
            custom.Add(firstNumber);
            custom.Add(secondNumber);
            actual = custom[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_AddTheSameItemTwice_MakeSureBothItemsAreAddedToTheList()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>();

            string officeItem1 = "Desk";
            string Officeitem2 = "Desk";
            string actual;
            string expected = "Desk";
            //Act
            custom.Add(officeItem1);
            custom.Add(Officeitem2);
            actual =  custom[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_AddFiveItemsToTheList_MakeSureCompacityGrowsToEightInSize()
        {
          //Arrange
            CustomList<int> customNumbers = new CustomList<int>();
            int expected = 8;
            int actual;


          //Act
            customNumbers.Add(6);
            customNumbers.Add(4);
            customNumbers.Add(12);
            customNumbers.Add(44);
            customNumbers.Add(56);
            actual = customNumbers.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        //test adding a second value and check to see if its at the 1st index
        //add a second item and check to made sure the 0 index is still the same item  added
        //add five items and check to see if the compacity has grown to 8 in size
        // add the same thing twice and make sure its in the list twice
    }
}
    