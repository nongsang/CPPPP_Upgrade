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
        array = null;                               // SimpleSum 생성자가 끝나면서 array에는 많은 데이터를 저장하게 된다.
                                                    // 클래스안에 array가 있으므로 생성자가 끝나도 array에 값이 계속해서 저장되게 된다.
                                                    // array는 단순히 값을 전달하는 역할일 뿐이다.
                                                    // array의 역할이 끝나면 값을 전부 삭제해야 메모리부족이 발생하지 않는다.
                                                    // 생성자는 값을 초기화하는 역할이지, 어떤 기능을 정의하여 사용하라고 있는게 아니다.
    }
}

namespace CPPPP
{
    class Constructor_Array
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