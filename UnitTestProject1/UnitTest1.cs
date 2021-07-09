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
        //when ever the testmethod call before that this testinitializer will call
        public void SetUp()
        {
          find = new FindingMaximum();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrang
            float firstValue = 28.6f, secondValue = 6.9f, thirdValue = 13.5f;
            float expected = 28.6f ;
            //Act
            float actual = find.MaxFloatValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrang
            float firstValue = 6.5f, secondValue = 6.9f, thirdValue = 6.8f;
            float expected = 6.9f;
            //Act
            float actual = find.MaxFloatValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrang
            float firstValue = 28.6f, secondValue = 6.9f, thirdValue = 33.5f;
            float expected = 33.5f;
            //Act
            float actual = find.MaxFloatValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
