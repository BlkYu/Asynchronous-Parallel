namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        static async Task Main(string[] _)
        {
            Task<string>[] arrayTask = new[]
            {
                Task<string>.Run(()=>{return "A"; }),
                Task<string>.Run(()=>{ return "B"; }),
                Task<string>.Run(()=>{ return "C"; })
            };

            for (int i = 0; i < arrayTask.Length; i++)
            {
                Console.WriteLine("Result[{0}] = {1}.", i, arrayTask[i].Result);
            }
        }
    }
}