using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This is the main class that contains the menu and main method of the program
/// The namespace is the scope, and this class is part of the FinalVersion namespace
/// This project is a contact list, where a user can save contacts to a list. They can currently search a certain contact,
/// view all contacts, or output contact to file. The other features have not been fully impleneted yet.
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{
    /// <summary>
    /// Program class that contains the main method and menu method for the project
    /// </summary>
    class Program
    {


        /// <summary>
        /// This method is the now the new main login menu. Allows for user login
        /// </summary>
        public void LoginMenu()
        {
            do
            {
                Controller controller = new FinalVersion.Controller();
                Console.WriteLine("Please type 1 to login, or 0 to quit");
                String login = Console.ReadLine();
                int option;
                if (int.TryParse(login, out option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter a username: ");
                            String username = Console.ReadLine();
                            Console.WriteLine("Please enter a password: ");
                            String password = Console.ReadLine();
                            if (controller.LoginController(username, password))
                            {
                                if (controller.isAdmin(username, password))
                                {
                                    MainMenu(true);
                                }
                                else
                                {
                                    MainMenu(false);
                                }
                            }

                            break;
                        case 0:
                            Console.WriteLine("Exiting Program...\nPress any button to continue");
                            Console.ReadKey();
                            System.Environment.Exit(1); //exiting program safely
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number.");
                }

            } while (true);
        }
        /// <summary>
        /// This is the main menu method. This contains the main menu, and the corresponding option
        /// </summary>
        public void MainMenu(bool isAdmin)
        {
            NormalUserBehaviour test;
            if (isAdmin)
            {
                test = new AdminUserBehaviour(); //depending if true or false, making it a normal user or admin
            }
            else
            {
                test = new NormalUserBehaviour();

            }
            do //menu always on loop, unless exit
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. Search a contact");
                Console.WriteLine("3. View all contacts");
                Console.WriteLine("4. Edit a contact");
                Console.WriteLine("5. Delete a contact");
                Console.WriteLine("6. Output contact to file");
                Console.WriteLine("7. Exit Program");
                String input = Console.ReadLine();
                int selectedOption;
                int index = 0;
                if (int.TryParse(input, out selectedOption)) //exception handling here, converting to an int, and if not int, it will display message in else statement
                {

                    switch (selectedOption)
                    {
                        case 1: //adding a contact
                            test.addContact();
                            break;
                        case 2:
                            String searchLastName;
                            Console.WriteLine("Enter a Last name to search: ");
                            searchLastName = Console.ReadLine();
                            test.searchContact(searchLastName);
                            break;
                        case 3:
                            test.viewAllContacts();
                            break;
                        case 4:
                            test.editContact();
                            break;
                        case 5:
                            test.deleteContact();
                            break;
                        case 6:
                            test.outputContact();
                            break;
                        case 7:
                            test.exitProgram();
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
            } while (true);
        }

        /// <summary>
        /// Main method of the program. Initializing the main menu
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            new Program().LoginMenu(); //calling login menu
        }
    }
}