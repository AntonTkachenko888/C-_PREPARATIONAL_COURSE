using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.MemoryCards
{
    public class MemoryCardInLine:MemoryCardBase
    {
        private readonly int vSpace = 250;
        public override int Space { get { return vSpace; } }
        public override string ToString()
        {
            return "MemoryCardInLine";
        }
    }
}
