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
        IEnumerable<int> enumAll = Enumerable.Range(0, max);// 0에서부터 max값까지 열거형으로 저장
                                                            // 배열형이 아니라 열거형으로 바꾸었다.
                                                            // 배열은 데이터에 집중한 반면 열거형은 데이터를 반복해서 가져오는 것에 집중한다.
                                                            // 따라서 배열은 데이터를 많이 잡아먹지만 열거형은 그냥 다음 요소를 가져올 뿐이다.

        GetSum = () =>
        {
            return enumAll.Sum();   // 열거형으로 전체 합을 반환한다.
                                    // 전에는 배열형의 전체값을 Sum()하면 배열을 순차적으로 접근하여 합흘 반환하므로 시간이 오래 걸린다.
                                    // 또한 반환형은 IEnumerable이지만 받는 자료형은 배열이므로 오버헤드가 발생했다.
                                    // 받는 자료형이 IEnumerable형이면 Enumerable로 받아도 같은 자료형이므로 속도와 메모리가 개선된다.
                                    // 배열형인지 열거형인지 잘 보고 맞춰서 매치를 잘 해주자.
        };
    }
}

namespace CPPPP
{
    class Lamda_Enumerable
    {
        public static void Main()
        {
            var list = new List<SimpleSum>();

            for (int i = 0; i < 100000; ++i)    // 10만번
                list.Add(new SimpleSum(10000)); // 0부터 9999까지 저장하고 합을 반환한다.
        }
    }
}