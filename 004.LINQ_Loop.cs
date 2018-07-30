using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class LINQ_Loop
    {
        public static void Main()
        {
            int[] a = { -1, 1, -2, 2, -3, 3, 4};

            foreach (var item in a)     // 원하는 값을 1개, 혹은 모두 찾을 때
                if (item < 0)           // for나 foreach와 if문을 조합하는게
                {
                    WriteLine(item);    // 편하긴 하다.
                    break;              // break로 조건에 맞는 첫번째 값을 찾고 탈출한다.
                }

            WriteLine(a.FirstOrDefault(c => c < 0));    // 람다와 LINQ를 이용해서 for와 if없이 값 1개 찾기가 가능하다.
            WriteLine(a.First(c => c < 0));             // c는 매개변수이므로 c로 전달된 값이 0보다 작은 첫번째 요소를 반환한다.

            WriteLine(a.Where(c => c < 0).ElementAt(1));    // 0보다 작은 요소중 1번에 해당하는 요소를 반환

            WriteLine(a.LastOrDefault(c => c < 0));     // LINQ로 조건에 맞는 마지막 값을 찾을 수 있다.
            WriteLine(a.Last(c => c < 0));              // 이것도 마찬가지
        }
    }
}