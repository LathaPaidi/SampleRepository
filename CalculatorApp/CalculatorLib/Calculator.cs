﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
  public class Calculator
  {
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
