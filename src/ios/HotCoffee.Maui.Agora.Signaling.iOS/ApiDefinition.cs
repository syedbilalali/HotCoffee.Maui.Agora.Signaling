global using System;
global using Foundation;
global using ObjCRuntime;
namespace HotCoffee.Maui.Agora.Signaling.iOS
{
    // @interface AgoraRtmPublishOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPublishOptions
	{
		// @property (assign, nonatomic) AgoraRtmChannelType channelType;
		[Export ("channelType", ArgumentSemantic.Assign)]
		AgoraRtmChannelType ChannelType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull customType;
		[Export ("customType")]
		string CustomType { get; set; }

		// @property (assign, nonatomic) BOOL storeInHistory;
		[Export ("storeInHistory")]
		bool StoreInHistory { get; set; }
	}

	// @interface AgoraRtmTopicMessageOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmTopicMessageOptions
	{
		// @property (copy, nonatomic) NSString * _Nonnull customType;
		[Export ("customType")]
		string CustomType { get; set; }

		// @property (assign, nonatomic) unsigned long long sendTs;
		[Export ("sendTs")]
		ulong SendTs { get; set; }
	}

	// @interface AgoraRtmMetadataOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmMetadataOptions
	{
		// @property (assign, nonatomic) BOOL recordTs;
		[Export ("recordTs")]
		bool RecordTs { get; set; }

		// @property (assign, nonatomic) BOOL recordUserId;
		[Export ("recordUserId")]
		bool RecordUserId { get; set; }
	}

