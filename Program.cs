﻿using System;
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
            UC4_DeletePersonUsingPersonName addressBook = new UC4_DeletePersonUsingPersonName();
            //getting Op in Constructor with paratmers
            takeInputAndAddToContacts(addressBook);
            takeInputAndAddToContacts(addressBook);
            // called Print method 
            addressBook.print();
            Console.WriteLine("What you want to perform ? Press 1 for Edit the details ,\n Press 2 for Delete  details : ");
            int Selectchoice = Convert.ToInt32(Console.ReadLine());
            switch (Selectchoice)
            {

                case 1:
                    Console.WriteLine("Enter FirstName of Contact to be edited");
                    string firstNameOfContactToBeEdited = Console.ReadLine();
                    Console.WriteLine("Enter LastName of Contact to be edited");
                    string lastNameOfContactToBeEdited = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter FirstName of Contact to be deleted");
                    string firstNameOfContactToBeDeleted = Console.ReadLine();
                    Console.WriteLine("Enter LastName of Contact to be deleted");
                    string lastNameOfContactToBeDeleted = Console.ReadLine();
                    addressBook.delete(firstNameOfContactToBeDeleted, lastNameOfContactToBeDeleted);
                    break;
                default:
                    Console.WriteLine("Please enter the valid number : ");
                    break;
            }
            Console.ReadLine();
        }
        // take Input And Add To Contacts
        public static void takeInputAndAddToContacts(AddressBook addressBook)
        {
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            string email = Console.ReadLine();
            addressBook.addContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            Console.ReadLine();
        }
    }
    
}

    

