namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add\n ");
            Console.WriteLine("Please Enter Your Choice : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Addressbook addressbook = new Addressbook();
                    addressbook.AddContact();
                    break;

                default:
                    break;
            }
        }
    }
}