using System;

namespace CampaignMonitorTest
{
    public class InvalidTriangleException : Exception
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public InvalidTriangleException()
        {
        }
        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="message">Input message to exception</param>
        public InvalidTriangleException(String message) :
            base(message)
        {

        }
    }
}
