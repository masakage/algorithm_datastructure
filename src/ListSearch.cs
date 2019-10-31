//教科書 139ページ　リスト要素の探索

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSearch
{

    public struct Syain
    {
        public string Key;
        public int Next;

    }

    class ListSearch
    {
        static void Main(string[] args)
        {
            //宣言
            int Ptr,Head;
            Boolean Ret;
            String name;

            //検索条件
            Head = 2;
            name = "Tanaka";

            Syain[] syains = new Syain[7];
            syains[0] = new Syain() { Key = "Yamada", Next = -1 };
            syains[1] = new Syain() { Key = "Tanaka", Next = 0 };
            syains[2] = new Syain() { Key = "Abe", Next = 3 };
            syains[3] = new Syain() { Key = "Ikeda", Next = 6 };
            syains[4] = new Syain() { Key = null, Next = -2 };
            syains[5] = new Syain() { Key = "Sato", Next = 1 };
            syains[6] = new Syain() { Key = "Ootani", Next = 5 };

            if (Head==-1){
                Ret = false;
            }
            else{
                Ptr = Head;
                //検索文字 name が一致するか最後まで繰り返す
                while( (Ptr!= -1) && (syains[Ptr].Key!=name)){
                    Ptr = syains[Ptr].Next;
                }

                if (Ptr == -1){
                    Ret = false;
                }
                else{
                    Ret = true;
                }

            }

            Console.WriteLine("探索結果 "+Ret);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
