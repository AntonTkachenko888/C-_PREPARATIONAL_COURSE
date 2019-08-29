using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class Contact
    {
        public string Name { get; set; }
        public string LastName  { get; set; }

        private List<int> Numbers { get; set; } = new List<int>();

        public Contact(string name, string lastName,int numbers)
        {
            Name = name;
            LastName = lastName;
            Numbers.Add(numbers);
        }

        public Contact()
        {
        }

        public void AddNumberToContact(int number)
        {
            Numbers.Add(number);
        }
        public bool HaveThisNumber(int number)
        {
            return Numbers.Contains(number);
        }
        public IEnumerable<int> GetAllNumbers(int number)
        {
            return Numbers;
        }
    }
}
