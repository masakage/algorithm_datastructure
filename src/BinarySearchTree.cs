//教科書 171ページ 2分木探索

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree

{
    // 構造体の定義 もとのデータ
    public struct BT
    {
        public int Key;
        public string Name;
        public int Left;
        public int Right;
    }

    // 追加するデータ（構造体）
    public struct E
    {
        public int Key;
        public string Name;
    }

    class BinarySearchTree
    {
        static void Main(string[] args)
        {

            //追加するデータ　構造体 Eで定義
            E[] e = new E[2];
            e[0] = new E() { Key = 18, Name = "G" };
            e[1] = new E() { Key = 33, Name = "H" };



            //実際のデータの追加
            Console.WriteLine(AddToBT(e[0]));
            Console.WriteLine(AddToBT(e[1]));
            Console.ReadKey();

        }

        public static Boolean AddToBT(E e)
        {
            int Ptr, Before, Store, Root,N;
            Boolean Ret;

            //構造体 tblを作成する
            
            BT[] bt = new BT[8];
            bt[0] = new BT() { Key = 35, Name = "A", Left = 1,Right=2 };
            bt[1] = new BT() { Key = 29, Name = "B", Left = -1,Right=-1 };
            bt[2] = new BT() { Key = 41, Name = "C", Left = -1, Right = -1 };
            bt[3] = new BT() { Key = 26, Name = "D", Left = 4, Right = 0 };
            bt[4] = new BT() { Key = 13, Name = "E", Left = 5, Right = -1 };
            bt[5] = new BT() { Key = 5, Name = "F", Left = -1, Right = -1 };
            bt[6] = new BT() { Key = -1, Name = "", Left = -1, Right = -1 };
            bt[7] = new BT() { Key = -1, Name = "", Left = -1, Right = -1 };

            // rootの場所、各種変数初期化
            Ret = true;
            Root = 3;
            N = bt.Length;
            Before = 0;
            Store = 0;

            //プログラム
            if (Root == -1)
            {
                Root = 0;
                bt[0].Key = e.Key;
                bt[0].Name = e.Name;
                bt[0].Left = -1;
                bt[0].Right = -1;
            }
            else
            {
                Store = 0;
                while (Store < N && (bt[Store].Key != -1))
                {
                    Store = Store + 1;
                }
                if (Store < N)
                {
                    bt[Store].Key = e.Key;
                    bt[Store].Name = e.Name;
                    bt[Store].Left = -1;
                    bt[Store].Right = -1;
                    Ptr = Root;

                    //追加の探索部分
                    while (Ptr != -1)
                    {
                        Before = Ptr;
                        if (e.Key < bt[Ptr].Key)
                        {
                            Ptr = bt[Ptr].Left;
                        }
                        else
                        {
                            Ptr = bt[Ptr].Right;
                        }
                    }
                    if (e.Key < bt[Before].Key)
                        {
                            bt[Before].Left = Store;
                        }
                    else
                        {
                            bt[Before].Right = Store;
                        }
                }
                else
                {
                    Ret = false;
                }
            }
            Console.WriteLine("Key=" + bt[Store].Key + " Name=" + bt[Store].Name);
            return Ret;
        }
    }
}