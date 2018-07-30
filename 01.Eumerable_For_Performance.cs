using System;
using System.Collections.Generic;
using System.Linq;              // Enumerable을 사용하기 위해 추가
using System.Text;
using System.Threading.Tasks;   // Task를 사용하기 위해서 추가
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // 성능측정하기 위한 Stopwatch를 쓰려고 추가

namespace CPPPP
{
    class Eumerable_For_Performance
    {
        public static void Main()
        {
            Stopwatch sw = new Stopwatch();

            var heavyQuery = Enumerable.Range(0, 10).Where(c => // 0 ~ 9까지 열거형으로 저장한다. 이 때 var는 IEnumerable이다.
            {                                                   // 각 정수를 반환받을 때는 true를 반환할 때마다 반환한다.
                Task.Delay(1000).Wait();                       // 1초동안 쉬고
                return true;                                   // true를 반환하는 기능이다.
            });                                                 // 따라서 정수를 반환할 때는 1초가 지날 때 마다 반환한다.

            sw.Start();                                         // 스탑워치 키고

            for (int i = 0; i < heavyQuery.Count(); ++i)        // for문으로 IEnumerable형인 heavyQuery의 원소를
                WriteLine(heavyQuery.ElementAt(i));             // 출력한다.

            sw.Stop();                                          // 스탑워치를 끈다.

            WriteLine("소요시간 : " + sw.Elapsed);               // 전체 시간은 2분 40초정도 걸린다.
                                                                // 1초마가 값을 반환하게 했으니 10초가 나와야하는데 2분 40초가 걸린다.
                                                                // 이유는 IEnumerable형 자료를 for문으로 접근했기 때문이다.
        }
    }
}