using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
            Console.WriteLine($"Contact {contact}, added to phone book");
        }

        public void RemoveContact(string contactName)
        {
            var contactToRemove = Contacts.FirstOrDefault(c => c.Name == contactName);
            if (contactToRemove == null)
            {
                Console.WriteLine($"Contact: {contactName}, doesn't exist in phone book");
            }
            else
            {
                Contacts.Remove(contactToRemove);
                Console.WriteLine($"Contact: {contactName}, removed from phone book");
            }
        }

        public void EditContact(string contactName, Contact newContact)
        {
            var contactToRemove = Contacts.FirstOrDefault(c => c.Name == contactName);
            if (contactToRemove == null)
            {
                Console.WriteLine($"Contact: {contactName}, doesn't exist in phone book");
            }
            else
            {
                contactToRemove.Name = newContact.Name;
                contactToRemove.PhoneNumber = newContact.PhoneNumber;

                Console.WriteLine($"Contact: {contactName}, updated");
            }
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("All contacts:");
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"Contact: {contact}");
            }
        }
        public void DisplayContact(string contactName)
        {
            var contact = Contacts.FirstOrDefault(c => c.Name == contactName);
            if (contact == null)
            {
                Console.WriteLine($"Contact: {contactName}, doesn't exist in phone book");
            }
            else
            {
                Console.WriteLine($"Contact details: {contact}");
            }
        }

        public void SearchContactsForNumber(string phoneNumber)
        {
            var matchingContacts = Contacts.Where(c => c.PhoneNumber.Contains(phoneNumber)).ToList();

            if (matchingContacts.Any())
            {
                Console.WriteLine("Matching contacts:");
                foreach (var matchingContact in matchingContacts)
                {
                    Console.WriteLine($"Contact: {matchingContact}");
                }
            }
            else
            {
                Console.WriteLine($"No matching contacts found, for {phoneNumber}");
            }
        }

        public void SearchContactsForName(string contactName)
        {
            var matchingContacts = Contacts.Where(c => c.Name.ToLower().Contains(contactName.ToLower())).ToList();

            if (matchingContacts.Any())
            {
                Console.WriteLine("Matching contacts:");
                foreach (var matchingContact in matchingContacts)
                {
                    Console.WriteLine($"Contact: {matchingContact}");
                }
            }
            else
            {
                Console.WriteLine($"No matching contacts found, for {contactName}");
            }
        }

    }
}
