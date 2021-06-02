using System;

namespace Twilio.Conversations
{
    public class ProgressListener : Java.Lang.Object, IProgressListener
    {
        public Action OnStartedAction { private get; set; }
        public Action<long> OnProgressAction { private get; set; }
        public Action<string> OnCompletedAction { private get; set; }

        public void OnStarted()
        {
            OnStartedAction?.Invoke();
        }

        public void OnProgress(long bytes)
        {
            OnProgressAction?.Invoke(bytes);
        }

        public void OnCompleted(string mediaSid)
        {
            OnCompletedAction?.Invoke(mediaSid);
        }
    }
}