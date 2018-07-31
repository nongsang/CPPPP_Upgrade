using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Static_Avogadro_Exception
    {
        private static double a;
        private static double avogadro
        {
            get { return a; }
            set
            {
                if (value != 6.02E23)   // 만약 avogadro에 값이 6.02E23과 다르면 예외를 발생
                    throw new ArgumentException("아보가드로 상수는 6.02E23만 설정할 수 있다.");

                a = value;      // 그렇지 않다면 다른 변수에 값을 저장
            }
        }

        public static void Main()
        {
            avogadro = 10;  // 이러면 예외가 발생하는 거지

            WriteLine("오늘 산 아보카도의 갯수는 {0}개 입니다.", avogadro);

            double mol = 10;

            // 문제는 아보가드로 상수는 정확하게 6.02E23가 아니다.
            // 정확하게 6.02214129E23이기 때문에 avogadro에 6.02214129E23를 넣으면 문제가 발생한다.
            // 다른 방법이 없나?
            WriteLine("{0}mol의 물에 포함되는 물 분자는 {1}개 입니다.", mol, mol * avogadro);
        }
    }
}