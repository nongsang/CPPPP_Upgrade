using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

class Distance
{
    private double x1, x2, distance;

    public void Report()
    {
        WriteLine("{0}와 {1}의 거리는 {2}다", x1, x2, distance);
    }

    public void OtherWork()         // 누군가 이런 장난을 친다.
    {
        WriteLine("다른 일을 하고 있습니다.");

        x1 = 4893;      // 필드값을 마음대로
        x2 = 874;       // 막 접근해서 막 바꾸네
    }

    public Distance(double x1, double x2)   // 생성자
    {
        this.x1 = x1;
        this.x2 = x2;
        this.distance = Math.Abs(x2 - x1);  // 두 값을 빼서 절대값을 저장
    }
}

namespace CPPPP
{
    class Variable_Problem
    {
        public static void Main()
        {
            var dist = new Distance(2, 5);
            dist.OtherWork();               // 여기서 필드값이 마음대로 바뀐다.
            dist.Report();                  // 해결방법이 없나?
        }
    }
}