using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class Display : IStartable
    {
        public void Start()
        {
            Console.WriteLine("Average of Japanese is " + ResultList.GetAvarage(Subject.Japanese));
            Console.WriteLine("Average of English is " + ResultList.GetAvarage(Subject.English));
            Console.WriteLine("Number of  passing person counted of Japanese is " + Judgment.GetJapanesePassingCount());
            Console.WriteLine("Number of  passing person counted of English is " + Judgment.GetEnglishPassingCount(ResultList.GetAvarage(Subject.English)));
        }
    }
}
