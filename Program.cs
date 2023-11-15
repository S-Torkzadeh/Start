// برنامه ای بنویسید که عددی خوانده و اگر فرد باشد مجموع و حاصل ضرب اعداد فرد تا ان عدد را حساب کند و اگر عدد خوانده شده زوج بود به همین صورت
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Project
{
    class test
    {
        public static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Even(x);
            }
            else
            {
                Odd(x);
            }
        }
        static void Even(int x)
        {
            int sum = 0;
            int mul = 1;
            for (int i = 2; i <= x; i+2)
            {
                sum += i;
                mul *= i;
            }
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }
        static void Odd (int x)
        {
            int sum = 0;
            int mul = 1;
            for (int i = 1; i <= x; i+2)
            {
                sum += i;
                mul *= i;
            }
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }
    }
}