using System;
using CountdownTimer;

namespace CountDownTimerTest
{
    public class LowerSubscriber
    {
        private readonly Timer _timer;

        public LowerSubscriber(Timer timer) => _timer = timer;

        public void Subscribe() => _timer.TimerEvent += ConvertString;

        private void ConvertString(object sender, TimerEventArgs e) =>
            Console.WriteLine(e.Words.ToLower());
    }
}
