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
/// Last Modified: Dec.02, 2016
/// </summary>
namespace FinalVersion
{
    /// <summary>
    /// Validation class which validates all the data
    /// </summary>
    public class Validate
    {
        /// <summary>
        /// Validating valid emails
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Please enter an email address.");
                    return false;
                }
                Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"); //regex to match emails
                Match match = regex.Match(email);
                return match.Success; //returning boolean to see if it matches regex
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid email address.");
                return false;
            }

        }
        /// <summary>
        /// Validating any country or city
        /// </summary>
        /// <param name="cityOrCountry"></param>
        /// <returns></returns>
        public bool ValidCityCountry(string cityOrCountry)
        {
            try
            {
                if (string.IsNullOrEmpty(cityOrCountry))
                {
                    Console.WriteLine("Please enter a city or country."); //checking to see if its empty or null
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a city or country.");
                return false;
            }

        }
        /// <summary>
        /// Validating name, either first or last name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ValidateName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name)) //first or last name can't be empty
                {
                    Console.WriteLine("Please enter a name.");
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a name.");
                return false;
            }
        }

        /// <summary>
        /// Validating address(Not yet complete)
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool ValidateAddress(string address)
        {
            try
            {
                if (string.IsNullOrEmpty(address))
                {
                    Console.WriteLine("Please enter an address.");
                    return false;
                }
                Regex regex = new Regex(@"\d{1,3}.?\d{0,3}\s[a-zA-Z]{2,30}\s[a-zA-Z]{2,15}"); //regex to match address, though almost impossible to verify if actual address
                Match match = regex.Match(address);
                return match.Success;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid address.");
                return false;
            }

        }
        /// <summary>
        /// Validating Postal Code
        /// </summary>
        /// <param name="postalCode"></param>
        /// <returns></returns>
        public bool ValidatePostalCode(string postalCode)
        {
            try
            {
                if (string.IsNullOrEmpty(postalCode))
                {
                    Console.WriteLine("Please enter a Postal Code.");
                    return false;
                }
                Regex regex = new Regex(@"^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$"); //regex to match a valid Postal Code
                Match match = regex.Match(postalCode);
                return match.Success;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid postal code.");
                return false;
            }

        }
        /// <summary>
        /// Validating a valid phone number
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool ValidPhoneNumber(string phone)
        {
            try
            {
                if (string.IsNullOrEmpty(phone))
                {
                    Console.WriteLine("Please enter a phone number.");
                    return false;
                }
                Regex regex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"); //regex to match phone number
                Match match = regex.Match(phone);
                return match.Success;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid phone number.");
                return false;
            }

        }

    }
}