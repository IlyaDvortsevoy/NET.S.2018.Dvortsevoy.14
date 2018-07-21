using System;
using CountdownTimer;

namespace CountDownTimerTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var timer = new Timer();

            var upperSubscriber = new UpperSubscriber(timer);
            upperSubscriber.Subscribe();
            var lowerSubscriber = new LowerSubscriber(timer);
            lowerSubscriber.Subscribe();

            timer.Notify(3000);
        }
    }
}