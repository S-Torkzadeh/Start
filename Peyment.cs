// دریافت اطلاعات و چاپ مباغ حق التدریس

using System;

namespace Project
{
    public class Teacher
    {
        private string id;
        private string name;
        private string lastname;
        private int hour;
        private int peyperonehour;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Peyperonehour
        {
            get { return peyperonehour; }
            set
            {
                if (value < 0)
                { peyperonehour = value; }
            }
        }
        public Teacher() { }
        public Teacher(string Id, string Name, string Lastname, int Hour, int Peyperonehour)
        {
            id = Id;
            name = Name;
            lastname = Lastname;
            hour = Hour;
            peyperonehour = Peyperonehour;
        }
        public double Peyment()
        {
            return hour * peyperonehour;
        }
    }
    class test
    {
        public static void Main()
        {
            Teacher th = new Teacher("123", "Ab", "Ahmad", 40, 40000);
            double Pey = th.Peyment();
            Console.WriteLine(Pey);
        }
    }
}