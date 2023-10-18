//پیدا کردن اعداد اول بین دو عدد
using System;
namespace Project3
{
    class test1
{
    public static void Main()
    {
        int i, j;

        Console.Write("Enter 2 numbers: ");
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());

        for (i = num1; i <= num2; ++i)
        {
            for (j = 2; j * j <= i; ++j)
            {
                if (i % j == 0)
                {
                    break;
                }
            }
            if (j * j > i)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}
}