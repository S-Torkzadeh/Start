//√(abs(2)+√(abs(2)+√(abs(2)))) محاسبه جواب رابطه
using System;
namespace Preject5
{
class test1
{
   public static void Main()
    {
       Console.WriteLine("Enter x:");
       int x=Convert.ToInt32(Console.ReadLine());
       double Result=Math.Sqrt(Math.Abs(x)+Math.Sqrt(Math.Abs(x)+(Math.Sqrt(Math.Abs(x)))));
       Console.WriteLine(Result);
       
    }
}
}