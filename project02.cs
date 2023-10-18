//دریافت عدد و اعلام مجموع ارقام
using System;
namespace Project2
{
class test2
{
    public static void Main()
    {
        int sum = 0;

        Console.WriteLine("Enter a Number: ");
       int number=Convert.ToInt32(Console.ReadLine());

        while (number != 0)
        {
            int temp = number % 10;
            sum += temp;
            number /= 10;
        }

        Console.WriteLine("Sum is: " + sum);
    }
}
}