//پیدا کردن بزرگترین عدد در یک ارایه 3 در 3
using System;
namespace Project1
{
class test1
{
    public static void Main()
    {
        int temp = 0;
        int[,] arr = new int[3, 3];

        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter 6 Number:");
                arr[i, j] =Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (arr[i, j] > temp)
                {
                    temp = arr[i, j];
                }
            }
        }

        Console.WriteLine("Max is: " + temp);
    }
}
}