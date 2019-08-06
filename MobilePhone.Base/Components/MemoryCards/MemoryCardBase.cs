using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.MemoryCards
{
    public abstract class MemoryCardBase
    {
        public abstract int Space { get; }

        protected string vMemory = "";
        public virtual string Memory
        {
            get { return vMemory; }
            set
            {
                if (value != "")
                {
                    if (vMemory.Length + value.Length < Space)
                    {
                        vMemory += value;
                    }
                    else
                    {
                        throw new Exception("Don't have anough space");
                    }
                }
                else
                {
                    throw new Exception("Value can't be empty");
                }
            }
        }
    }
}
