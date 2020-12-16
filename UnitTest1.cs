using COMP10066Lab5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
// i, Manan Patel,000826892 accept that it is my original work and i havent copied from any other person.


/// Bugs: bug found in subset method.
/// description: SetA is the subset of setB but still showing it is not a subset.
/// Bug fixes: Proper programming error in the for loop, it can be avoided by doin it both way that either way they can be subset.
/// bug 2: bug found in the create set method as it accepts a single value than more than 1
/// description: As the method says that it accepts more than 1 size of the int size but if we put 1 in the value than it accepts.
/// Bug fixes:Commenting should be wrote as int size must be>=1.
namespace Lab4UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateSet_CorrectSizeCreated()
        {
            //Arrange
            int size = 20;
            int minimum = 0;
            int maximum = 100;
            bool uniqueElements = false;
            int expResult = size;

            //Act
            int result = ArraySetUtilities.CreateSet(size, minimum, maximum, uniqueElements).Count;

            //Assert
            Assert.AreEqual(expResult, result, "incorrect item count");
        }

        [TestMethod]
        public void TestIsUnique_unique()
        {
            //Arrange
            List<int> arraySet = new List<int>() { 10, 12, 22, 33, 45, 44, 55, 48, 1 };
            bool expResult = true; //should be true to execute

            //Act
            bool actualResult = ArraySetUtilities.IsUnique(arraySet);

            //Assert
            Assert.AreEqual(expResult, actualResult, "Unique array test returning false - test array is unique");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIntersection_SetASizeZero()
        {
            //Arrange
            List<int> setA = new List<int>();
            List<int> setB = new List<int>() { 10, 12, 22, 33, 45, 44, 55, 48, 1 };
            //expected exception

            //Act
            List<int> result = ArraySetUtilities.Intersection(setA, setB);

            //Assert
            //no assert equired in this method.
        }
        [TestMethod]
        //here no exception required
        public void Testunion_union()
        {
            //Arrange
            List<int> setA = new List<int>() { 2, 6, 8, 9, 11, 44, 77, 55 };
            List<int> setB = new List<int>() { 10, 12, 22, 33, 45, 44, 55, 48, 1 };
            
            int expResult = 2;
            //Act
            List<int> result = ArraySetUtilities.union(setA, setB);

            //Assert
            Assert.AreEqual(expResult, result[0], "union is executed");
        }
        [TestMethod]
        public void TestsubSet_subset()
        {
            //Arrange
            List<int> setA = new List<int>() { 33, 45, 44 };
            List<int> setB = new List<int>() { 10, 12, 22, 33, 45, 44, 55, 48, 1 };
            bool expResult = false;
            //Act
            bool result = ArraySetUtilities.subSet(setA, setB);

            //Assert
            Assert.AreEqual(expResult, result, "Not a subset");

        }
        [TestMethod]
        //bug found in this case.
        public void TestCreateSet_Testforsize()
        {
            //Arrange
            int expResult = 2;
            //Act
            List<int> result = ArraySetUtilities.CreateSet(1, 2, 4, false);
            //Assert
            Assert.AreEqual(expResult, result[0], "it obtains some random values");
        }



    }
}
