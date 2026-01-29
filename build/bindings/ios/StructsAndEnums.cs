using System;
using ObjCRuntime;

namespace HotCoffee.Maui.Agora.Signaling.iOS
{
	[Flags]
	[Native]
	public enum AgoraRtmAreaCode : ulong
	{
		Cn = 0x1,
		Na = 0x2,
		Eu = 0x4,
		As = 0x8,
		Jp = 0x10,
		In = 0x20,
		Glob = (0xffffffffL)
	}

	[Native]
	public enum AgoraRtmTokenEventTokenType : long
	{
		WillExpire = 1,
		ReadPermissionRevoked = 2
	}

	[Native]
	public enum AgoraRtmEncryptionMode : long
	{
		None = 0,
		Aes128gcm = 1,
		Aes256gcm = 2
	}

	[Native]
	public enum AgoraRtmMessagePriority : long
	{
		Highest = 0,
		High = 1,
		Normal = 4,
		Low = 8
	}

	[Native]
	public enum AgoraRtmErrorCode : long
	{
		Ok = 0,
		NotInitialized = -10001,
		NotLogin = -10002,
		InvalidAppId = -10003,
		InvalidEventHandler = -10004,
		InvalidToken = -10005,
		InvalidUserId = -10006,
		InitServiceFailed = -10007,
		InvalidChannelName = -10008,
		TokenExpired = -10009,
		LoginNoServerResources = -10010,
		LoginTimeout = -10011,
		LoginRejected = -10012,
		LoginAborted = -10013,
		InvalidParameter = -10014,
		LoginNotAuthorized = -10015,
		LoginInconsistentAppId = -10016,
		DuplicateOperation = -10017,
		InstanceAlreadyReleased = -10018,
		InvalidChannelType = -10019,
		InvalidEncryptionParameter = -10020,
		OperationRateExceedLimitation = -10021,
		ServiceNotSupport = -10022,
		LoginCanceled = -10023,
		InvalidPrivateConfig = -10024,
		NotConnected = -10025,
		RenewTokenTimeout = -10026,
		ChannelNotJoined = -11001,
		ChannelNotSubscribed = -11002,
		ChannelExceedTopicUserLimitation = -11003,
		ChannelReused = -11004,
		ChannelInstanceExceedLimitation = -11005,
		ChannelInErrorState = -11006,
		ChannelJoinFailed = -11007,
		ChannelInvalidTopicName = -11008,
		ChannelInvalidMessage = -11009,
		ChannelMessageLengthExceedLimitation = -11010,
		ChannelInvalidUserList = -11011,
		ChannelNotAvailable = -11012,
		ChannelTopicNotSubscribed = -11013,
		ChannelExceedTopicLimitation = -11014,
		ChannelJoinTopicFailed = -11015,
		ChannelTopicNotJoined = -11016,
		ChannelTopicNotExist = -11017,
		ChannelInvalidTopicMeta = -11018,
		ChannelSubscribeTimeout = -11019,
		ChannelSubscribeTooFrequent = -11020,
		ChannelSubscribeFailed = -11021,
		ChannelUnsubscribeFailed = -11022,
		ChannelEncryptMessageFailed = -11023,
		ChannelPublishMessageFailed = -11024,
		ChannelPublishMessageTooFrequent = -11025,
		ChannelPublishMessageTimeout = -11026,
		ChannelNotConnected = -11027,
		ChannelLeaveFailed = -11028,
		ChannelCustomTypeLengthOverflow = -11029,
		ChannelInvalidCustomType = -11030,
		ChannelUnsupportedMessageType = -11031,
		ChannelPresenceNotReady = -11032,
		ChannelReceiverOffline = -11033,
		ChannelJoinCanceled = -11034,
		ChannelReceiverOfflineButMessageStoreSucceeded = -11035,
		ChannelReceiverOfflineAndMessageStoreFailed = -11036,
		ChannelMessageDeliveredButStoreFailed = -11037,
		ChannelSubscribePermissionDenied = -11038,
		ChannelPublishPermissionDenied = -11039,
		StorageOperationFailed = -12001,
		StorageMetadataItemExceedLimitation = -12002,
		StorageInvalidMetadataItem = -12003,
		StorageInvalidArgument = -12004,
		StorageInvalidRevision = -12005,
		StorageMetadataLengthOverflow = -12006,
		StorageInvalidLockName = -12007,
		StorageLockNotAcquired = -12008,
		StorageInvalidKey = -12009,
		StorageInvalidValue = -12010,
		StorageKeyLengthOverflow = -12011,
		StorageValueLengthOverflow = -12012,
		StorageDuplicateKey = -12013,
		StorageOutdatedRevision = -12014,
		StorageNotSubscribe = -12015,
		StorageInvalidMetadataInstance = -12016,
		StorageSubscribeUserExceedLimitation = -12017,
		StorageOperationTimeout = -12018,
		StorageNotAvailable = -12019,
		StoragePermissionDenied = -12020,
		PresenceNotConnected = -13001,
		PresenceNotWritable = -13002,
		PresenceInvalidArgument = -13003,
		PresenceCacheTooManyStates = -13004,
		PresenceStateCountOverflow = -13005,
		PresenceInvalidStateKey = -13006,
		PresenceInvalidStateValue = -13007,
		PresenceStateKeySizeOverflow = -13008,
		PresenceStateValueSizeOverflow = -13009,
		PresenceStateDuplicateKey = -13010,
		PresenceUserNotExist = -13011,
		PresenceOperationTimeout = -13012,
		PresenceOperationFailed = -13013,
		LockOperationFailed = -14001,
		LockOperationTimeout = -14002,
		LockOperationPerforming = -14003,
		LockAlreadyExist = -14004,
		LockInvalidName = -14005,
		LockNotAcquired = -14006,
		LockAcquireFailed = -14007,
		LockNotExist = -14008,
		LockNotAvailable = -14009,
		HistoryOperationFailed = -15001,
		HistoryInvalidTimestamp = -15002,
		HistoryOperationTimeout = -15003,
		HistoryOperationNotPermitted = -15004,
		HistoryNotAvailable = -15005,
		HistoryPermissionDenied = -15006
	}

