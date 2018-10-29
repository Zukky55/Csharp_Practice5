using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public enum Subject
    {
        English,Japanese
    }

    /// <summary>
    /// テスト結果を保持するクラス
    /// </summary>
    public static class ResultList
    {
        /// <summary>実行中記録を保持する為にstaticでテスト結果を保存する変数</summary>
        public static List<Student> Students { get; private set; }
        

        static ResultList()
        {
            Students = new List<Student>();
        }

        public static int GetAvarage(Subject subject)
        {
            int totalScore = 0;
            int count = 0;
            int avarage;

            switch (subject)
            {
                case Subject.English:

                    foreach (var student in Students)
                    {
                        totalScore += student.English;
                        count++;
                    }
                    avarage = totalScore / count;
                    return avarage;
                case Subject.Japanese:
                    foreach (var student in Students)
                    {
                        totalScore += student.Japanese;
                        count++;
                    }
                    avarage = totalScore / count;
                    return avarage;
                default:
                    throw new Exception("The argument is illegal."); //引数が登録された科目以外の場合エラーを投げる
            }
        }
    }
}
