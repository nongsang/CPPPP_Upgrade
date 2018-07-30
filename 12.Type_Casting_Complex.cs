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
    class Type_Casting_Complex
    {
        public static void Main()
        {
            Base[] array = { new Base(), new Extended() };

            foreach (var item in array)     // array에 있는 요소들 중에
                if (item is Extended)           // Extended이거나 상속을 받은 놈들은
                    ((Extended)item).SayIt();   // Etended로 형변환하고 SayIt()를 실행
                                                // 근데 ()가 많아서 헷깔리는데 바꿀 방법이 없을까?
        }
    }
}