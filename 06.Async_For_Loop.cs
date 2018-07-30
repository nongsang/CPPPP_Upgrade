using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   // Task를 사용하기 위해 추가
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Async_For_Loop
    {
        static async Task CountDown()   // 비동기로 동작하는 메소드임을 선언한다.
        {
            for(int i = 9; i>= 0; --i)  // 원래라면 for문이 다 끝나기 전까지 다른 작업을 할 수 없다.
            {                           // 하지만 async로 선언하면 for가 있더라도 비동기로 작업한다.
                WriteLine(i);
                await Task.Delay(1000); // await를 선언한 곳에서 작업하다가 다른 작업이 발생하면 다른 작업으로 하러간다.
            }
        }

        public static void Main()
        {
            var a = CountDown();    // var는 Task형이다.
            var b = CountDown();    // Task로 반환을 받아서 작업을 지시할 수 있다.

            Task.WaitAll(a, b);     // Task로 반환받은 변수 a, b를 서로 작업을 번갈아가면 할 수 있도록 제어해준다.
        }
    }
}