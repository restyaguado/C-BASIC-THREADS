namespace BasicThread
{
    class MyThreadClass
    {
        public static Action<string>? Output;

        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Output?.Invoke("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}
