
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewContactsAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressManagment addressmanagment = new AddressManagment();
            int option;
            do
            {
                Console.WriteLine("Please choose number as shown below\n1:Add Contacts.\n2:Display Contacts.\n3:Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressmanagment.AddContacts();
                        break;
                    case 2:
                        addressmanagment.DisplayContacts();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            } while (option != 3);
            Console.ReadLine();
        }
    }
}