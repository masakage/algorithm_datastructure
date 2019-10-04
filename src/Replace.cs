//教科書 121ページ　文字列の置換C#プログラム

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace {

    
    class Replace
    {
        static void Main(string[] args)
        {
            //宣言
            string[] T = new string[] { "H", "O", "T", "M", "I", "L", "K", "P", "L", "E", "A", "S","E" };
            string[] P = new string[] { "M", "I", "L" ,"K" };
            string[] Q = new string[] { "T", "E", "A" };
            string[] R = new string[] { "H", "O", "T", "M", "I", "L", "K", "P", "L", "E", "A", "S", "E" ,"X","X"};
            int Tidx, Ridx, Idx, L, M, N;

            Tidx = 0;
            Ridx = 0;
            M = T.Length; //配列名の長さを求める
            N = P.Length; //配列名の長さを求める
            L = Q.Length; //配列名の長さを求める

            while (Tidx <= (M - N))
            {
                Idx = 0;

                while ((Idx < N) && (T[Tidx + Idx] == P[Idx]))
                {
                    Idx = Idx + 1;
                }

                if (Idx >= N)
                {
                    for (int Qidx= 0; Qidx<L; ++Qidx)
                    {
                        R[Ridx] = Q[Qidx];
                        Ridx = Ridx+1;
                    }
                    Tidx = Tidx + N;
                }
                else
                {
                    R[Ridx]=T[Tidx];
                    Ridx = Ridx + 1;
                    Tidx = Tidx + 1;
                }
            }

            while (Tidx <M)
            {
                R[Ridx] = T[Tidx];
                Ridx = Ridx + 1;
                Tidx = Tidx + 1;
            }

            Console.WriteLine(Ridx);

            for (int i=0 ; i<Ridx; ++i)
            {
                Console.Write(R[i]);
            }

            Console.ReadKey();
        }
    }
}
