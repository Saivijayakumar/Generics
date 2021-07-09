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
            String firstname = "zero", secondname = "To", thirdname = "Hero";
            string expected = "zero" ;
            //Act
            string actual = find.MaxStringValue(firstname, secondname, thirdname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrang
            String firstname = "sai", secondname = "vijaya", thirdname = "kumar";
            string expected = "vijaya";
            //Act
            string actual = find.MaxStringValue(firstname, secondname, thirdname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrang
            String firstname = "Hero", secondname = "To", thirdname = "zero";
            string expected = "zero";
            //Act
            string actual = find.MaxStringValue(firstname, secondname, thirdname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
