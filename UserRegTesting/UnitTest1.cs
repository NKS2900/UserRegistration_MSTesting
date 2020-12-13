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
            string email = "nks@gmail.com";
            string email2 = "nks.nks@gmail.com";
            string email3 = "nks.nks@gmail.co.in";
            string email4 = "nks.nks3434@gmail.com";
            bool result = program.EmailValidation(email);
            bool result2 = program.EmailValidation(email2);
            bool result3 = program.EmailValidation(email3);
            bool result4 = program.EmailValidation(email4);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
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
