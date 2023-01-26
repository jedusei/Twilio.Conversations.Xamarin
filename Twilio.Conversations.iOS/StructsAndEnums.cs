using ObjCRuntime;

namespace Twilio.Conversations
{
    [Native]
    public enum TCHDeliveryAmount : ulong
    {
        None = 0,
        Some,
        All
    }

    [Native]
    public enum TCHClientConnectionState : long
    {
        Unknown,
        Disconnected,
        Connected,
        Connecting,
        Denied,
        Error,
        FatalError
    }

    [Native]
    public enum TCHClientSynchronizationStatus : long
    {
        Started = 0,
        ConversationsListCompleted,
        Completed,
        Failed
    }

    [Native]
    public enum TCHLogLevel : long
    {
        Silent = 0,
        Fatal,
        Critical,
        Warning,
        Info,
        Debug,
        Trace
    }

    [Native]
    public enum TCHConversationUpdate : long
    {
        Status = 1,
        LastReadMessageIndex,
        UniqueName,
        FriendlyName,
        Attributes,
        LastMessage,
        UserNotificationLevel,
        State
    }

    [Native]
    public enum TCHConversationSynchronizationStatus : long
    {
        None = 0,
        Identifier,
        Metadata,
        All,
        Failed
    }

    [Native]
    public enum TCHConversationStatus : long
    {
        Joined = 1,
        NotParticipating
    }

    [Native]
    public enum TCHConversationState : long
    {
        Undefined = 0,
        Active,
        Inactive,
        Closed
    }

    [Native]
    public enum TCHConversationNotificationLevel : long
    {
        Default = 0,
        Muted
    }

    [Native]
    public enum TCHUserUpdate : long
    {
        FriendlyName = 0,
        Attributes,
        ReachabilityOnline,
        ReachabilityNotifiable
    }

    [Native]
    public enum TCHParticipantUpdate : long
    {
        LastReadMessageIndex = 0,
        LastReadTimestamp,
        Attributes
    }

    [Native]
    public enum TCHParticipantType : long
    {
        Unset = 0,
        Other,
        Chat,
        Sms,
        Whatsapp
    }

    [Native]
    public enum TCHMessageUpdate : long
    {
        Body = 0,
        Attributes,
        DeliveryReceipt,
        Subject
    }

    [Native]
    public enum TCHMessageType : long
    {
        Text = 0,
        Media
    }

    [Native]
    public enum TCHMediaCategory : ulong
    {
        Media,
        Body,
        History
    }

    [Native]
    public enum TCHCommandTimeout : long
    {
        Min = 10000,
        Max = 2147483647,
        Default = 90000
    }

    [Native]
    public enum TCHDeliveryStatus : ulong
    {
        Read = 0,
        Undelivered,
        Delivered,
        Failed,
        Sent,
        Queued
    }
}