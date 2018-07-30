using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // 성능측정하기 위한 Stopwatch를 쓰려고 추가

namespace CPPPP
{
    class Array_For_Foreach_Comparison
    {
        public static void Main()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // int형 배열을 for문과 foreach로 성능측정을 해본다.

            Stopwatch sw = new Stopwatch();

            sw.Start();                                 // 스탑워치 키고

            for (int i = 0; i < a.Length; ++i)          // for문으로 배열의 원소를
                WriteLine(a[i]);                        // 출력한다.

            //int n = a.Length;                         // 길이를 미리 저장해놓고
            //for (int i = 0; i < n; ++i)               // 값을 비교하면서 해도
            //    WriteLine(a[i]);                      // 성능이 올라가진 않는다.

            sw.Stop();                                  // 스탑워치를 끈다.

            WriteLine("소요시간 : " + sw.Elapsed);      // 시간은 약 0.001초;

            sw.Reset();

            sw.Start();                     // 다시 스탑워치 키고

            foreach (int item in a)         // foreach문으로 배열의 원소를 순회하면서
                WriteLine(item);            // 출력한다.

            sw.Stop();                      // 스탑워치를 끈다.

            WriteLine("소요시간 : " + sw.Elapsed);      // 배열에서는 foreach문이 for문보다 2배정도 더 빠르다.

            // 처리 대상에 따라서 성능차가 많이 날 수 있다.
            // for문은 특정 조건이 성립할 때까지 반복한다.
            // 거기에 인덱스를 하나씩 증가시키면서 인덱스에 해당하는 요소를 가져온다.
            // 배열처럼 임의접근(Random Access, 인덱스로 아무곳이나 찍어서 접근하는 것)이 가능한 컬렉션은 성능에 큰 문제는 없다.
            // 하지만 list같은 임의접근이 불가능하고 순차접근(Sequential Access)이 필요한 컬렉션은 foreach문이 더 적합하다.
            // foreach문은 특정 열거 인터페이스가 열거된 요소를 하나씩 다음으로 넘어가면서 요소를 가져온다.
        }
    }
}