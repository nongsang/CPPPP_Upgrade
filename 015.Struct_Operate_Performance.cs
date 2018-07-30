using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // Stopwatch 사용하려고 추가

struct TenNumbers       // double형 값이 10개 있는 구조체
{
    public double d0, d1, d2, d3, d4, d5, d6, d7, d8, d9;   // 값은 그냥 안넣어서 0으로 초기화
}

namespace CPPPP
{
    class Struct_Operate_Performance
    {
        static double calc(TenNumbers t)    // 구조체를 받아서 각 원소를 다 더한 값을 반환하는 메소드
        {
            return t.d0 + t.d1 + t.d2 + t.d3 + t.d4 + t.d5 + t.d6 + t.d7 + t.d8 + t.d9;
        }

        public static void Main()
        {
            Stopwatch sw = new Stopwatch();

            double sum = 0;

            sw.Start();     // 스탑워치를 키고

            for (int i = 0; i < 100000000; ++i)     // 1억번
                sum += calc(new TenNumbers());      // 메소드에 생성한 구조체를 전달한다.
                                                    // 구조체는 스택에 생성하므로 가비지컬렉터도 안건들테니 속도가 빠르겠지?

            sw.Stop();      // 스탑워치를 끈다.

            WriteLine(sum);         // 총 합
            WriteLine(sw.Elapsed);  // 시간은 약 3.1초
                                    // 더 빠르게 할 수 없나?
        }
    }
}