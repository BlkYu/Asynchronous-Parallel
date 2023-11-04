namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        //メインスレッド
        static void Main(string[] args)
        {
            //別スレッド
            Task.Run(() => WriteOne("1"));

            //メインスレッド
            WriteOne("2");
        }

        private static void WriteOne(string target)
        {
            for (int i = 0; i < 1024; i++)
            {
                Console.Write(target);
            }
        }
    }
}