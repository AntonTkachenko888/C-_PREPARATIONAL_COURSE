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

        private List<int> Nambers { get; set; }

        public void AddNumberToContact(int number)
        {
            Nambers.Add(number);
        }
        public IEnumerable<int> GetAllNumbers(int number)
        {
            return Nambers;
        }
    }
}
