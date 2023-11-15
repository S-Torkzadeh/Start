// برنامه دریافت نمره میانترم و پایانترم یک دانشجو و نمایش نمره نهایی در متد اصلی
using System;
namespace Project
{
    class tast
    {
        public static void Main()
        {
            double m = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            double res = Calc(m, p);
            Console.WriteLine(res);
        }
        static double Calc(double m, double p)
        {
            double res = (0.35 * m) + (0.65 * p);
            return res;
        }
    }
}