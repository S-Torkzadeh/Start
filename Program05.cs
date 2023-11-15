//محاسبه جواب سوال x^(2)+4×x−5 با استفاده از تابع
using System;
namespace Project
{
    class test
    {
        public static void Main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double Res = Calc(x);
            Console.WriteLine(Res);
        }
        static double Calc(double num)
        {
            double res = Math.Pow(num, 2) + (4 * num) - 5;
            return res;
        }
    }
}