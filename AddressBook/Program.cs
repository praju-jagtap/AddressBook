namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "Prajakta",
                LastName = "Jagtap",
                Address = "M.J.Road",
                City = "Pune",
                State = "Maharastra",
                Zip = 412210,
                PhoneNumber = "8329011606",
                Email = "xyz@gmail.com"
            };
            Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);
        }
    }
}