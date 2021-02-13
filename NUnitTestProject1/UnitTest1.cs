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
            string firstName = "dilip";
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
            string lastName = "rathod";
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
    }
}