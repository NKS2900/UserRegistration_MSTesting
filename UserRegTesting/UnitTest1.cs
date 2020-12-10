using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserRegTesting
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Nijam";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
    }
}
