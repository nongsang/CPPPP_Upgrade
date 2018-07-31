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
        try
        {
            throw new ApplicationException("Sample Exception"); // 예외를 발생시켜서
        }
        catch(Exception)    // 받으면
        {
            Close();        // 파일을 닫고
            throw;          // 예외를 발생시킨다.
        }
    }
}

namespace CPPPP
{
    class Exception_Close
    {
        public static void Main()
        {
            var cwc = new CWC();
            cwc.Create();
            cwc.Write();    // 여기서 예외를 발생시키고 파일을 닫지만 문제는 try 구문으로만 감싼 곳에서 문제가 발생한다.
            cwc.Close();    // 다른 방법이 없나?
        }
    }
}