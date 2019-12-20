using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6test6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] numberSourse = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int[] actual = { 7, 7, 70, 17 };

            //act
            int[] expected = _6.Program.shodstva(numberSourse);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
