using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace Twilio.Conversations
{
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

    // @interface TCHCancellationToken : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHCancellationToken
    {
        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

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

    // typedef void (^TCHURLCompletion)(TCHResult * _Nonnull, NSUrl * _Nullable);
    delegate void TCHURLCompletion(TCHResult arg0, [NullAllowed] NSUrl arg1);

    // typedef void (^TCHMediaSidsCompletion)(TCHResult * _Nonnull, NSDictionary<NSString *,NSUrl *> * _Nullable);
    delegate void TCHMediaSidsCompletion(TCHResult arg0, [NullAllowed] NSDictionary<NSString, NSUrl> arg1);

    // typedef void (^TCHDetailedDeliveryReceiptsCompletion)(TCHResult * _Nonnull, NSArray<TCHDetailedDeliveryReceipt *> * _Nullable);
    delegate void TCHDetailedDeliveryReceiptsCompletion(TCHResult arg0, [NullAllowed] TCHDetailedDeliveryReceipt[] arg1);

    // typedef void (^TCHMediaOnStarted)();
    delegate void TCHMediaOnStarted();

    // typedef void (^TCHMediaOnProgress)(NSUInteger);
    delegate void TCHMediaOnProgress(nuint arg0);

    // typedef void (^TCHMediaOnCompleted)(NSString * _Nonnull);
    delegate void TCHMediaOnCompleted(string arg0);

    // typedef void (^TCHMediaOnFailed)(TCHError * _Nonnull);
    delegate void TCHMediaOnFailed(TCHError arg0);

    [Static]
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
        NativeHandle Constructor(NSDictionary dictionary);

        // -(instancetype _Null_unspecified)initWithArray:(NSArray * _Nonnull)array;
        [Export("initWithArray:")]
        NativeHandle Constructor(NSObject[] array);

        // -(instancetype _Null_unspecified)initWithString:(NSString * _Nonnull)string;
        [Export("initWithString:")]
        NativeHandle Constructor(string @string);

        // -(instancetype _Null_unspecified)initWithNumber:(NSNumber * _Nonnull)number;
        [Export("initWithNumber:")]
        NativeHandle Constructor(NSNumber number);

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
        TCHJsonAttributes Attributes { get; }

        // -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("setAttributes:completion:")]
        void SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(void)setFriendlyName:(NSString * _Nullable)friendlyName completion:(TCHCompletion _Nullable)completion;
        [Export("setFriendlyName:completion:")]
        void SetFriendlyName([NullAllowed] string friendlyName, [NullAllowed] TCHCompletion completion);

        // -(BOOL)isOnline;
        [Export("isOnline")]
        bool IsOnline { get; }

        // -(BOOL)isNotifiable;
        [Export("isNotifiable")]
        bool IsNotifiable { get; }

        // -(BOOL)isSubscribed;
        [Export("isSubscribed")]
        bool IsSubscribed { get; }

        // -(void)unsubscribe;
        [Export("unsubscribe")]
        void Unsubscribe();
    }

    // @interface TCHMediaMessageListener : NSObject
    [BaseType(typeof(NSObject))]
    interface TCHMediaMessageListener
    {
        // @property (nonatomic) TCHMediaOnStarted _Nullable onStarted;
        [NullAllowed, Export("onStarted", ArgumentSemantic.Assign)]
        TCHMediaOnStarted OnStarted { get; set; }

        // @property (nonatomic) TCHMediaOnProgress _Nullable onProgress;
        [NullAllowed, Export("onProgress", ArgumentSemantic.Assign)]
        TCHMediaOnProgress OnProgress { get; set; }

        // @property (nonatomic) TCHMediaOnCompleted _Nullable onCompleted;
        [NullAllowed, Export("onCompleted", ArgumentSemantic.Assign)]
        TCHMediaOnCompleted OnCompleted { get; set; }

        // @property (nonatomic) TCHMediaOnFailed _Nullable onFailed;
        [NullAllowed, Export("onFailed", ArgumentSemantic.Assign)]
        TCHMediaOnFailed OnFailed { get; set; }

        // -(instancetype _Nonnull)initWithOnStarted:(TCHMediaOnStarted _Nullable)onStarted onProgress:(TCHMediaOnProgress _Nullable)onProgress onCompleted:(TCHMediaOnCompleted _Nullable)onCompleted onFailed:(TCHMediaOnFailed _Nullable)onFailed __attribute__((swift_name("init(onStarted:onProgress:onCompleted:onFailed:)")));
        [Export("initWithOnStarted:onProgress:onCompleted:onFailed:")]
        NativeHandle Constructor([NullAllowed] TCHMediaOnStarted onStarted, [NullAllowed] TCHMediaOnProgress onProgress, [NullAllowed] TCHMediaOnCompleted onCompleted, [NullAllowed] TCHMediaOnFailed onFailed);
    }

    // @interface TCHMessageBuilder : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHMessageBuilder
    {
        // -(instancetype _Nonnull)setBody:(NSString * _Nullable)body __attribute__((swift_name("setBody(_:)")));
        [Export("setBody:")]
        TCHMessageBuilder SetBody([NullAllowed] string body);

        // -(instancetype _Nonnull)setSubject:(NSString * _Nullable)subject __attribute__((swift_name("setSubject(_:)")));
        [Export("setSubject:")]
        TCHMessageBuilder SetSubject([NullAllowed] string subject);

        // -(instancetype _Nonnull)setAttributes:(TCHJsonAttributes * _Nullable)attributes error:(TCHError * _Nullable * _Nullable)error __attribute__((swift_name("setAttributes(_:error:)")));
        [Export("setAttributes:error:")]
        TCHMessageBuilder SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] out TCHError error);

        // -(instancetype _Nonnull)addMediaWithInputStream:(NSInputStream * _Nonnull)inputStream contentType:(NSString * _Nonnull)contentType __attribute__((swift_name("addMedia(inputStream:contentType:)")));
        [Export("addMediaWithInputStream:contentType:")]
        TCHMessageBuilder AddMediaWithInputStream(NSInputStream inputStream, string contentType);

        // -(instancetype _Nonnull)addMediaWithInputStream:(NSInputStream * _Nonnull)inputStream contentType:(NSString * _Nonnull)contentType filename:(NSString * _Nullable)filename __attribute__((swift_name("addMedia(inputStream:contentType:filename:)")));
        [Export("addMediaWithInputStream:contentType:filename:")]
        TCHMessageBuilder AddMediaWithInputStream(NSInputStream inputStream, string contentType, [NullAllowed] string filename);

        // -(instancetype _Nonnull)addMediaWithInputStream:(NSInputStream * _Nonnull)inputStream contentType:(NSString * _Nonnull)contentType filename:(NSString * _Nullable)filename listener:(TCHMediaMessageListener * _Nullable)listener __attribute__((swift_name("addMedia(inputStream:contentType:filename:listener:)")));
        [Export("addMediaWithInputStream:contentType:filename:listener:")]
        TCHMessageBuilder AddMediaWithInputStream(NSInputStream inputStream, string contentType, [NullAllowed] string filename, [NullAllowed] TCHMediaMessageListener listener);

        // -(instancetype _Nonnull)addMediaWithData:(NSData * _Nonnull)mediaData contentType:(NSString * _Nonnull)contentType __attribute__((swift_name("addMedia(data:contentType:)")));
        [Export("addMediaWithData:contentType:")]
        TCHMessageBuilder AddMediaWithData(NSData mediaData, string contentType);

        // -(instancetype _Nonnull)addMediaWithData:(NSData * _Nonnull)mediaData contentType:(NSString * _Nonnull)contentType filename:(NSString * _Nullable)filename __attribute__((swift_name("addMedia(data:contentType:filename:)")));
        [Export("addMediaWithData:contentType:filename:")]
        TCHMessageBuilder AddMediaWithData(NSData mediaData, string contentType, [NullAllowed] string filename);

        // -(instancetype _Nonnull)addMediaWithData:(NSData * _Nonnull)mediaData contentType:(NSString * _Nonnull)contentType filename:(NSString * _Nullable)filename listener:(TCHMediaMessageListener * _Nullable)listener __attribute__((swift_name("addMedia(data:contentType:filename:listener:)")));
        [Export("addMediaWithData:contentType:filename:listener:")]
        TCHMessageBuilder AddMediaWithData(NSData mediaData, string contentType, [NullAllowed] string filename, [NullAllowed] TCHMediaMessageListener listener);

        // -(instancetype _Nonnull)setEmailBody:(NSString * _Nullable)emailBody contentType:(NSString * _Nonnull)contentType __attribute__((swift_name("setEmailBody(_:contentType:)")));
        [Export("setEmailBody:contentType:")]
        TCHMessageBuilder SetEmailBody([NullAllowed] string emailBody, string contentType);

        // -(instancetype _Nonnull)setEmailBody:(NSString * _Nullable)emailBody contentType:(NSString * _Nonnull)contentType listener:(TCHMediaMessageListener * _Nullable)listener __attribute__((swift_name("setEmailBody(_:contentType:listener:)")));
        [Export("setEmailBody:contentType:listener:")]
        TCHMessageBuilder SetEmailBody([NullAllowed] string emailBody, string contentType, [NullAllowed] TCHMediaMessageListener listener);

        // -(instancetype _Nonnull)setEmailBodyWithInputStream:(NSInputStream * _Nullable)inputStream contentType:(NSString * _Nonnull)contentType __attribute__((swift_name("setEmailBody(inputStream:contentType:)")));
        [Export("setEmailBodyWithInputStream:contentType:")]
        TCHMessageBuilder SetEmailBodyWithInputStream([NullAllowed] NSInputStream inputStream, string contentType);

        // -(instancetype _Nonnull)setEmailBodyWithInputStream:(NSInputStream * _Nullable)inputStream contentType:(NSString * _Nonnull)contentType listener:(TCHMediaMessageListener * _Nullable)listener __attribute__((swift_name("setEmailBody(inputStream:contentType:listener:)")));
        [Export("setEmailBodyWithInputStream:contentType:listener:")]
        TCHMessageBuilder SetEmailBodyWithInputStream([NullAllowed] NSInputStream inputStream, string contentType, [NullAllowed] TCHMediaMessageListener listener);

        // -(instancetype _Nonnull)setEmailHistory:(NSString * _Nullable)emailHistory contentType:(NSString * _Nonnull)contentType __attribute__((swift_name("setEmailHistory(_:contentType:)")));
        [Export("setEmailHistory:contentType:")]
        TCHMessageBuilder SetEmailHistory([NullAllowed] string emailHistory, string contentType);

        // -(instancetype _Nonnull)setEmailHistory:(NSString * _Nullable)emailHistory contentType:(NSString * _Nonnull)contentType listener:(TCHMediaMessageListener * _Nullable)listener __attribute__((swift_name("setEmailHistory(_:contentType:listener:)")));
        [Export("setEmailHistory:contentType:listener:")]
        TCHMessageBuilder SetEmailHistory([NullAllowed] string emailHistory, string contentType, [NullAllowed] TCHMediaMessageListener listener);

        // -(instancetype _Nonnull)setEmailHistoryWithInputStream:(NSInputStream * _Nullable)inputStream contentType:(NSString * _Nonnull)contentType __attribute__((swift_name("setEmailHistory(inputStream:contentType:)")));
        [Export("setEmailHistoryWithInputStream:contentType:")]
        TCHMessageBuilder SetEmailHistoryWithInputStream([NullAllowed] NSInputStream inputStream, string contentType);

        // -(instancetype _Nonnull)setEmailHistoryWithInputStream:(NSInputStream * _Nullable)inputStream contentType:(NSString * _Nonnull)contentType listener:(TCHMediaMessageListener * _Nullable)listener __attribute__((swift_name("setEmailHistory(inputStream:contentType:listener:)")));
        [Export("setEmailHistoryWithInputStream:contentType:listener:")]
        TCHMessageBuilder SetEmailHistoryWithInputStream([NullAllowed] NSInputStream inputStream, string contentType, [NullAllowed] TCHMediaMessageListener listener);

        // -(TCHUnsentMessage * _Nonnull)build;
        [Export("build")]
        TCHUnsentMessage Build();

        // -(TCHCancellationToken * _Nonnull)buildAndSendWithCompletion:(TCHMessageCompletion _Nullable)completion __attribute__((swift_name("buildAndSend(completion:)")));
        [Export("buildAndSendWithCompletion:")]
        TCHCancellationToken BuildAndSendWithCompletion([NullAllowed] TCHMessageCompletion completion);
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

    // @interface TCHConversationLimits : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHConversationLimits
    {
        // @property (readonly, nonatomic) NSInteger mediaAttachmentsCountLimit;
        [Export("mediaAttachmentsCountLimit")]
        nint MediaAttachmentsCountLimit { get; }

        // @property (readonly, nonatomic) NSInteger mediaAttachmentSizeLimitInMb;
        [Export("mediaAttachmentSizeLimitInMb")]
        nint MediaAttachmentSizeLimitInMb { get; }

        // @property (readonly, nonatomic) NSInteger mediaAttachmentsTotalSizeLimitInMb;
        [Export("mediaAttachmentsTotalSizeLimitInMb")]
        nint MediaAttachmentsTotalSizeLimitInMb { get; }

        // @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull emailBodiesAllowedContentTypes;
        [Export("emailBodiesAllowedContentTypes")]
        string[] EmailBodiesAllowedContentTypes { get; }

        // @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull emailHistoriesAllowedContentTypes;
        [Export("emailHistoriesAllowedContentTypes")]
        string[] EmailHistoriesAllowedContentTypes { get; }
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

        // @property (readonly, nonatomic) TCHConversationLimits * _Nonnull limits;
        [Export("limits")]
        TCHConversationLimits Limits { get; }

        // -(TCHJsonAttributes * _Nullable)attributes;
        [NullAllowed, Export("attributes")]
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

        // -(TCHMessageBuilder * _Nonnull)prepareMessage;
        [Export("prepareMessage")]
        TCHMessageBuilder PrepareMessage();

        // -(void)sendMessageWithOptions:(TCHMessageOptions * _Nonnull)options completion:(TCHMessageCompletion _Nullable)completion __attribute__((deprecated("Replaced by TCHConversation.prepareMessage().buildAndSend(completion:)")));
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
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface TCHConversationDelegate
    {
        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation updated:(TCHConversationUpdate)updated;
        [Export("conversationsClient:conversation:updated:")]
        void ConversationUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHConversationUpdate updated);

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

    // @interface TCHMedia : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHMedia : INativeObject
    {
        // @property (readonly, nonatomic) NSString * _Nonnull sid;
        [Export("sid")]
        string Sid { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull contentType;
        [Export("contentType")]
        string ContentType { get; }

        // @property (readonly, nonatomic) TCHMediaCategory category;
        [Export("category")]
        TCHMediaCategory Category { get; }

        // @property (readonly, nonatomic) NSString * _Nullable filename;
        [NullAllowed, Export("filename")]
        string Filename { get; }

        // @property (readonly, nonatomic) NSUInteger size;
        [Export("size")]
        nuint Size { get; }

        // -(void)getTemporaryContentUrlWithCompletion:(TCHURLCompletion _Nonnull)completion __attribute__((swift_name("getTemporaryContentUrl(completion:)")));
        [Export("getTemporaryContentUrlWithCompletion:")]
        void GetTemporaryContentUrlWithCompletion(TCHURLCompletion completion);
    }

    // @interface TCHUnsentMessage : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TCHUnsentMessage
    {
        // -(TCHCancellationToken * _Nonnull)sendWithCompletion:(TCHMessageCompletion _Nullable)completion __attribute__((swift_name("send(comletion:)")));
        [Export("sendWithCompletion:")]
        TCHCancellationToken SendWithCompletion([NullAllowed] TCHMessageCompletion completion);
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

        // @property (readonly, assign, nonatomic) TCHMessageType messageType __attribute__((deprecated("")));
        [Export("messageType", ArgumentSemantic.Assign)]
        TCHMessageType MessageType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaSid __attribute__((deprecated("Use TCHMedia instead.")));
        [NullAllowed, Export("mediaSid")]
        string MediaSid { get; }

        // @property (readonly, assign, nonatomic) NSUInteger mediaSize __attribute__((deprecated("Use TCHMedia instead.")));
        [Export("mediaSize")]
        nuint MediaSize { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaType __attribute__((deprecated("Use TCHMedia instead.")));
        [NullAllowed, Export("mediaType")]
        string MediaType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaFilename __attribute__((deprecated("Use TCHMedia instead.")));
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

        // @property (readonly) NSArray<TCHMedia *> * _Nonnull attachedMedia;
        [Export("attachedMedia")]
        TCHMedia[] AttachedMedia { get; }

        // -(void)getDetailedDeliveryReceiptsWithCompletion:(TCHDetailedDeliveryReceiptsCompletion _Nonnull)completion;
        [Export("getDetailedDeliveryReceiptsWithCompletion:")]
        void GetDetailedDeliveryReceiptsWithCompletion(TCHDetailedDeliveryReceiptsCompletion completion);

        // -(void)updateBody:(NSString * _Nonnull)body completion:(TCHCompletion _Nullable)completion;
        [Export("updateBody:completion:")]
        void UpdateBody(string body, [NullAllowed] TCHCompletion completion);

        // -(TCHJsonAttributes * _Nullable)attributes;
        [NullAllowed, Export("attributes")]
        TCHJsonAttributes Attributes { get; }

        // -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
        [Export("setAttributes:completion:")]
        void SetAttributes([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

        // -(BOOL)hasMedia __attribute__((deprecated("Use attachedMedia instead")));
        [Export("hasMedia")]
        bool HasMedia { get; }

        // -(void)getMediaContentTemporaryUrlWithCompletion:(TCHStringCompletion _Nonnull)completion __attribute__((deprecated("Use [TCHMedia getTemporaryContentUrlWithCompletion:] instead.")));
        [Export("getMediaContentTemporaryUrlWithCompletion:")]
        void GetMediaContentTemporaryUrlWithCompletion(TCHStringCompletion completion);

        // -(NSArray<TCHMedia *> * _Nonnull)getMediaByCategories:(NSSet<NSNumber *> * _Nonnull)categories;
        [Export("getMediaByCategories:")]
        TCHMedia[] GetMediaByCategories(NSSet<NSNumber> categories);

        // -(TCHMedia * _Nullable)getEmailBody __attribute__((swift_name("getEmailBody()")));
        [NullAllowed, Export("getEmailBody")]
        TCHMedia EmailBody { get; }

        // -(TCHMedia * _Nullable)getEmailBodyForContentType:(NSString * _Nonnull)contentType __attribute__((swift_name("getEmailBody(contentType:)")));
        [Export("getEmailBodyForContentType:")]
        [return: NullAllowed]
        TCHMedia GetEmailBodyForContentType(string contentType);

        // -(TCHMedia * _Nullable)getEmailHistory __attribute__((swift_name("getEmailHistory()")));
        [NullAllowed, Export("getEmailHistory")]
        TCHMedia EmailHistory { get; }

        // -(TCHMedia * _Nullable)getEmailHistoryForContentType:(NSString * _Nonnull)contentType __attribute__((swift_name("getEmailHistory(contentType:)")));
        [Export("getEmailHistoryForContentType:")]
        [return: NullAllowed]
        TCHMedia GetEmailHistoryForContentType(string contentType);

        // -(TCHCancellationToken * _Nullable)getTemporaryContentUrlsForAttachedMediaWithCompletion:(TCHMediaSidsCompletion _Nonnull)completion __attribute__((swift_name("getTemporaryContentUrlsForAttachedMedia(completion:)")));
        [Export("getTemporaryContentUrlsForAttachedMediaWithCompletion:")]
        [return: NullAllowed]
        TCHCancellationToken GetTemporaryContentUrlsForAttachedMediaWithCompletion(TCHMediaSidsCompletion completion);

        // -(TCHCancellationToken * _Nullable)getTemporaryContentUrlsForMedia:(NSSet<TCHMedia *> * _Nonnull)media completion:(TCHMediaSidsCompletion _Nonnull)completion __attribute__((swift_name("getTemporaryContentUrlsFor(media:completion:)")));
        [Export("getTemporaryContentUrlsForMedia:completion:")]
        [return: NullAllowed]
        TCHCancellationToken GetTemporaryContentUrlsForMedia(NSSet<TCHMedia> media, TCHMediaSidsCompletion completion);

        // -(TCHCancellationToken * _Nullable)getTemporaryContentUrlsForMediaSids:(NSSet<NSString *> * _Nonnull)sids completion:(TCHMediaSidsCompletion _Nonnull)completion __attribute__((swift_name("getTemporaryContentUrlsFor(mediaSids:completion:)")));
        [Export("getTemporaryContentUrlsForMediaSids:completion:")]
        [return: NullAllowed]
        TCHCancellationToken GetTemporaryContentUrlsForMediaSids(NSSet<NSString> sids, TCHMediaSidsCompletion completion);
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

        // -(instancetype _Nullable)withAttributes:(TCHJsonAttributes * _Nonnull)attributes error:(TCHError * _Nullable * _Nullable)error;
        [Export("withAttributes:error:")]
        [return: NullAllowed]
        TCHMessageOptions WithAttributes(TCHJsonAttributes attributes, [NullAllowed] out TCHError error);
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
        TCHLogLevel LogLevel { get; set; }

        // +(void)conversationsClientWithToken:(NSString * _Nonnull)token properties:(TwilioConversationsClientProperties * _Nullable)properties delegate:(id<TwilioConversationsClientDelegate> _Nullable)delegate completion:(TCHTwilioClientCompletion _Nonnull)completion;
        [Static]
        [Export("conversationsClientWithToken:properties:delegate:completion:")]
        void ConversationsClientWithToken(string token, [NullAllowed] TwilioConversationsClientProperties properties, [NullAllowed] TwilioConversationsClientDelegate @delegate, TCHTwilioClientCompletion completion);

        // +(NSString * _Nonnull)sdkName;
        [Static]
        [Export("sdkName")]
        string SdkName { get; }

        // +(NSString * _Nonnull)sdkVersion;
        [Static]
        [Export("sdkVersion")]
        string SdkVersion { get; }

        // -(void)updateToken:(NSString * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
        [Export("updateToken:completion:")]
        void UpdateToken(string token, [NullAllowed] TCHCompletion completion);

        // -(NSArray<TCHConversation *> * _Nullable)myConversations;
        [NullAllowed, Export("myConversations")]
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
        bool IsReachabilityEnabled { get; }

        // -(void)shutdown;
        [Export("shutdown")]
        void Shutdown();

        // -(TCHCancellationToken * _Nullable)getTemporaryContentUrlsForMedia:(NSSet<TCHMedia *> * _Nonnull)media completion:(TCHMediaSidsCompletion _Nonnull)completion __attribute__((swift_name("getTemporaryContentUrlsFor(media:completion:)")));
        [Export("getTemporaryContentUrlsForMedia:completion:")]
        [return: NullAllowed]
        TCHCancellationToken GetTemporaryContentUrlsForMedia(NSSet<TCHMedia> media, TCHMediaSidsCompletion completion);

        // -(TCHCancellationToken * _Nullable)getTemporaryContentUrlsForMediaSids:(NSSet<NSString *> * _Nonnull)sids completion:(TCHMediaSidsCompletion _Nonnull)completion __attribute__((swift_name("getTemporaryContentUrlsFor(mediaSids:completion:)")));
        [Export("getTemporaryContentUrlsForMediaSids:completion:")]
        [return: NullAllowed]
        TCHCancellationToken GetTemporaryContentUrlsForMediaSids(NSSet<NSString> sids, TCHMediaSidsCompletion completion);
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
    [Protocol, Model]
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
        void ConversationsClientParticipantUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant, TCHParticipantUpdate updated);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation participantLeft:(TCHParticipant * _Nonnull)participant;
        [Export("conversationsClient:conversation:participantLeft:")]
        void ConversationsClientParticipantLeft(TwilioConversationsClient client, TCHConversation conversation, TCHParticipant participant);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation messageAdded:(TCHMessage * _Nonnull)message;
        [Export("conversationsClient:conversation:messageAdded:")]
        void ConversationsClientMessageAdded(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message);

        // @optional -(void)conversationsClient:(TwilioConversationsClient * _Nonnull)client conversation:(TCHConversation * _Nonnull)conversation message:(TCHMessage * _Nonnull)message updated:(TCHMessageUpdate)updated;
        [Export("conversationsClient:conversation:message:updated:")]
        void ConversationsClientMessageUpdated(TwilioConversationsClient client, TCHConversation conversation, TCHMessage message, TCHMessageUpdate updated);

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