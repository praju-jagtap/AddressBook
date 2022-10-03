using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Addressbook
    {
        List<Contact> contacts = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Display();
        }
        public void Display()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);
                Console.WriteLine("------------------------------------\n");
            }
        }
        
        public void EditContact(string name)
        {
            foreach (var contact in contacts)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("-----------------------------\n");
                    Console.WriteLine("Enter The Option Which You Can Edit : ");
                    Contact contact1 = new Contact();
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter LastName to Edit");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Address to Edit");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter City to Edit");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter State to Edit");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Zip to Edit");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter PhoneNo to Edit");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Email to Edit");
                            contact.Email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Enter the Valid Option");
                            break;
                    }
                    Console.WriteLine("------- Edited Contact List --------");
                    Display();
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in contacts)
            {
                if (contact.FirstName == name)
                {
                    delete = contact;
                }
            }
            contacts.Remove(delete);
        }
    }
}