using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// Startableオブジェクトを返すクラス
    /// </summary>
    public class StartableFactory
    {
        public IStartable Create(string input)
        {
            if(!int.TryParse(input, out int value))
            {
                return new InputException();
            }
            switch(value)
            {
                case 1:
                    return new Registration();
                case 2:
                    return new Display();
                case 3:
                    return new EndProgram();
                default:
                    return new InputException();
            }
        }
    }
}
