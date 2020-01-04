using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _1test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int numberSourse = 15;
            int numberIn = 15;
            int i = 0;
            int j = 0;
            int expected = 15;
            
            //act
            int actual = _1.Insertnum.InsertNumber(numberSourse, numberIn, i, j);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int numberSourse = 8;
            int numberIn = 15;
            int i = 0;
            int j = 0;
            int expected = 9;

            //act
            int actual = _1.Insertnum.InsertNumber(numberSourse, numberIn, i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int numberSourse = 8;
            int numberIn = 15;
            int i = 3;
            int j = 8;
            int expected = 120;

            //act
            int actual = _1.Insertnum.InsertNumber(numberSourse, numberIn, i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
