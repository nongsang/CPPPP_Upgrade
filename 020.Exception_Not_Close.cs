using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.IO;                // TextWriter와 File을 사용하기 위해서 사용

class CWC
{
    private TextWriter writer;

    public TextWriter Create()
    {
        return File.CreateText("sample.txt");
    }

    public void Close()
    {
        writer.Close();
    }

    public void Write() // 예외를 발생시킨다.
    {
        throw new ApplicationException("Sample Exception"); // 하지만 예외가 발생했다고 해서 파일이 닫힌다는 보장이 없다.
    }
}

namespace CPPPP
{
    class Exception_Not_Close
    {
        public static void Main()
        {
            var cwc = new CWC();
            cwc.Create();
            cwc.Write();
            cwc.Close();
        }
    }
}