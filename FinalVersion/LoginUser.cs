using System;
/// <summary>
/// This class is part of the BetaPrototype namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{

    /// <summary>
    /// Login user Class that makes the login user
    /// </summary>
    public class LoginUser
    {
        /// <summary>
        /// Member id
        /// </summary>
        private int member_id;
        /// <summary>
        /// Admin variable
        /// </summary>
        private bool is_admin;
        /// <summary>
        /// Alias
        /// </summary>
        private String alias;
        /// <summary>
        /// First Name
        /// </summary>
        private String first_name;
        /// <summary>
        /// Last name
        /// </summary>
        private String last_name;
        /// <summary>
        /// Email
        /// </summary>
        private String email;
        /// <summary>
        /// Username
        /// </summary>
        private String username;
        /// <summary>
        /// Password
        /// </summary>
        private String password;
        /// <summary>
        /// Behaviour
        /// </summary>
        private UserBehaviour behaviour;

        /// <summary>
        /// Getter/Setter for id
        /// </summary>
        public int Member_id
        {
            get
            {
                return member_id;
            }

            set
            {
                member_id = value;
            }
        }
        /// <summary>
        /// Getter/Setter for Admin
        /// /// </summary>
        public bool Is_admin
        {
            get
            {
                return is_admin;
            }

            set
            {
                is_admin = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Alias
        /// </summary>
        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }

        /// <summary>
        /// Getter/Setter for First Name
        /// </summary>
        public string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                first_name = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Last Name
        /// </summary>
        public string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                last_name = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Email
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Username
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Password
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }



        /// <summary>
        /// Initial Consturctor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="is_admin"></param>
        public LoginUser(String username, String password, bool is_admin)
        {
            this.Username = username;
            this.Password = password;
            this.Is_admin = is_admin;
            behaviour = new NormalUserBehaviour();
        }

        /// <summary>
        /// Changing the behaviour from admin to normal user
        /// </summary>
        /// <param name="userBehaviour"></param>
        public void changeBehaviour(UserBehaviour userBehaviour)
        {
            this.behaviour = userBehaviour;
        }
    }
}
