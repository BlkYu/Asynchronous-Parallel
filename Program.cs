namespace Asynchronous_ParallelApp
{
    internal class Program
    {
        //メインスレッド
        static void Main(string[] args)
        {
            //別スレッド
            //var task = new Task(new Action(WriteOne));
            var task = new Task(WriteOne);
            task.Start();

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