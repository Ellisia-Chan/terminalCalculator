using System;

namespace Hello_World
{
  class Calculator
  {
    public int num1;
    public int num2;
    public string? op;
    public double result = 0;

    public Calculator(int _num1, int _num2, string _op)
    {
      num1 = _num1;
      num2 = _num2;
      op = _op;
    }

    public double Calculate()
    {
      if (op == "/")
      {
        if (num1 == 0 || num2 == 0)
        {
          Console.WriteLine("Cannot Divide by zero");
          return 0;
        }
        result = (double)num1 / num2;
      }
      else
      {
        switch (op)
        {
          case "+":
            result = num1 + num2;
            break;
          case "-":
            result = num1 - num2;
            break;
          case "x":
            result = num1 * num2;
            break;
          default:
            Console.WriteLine("Enter a Valid Operator.");
            return 0;
        }
      }
      return result;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      //Code Goes Here
      Console.WriteLine("Calculator");
      Console.Write("Enter a number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter another number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Select Operator [+, -, x, /]: ");
      string? op = Console.ReadLine();

      Calculator cal = new Calculator(num1, num2, op);
      double result = cal.Calculate();

      Console.WriteLine("The answer is: " + result);
      // For Closing
      Console.ReadKey();
    }
  }
}