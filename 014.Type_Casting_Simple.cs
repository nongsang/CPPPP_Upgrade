using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

class Base { }  // 기본 클래스

class Extended : Base   // 자식 클래스
{
    public void SayIt()
    {
        WriteLine("I'm Extended!");
    }
}

namespace CPPPP
{
    class Type_Casting_Simple
    {
        public static void Main()
        {
            Base[] array = { new Base(), new Extended() };

            foreach (var item in array.OfType<Extended>())  // array의 요소중에서 Extended이거나 상속받은 놈들 모두 Extended로 형변환해서
            {
                item.SayIt();                               // SayIt() 실행
                                                            // var도 Extended로 컴파일된다.
            }
        }
    }
}