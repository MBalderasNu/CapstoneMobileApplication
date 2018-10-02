using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.DatabaseModels
{
    public class UserAccount
    {
        /// <summary>
        /// User Id is the Id for each user
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Username for the Account to sign-in
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Username for the Password to sign-in
        /// </summary>
        public string Password { get; set; }
    }
}
