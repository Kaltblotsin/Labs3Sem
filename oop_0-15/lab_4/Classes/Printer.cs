using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_4.Classes
{
    public class Printer : IObject
    {
        public void IAmPrinting(IObject obj)
        {
            Console.WriteLine(Convert.ToString(obj.GetType()));
            Console.WriteLine(obj.ToString());
        }
    }
}