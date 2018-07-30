using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.IO;

class SimpleSum
{
    private int[] array    // 배열에다 값들을 저장
    {
        // 읽은 작업이 있으면 HDD에 텍스트파일을 열고 파일을 읽고, 파일을 닫는다.
        get { return File.ReadAllLines(id.ToString() + ".txt").Select(c => int.Parse(c)).ToArray(); }
        // 쓰는 작업이 있으면 HDD에 파일을 새로 만들고, 배열을 파일에 쓰고 닫는다.
        set { File.WriteAllLines(id.ToString() + ".txt", value.Select(c=>c.ToString()).ToArray()); }
    }
    private int sum;        // 배열에 있는 값을 모두 더하여 저장
    private int id;         // ID

    private void calc()     // calc() 메소드를 이용해서
    {
        sum = array.Sum();  // 배열에 저장된 값을 sum에 저장한다.
    }
    public SimpleSum(int max, int id)   // 생성자
    {
        this.id = id;           // 추가로 id도 설정
        array = Enumerable.Range(0, max).ToArray(); // 0에서부터 max값까지 배열에 원소로 저장
        calc();                                     // 그리고 값을 전부 더한다.
    }
}

namespace CPPPP
{
    class Auxiliary_Memory_Use
    {
        public static void Main()
        {
            var list = new List<SimpleSum>();

            for (int i = 0; i < 100000; ++i)        // 10만번을 반복하는데
                list.Add(new SimpleSum(10000, i));  // 0에서 9999까지 하는 작업을 하는 요소에 각각 id까지 부여한다.
                                                    // HDD를 사용하므로 시간은 오래걸리지만 OutOfMemory 예외는 발생하지 않는다.
        }
    }
}