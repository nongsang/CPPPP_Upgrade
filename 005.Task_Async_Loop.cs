using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;         // AutoResetEvent를 사용하기 위해 추가
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

class CountDownWapper
{
    public AutoResetEvent Done = new AutoResetEvent(false);     // 대기 중인 스레드에 이벤트가 발생했음알리는 클래스, false로 초기화

    private int count = 9;  // 숫자를 세기 위해서 정의

    public void CountDown()
    {
        WriteLine(count--); // 숫자를 센다
        if (count >= 0)
            Task.Delay(1000).ContinueWith(c => { CountDown(); });   // for문을 사용하지 않으려고 1초가 지날 때 마다 자기자신을 실행
        else                                                        // Task를 사용했으므로 비동기로 동작한다.
            Done.Set();     // 0이면 스레드에 이벤트 발생
    }
}

namespace CPPPP
{
    class Task_Async_Loop
    {
        public static void Main()
        {
            var a = new CountDownWapper();  // 각자가 알아서 도는
            var b = new CountDownWapper();  // 클래스 생성

            a.CountDown();      // 각자가
            b.CountDown();      // 숫자를 돌린다.

            AutoResetEvent.WaitAll(new[] { a.Done, b.Done });   // 두 클래스에 이벤트가 발생할 때 까지 기다린다.
                                                                // 비동기로 돌지만 좀 어렵다.
        }
    }
}