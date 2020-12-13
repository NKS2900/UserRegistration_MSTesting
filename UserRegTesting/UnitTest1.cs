using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserRegTesting
{
    [TestClass]
    public class UnitTest1
    {
        private readonly RegExValidation reg;
        public UnitTest1()
        {
            reg = new RegExValidation();
        }
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Nijam";
            bool result = reg.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Sayyad";
            bool result = reg.LastNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email = "nks@gmail.com";
            string email2 = "nks.nks@gmail.com";
            string email3 = "nks.nks@gmail.co.in";
            string email4 = "nks.nks3434@gmail.com";
            bool result = reg.EmailValidation(email);
            bool result2 = reg.EmailValidation(email2);
            bool result3 = reg.EmailValidation(email3);
            bool result4 = reg.EmailValidation(email4);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 9130512900";
            bool result = reg.MobileValidation(mobile);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "Console123";
            bool result = reg.PasswordRule(password);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Happy_Test()
        {
            var Result = reg.MessageCheck("Happy");
            Assert.AreEqual(true,Result);
        }
    }
}
