using System;

class Programm
{
    static void Main(string[] args)
    {
        int n;
        while (true)
        {
            Console.Write("введите нечётное число для задания размера массиву N x N: ");
            if (int.TryParse(Console.ReadLine(), out n) && n % 2 != 0)
            {
                break; 
            }
            Console.WriteLine("введите нечётное число!");
        }
        int[,] array = GenerateArray(n);
        PrintArray(array);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("элементы массива при обходе по спирали, начиная с центра:");
        Console.WriteLine(" ");
        Console.WriteLine(SpiralOrder(array));
    }
    static int[,] GenerateArray(int size)
    {
        int[,] array = new int[size, size];
        int value = 1;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                array[i, j] = value++;
            }
        }

        return array;
    }
    static void PrintArray(int[,] array)
    {
        int size = array.GetLength(0);
        Console.WriteLine(" ");
        Console.WriteLine("массив:");
        Console.WriteLine(" ");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static string SpiralOrder(int[,] array)
    {
        int size = array.GetLength(0);
        string result = "";
        int centerX = size / 2;
        int centerY = size / 2;
        result += array[centerX, centerY];
        int[] directionsX = { 0, 1, 0, -1 }; 
        int[] directionsY = { 1, 0, -1, 0 }; 
        int steps = 1; 
        int dir = 0; 
        int x = centerX, y = centerY; 
        
        while (steps < size)
        {
            for (int i = 0; i < steps; i++)
            {
                x += directionsX[dir];
                y += directionsY[dir];
                result += " " + array[x, y]; 
            }
            dir = (dir + 1) % 4;
            if (dir % 2 == 0) steps++;
        }

        for (int i = 0; i < steps; i++)
        {
            x += directionsX[dir];
            y += directionsY[dir];
            if (x >= 0 && x < size && y >= 0 && y < size)
            {
                result += " " + array[x, y]; 
            }
        }
        return result.Trim(); 
    }
}