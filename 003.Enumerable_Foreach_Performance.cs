using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Diagnostics;       // 성능측정하기 위한 Stopwatch를 쓰려고 추가

namespace CPPPP
{
    class Enumerable_Foreach_Performance
    {
        public static void Main()
        {
            Stopwatch sw = new Stopwatch();

            var heavyQuery = Enumerable.Range(0, 10).Where(c => // 0 ~ 9까지 열거형으로 저장한다. 이 때 var는 IEnumerable이다.
            {                                                   // 각 정수를 반환받을 때는 true를 반환할 때마다 반환한다.
                Task.Delay(1000).Wait();                        // 1초동안 쉬고
                return true;                                    // true를 반환하는 기능이다.
            });                                                 // 따라서 정수를 반환할 때는 1초가 지날 때 마다 반환한다.

            sw.Start();                                         // 스탑워치 키고

            //var enumerator = heavyQuery.GetEnumerator();      // heavyQuery는 IEnumerable형이므로 MoveNext()를 쓰려고 IEnumerator에 저장
            //for (; enumerator.MoveNext();)                    // 인덱스 접근을 없애고 for문과 MoveNext()로 요소에 접근한 후
            //    WriteLine(enumerator.Current);                // enumerator가 가리키는 값을 출력한다.
                                                                // 인덱스 접근만 없애도 성능이 증가하며, foreach문과 같아진다.

            foreach (var item in heavyQuery)                    // 차라리 foreach문이 훨씬 간편하다.
                WriteLine(item);

            sw.Stop();                                          // 스탑워치를 끈다.

            WriteLine("소요시간 : " + sw.Elapsed);               // 전체 시간은 10초
        }
    }
}