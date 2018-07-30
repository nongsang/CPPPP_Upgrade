using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // Stopwatch 사용하려고 추가

class TenNumbers       // double형 값이 10개 있는 클래스
{
    public double d0, d1, d2, d3, d4, d5, d6, d7, d8, d9;   // 값은 그냥 안넣어서 0으로 초기화
}

namespace CPPPP
{
    class Class_Operate_Performance
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

            sw.Stop();      // 스탑워치를 끈다.

            WriteLine(sum);         // 총 합
            WriteLine(sw.Elapsed);  // 시간은 약 1.6초
                                    // 클래스를 구조체로 바꿔서 성능이 좋은 경우는 '데이터 크기가 작은 경우'다.
                                    // 멤버가 10개이면 충분히 많다.
                                    // double형 8개 크기(64byte)정도부터는 클래스를 쓰는 것이 오히려 좋다.
                                    // 가비지컬렉터를 건드리지만 시간날 때 가비지컬렉션 한번씩 하자.
        }
    }
}