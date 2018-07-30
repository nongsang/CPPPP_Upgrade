using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // Stopwatch 사용하려고 추가

struct TenNumbers       // double형 배열로 되어 있는 구조체
{
    public double[] d;
}

namespace CPPPP
{
    class Struct_Performance_Improvement
    {
        static double calc(TenNumbers t)    // 구조체를 받아서 각 원소를 다 더한 값을 반환하는 메소드
        {
            // t는 배열이므로 참조형이라 크기가 아무리 늘어나도 참조만 저장하기 때문에 크기를 줄일 수 있다.
            // 따라서 성능향상을 기대할 수 있다.
            return t.d[0] + t.d[1] + t.d[2] + t.d[3] + t.d[4] + t.d[5] + t.d[6] + t.d[7] + t.d[8] + t.d[8];
        }

        public static void Main()
        {
            Stopwatch sw = new Stopwatch();

            double sum = 0;

            sw.Start();     // 스탑워치를 키고

            for (int i = 0; i < 100000000; ++i)                     // 1억번
                sum += calc(new TenNumbers() { d = new double[10]});// TenNumbers의 d 크기를 10으로 정하고 메소드로 구조체를 전달

            sw.Stop();      // 스탑워치를 끈다.

            WriteLine(sum); // 총 합
            WriteLine(sw.Elapsed);  // 시간은 약 2.1초
                                    // 그래도 더 빠르게 하고 싶어 
        }
    }
}