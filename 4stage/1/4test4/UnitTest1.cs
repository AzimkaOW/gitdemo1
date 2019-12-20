using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4test4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string ffs = "aaaabbbbbvvvvvggggaaaabbbbbvvvgggg";
            string sstr = "zzzzzzzzzzzddddddddsssssssaaaaaaaggggg";
            string actual = "abvgzds";

            //act
            string expected = _4.Program.concat(ffs, sstr);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
