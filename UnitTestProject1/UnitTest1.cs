using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Generics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //AAA Method
        [TestMethod]
        public void TestMethod1()
        {
            //Checking For Interger
            //Act
            int[] intArray = { 40, 33 ,20 };
            int expected = 40;
            FindingMaximum<int> find = new FindingMaximum<int>(intArray);
            //Arrang
            int actual = find.TestMaximum();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Checking For Float
            //Act
            float[] floatArray = { 3.4f, 3.7f, 3.6f };
            float expected = 3.7f;
            FindingMaximum<float> find = new FindingMaximum<float>(floatArray);
            //Arrang
            float actual = find.TestMaximum();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Checking For String
            //Act
            string[] strArray = { "Apple", "Banana", "Rain", "Peach" };
            string expected = "Rain";
            FindingMaximum<string> find = new FindingMaximum<string>(strArray);
            //Arrang
            string actual = find.TestMaximum();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
