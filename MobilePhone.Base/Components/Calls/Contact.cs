using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class Contact
    {
        public event Action ContactChanged;
        public string Name { get; set; }
        public string LastName  { get; set; }

        private List<int> Numbers { get; set; } = new List<int>();

        public Contact() { }
        public Contact(string name, string lastName)
            :this()
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentOutOfRangeException("You missed contact name!");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentOutOfRangeException("You missed contact last name!");
            Name = name;
            LastName = lastName;
        }
        public Contact(string name, string lastName,int numbers)
            : this(name, lastName)
        {
            Numbers.Add(numbers);
        }
        
        public void AddNumberToContact(int number)
        {
            Numbers.Add(number);

            ContactChanged?.Invoke();
        }
        public bool HaveThisNumber(int number)
        {
            return Numbers.Contains(number);
        }
        public string GetAllNumbers()
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in Numbers)
            {
                s.Append(item + Environment.NewLine);
            }
            return s.ToString();
        }
    }
}
