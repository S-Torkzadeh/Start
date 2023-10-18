//نمایش اعداد فرد بین 0 تا 1000
using System;
namespace Project6
{
class test1
{
    public static void Main()
    {
        for (int i = 0; i <= 1000; i++)
        {
            if (i % 2 != 0)
                Console.WriteLine(i);
        }
    }
}
}