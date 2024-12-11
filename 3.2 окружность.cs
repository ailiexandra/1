using System;

class Program
{
    static void Main()
    {
        int radius = 4;
        for (int y = 0; y < 2 * radius; y++)
        {
            for (int x = 0; x < 2 * radius; x++)
            {
                if ((y - radius) * (y - radius) + (x - radius) * (x - radius) < radius * radius)
                    Console.Write('*');
                else
                    Console.Write(' ');
                    
            }
            Console.Write(' ');
        Console.WriteLine();
        }
        
    }
}

