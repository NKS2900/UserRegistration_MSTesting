using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;
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
        public void HappyTest()
        {
            var Result = reg.MessageCheck("Happy");
            Assert.AreEqual(true, Result);
        }
        [TestMethod]
        public void MultipleEmailTest()
        {
            var Result = reg.CheckMultipleEmail("nks@gmail.com","nks.nks@gmail.com","nks234@gmail.com");
            string check = "succesfull";
            Assert.AreEqual(check, Result);
        }
        [TestMethod]
        [DataRow("nijam")]
        public void InvalidName_TrowException(string FirstName)
        {
            try
            {
                reg.FirstNameVal(FirstName);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid First Name", Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("sayyad")]
        public void InvalidLastName_TrowException(string LastName)
        {
            try
            {
                reg.LastNameVal(LastName);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid LastName", Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("imraninfo@gmail.com")]
        public void InvalidEmail_ThrowException(string Email)
        {
            try
            {
                reg.EmailValidation(Email);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid Email", Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("91 1234567890")]
        public void InvalidMobileNo_TrowException(string MobileNo)
        {
            try
            {
                reg.MobileValidation(MobileNo);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid Mobile No", Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("12Q35abcd")]
        public void InvalidPassword_TrhowException(string Password)
        {
            try
            {
                reg.PasswordRule(Password);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid Password", Exception.Message);
            }
        }
    }
}
