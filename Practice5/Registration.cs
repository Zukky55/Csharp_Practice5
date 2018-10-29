using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice5
{
    /// <summary>
    /// テスト結果を登録するクラス
    /// </summary>
    public class Registration : IStartable
    {
        /// <summary>0~99 or 100</summary>
        private readonly Regex ScoreRegex = new Regex("[1]{0,1}[0-9]{1,2}|100");
        /// <summary>英数字,ひらがな,カタカナを1~10文字以内</summary>
        private readonly Regex NameRegex = new Regex("[0-9a-zA-zぁ-んア-ヴ]{1,10}");

        public void Start()
        {
            while (true)
            {
                var name = InputName();
                var english = InputScore("English");
                var japanese = InputScore("Japanese");
                ResultList.Students.Add(new Student(name, english, japanese)); //テスト結果をリストに追加する
                if(new Confirmation().Continuation()) //追加で入力するか確認をとる
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        ///名前入力
        /// </summary>
        /// <returns>名前</returns>
        private string InputName()
        {
            while(true)
            {
                Console.WriteLine("Please enter within 10 characters.\nName : ");
                var input = Console.ReadLine();
                if (NameRegex.IsMatch(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input, Type it again.");
                }
            }
        }

        /// <summary>
        /// 点数入力。
        /// 引数の科目名に応じてコンソールに表示させる文言を変える。
        /// これイケてない気感がすごい。
        /// </summary>
        /// <param name="subject">科目</param>
        /// <returns>点数</returns>
        private int InputScore(string subject)
        {
            while (true)
            {
                Console.WriteLine(subject + " score : ");
                var input = Console.ReadLine();
                if (ScoreRegex.IsMatch(input))
                {
                    return int.Parse(input);
                }
                else
                {
                    Console.WriteLine("Invalid input, Type it again.");
                }
            }
        }
    }
}
