using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PhoneBookOperator
    {
        public PhoneBook PhoneBook { get; set; } = new PhoneBook();

        public void Process(PhoneBookOperation operation)
        {
            switch (operation)
            {
                case PhoneBookOperation.AddContact:
                    AddContact();
                    break;
                case PhoneBookOperation.EditContact:
                    EditContact();
                    break;
                case PhoneBookOperation.DisplayAllContacts:
                    DisplayAllContacts();
                    break;
                case PhoneBookOperation.RemoveContact:
                    RemoveContact();
                    break;
                case PhoneBookOperation.SearchName:
                    SearchName();
                    break;
                case PhoneBookOperation.SearchPhoneNumber:
                    SearchPhoneNumber();
                    break;
                case PhoneBookOperation.DisplayContact:
                    DisplayContact();
                    break;
            }
        }

        private void DisplayContact()
        {
            Console.WriteLine("Insert contact name to be displayed:");
            var contactName = Console.ReadLine();
            PhoneBook.DisplayContact(contactName);
        }

        private void SearchPhoneNumber()
        {
            Console.WriteLine("Insert contact phone number to be searched:");
            var phoneNumber = Console.ReadLine();
            PhoneBook.SearchContactsForNumber(phoneNumber);
        }

        private void SearchName()
        {
            Console.WriteLine("Insert contact name to be searched:");
            var contactName = Console.ReadLine();
            PhoneBook.SearchContactsForNumber(contactName);
        }

        private void RemoveContact()
        {
            Console.WriteLine("Insert contact name to be removed:");
            var contactName = Console.ReadLine();
            PhoneBook.RemoveContact(contactName);
        }

        private void DisplayAllContacts()
        {
            PhoneBook.DisplayAllContacts();
        }

        private Contact ReadFromConsole()
        {
            Console.WriteLine("Insert a new contact in the following format:");
            Console.WriteLine("name phonenumber");
            var input = Console.ReadLine();
            var name = input.Split(" ")[0];
            var number = input.Split(" ")[1];
            return new Contact(name, number);
        }

        private void EditContact()
        {
            Console.WriteLine("Insert contact name to be edited:");
            var contactName = Console.ReadLine();

            var contact = ReadFromConsole();
            PhoneBook.EditContact(contactName, contact);

        }

        private void AddContact()
        {
            var contact = ReadFromConsole();
            PhoneBook.AddContact(contact);
        }

        
    }
}
