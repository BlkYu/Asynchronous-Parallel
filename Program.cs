﻿namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 1024; i++)
                {
                    Console.Write("1");
                }
                
            });
            for (int i = 0; i < 1024; i++)
            {
                Console.Write("2");
            }
        }
    }
}