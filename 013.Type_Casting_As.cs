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
    class Type_Casting_As
    {
        public static void Main()
        {
            Base[] array = { new Base(), new Extended() };

            foreach (var item in array)         // array에 있는 요소들 모두
            {
                var extended = item as Extended;// 형변환해서 저장하고

                if (extended != null)           // 형변환이 된 놈들은
                {
                    extended.SayIt();           // SayIt() 실행
                }                               // 그래도 이해하기는 쉬운데 null체크도 없었으면 좋겠어
            }
        }
    }
}