using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Generics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FindingMaximum find;
        [TestInitialize]
        public void SetUp()
        {
          find = new FindingMaximum();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrang
            int firstValue = 28, secondValue = 6, thirdValue = 13;
            int expected = 28 ;
            //FindingMaximum find = new FindingMaximum();
            //Act
            int actual = find.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrang
            int firstValue = 21, secondValue = 26, thirdValue = 13;
            int expected = 26;
            //FindingMaximum find = new FindingMaximum();
            //Act
            int actual = find.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrang
            int firstValue = 20, secondValue = 26, thirdValue = 33;
            int expected = 33;
            //FindingMaximum find = new FindingMaximum();
            //Act
            int actual = find.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
