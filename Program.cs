namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        //メインスレッド
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                //別スレッド
                for (int i = 0; i < 1024; i++)
                {
                    Console.Write("1");
                }
            });

            //メインスレッド
            for (int i = 0; i < 1024; i++)
            {
                Console.Write("2");
            }
        }
    }
}