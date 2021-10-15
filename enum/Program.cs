using System;

namespace enumPractice
{
    public enum Days { Sat = 1, Sun, Mon= 0, Tue, Wed, Thu, Fri };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sun + " is day " + (int)Days.Sun);
            Console.WriteLine(Days.Tue + " is day " + (int)Days.Tue);
        }
    }
}
