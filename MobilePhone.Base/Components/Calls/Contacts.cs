using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            var c1 = new Contact("Homer", "Simson", 1);
            c1.ContactChanged += ContactChangedInvoke;
            ListOfContacts.Add(c1);
            ListOfContacts.Last().AddNumberToContact(2);

            var c2 = new Contact("Mom", "Simson", 4);
            c2.ContactChanged += ContactChangedInvoke;
            ListOfContacts.Add(c2);
            ListOfContacts.Last().AddNumberToContact(5);
        }
        public void Add(Contact contact)
        {
            if (ListOfContacts.Contains(contact, ContactNameLastNameEqualityComparer.Instance))
                throw new ArgumentException("You already have this contact");

            contact.ContactChanged += ContactChangedInvoke;
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
            contactToDelete.ContactChanged -= ContactChangedInvoke;

            if (ListOfContacts.Contains(contact, ContactNameLastNameEqualityComparer.Instance))
                throw new Exception("Can't delete this contact please try again");

            ContactListChanged?.Invoke();
        }

        public Contact Get(int number)
        {
            return ListOfContacts.Find(x=>x.HaveThisNumber(number));
        }
        public Contact Get(string name,string lastName)
        {
            return ListOfContacts.Find(x => 
                    x.Name.ToUpper()== name.ToUpper() && 
                    x.LastName.ToUpper() == lastName.ToUpper()
            );
        }
        public IEnumerable<string> Get()
        {
            return (from c in ListOfContacts
                   select ""+c.Name+" "+c.LastName).ToList();
        }

        public void ContactChangedInvoke()
        {
            ContactListChanged?.Invoke();
        }
    }
}
