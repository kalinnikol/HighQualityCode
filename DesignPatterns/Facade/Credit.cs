﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Check credit for " + customer.Name);

            return true;
        }
    }
}
