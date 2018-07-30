using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.IO;                // TextWriter와 File을 사용하기 위해서 사용

static class CWC        // 정적 클래스다
{
    public static TextWriter Create()       // 파일을 새롭게 만드는 기능
    {
        return File.CreateText("sample.txt");
    }

    public static void Close(TextWriter writer) // 현재 파일을 닫는 기능
    {
        writer.Close();
    }

    public static void Write(TextWriter writer) // 문자열을 파일에 쓰는 기능
    {
        writer.WriteLine("Samole Message");
    }
}

namespace CPPPP
{
    class Static_Syndrome
    {
        public static void Main()
        {
            var writer = CWC.Create();  // ???
            CWC.Write(writer);          // 너무 클래스에 막 접근할 수 있는거 아닌가?
            CWC.Close(writer);          // 똑같은 인수도 너무 자주 넘기고
        }
    }
}