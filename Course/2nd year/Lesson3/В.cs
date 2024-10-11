using System;

class Program
{ 
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5};
        Console.WriteLine(numbers[1]);
        numbers[2] = 100;
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers.Length);
    }
}