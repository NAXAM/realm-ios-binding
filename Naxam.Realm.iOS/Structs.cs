using System;
using ObjCRuntime;

namespace NxRealm
{
	public enum RLMPropertyType
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

	[Native]
	public enum RLMSyncError : long
	{
		BadResponse = 1,
		ClientSessionError = 4,
		ClientUserError = 5,
		ClientInternalError = 6,
		ClientResetError = 7,
		UnderlyingAuthError = 8
	}

	[Native]
	public enum RLMSyncAuthError : long
	{
		BadResponse = 1,
		BadRemoteRealmPath = 2,
		HTTPStatusCodeError = 3,
		ClientSessionError = 4,
		InvalidCredential = 611,
		UserDoesNotExist = 612,
		UserAlreadyExists = 613
	}

	[Native]
	public enum RLMSyncPermissionError : long
	{
		ChangeFailed = 1,
		GetFailed = 2
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

	[Native]
	public enum RLMSyncStopPolicy : ulong
	{
		Immediately,
		LiveIndefinitely,
		AfterChangesUploaded
	}

	[Native]
	public enum RLMSyncSystemErrorKind : ulong
	{
		ClientReset,
		Client,
		Connection,
		Session,
		User,
		Unknown
	}
}
