using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay11
{
    public class UserRegistrationTest
    {
        public string FirstName(string firstName)
        {

            Regex regex = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
            var result = regex.Match(firstName);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.FIRST_NAME_MESSAGE, "first name is not valid");
                }
                return "first name is valid";
            }
            catch
            {
                throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.FIRST_NAME_MESSAGE, "first name is not valid");
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
                    throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.LAST_NAME_MESSAGE, "last name is not valid");
                }
                return "last name is valid";
            }
            catch
            {
                throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.LAST_NAME_MESSAGE, "last name is not valid");
            }

        }
        public string EmailId(string emailid)
        {
            string emailPattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}(.[][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
            var result = regex.Match(emailid);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.EMAIL_ID, "emailid is not valid");
                }
                return "emailid is valid";
            }
            catch
            {
                throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.EMAIL_ID, "emailid is not valid");
            }

        }
        public string MobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = @"^[0-9]{2,}\s[0-9]{10,}$";
            Regex regex = new Regex(mobileNumberPattern);
            var result = regex.Match(mobileNumber);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.MOBILE_NUMBER, "mobile number is not valid");
                }
                return "mobile number is valid";
            }
            catch
            {
                throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.MOBILE_NUMBER, "mobile number is not valid");
            }

        }
        public string PasswordRule1(string passwordRule1)
        {
            string passwordRule1Pattern = @"^.{8,}$";
            Regex regex = new Regex(passwordRule1Pattern);
            var result = regex.Match(passwordRule1);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.PASSWORDRULES, "password rule1 is not valid");
                }
                return "password rule1 is valid";
            }
            catch
            {
                throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.PASSWORDRULES, "password rule1 is not valid");
            }

        }
        public string PasswordRule2(string passwordRule2)
        {
            string passwordRule2Pattern = @"^(?=.*[A-Z]).{8,}$";
            Regex regex = new Regex(passwordRule2Pattern);
            var result = regex.Match(passwordRule2);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.PASSWORDRULES, "password rule2 is not valid");
                }
                return "password rule2 is valid";
            }
            catch
            {
                throw new UserRegrestrationCustomException(UserRegrestrationCustomException.ExceptionType.PASSWORDRULES, "password rule2 is not valid");
            }

        }
    }
}