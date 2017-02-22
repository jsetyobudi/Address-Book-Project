using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/// <summary>
/// This class is part of the FinalVersion.test namespace
/// By: Johan Setyobudi 040 671 309
/// CST 8333 FinalProject
/// Last Modified: Dec. 02, 2016
/// </summary>
namespace FinalVersion.Test
{
    /// <summary>
    /// Testing class for NUnit tests
    /// </summary>  
    [TestFixture]
    class Testing
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
        /// Setting up all the variables
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            firstName = "Johan";
            lastName = "Setyobudi";
            address = "123 Main Avenue";
            postalCode = "K2V1P4";
            city = "Ottawa";
            country = "Canada";
            email = "sety0002@algonquinlive.com";
            homePhone = "613-321-4322";
            workPhone = "613-443-2221";
            cellPhone = "613-964-4345";
            id = 1;
            contact = new Contact(id, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email);
            validate = new Validate();


        }
        /// <summary>
        /// Testing first name
        /// </summary>
        [Test]
        public void TestFirstName()
        {

            Assert.AreEqual("Johan", contact.FirstName);
        }
        /// <summary>
        /// Testing last name
        /// </summary>
        [Test]
        public void TestLastName()
        {
            Assert.AreEqual("Setyobudi", contact.LastName);
        }

        /// <summary>
        /// Testing address
        /// </summary>
        [Test]
        public void TestAddress()
        {
            Assert.AreEqual("123 Main Avenue", contact.Address);
        }

        /// <summary>
        /// Testing postal code
        /// </summary>
        [Test]
        public void TestPostalCode()
        {
            Assert.AreEqual("K2V1P4", contact.PostalCode);
        }

        /// <summary>
        /// Testing city
        /// </summary>
        [Test]
        public void TestCity()
        {
            Assert.AreEqual("Ottawa", contact.City);
        }

        /// <summary>
        /// Testing country
        /// </summary>
        [Test]
        public void TestCountry()
        {
            Assert.AreEqual("Canada", contact.Country);
        }

        /// <summary>
        /// Testing home phone number
        /// </summary>
        [Test]
        public void TestHomePhone()
        {
            Assert.AreEqual("613-321-4322", contact.HomePhoneNumber);

        }

        /// <summary>
        /// Testing cell phone number
        /// </summary>
        [Test]
        public void TestCellPhone()
        {
            Assert.AreEqual("613-964-4345", contact.MobilePhoneNumber);
        }

        /// <summary>
        /// Testing work phone number
        /// </summary>
        [Test]
        public void TestWorkPhone()
        {
            Assert.AreEqual("613-443-2221", contact.WorkPhoneNumber);
        }

        /// <summary>
        /// Testing email
        /// </summary>
        [Test]
        public void TestEmail()
        {
            Assert.AreEqual("sety0002@algonquinlive.com", contact.Email);
        }


        /// <summary>
        /// Testing contact id
        /// </summary>
        [Test]
        public void TestContactID()
        {
            int id = 1;
            Assert.AreEqual(id, contact.ContactID);
        }

        /// <summary>
        /// Testing validation for postal code
        /// </summary>
        [Test]
        public void TestValidatePostalCode()
        {
            Assert.AreEqual(validate.ValidatePostalCode(postalCode), validate.ValidatePostalCode(contact.PostalCode));
        }

        /// <summary>
        /// Testing validation for first name
        /// </summary>
        [Test]
        public void TestValidateFirstName()
        {
            Assert.AreEqual(validate.ValidateName(firstName), validate.ValidateName(contact.FirstName));
        }
        /// <summary>
        /// Testing validation for last name
        /// </summary>
        [Test]
        public void TestValidateLastName()
        {
            Assert.AreEqual(validate.ValidateName(lastName), validate.ValidateName(contact.LastName));
        }
        /// <summary>
        /// Testing validation for email
        /// </summary>
        [Test]
        public void TestValidateEmail()
        {
            Assert.AreEqual(validate.ValidEmail(email), validate.ValidEmail(contact.Email));
        }

        /// <summary>
        /// Testing validation for home phone number
        /// </summary>
        [Test]
        public void TestValidateHomePhone()
        {
            Assert.AreEqual(validate.ValidPhoneNumber(homePhone), validate.ValidPhoneNumber(contact.HomePhoneNumber));
        }
        /// <summary>
        /// Testing validation for work phone number
        /// </summary>
        [Test]
        public void TestValidateWorkPhone()
        {
            Assert.AreEqual(validate.ValidPhoneNumber(workPhone), validate.ValidPhoneNumber(contact.WorkPhoneNumber));
        }
        /// <summary>
        /// Testing validation for cell phone number
        /// </summary>
        [Test]
        public void TestValidateCellPhone()
        {
            Assert.AreEqual(validate.ValidPhoneNumber(cellPhone), validate.ValidPhoneNumber(contact.MobilePhoneNumber));
        }




        /// <summary>
        /// Tear down, setting everything to null
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            firstName = null;
            lastName = null;
            address = null;
            city = null;
            country = null;
            email = null;
            homePhone = null;
            workPhone = null;
            cellPhone = null;
            contact = null;
            validate = null;
        }
    }
}