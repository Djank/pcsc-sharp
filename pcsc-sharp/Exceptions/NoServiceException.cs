﻿using System;

namespace PCSC
{
    /// <summary>
    /// The PC/SC service is not running.
    /// </summary>
    public class NoServiceException : PCSCException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoServiceException"/> class.
        /// </summary>
        /// <param name="serr">System's error code</param>
        public NoServiceException(SCardError serr)
            : base(serr) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="NoServiceException"/> class.
        /// </summary>
        /// <param name="serr">System's error code</param>
        /// <param name="message">An error message text.</param>
        public NoServiceException(SCardError serr, string message)
            : base(serr, message) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="NoServiceException"/> class.
        /// </summary>
        /// <param name="serr">System's error code</param>
        /// <param name="message">An error message text.</param>
        /// <param name="innerException">The inner exception.</param>
        public NoServiceException(SCardError serr, string message, Exception innerException)
            : base(serr, message, innerException) {}
    }
}
