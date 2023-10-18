//پیدا کردن دترمینان ماتریس 3 در 3
using System;
namespace Preject4
{
class test1
{
    public static void Main()
    {
        int[,] arr = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter 6 number: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int determinant = (arr[1, 1] * arr[2, 2]) - (arr[1, 2] * arr[2, 1]) + (arr[1, 0] * arr[2, 2]) - (arr[1, 2] * arr[2, 0]) + (arr[1, 0] * arr[2, 1]) - (arr[1, 1] * arr[2, 0]);
        Console.WriteLine("Determinant is = " + determinant);
    }
}
}