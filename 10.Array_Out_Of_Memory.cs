using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

class SimpleSum
{
    public Func<int> GetSum;    // 반환값이 있는 람다 전용 델리게이트

    public SimpleSum(int max)   // 생성자
    {
        int[] array = Enumerable.Range(0, max).ToArray();   // 0에서부터 max값까지 배열에 원소로 저장
                                                            // 이번에는 배열을 지역으로 생성해서 메소드가 끝나면 상제하도록 했다.

        GetSum = () =>          // 람다인데
        {
            return array.Sum(); // 배열값의 합을 반환한다.
                                // 이번에는 array와 람다때문에 문제가 발생한다.
        };
    }
}

namespace CPPPP
{
    class Array_Out_Of_Memory
    {
        public static void Main()
        {
            var list = new List<SimpleSum>();

            for (int i = 0; i < 100000; ++i)    // 10만번
                list.Add(new SimpleSum(10000)); // 0부터 9999까지 저장하고 합을 반환한다.
                                                // 문제는 람다에서 발생한다.
        }
    }
}