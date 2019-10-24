//教科書 126ページ　文字列の圧縮C#プログラム
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLength
{
    class RunLength
    {
        static void Main(string[] args)
        {
            //宣言
            string[] T = new string[] { "A", "A", "B", "B", "B", "B", "C", "C", "D", "A", "A", "A", "A" };
            string[] R = new string[] { "H", "O", "T", "M", "I", "L", "K", "P", "L", "E", "A", "S", "E" };
            int Tidx, Ridx, Cnt, N;
            string Char;

            Tidx = 0;
            Ridx = 0;
            N = T.Length; //配列名の長さを求める

            Console.WriteLine("圧縮前の文字数 "+T.Length);//圧縮前の文字数

            for (int i = 0; i < N; ++i) //圧縮前の文字列
            {
                Console.Write(T[i]);
            }
            Console.WriteLine();

            while (Tidx < N)
            {
                Char = T[Tidx];
                Cnt = 0;

                while ((Tidx < N) && (T[Tidx].Equals(Char))) //文字列の比較 Equalsクラス
                {
                    Tidx = Tidx + 1;
                    Cnt = Cnt + 1;
                }

                if (Cnt >= 4)
                {
                    R[Ridx] = "\\";
                    R[Ridx + 1] = Char;
                    R[Ridx + 2] = Cnt.ToString();
                    Ridx = Ridx + 3;
                }
                else
                {
                    while (Cnt > 0)
                    {
                        R[Ridx] = Char;
                        Ridx = Ridx + 1;
                        Cnt = Cnt - 1;
                    }
                }
            }

            Console.WriteLine("圧縮後の文字数 "+Ridx);//圧縮後の文字数
            for (int i = 0; i < Ridx; ++i)
            {
                Console.Write(R[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}