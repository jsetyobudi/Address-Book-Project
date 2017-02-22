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
namespace FinalVersion.test
{
    /// <summary>
    /// Testing collections 
    /// </summary>
    [TestFixture]
    class CollectionsTest
    {
        /// <summary>
        /// Actual contact list
        /// </summary>
        private List<Contact> contactList;
        /// <summary>
        /// Testing list
        /// </summary>
        private List<Contact> testing;

        [SetUp]
        public void SetUp()
        {
            contactList = new List<Contact>();
            testing = new List<Contact>();
            string firstName = "Johan";
            string lastName = "Setyobudi";
            string address = "123 Main Avenue";
            string postalCode = "K2V1P4";
            string city = "Ottawa";
            string country = "Canada";
            string email = "sety0002@algonquinlive.com";
            string homePhone = "613-321-4322";
            string workPhone = "613-443-2221";
            string cellPhone = "613-964-4345";
            testing.Add(new Contact(1, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email));
            contactList.Add(new Contact(1, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email));

            firstName = "aaa";
            lastName = "bbb";
            address = "123 Main Avenue";
            postalCode = "K2V1P4";
            city = "Ottawa";
            country = "Canada";
            email = "sety0002@algonquinlive.com";
            homePhone = "613-321-4322";
            workPhone = "613-443-2221";
            cellPhone = "613-964-4345";
            testing.Add(new Contact(2, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email));
            contactList.Add(new Contact(2, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email));

            firstName = "zzz";
            lastName = "zzz";
            address = "123 Main Avenue";
            postalCode = "K2V1P4";
            city = "Ottawa";
            country = "Canada";
            email = "sety0002@algonquinlive.com";
            homePhone = "613-321-4322";
            workPhone = "613-443-2221";
            cellPhone = "613-964-4345";
            testing.Add(new Contact(3, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email));
            contactList.Add(new Contact(3, firstName, lastName, address, postalCode, city, country, homePhone, cellPhone, workPhone, email));

        }

        /// <summary>
        /// Testing sorting by first name
        /// </summary>
        [Test]
        public void TestSorting()
        {
            //sorting by first name
            List<Contact> sortedList = contactList;
            sortedList.Sort(
            delegate (Contact c1, Contact c2)
            {
                return c1.FirstName.CompareTo(c2.FirstName);
            }
            );
            //sorting by first name
            var sorted = contactList.OrderBy(s => s.FirstName);

            CollectionAssert.AreEqual(sorted.ToList(), sortedList.ToList());

        }

        /// <summary>
        /// Testing Iterating 
        /// </summary>
        [Test]
        public void TestIterator()
        {
            //Since there is a static id helper that auto increments, everything inside will be the same but the id. It will alwways increase,
            //so one way to test is to see how many objects are inside the collection.
            Assert.AreEqual(testing.Count(), contactList.Count());

        }

    }
}
