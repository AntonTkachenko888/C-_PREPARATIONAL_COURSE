﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public interface IPhoneCall: ICall
    {
        Contact Contact { get; set; }
    }
}
