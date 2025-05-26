﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;
        bool valid = true;

        switch (op)
        {
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*": result = num1 * num2; break;
            case "/":
                if (num2 != 0) result = num1 / num2;
                else { Console.WriteLine("Cannot divide by zero!"); valid = false; }
                break;
            default: Console.WriteLine("Invalid operator"); valid = false; break;
        }

        if (valid)
            Console.WriteLine("Result: " + result);
    }
}
