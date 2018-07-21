using System;
using CountdownTimer;

namespace CountDownTimerTest
{
    public class UpperSubscriber
    {
        private readonly Timer _timer;

        public UpperSubscriber(Timer timer) => _timer = timer;

        public void Subscribe() => _timer.timerEvent += ConvertString;

        private void ConvertString(object sender, TimerEventArgs e) =>
            Console.WriteLine(e.Words.ToUpper());
    }
}
