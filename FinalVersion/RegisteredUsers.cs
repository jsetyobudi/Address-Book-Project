using System;
using System.Collections.Generic;
/// <summary>
/// This class is part of the BetaPrototype namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{

    /// <summary>
    /// Registered Users class, where the users are stored
    /// </summary>
    public class RegisteredUsers
    {
        /// <summary>
        /// User list
        /// </summary>
        private List<LoginUser> userList = new List<LoginUser>();
        /// <summary>
        /// Setting up users, Initial Constructor
        /// </summary>
        public RegisteredUsers()
        {
            userList.Add(new LoginUser("johan", "123456", true));
            userList.Add(new LoginUser("joe", "123456", false));
        }

        /// <summary>
        /// Returning User list
        /// </summary>
        /// <returns></returns>
        public List<LoginUser> returnUserList()
        {
            return userList;
        }

    }
}
