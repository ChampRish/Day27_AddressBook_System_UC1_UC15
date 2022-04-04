using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_AddressBookSystem
{
     class UC1_CreateAContactInAddressBook
     {
        private List<Contact> contactList;

        public void AddressBook()
        {
            contactList = new List<Contact>();
        }

        public void addContacts(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            //Create object of Contact class
            Contact contact = new Contact();
            //calling Varivale using object
            contact.firstname = firstName;
            contact.lastname = lastName;
            contact.address = address;
            contact.city = city;
            contact.state = state;
            contact.zip = zip;
            contact.phonenumber = phoneNumber;
            contact.emailid = email;
            //adding contact details in contact list 
            contactList.Add(contact);
        }
        //method print
        public void print()
        {
            //using foreach loop for calling the variable 
            foreach (Contact contact in contactList)
            {
                //Prinitng the Op
                Console.WriteLine("FirstName: " + contact.firstname);
                Console.WriteLine("LastName: " + contact.lastname);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("Zip: " + contact.zip);
                Console.WriteLine("PhoneNumber: " + contact.phonenumber);
                Console.WriteLine("Email id: " + contact.emailid);
            }
        }
    }
}
