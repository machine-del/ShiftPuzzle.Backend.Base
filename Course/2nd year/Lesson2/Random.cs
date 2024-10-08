using System;

class Program
{
    static void Main(string[] args)
    {
        int secretNum = 52;

        while (true)
        {
            Console.Write("Введите ваше число: ");
            string secretGuest = Console.ReadLine();
            int guestNum = Convert.ToInt32(secretGuest);

            if (secretNum == guestNum)
            {
                Console.WriteLine("Поздравляю! Вы отгадали число!");
                break;
            } else if (guestNum < secretNum)
            {
                Console.WriteLine("Ваше число слишком маленькое.");
            } else
            {
                Console.WriteLine("Ваше число слишком большое.");
            }
        }
    }
}