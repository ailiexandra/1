using System;

class Program
{
    static void Main()

    {
        string basePath = @"C:/Users/me/source/repos";
        string path = "f.txt";
        using (StreamWriter sw = new StreamWriter(Path.Combine(basePath, path)))
        {
            sw.WriteLine("x\t\tsin(x)");
            for (double x = 0; x <= 1; x += 0.1)
            {
                sw.WriteLine($"{Math.Round(x, 1)}\t\t{Math.Round(Math.Sin(x), 4)}");
            }

        }

    }


}
