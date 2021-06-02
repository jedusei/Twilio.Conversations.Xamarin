using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Twilio.Conversations
{
    // @interface TCHError : NSError
    [BaseType(typeof(NSError))]
    interface TCHError
    {
    }

    // @interface TCHResult : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHResult
    {
        // @property (readonly, nonatomic, strong) TCHError * _Nullable error;
        [NullAllowed, Export("error", ArgumentSemantic.Strong)]
        TCHError Error { get; }

        // @property (readonly, assign, nonatomic) NSInteger resultCode;
        [Export("resultCode")]
        nint ResultCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable resultText;
        [NullAllowed, Export("resultText")]
        string ResultText { get; }

        // @property (readonly) BOOL isSuccessful;
        [Export("isSuccessful")]
        bool IsSuccessful { get; }
    }

    // typedef void (^TCHCompletion)(TCHResult * _Nonnull);
    delegate void TCHCompletion(TCHResult arg0);

    // typedef void (^TCHTwilioClientCompletion)(TCHResult * _Nonnull, TwilioConversationsClient * _Nullable);
    delegate void TCHTwilioClientCompletion(TCHResult arg0, [NullAllowed] TwilioConversationsClient arg1);

    // typedef void (^TCHConversationCompletion)(TCHResult * _Nonnull, TCHConversation * _Nullable);
    delegate void TCHConversationCompletion(TCHResult arg0, [NullAllowed] TCHConversation arg1);

    // typedef void (^TCHMessageCompletion)(TCHResult * _Nonnull, TCHMessage * _Nullable);
    delegate void TCHMessageCompletion(TCHResult arg0, [NullAllowed] TCHMessage arg1);

    // typedef void (^TCHMessagesCompletion)(TCHResult * _Nonnull, NSArray<TCHMessage *> * _Nullable);
    delegate void TCHMessagesCompletion(TCHResult arg0, [NullAllowed] TCHMessage[] arg1);

    // typedef void (^TCHUserCompletion)(TCHResult * _Nonnull, TCHUser * _Nullable);
    delegate void TCHUserCompletion(TCHResult arg0, [NullAllowed] TCHUser arg1);

    // typedef void (^TCHCountCompletion)(TCHResult * _Nonnull, NSUInteger);
    delegate void TCHCountCompletion(TCHResult arg0, nuint arg1);

    // typedef void (^TCHNullableCountCompletion)(TCHResult * _Nonnull, NSNumber * _Nullable);
    delegate void TCHNullableCountCompletion(TCHResult arg0, [NullAllowed] NSNumber arg1);

    // typedef void (^TCHStringCompletion)(TCHResult * _Nonnull, NSString * _Nullable);
    delegate void TCHStringCompletion(TCHResult arg0, [NullAllowed] string arg1);

    // typedef void (^TCHDetailedDeliveryReceiptsCompletion)(TCHResult * _Nonnull, NSArray<TCHDetailedDeliveryReceipt *> * _Nullable);
    delegate void TCHDetailedDeliveryReceiptsCompletion(TCHResult arg0, [NullAllowed] TCHDetailedDeliveryReceipt[] arg1);

    // typedef void (^TCHMediaOnStarted)();
    delegate void TCHMediaOnStarted();

    // typedef void (^TCHMediaOnProgress)(NSUInteger);
    delegate void TCHMediaOnProgress(nuint arg0);

    // typedef void (^TCHMediaOnCompleted)(NSString * _Nonnull);
    delegate void TCHMediaOnCompleted(string arg0);

    [Static]
    //[Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull TCHConversationOptionFriendlyName;
        [Field("TCHConversationOptionFriendlyName", "__Internal")]
        NSString TCHConversationOptionFriendlyName { get; }

        // extern NSString *const _Nonnull TCHConversationOptionUniqueName;
        [Field("TCHConversationOptionUniqueName", "__Internal")]
        NSString TCHConversationOptionUniqueName { get; }

        // extern NSString *const _Nonnull TCHConversationOptionAttributes;
        [Field("TCHConversationOptionAttributes", "__Internal")]
        NSString TCHConversationOptionAttributes { get; }

        // extern NSString *const _Nonnull TCHErrorDomain;
        [Field("TCHErrorDomain", "__Internal")]
        NSString TCHErrorDomain { get; }

        // extern const NSInteger TCHErrorGeneric;
        [Field("TCHErrorGeneric", "__Internal")]
        nint TCHErrorGeneric { get; }

        // extern NSString *const _Nonnull TCHErrorMsgKey;
        [Field("TCHErrorMsgKey", "__Internal")]
        NSString TCHErrorMsgKey { get; }
    }

    // @interface TCHJsonAttributes : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHJsonAttributes
    {
        // -(instancetype _Null_unspecified)initWithDictionary:(NSDictionary * _Nonnull)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);

        // -(instancetype _Null_unspecified)initWithArray:(NSArray * _Nonnull)array;
        [Export("initWithArray:")]
        //[Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] array);

        // -(instancetype _Null_unspecified)initWithString:(NSString * _Nonnull)string;
        [Export("initWithString:")]
        IntPtr Constructor(string @string);

        // -(instancetype _Null_unspecified)initWithNumber:(NSNumber * _Nonnull)number;
        [Export("initWithNumber:")]
        IntPtr Constructor(NSNumber number);

        // @property (readonly) BOOL isDictionary;
        [Export("isDictionary")]
        bool IsDictionary { get; }

        // @property (readonly) BOOL isArray;
        [Export("isArray")]
        bool IsArray { get; }

        // @property (readonly) BOOL isString;
        [Export("isString")]
        bool IsString { get; }

        // @property (readonly) BOOL isNumber;
        [Export("isNumber")]
        bool IsNumber { get; }

        // @property (readonly) BOOL isNull;
        [Export("isNull")]
        bool IsNull { get; }

        // @property (readonly) NSDictionary * _Nullable dictionary;
        [NullAllowed, Export("dictionary")]
        NSDictionary Dictionary { get; }

        // @property (readonly) NSArray * _Nullable array;
        [NullAllowed, Export("array")]
        //[Verify (StronglyTypedNSArray)]
        NSObject[] Array { get; }

        // @property (readonly) NSString * _Nullable string;
        [NullAllowed, Export("string")]
        string String { get; }

        // @property (readonly) NSNumber * _Nullable number;
        [NullAllowed, Export("number")]
        NSNumber Number { get; }
    }

    // @interface TCHUser : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHUser
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable identity;
        [NullAllowed, Export("identity")]
        string Identity { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable friendlyName;
        [NullAllowed, Export("friendlyName")]
        string FriendlyName { get; }

        // -(TCHJsonAttributes * _Nullable)attributes;
        [NullAllowed, Export("attributes")]
        //[Verify (MethodToProperty)]
        TCHJsonAttributes Attributes { get; }

        // -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("setAttributes:completion:")]
        void SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(void)setFriendlyName:(NSString * _Nullable)friendlyName completion:(TCHCompletion _Nullable)completion;
        [Export("setFriendlyName:completion:")]
        void SetFriendlyName([NullAllowed] string friendlyName, [NullAllowed] TCHCompletion completion);

        // -(BOOL)isOnline;
        [Export("isOnline")]
        //[Verify (MethodToProperty)]
        bool IsOnline { get; }

        // -(BOOL)isNotifiable;
        [Export("isNotifiable")]
        //[Verify (MethodToProperty)]
        bool IsNotifiable { get; }

        // -(BOOL)isSubscribed;
        [Export("isSubscribed")]
        //[Verify (MethodToProperty)]
        bool IsSubscribed { get; }

        // -(void)unsubscribe;
        [Export("unsubscribe")]
        void Unsubscribe();
    }

    // @interface TCHAggregatedDeliveryReceipt : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHAggregatedDeliveryReceipt
    {
        // @property (readonly) NSInteger total;
        [Export("total")]
        nint Total { get; }

        // @property (readonly) TCHDeliveryAmount sent;
        [Export("sent")]
        TCHDeliveryAmount Sent { get; }

        // @property (readonly) TCHDeliveryAmount delivered;
        [Export("delivered")]
        TCHDeliveryAmount Delivered { get; }

        // @property (readonly) TCHDeliveryAmount undelivered;
        [Export("undelivered")]
        TCHDeliveryAmount Undelivered { get; }

        // @property (readonly) TCHDeliveryAmount read;
        [Export("read")]
        TCHDeliveryAmount Read { get; }

        // @property (readonly) TCHDeliveryAmount failed;
        [Export("failed")]
        TCHDeliveryAmount Failed { get; }
    }

    // @interface TCHDetailedDeliveryReceipt : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHDetailedDeliveryReceipt
    {
        // @property (readonly) TCHDeliveryStatus status;
        [Export("status")]
        TCHDeliveryStatus Status { get; }

        // @property (readonly) NSString * sid;
        [Export("sid")]
        string Sid { get; }

        // @property (readonly) NSString * messageSid;
        [Export("messageSid")]
        string MessageSid { get; }

        // @property (readonly) NSString * conversationSid;
        [Export("conversationSid")]
        string ConversationSid { get; }

        // @property (readonly) NSString * channelMessageSid;
        [Export("channelMessageSid")]
        string ChannelMessageSid { get; }

        // @property (readonly) NSString * participantSid;
        [Export("participantSid")]
        string ParticipantSid { get; }

        // @property (readonly) NSInteger errorCode;
        [Export("errorCode")]
        nint ErrorCode { get; }

        // @property (readonly) NSDate * dateCreatedAsDate;
        [Export("dateCreatedAsDate")]
        NSDate DateCreatedAsDate { get; }

        // @property (readonly) NSDate * dateUpdatedAsDate;
        [Export("dateUpdatedAsDate")]
        NSDate DateUpdatedAsDate { get; }
    }

    // @interface TCHMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHMessage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable sid;
        [NullAllowed, Export("sid")]
        string Sid { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable index;
        [NullAllowed, Export("index", ArgumentSemantic.Copy)]
        NSNumber Index { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable author;
        [NullAllowed, Export("author")]
        string Author { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable subject;
        [NullAllowed, Export("subject")]
        string Subject { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable body;
        [NullAllowed, Export("body")]
        string Body { get; }

        // @property (readonly, assign, nonatomic) TCHMessageType messageType;
        [Export("messageType", ArgumentSemantic.Assign)]
        TCHMessageType MessageType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaSid;
        [NullAllowed, Export("mediaSid")]
        string MediaSid { get; }

        // @property (readonly, assign, nonatomic) NSUInteger mediaSize;
        [Export("mediaSize")]
        nuint MediaSize { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaType;
        [NullAllowed, Export("mediaType")]
        string MediaType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaFilename;
        [NullAllowed, Export("mediaFilename")]
        string MediaFilename { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable participantSid;
        [NullAllowed, Export("participantSid")]
        string ParticipantSid { get; }

        // @property (readonly, copy, nonatomic) TCHParticipant * _Nullable participant;
        [NullAllowed, Export("participant", ArgumentSemantic.Copy)]
        TCHParticipant Participant { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable dateCreated;
        [NullAllowed, Export("dateCreated")]
        string DateCreated { get; }

        // @property (readonly, nonatomic, strong) NSDate * _Nullable dateCreatedAsDate;
        [NullAllowed, Export("dateCreatedAsDate", ArgumentSemantic.Strong)]
        NSDate DateCreatedAsDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable dateUpdated;
        [NullAllowed, Export("dateUpdated")]
        string DateUpdated { get; }

        // @property (readonly, nonatomic, strong) NSDate * _Nullable dateUpdatedAsDate;
        [NullAllowed, Export("dateUpdatedAsDate", ArgumentSemantic.Strong)]
        NSDate DateUpdatedAsDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable lastUpdatedBy;
        [NullAllowed, Export("lastUpdatedBy")]
        string LastUpdatedBy { get; }

        // @property (readonly) TCHAggregatedDeliveryReceipt * _Nullable aggregatedDeliveryReceipt;
        [NullAllowed, Export("aggregatedDeliveryReceipt")]
        TCHAggregatedDeliveryReceipt AggregatedDeliveryReceipt { get; }

        // -(void)getDetailedDeliveryReceiptsWithCompletion:(TCHDetailedDeliveryReceiptsCompletion _Nonnull)completion;
        [Export("getDetailedDeliveryReceiptsWithCompletion:")]
        void GetDetailedDeliveryReceiptsWithCompletion(TCHDetailedDeliveryReceiptsCompletion completion);

        // -(void)updateBody:(NSString * _Nonnull)body completion:(TCHCompletion _Nullable)completion;
        [Export("updateBody:completion:")]
        void UpdateBody(string body, [NullAllowed] TCHCompletion completion);

        // -(TCHJsonAttributes * _Nullable)attributes;
        [NullAllowed, Export("attributes")]
        //[Verify (MethodToProperty)]
        TCHJsonAttributes Attributes { get; }

        // -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("setAttributes:completion:")]
        void SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(BOOL)hasMedia;
        [Export("hasMedia")]
        //[Verify (MethodToProperty)]
        bool HasMedia { get; }

        // -(void)getMediaContentTemporaryUrlWithCompletion:(TCHStringCompletion _Nonnull)completion;
        [Export("getMediaContentTemporaryUrlWithCompletion:")]
        void GetMediaContentTemporaryUrlWithCompletion(TCHStringCompletion completion);
    }

    // @interface TCHMessageOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHMessageOptions
    {
        // -(instancetype _Nonnull)withBody:(NSString * _Nonnull)body;
        [Export("withBody:")]
        TCHMessageOptions WithBody(string body);

        // -(instancetype _Nonnull)withMediaStream:(NSInputStream * _Nonnull)mediaStream contentType:(NSString * _Nonnull)contentType defaultFilename:(NSString * _Nullable)defaultFilename onStarted:(TCHMediaOnStarted _Nullable)onStarted onProgress:(TCHMediaOnProgress _Nullable)onProgress onCompleted:(TCHMediaOnCompleted _Nullable)onCompleted;
        [Export("withMediaStream:contentType:defaultFilename:onStarted:onProgress:onCompleted:")]
        TCHMessageOptions WithMediaStream(NSInputStream mediaStream, string contentType, [NullAllowed] string defaultFilename, [NullAllowed] TCHMediaOnStarted onStarted, [NullAllowed] TCHMediaOnProgress onProgress, [NullAllowed] TCHMediaOnCompleted onCompleted);

        // -(instancetype _Nullable)withAttributes:(TCHJsonAttributes * _Nonnull)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("withAttributes:completion:")]
        [return: NullAllowed]
        TCHMessageOptions WithAttributes(TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);
    }

    // @interface TCHConversation : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHConversation
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        TCHConversationDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<TCHConversationDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable sid;
        [NullAllowed, Export("sid")]
        string Sid { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable friendlyName;
        [NullAllowed, Export("friendlyName")]
        string FriendlyName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable uniqueName;
        [NullAllowed, Export("uniqueName")]
        string UniqueName { get; }

        // @property (readonly, assign, nonatomic) TCHConversationNotificationLevel notificationLevel;
        [Export("notificationLevel", ArgumentSemantic.Assign)]
        TCHConversationNotificationLevel NotificationLevel { get; }

        // @property (readonly, assign, nonatomic) TCHConversationSynchronizationStatus synchronizationStatus;
        [Export("synchronizationStatus", ArgumentSemantic.Assign)]
        TCHConversationSynchronizationStatus SynchronizationStatus { get; }

        // @property (readonly, assign, nonatomic) TCHConversationStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        TCHConversationStatus Status { get; }

        // @property (readonly) TCHConversationState state;
        [Export("state")]
        TCHConversationState State { get; }

        // @property (readonly) NSDate * _Nullable stateDateUpdatedAsDate;
        [NullAllowed, Export("stateDateUpdatedAsDate")]
        NSDate StateDateUpdatedAsDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable createdBy;
        [NullAllowed, Export("createdBy")]
        string CreatedBy { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable dateCreated;
        [NullAllowed, Export("dateCreated", ArgumentSemantic.Strong)]
        string DateCreated { get; }

        // @property (readonly, nonatomic, strong) NSDate * _Nullable dateCreatedAsDate;
        [NullAllowed, Export("dateCreatedAsDate", ArgumentSemantic.Strong)]
        NSDate DateCreatedAsDate { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable dateUpdated;
        [NullAllowed, Export("dateUpdated", ArgumentSemantic.Strong)]
        string DateUpdated { get; }

        // @property (readonly, nonatomic, strong) NSDate * _Nullable dateUpdatedAsDate;
        [NullAllowed, Export("dateUpdatedAsDate", ArgumentSemantic.Strong)]
        NSDate DateUpdatedAsDate { get; }

        // @property (readonly, nonatomic, strong) NSDate * _Nullable lastMessageDate;
        [NullAllowed, Export("lastMessageDate", ArgumentSemantic.Strong)]
        NSDate LastMessageDate { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable lastMessageIndex;
        [NullAllowed, Export("lastMessageIndex", ArgumentSemantic.Strong)]
        NSNumber LastMessageIndex { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable lastReadMessageIndex;
        [NullAllowed, Export("lastReadMessageIndex", ArgumentSemantic.Copy)]
        NSNumber LastReadMessageIndex { get; }

        // -(TCHJsonAttributes * _Nullable)attributes;
        [NullAllowed, Export("attributes")]
        //[Verify (MethodToProperty)]
        TCHJsonAttributes Attributes { get; }

        // -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("setAttributes:completion:")]
        void SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(void)setFriendlyName:(NSString * _Nullable)friendlyName completion:(TCHCompletion _Nullable)completion;
        [Export("setFriendlyName:completion:")]
        void SetFriendlyName([NullAllowed] string friendlyName, [NullAllowed] TCHCompletion completion);

        // -(void)setUniqueName:(NSString * _Nullable)uniqueName completion:(TCHCompletion _Nullable)completion;
        [Export("setUniqueName:completion:")]
        void SetUniqueName([NullAllowed] string uniqueName, [NullAllowed] TCHCompletion completion);

        // -(void)setNotificationLevel:(TCHConversationNotificationLevel)notificationLevel completion:(TCHCompletion _Nullable)completion;
        [Export("setNotificationLevel:completion:")]
        void SetNotificationLevel(TCHConversationNotificationLevel notificationLevel, [NullAllowed] TCHCompletion completion);

        // -(void)joinWithCompletion:(TCHCompletion _Nullable)completion;
        [Export("joinWithCompletion:")]
        void JoinWithCompletion([NullAllowed] TCHCompletion completion);

        // -(void)leaveWithCompletion:(TCHCompletion _Nullable)completion;
        [Export("leaveWithCompletion:")]
        void LeaveWithCompletion([NullAllowed] TCHCompletion completion);

        // -(void)destroyWithCompletion:(TCHCompletion _Nullable)completion;
        [Export("destroyWithCompletion:")]
        void DestroyWithCompletion([NullAllowed] TCHCompletion completion);

        // -(void)typing;
        [Export("typing")]
        void Typing();

        // -(void)sendMessageWithOptions:(TCHMessageOptions * _Nonnull)options completion:(TCHMessageCompletion _Nullable)completion;
        [Export("sendMessageWithOptions:completion:")]
        void SendMessageWithOptions(TCHMessageOptions options, [NullAllowed] TCHMessageCompletion completion);

        // -(void)removeMessage:(TCHMessage * _Nonnull)message completion:(TCHCompletion _Nullable)completion;
        [Export("removeMessage:completion:")]
        void RemoveMessage(TCHMessage message, [NullAllowed] TCHCompletion completion);

        // -(void)getLastMessagesWithCount:(NSUInteger)count completion:(TCHMessagesCompletion _Nonnull)completion;
        [Export("getLastMessagesWithCount:completion:")]
        void GetLastMessagesWithCount(nuint count, TCHMessagesCompletion completion);

        // -(void)getMessagesBefore:(NSUInteger)index withCount:(NSUInteger)count completion:(TCHMessagesCompletion _Nonnull)completion;
        [Export("getMessagesBefore:withCount:completion:")]
        void GetMessagesBefore(nuint index, nuint count, TCHMessagesCompletion completion);

        // -(void)getMessagesAfter:(NSUInteger)index withCount:(NSUInteger)count completion:(TCHMessagesCompletion _Nonnull)completion;
        [Export("getMessagesAfter:withCount:completion:")]
        void GetMessagesAfter(nuint index, nuint count, TCHMessagesCompletion completion);

        // -(void)messageWithIndex:(NSNumber * _Nonnull)index completion:(TCHMessageCompletion _Nonnull)completion;
        [Export("messageWithIndex:completion:")]
        void MessageWithIndex(NSNumber index, TCHMessageCompletion completion);

        // -(void)messageForReadIndex:(NSNumber * _Nonnull)index completion:(TCHMessageCompletion _Nonnull)completion;
        [Export("messageForReadIndex:completion:")]
        void MessageForReadIndex(NSNumber index, TCHMessageCompletion completion);

        // -(void)setLastReadMessageIndex:(NSNumber * _Nonnull)index completion:(TCHCountCompletion _Nullable)completion;
        [Export("setLastReadMessageIndex:completion:")]
        void SetLastReadMessageIndex(NSNumber index, [NullAllowed] TCHCountCompletion completion);

        // -(void)advanceLastReadMessageIndex:(NSNumber * _Nonnull)index completion:(TCHCountCompletion _Nullable)completion;
        [Export("advanceLastReadMessageIndex:completion:")]
        void AdvanceLastReadMessageIndex(NSNumber index, [NullAllowed] TCHCountCompletion completion);

        // -(void)setAllMessagesReadWithCompletion:(TCHCountCompletion _Nullable)completion;
        [Export("setAllMessagesReadWithCompletion:")]
        void SetAllMessagesReadWithCompletion([NullAllowed] TCHCountCompletion completion);

        // -(void)setAllMessagesUnreadWithCompletion:(TCHNullableCountCompletion _Nullable)completion;
        [Export("setAllMessagesUnreadWithCompletion:")]
        void SetAllMessagesUnreadWithCompletion([NullAllowed] TCHNullableCountCompletion completion);

        // -(void)getUnreadMessagesCountWithCompletion:(TCHNullableCountCompletion _Nonnull)completion;
        [Export("getUnreadMessagesCountWithCompletion:")]
        void GetUnreadMessagesCountWithCompletion(TCHNullableCountCompletion completion);

        // -(void)getMessagesCountWithCompletion:(TCHCountCompletion _Nonnull)completion;
        [Export("getMessagesCountWithCompletion:")]
        void GetMessagesCountWithCompletion(TCHCountCompletion completion);

        // -(void)getParticipantsCountWithCompletion:(TCHCountCompletion _Nonnull)completion;
        [Export("getParticipantsCountWithCompletion:")]
        void GetParticipantsCountWithCompletion(TCHCountCompletion completion);

        // -(NSArray<TCHParticipant *> * _Nonnull)participants;
        [Export("participants")]
        //[Verify (MethodToProperty)]
        TCHParticipant[] Participants { get; }

        // -(void)addParticipantByIdentity:(NSString * _Nonnull)identity attributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("addParticipantByIdentity:attributes:completion:")]
        void AddParticipantByIdentity(string identity, [NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(void)addParticipantByAddress:(NSString * _Nonnull)address proxyAddress:(NSString * _Nonnull)proxyAddress attributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("addParticipantByAddress:proxyAddress:attributes:completion:")]
        void AddParticipantByAddress(string address, string proxyAddress, [NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(void)removeParticipant:(TCHParticipant * _Nonnull)participant completion:(TCHCompletion _Nullable)completion;
        [Export("removeParticipant:completion:")]
        void RemoveParticipant(TCHParticipant participant, [NullAllowed] TCHCompletion completion);

        // -(void)removeParticipantByIdentity:(NSString * _Nonnull)identity completion:(TCHCompletion _Nullable)completion;
        [Export("removeParticipantByIdentity:completion:")]
        void RemoveParticipantByIdentity(string identity, [NullAllowed] TCHCompletion completion);

        // -(TCHParticipant * _Nullable)participantWithIdentity:(NSString * _Nonnull)identity;
        [Export("participantWithIdentity:")]
        [return: NullAllowed]
        TCHParticipant ParticipantWithIdentity(string identity);

        // -(TCHParticipant * _Nullable)participantWithSid:(NSString * _Nonnull)sid;
        [Export("participantWithSid:")]
        [return: NullAllowed]
        TCHParticipant ParticipantWithSid(string sid);
    }

    // @protocol TCHConversationDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface TCHConversationDelegate
    {
        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation updated:(TCHConversationUpdate)updated;
        [Export("conversationsClient:conversation:updated:")]
        void Conversation(TwilioConversationsClient client, TCHConversation conversation, TCHConversationUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversationDeleted:(TCHConversation * _Nonnull)conversation;
        [Export("conversationsClient:conversationDeleted:")]
        void ConversationDeleted(TwilioConversationsClient client, TCHConversation conversation);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation synchronizationStatusUpdated:(TCHConversationSynchronizationStatus)status;
        [Export("conversationsClient:conversation:synchronizationStatusUpdated:")]
        void ConversationSynchronizationStatusUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHConversationSynchronizationStatus status);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participantJoined:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:conversation:participantJoined:")]
        void ConversationParticipantJoined(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant updated:(TCHParticipantUpdate)updated;
        [Export("conversationsClient:conversation:participant:updated:")]
        void ConversationParticipantUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant, TCHParticipantUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participantLeft:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:conversation:participantLeft:")]
        void ConversationParticipantLeft(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation messageAdded:(TCHMessage * _Nonnull)message;
        [Export("conversationsClient:conversation:messageAdded:")]
        void ConversationMessageAdded(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation message:(TCHMessage * _Nonnull)message updated:(TCHMessageUpdate)updated;
        [Export("conversationsClient:conversation:message:updated:")]
        void ConversationMessageUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message, TCHMessageUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation messageDeleted:(TCHMessage * _Nonnull)message;
        [Export("conversationsClient:conversation:messageDeleted:")]
        void ConversationMessageDeleted(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client typingStartedOnConversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:typingStartedOnConversation:participant:")]
        void TypingStartedOnConversation(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client typingEndedOnConversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:typingEndedOnConversation:participant:")]
        void TypingEndedOnConversation(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant user:(TCHUser * _Nonnull)user updated:(TCHUserUpdate)updated;
        [Export("conversationsClient:conversation:participant:user:updated:")]
        void ConversationParticipantUserUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant, TCHUser user, TCHUserUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant userSubscribed:(TCHUser * _Nonnull)user;
        [Export("conversationsClient:conversation:participant:userSubscribed:")]
        void ConversationParticipantUserSubscribed(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant, TCHUser user);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant userUnsubscribed:(TCHUser * _Nonnull)user;
        [Export("conversationsClient:conversation:participant:userUnsubscribed:")]
        void ConversationParticipantUserUnSubscribed(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant, TCHUser user);
    }

    // @interface TCHParticipant : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHParticipant
    {
        // @property (readonly, nonatomic, weak) TCHConversation * _Nullable conversation;
        [NullAllowed, Export("conversation", ArgumentSemantic.Weak)]
        TCHConversation Conversation { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable sid;
        [NullAllowed, Export("sid")]
        string Sid { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable identity;
        [NullAllowed, Export("identity", ArgumentSemantic.Strong)]
        string Identity { get; }

        // @property (readonly, nonatomic) TCHParticipantType type;
        [Export("type")]
        TCHParticipantType Type { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable lastReadMessageIndex;
        [NullAllowed, Export("lastReadMessageIndex", ArgumentSemantic.Copy)]
        NSNumber LastReadMessageIndex { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable lastReadTimestamp;
        [NullAllowed, Export("lastReadTimestamp")]
        string LastReadTimestamp { get; }

        // @property (readonly, nonatomic, strong) NSDate * _Nullable lastReadTimestampAsDate;
        [NullAllowed, Export("lastReadTimestampAsDate", ArgumentSemantic.Strong)]
        NSDate LastReadTimestampAsDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable dateCreated;
        [NullAllowed, Export("dateCreated")]
        string DateCreated { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable dateCreatedAsDate;
        [NullAllowed, Export("dateCreatedAsDate", ArgumentSemantic.Copy)]
        NSDate DateCreatedAsDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable dateUpdated;
        [NullAllowed, Export("dateUpdated")]
        string DateUpdated { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable dateUpdatedAsDate;
        [NullAllowed, Export("dateUpdatedAsDate", ArgumentSemantic.Copy)]
        NSDate DateUpdatedAsDate { get; }

        // -(TCHJsonAttributes * _Nullable)attributes;
        [NullAllowed, Export("attributes")]
        //[Verify (MethodToProperty)]
        TCHJsonAttributes Attributes { get; }

        // -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("setAttributes:completion:")]
        void SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(void)subscribedUserWithCompletion:(TCHUserCompletion _Nonnull)completion;
        [Export("subscribedUserWithCompletion:")]
        void SubscribedUserWithCompletion(TCHUserCompletion completion);

        // -(void)removeWithCompletion:(TCHCompletion _Nullable)completion;
        [Export("removeWithCompletion:")]
        void RemoveWithCompletion([NullAllowed] TCHCompletion completion);
    }

    // @interface TwilioConversationsClient : NSObject
    [BaseType(typeof(NSObject))]
    interface TwilioConversationsClient
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        TwilioConversationsClientDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<TwilioConversationsClientDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) TCHUser * _Nullable user;
        [NullAllowed, Export("user", ArgumentSemantic.Strong)]
        TCHUser User { get; }

        // @property (readonly, assign, nonatomic) TCHClientConnectionState connectionState;
        [Export("connectionState", ArgumentSemantic.Assign)]
        TCHClientConnectionState ConnectionState { get; }

        // @property (readonly, assign, nonatomic) TCHClientSynchronizationStatus synchronizationStatus;
        [Export("synchronizationStatus", ArgumentSemantic.Assign)]
        TCHClientSynchronizationStatus SynchronizationStatus { get; }

        // @property (readwrite, nonatomic) dispatch_queue_t _Nonnull dispatchQueue;
        [Export("dispatchQueue", ArgumentSemantic.Assign)]
        DispatchQueue DispatchQueue { get; set; }

        // +(TCHLogLevel)logLevel;
        // +(void)setLogLevel:(TCHLogLevel)logLevel;
        [Static]
        [Export("logLevel")]
        //[Verify (MethodToProperty)]
        TCHLogLevel LogLevel { get; set; }

        // +(void)conversationsClientWithToken:(NSString * _Nonnull)token properties:(TwilioConversationsClientProperties * _Nullable)properties delegate:(id<TwilioConversationsClientDelegate> _Nullable)delegate completion:(TCHTwilioClientCompletion _Nonnull)completion;
        [Static]
        [Export("conversationsClientWithToken:properties:delegate:completion:")]
        void ConversationsClientWithToken(string token, [NullAllowed] TwilioConversationsClientProperties properties, [NullAllowed] TwilioConversationsClientDelegate @delegate, TCHTwilioClientCompletion completion);

        // +(NSString * _Nonnull)sdkName;
        [Static]
        [Export("sdkName")]
        //[Verify (MethodToProperty)]
        string SdkName { get; }

        // +(NSString * _Nonnull)sdkVersion;
        [Static]
        [Export("sdkVersion")]
        //[Verify (MethodToProperty)]
        string SdkVersion { get; }

        // -(void)updateToken:(NSString * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
        [Export("updateToken:completion:")]
        void UpdateToken(string token, [NullAllowed] TCHCompletion completion);

        // -(NSArray<TCHConversation *> * _Nullable)myConversations;
        [NullAllowed, Export("myConversations")]
        //[Verify (MethodToProperty)]
        TCHConversation[] MyConversations { get; }

        // -(void)createConversationWithOptions:(NSDictionary<NSString *,id> * _Nullable)options completion:(TCHConversationCompletion _Nullable)completion;
        [Export("createConversationWithOptions:completion:")]
        void CreateConversationWithOptions([NullAllowed] NSDictionary<NSString, NSObject> options, [NullAllowed] TCHConversationCompletion completion);

        // -(void)conversationWithSidOrUniqueName:(NSString * _Nonnull)sidOrUniqueName completion:(TCHConversationCompletion _Nonnull)completion;
        [Export("conversationWithSidOrUniqueName:completion:")]
        void ConversationWithSidOrUniqueName(string sidOrUniqueName, TCHConversationCompletion completion);

        // -(NSArray<TCHParticipant *> * _Nonnull)participantsWithIdentity:(NSString * _Nonnull)identity;
        [Export("participantsWithIdentity:")]
        TCHParticipant[] ParticipantsWithIdentity(string identity);

        // -(NSArray<TCHUser *> * _Nullable)users;
        [NullAllowed, Export("users")]
        //[Verify (MethodToProperty)]
        TCHUser[] Users { get; }

        // -(void)subscribedUserWithIdentity:(NSString * _Nonnull)identity completion:(TCHUserCompletion _Nonnull)completion;
        [Export("subscribedUserWithIdentity:completion:")]
        void SubscribedUserWithIdentity(string identity, TCHUserCompletion completion);

        // -(void)registerWithNotificationToken:(NSData * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
        [Export("registerWithNotificationToken:completion:")]
        void RegisterWithNotificationToken(NSData token, [NullAllowed] TCHCompletion completion);

        // -(void)deregisterWithNotificationToken:(NSData * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
        [Export("deregisterWithNotificationToken:completion:")]
        void DeregisterWithNotificationToken(NSData token, [NullAllowed] TCHCompletion completion);

        // -(void)handleNotification:(NSDictionary * _Nonnull)notification completion:(TCHCompletion _Nullable)completion;
        [Export("handleNotification:completion:")]
        void HandleNotification(NSDictionary notification, [NullAllowed] TCHCompletion completion);

        // -(BOOL)isReachabilityEnabled;
        [Export("isReachabilityEnabled")]
        //[Verify (MethodToProperty)]
        bool IsReachabilityEnabled { get; }

        // -(void)shutdown;
        [Export("shutdown")]
        void Shutdown();
    }

    // @interface TwilioConversationsClientProperties : NSObject
    [BaseType(typeof(NSObject))]
    interface TwilioConversationsClientProperties
    {
        // @property (copy, nonatomic) NSString * _Nonnull region;
        [Export("region")]
        string Region { get; set; }

        // @property (assign, nonatomic) NSInteger commandTimeout;
        [Export("commandTimeout")]
        nint CommandTimeout { get; set; }

        // @property (readwrite, nonatomic) BOOL deferCertificateTrustToPlatform;
        [Export("deferCertificateTrustToPlatform")]
        bool DeferCertificateTrustToPlatform { get; set; }

        // @property (readwrite, nonatomic) BOOL useProxy;
        [Export("useProxy")]
        bool UseProxy { get; set; }

        // @property (readwrite, nonatomic) dispatch_queue_t _Nullable dispatchQueue;
        [NullAllowed, Export("dispatchQueue", ArgumentSemantic.Assign)]
        DispatchQueue DispatchQueue { get; set; }
    }

    // @protocol TwilioConversationsClientDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface TwilioConversationsClientDelegate
    {
        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client connectionStateUpdated:(TCHClientConnectionState)state;
        [Export("conversationsClient:connectionStateUpdated:")]
        void ConversationsClientConnectionStateUpdated(TwilioConversationsClient client, TCHClientConnectionState state);

        // @optional -(void)conversationsClientTokenExpired:(TwilioConversationsClient * _Nonnull)client;
        [Export("conversationsClientTokenExpired:")]
        void ConversationsClientTokenExpired(TwilioConversationsClient client);

        // @optional -(void)conversationsClientTokenWillExpire:(TwilioConversationsClient * _Nonnull)client;
        [Export("conversationsClientTokenWillExpire:")]
        void ConversationsClientTokenWillExpire(TwilioConversationsClient client);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client synchronizationStatusUpdated:(TCHClientSynchronizationStatus)status;
        [Export("conversationsClient:synchronizationStatusUpdated:")]
        void ConversationsClientSynchronizationStatusUpdated(TwilioConversationsClient client, TCHClientSynchronizationStatus status);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversationAdded:(TCHConversation * _Nonnull)conversation;
        [Export("conversationsClient:conversationAdded:")]
        void ConversationsClientConversationAdded(TwilioConversationsClient client, TCHConversation conversation);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation updated:(TCHConversationUpdate)updated;
        [Export("conversationsClient:conversation:updated:")]
        void ConversationsClientConversationUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHConversationUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation synchronizationStatusUpdated:(TCHConversationSynchronizationStatus)status;
        [Export("conversationsClient:conversation:synchronizationStatusUpdated:")]
        void ConversationsClientConversationSynchronizationStatusUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHConversationSynchronizationStatus status);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversationDeleted:(TCHConversation * _Nonnull)conversation;
        [Export("conversationsClient:conversationDeleted:")]
        void ConversationsClientConversationDeleted(TwilioConversationsClient client, TCHConversation conversation);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participantJoined:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:conversation:participantJoined:")]
        void ConversationsClientConversationParticipantJoined(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant updated:(TCHParticipantUpdate)updated;
        [Export("conversationsClient:conversation:participant:updated:")]
        void ConversationsClient(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant, TCHParticipantUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participantLeft:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:conversation:participantLeft:")]
        void ConversationsClient(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation messageAdded:(TCHMessage * _Nonnull)message;
        [Export("conversationsClient:conversation:messageAdded:")]
        void ConversationsClient(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation message:(TCHMessage * _Nonnull)message updated:(TCHMessageUpdate)updated;
        [Export("conversationsClient:conversation:message:updated:")]
        void ConversationsClient(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message, TCHMessageUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation messageDeleted:(TCHMessage * _Nonnull)message;
        [Export("conversationsClient:conversation:messageDeleted:")]
        void ConversationsClientMessageDeleted(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client errorReceived:(TCHError * _Nonnull)error;
        [Export("conversationsClient:errorReceived:")]
        void ConversationsClientErrorReceived(TwilioConversationsClient client, TCHError error);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client typingStartedOnConversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:typingStartedOnConversation:participant:")]
        void ConversationsClientTypingStartedOnConversation(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client typingEndedOnConversation:(TCHConversation * _Nonnull)conversation participant:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:typingEndedOnConversation:participant:")]
        void ConversationsClientTypingEndedOnConversation(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client notificationNewMessageReceivedForConversationSid:(NSString * _Nonnull)conversationSid messageIndex:(NSUInteger)messageIndex;
        [Export("conversationsClient:notificationNewMessageReceivedForConversationSid:messageIndex:")]
        void ConversationsClientNotificationNewMessageReceivedForConversationSid(TwilioConversationsClient client, string conversationSid, nuint messageIndex);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client notificationAddedToConversationWithSid:(NSString * _Nonnull)conversationSid;
        [Export("conversationsClient:notificationAddedToConversationWithSid:")]
        void ConversationsClientNotificationAddedToConversationWithSid(TwilioConversationsClient client, string conversationSid);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client notificationRemovedFromConversationWithSid:(NSString * _Nonnull)conversationSid;
        [Export("conversationsClient:notificationRemovedFromConversationWithSid:")]
        void ConversationsClientNotificationRemovedFromConversationWithSid(TwilioConversationsClient client, string conversationSid);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client notificationUpdatedBadgeCount:(NSUInteger)badgeCount;
        [Export("conversationsClient:notificationUpdatedBadgeCount:")]
        void ConversationsClientNotificationUpdatedBadgeCount(TwilioConversationsClient client, nuint badgeCount);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client user:(TCHUser * _Nonnull)user updated:(TCHUserUpdate)updated;
        [Export("conversationsClient:user:updated:")]
        void ConversationsClientUserUpdated(TwilioConversationsClient client, TCHUser user, TCHUserUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client userSubscribed:(TCHUser * _Nonnull)user;
        [Export("conversationsClient:userSubscribed:")]
        void ConversationsClientUserSubscribed(TwilioConversationsClient client, TCHUser user);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client userUnsubscribed:(TCHUser * _Nonnull)user;
        [Export("conversationsClient:userUnsubscribed:")]
        void ConversationsClientUserUnsubscribed(TwilioConversationsClient client, TCHUser user);
    }
}
