using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var mainMenu = new MainMenu();

            while(true)
            {
                mainMenu.Display();
            }
        }
    }
}
