using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class Contacts
    {
        public event Action ContactListChanged;
        protected List<Contact> ListOfContacts { get; set; }= new List<Contact>();

        public Contacts()
        {
            ListOfContacts.Add(new Contact("Homer","Simson", 1));
            ListOfContacts.Last().AddNumberToContact(2);
            ListOfContacts.Add(new Contact("Mom", "Simson", 4));
            ListOfContacts.Last().AddNumberToContact(5);
        }
        public void Add(Contact contact)
        {
            if (ListOfContacts.Contains(contact, ContactNameLastNameEqualityComparer.Instance))
                throw new ArgumentException("You already have this contact");

            ListOfContacts.Add(contact);

            if (!ListOfContacts.Contains(contact, ContactNameLastNameEqualityComparer.Instance))
                throw new ArgumentException("Can't add this contact please try again");

            ContactListChanged?.Invoke();
        }
        
        public void Remove(Contact contact)
        {
            var contactToDelete = ListOfContacts.Find(x => x.Name == contact.Name &&
                                                      x.LastName == contact.LastName);
            ListOfContacts.Remove(contactToDelete);

            if (ListOfContacts.Contains(contact, ContactNameLastNameEqualityComparer.Instance))
                throw new Exception("Can't delete this contact please try again");

            ContactListChanged?.Invoke();
        }

        public Contact Get(int number)
        {
            return ListOfContacts.Find(x=>x.HaveThisNumber(number));
        }
    }
}
