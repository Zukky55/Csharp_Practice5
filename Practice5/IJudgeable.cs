using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class Judgment
    {
        /// <summary>英語の合格ライン</summary>
        public static int passingScoreOfEnglish = 0;
        /// <summary>国語の合格ライン</summary>
        public static int passingScoreOfJapanese = 80;

        /// <summary>
        /// 科目「英語」合格者数を返す
        /// </summary>
        /// <param name="score">テストの点数</param>
        /// <returns></returns>
        public static int GetEnglishPassingCount(int score)
        {
            var successfulCount = 0;
            foreach (var student in ResultList.Students)
            {
                if (student.English >= ResultList.GetAvarage(Subject.English))
                {
                    successfulCount++;
                }
            }
            return successfulCount;
        }

        /// <summary>
        /// 科目「国語」合格者数を返す
        /// </summary>
        /// <param name="score">テストの点数</param>
        /// <returns></returns>
        public static int GetJapanesePassingCount()
        {
            var successfulCount = 0;
            foreach (var student in ResultList.Students)
            {
                if (student.Japanese >= passingScoreOfJapanese)
                {
                    successfulCount++;
                }
            }
            return successfulCount;
        }
    }
}
