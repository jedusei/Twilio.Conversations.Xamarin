using Com.Twilio.Util;
using System;

namespace Twilio.Conversations
{
    public class MediaUploadListener : Java.Lang.Object, IMediaUploadListener
    {
        public delegate void ProgressDelegate(long bytesSent);
        public delegate void CompletionDelegate(string mediaSid);
        public delegate void FailureDelegate(ErrorInfo errorInfo);

        private readonly Action _onStarted;
        private readonly ProgressDelegate _onProgress;
        private readonly CompletionDelegate _onCompleted;
        private readonly FailureDelegate _onFailed;

        public MediaUploadListener(
            Action onStarted = null,
            ProgressDelegate onProgress = null,
            CompletionDelegate onCompleted = null,
            FailureDelegate onFailed = null)
        {
            _onStarted = onStarted;
            _onProgress = onProgress;
            _onCompleted = onCompleted;
            _onFailed = onFailed;
        }

        public void OnStarted()
        {
            _onStarted?.Invoke();
        }

        public void OnProgress(long bytes)
        {
            _onProgress?.Invoke(bytes);
        }

        public void OnCompleted(string mediaSid)
        {
            _onCompleted?.Invoke(mediaSid);
        }

        public void OnFailed(ErrorInfo errorInfo)
        {
            _onFailed?.Invoke(errorInfo);
        }
    }
}