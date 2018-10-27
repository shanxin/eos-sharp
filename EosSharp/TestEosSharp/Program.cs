using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEosSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEos testEos = new TestEos();
            testEos.CheckAsync();

            Console.WriteLine(testEos.Result);
            Console.ReadLine();
        }
    }
}