using System;

namespace testAsync
{
    internal class Program
    {
        static  void Print()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("i=" + i);
            }
        }
        static async Task Main(string[] args)
        {
             Task.Run(Print); 
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("J=" + i);
            }
        }
    }
}
