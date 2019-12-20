using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] numberSourse = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int actual = 9;

            //act
            int expected = _2.Fmax.FmaxAr(numberSourse);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] numberSourse = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            int actual = 9;

            //act
            int expected = _2.Fmax.FmaxAr(numberSourse);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
