using System;

namespace zadacha_3._3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.WriteLine("Введите n:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите x:");
                    double x = double.Parse(Console.ReadLine());
                    double S = 0;
                    int h = 0;
                    for (int i = 1; i < n; i++, h += 2)
                    {
                        long F = h;
                        for (int j = 1; j <= h; j++) F *= j;
                        S = (Math.Pow(x, h) / F);


                    }
                    Console.WriteLine("S={0:F2}", S);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

