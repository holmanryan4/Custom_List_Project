using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class ZipperTest
    {
        //[TestMethod]
        //public void CustomList_CheckIndexOfZipperList_ForAccuracyOfTransferedItemsToTheRightIndex()
        //{
        //    //Arrange
        //    CustomList<int> even = new CustomList<int>();
        //    CustomList<int> odd = new CustomList<int>();
        //    CustomList<int> zipper;
        //    string expected = "123456";
        //    string actual;
            
        //    //Act
        //    even.Add(2);
        //    even.Add(4);
        //    even.Add(6);
        //    odd.Add(1);
        //    odd.Add(3);
        //    odd.Add(5);
        //    zipper = odd.Zipper(even);
        //    actual =  zipper.ToString();

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void CustomList_CheckCountOfZipperList_MakingSureAllItemsFromBothOriginalList_AreAllAccountedForInZipperList()
        {
            //Arrange
            CustomList<int> even = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> zipper = new CustomList<int>();
            int expected = 6;
            int actual;
            //Act
            even.Add(2);
            even.Add(4);
            even.Add(6);

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            zipper.Add(odd[0]);
            zipper.Add(even[0]);
            zipper.Add(odd[1]);
            zipper.Add(even[1]);
            zipper.Add(odd[2]);
            zipper.Add(even[2]);
            actual = zipper.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_CheckToMakeSureOnceOneListRunsOutOfItemsToZip_TheOtherListItemsAreListedAtTheEndOfTheZipperList()
        {
            //Arrange
            CustomList<int> even = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> zipper = new CustomList<int>();
            int expected = 9;
            int actual;
            //Act
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);
            even.Add(10);
            even.Add(12);

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            zipper.Add(odd[0]);
            zipper.Add(even[0]);
            zipper.Add(odd[1]);
            zipper.Add(even[1]);
            zipper.Add(odd[2]);
            zipper.Add(even[2]);
            zipper.Add(even[3]);
            zipper.Add(even[4]);
            zipper.Add(even[5]);
            actual = zipper.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
