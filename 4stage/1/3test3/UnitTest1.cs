using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3test3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] numberSourse = { 1, 0, 0, 0, 0, 0, 0};
            int actual = 0;

            //act
            int? expected = _3.Program.sumLr(numberSourse);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] numberSourse = { 1, 0, 0, 1, 0, 0, 1};
            int actual = 3;

            //act
            int? expected = _3.Program.sumLr(numberSourse);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
