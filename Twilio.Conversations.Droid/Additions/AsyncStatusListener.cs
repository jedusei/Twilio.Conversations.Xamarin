using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public class AsyncStatusListener : Java.Lang.Object, IStatusListener
    {
        readonly TaskCompletionSource<bool> _tcs = new TaskCompletionSource<bool>();
        public Task Task => _tcs.Task;

        void IStatusListener.OnSuccess()
        {
            _tcs.TrySetResult(true);
        }

        void IStatusListener.OnError(ErrorInfo errorInfo)
        {
            _tcs.TrySetException(new TwilioException(errorInfo));
        }
    }
}