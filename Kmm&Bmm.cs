//محاسبه "ک م م" و "ب م م" اعداد
using System;
namespace Project
{
    class test
    {
        public static void Main()
        {
            Console.WriteLine("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kmm is:" + Kmm(num1, num2));
            Console.WriteLine("Bmm is:" + Bmm(num1, num2));
        }
        static int Kmm(int x, int y)
        {
            int temp = x * y / Bmm(x, y);
            return temp;
        }
        static int Bmm(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}