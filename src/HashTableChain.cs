//教科書 161ページ　ハッシュテーブルへの要素追加
//チェーン法で実装している

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableChain

{
    // 構造体の定義 作成されたデータ
    public struct TBL
    {
        public int Key;
        public string Data;
        public int Next;
    }

    // 追加するデータ（構造体）
    public struct E
    {
        public int Key;
        public string Data;
    }

    class HashTableChain
    {
        static void Main(string[] args)
        {

            //追加するデータ　構造体 Eで定義
            E[] e = new E[2];
            e[0] = new E() { Key = 64, Data = "Reader" };
            e[1] = new E() { Key = 17, Data = "USB" };


            //実際のデータの追加
            Console.WriteLine(AddToTBL(e[0]));
            Console.WriteLine(AddToTBL(e[1]));
            Console.ReadKey();

        }

        public static Boolean AddToTBL(E e)
        {
            int StoreIdx, ListTail, N;
            Boolean Ret;

            //構造体 tblを作成する
            TBL[] tbl = new TBL[60];
            tbl[0] = new TBL() { Key = 55, Data = "Key_board", Next = -1 };
            tbl[1] = new TBL() { Key = 23, Data = "Video", Next = -1 };
            tbl[2] = new TBL() { Key = 57, Data = "M_Phone", Next = -1 };
            tbl[3] = new TBL() { Key = 36, Data = "Camera", Next = -1 };
            tbl[4] = new TBL() { Key = 70, Data = "Printer", Next = -1 };
            tbl[5] = new TBL() { Key = 49, Data = "NotePC", Next = -1 };
            tbl[6] = new TBL() { Key = 39, Data = "DVD_Drive", Next = -1 };
            tbl[7] = new TBL() { Key = 18, Data = "Opt_Mouse", Next = -1 };
            tbl[8] = new TBL() { Key = 19, Data = "Mouse", Next = -1 };
            tbl[9] = new TBL() { Key = 42, Data = "BD_Drive", Next = -1 };
            tbl[10] = new TBL() { Key = 21, Data = "Scaner", Next = -1 };

            //以降のデータを初期化する
            for (int i = 11; i < tbl.Length; ++i)
            {
                tbl[i] = new TBL() { Key = -1, Data = "Null", Next = -1 };
            }

            N = tbl.Length;

            //データ追加する部分
            Ret = true;
            StoreIdx = Hash(e.Key);

            if (tbl[StoreIdx].Key == -1)
            {
                tbl[StoreIdx].Key = e.Key;
                tbl[StoreIdx].Data = e.Data;
                tbl[StoreIdx].Next = -1;
            }
            else
            {
                ListTail = StoreIdx;
                StoreIdx = 31;
                while (StoreIdx < N && (tbl[StoreIdx].Key != -1))
                {
                    StoreIdx = StoreIdx + 1;
                }
                if (StoreIdx < N)
                {
                    tbl[StoreIdx].Key = e.Key;
                    tbl[StoreIdx].Data = e.Data;
                    tbl[StoreIdx].Next = -1;
                    while (tbl[ListTail].Next != -1)
                    {
                        ListTail = tbl[ListTail].Next;
                    }
                    tbl[ListTail].Next = StoreIdx;
                }
                else
                {
                    Ret = false;
                }
            }
            Console.WriteLine("Key=" + tbl[StoreIdx].Key + " Data=" + tbl[StoreIdx].Data);
            return Ret;
        }

        //31の余りアドレスを返却するハッシュ関数
        public static int Hash(int Key)
        {
            return Key % 31;
        }

    }
}