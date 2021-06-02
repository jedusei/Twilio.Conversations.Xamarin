using Android.Runtime;
using System;

namespace Twilio.Conversations
{
    // See IConversationsClient.cs for info on why this is here.
    public partial interface IMessage
    {
        private static readonly IntPtr _messageOptionsClass = JNIEnv.FindClass("com/twilio/conversations/MessageImpl$OptionsImpl");

        public static IMessageOptions Options()
        {
            var handle = JNIEnv.CreateInstance(_messageOptionsClass, "()V");
            return Java.Lang.Object.GetObject<IMessageOptions>(handle, JniHandleOwnership.TransferLocalRef);
        }
    }
}