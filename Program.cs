namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        static async Task Main(string[] _)
        {
            Task[] arrayTask = new[]
            {
                Task.Run(()=>{Console.WriteLine("0"); }),
                Task.Run(()=>{Console.WriteLine("1"); }),
                Task.Run(()=>{Console.WriteLine("2"); }),
            };
            Task.WaitAll(arrayTask);
        }
    }
}