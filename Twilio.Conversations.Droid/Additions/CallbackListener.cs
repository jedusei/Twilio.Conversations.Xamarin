using Android.Runtime;

namespace Twilio.Conversations
{
    public abstract class CallbackListener<T> : Java.Lang.Object, ICallbackListener where T : class, IJavaObject
    {
        void ICallbackListener.OnSuccess(Java.Lang.Object result)
        {
            OnSuccess(result.JavaCast<T>());
        }

        public abstract void OnSuccess(T result);
        public virtual void OnError(ErrorInfo errorInfo) { }
    }
}
