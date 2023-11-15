// محاسبه جواب محاسبات √(abs(x)+y^(2)) با استفاده از تابع و نمایش جواب در تابع
using System;
    namespace Project
{
    class test
    {
        public static void Main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Calc(x, y);
        }
        static void Calc(double x,double y)
        {
            double Result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));
            Console.WriteLine(Result);
        }
    }
}