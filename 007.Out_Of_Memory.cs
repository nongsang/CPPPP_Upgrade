using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

class SimpleSum
{
    private int[] array;    // 배열에다 값들을 저장
    private int sum;        // 배열에 있는 값을 모두 더하여 저장

    private void calc()     // calc() 메소드를 이용해서
    {
        sum = array.Sum();  // 배열에 저장된 값을 sum에 저장한다.
    }
    public SimpleSum(int max)   // 생성자
    {
        array = Enumerable.Range(0, max).ToArray(); // 0에서부터 max값까지 배열에 원소로 저장
        calc();                                     // 그리고 값을 전부 더한다.
    }
}

namespace CPPPP
{
    class Out_Of_Memory
    {
        public static void Main()
        {
            var list = new List<SimpleSum>();

            for (int i = 0; i < 100000; ++i)    // 10만번을 반복하는데
                list.Add(new SimpleSum(10000)); // 0에서 9999까지 하는 작업을 한다.
                                                // List는 문제가 없지만, SimpleSum.array에서 발생한다.
        }
    }
}