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
        public event EventHandler<TimerEventArgs> TimerEvent;
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

        #region Protected Methods
        /// <summary>
        /// Invokes all subscribers of <see cref="TimerEvent"/>
        /// </summary>
        /// <param name="sender"> The object which initialized the event </param>
        /// <param name="e"> Event arguments </param>
        protected virtual void OnTimeСome(object sender, TimerEventArgs e)
        {
            TimerEvent?.Invoke(this, e);
        }
        #endregion

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