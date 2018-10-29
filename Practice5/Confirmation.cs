using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// コンソールに確認画面を出すクラス
    /// </summary>
    public class Confirmation
    {
        public bool Continuation()
        {
            while (true)
            {
                Console.WriteLine("Do you want to enter additional? Y/N or y/n");
                var input = Console.ReadLine();
                if (Regex.IsMatch(input, "[Yy]"))
                {
                    return true;
                }
                else if(Regex.IsMatch(input, "[Nn]"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input, Type it again.");
                    continue;
                }
            }
        }
    }
}
