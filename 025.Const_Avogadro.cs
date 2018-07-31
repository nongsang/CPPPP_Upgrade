using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Const_Avogadro
    {
        private const double avogadro = 6.02E23;    // const는 상수로 만들기 때문에

        public static void Main()
        {
            avogadro = 10;      // 여기서 상수에 상수를 저장하는 행위를 컴파일 단계에서 검출한다.

            WriteLine("오늘 산 아보카도의 갯수는 {0}개 입니다.", avogadro);

            double mol = 10;    // const를 애용하자.

            WriteLine("{0}mol의 물에 포함되는 물 분자는 {1}개 입니다.", mol, mol * avogadro);
        }
    }
}