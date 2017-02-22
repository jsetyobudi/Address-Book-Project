using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This class is part of the FinalVersion.test namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion.Test
{
    /// <summary>
    /// Testing for Users
    /// </summary>
    [TestFixture]
    public class UsersTest
    {
        /// <summary>
        /// username
        /// </summary>
        private String name;
        /// <summary>
        /// password
        /// </summary>
        private String password;
        /// <summary>
        /// is admin
        /// </summary>
        private bool isAdmin;
        /// <summary>
        /// test class
        /// </summary>
        private RegisteredUsers test;
        /// <summary>
        /// getting list of users
        /// </summary>
        private List<LoginUser> listTest;
        /// <summary>
        /// Setting up method
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            name = "johan";
            password = "123456";
            isAdmin = true;
            test = new RegisteredUsers();
            listTest = test.returnUserList();
        }
        /// <summary>
        /// testing name
        /// </summary>
        [Test]
        public void nameTest()
        {
            var usernameFind = listTest.Find(x => x.Username == name).Username.ToString();
            Assert.AreEqual(name, usernameFind);

        }
        /// <summary>
        /// testing password
        /// </summary>
        [Test]
        public void passwordTest()
        {
            var passwordFind = listTest.Find(x => x.Username == name).Password.ToString();
            Assert.AreEqual(password, passwordFind);

        }
        /// <summary>
        /// testing admin
        /// </summary>
        [Test]
        public void isAdminTest()
        {
            var isAdminFind = listTest.Find(x => x.Username == name).Is_admin.ToString();
            Assert.AreEqual(isAdmin.ToString(), isAdminFind);

        }

        [TearDown]
        public void tearDown()
        {
            name = null;
            password = null;
            test = null;
            listTest = null;
        }
    }
}
