//教科書 175ページ、178ページ　ヒープ化とヒープソート

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSortSample
{
    class HeapSortSample
    {
        //Heap化される前の配列
        public static int[] t = new int[9] { 8, 5, 6, 4, 3, 0, 1, 2, 7 };
        public static int N = t.Length;

        static void Main(string[] args)
        {
            //Heap化される前の配列を表示
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]);
            }
            Console.WriteLine();

            //Heap化する関数を呼び出して結果を表示
            MakeHeap();

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]);
            }
            Console.WriteLine();

            //HeapSortを呼び出しで結果を表示
            HeapSort();

            //結果を表示
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        //MakeHeap() 関数 教科書 175ページ
        static void MakeHeap()
        {
            int Temp, Parent, Child;

            for(int Idx = 0; Idx < t.Length; Idx++)
            {
                Child = Idx;
                Parent = (Child - 1) / 2;
                while( (Child > 0) && (t[Parent] < t[Child]) ) {
                    Temp = t[Child];
                    t[Child] = t[Parent];
                    t[Parent] = Temp;
                    Child = Parent;
                    Parent = (Child - 1) / 2;
                }
            }
        }

        //HeapSort() 関数　教科書 178ページ
        static void HeapSort()
        {
            int Temp, HeapTail;
            HeapTail = N - 1;
            while (HeapTail >= 1)
            {
                Temp = t[0];
                t[0] = t[HeapTail];
                t[HeapTail] = Temp;
                HeapTail = HeapTail - 1;
                TopDown(HeapTail);
            }
        }

        //TopDown  HeapTailは、ヒープの末尾
        static void TopDown(int HeapTail)
        {
            int Parent, Child, Temp;
            Parent = 0;
            Child = SelectChild(Parent, HeapTail);
            while((Child!=-1)&& (t[Parent] < t[Child]))
            {
                Temp = t[Parent];
                t[Parent] = t[Child];
                t[Child] = Temp;
                Parent = Child;
                Child = SelectChild(Parent, HeapTail);
            }
        }

        //整数型 SelectChild
        static int SelectChild(int Parent,int HeapTail)
        {
            int Child;
            Child = Parent * 2 + 1;

            if (Child > HeapTail)
            {
                Child = -1;
            }
            else {
                if((Child<HeapTail) && (t[Child]<t[Child+1]))
                {
                    Child = Child + 1;
                }
            }
            return Child;
        }
    }
}
