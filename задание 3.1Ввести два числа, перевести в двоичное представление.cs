using System;

class Program
{
    static void Main()
    {
        
        Console.Write("введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        string binary1 = Convert.ToString(num1, 2).PadLeft(8, '0');
        string binary2 = Convert.ToString(num2, 2).PadLeft(8, '0');

        Console.WriteLine($"первое число в двоичном представлении: {binary1}");
        Console.WriteLine($"второе число в двоичном представлении: {binary2}");

        int sum = num1 + num2;
        string binarySum = Convert.ToString(sum, 2).PadLeft(8, '0');

        Console.WriteLine($"сумма в двоичном представлении: {binarySum}");

        Console.WriteLine($"сумма в десятичном виде: {sum}");
    }
}
