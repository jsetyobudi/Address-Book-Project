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
    /// User Behaviour Interface
    /// </summary>
    public interface UserBehaviour
    {
        /// <summary>
        /// Abstract method for adding contact
        /// </summary>
        void addContact();
        /// <summary>
        /// Abstract method for searching contact
        /// </summary>
        /// <param name="name"></param>
        void searchContact(String name);
        /// <summary>
        /// Abstract method for viewing all contacts
        /// </summary>
        void viewAllContacts();
        /// <summary>
        /// Abstract method for editing contacts
        /// </summary>
        void editContact();
        /// <summary>
        /// Abstract method for deleting contacts
        /// </summary>
        void deleteContact();
        /// <summary>
        /// Abstract method for outputting contacts to file
        /// </summary>
        void outputContact();
        /// <summary>
        /// Abstract method for exiting program
        /// </summary>
        void exitProgram();
        /// <summary>
        /// Abstract method for changing account behaviour
        /// </summary>
        /// <returns></returns>
        String accountBehaviour();
    }
}
