using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class CustomExcepsion : ApplicationException
    {
        public CustomExcepsion(string message) : base(message)
        {

        }

    }
}
