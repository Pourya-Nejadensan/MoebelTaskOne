using MoebelTaskOne.Domain.Entities;
using System;

namespace MoebelTaskOne.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = System.Console.ReadLine();
            YourNameAsANumber Test = new YourNameAsANumber(inputString);
            System.Console.WriteLine(Test.CalcSumOfInputString());
            System.Console.ReadKey();
        }
    }
}
