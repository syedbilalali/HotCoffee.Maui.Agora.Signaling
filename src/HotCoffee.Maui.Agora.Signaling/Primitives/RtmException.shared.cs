namespace HotCoffee.Maui.Agora.Signaling.Primitives
{   
    /// <summary>
    /// This class used to generate custom exception for the RtmManager class critical exceptions.
    /// </summary>
    public class RtmException : Exception
    {   
        /// <summary>
        /// Constructor which use to define the exceptions.
        /// </summary>
        /// <param name="message">You need the pass the exception messages when any critical error occur</param>
        public RtmException(string message) : base(message)
        {


        }
    }
}
