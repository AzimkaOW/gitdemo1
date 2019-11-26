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
            int numberSourse = 8;
            int numberIn = 6;
            int i = 32 - 0;
            int j = 32 - 2;
            int expected = 14;
            
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
            int numberIn = 4;
            int i = 32 - 0;
            int j = 32 - 2;
            int expected = 12;

            //act
            int actual = _1.Insertnum.InsertNumber(numberSourse, numberIn, i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int numberSourse = 6;
            int numberIn = 8;
            int i = 32 - 0;
            int j = 32 - 2;
            int expected = 0;

            //act
            int actual = _1.Insertnum.InsertNumber(numberSourse, numberIn, i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
