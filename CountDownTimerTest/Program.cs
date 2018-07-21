using System;
using CountdownTimer;

namespace CountDownTimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();

            var upperSubscriber = new UpperSubscriber(timer);
            upperSubscriber.Subscribe();
            var lowerSubscriber = new LowerSubscriber(timer);
            lowerSubscriber.Subscribe();

            timer.Notify(2000);
        }
    }
}