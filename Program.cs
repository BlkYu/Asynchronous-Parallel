namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        static async Task Main(string[] _)
        {
            string str = await Method();
            Console.WriteLine($"{str}");
        }

        private static Task<string> Method()
        {
            Thread.Sleep( 1000 );
            return "messages";
        }
    }
}