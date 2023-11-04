namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        //メインスレッド
        static void Main(string[] args)
        {
            //別スレッド
            var msg = "1";
            Task.Run(() =>
            {
                for (int i = 0; i < 1024; i++)
                {
                    Console.Write(msg);
                }
            });
            Thread.Sleep(10);
            msg = "0";

            //メインスレッド
            for (int i = 0; i < 1024; i++)
            {
                Console.Write("2");
            }
        }

        private static void WriteOne()
        {
            for (int i = 0; i < 1024; i++)
            {
                Console.Write("1");
            }
        }
    }
}