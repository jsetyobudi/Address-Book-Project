using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/// <summary>
/// This class is part of the BetaPrototype namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion
{
    /// <summary>
    /// Contact class, holds a single contact with all their informaton
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// First Name
        /// </summary>
        private string firstName;
        /// <summary>
        /// Last Name
        /// </summary>
        private string lastName;
        /// <summary>
        /// Address
        /// </summary>
        private string address;
        /// <summary>
        /// Postal Code
        /// </summary>
        private string postalCode;
        /// <summary>
        /// City
        /// </summary>
        private string city;
        /// <summary>
        /// Country
        /// </summary>
        private string country;
        /// <summary>
        /// Home Phone Number
        /// </summary>
        private string homePhoneNumber;
        /// <summary>
        /// Cell Phone Number
        /// </summary>
        private string mobilePhoneNumber;
        /// <summary>
        /// Work Phone Number
        /// </summary>
        private string workPhoneNumber;
        /// <summary>
        /// Email 
        /// </summary>
        private string email;
        /// <summary>
        /// Contact ID
        /// </summary>
        private int contactID;
        /// <summary>
        /// Country for the id
        /// </summary>
        private static int idHelper = 0;

        /// <summary>
        /// Constructor to place all the data in
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="postalCode"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="homePhoneNumber"></param>
        /// <param name="mobilePhoneNumber"></param>
        /// <param name="workPhoneNumber"></param>
        /// <param name="email"></param>
        public Contact(int id, string firstName, string lastName, string address, string postalCode, string city, string country, string homePhoneNumber, string mobilePhoneNumber, string workPhoneNumber, string email)
        {
            //	this.ContactID = ++idHelper;
            this.contactID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
            this.homePhoneNumber = homePhoneNumber;
            this.mobilePhoneNumber = mobilePhoneNumber;
            this.workPhoneNumber = workPhoneNumber;
            this.email = email;
        }

        /// <summary>
        /// Getter/Setter for Last Name
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        /// <summary>
        /// Getter/Setter for First Name
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Address
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        /// <summary>
        /// Getter/Setter for City
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Country
        /// </summary>
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Home Phone Number
        /// </summary>
        public string HomePhoneNumber
        {
            get
            {
                return homePhoneNumber;
            }

            set
            {
                homePhoneNumber = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Mobile phone number
        /// </summary>
        public string MobilePhoneNumber
        {
            get
            {
                return mobilePhoneNumber;
            }

            set
            {
                mobilePhoneNumber = value;
            }
        }

        /// <summary>
        /// Getter/Setter for Work Phone Number
        /// </summary>
        public string WorkPhoneNumber
        {
            get
            {
                return workPhoneNumber;
            }

            set
            {
                workPhoneNumber = value;
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
        /// Getter/Setter for Contact ID
        /// </summary>
        public int ContactID
        {
            get
            {
                return contactID;
            }

            set
            {
                contactID = value;
            }
        }
        /// <summary>
        /// Getter/Setter for Postal Code
        /// </summary>
        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        /// <summary>
        /// Override the default ToString method to display data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "First Name: " + firstName + "\nLast Name: " + lastName + "\nAddress: " + address + "\nPostal Code: " + postalCode + "\nCity: " + city + "\nCountry: " + country + "\nHome Phone Number: " + homePhoneNumber
                + "\nCell Phone Number: " + mobilePhoneNumber + "\nWork Phone Number: " + workPhoneNumber + "\nEmail: " + email + "\nContact ID: " + contactID;
        }

    }
}