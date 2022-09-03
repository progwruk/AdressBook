using System;
namespace AdressBookMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Contact contact = new Contact()
            {
                FirstName="Wrukshali",
                LastName="Meshram",
                Address="Bhadrawati",
                City="Chandrapur",
                Zip=442501,
                PhoneNumber="+910485458907",
                Email="abc@gmail.com"
            };
            Console.WriteLine("FirstName: "+contact.FirstName+"\n"+ "LastName: "+contact.LastName+"\n" +"Address: "+contact.Address+"\n"+"City: "+contact.City+"\n"+"Zip: "+contact.Zip+"\n"+"PhoneNumber: "+contact.PhoneNumber+"\n"+"Email: "+contact.Email);
        }
    }
}