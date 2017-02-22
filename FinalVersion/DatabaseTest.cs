using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Testing class for database
    /// </summary>  
    [TestFixture]
    class DatabaseTest
    {
        /// <summary>
		/// Contact variable
		/// </summary>
		private Contact contact;
        /// <summary>
        /// Validation variable
        /// </summary>
        private Validate validate;
        /// <summary>
        /// First Name 
        /// </summary>
        private String firstName;
        /// <summary>
        /// Last Name
        /// </summary>
        private String lastName;
        /// <summary>
        /// Address
        /// </summary>
        private String address;
        /// <summary>
        /// Postal Code
        /// </summary>
        private String postalCode;
        /// <summary>
        /// City
        /// </summary>
        private String city;
        /// <summary>
        /// Country
        /// </summary>
        private String country;
        /// <summary>
        /// Email
        /// </summary>
        private String email;
        /// <summary>
        /// Home Phone
        /// </summary>
        private String homePhone;
        /// <summary>
        /// Work Phone
        /// </summary>
        private String workPhone;
        /// <summary>
        /// Cell Phone
        /// </summary>
        private String cellPhone;
        /// <summary>
        /// Id
        /// </summary>
        private int id;
        /// <summary>
        /// test first name
        /// </summary>
        private String testFirstName;
        /// <summary>
        /// test last name
        /// </summary>
        private String testLastName;
        /// <summary>
        /// test address
        /// </summary>
        private String testAddress;
        /// <summary>
        /// test postal code
        /// </summary>
        private String testPostalCode;
        /// <summary>
        /// test city
        /// </summary>
        private String testCity;
        /// <summary>
        /// test country
        /// </summary>
        private String testCountry;
        /// <summary>
        /// test email
        /// </summary>
        private String testEmail;
        /// <summary>
        /// test home phone
        /// </summary>
        private String testHomePhone;
        /// <summary>
        /// test work phone
        /// </summary>
        private String testWorkPhone;
        /// <summary>
        /// test cell phone
        /// </summary>
        private String testCellPhone;
        /// <summary>
        /// test id
        /// </summary>
        private int testId;

        /// <summary>
        /// Set up
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            firstName = "Joe";
            lastName = "Setyobudi";
            address = "123 main avenue";
            postalCode = "K2V1P4";
            city = "Ottawa";
            country = "Canada";
            email = "sety0002@algonquinlive.com";
            homePhone = "613-321-4322";
            workPhone = "613-964-4345";
            cellPhone = "613-443-2221";
            id = 1;
            //creating a database file
            // SQLiteConnection.CreateFile("C:\\Users\\Johan\\Documents\\Visual Studio 2015\\Projects\\FinalVersion\\FinalVersion\\Stesting.sqlite");
            //creating connection
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=C:\\Users\\Johan\\Documents\\Visual Studio 2015\\Projects\\FinalVersion\\FinalVersion\\testing.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            //creating table
            //  string table = "create table contact (id INTEGER PRIMARY KEY, f_name VARCHAR(30), l_name VARCHAR(30), address VARCHAR(90), postal_code VARCHAR(30), city VARCHAR(30), country VARCHAR(30), home_phone VARCHAR(30), mobile_phone VARCHAR(30), work_phone VARCHAR(30), email VARCHAR(30))";
            SQLiteCommand command;// = new SQLiteCommand(table, m_dbConnection);
                                  //executing above query
                                  // command.ExecuteNonQuery();
                                  //creating insert statements
                                  //string insert1 = "insert into contact (f_name,l_name,address,postal_code,city,country,home_phone,mobile_phone,work_phone,email) values( 'Johan', 'Setyobudi', '123 main avenue', 'K2V1P4', 'Ottawa', 'Canada', '613-321-4322', '613-443-2221', '613-964-4345', 'sety0002@algonquinlive.com')";
                                  //executing all 3 queries one at a time
                                  //command = new SQLiteCommand(insert1, m_dbConnection);
                                  //command.ExecuteNonQuery();
            string query = "Select * from contact";
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            //displaying data
            while (reader.Read())
            {
                testId = Convert.ToInt32(reader["id"]);
                testFirstName = reader["f_name"].ToString();
                testLastName = reader["l_name"].ToString();
                testAddress = reader["address"].ToString();
                testPostalCode = reader["postal_code"].ToString();
                testCity = reader["city"].ToString();
                testCountry = reader["country"].ToString();
                testHomePhone = reader["home_phone"].ToString();
                testCellPhone = reader["mobile_phone"].ToString();
                testWorkPhone = reader["work_phone"].ToString();
                testEmail = reader["email"].ToString();


            }
            m_dbConnection.Close();

        }

        /// <summary>
        /// Testing first name
        /// </summary>
        [Test]
        public void TestFirstName()
        {

            Assert.AreEqual(firstName, testFirstName);
        }
        /// <summary>
        /// Testing last name
        /// </summary>
        [Test]
        public void TestLastName()
        {
            Assert.AreEqual(lastName, testLastName);
        }

        /// <summary>
        /// Testing address
        /// </summary>
        [Test]
        public void TestAddress()
        {
            Assert.AreEqual(address, testAddress);
        }

        /// <summary>
        /// Testing postal code
        /// </summary>
        [Test]
        public void TestPostalCode()
        {
            Assert.AreEqual(postalCode, testPostalCode);
        }

        /// <summary>
        /// Testing city
        /// </summary>
        [Test]
        public void TestCity()
        {
            Assert.AreEqual(city, testCity);
        }

        /// <summary>
        /// Testing country
        /// </summary>
        [Test]
        public void TestCountry()
        {
            Assert.AreEqual(country, testCountry);
        }

        /// <summary>
        /// Testing home phone number
        /// </summary>
        [Test]
        public void TestHomePhone()
        {
            Assert.AreEqual(homePhone, testHomePhone);

        }

        /// <summary>
        /// Testing cell phone number
        /// </summary>
        [Test]
        public void TestCellPhone()
        {
            Assert.AreEqual(cellPhone, testCellPhone);
        }

        /// <summary>
        /// Testing work phone number
        /// </summary>
        [Test]
        public void TestWorkPhone()
        {
            Assert.AreEqual(workPhone, testWorkPhone);
        }

        /// <summary>
        /// Testing email
        /// </summary>
        [Test]
        public void TestEmail()
        {
            Assert.AreEqual(email, testEmail);
        }


        /// <summary>
        /// Testing contact id
        /// </summary>
        [Test]
        public void TestContactID()
        {
            Assert.AreEqual(id, testId);
        }
        [Test]
        public void TestDelete()
        {

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=C:\\Users\\Johan\\Documents\\Visual Studio 2015\\Projects\\FinalVersion\\FinalVersion\\testing.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            SQLiteCommand command;
            string query = "delete from contact where id = @id";
            command = new SQLiteCommand(query, m_dbConnection);
            command.Parameters.AddWithValue("@id", 2);
            try
            {
                //executing query
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            String number = "1";
            query = "Select count(*) as count from contact";
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            //displaying data
            while (reader.Read())
            {
                number = reader["count"].ToString();

            }
            Assert.AreEqual("1", number);
        }
        /// <summary>
        /// testing an edit
        /// </summary>
        [Test]
        public void TestEdit()
        {
            String firstName2 = "Joe";
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=C:\\Users\\Johan\\Documents\\Visual Studio 2015\\Projects\\FinalVersion\\FinalVersion\\testing.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            SQLiteCommand command;
            String query = "update contact set f_name = @f_name where id = @id";
            command = new SQLiteCommand(query, m_dbConnection);
            command.Parameters.AddWithValue("@f_name", firstName2);
            command.Parameters.AddWithValue("@id", 2);

            try
            {
                //executing query
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            query = "Select * from contact";
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            //displaying data
            while (reader.Read())
            {
                testFirstName = reader["f_name"].ToString();



            }
            m_dbConnection.Close();
            Assert.AreEqual(firstName2, testFirstName);

        }


        /// <summary>
        /// Tear down, setting everything to null
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            firstName = null;
            testFirstName = null;
            lastName = null;
            testLastName = null;
            address = null;
            testAddress = null;
            city = null;
            testCity = null;
            country = null;
            testCountry = null;
            email = null;
            testEmail = null;
            homePhone = null;
            testHomePhone = null;
            workPhone = null;
            testWorkPhone = null;
            cellPhone = null;
            testCellPhone = null;
        }
    }
}