	// @interface AgoraRtmMetadataItem : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmMetadataItem
	{
		// @property (copy, nonatomic) NSString * _Nonnull key;
		[Export ("key")]
		string Key { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull authorUserId;
		[Export ("authorUserId")]
		string AuthorUserId { get; set; }

		// @property (assign, nonatomic) long long revision;
		[Export ("revision")]
		long Revision { get; set; }

		// @property (assign, nonatomic) unsigned long long updateTs;
		[Export ("updateTs")]
		ulong UpdateTs { get; set; }
	}

	// @interface AgoraRtmMetadata : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmMetadata
	{
		// @property (assign, nonatomic) long long majorRevision;
		[Export ("majorRevision")]
		long MajorRevision { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmMetadataItem *> * _Nullable items;
		[NullAllowed, Export ("items", ArgumentSemantic.Copy)]
		AgoraRtmMetadataItem[] Items { get; set; }
	}

	// @interface AgoraRtmLockDetail : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmLockDetail
	{
		// @property (copy, nonatomic) NSString * _Nonnull lockName;
		[Export ("lockName")]
		string LockName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull owner;
		[Export ("owner")]
		string Owner { get; set; }

		// @property (assign, nonatomic) int ttl;
		[Export ("ttl")]
		int Ttl { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmGetOnlineUsersOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetOnlineUsersOptions
	{
		// @property (assign, nonatomic) BOOL includeUserId;
		[Export ("includeUserId")]
		bool IncludeUserId { get; set; }

		// @property (assign, nonatomic) BOOL includeState;
		[Export ("includeState")]
		bool IncludeState { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull page;
		[Export ("page")]
		string Page { get; set; }
	}

	// @interface AgoraRtmPresenceOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPresenceOptions
	{
		// @property (assign, nonatomic) BOOL includeUserId;
		[Export ("includeUserId")]
		bool IncludeUserId { get; set; }

		// @property (assign, nonatomic) BOOL includeState;
		[Export ("includeState")]
		bool IncludeState { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull page;
		[Export ("page")]
		string Page { get; set; }
	}

	// @interface AgoraRtmUserState : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmUserState
	{
		// @property (copy, nonatomic) NSString * _Nonnull userId;
		[Export ("userId")]
		string UserId { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull states;
		[Export ("states", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> States { get; set; }
	}

	// @interface AgoraRtmChannelInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmChannelInfo
	{
		// @property (copy, nonatomic) NSString * _Nonnull channelName;
		[Export ("channelName")]
		string ChannelName { get; set; }

		// @property (assign, nonatomic) AgoraRtmChannelType channelType;
		[Export ("channelType", ArgumentSemantic.Assign)]
		AgoraRtmChannelType ChannelType { get; set; }
	}

	// @interface AgoraRtmTopicEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmTopicEvent
	{
		// @property (assign, nonatomic) AgoraRtmTopicEventType type;
		[Export ("type", ArgumentSemantic.Assign)]
		AgoraRtmTopicEventType Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull channelName;
		[Export ("channelName")]
		string ChannelName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull publisher;
		[Export ("publisher")]
		string Publisher { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmTopicInfo *> * _Nonnull topicInfos;
		[Export ("topicInfos", ArgumentSemantic.Copy)]
		AgoraRtmTopicInfo[] TopicInfos { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmPublisherInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPublisherInfo
	{
		// @property (copy, nonatomic) NSString * _Nonnull publisherUserId;
		[Export ("publisherUserId")]
		string PublisherUserId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable publisherMeta;
		[NullAllowed, Export ("publisherMeta")]
		string PublisherMeta { get; set; }
	}

	// @interface AgoraRtmLockEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmLockEvent
	{
		// @property (assign, nonatomic) AgoraRtmChannelType channelType;
		[Export ("channelType", ArgumentSemantic.Assign)]
		AgoraRtmChannelType ChannelType { get; set; }

		// @property (assign, nonatomic) AgoraRtmLockEventType eventType;
		[Export ("eventType", ArgumentSemantic.Assign)]
		AgoraRtmLockEventType EventType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull channelName;
		[Export ("channelName")]
		string ChannelName { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmLockDetail *> * _Nonnull lockDetailList;
		[Export ("lockDetailList", ArgumentSemantic.Copy)]
		AgoraRtmLockDetail[] LockDetailList { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmStorageEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmStorageEvent
	{
		// @property (assign, nonatomic) AgoraRtmChannelType channelType;
		[Export ("channelType", ArgumentSemantic.Assign)]
		AgoraRtmChannelType ChannelType { get; set; }

		// @property (assign, nonatomic) AgoraRtmStorageType storageType;
		[Export ("storageType", ArgumentSemantic.Assign)]
		AgoraRtmStorageType StorageType { get; set; }

		// @property (assign, nonatomic) AgoraRtmStorageEventType eventType;
		[Export ("eventType", ArgumentSemantic.Assign)]
		AgoraRtmStorageEventType EventType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull target;
		[Export ("target")]
		string Target { get; set; }

		// @property (nonatomic, strong) AgoraRtmMetadata * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		AgoraRtmMetadata Data { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmLogConfig : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AgoraRtmLogConfig : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable filePath;
		[NullAllowed, Export ("filePath")]
		string FilePath { get; set; }

		// @property (assign, nonatomic) int fileSizeInKB;
		[Export ("fileSizeInKB")]
		int FileSizeInKB { get; set; }

		// @property (assign, nonatomic) AgoraRtmLogLevel level;
		[Export ("level", ArgumentSemantic.Assign)]
		AgoraRtmLogLevel Level { get; set; }
	}

	// @interface AgoraRtmProxyConfig : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmProxyConfig : INSCopying
	{
		// -(instancetype _Nonnull)initWithServer:(NSString * _Nonnull)server port:(unsigned short)port proxyType:(AgoraRtmProxyType)proxyType;
		[Export ("initWithServer:port:proxyType:")]
		NativeHandle Constructor (string server, ushort port, AgoraRtmProxyType proxyType);

		// @property (assign, nonatomic) AgoraRtmProxyType proxyType;
		[Export ("proxyType", ArgumentSemantic.Assign)]
		AgoraRtmProxyType ProxyType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull server;
		[Export ("server")]
		string Server { get; set; }

		// @property (assign, nonatomic) unsigned short port;
		[Export ("port")]
		ushort Port { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable account;
		[NullAllowed, Export ("account")]
		string Account { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable password;
		[NullAllowed, Export ("password")]
		string Password { get; set; }
	}

	// @interface AgoraRtmEncryptionConfig : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AgoraRtmEncryptionConfig : INSCopying
	{
		// @property (assign, nonatomic) AgoraRtmEncryptionMode encryptionMode;
		[Export ("encryptionMode", ArgumentSemantic.Assign)]
		AgoraRtmEncryptionMode EncryptionMode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable encryptionKey;
		[NullAllowed, Export ("encryptionKey")]
		string EncryptionKey { get; set; }

		// @property (nonatomic, strong) NSData * _Nullable encryptionSalt;
		[NullAllowed, Export ("encryptionSalt", ArgumentSemantic.Strong)]
		NSData EncryptionSalt { get; set; }
	}

	// @interface AgoraRtmJoinTopicOption : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmJoinTopicOption
	{
		// @property (assign, nonatomic) AgoraRtmMessageQos qos;
		[Export ("qos", ArgumentSemantic.Assign)]
		AgoraRtmMessageQos Qos { get; set; }

		// @property (nonatomic) NSString * _Nullable meta;
		[NullAllowed, Export ("meta")]
		string Meta { get; set; }

		// @property (assign, nonatomic) AgoraRtmMessagePriority priority;
		[Export ("priority", ArgumentSemantic.Assign)]
		AgoraRtmMessagePriority Priority { get; set; }

		// @property (assign, nonatomic) BOOL syncWithMedia;
		[Export ("syncWithMedia")]
		bool SyncWithMedia { get; set; }
	}

	// @interface AgoraRtmTopicOption : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmTopicOption
	{
		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable users;
		[NullAllowed, Export ("users", ArgumentSemantic.Copy)]
		string[] Users { get; set; }
	}

	// @interface AgoraRtmJoinChannelOption : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmJoinChannelOption
	{
		// @property (copy, nonatomic) NSString * _Nullable token;
		[NullAllowed, Export ("token")]
		string Token { get; set; }

		// @property (assign, nonatomic) AgoraRtmJoinChannelFeature features;
		[Export ("features", ArgumentSemantic.Assign)]
		AgoraRtmJoinChannelFeature Features { get; set; }
	}

	// @interface AgoraRtmMessageEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmMessageEvent
	{
		// @property (assign, nonatomic) AgoraRtmChannelType channelType;
		[Export ("channelType", ArgumentSemantic.Assign)]
		AgoraRtmChannelType ChannelType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull channelName;
		[Export ("channelName")]
		string ChannelName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull channelTopic;
		[Export ("channelTopic")]
		string ChannelTopic { get; set; }

		// @property (copy, nonatomic) AgoraRtmMessage * _Nonnull message;
		[Export ("message", ArgumentSemantic.Copy)]
		AgoraRtmMessage Message { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull publisher;
		[Export ("publisher")]
		string Publisher { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customType;
		[NullAllowed, Export ("customType")]
		string CustomType { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmTopicInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmTopicInfo
	{
		// @property (copy, nonatomic) NSString * _Nonnull topic;
		[Export ("topic")]
		string Topic { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmPublisherInfo *> * _Nonnull publishers;
		[Export ("publishers", ArgumentSemantic.Copy)]
		AgoraRtmPublisherInfo[] Publishers { get; set; }
	}

	// @interface AgoraRtmSubscribeOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmSubscribeOptions
	{
		// @property (assign, nonatomic) AgoraRtmSubscribeChannelFeature features;
		[Export ("features", ArgumentSemantic.Assign)]
		AgoraRtmSubscribeChannelFeature Features { get; set; }
	}

	// @interface AgoraRtmPresenceIntervalInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPresenceIntervalInfo
	{
		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull joinUserList;
		[Export ("joinUserList", ArgumentSemantic.Copy)]
		string[] JoinUserList { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull leaveUserList;
		[Export ("leaveUserList", ArgumentSemantic.Copy)]
		string[] LeaveUserList { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull timeoutUserList;
		[Export ("timeoutUserList", ArgumentSemantic.Copy)]
		string[] TimeoutUserList { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmUserState *> * _Nonnull userStateList;
		[Export ("userStateList", ArgumentSemantic.Copy)]
		AgoraRtmUserState[] UserStateList { get; set; }
	}

	// @interface AgoraRtmPresenceEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPresenceEvent
	{
		// @property (assign, nonatomic) AgoraRtmPresenceEventType type;
		[Export ("type", ArgumentSemantic.Assign)]
		AgoraRtmPresenceEventType Type { get; set; }

		// @property (assign, nonatomic) AgoraRtmChannelType channelType;
		[Export ("channelType", ArgumentSemantic.Assign)]
		AgoraRtmChannelType ChannelType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull channelName;
		[Export ("channelName")]
		string ChannelName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable publisher;
		[NullAllowed, Export ("publisher")]
		string Publisher { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull states;
		[Export ("states", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> States { get; set; }

		// @property (copy, nonatomic) AgoraRtmPresenceIntervalInfo * _Nullable interval;
		[NullAllowed, Export ("interval", ArgumentSemantic.Copy)]
		AgoraRtmPresenceIntervalInfo Interval { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmUserState *> * _Nonnull snapshot;
		[Export ("snapshot", ArgumentSemantic.Copy)]
		AgoraRtmUserState[] Snapshot { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmTokenEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmTokenEvent
	{
		// @property (assign, nonatomic) AgoraRtmTokenEventTokenType eventType;
		[Export ("eventType", ArgumentSemantic.Assign)]
		AgoraRtmTokenEventTokenType EventType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull reason;
		[Export ("reason")]
		string Reason { get; set; }

		// @property (copy, nonatomic) AgoraRtmAffectedResources * _Nonnull affectedResources;
		[Export ("affectedResources", ArgumentSemantic.Copy)]
		AgoraRtmAffectedResources AffectedResources { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmAffectedResources : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmAffectedResources
	{
		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull messageChannels;
		[Export ("messageChannels", ArgumentSemantic.Copy)]
		string[] MessageChannels { get; set; }
	}

	// @interface AgoraRtmClientConfig : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmClientConfig
	{
		// -(instancetype _Nonnull)initWithAppId:(NSString * _Nonnull)appId userId:(NSString * _Nonnull)userId;
		[Export ("initWithAppId:userId:")]
		NativeHandle Constructor (string appId, string userId);

		// @property (assign, nonatomic) AgoraRtmAreaCode areaCode;
		[Export ("areaCode", ArgumentSemantic.Assign)]
		AgoraRtmAreaCode AreaCode { get; set; }

		// @property (assign, nonatomic) AgoraRtmProtocolType protocolType;
		[Export ("protocolType", ArgumentSemantic.Assign)]
		AgoraRtmProtocolType ProtocolType { get; set; }

		// @property (assign, nonatomic) unsigned int presenceTimeout;
		[Export ("presenceTimeout")]
		uint PresenceTimeout { get; set; }

		// @property (assign, nonatomic) unsigned int heartbeatInterval;
		[Export ("heartbeatInterval")]
		uint HeartbeatInterval { get; set; }

		// @property (assign, nonatomic) unsigned int reconnectTimeout;
		[Export ("reconnectTimeout")]
		uint ReconnectTimeout { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull appId;
		[Export ("appId")]
		string AppId { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull userId;
		[Export ("userId")]
		string UserId { get; set; }

		// @property (assign, nonatomic) BOOL useStringUserId;
		[Export ("useStringUserId")]
		bool UseStringUserId { get; set; }

		// @property (assign, nonatomic) BOOL multipath;
		[Export ("multipath")]
		bool Multipath { get; set; }

		// @property (assign, nonatomic) BOOL ispPolicyEnabled;
		[Export ("ispPolicyEnabled")]
		bool IspPolicyEnabled { get; set; }

		// @property (copy, nonatomic) AgoraRtmLogConfig * _Nullable logConfig;
		[NullAllowed, Export ("logConfig", ArgumentSemantic.Copy)]
		AgoraRtmLogConfig LogConfig { get; set; }

		// @property (copy, nonatomic) AgoraRtmProxyConfig * _Nullable proxyConfig;
		[NullAllowed, Export ("proxyConfig", ArgumentSemantic.Copy)]
		AgoraRtmProxyConfig ProxyConfig { get; set; }

		// @property (copy, nonatomic) AgoraRtmEncryptionConfig * _Nullable encryptionConfig;
		[NullAllowed, Export ("encryptionConfig", ArgumentSemantic.Copy)]
		AgoraRtmEncryptionConfig EncryptionConfig { get; set; }

		// @property (copy, nonatomic) AgoraRtmPrivateConfig * _Nullable privateConfig;
		[NullAllowed, Export ("privateConfig", ArgumentSemantic.Copy)]
		AgoraRtmPrivateConfig PrivateConfig { get; set; }
	}

	// @interface AgoraRtmErrorInfo : NSError
	[BaseType (typeof(NSError))]
	interface AgoraRtmErrorInfo
	{
		// @property (assign, nonatomic) AgoraRtmErrorCode errorCode;
		[Export ("errorCode", ArgumentSemantic.Assign)]
		AgoraRtmErrorCode ErrorCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull operation;
		[Export ("operation")]
		string Operation { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull reason;
		[Export ("reason")]
		string Reason { get; set; }
	}

	// @interface AgoraRtmTopicSubscriptionResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmTopicSubscriptionResponse
	{
		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull succeedUsers;
		[Export ("succeedUsers", ArgumentSemantic.Copy)]
		string[] SucceedUsers { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull failedUsers;
		[Export ("failedUsers", ArgumentSemantic.Copy)]
		string[] FailedUsers { get; set; }
	}

	// @interface AgoraRtmGetMetadataResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetMetadataResponse
	{
		// @property (nonatomic, strong) AgoraRtmMetadata * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Strong)]
		AgoraRtmMetadata Data { get; set; }
	}

	// @interface AgoraRtmGetLocksResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetLocksResponse
	{
		// @property (copy, nonatomic) NSArray<AgoraRtmLockDetail *> * _Nonnull lockDetailList;
		[Export ("lockDetailList", ArgumentSemantic.Copy)]
		AgoraRtmLockDetail[] LockDetailList { get; set; }
	}

	// @interface AgoraRtmGetOnlineUsersResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetOnlineUsersResponse
	{
		// @property (assign, nonatomic) int totalOccupancy;
		[Export ("totalOccupancy")]
		int TotalOccupancy { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmUserState *> * _Nonnull userStateList;
		[Export ("userStateList", ArgumentSemantic.Copy)]
		AgoraRtmUserState[] UserStateList { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable nextPage;
		[NullAllowed, Export ("nextPage")]
		string NextPage { get; set; }
	}

	// @interface AgoraRtmWhoNowResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmWhoNowResponse
	{
		// @property (assign, nonatomic) int totalOccupancy;
		[Export ("totalOccupancy")]
		int TotalOccupancy { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmUserState *> * _Nonnull userStateList;
		[Export ("userStateList", ArgumentSemantic.Copy)]
		AgoraRtmUserState[] UserStateList { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable nextPage;
		[NullAllowed, Export ("nextPage")]
		string NextPage { get; set; }
	}

	// @interface AgoraRtmWhereNowResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmWhereNowResponse
	{
		// @property (assign, nonatomic) int totalChannel;
		[Export ("totalChannel")]
		int TotalChannel { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmChannelInfo *> * _Nonnull channels;
		[Export ("channels", ArgumentSemantic.Copy)]
		AgoraRtmChannelInfo[] Channels { get; set; }
	}

	// @interface AgoraRtmGetUserChannelsResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetUserChannelsResponse
	{
		// @property (assign, nonatomic) int totalChannel;
		[Export ("totalChannel")]
		int TotalChannel { get; set; }

		// @property (copy, nonatomic) NSArray<AgoraRtmChannelInfo *> * _Nonnull channels;
		[Export ("channels", ArgumentSemantic.Copy)]
		AgoraRtmChannelInfo[] Channels { get; set; }
	}

	// @interface AgoraRtmPresenceGetStateResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPresenceGetStateResponse
	{
		// @property (nonatomic, strong) AgoraRtmUserState * _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		AgoraRtmUserState State { get; set; }
	}

	// @interface AgoraRtmCommonResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmCommonResponse
	{
	}

	// @interface AgoraRtmMessage : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AgoraRtmMessage : INSCopying
	{
		// @property (copy, nonatomic) NSData * _Nullable rawData;
		[NullAllowed, Export ("rawData", ArgumentSemantic.Copy)]
		NSData RawData { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable stringData;
		[NullAllowed, Export ("stringData")]
		string StringData { get; set; }
	}

	// @interface AgoraRtmGetTopicSubscribedUsersResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetTopicSubscribedUsersResponse
	{
		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull users;
		[Export ("users", ArgumentSemantic.Copy)]
		string[] Users { get; set; }
	}

	// @interface AgoraRtmPrivateConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmPrivateConfig
	{
		// @property (assign, nonatomic) AgoraRtmServiceType serviceType;
		[Export ("serviceType", ArgumentSemantic.Assign)]
		AgoraRtmServiceType ServiceType { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull accessPointHosts;
		[Export ("accessPointHosts", ArgumentSemantic.Copy)]
		string[] AccessPointHosts { get; set; }
	}

	// @interface AgoraRtmLinkStateEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmLinkStateEvent
	{
		// @property (assign, nonatomic) AgoraRtmLinkState currentState;
		[Export ("currentState", ArgumentSemantic.Assign)]
		AgoraRtmLinkState CurrentState { get; set; }

		// @property (assign, nonatomic) AgoraRtmLinkState previousState;
		[Export ("previousState", ArgumentSemantic.Assign)]
		AgoraRtmLinkState PreviousState { get; set; }

		// @property (assign, nonatomic) AgoraRtmServiceType serviceType;
		[Export ("serviceType", ArgumentSemantic.Assign)]
		AgoraRtmServiceType ServiceType { get; set; }

		// @property (assign, nonatomic) AgoraRtmLinkOperation operation;
		[Export ("operation", ArgumentSemantic.Assign)]
		AgoraRtmLinkOperation Operation { get; set; }

		// @property (assign, nonatomic) AgoraRtmLinkStateChangeReason reasonCode;
		[Export ("reasonCode", ArgumentSemantic.Assign)]
		AgoraRtmLinkStateChangeReason ReasonCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable reason;
		[NullAllowed, Export ("reason")]
		string Reason { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull affectedChannels;
		[Export ("affectedChannels", ArgumentSemantic.Copy)]
		string[] AffectedChannels { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull unrestoredChannels;
		[Export ("unrestoredChannels", ArgumentSemantic.Copy)]
		string[] UnrestoredChannels { get; set; }

		// @property (assign, nonatomic) BOOL isResumed;
		[Export ("isResumed")]
		bool IsResumed { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmGetHistoryMessagesOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetHistoryMessagesOptions
	{
		// @property (assign, nonatomic) int messageCount;
		[Export ("messageCount")]
		int MessageCount { get; set; }

		// @property (assign, nonatomic) unsigned long long start;
		[Export ("start")]
		ulong Start { get; set; }

		// @property (assign, nonatomic) unsigned long long end;
		[Export ("end")]
		ulong End { get; set; }
	}

	// @interface AgoraRtmHistoryMessage : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface AgoraRtmHistoryMessage : INSCopying
	{
		// @property (copy, nonatomic) AgoraRtmMessage * _Nonnull message;
		[Export ("message", ArgumentSemantic.Copy)]
		AgoraRtmMessage Message { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull publisher;
		[Export ("publisher")]
		string Publisher { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customType;
		[NullAllowed, Export ("customType")]
		string CustomType { get; set; }

		// @property (assign, nonatomic) unsigned long long timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; set; }
	}

	// @interface AgoraRtmGetHistoryMessagesResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface AgoraRtmGetHistoryMessagesResponse
	{
		// @property (copy, nonatomic) NSArray<AgoraRtmHistoryMessage *> * _Nonnull messageList;
		[Export ("messageList", ArgumentSemantic.Copy)]
		AgoraRtmHistoryMessage[] MessageList { get; set; }

		// @property (assign, nonatomic) unsigned long long newStart;
		[Export ("newStart")]
		ulong NewStart { get; set; }
	}

	// typedef void (^AgoraRtmTopicSubscriptionBlock)(AgoraRtmTopicSubscriptionResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmTopicSubscriptionBlock ([NullAllowed] AgoraRtmTopicSubscriptionResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmOperationBlock)(AgoraRtmCommonResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmOperationBlock ([NullAllowed] AgoraRtmCommonResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmGetMetadataBlock)(AgoraRtmGetMetadataResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmGetMetadataBlock ([NullAllowed] AgoraRtmGetMetadataResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmGetLocksBlock)(AgoraRtmGetLocksResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmGetLocksBlock ([NullAllowed] AgoraRtmGetLocksResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmWhoNowBlock)(AgoraRtmWhoNowResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmWhoNowBlock ([NullAllowed] AgoraRtmWhoNowResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmWhereNowBlock)(AgoraRtmWhereNowResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmWhereNowBlock ([NullAllowed] AgoraRtmWhereNowResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmGetOnlineUsersBlock)(AgoraRtmGetOnlineUsersResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmGetOnlineUsersBlock ([NullAllowed] AgoraRtmGetOnlineUsersResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmGetUserChannelsBlock)(AgoraRtmGetUserChannelsResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmGetUserChannelsBlock ([NullAllowed] AgoraRtmGetUserChannelsResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmPresenceGetStateBlock)(AgoraRtmPresenceGetStateResponse * _Nullable, AgoraRtmErrorInfo * _Nullable);
	delegate void AgoraRtmPresenceGetStateBlock ([NullAllowed] AgoraRtmPresenceGetStateResponse arg0, [NullAllowed] AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmGetTopicSubscribedUsersBlock)(AgoraRtmGetTopicSubscribedUsersResponse * _Nullable, AgoraRtmErrorInfo * _Nonnull);
	delegate void AgoraRtmGetTopicSubscribedUsersBlock ([NullAllowed] AgoraRtmGetTopicSubscribedUsersResponse arg0, AgoraRtmErrorInfo arg1);

	// typedef void (^AgoraRtmGetHistoryMessagesBlock)(AgoraRtmGetHistoryMessagesResponse * _Nullable, AgoraRtmErrorInfo * _Nonnull);
	delegate void AgoraRtmGetHistoryMessagesBlock ([NullAllowed] AgoraRtmGetHistoryMessagesResponse arg0, AgoraRtmErrorInfo arg1);

	// @protocol AgoraRtmClientDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AgoraRtmClientDelegate
	{
		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceiveLinkStateEvent:(AgoraRtmLinkStateEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceiveLinkStateEvent:)")));
		[Export ("rtmKit:didReceiveLinkStateEvent:")]
		void DidReceiveLinkStateEvent (AgoraRtmClientKit rtmKit, AgoraRtmLinkStateEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceiveMessageEvent:(AgoraRtmMessageEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceiveMessageEvent:)")));
		[Export ("rtmKit:didReceiveMessageEvent:")]
		void DidReceiveMessageEvent (AgoraRtmClientKit rtmKit, AgoraRtmMessageEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceivePresenceEvent:(AgoraRtmPresenceEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceivePresenceEvent:)")));
		[Export ("rtmKit:didReceivePresenceEvent:")]
		void DidReceivePresenceEvent (AgoraRtmClientKit rtmKit, AgoraRtmPresenceEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceiveLockEvent:(AgoraRtmLockEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceiveLockEvent:)")));
		[Export ("rtmKit:didReceiveLockEvent:")]
		void DidReceiveLockEvent (AgoraRtmClientKit rtmKit, AgoraRtmLockEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceiveStorageEvent:(AgoraRtmStorageEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceiveStorageEvent:)")));
		[Export ("rtmKit:didReceiveStorageEvent:")]
		void DidReceiveStorageEvent (AgoraRtmClientKit rtmKit, AgoraRtmStorageEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceiveTopicEvent:(AgoraRtmTopicEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceiveTopicEvent:)")));
		[Export ("rtmKit:didReceiveTopicEvent:")]
		void DidReceiveTopicEvent (AgoraRtmClientKit rtmKit, AgoraRtmTopicEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit didReceiveTokenEvent:(AgoraRtmTokenEvent * _Nonnull)event __attribute__((swift_name("rtmKit(_:didReceiveTokenEvent:)")));
		[Export ("rtmKit:didReceiveTokenEvent:")]
		void DidReceiveTokenEvent (AgoraRtmClientKit rtmKit, AgoraRtmTokenEvent @event);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)rtmKit tokenPrivilegeWillExpire:(NSString * _Nullable)channel __attribute__((swift_name("rtmKit(_:tokenPrivilegeWillExpire:)")));
		[Export ("rtmKit:tokenPrivilegeWillExpire:")]
		void TokenPrivilegeWillExpire (AgoraRtmClientKit rtmKit, [NullAllowed] string channel);

		// @optional -(void)rtmKit:(AgoraRtmClientKit * _Nonnull)kit channel:(NSString * _Nonnull)channelName connectionChangedToState:(AgoraRtmClientConnectionState)state reason:(AgoraRtmClientConnectionChangeReason)reason __attribute__((swift_name("rtmKit(_:channel:connectionChangedToState:reason:)")));
		[Export ("rtmKit:channel:connectionChangedToState:reason:")]
		void Channel (AgoraRtmClientKit kit, string channelName, AgoraRtmClientConnectionState state, AgoraRtmClientConnectionChangeReason reason);
	}

	// @interface AgoraRtmClientKit : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmClientKit
	{
		// -(instancetype _Nullable)initWithConfig:(AgoraRtmClientConfig * _Nonnull)config delegate:(id<AgoraRtmClientDelegate> _Nullable)delegate error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init(_:delegate:)")));
		[Export ("initWithConfig:delegate:error:")]
		NativeHandle Constructor (AgoraRtmClientConfig config, [NullAllowed] AgoraRtmClientDelegate @delegate, [NullAllowed] out NSError error);

		// -(void)loginByToken:(NSString * _Nullable)token completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("login(_:completion:)")));
		[Export ("loginByToken:completion:")]
		void LoginByToken ([NullAllowed] string token, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)logout:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("logout(_:)")));
		[Export ("logout:")]
		void Logout ([NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(AgoraRtmStorage * _Nullable)getStorage __attribute__((swift_name("getStorage()")));
		[NullAllowed, Export ("getStorage")]
		//[Verify (MethodToProperty)]
		AgoraRtmStorage Storage { get; }

		// -(AgoraRtmLock * _Nullable)getLock __attribute__((swift_name("getLock()")));
		[NullAllowed, Export ("getLock")]
		//[Verify (MethodToProperty)]
		AgoraRtmLock Lock { get; }

		// -(AgoraRtmPresence * _Nullable)getPresence __attribute__((swift_name("getPresence()")));
		[NullAllowed, Export ("getPresence")]
		//[Verify (MethodToProperty)]
		AgoraRtmPresence Presence { get; }

		// -(AgoraRtmHistory * _Nullable)getHistory __attribute__((swift_name("getHistory()")));
		[NullAllowed, Export ("getHistory")]
		//[Verify (MethodToProperty)]
		AgoraRtmHistory History { get; }

		// -(void)renewToken:(NSString * _Nonnull)token completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("renewToken(_:completion:)")));
		[Export ("renewToken:completion:")]
		void RenewToken (string token, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)subscribeWithChannel:(NSString * _Nonnull)channelName option:(AgoraRtmSubscribeOptions * _Nullable)subscribeOption completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("subscribe(channelName:option:completion:)")));
		[Export ("subscribeWithChannel:option:completion:")]
		void SubscribeWithChannel (string channelName, [NullAllowed] AgoraRtmSubscribeOptions subscribeOption, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)unsubscribeWithChannel:(NSString * _Nonnull)channelName completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("unsubscribe(_:completion:)")));
		[Export ("unsubscribeWithChannel:completion:")]
		void UnsubscribeWithChannel (string channelName, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)publish:(NSString * _Nonnull)channelName message:(NSString * _Nonnull)message option:(AgoraRtmPublishOptions * _Nullable)publishOption completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("publish(channelName:message:option:completion:)")));
		[Export ("publish:message:option:completion:")]
		void Publish (string channelName, string message, [NullAllowed] AgoraRtmPublishOptions publishOption, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)publish:(NSString * _Nonnull)channelName data:(NSData * _Nonnull)data option:(AgoraRtmPublishOptions * _Nullable)publishOption completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("publish(channelName:data:option:completion:)")));
		[Export ("publish:data:option:completion:")]
		void Publish (string channelName, NSData data, [NullAllowed] AgoraRtmPublishOptions publishOption, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)addDelegate:(id<AgoraRtmClientDelegate> _Nonnull)delegate __attribute__((swift_name("addDelegate(_:)")));
		[Export ("addDelegate:")]
		void AddDelegate (AgoraRtmClientDelegate @delegate);

		// -(void)removeDelegate:(id<AgoraRtmClientDelegate> _Nonnull)delegate __attribute__((swift_name("removeDelegate(_:)")));
		[Export ("removeDelegate:")]
		void RemoveDelegate (AgoraRtmClientDelegate @delegate);

		// -(AgoraRtmErrorCode)setParameters:(NSString * _Nonnull)parameter __attribute__((swift_name("setParameters(_:)")));
		[Export ("setParameters:")]
		AgoraRtmErrorCode SetParameters (string parameter);

		// +(NSString * _Nullable)getErrorReason:(AgoraRtmErrorCode)errorCode __attribute__((swift_name("getErrorReason(_:)")));
		[Static]
		[Export ("getErrorReason:")]
		[return: NullAllowed]
		string GetErrorReason (AgoraRtmErrorCode errorCode);

		// +(NSString * _Nonnull)getVersion __attribute__((swift_name("getVersion()")));
		[Static]
		[Export ("getVersion")]
		//[Verify (MethodToProperty)]
		string Version { get; }

		// -(AgoraRtmStreamChannel * _Nullable)createStreamChannel:(NSString * _Nonnull)channelName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("createStreamChannel(_:)")));
		[Export ("createStreamChannel:error:")]
		[return: NullAllowed]
		AgoraRtmStreamChannel CreateStreamChannel (string channelName, [NullAllowed] out NSError error);

		// -(AgoraRtmErrorCode)destroy __attribute__((swift_name("destroy()")));
		[Export ("destroy")]
		//[Verify (MethodToProperty)]
		AgoraRtmErrorCode Destroy { get; }
	}

	// @interface AgoraRtmStreamChannel : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmStreamChannel
	{
		// -(void)joinWithOption:(AgoraRtmJoinChannelOption * _Nonnull)option completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("join(_:completion:)")));
		[Export ("joinWithOption:completion:")]
		void JoinWithOption (AgoraRtmJoinChannelOption option, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)leave:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("leave(_:)")));
		[Export ("leave:")]
		void Leave ([NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)renewToken:(NSString * _Nonnull)token completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("renewToken(_:completion:)")));
		[Export ("renewToken:completion:")]
		void RenewToken (string token, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)joinTopic:(NSString * _Nonnull)topic option:(AgoraRtmJoinTopicOption * _Nullable)option completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("joinTopic(_:option:completion:)")));
		[Export ("joinTopic:option:completion:")]
		void JoinTopic (string topic, [NullAllowed] AgoraRtmJoinTopicOption option, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)leaveTopic:(NSString * _Nonnull)topic completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("leaveTopic(_:completion:)")));
		[Export ("leaveTopic:completion:")]
		void LeaveTopic (string topic, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)subscribeTopic:(NSString * _Nonnull)topic option:(AgoraRtmTopicOption * _Nullable)option completion:(AgoraRtmTopicSubscriptionBlock _Nullable)completionBlock __attribute__((swift_name("subscribeTopic(_:option:completion:)")));
		[Export ("subscribeTopic:option:completion:")]
		void SubscribeTopic (string topic, [NullAllowed] AgoraRtmTopicOption option, [NullAllowed] AgoraRtmTopicSubscriptionBlock completionBlock);

		// -(void)unsubscribeTopic:(NSString * _Nonnull)topic option:(AgoraRtmTopicOption * _Nullable)option completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("unsubscribeTopic(_:option:completion:)")));
		[Export ("unsubscribeTopic:option:completion:")]
		void UnsubscribeTopic (string topic, [NullAllowed] AgoraRtmTopicOption option, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)publishTopicMessage:(NSString * _Nonnull)topic message:(NSString * _Nonnull)message option:(AgoraRtmTopicMessageOptions * _Nullable)options completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("publishTopicMessage(topic:message:option:completion:)")));
		[Export ("publishTopicMessage:message:option:completion:")]
		void PublishTopicMessage (string topic, string message, [NullAllowed] AgoraRtmTopicMessageOptions options, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)publishTopicMessage:(NSString * _Nonnull)topic data:(NSData * _Nonnull)data option:(AgoraRtmTopicMessageOptions * _Nullable)options completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("publishTopicMessage(topic:data:option:completion:)")));
		[Export ("publishTopicMessage:data:option:completion:")]
		void PublishTopicMessage (string topic, NSData data, [NullAllowed] AgoraRtmTopicMessageOptions options, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)getSubscribedUserList:(NSString * _Nonnull)topic completion:(AgoraRtmGetTopicSubscribedUsersBlock _Nullable)completionBlock __attribute__((swift_name("getSubscribedUserList(_:completion:)")));
		[Export ("getSubscribedUserList:completion:")]
		void GetSubscribedUserList (string topic, [NullAllowed] AgoraRtmGetTopicSubscribedUsersBlock completionBlock);

		// -(NSString * _Nonnull)getChannelName __attribute__((swift_name("getChannelName()")));
		[Export ("getChannelName")]
		//[Verify (MethodToProperty)]
		string ChannelName { get; }

		// -(AgoraRtmErrorCode)setParameters:(NSString * _Nonnull)parameters __attribute__((swift_name("setParameters(_:)")));
		[Export ("setParameters:")]
		AgoraRtmErrorCode SetParameters (string parameters);

		// -(AgoraRtmErrorCode)destroy;
		[Export ("destroy")]
		//[Verify (MethodToProperty)]
		AgoraRtmErrorCode Destroy { get; }
	}

	// @interface AgoraRtmStorage : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmStorage
	{
		// -(void)setChannelMetadata:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType data:(AgoraRtmMetadata * _Nonnull)data options:(AgoraRtmMetadataOptions * _Nullable)options lock:(NSString * _Nullable)lock completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("setChannelMetadata(channelName:channelType:data:options:lock:completion:)")));
		[Export ("setChannelMetadata:channelType:data:options:lock:completion:")]
		void SetChannelMetadata (string channelName, AgoraRtmChannelType channelType, AgoraRtmMetadata data, [NullAllowed] AgoraRtmMetadataOptions options, [NullAllowed] string @lock, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)updateChannelMetadata:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType data:(AgoraRtmMetadata * _Nonnull)data options:(AgoraRtmMetadataOptions * _Nullable)options lock:(NSString * _Nullable)lock completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("updateChannelMetadata(channelName:channelType:data:options:lock:completion:)")));
		[Export ("updateChannelMetadata:channelType:data:options:lock:completion:")]
		void UpdateChannelMetadata (string channelName, AgoraRtmChannelType channelType, AgoraRtmMetadata data, [NullAllowed] AgoraRtmMetadataOptions options, [NullAllowed] string @lock, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)removeChannelMetadata:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType data:(AgoraRtmMetadata * _Nonnull)data options:(AgoraRtmMetadataOptions * _Nullable)options lock:(NSString * _Nullable)lock completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("removeChannelMetadata(channelName:channelType:data:options:lock:completion:)")));
		[Export ("removeChannelMetadata:channelType:data:options:lock:completion:")]
		void RemoveChannelMetadata (string channelName, AgoraRtmChannelType channelType, AgoraRtmMetadata data, [NullAllowed] AgoraRtmMetadataOptions options, [NullAllowed] string @lock, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)getChannelMetadata:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType completion:(AgoraRtmGetMetadataBlock _Nullable)completionBlock __attribute__((swift_name("getChannelMetadata(channelName:channelType:completion:)")));
		[Export ("getChannelMetadata:channelType:completion:")]
		void GetChannelMetadata (string channelName, AgoraRtmChannelType channelType, [NullAllowed] AgoraRtmGetMetadataBlock completionBlock);

		// -(void)setUserMetadata:(NSString * _Nonnull)userId data:(AgoraRtmMetadata * _Nonnull)data options:(AgoraRtmMetadataOptions * _Nullable)options completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("setUserMetadata(userId:data:options:completion:)")));
		[Export ("setUserMetadata:data:options:completion:")]
		void SetUserMetadata (string userId, AgoraRtmMetadata data, [NullAllowed] AgoraRtmMetadataOptions options, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)updateUserMetadata:(NSString * _Nonnull)userId data:(AgoraRtmMetadata * _Nonnull)data options:(AgoraRtmMetadataOptions * _Nullable)options completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("updateUserMetadata(userId:data:options:completion:)")));
		[Export ("updateUserMetadata:data:options:completion:")]
		void UpdateUserMetadata (string userId, AgoraRtmMetadata data, [NullAllowed] AgoraRtmMetadataOptions options, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)removeUserMetadata:(NSString * _Nonnull)userId data:(AgoraRtmMetadata * _Nonnull)data options:(AgoraRtmMetadataOptions * _Nullable)options completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("removeUserMetadata(userId:data:options:completion:)")));
		[Export ("removeUserMetadata:data:options:completion:")]
		void RemoveUserMetadata (string userId, AgoraRtmMetadata data, [NullAllowed] AgoraRtmMetadataOptions options, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)getUserMetadata:(NSString * _Nonnull)userId completion:(AgoraRtmGetMetadataBlock _Nullable)completionBlock __attribute__((swift_name("getUserMetadata(userId:completion:)")));
		[Export ("getUserMetadata:completion:")]
		void GetUserMetadata (string userId, [NullAllowed] AgoraRtmGetMetadataBlock completionBlock);

		// -(void)subscribeUserMetadata:(NSString * _Nonnull)userId completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("subscribeUserMetadata(userId:completion:)")));
		[Export ("subscribeUserMetadata:completion:")]
		void SubscribeUserMetadata (string userId, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)unsubscribeUserMetadata:(NSString * _Nonnull)userId completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("unsubscribeUserMetadata(userId:completion:)")));
		[Export ("unsubscribeUserMetadata:completion:")]
		void UnsubscribeUserMetadata (string userId, [NullAllowed] AgoraRtmOperationBlock completionBlock);
	}

	// @interface AgoraRtmLock : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmLock
	{
		// -(void)setLock:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType lockName:(NSString * _Nonnull)lockName ttl:(int)ttl completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("setLock(channelName:channelType:lockName:ttl:completion:)")));
		[Export ("setLock:channelType:lockName:ttl:completion:")]
		void SetLock (string channelName, AgoraRtmChannelType channelType, string lockName, int ttl, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)removeLock:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType lockName:(NSString * _Nonnull)lockName completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("removeLock(channelName:channelType:lockName:completion:)")));
		[Export ("removeLock:channelType:lockName:completion:")]
		void RemoveLock (string channelName, AgoraRtmChannelType channelType, string lockName, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)acquireLock:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType lockName:(NSString * _Nonnull)lockName retry:(BOOL)retry completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("acquireLock(channelName:channelType:lockName:retry:completion:)")));
		[Export ("acquireLock:channelType:lockName:retry:completion:")]
		void AcquireLock (string channelName, AgoraRtmChannelType channelType, string lockName, bool retry, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)releaseLock:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType lockName:(NSString * _Nonnull)lockName completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("releaseLock(channelName:channelType:lockName:completion:)")));
		[Export ("releaseLock:channelType:lockName:completion:")]
		void ReleaseLock (string channelName, AgoraRtmChannelType channelType, string lockName, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)revokeLock:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType lockName:(NSString * _Nonnull)lockName userId:(NSString * _Nonnull)userId completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("revokeLock(channelName:channelType:lockName:userId:completion:)")));
		[Export ("revokeLock:channelType:lockName:userId:completion:")]
		void RevokeLock (string channelName, AgoraRtmChannelType channelType, string lockName, string userId, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)getLocks:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType completion:(AgoraRtmGetLocksBlock _Nullable)completionBlock __attribute__((swift_name("getLocks(channelName:channelType:completion:)")));
		[Export ("getLocks:channelType:completion:")]
		void GetLocks (string channelName, AgoraRtmChannelType channelType, [NullAllowed] AgoraRtmGetLocksBlock completionBlock);
	}

	// @interface AgoraRtmPresence : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmPresence
	{
		// -(void)whoNow:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType options:(AgoraRtmPresenceOptions * _Nullable)options completion:(AgoraRtmWhoNowBlock _Nullable)completionBlock __attribute__((swift_name("whoNow(channelName:channelType:options:completion:)")));
		[Export ("whoNow:channelType:options:completion:")]
		void WhoNow (string channelName, AgoraRtmChannelType channelType, [NullAllowed] AgoraRtmPresenceOptions options, [NullAllowed] AgoraRtmWhoNowBlock completionBlock);

		// -(void)getOnlineUsers:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType options:(AgoraRtmGetOnlineUsersOptions * _Nullable)options completion:(AgoraRtmGetOnlineUsersBlock _Nullable)completionBlock __attribute__((swift_name("getOnlineUser(channelName:channelType:options:completion:)")));
		[Export ("getOnlineUsers:channelType:options:completion:")]
		void GetOnlineUsers (string channelName, AgoraRtmChannelType channelType, [NullAllowed] AgoraRtmGetOnlineUsersOptions options, [NullAllowed] AgoraRtmGetOnlineUsersBlock completionBlock);

		// -(void)whereNow:(NSString * _Nonnull)userId completion:(AgoraRtmWhereNowBlock _Nullable)completionBlock __attribute__((swift_name("whereNow(userId:completion:)")));
		[Export ("whereNow:completion:")]
		void WhereNow (string userId, [NullAllowed] AgoraRtmWhereNowBlock completionBlock);

		// -(void)getUserChannels:(NSString * _Nonnull)userId completion:(AgoraRtmGetUserChannelsBlock _Nullable)completionBlock __attribute__((swift_name("getUserChannels(userId:completion:)")));
		[Export ("getUserChannels:completion:")]
		void GetUserChannels (string userId, [NullAllowed] AgoraRtmGetUserChannelsBlock completionBlock);

		// -(void)setState:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType items:(NSDictionary<NSString *,NSString *> * _Nonnull)items completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("setState(channelName:channelType:items:completion:)")));
		[Export ("setState:channelType:items:completion:")]
		void SetState (string channelName, AgoraRtmChannelType channelType, NSDictionary<NSString, NSString> items, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)removeState:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType keys:(NSArray<NSString *> * _Nonnull)keys completion:(AgoraRtmOperationBlock _Nullable)completionBlock __attribute__((swift_name("removeState(channelName:channelType:keys:completion:)")));
		[Export ("removeState:channelType:keys:completion:")]
		void RemoveState (string channelName, AgoraRtmChannelType channelType, string[] keys, [NullAllowed] AgoraRtmOperationBlock completionBlock);

		// -(void)getState:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType userId:(NSString * _Nonnull)userId completion:(AgoraRtmPresenceGetStateBlock _Nullable)completionBlock __attribute__((swift_name("getState(channelName:channelType:userId:completion:)")));
		[Export ("getState:channelType:userId:completion:")]
		void GetState (string channelName, AgoraRtmChannelType channelType, string userId, [NullAllowed] AgoraRtmPresenceGetStateBlock completionBlock);
	}

	// @interface AgoraRtmHistory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AgoraRtmHistory
	{
		// -(void)getMessages:(NSString * _Nonnull)channelName channelType:(AgoraRtmChannelType)channelType options:(AgoraRtmGetHistoryMessagesOptions * _Nullable)options completion:(AgoraRtmGetHistoryMessagesBlock _Nullable)completionBlock __attribute__((swift_name("getMessages(channelName:channelType:options:completion:)")));
		[Export ("getMessages:channelType:options:completion:")]
		void GetMessages (string channelName, AgoraRtmChannelType channelType, [NullAllowed] AgoraRtmGetHistoryMessagesOptions options, [NullAllowed] AgoraRtmGetHistoryMessagesBlock completionBlock);
	}
}
