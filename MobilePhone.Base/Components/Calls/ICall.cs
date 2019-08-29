using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public interface ICall
    {
        int PhoneNamber { get; set; }
        CallDirection CallDirection { get; set; }
        DateTime StartTime { get; set; }
        TimeSpan CallTime { get; set; }
    }
}
