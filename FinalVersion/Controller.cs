using System;
using System.Collections.Generic;
/// <summary>
/// This class is part of the FinalVersion namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{
    /// <summary>
    /// Controller class that logs you in
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// users
        /// </summary>
        private RegisteredUsers users;
        /// <summary>
        /// list of users
        /// </summary>
        private List<LoginUser> userList;

        /// <summary>
        /// initial constructor
        /// </summary>
        public Controller()
        {
            users = new RegisteredUsers();
            userList = new List<LoginUser>();
        }
        /// <summary>
        /// logging in
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean LoginController(String username, String password)
        {
            userList = users.returnUserList();
            //logging in, finding if correct username and password combination
            var usernameFind = userList.Find(x => x.Username == username);
            var passwordFind = userList.Find(x => x.Password == password);
            if (usernameFind != null && passwordFind != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return false;
            }
        }
        /// <summary>
        /// checking if admin
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean isAdmin(String username, String password)
        {
            var isAdminString = userList.Find(x => x.Username == username).Is_admin.ToString(); //checking if admin here
            if (isAdminString.ToLower().Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
