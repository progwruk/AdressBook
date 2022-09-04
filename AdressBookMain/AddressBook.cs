using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookMain
{
    internal class AddressBook
    {
        List<Contact> contacts=new List<Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void Display()
        {
            foreach(var contact in contacts)
            {
                Console.WriteLine(contact.FirstName+"\n"+contact.LastName+"\n"+contact.Address+"\n"+contact.City+"\n"+contact.Zip+"\n"+contact.PhoneNumber+"\n"+contact.Email);
            }
        }
    }
}
