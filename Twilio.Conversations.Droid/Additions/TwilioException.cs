namespace Twilio.Conversations
{
    public class TwilioException : Java.Lang.RuntimeException
    {
        public ErrorInfo ErrorInfo { get; }

        public TwilioException(ErrorInfo errorInfo) : base(errorInfo.Message)
        {
            ErrorInfo = errorInfo;
        }
    }
}