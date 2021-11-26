using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISBNday2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] number = new int[] { 9, 7, 8, 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };

            bool result = EmptyClass.VerifyISBN(number);

            Assert.AreEqual(result, true);
        }
    }
}
