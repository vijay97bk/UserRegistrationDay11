using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationDay11
{
    public class UserRegrestrationCustomException : Exception
    {
      
            /// <summary>
            /// 
            /// </summary>
            public enum ExceptionType
            {
                FIRST_NAME_MESSAGE, LAST_NAME_MESSAGE, EMAIL_ID, MOBILE_NUMBER, PASSWORDRULES,
        }
            public ExceptionType type;

            /// <summary>
            /// Initializes a new instance of the <see cref="UserRegrestrationCustomException"/> class.
            /// </summary>
            /// <param name="type">The type.</param>
            /// <param name="message">The message.</param>
            public UserRegrestrationCustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        
    }
}
