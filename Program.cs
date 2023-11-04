namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(new Func<int>(() =>
            //var task = Task.Run(() =>
            {
                var sum = 0;
                for (int i = 0; i < 16; i++)
                {
                    sum += i;
                    Console.Write($"{i}+");
                }
                Console.Write("\b \b");
                return sum;
            }));
            Console.WriteLine($" = {task.Result}");

        }
    }
}