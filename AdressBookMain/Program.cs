using System;
using System.Net;

namespace AdressBookMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            bool flag = true;
            int option;
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Enter option: \n 1. Add ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contact contact = new Contact();
                        {
                            Console.WriteLine("Enter first name");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter last name");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter address");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine("Enter city");
                            contact.City = Console.ReadLine();
                            Console.WriteLine("Enter zip");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter phonenumber");
                            contact.PhoneNumber = Console.ReadLine();
                            Console.WriteLine("Enter email");
                            contact.Email = Console.ReadLine();
                        }
                        addressBook.AddContact(contact);
                        break;
                    default:
                        addressBook.Display();
                        break;
                }
            }
        }
    }
}