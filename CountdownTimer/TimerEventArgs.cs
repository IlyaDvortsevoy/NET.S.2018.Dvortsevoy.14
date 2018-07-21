using System;

namespace CountdownTimer
{
    /// <summary>
    /// Represents event arguments specific for <see cref="T:CountdownTimer.Timer"/> class
    /// </summary>
    public class TimerEventArgs : EventArgs
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CountdownTimer.TimerEventArgs" /> class
        /// </summary>
        /// <param name="word"> Random words </param>
        public TimerEventArgs(string words)
        {
            Words = words;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a random words
        /// </summary>
        public string Words { get; }
        #endregion
    }
}