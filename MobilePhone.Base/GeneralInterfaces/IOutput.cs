using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.GeneralInterfaces
{
    public interface IOutput
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
