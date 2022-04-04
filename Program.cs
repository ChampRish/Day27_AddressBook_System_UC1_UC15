using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("!------Welcome to Address Book system------!");
            //creating object of addressbook
            UC1_CreateAContactInAddressBook address =new UC1_CreateAContactInAddressBook();

            //getting Op in Constructor with paratmers
            address.addContacts("Rishabh", "Gupta", "Agra CAntt", "Agra", "UP", 12345, 01234567890, "abc@gmail.com");
            // called Print method 
            address.print();
            Console.ReadLine();

        }
    }
}
    

