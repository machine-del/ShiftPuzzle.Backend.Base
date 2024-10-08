using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        string Input = Console.ReadLine();
        double num1 = Convert.ToDouble(Input);

        Console.Write("Введите второе число: ");
        string Input1 = Console.ReadLine();
        double num2 = Convert.ToDouble(Input1);

        double result = num1 + num2;

        Console.WriteLine("Результат: " + result);
    }
}