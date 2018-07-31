using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

class Distance
{
    private readonly double x1, x2, distance;   // 클래스의 필드를 readonly로 선언한다.

    public void Report()
    {
        WriteLine("{0}와 {1}의 거리는 {2}다", x1, x2, distance);
    }

    public void OtherWork()         // 누군가 이런 장난을 친다.
    {
        WriteLine("다른 일을 하고 있습니다.");

        x1 = 4893;      // 필드값을 readonly로 선언하면 
        x2 = 874;       // 다른 메소드에서 필드값을 마음대로 바꿀 수 없다.
    }

    public Distance(double x1, double x2)   // 생성자
    {
        this.x1 = x1;       // 생성자에서는 readonly값을
        this.x2 = x2;       // 마음대로 정할 수 없다.
        this.distance = Math.Abs(x2 - x1);  // 두 값을 빼서 절대값을 저장
    }
}

namespace CPPPP
{
    class Class_Readonly_Variable
    {
        public static void Main()
        {
            var dist = new Distance(2, 5);
            dist.OtherWork();               // 필드를 readonly로 선언했으므로 마음대로 값을 바꿀 수 없다.
            dist.Report();                  // 만사 해결
        }
    }
}