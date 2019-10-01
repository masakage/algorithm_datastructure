//教科書 113ページ　文字列の照合プログラム

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class PatternMatching
    {
        static void Main(string[] args)
        {
            //宣言
            string[] T = new string[] { "T","T","A","G","G","G" };
            string[] P = new string[] { "T","A","G"};
            int Head, Idx, Match,M,N;

            Head = 0;
            Match = -1;
            M = T.Length; //配列名の長さを求める
            N = P.Length; //配列名の長さを求める

            while ((Match == -1) && (Head <= M - N)){
                Idx = 0;

                while ((Idx < N) && (T[Head + Idx] == P[Idx])){
                    Idx = Idx + 1;
                }

                if (Idx >= N) { 
                    Match = Head;
                }
                else { 
                    Head = Head + 1;
                }
            }

            Console.WriteLine(Match);
            Console.ReadKey();
        }
    }
