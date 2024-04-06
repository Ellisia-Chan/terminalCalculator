using System;

namespace HelloWorld {
    class Calculator {
        private readonly int _num1;
        private readonly int _num2;
        private readonly string? _op;

        public Calculator(int num1, int num2, string? op) {
            _num1 = num1;
            _num2 = num2;
            _op = op;
        }

        public double Calculate() {
            double result = 0;

            if (_op == null) {
                Console.WriteLine("Operator cannot be null.");
                return result;
            }

            switch (_op) {
                case "+":
                    result = _num1 + _num2;
                    break;
                case "-":
                    result = _num1 - _num2;
                    break;
                case "x":
                    result = _num1 * _num2;
                    break;
                case "/":
                    if (_num2 == 0) {
                        Console.WriteLine("Cannot Divide by zero");
                        return result;
                    }
                    result = (double)_num1 / _num2;
                    break;
                default:
                    Console.WriteLine("Enter a Valid Operator.");
                    break;
            }
            return result;
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Calculator");
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select Operator [+,-,x,/]: ");
            string? op = Console.ReadLine();

            Calculator cal = new Calculator(num1, num2, op);
            double result = cal.Calculate();

            Console.WriteLine("The answer is: " + result);
            Console.ReadKey();
        }
    }
}
