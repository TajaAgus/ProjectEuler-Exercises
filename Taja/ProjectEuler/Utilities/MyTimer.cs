namespace ProjectEuler.Utilities
{
    public class MyTimer
    {
        DateTime startTime;
        public MyTimer()
        {
            startTime = DateTime.Now;
        }

        public void End()
        {
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine("La operación tomó {0} segundos", Math.Round(duration.TotalSeconds, 4));
        }
    }
}
