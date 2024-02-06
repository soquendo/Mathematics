using Mathematics;
using System;
using System.Collections.Generic;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;
        private static List<double> _numbersList = new List<double>();

        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            //foreach(var a in args)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();
            AreArgumentsValid(args);

            var basicMath = new BasicMath();
            var advMath = new AdvMath();

            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {basicMath.AddNumbers(_num1, _num2)}");
                    break;
                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {basicMath.SubNumbers(_num1, _num2)}");
                    break;
                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {basicMath.MulNumbers(_num1, _num2)}");
                    break;
                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {basicMath.DivNumbers(_num1, _num2)}");
                    break;
                case "area":
                    Console.WriteLine($"Area of rectangle with height: {_num1} and width: {_num2} = {advMath.CalcArea(_num1, _num2)}");
                    break;
                case "avg":
                    Console.WriteLine($"Average = {advMath.CalcAverage(_numbersList)}");
                    break;
                case "square":
                    Console.WriteLine($"Value {_num1} squared = {advMath.CalcValueSquared(_num1)}");
                    break;
                case "pythagorean":
                    Console.WriteLine($"Hypotenuse given sides {_num1} and {_num2} = {advMath.CalcPyTheorem(_num1, _num2)}");
                    break;
                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter a valid operator like add, sub, mul, div, area, avg, square, or pythagorean.");
                    break;
            }

            Console.ReadLine();

        }

        public static void AreArgumentsValid(string[] args)
        {
            //check for min length arg
            if (args.Length < 2)
            {
                Console.WriteLine("Not enough arguments provided.");
                Environment.Exit(98);
            }

            _operand = args[1].ToLower();

            //
            if (_operand == "square" && args.Length >= 3)
            {
                _num1 = NumParser(args[2]);
            }
            else if (args.Length >= 4)
            {
                _num1 = NumParser(args[2]);
                _num2 = NumParser(args[3]);
            }
            else if (_operand == "avg" && args.Length > 3)
            {
                for (int i = 2; i < args.Length; i++)
                {
                    _numbersList.Add(NumParser(args[i]));
                }
            }
            else
            {
                Console.WriteLine("Invalid numbers of arguments for the operation.");
                Environment.Exit(97);
            }

            Console.WriteLine("All arguments are valid");
            //Console.ReadLine();
        }   
            
        public static double NumParser(string arg)
        {
            //double number;
            if (Double.TryParse(arg, out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
                return 0;
            }

            //return 0;
        }

    }
}