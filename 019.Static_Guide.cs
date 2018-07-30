using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.IO;                // TextWriter와 File을 사용하기 위해서 사용

class CWC        // 정적 클래스는 가급적 쓰지 말자
{
    private TextWriter writer;  // 내부에서만 쓰고, 인수를 적게 쓰기 위해 private 정의

    public TextWriter Create()       // 파일을 새롭게 만드는 기능
    {
        return File.CreateText("sample.txt");
    }

    public void Close() // 현재 파일을 닫는 기능
    {
        writer.Close();
    }

    public void Write() // 문자열을 파일에 쓰는 기능
    {
        writer.WriteLine("Samole Message");
    }
}

namespace CPPPP
{
    class Static_Guide
    {
        public static void Main()
        {
            var cwc = new CWC();    // CWC 기능을 쓰고 싶으면 인스턴스화 해서 쓰게끔 하자.
            cwc.Create();           // 너무 static 남발해서 쓰면 병렬처리가 힘들다.
            cwc.Write();            // 요즘은 웹 시스템이라서 여러 사람이 동시에 작업을 하려면 static을 안쓰는 것이 좋다.
            cwc.Close();            // 하지만 한 곳에서만 사용된다는 것을 알고 있다면 static을 사용해야 한다.
        }
    }
}