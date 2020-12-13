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
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Sayyad";
            bool result = program.LastNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email = "nks.nks@gmail.com.in";
            bool result = program.EmailValidation(email);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 9130512900";
            bool result = program.MobileValidation(mobile);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "Console123";
            bool result = program.PasswordRule(password);
            Assert.AreEqual(true, result);
        }
    }
}
