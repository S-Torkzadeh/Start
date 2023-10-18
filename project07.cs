//نمایش اعداد زوج بین 50 تا 200
using System;
namespace Project7
{
class test1
{
    public static void Main()
    {
        for (int i = 20; i <= 500; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
}