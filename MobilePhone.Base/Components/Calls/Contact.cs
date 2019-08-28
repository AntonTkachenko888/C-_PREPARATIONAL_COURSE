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

        public List<int> Nambers { get; set; }

        public void AddNumberToContact(Contact contact, int number)
        {

        }
    }
}
