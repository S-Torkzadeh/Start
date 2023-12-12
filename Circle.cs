// محاسبه محیط و مساحت دایره با استفاده از شی گرایی

using System;

namespace Project
{
    public class Circle
    {
        private double r;
        double pi = 3.14;
        public double R
        {
            get { return r;}
            set
            {
                if (value < 0)
                { r = value;}
            }
        }
        public Circle() { }
        public Circle(double R)
        {
            r = R;
        }
        public double S()
        {
            double res = pi + Math.Pow(r, 2);
            return res;
        }
        public double A()
        {
            double res = pi*r*2;
            return res;
        }
    }
    class test
    {
        public static void Main()
        {
            Circle C = new Circle(12);
            double a = C.A();
            double s = C.S();
            Console.WriteLine(a);
            Console.WriteLine(s);
        }
    }
}