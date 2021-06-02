using Android.Runtime;
using System;

namespace Twilio.Conversations
{
    // Glue code that ensures that ICallbackListener.OnError works properly...
    internal partial class ICallbackListenerInvoker : Java.Lang.Object, ICallbackListener
    {
        static Delegate cb_onError_Lcom_twilio_conversations_ErrorInfo_;
#pragma warning disable 0169
        static Delegate GetOnError_Lcom_twilio_conversations_ErrorInfo_Handler()
        {
            if (cb_onError_Lcom_twilio_conversations_ErrorInfo_ == null)
                cb_onError_Lcom_twilio_conversations_ErrorInfo_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_OnError_Lcom_twilio_conversations_ErrorInfo_);
            return cb_onError_Lcom_twilio_conversations_ErrorInfo_;
        }

        static void n_OnError_Lcom_twilio_conversations_ErrorInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Twilio.Conversations.ICallbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = global::Java.Lang.Object.GetObject<global::Twilio.Conversations.ErrorInfo>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.OnError(p0);
        }
#pragma warning restore 0169

        IntPtr id_onError_Lcom_twilio_conversations_ErrorInfo_;
        public unsafe void OnError(global::Twilio.Conversations.ErrorInfo p0)
        {
            if (id_onError_Lcom_twilio_conversations_ErrorInfo_ == IntPtr.Zero)
                id_onError_Lcom_twilio_conversations_ErrorInfo_ = JNIEnv.GetMethodID(class_ref, "onError", "(Lcom/twilio/conversations/ErrorInfo;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onError_Lcom_twilio_conversations_ErrorInfo_, __args);
        }
    }
}