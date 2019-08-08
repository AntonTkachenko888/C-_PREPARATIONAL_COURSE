using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.UnitTestProject
{
    public class FakeOutput: IOutput
    {
        private string output;
        public string Output{get { return output; }}


        public void Write(string text)
        {
            output = output + text;
        }

        public void WriteLine(string text)
        {
            output = output +"\n"+ text;
        }

        public void Clean()
        {
            output = "";
        }
    }
}
