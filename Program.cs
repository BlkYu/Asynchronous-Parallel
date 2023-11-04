namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        //メインスレッド
        static void Main(string[] args)
        {
            //別スレッド
            var msg = "1";
            Task.Run(() => proc(msg));

            Thread.Sleep(10);
            msg = "0";

            //メインスレッド
            proc("2");
        }

        private static void proc(object param)
        {
            for (int i = 0; i < 1024; i++)
            {
                Console.Write(param);
            }
        }
    }
}