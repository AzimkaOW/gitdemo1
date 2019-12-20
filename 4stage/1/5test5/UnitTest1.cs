using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5test5
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test1()
        {
            //arrange
            int a = 12;
            int actual = 21;

            //act
            int expected = _5.Program.FindNextBiggerNumber(a);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
