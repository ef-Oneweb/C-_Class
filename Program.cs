using System;

namespace ClassCSharp
{
class Program
    {
        static void Main(string[] args)
        {
           // AddSwapNumbers a = new AddSwapNumbers();
           // a.AddSwapNos();            
           // AddTwoNums atn = new AddTwoNums();
           // atn.Add2Nums();
           // atn.AddSNums();
           ClassOne classOne = new();
           var result = classOne.Add2();
           Console.WriteLine(result);
        }
    }
}

