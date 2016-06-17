using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace CalculatorApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calculator App");
      Calculator cl = new Calculator();
      int c2 = cl.Add(2,3);
      Console.WriteLine("Result:" + c2);
      int c3 = cl.Multiply(3, 4);
      Console.WriteLine("Result:" + c3);
      int c4 = cl.Divide(4, 1);
      Console.WriteLine("Result:" + c4);
      Console.ReadLine();
    }
  }
}
