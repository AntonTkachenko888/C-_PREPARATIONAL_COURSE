using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.MemoryCards
{
    public class MemoryCardInRows:MemoryCardBase
    {
        private readonly int vSpace = 250;
        public override int Space { get { return vSpace; } }
        public override string Memory
        {
            get { return vMemory; }
            set
            {
                if (value != "")
                {
                    if (vMemory.Length + value.Length < Space)
                    {
                        vMemory += value+"\n";
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
        public override string ToString()
        {
            return "MemoryCardInRows";
        }
    }
}
