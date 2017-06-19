using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace NxRealm
{
	public enum RLMPropertyType : long
	{
		Int = 0,
		Bool = 1,
		Float = 9,
		Double = 10,
		String = 2,
		Data = 4,
		Any = 6,
		Date = 8,
		Object = 12,
		Array = 13,
		LinkingObjects = 14
	}

	[Native]
	public enum RLMError : long
	{
		Fail = 1,
		FileAccess = 2,
		FilePermissionDenied = 3,
		FileExists = 4,
		FileNotFound = 5,
		FileFormatUpgradeRequired = 6,
		IncompatibleLockFile = 8,
		AddressSpaceExhausted = 9,
		SchemaMismatch = 10
	}

	// static class CFunctions
	// {
	// 	// extern RLMRealm * _Nullable RLMObjectBaseRealm (RLMObjectBase * _Nullable object);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	[return: NullAllowed]
	// 	static extern RLMRealm RLMObjectBaseRealm ([NullAllowed] RLMObjectBase @object);

	// 	// extern RLMObjectSchema * _Nullable RLMObjectBaseObjectSchema (RLMObjectBase * _Nullable object);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	[return: NullAllowed]
	// 	static extern RLMObjectSchema RLMObjectBaseObjectSchema ([NullAllowed] RLMObjectBase @object);

	// 	// extern id _Nullable RLMObjectBaseObjectForKeyedSubscript (RLMObjectBase * _Nullable object, NSString * _Nonnull key);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	[return: NullAllowed]
	// 	static extern NSObject RLMObjectBaseObjectForKeyedSubscript ([NullAllowed] RLMObjectBase @object, NSString key);

	// 	// extern void RLMObjectBaseSetObjectForKeyedSubscript (RLMObjectBase * _Nullable object, NSString * _Nonnull key, id _Nullable obj);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern void RLMObjectBaseSetObjectForKeyedSubscript ([NullAllowed] RLMObjectBase @object, NSString key, [NullAllowed] NSObject obj);
	// }

	[Native]
	public enum RLMSyncError : long
	{
		BadResponse = 1,
        BadRemoteRealmPath      = 2,
        HTTPStatusCodeError     = 3,
		ClientSessionError = 4,
		ClientUserError = 5,
		ClientInternalError = 6,
		ClientResetError = 7,
		UnderlyingAuthError = 8
	}

	[Native]
	public enum RLMSyncAuthError : long
	{
		InvalidCredential = 611,
		UserDoesNotExist = 612,
		UserAlreadyExists = 613
	}

	[Native]
	public enum RLMSyncManagementObjectStatus : ulong
	{
		NotProcessed,
		Success,
		Error
	}

	[Native]
	public enum RLMSyncLogLevel : ulong
	{
		Off,
		Fatal,
		Error,
		Warn,
		Info,
		Detail,
		Debug,
		Trace,
		All
	}

	[Native]
	public enum RLMSyncUserState : ulong
	{
		LoggedOut,
		Active,
		Error
	}

	[Native]
	public enum RLMSyncPermissionResultsSortProperty : ulong
	{
		PropertyPath,
		PropertyUserID,
		DateUpdated
	}

	[Native]
	public enum RLMSyncAccessLevel : ulong
	{
		None = 0,
		Read = 1,
		Write = 2,
		Admin = 3
	}

	[Native]
	public enum RLMSyncSessionState : ulong
	{
		Active,
		Inactive,
		Invalid
	}

	[Native]
	public enum RLMSyncProgressDirection : ulong
	{
		Upload,
		Download
	}

	[Native]
	public enum RLMSyncProgress : ulong
	{
		ReportIndefinitely,
		ForCurrentlyOutstandingWork
	}
}
