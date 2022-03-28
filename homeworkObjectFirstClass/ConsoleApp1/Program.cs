using System;

namespace ConsoleApp1
{
    class Program
    {   
        static bool ff(string ff)
        {
            if (ff != "cadillac" && ff != "lincoln" && ff != "dodge" && ff != "chrysler")
            {
                return false;
                
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("insert");
            string gg = Console.ReadLine();
            bool fff = ff(gg);
            while(fff)
            {
                Console.WriteLine("helllo");

                gg = Console.ReadLine();
                fff = ff(gg);
            }

        }
    }
}
