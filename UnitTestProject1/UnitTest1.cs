using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Generics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        public void TestMethod1()
        {
            //Max Integer at 1st Position
            int[] intArray = { 40, 33 ,20 };
            int expected = 40;
            FindingMaximum<int> find = new FindingMaximum<int>(intArray);
            int actual = find.FindingMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Max float at 2nd Position
            float[] floatArray = { 3.4f, 3.7f, 3.6f };
            float expected = 3.7f;
            FindingMaximum<float> find = new FindingMaximum<float>(floatArray);
            float actual = find.FindingMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Max String at 3rd Position
            string[] strArray = { "Apple", "Banana", "Rain", "Peach" };
            string expected = "Rain";
            FindingMaximum<string> find = new FindingMaximum<string>(strArray);
            string actual = find.FindingMaxValue();
            Assert.AreEqual(expected, actual);
        }

    }
}
