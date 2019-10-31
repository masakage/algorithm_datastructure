//教科書 136ページ　構造体配列サンプル

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHeightAvg
{

    public struct Student
    {
        public double Height;
        public int Age;

    }

    class GetHeightAvg
    {
        static void Main(string[] args)
        {
            //宣言
            int U20Num,N;
            double U20Total, O20Total;

            Student[] students = new Student[8];
            students[0] = new Student() { Height = 170, Age = 25 };
            students[1] = new Student() { Height = 160, Age = 18 };
            students[2] = new Student() { Height = 150, Age = 17 };
            students[3] = new Student() { Height = 175, Age = 32 };
            students[4] = new Student() { Height = 185, Age = 26 };
            students[5] = new Student() { Height = 165, Age = 15 };
            students[6] = new Student() { Height = 173, Age = 22 };
            students[7] = new Student() { Height = 182, Age = 23 };

            N = students.Length;
            U20Num = 0;
            U20Total = 0;
            O20Total = 0;

            for(int Idx=0 ; Idx<N;  ++Idx)
            {
                if (students[Idx].Age <= 20){
                    U20Num = U20Num + 1;
                    U20Total = U20Total + students[Idx].Height;
                }

                else{
                    O20Total = O20Total + students[Idx].Height;

                }
            }

            if (U20Num > 0){
                // (int)で整数型にキャスト
                Console.WriteLine("20歳以下の学生の平均身長 " + (int)(U20Total / U20Num));
            }

            if (U20Num < N) {
                Console.WriteLine("20歳以上の学生の平均身長 " + (int)(O20Total / (N - U20Num)));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
