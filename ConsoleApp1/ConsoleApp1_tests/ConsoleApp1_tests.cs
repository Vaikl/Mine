using ConsoleApp1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ConsoleApp1_tests
    {
        [TestMethod()]
        public void Triangle_10and4and1_returned()
        {
            //arange
            int a = 10;
            int b = 4;
            int c = 1;
            bool expected = false;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void triangleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void triangle_minus()
        {
            //arange
            int a = -5;
            int b = -2;
            int c = -1;
            bool expected = false;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_2and2and2_true_expected()
        {
            //arange
            int a = 2;
            int b = 2;
            int c = 2;
            bool expected = true;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_1000and3500and5200_false_expected()
        {
            //arange
            int a = 1000;
            int b = 3500;
            int c = 5200;
            bool expected = false;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_54and123and46_false_expected()
        {
            //arange
            int a = 54;
            int b = 123;
            int c = 46;
            bool expected = false;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_14and245and240_true_expected()
        {
            //arange
            int a = 14;
            int b = 245;
            int c = 240;
            bool expected = true;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_34and53and5_false_expected()
        {
            //arange
            int a = 34;
            int b = 53;
            int c = 5;
            bool expected = false;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_0and0and0_false_expected()
        {
            //arange
            int a = 0;
            int b = 0;
            int c = 0;
            bool expected = false;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual = q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

namespace ConsoleApp1_tests
{
    [TestClass]
    public class ConsoleApp1_tests
    {
        [TestMethod]
        public void Triangle_4and5and7_true_returned()
        {
            //arange
            int a = 4;
            int b = 5;
            int c = 7;
            bool expected = true;
            //act
            ConsoleApp1.ConsoleApp q = new ConsoleApp1.ConsoleApp();
            bool actual=q.triangle(a, b, c);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
