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
    }
  }
}