	[Native]
	public enum AgoraRtmStorageType : long
	{
		None = 0,
		User = 1,
		Channel = 2
	}

	[Native]
	public enum AgoraRtmLockEventType : long
	{
		None = 0,
		Snapshot = 1,
		LockSet = 2,
		LockRemoved = 3,
		LockAcquired = 4,
		LockReleased = 5,
		LockExpired = 6
	}

	[Native]
	public enum AgoraRtmProxyType : long
	{
		None = 0,
		Http = 1,
		CloudTcp = 2
	}

	[Flags]
	[Native]
	public enum AgoraRtmServiceType : long
	{
		None = 0x0,
		Message = 0x1,
		Stream = 0x2
	}

	[Native]
	public enum AgoraRtmProtocolType : long
	{
		Udp = 0,
		Only = 1
	}

	[Native]
	public enum AgoraRtmLinkState : long
	{
		Idle = 0,
		Connecting = 1,
		Connected = 2,
		Disconnected = 3,
		Suspended = 4,
		Failed = 5
	}

	[Native]
	public enum AgoraRtmLinkStateChangeReason : long
	{
		Unknown = 0,
		Login = 1,
		LoginSuccess = 2,
		LoginTimeout = 3,
		LoginNotAuthorized = 4,
		LoginRejected = 5,
		Relogin = 6,
		Logout = 7,
		AutoReconnect = 8,
		ReconnectTimeout = 9,
		ReconnectSuccess = 10,
		Join = 11,
		JoinSuccess = 12,
		JoinFailed = 13,
		Rejoin = 14,
		Leave = 15,
		InvalidToken = 16,
		TokenExpired = 17,
		InconsistentAppId = 18,
		InvalidChannelName = 19,
		InvalidUserId = 20,
		NotInitialized = 21,
		RtmServiceNotConnected = 22,
		ChannelInstanceExceedLimitation = 23,
		OperationRateExceedLimitation = 24,
		ChannelInErrorState = 25,
		PresenceNotConnected = 26,
		SameUidLogin = 27,
		KickedOutByServer = 28,
		KeepAliveTimeout = 29,
		ConnectionError = 30,
		PresenceNotReady = 31,
		NetworkChange = 32,
		ServiceNotSupported = 33,
		StreamChannelNotAvailable = 34,
		StorageNotAvailable = 35,
		LockNotAvailable = 36,
		LoginTooFrequent = 37
	}

