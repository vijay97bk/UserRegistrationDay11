using NUnit.Framework;
using UserRegistrationException;
namespace NUnitTestProject
{
    public class Tests
    {
        UserRegistrationTest userRegistrationTest;
        [SetUp]
        public void Setup()
        {
            userRegistrationTest = new UserRegistrationTest();
        }

        /// <summary>
        /// Act methodology- method calling 
        /// Assert methodology- here we can define the output 
        /// </summary>
        [Test]
        public void GivenFirstNameExpectingTrueResult()
        {
            string firstName = "vijay";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.FirstName(firstName);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("first name is not valid", exception.Message);
            }

        }
        [Test]
        public void GivenLastNameExpectingTrueResult()
        {
            string lastName = "kshirasagar";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.LastName(lastName);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("last name is not valid", exception.Message);
            }

        }
        [Test]
        public void GivenEmailExpectingTrueResult()
        {
            string emailid = "abc.xyz@gmail.com";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.EmailId(emailid);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("emailid is not valid", exception.Message);
            }

        }
        [Test]
        public void MobileNumberExpectingTrueResult()
        {
            string mobileNumber = "91+ 9876543210";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.MobileNumber(mobileNumber);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("mobile number is not valid", exception.Message);
            }

        }
    }
}