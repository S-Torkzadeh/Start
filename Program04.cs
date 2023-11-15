// محاسبه حجم یک مکعب
using System;

namespace Project
{
    class Voloum
{
    public static void Main()
    {
        double L = Convert.ToDouble(Console.ReadLine());
        double W = Convert.ToDouble(Console.ReadLine());
        double H = Convert.ToDouble(Console.ReadLine());
            double Result = Calc(L, W, H);
            Console.WriteLine(Result);
        }

        static double Calc(double num1, double num2, double num3)
        {
            double Vol = num1 * num2 * num3;
            return Vol;
        }
}
}
