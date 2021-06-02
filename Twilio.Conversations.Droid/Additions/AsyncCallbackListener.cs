using Android.Runtime;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public class AsyncCallbackListener<T> : CallbackListener<T> where T : class, IJavaObject
    {
        readonly TaskCompletionSource<T> _tcs = new TaskCompletionSource<T>();

        public override void OnSuccess(T result)
        {
            _tcs.TrySetResult(result);
        }

        public override void OnError(ErrorInfo errorInfo)
        {
            _tcs.TrySetException(new TwilioException(errorInfo));
        }

        public Task<T> GetResultAsync() => _tcs.Task;
    }
}