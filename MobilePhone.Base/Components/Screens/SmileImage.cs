using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class SmileImage:IScreenImage
    {
        private readonly string vSmileImage = "Smile";
        public string Image { get { return vSmileImage; } }
        
    }
}
