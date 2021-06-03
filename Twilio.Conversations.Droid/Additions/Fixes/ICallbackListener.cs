using Android.Runtime;
using Java.Interop;

namespace Twilio.Conversations
{
    public partial interface ICallbackListener : IJavaObject, IJavaPeerable
    {
        [Register("onError", "(Lcom/twilio/conversations/ErrorInfo;)V", "GetOnError_Lcom_twilio_conversations_ErrorInfo_Handler:Twilio.Conversations.ICallbackListenerInvoker, Twilio.Conversations.Droid")]
        void OnError(ErrorInfo errorInfo)
        {
            // Had to add this manually because it was ignored by the bindings generator.
        }
    }
}