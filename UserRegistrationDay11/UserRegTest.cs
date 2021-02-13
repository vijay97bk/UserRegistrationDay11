using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationCustomeException
{
    public class UserRegistrationTest
    {
        string firstNamePattern = "^[A-Z]{1}[a-zA-Z]{2,}$";

        public string FirstName(string firstName)
        {

            Regex regex = new Regex(firstNamePattern);
            var result = regex.Match(firstName);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.FIRST_NAME_MESSAGE, "first name is not valid");
                }
                return "first name is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.FIRST_NAME_MESSAGE, "first name is not valid");
            }

        }
        public string LastName(string lastName)
        {
            string lastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex = new Regex(lastNamePattern);
            var result = regex.Match(lastName);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.LAST_NAME_MESSAGE, "last name is not valid");
                }
                return "first name is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.LAST_NAME_MESSAGE, "last name is not valid");
            }

        }
    }
}