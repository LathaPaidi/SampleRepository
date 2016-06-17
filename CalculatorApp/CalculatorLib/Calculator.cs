using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
  /// <summary>
  /// Calculator class
  /// </summary>
  public class Calculator
  {
    /// <summary>
    /// Add method
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>integer</returns>
    public int Add(int a ,int b)
    {
      return a + b;
    }
    public int Multiply(int a, int b)
    {
      return a * b;
    }
    public int Divide(int a, int b)
    {
      return a / b;
    }
    public int Subtract(int a, int b)
    {
      return a - b;
    }
    public string GetString()
    {
      return "Hello World";
    }
  }
}
