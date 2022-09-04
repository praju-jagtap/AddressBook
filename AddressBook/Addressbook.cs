using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Addressbook
    {
        List<Contact> contacts=new List<Contact>();
        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Enter FirstName: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip: ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNo: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("The New Contact Added is: \n");
            Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);
            Console.ReadKey();
        }
    }
}
