using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.IO;                // TextWriter와 File을 사용하기 위해서 사용

class CWC : IDisposable     // IDisposable을 상속받았다.
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
        throw new ApplicationException("Sample Exception"); // 예외를 발생시켜서
    }

    public void Dispose()   // IDisposable을 사용하면 반드시 정의해줘야 한다.
    {
        if (writer != null) writer.Close();     // 예외가 발생하면 Dispos가 실행되며 파일이 닫히게 된다.
    }
}

namespace CPPPP
{
    class IDisposable_Exception_Close
    {
        public static void Main()
        {
            try
            {
                using (var cwc = new CWC()) // try문 안에서만 클래스를 사용하려면 using을 사용하면 된다.
                {
                    cwc.Create();
                    cwc.Write();            // 예외 발생을 한다.
                                            // CWC는 IDisposable을 상속받아서 Dispose를 정의했으므로 예외가 발생하면 Dispose를 실행한다.
                                            // Dispose가 실행되면 파일이 닫히게 된다.
                }
            }
            catch (Exception e)     // 그리고 예외가 발생한 모든 위치를
            {
                WriteLine(e);       // 출력한다.
                                    // 그냥 throw만 하는 것보다 많이 쓰이는 방식이다.
            }
        }
    }
}