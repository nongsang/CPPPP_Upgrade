using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Static_Avogadro
    {
        private static double avogadro = 6.02E23;   // 이걸 잘 쓰고 있었는데

        public static void Main()
        {
            double mol = 10;

            avogadro = 10; // 누군가가 이렇게 바꿔버리고

            //WriteLine("{0}mol의 물에 포함되는 물 분자는 {1}개 입니다.", mol, mol * avogadro);    // 이렇게 쓰던 문자열을

            WriteLine("오늘 산 아보카도의 갯수는 {0}개 입니다.", avogadro);    // 문자열도 이렇게 바꿔버린다면?
                                                                            // 누군가 함부로 값을 바꿀 수 없었으면 좋겠어
        }
    }
}