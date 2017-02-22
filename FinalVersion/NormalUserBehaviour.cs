using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
/// <summary>
/// This class is part of the FinalVersion namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{
    /// <summary>
    /// NormalUser class, implements UserBehaviour, the normal user class
    /// </summary>
    public class NormalUserBehaviour : UserBehaviour
    {
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
        /// Validate
        /// </summary>
        protected Validate validate;
        /// <summary>
        /// Contact List
        /// </summary>
        private List<Contact> contactList;
        /// <summary>
        /// Returning contact list
        /// </summary>
        internal List<Contact> ContactList
        {
            get
            {
                return contactList;
            }


        }

        /// <summary>
        /// Initial Constructor
        /// </summary>
        public NormalUserBehaviour()
        {

            SQLiteConnection.CreateFile("finalversion.sqlite"); //creating database file
                                                                //  creating connection
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            //  creating table
            string table = "create table contact (id INTEGER PRIMARY KEY, f_name VARCHAR(30), l_name VARCHAR(30), address VARCHAR(90), postal_code VARCHAR(10), city VARCHAR(30), country VARCHAR(30), home_phone VARCHAR(30), mobile_phone VARCHAR(30), work_phone VARCHAR(30), email VARCHAR(30))";
            SQLiteCommand command = new SQLiteCommand(table, m_dbConnection);
            //  executing above query
            command.ExecuteNonQuery();
            contactList = new List<Contact>(); //initializing list of type Contact
            validate = new Validate(); //initializing validation

        }

        /// <summary>
        /// Adding contact method
        /// </summary>
        public void addContact()
        {
            String prompt;
            do
            {
                Console.WriteLine("Adding a contact...");
                do
                {
                    Console.Write("Please enter a first name: ");
                    firstName = Console.ReadLine();

                } while (!validate.ValidateName(firstName)); //validation for first name

                do
                {
                    Console.Write("Please enter a last name: ");
                    lastName = Console.ReadLine();

                } while (!validate.ValidateName(lastName)); //validation for last name
                do
                {
                    Console.Write("Please enter an address: ");
                    address = Console.ReadLine();
                } while (!validate.ValidateAddress(address)); //validation for address
                do
                {
                    Console.Write("Please enter a postal code with no spaces: ");
                    postalCode = Console.ReadLine();
                    postalCode = postalCode.ToUpper();//in case user types any lower case, make it all upper case
                } while (!validate.ValidatePostalCode(postalCode));


                do
                {
                    Console.Write("Please enter a city: ");
                    city = Console.ReadLine();
                } while (!validate.ValidCityCountry(city)); //validate city
                do
                {
                    Console.Write("Please enter a country: ");
                    country = Console.ReadLine();
                } while (!validate.ValidCityCountry(country)); //validate country
                do
                {
                    Console.Write("Please enter an email: ");
                    email = Console.ReadLine();

                } while (!validate.ValidEmail(email)); //validation for email

                do
                {
                    Console.Write("Please enter a home phone number(In format 111-111-1111): ");
                    homePhone = Console.ReadLine();
                } while (!validate.ValidPhoneNumber(homePhone)); //validation for phone number

                do
                {
                    Console.Write("Please enter a work phone number(In format 111-111-1111): ");
                    workPhone = Console.ReadLine();
                } while (!validate.ValidPhoneNumber(workPhone)); //validation for phone number

                do
                {

                    Console.Write("Please enter a mobile phone number(In format 111-111-1111): ");
                    cellPhone = Console.ReadLine();
                } while (!validate.ValidPhoneNumber(cellPhone)); //validation for phone number

                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
                //opening database
                m_dbConnection.Open();
                //inserting data to database
                string insert = "insert into contact (f_name,l_name,address,postal_code,city,country,home_phone,mobile_phone,work_phone,email)";
                insert += " values (@f_name,@l_name,@address,@postal_code,@city,@country,@home_phone,@mobile_phone,@work_phone,@email)";

                SQLiteCommand command = new SQLiteCommand(insert, m_dbConnection);
                //binding variables so its safe
                command.Parameters.AddWithValue("@f_name", firstName);
                command.Parameters.AddWithValue("@l_name", lastName);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@postal_code", postalCode);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@home_phone", homePhone);
                command.Parameters.AddWithValue("@mobile_phone", cellPhone);
                command.Parameters.AddWithValue("@work_phone", workPhone);
                command.Parameters.AddWithValue("@email", email);

                try
                {
                    //executing query
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                //closing database
                m_dbConnection.Close();


                Console.WriteLine("Contact successfully added!\n");
                Console.WriteLine("Would you like to add another contact? (Y/N)"); //maybe user wants to add another contact
                prompt = Console.ReadLine();

            } while (!string.Equals(prompt, "n", StringComparison.OrdinalIgnoreCase));//making it not case sensitive, similar to equalsignorecase in java 
        }
        /// <summary>
        /// Searching Contact method
        /// </summary>
        /// <param name="name"></param>
        public void searchContact(String name)
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            SQLiteCommand command;
            string query = "Select * from contact where l_name = @l_name";
            command = new SQLiteCommand(query, m_dbConnection);
            command.Parameters.AddWithValue("@l_name", name);
            SQLiteDataReader reader = command.ExecuteReader();
            //displaying data
            while (reader.Read())
            {
                Console.WriteLine("\nid: " + reader["id"] + "\nFirst Name: " + reader["f_name"] + "\nLast Name: " + reader["l_name"] + "\naddress: " + reader["address"] + "\nPostal Code: " + reader["postal_code"]
                     + "\nCity: " + reader["city"] + "\nCountry: " + reader["country"] + "\nHome Phone: " + reader["home_phone"] + "\nMobile Phone: " + reader["mobile_phone"] + "\nWork Phone: " + reader["work_phone"] + "\nemail: " + reader["email"] + "\n");
            }
            m_dbConnection.Close();

        }
        /// <summary>
        /// Getting all contacts from database and putting it in a list
        /// </summary>
        /// <returns></returns>
        public List<Contact> getContacts()
        {
            List<Contact> getAllContacts = new List<Contact>();
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            SQLiteCommand command;
            string query = "Select * from contact";
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            //displaying data
            while (reader.Read())
            {
                getAllContacts.Add(new Contact(Convert.ToInt32(reader["id"]), reader["f_name"].ToString(), reader["l_name"].ToString(), reader["address"].ToString(), reader["postal_code"].ToString(), reader["city"].ToString(), reader["country"].ToString(), reader["home_phone"].ToString(), reader["mobile_phone"].ToString(), reader["work_phone"].ToString(), reader["email"].ToString()));

            }
            m_dbConnection.Close();

            return getAllContacts;
        }
        /// <summary>
        /// Getting all data from the database
        /// </summary>
        public void getAllFromDatabase()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
            //opening database
            m_dbConnection.Open();
            SQLiteCommand command;
            string query = "Select * from contact";
            command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            //displaying data
            while (reader.Read())
            {

                Console.WriteLine("\nid: " + reader["id"] + "\nFirst Name: " + reader["f_name"] + "\nLast Name: " + reader["l_name"] + "\naddress: " + reader["address"] + "\nPostal Code: " + reader["postal_code"]
                     + "\nCity: " + reader["city"] + "\nCountry: " + reader["country"] + "\nHome Phone: " + reader["home_phone"] + "\nMobile Phone: " + reader["mobile_phone"] + "\nWork Phone: " + reader["work_phone"] + "\nemail: " + reader["email"] + "\n");

            }
            m_dbConnection.Close();

        }
        /// <summary>
        /// Viewing all contact method
        /// </summary>
        public void viewAllContacts()
        {
            Console.WriteLine("Viewing all contacts\n");
            //getting data from database
            contactList = getContacts();
            //displaying data

            //sorting the collection by first name
            Console.WriteLine("Sorting List by First Name\nPress any button to continue...\n");
            Console.ReadKey();
            ContactList.Sort(
                delegate (Contact c1, Contact c2)
                {
                    return c1.FirstName.CompareTo(c2.FirstName);
                }
                );
            foreach (var contact in ContactList) //printing everything inside list and arragnging it neatly
            {
                Console.WriteLine("\nFirst Name: {0}\nLast Name: {1}\nAddress: {2}\nPostal Code: {3}\nCity: {4}\nCountry: {5}\nHome Phone: {6}\nCell Phone: {7}\nWork Phone: {8}\nEmail: {9}\nContact ID: {10}\n"
                    , contact.FirstName, contact.LastName, contact.Address, contact.PostalCode, contact.City, contact.Country, contact.HomePhoneNumber, contact.MobilePhoneNumber, contact.WorkPhoneNumber, contact.Email, contact.ContactID);
            }
            Console.WriteLine("\nPress any button to continue...");
            Console.ReadKey(); //breakpoint to show data
        }
        /// <summary>
        /// Editing contact method
        /// </summary>
        public virtual void editContact()
        {
            Console.WriteLine("You don't have permission to do that!\n"); //normal user cant access this
        }
        /// <summary>
        /// Deleting contact method
        /// </summary>
        public virtual void deleteContact()
        {
            Console.WriteLine("You don't have permission to do that!\n"); //normal user cant access this

        }
        /// <summary>
        /// Output contact method
        /// </summary>
        public void outputContact()
        {
            contactList = getContacts();
            String fileLocation = "C:\\Users\\Johan\\Documents\\visual studio 2015\\Projects\\FinalVersion\\test.txt"; //location of sample text file
            Console.WriteLine("Outputting contact list to file...\nPress any button to continue\n");
            Console.ReadKey();
            System.IO.File.WriteAllLines(fileLocation, contactList.ConvertAll(Convert.ToString)); //converting list to a string so can be written to file,
                                                                                                  //writing to the file, then closing the file
        }
        /// <summary>
        /// Exit program method
        /// </summary>
        public void exitProgram()
        {
            Console.WriteLine("Exiting Program...\nPress any button to continue");
            Console.ReadKey();
            System.Environment.Exit(1); //exiting program safely
        }
        /// <summary>
        /// Changing Account Behaviour method
        /// </summary>
        /// <returns></returns>
        public virtual String accountBehaviour()
        {
            return "Normal Account";
        }
    }
}
