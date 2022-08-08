using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            try
            {
                Console.WriteLine(a/0);
                string m = Console.ReadLine();
            }catch(Exception k)
            {
                Console.WriteLine($"exception-{k}");
            }
        }
    }
}
