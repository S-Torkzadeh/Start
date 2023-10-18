//میانگین نمرات 20 دانشجو
using System;
namespace Project8
{
class test1
{
   public static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Enter Score:");
            int num =Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        int ave = sum / 20;
        Console.WriteLine("Average is: " + ave);
    }
}
}