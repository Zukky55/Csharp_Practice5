using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// プログラムを終了させる
    /// </summary>
    public class EndProgram : IStartable
    {
        public void Start()
        {
            End();
        }

        private void End()
        {
            Console.WriteLine("Good luck.");
            Environment.Exit(0); //プログラム終了
        }
    }
}
