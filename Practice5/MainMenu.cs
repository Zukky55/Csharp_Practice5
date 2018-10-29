using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice5
{
    public class MainMenu
    {
        public void Display()
        {
            Console.WriteLine("1:Registration,2:Display result,3:End program");
            var input = Console.ReadLine();
            var startableFactory = new StartableFactory();
            var iStartable = startableFactory.Create(input);
            iStartable.Start();
        }
    }
}