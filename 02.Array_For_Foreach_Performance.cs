using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // 성능측정하기 위한 Stopwatch를 쓰려고 추가

namespace CPPPP
{
    class For_Foreach_Array_Performance
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
        }
    }
}