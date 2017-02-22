using System;
using System.Data.SQLite;
/// <summary>
/// This class is part of the BetaPrototype namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{
    /// <summary>
    /// Admin User class, extends NormalUser class, and implements User Behaviour, the admin user class
    /// </summary>
    public class AdminUserBehaviour : NormalUserBehaviour, UserBehaviour
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public AdminUserBehaviour()
        {

        }
        /// <summary>
        /// Editing contact method 
        /// </summary>
        public override void editContact()
        {
            String input;
            do
            {
                getAllFromDatabase();
                Console.WriteLine("Please select an ID to edit: ");
                input = Console.ReadLine();
                int selectedOption;

                if (int.TryParse(input, out selectedOption)) //exception handling here, converting to an int, and if not int, it will display message in else statement
                {
                    SQLiteConnection m_dbConnection;
                    m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
                    //opening database
                    m_dbConnection.Open();
                    SQLiteCommand command;
                    string query = "Select * from contact where id = @id";
                    command = new SQLiteCommand(query, m_dbConnection);
                    command.Parameters.AddWithValue("@id", selectedOption);
                    SQLiteDataReader reader = command.ExecuteReader();
                    //displaying data
                    while (reader.Read())
                    {
                        Console.WriteLine("\nid: " + reader["id"] + "\nFirst Name: " + reader["f_name"] + "\nLast Name: " + reader["l_name"] + "\naddress: " + reader["address"] + "\nPostal Code: " + reader["postal_code"]
                             + "\nCity: " + reader["city"] + "\nCountry: " + reader["country"] + "\nHome Phone: " + reader["home_phone"] + "\nMobile Phone: " + reader["mobile_phone"] + "\nWork Phone: " + reader["work_phone"] + "\nemail: " + reader["email"] + "\n");
                    }
                    String value;

                    Console.WriteLine("What would you like to edit? Please chosoe from the following items:\n");
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. Postal Code");
                    Console.WriteLine("5. City");
                    Console.WriteLine("6. Country");
                    Console.WriteLine("7. Home Phone");
                    Console.WriteLine("8. Mobile Phone");
                    Console.WriteLine("9. Work Phone");
                    Console.WriteLine("10. Email");
                    value = Console.ReadLine();
                    int selectedOption2;
                    if (int.TryParse(value, out selectedOption2)) //exception handling here, converting to an int, and if not int, it will display message in else statement
                    {
                        switch (selectedOption2)
                        {
                            case 1:
                                do
                                {
                                    Console.Write("Please enter a first name: ");
                                    value = Console.ReadLine();
                                    query = "update contact set f_name = @f_name where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@f_name", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);

                                } while (!validate.ValidateName(value)); //validation for first name

                                break;
                            case 2:
                                do
                                {
                                    Console.Write("Please enter a Last name: ");
                                    value = Console.ReadLine();
                                    query = "update contact set l_name = @l_name where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@l_name", input);
                                    command.Parameters.AddWithValue("@id", selectedOption);


                                } while (!validate.ValidateName(value)); //validation for last name
                                break;
                            case 3:
                                do
                                {
                                    Console.Write("Please enter an address ");
                                    value = Console.ReadLine();
                                    query = "update contact set address = @address where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@address", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);


                                } while (!validate.ValidateAddress(value)); //validation for address
                                break;
                            case 4:
                                do
                                {
                                    Console.Write("Please enter a postal code with no spaces: ");
                                    value = Console.ReadLine();
                                    value = input.ToUpper();//in case user types any lower case, make it all upper case
                                    query = "update contact set postal_code = @postal_code where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@postal_code", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);

                                } while (!validate.ValidatePostalCode(value)); //validate postal code

                                break;
                            case 5:
                                do
                                {
                                    Console.Write("Please enter a city: ");
                                    value = Console.ReadLine();
                                    query = "update contact set city = @city where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@city", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);

                                } while (!validate.ValidCityCountry(value)); //validate city
                                break;
                            case 6:
                                do
                                {
                                    Console.Write("Please enter a country: ");
                                    value = Console.ReadLine();
                                    query = "update contact set country = @country where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@country", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);
                                } while (!validate.ValidCityCountry(value)); //validate country

                                break;
                            case 7:
                                do
                                {
                                    Console.Write("Please enter a home phone number(In format 111-111-1111): ");
                                    value = Console.ReadLine();
                                    query = "update contact set home_phone = @home_phone where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@home_phone", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);

                                } while (!validate.ValidPhoneNumber(value)); //validation for phone number
                                break;
                            case 8:
                                do
                                {
                                    Console.Write("Please enter a work phone number(In format 111-111-1111): ");
                                    value = Console.ReadLine();
                                    query = "update contact set work_phone = @work_phone where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@work_phone", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);
                                } while (!validate.ValidPhoneNumber(value)); //validation for phone number
                                break;
                            case 9:
                                do
                                {

                                    Console.Write("Please enter a mobile phone number(In format 111-111-1111): ");
                                    value = Console.ReadLine();
                                    query = "update contact set mobile_phone = @mobile_phone where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@mobile_phone", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);
                                } while (!validate.ValidPhoneNumber(value)); //validation for phone number
                                break;
                            case 10:
                                do
                                {
                                    Console.Write("Please enter an email: ");
                                    value = Console.ReadLine();
                                    query = "update contact set email = @email where id = @id";
                                    command = new SQLiteCommand(query, m_dbConnection);
                                    command.Parameters.AddWithValue("@email", value);
                                    command.Parameters.AddWithValue("@id", selectedOption);

                                } while (!validate.ValidEmail(value)); //validation for email
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please choose again\n"); //if user enteres an invalid option
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. Please enter an appropriate number\n"); //exception handling, if user enters something other than a number
                    }

                    try
                    {
                        //executing query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    Console.WriteLine("Successfully edited the contact. The updated details are listed below.");

                    query = "Select * from contact where id = @id";
                    command = new SQLiteCommand(query, m_dbConnection);
                    command.Parameters.AddWithValue("@id", selectedOption);
                    reader = command.ExecuteReader();
                    //displaying data
                    while (reader.Read())
                    {
                        Console.WriteLine("\nid: " + reader["id"] + "\nFirst Name: " + reader["f_name"] + "\nLast Name: " + reader["l_name"] + "\naddress: " + reader["address"] + "\nPostal Code: " + reader["postal_code"]
                             + "\nCity: " + reader["city"] + "\nCountry: " + reader["country"] + "\nHome Phone: " + reader["home_phone"] + "\nMobile Phone: " + reader["mobile_phone"] + "\nWork Phone: " + reader["work_phone"] + "\nemail: " + reader["email"] + "\n");
                    }
                    m_dbConnection.Close();
                    Console.WriteLine("Edit another contact? (Y/N)");
                    input = Console.ReadLine();
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Error. Please enter an appropriate number\n"); //exception handling, if user enters something other than a number
                }
            } while (!string.Equals(input, "n", StringComparison.OrdinalIgnoreCase));//making it not case sensitive, similar to equalsignorecase in java 

        }
        /// <summary>
        /// Deleting contact method 
        /// </summary>
        public override void deleteContact()
        {
            String input;
            do
            {
                getAllFromDatabase();
                Console.WriteLine("Please select an ID to delete: ");
                input = Console.ReadLine();
                int selectedOption;

                if (int.TryParse(input, out selectedOption)) //exception handling here, converting to an int, and if not int, it will display message in else statement
                {
                    SQLiteConnection m_dbConnection;
                    m_dbConnection = new SQLiteConnection("Data Source=finalversion.sqlite;Version=3;");
                    //opening database
                    m_dbConnection.Open();
                    SQLiteCommand command;
                    string query = "delete from contact where id = @id";
                    command = new SQLiteCommand(query, m_dbConnection);
                    command.Parameters.AddWithValue("@id", selectedOption);
                    try
                    {
                        //executing query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    Console.WriteLine("Contact successfully deleted. \nThe updated contact list will now display. \nPress any button to continue...\n");
                    Console.ReadKey();
                    getAllFromDatabase();
                    m_dbConnection.Close();
                    Console.WriteLine("Delete another contact? (Y/N)");
                    input = Console.ReadLine();
                    Console.WriteLine("\n");

                }
            } while (!string.Equals(input, "n", StringComparison.OrdinalIgnoreCase));//making it not case sensitive, similar to equalsignorecase in java 
        }
        /// <summary>
        /// Changing Account Behaviour method
        /// </summary>
        /// <returns></returns>
        public override String accountBehaviour()
        {
            return "Admin Account";
        }

    }
}