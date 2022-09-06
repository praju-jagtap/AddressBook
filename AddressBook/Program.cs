﻿namespace AddressBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Add\n");
                Console.WriteLine("Please Enter Your Choice : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Addressbook addressbook = new Addressbook();
                        Contact contact = new Contact();
                        {
                            Console.WriteLine("----------------------------\n");
                            Console.WriteLine("Enter FirstName: ");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter LastName: ");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter Address: ");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine("Enter City: ");
                            contact.City = Console.ReadLine();
                            Console.WriteLine("Enter state: ");
                            contact.State = Console.ReadLine();
                            Console.WriteLine("Enter Zip: ");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PhoneNumber: ");
                            contact.PhoneNumber = Console.ReadLine();
                            Console.WriteLine("Enter Email: ");
                            contact.Email = Console.ReadLine();
                        }
                        Console.WriteLine("------- Display Added Contact -------");
                        addressbook.AddContact(contact);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}