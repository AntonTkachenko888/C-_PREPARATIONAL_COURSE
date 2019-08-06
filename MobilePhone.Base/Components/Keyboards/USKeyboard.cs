using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Keyboards
{
    public class USKeyboard: KeyboardBase
    {
        private readonly string vType = "US";
        public override string Type {get { return vType; }
        }
        public override string ToString()
        {
            return "USKeyboard";
        }
    }
}