	[Native]
	public enum AgoraRtmLinkOperation : long
	{
		Login = 0,
		Logout = 1,
		Join = 2,
		Leave = 3,
		ServerReject = 4,
		AutoReconnect = 5,
		Reconnected = 6,
		HeartbeatTimeout = 7,
		ServerTimeout = 8,
		NetworkChange = 9
	}

	[Native]
	public enum AgoraRtmTopicEventType : long
	{
		None = 0,
		Snapshot = 1,
		RemoteJoinTopic = 2,
		RemoteLeaveTopic = 3
	}

	[Native]
	public enum AgoraRtmPresenceEventType : long
	{
		None = 0,
		Snapshot = 1,
		Interval = 2,
		RemoteJoinChannel = 3,
		RemoteLeaveChannel = 4,
		RemoteConnectionTimeout = 5,
		RemoteStateChanged = 6,
		ErrorOutOfService = 7
	}

	[Flags]
	[Native]
	public enum AgoraRtmJoinChannelFeature : ulong
	{
		None = 0x0,
		Presence = 0x1,
		Metadata = 1uL << 1,
		Lock = 1uL << 2,
		BeQuiet = 1uL << 3
	}

	[Flags]
	[Native]
	public enum AgoraRtmSubscribeChannelFeature : ulong
	{
		None = 0x0,
		Presence = 0x1,
		Metadata = 1uL << 1,
		Message = 1uL << 2,
		Lock = 1uL << 3,
		BeQuiet = 1uL << 4
	}

	[Native]
	public enum AgoraRtmClientConnectionState : long
	{
		Disconnected = 1,
		Connecting = 2,
		Connected = 3,
		Reconnecting = 4,
		Failed = 5
	}

	[Native]
	public enum AgoraRtmClientConnectionChangeReason : long
	{
		Connecting = 0,
		JoinSuccess = 1,
		Interrupted = 2,
		BannedByServer = 3,
		JoinFailed = 4,
		LeaveChannel = 5,
		InvalidAppId = 6,
		InvalidChannelName = 7,
		InvalidToken = 8,
		TokenExpired = 9,
		RejectedByServer = 10,
		SettingProxyServer = 11,
		RenewToken = 12,
		ClientIpAddressChanged = 13,
		KeepAliveTimeout = 14,
		RejoinSuccess = 15,
		ChangedLost = 16,
		EchoTest = 17,
		ClientIpAddressChangedByUser = 18,
		SameUidLogin = 19,
		TooManyBroadcasters = 20,
		LicenseValidationFailure = 21,
		CertificationVerifyFailure = 22,
		StreamChannelNotAvailable = 23,
		InconsistentAppId = 24,
		LoginSuccess = 10001,
		Logout = 10002,
		PresenceNotReady = 10003
	}

	[Native]
	public enum AgoraRtmChannelType : long
	{
		None = 0,
		Message = 1,
		Stream = 2,
		User = 3
	}

	[Native]
	public enum AgoraRtmStorageEventType : long
	{
		None = 0,
		Snapshot = 1,
		Set = 2,
		Update = 3,
		Remove = 4
	}

	[Native]
	public enum AgoraRtmPresenceType : long
	{
		RemoteJoinChannel = 0,
		RemoteLeaveChannel = 1,
		RemoteConnectionTimeout = 2,
		RemoteJoinTopic = 3,
		RemoteLeaveTopic = 4,
		SelfJoinChannel = 5
	}

	[Native]
	public enum AgoraRtmMessageQos : long
	{
		Unordered = 0,
		Ordered = 1
	}

	[Native]
	public enum AgoraRtmLogLevel : long
	{
		None = 0,
		Info = 1,
		Warn = 2,
		Error = 4,
		Fatal = 8
	}
}
