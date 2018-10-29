using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class InputException : IStartable
    {
        public void Start()
        {
            Console.WriteLine("The input is invalid, Please enter the specified value.");
        }
    }
}
