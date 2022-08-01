
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewContactsAddressBook
{
    class AddressManagment
    {
        List<Person> listOfContacts = new List<Person>();
        public void AddContacts()
        {
            Person person = new Person();
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.Contactnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Email ID: ");
            person.EmailID = Console.ReadLine();
            listOfContacts.Add(person);
        }
        public void DisplayContacts()
        {
            foreach (var data in listOfContacts)
            {
                Console.WriteLine("\nBelow is the details of person in Address Book.");
                Console.WriteLine("\nFirst name : " + data.FirstName + "\nLast name : " + data.LastName + "\nCity : " + data.City + "\nState : " + data.State + "\nZip code : " + data.Zip + "\nMobile Number : " + data.Contactnumber + "\nEmail ID : " + data.EmailID + "\n");
            }
        }


    }

}