using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindNthRoot_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            double a = 8;
            double b = 3;
            double eps = 0.1;
            double actual = 2;
            

            //act
            double expected = FindNthRoot.Program.SqrtN(a,b,eps);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            double a = -0.008;
            double b = 3;
            double eps = 0.1;
            double actual = -0.2;


            //act
            double expected = FindNthRoot.Program.SqrtN(a, b, eps);

            //assert
            Assert.AreEqual(expected, actual);
        }
        //public void Test1()
        //{
        //    //arrange
        //    int[] numberSourse = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
        //    int[] actual = { 7, 7, 70, 17 };

        //    //act
        //    int[] expected = _6.Program.shodstva(numberSourse);

        //    //assert
        //    CollectionAssert.AreEqual(expected, actual);
        //}
    }
}
