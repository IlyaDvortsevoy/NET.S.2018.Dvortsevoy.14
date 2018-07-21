using System;
using System.Threading;

namespace CountdownTimer
{
    /// <summary>
    /// Notifies subscribers upon the expiration of the given period of time
    /// </summary>
    public class Timer
    {
        #region Fields
        /// <summary>
        /// Event field for subscribtion
        /// </summary>
        public event EventHandler<TimerEventArgs> timerEvent;
        #endregion

        #region Public Methods
        /// <summary>
        /// Notifies the subscribers
        /// </summary>
        /// <param name="milliseconds"> The amount of time to count </param>
        public void Notify(int milliseconds)
        {
            ValidateTime(milliseconds);

            Thread.Sleep(milliseconds);

            OnTimeСome(this, new TimerEventArgs("HeLlO WoRLD!"));
        }
        #endregion


        protected virtual void OnTimeСome(object sender, TimerEventArgs e)
        {
            timerEvent.Invoke(this, e);
        }

        #region Private Methods
        private void ValidateTime(int milliseconds)
        {
            if (milliseconds <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Time interval must be greater than zero",
                    nameof(milliseconds));
            }
        }

        #endregion
    }
}