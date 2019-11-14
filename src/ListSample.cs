//教科書 139ページ　リスト要素の探索
//Listを使って 教科書　139ページの内容を書き直し
//あらかじめ配列の長さを定義しなくてもよい


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample
{
    class ListSample
    {
        static void Main(string[] args)
        {
            var strList = new List<string>();
            strList.Add("Abe");
            strList.Add("Ikeda");
            strList.Add("Ootani");
            strList.Add("Sato");
            strList.Add("Tanaka");
            strList.Add("Yamada");

            //表示メソッド（関数)
            disp(strList);

            //1件データを追加
            strList.Add("Yamaguchi");

            //表示メソッド（関数)
            disp(strList);

            //要素3を削除
            strList.RemoveAt(3);

            //表示メソッド（関数)
            disp(strList);

            //探索 "Tanaka”は存在するか
            Console.WriteLine(strList.Contains("Tanaka"));

            Console.WriteLine();
            Console.ReadKey();
        }

        //リストの件数と内容を表示する
        public static void disp(List<string > ls)
        {
            Console.Write("(" + ls.Count() + ")\t");//件数
            foreach (string str in ls)
            {
                Console.Write(str + "\t");//内容を表示
            }
            Console.WriteLine("");

        }

    }
}
