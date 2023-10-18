//چاپ معکوس عدد دو رقمی
using System;
namespace Project9
{
class test1
{
   public static void Main()
    {
        int num, temp, f, z;
        Console.WriteLine("Enter Number:");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num / 10;
        f = num % 10;
        z = f * 10 + temp;
        Console.WriteLine(z);
    }
}
}