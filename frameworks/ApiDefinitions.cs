using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Realm;

namespace NxRealm
{
	// @interface RLMSync (NSError)
	[Category]
	[BaseType (typeof(NSError))]
	interface NSError_RLMSync
	{
		// -(void (^ _Nullable)(void))rlmSync_clientResetBlock;
		[NullAllowed, Export ("rlmSync_clientResetBlock")]
		[Verify (MethodToProperty)]
		Action RlmSync_clientResetBlock { get; }

		// -(NSString * _Nullable)rlmSync_clientResetBackedUpRealmPath;
		[NullAllowed, Export ("rlmSync_clientResetBackedUpRealmPath")]
		[Verify (MethodToProperty)]
		string RlmSync_clientResetBackedUpRealmPath { get; }
	}

	// audit-objc-generics: @interface RLMArray<RLMObjectType : RLMObject *> : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMArray
	{
		// @property (readonly, assign, nonatomic) NSUInteger count;
		[Export ("count")]
		nuint Count { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull objectClassName;
		[Export ("objectClassName")]
		string ObjectClassName { get; }

		// @property (readonly, nonatomic) RLMRealm * _Nullable realm;
		[NullAllowed, Export ("realm")]
		RLMRealm Realm { get; }

		// @property (readonly, getter = isInvalidated, nonatomic) BOOL invalidated;
		[Export ("invalidated")]
		bool Invalidated { [Bind ("isInvalidated")] get; }

		// -(RLMObjectType _Nonnull)objectAtIndex:(NSUInteger)index;
		[Export ("objectAtIndex:")]
		RLMObject ObjectAtIndex (nuint index);

		// -(RLMObjectType _Nullable)firstObject;
		[NullAllowed, Export ("firstObject")]
		[Verify (MethodToProperty)]
		RLMObject FirstObject { get; }

		// -(RLMObjectType _Nullable)lastObject;
		[NullAllowed, Export ("lastObject")]
		[Verify (MethodToProperty)]
		RLMObject LastObject { get; }

		// -(void)addObject:(RLMObjectType _Nonnull)object;
		[Export ("addObject:")]
		void AddObject (RLMObject @object);

		// -(void)addObjects:(id<NSFastEnumeration> _Nonnull)objects;
		[Export ("addObjects:")]
		void AddObjects (NSFastEnumeration objects);

		// -(void)insertObject:(RLMObjectType _Nonnull)anObject atIndex:(NSUInteger)index;
		[Export ("insertObject:atIndex:")]
		void InsertObject (RLMObject anObject, nuint index);

		// -(void)removeObjectAtIndex:(NSUInteger)index;
		[Export ("removeObjectAtIndex:")]
		void RemoveObjectAtIndex (nuint index);

		// -(void)removeLastObject;
		[Export ("removeLastObject")]
		void RemoveLastObject ();

		// -(void)removeAllObjects;
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();

		// -(void)replaceObjectAtIndex:(NSUInteger)index withObject:(RLMObjectType _Nonnull)anObject;
		[Export ("replaceObjectAtIndex:withObject:")]
		void ReplaceObjectAtIndex (nuint index, RLMObject anObject);

		// -(void)moveObjectAtIndex:(NSUInteger)sourceIndex toIndex:(NSUInteger)destinationIndex;
		[Export ("moveObjectAtIndex:toIndex:")]
		void MoveObjectAtIndex (nuint sourceIndex, nuint destinationIndex);

		// -(void)exchangeObjectAtIndex:(NSUInteger)index1 withObjectAtIndex:(NSUInteger)index2;
		[Export ("exchangeObjectAtIndex:withObjectAtIndex:")]
		void ExchangeObjectAtIndex (nuint index1, nuint index2);

		// -(NSUInteger)indexOfObject:(RLMObjectType _Nonnull)object;
		[Export ("indexOfObject:")]
		nuint IndexOfObject (RLMObject @object);

		// -(NSUInteger)indexOfObjectWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Internal]
		[Export ("indexOfObjectWhere:", IsVariadic = true)]
		nuint IndexOfObjectWhere (string predicateFormat, IntPtr varArgs);

		// -(NSUInteger)indexOfObjectWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Export ("indexOfObjectWhere:args:")]
		unsafe nuint IndexOfObjectWhere (string predicateFormat, sbyte* args);

		// -(NSUInteger)indexOfObjectWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Export ("indexOfObjectWithPredicate:")]
		nuint IndexOfObjectWithPredicate (NSPredicate predicate);

		// -(RLMResults * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Internal]
		[Export ("objectsWhere:", IsVariadic = true)]
		RLMResults ObjectsWhere (string predicateFormat, IntPtr varArgs);

		// -(RLMResults * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Export ("objectsWhere:args:")]
		unsafe RLMResults ObjectsWhere (string predicateFormat, sbyte* args);

		// -(RLMResults * _Nonnull)objectsWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Export ("objectsWithPredicate:")]
		RLMResults ObjectsWithPredicate (NSPredicate predicate);

		// -(RLMResults * _Nonnull)sortedResultsUsingKeyPath:(NSString * _Nonnull)keyPath ascending:(BOOL)ascending;
		[Export ("sortedResultsUsingKeyPath:ascending:")]
		RLMResults SortedResultsUsingKeyPath (string keyPath, bool ascending);

		// -(RLMResults * _Nonnull)sortedResultsUsingProperty:(NSString * _Nonnull)property ascending:(BOOL)ascending __attribute__((deprecated("Use `-sortedResultsUsingKeyPath:ascending:`")));
		[Export ("sortedResultsUsingProperty:ascending:")]
		RLMResults SortedResultsUsingProperty (string property, bool ascending);

		// -(RLMResults * _Nonnull)sortedResultsUsingDescriptors:(NSArray * _Nonnull)properties;
		[Export ("sortedResultsUsingDescriptors:")]
		[Verify (StronglyTypedNSArray)]
		RLMResults SortedResultsUsingDescriptors (NSObject[] properties);

		// -(RLMObjectType _Nonnull)objectAtIndexedSubscript:(NSUInteger)index;
		[Export ("objectAtIndexedSubscript:")]
		RLMObject ObjectAtIndexedSubscript (nuint index);

		// -(void)setObject:(RLMObjectType _Nonnull)newValue atIndexedSubscript:(NSUInteger)index;
		[Export ("setObject:atIndexedSubscript:")]
		void SetObject (RLMObject newValue, nuint index);

		// -(RLMNotificationToken * _Nonnull)addNotificationBlock:(void (^ _Nonnull)(RLMArray<RLMObjectType> * _Nullable, int * _Nullable, NSError * _Nullable))block __attribute__((warn_unused_result));
		[Export ("addNotificationBlock:")]
		unsafe RLMNotificationToken AddNotificationBlock (Action<RLMArray<RLMObject>, int*, NSError> block);

		// -(id _Nullable)minOfProperty:(NSString * _Nonnull)property;
		[Export ("minOfProperty:")]
		[return: NullAllowed]
		NSObject MinOfProperty (string property);

		// -(id _Nullable)maxOfProperty:(NSString * _Nonnull)property;
		[Export ("maxOfProperty:")]
		[return: NullAllowed]
		NSObject MaxOfProperty (string property);

		// -(NSNumber * _Nonnull)sumOfProperty:(NSString * _Nonnull)property;
		[Export ("sumOfProperty:")]
		NSNumber SumOfProperty (string property);

		// -(NSNumber * _Nullable)averageOfProperty:(NSString * _Nonnull)property;
		[Export ("averageOfProperty:")]
		[return: NullAllowed]
		NSNumber AverageOfProperty (string property);
	}

	// @interface Swift (RLMArray)
	[Category]
	[BaseType (typeof(RLMArray))]
	interface RLMArray_Swift
	{
		// -(instancetype _Nonnull)initWithObjectClassName:(NSString * _Nonnull)objectClassName;
		[Export ("initWithObjectClassName:")]
		IntPtr Constructor (string objectClassName);
	}

	// @protocol RLMThreadConfined <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface RLMThreadConfined
	{
		// @required @property (readonly, nonatomic) RLMRealm * _Nullable realm;
		[Abstract]
		[NullAllowed, Export ("realm")]
		RLMRealm Realm { get; }

		// @required @property (readonly, getter = isInvalidated, nonatomic) BOOL invalidated;
		[Abstract]
		[Export ("invalidated")]
		bool Invalidated { [Bind ("isInvalidated")] get; }
	}

	// audit-objc-generics: @interface RLMThreadSafeReference<__covariant Confined : id<RLMThreadConfined>> : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMThreadSafeReference
	{
		// +(instancetype _Nonnull)referenceWithThreadConfined:(Confined _Nonnull)threadConfined;
		[Static]
		[Export ("referenceWithThreadConfined:")]
		RLMThreadSafeReference ReferenceWithThreadConfined (RLMThreadConfined threadConfined);

		// @property (readonly, getter = isInvalidated, nonatomic) BOOL invalidated;
		[Export ("invalidated")]
		bool Invalidated { [Bind ("isInvalidated")] get; }
	}

	// @protocol RLMCollection <NSFastEnumeration, RLMThreadConfined>
	[Protocol, Model]
	interface RLMCollection : INSFastEnumeration, IRLMThreadConfined
	{
		// @required @property (readonly, assign, nonatomic) NSUInteger count;
		[Abstract]
		[Export ("count")]
		nuint Count { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull objectClassName;
		[Abstract]
		[Export ("objectClassName")]
		string ObjectClassName { get; }

		// @required @property (readonly, nonatomic) RLMRealm * _Nonnull realm;
		[Abstract]
		[Export ("realm")]
		RLMRealm Realm { get; }

		// @required -(id _Nonnull)objectAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("objectAtIndex:")]
		NSObject ObjectAtIndex (nuint index);

		// @required -(id _Nullable)firstObject;
		[Abstract]
		[NullAllowed, Export ("firstObject")]
		[Verify (MethodToProperty)]
		NSObject FirstObject { get; }

		// @required -(id _Nullable)lastObject;
		[Abstract]
		[NullAllowed, Export ("lastObject")]
		[Verify (MethodToProperty)]
		NSObject LastObject { get; }

		// @required -(NSUInteger)indexOfObject:(RLMObject * _Nonnull)object;
		[Abstract]
		[Export ("indexOfObject:")]
		nuint IndexOfObject (RLMObject @object);

		// @required -(NSUInteger)indexOfObjectWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Internal, Abstract]
		[Export ("indexOfObjectWhere:", IsVariadic = true)]
		nuint IndexOfObjectWhere (string predicateFormat, IntPtr varArgs);

		// @required -(NSUInteger)indexOfObjectWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Abstract]
		[Export ("indexOfObjectWhere:args:")]
		unsafe nuint IndexOfObjectWhere (string predicateFormat, sbyte* args);

		// @required -(NSUInteger)indexOfObjectWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Abstract]
		[Export ("indexOfObjectWithPredicate:")]
		nuint IndexOfObjectWithPredicate (NSPredicate predicate);

		// @required -(RLMResults * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Internal, Abstract]
		[Export ("objectsWhere:", IsVariadic = true)]
		RLMResults ObjectsWhere (string predicateFormat, IntPtr varArgs);

		// @required -(RLMResults * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Abstract]
		[Export ("objectsWhere:args:")]
		unsafe RLMResults ObjectsWhere (string predicateFormat, sbyte* args);

		// @required -(RLMResults * _Nonnull)objectsWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Abstract]
		[Export ("objectsWithPredicate:")]
		RLMResults ObjectsWithPredicate (NSPredicate predicate);

		// @required -(RLMResults * _Nonnull)sortedResultsUsingKeyPath:(NSString * _Nonnull)keyPath ascending:(BOOL)ascending;
		[Abstract]
		[Export ("sortedResultsUsingKeyPath:ascending:")]
		RLMResults SortedResultsUsingKeyPath (string keyPath, bool ascending);

		// @required -(RLMResults * _Nonnull)sortedResultsUsingProperty:(NSString * _Nonnull)property ascending:(BOOL)ascending __attribute__((deprecated("Use `-sortedResultsUsingKeyPath:ascending:`")));
		[Abstract]
		[Export ("sortedResultsUsingProperty:ascending:")]
		RLMResults SortedResultsUsingProperty (string property, bool ascending);

		// @required -(RLMResults * _Nonnull)sortedResultsUsingDescriptors:(NSArray<RLMSortDescriptor *> * _Nonnull)properties;
		[Abstract]
		[Export ("sortedResultsUsingDescriptors:")]
		RLMResults SortedResultsUsingDescriptors (RLMSortDescriptor[] properties);

		// @required -(id _Nonnull)objectAtIndexedSubscript:(NSUInteger)index;
		[Abstract]
		[Export ("objectAtIndexedSubscript:")]
		NSObject ObjectAtIndexedSubscript (nuint index);

		// @required -(id _Nullable)valueForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("valueForKey:")]
		[return: NullAllowed]
		NSObject ValueForKey (string key);

		// @required -(void)setValue:(id _Nullable)value forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setValue:forKey:")]
		void SetValue ([NullAllowed] NSObject value, string key);

		// @required -(RLMNotificationToken * _Nonnull)addNotificationBlock:(void (^ _Nonnull)(id<RLMCollection> _Nullable, RLMCollectionChange * _Nullable, NSError * _Nullable))block __attribute__((warn_unused_result));
		[Abstract]
		[Export ("addNotificationBlock:")]
		RLMNotificationToken AddNotificationBlock (Action<RLMCollection, RLMCollectionChange, NSError> block);

		// @required -(id _Nullable)minOfProperty:(NSString * _Nonnull)property;
		[Abstract]
		[Export ("minOfProperty:")]
		[return: NullAllowed]
		NSObject MinOfProperty (string property);

		// @required -(id _Nullable)maxOfProperty:(NSString * _Nonnull)property;
		[Abstract]
		[Export ("maxOfProperty:")]
		[return: NullAllowed]
		NSObject MaxOfProperty (string property);

		// @required -(NSNumber * _Nonnull)sumOfProperty:(NSString * _Nonnull)property;
		[Abstract]
		[Export ("sumOfProperty:")]
		NSNumber SumOfProperty (string property);

		// @required -(NSNumber * _Nullable)averageOfProperty:(NSString * _Nonnull)property;
		[Abstract]
		[Export ("averageOfProperty:")]
		[return: NullAllowed]
		NSNumber AverageOfProperty (string property);
	}

	// @interface RLMSortDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMSortDescriptor
	{
		// @property (readonly, nonatomic) NSString * _Nonnull keyPath;
		[Export ("keyPath")]
		string KeyPath { get; }

		// @property (readonly, nonatomic) BOOL ascending;
		[Export ("ascending")]
		bool Ascending { get; }

		// +(instancetype _Nonnull)sortDescriptorWithKeyPath:(NSString * _Nonnull)keyPath ascending:(BOOL)ascending;
		[Static]
		[Export ("sortDescriptorWithKeyPath:ascending:")]
		RLMSortDescriptor SortDescriptorWithKeyPath (string keyPath, bool ascending);

		// -(instancetype _Nonnull)reversedSortDescriptor;
		[Export ("reversedSortDescriptor")]
		RLMSortDescriptor ReversedSortDescriptor ();

		// @property (readonly, nonatomic) NSString * _Nonnull property __attribute__((deprecated("Use `-keyPath`")));
		[Export ("property")]
		string Property { get; }

		// +(instancetype _Nonnull)sortDescriptorWithProperty:(NSString * _Nonnull)propertyName ascending:(BOOL)ascending __attribute__((deprecated("Use `+sortDescriptorWithKeyPath:ascending:`")));
		[Static]
		[Export ("sortDescriptorWithProperty:ascending:")]
		RLMSortDescriptor SortDescriptorWithProperty (string propertyName, bool ascending);
	}

	// @interface RLMCollectionChange : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMCollectionChange
	{
		// @property (readonly, nonatomic) NSArray<NSNumber *> * _Nonnull deletions;
		[Export ("deletions")]
		NSNumber[] Deletions { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * _Nonnull insertions;
		[Export ("insertions")]
		NSNumber[] Insertions { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * _Nonnull modifications;
		[Export ("modifications")]
		NSNumber[] Modifications { get; }

		// -(NSArray<NSIndexPath *> * _Nonnull)deletionsInSection:(NSUInteger)section;
		[Export ("deletionsInSection:")]
		NSIndexPath[] DeletionsInSection (nuint section);

		// -(NSArray<NSIndexPath *> * _Nonnull)insertionsInSection:(NSUInteger)section;
		[Export ("insertionsInSection:")]
		NSIndexPath[] InsertionsInSection (nuint section);

		// -(NSArray<NSIndexPath *> * _Nonnull)modificationsInSection:(NSUInteger)section;
		[Export ("modificationsInSection:")]
		NSIndexPath[] ModificationsInSection (nuint section);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull RLMErrorDomain;
		[Field ("RLMErrorDomain", "__Internal")]
		NSString RLMErrorDomain { get; }

		// extern NSString *const _Nonnull RLMUnknownSystemErrorDomain;
		[Field ("RLMUnknownSystemErrorDomain", "__Internal")]
		NSString RLMUnknownSystemErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const RLMNotification _Nonnull RLMRealmRefreshRequiredNotification;
		[Field ("RLMRealmRefreshRequiredNotification", "__Internal")]
		NSString RLMRealmRefreshRequiredNotification { get; }

		// extern const RLMNotification _Nonnull RLMRealmDidChangeNotification;
		[Field ("RLMRealmDidChangeNotification", "__Internal")]
		NSString RLMRealmDidChangeNotification { get; }

		// extern const uint64_t RLMNotVersioned;
		[Field ("RLMNotVersioned", "__Internal")]
		ulong RLMNotVersioned { get; }

		// extern NSString *const _Nonnull RLMExceptionName;
		[Field ("RLMExceptionName", "__Internal")]
		NSString RLMExceptionName { get; }

		// extern NSString *const _Nonnull RLMRealmVersionKey;
		[Field ("RLMRealmVersionKey", "__Internal")]
		NSString RLMRealmVersionKey { get; }

		// extern NSString *const _Nonnull RLMRealmCoreVersionKey;
		[Field ("RLMRealmCoreVersionKey", "__Internal")]
		NSString RLMRealmCoreVersionKey { get; }

		// extern NSString *const _Nonnull RLMInvalidatedKey;
		[Field ("RLMInvalidatedKey", "__Internal")]
		NSString RLMInvalidatedKey { get; }
	}

	// typedef void (^RLMObjectMigrationBlock)(RLMObject * _Nullable, RLMObject * _Nullable);
	delegate void RLMObjectMigrationBlock ([NullAllowed] RLMObject arg0, [NullAllowed] RLMObject arg1);

	// @interface RLMMigration : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMMigration
	{
		// @property (readonly, nonatomic) RLMSchema * _Nonnull oldSchema;
		[Export ("oldSchema")]
		RLMSchema OldSchema { get; }

		// @property (readonly, nonatomic) RLMSchema * _Nonnull newSchema;
		[Export ("newSchema")]
		RLMSchema NewSchema { get; }

		// -(void)enumerateObjects:(NSString * _Nonnull)className block:(RLMObjectMigrationBlock _Nonnull)block;
		[Export ("enumerateObjects:block:")]
		void EnumerateObjects (string className, RLMObjectMigrationBlock block);

		// -(RLMObject * _Nonnull)createObject:(NSString * _Nonnull)className withValue:(id _Nonnull)value;
		[Export ("createObject:withValue:")]
		RLMObject CreateObject (string className, NSObject value);

		// -(void)deleteObject:(RLMObject * _Nonnull)object;
		[Export ("deleteObject:")]
		void DeleteObject (RLMObject @object);

		// -(BOOL)deleteDataForClassName:(NSString * _Nonnull)name;
		[Export ("deleteDataForClassName:")]
		bool DeleteDataForClassName (string name);

		// -(void)renamePropertyForClass:(NSString * _Nonnull)className oldName:(NSString * _Nonnull)oldName newName:(NSString * _Nonnull)newName;
		[Export ("renamePropertyForClass:oldName:newName:")]
		void RenamePropertyForClass (string className, string oldName, string newName);
	}

	// @interface RLMObject <RLMThreadConfined>
	interface RLMObject : IRLMThreadConfined
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject value);

		// +(NSString * _Nonnull)className;
		[Static]
		[Export ("className")]
		[Verify (MethodToProperty)]
		string ClassName { get; }

		// +(instancetype _Nonnull)createInDefaultRealmWithValue:(id _Nonnull)value;
		[Static]
		[Export ("createInDefaultRealmWithValue:")]
		RLMObject CreateInDefaultRealmWithValue (NSObject value);

		// +(instancetype _Nonnull)createInRealm:(RLMRealm * _Nonnull)realm withValue:(id _Nonnull)value;
		[Static]
		[Export ("createInRealm:withValue:")]
		RLMObject CreateInRealm (RLMRealm realm, NSObject value);

		// +(instancetype _Nonnull)createOrUpdateInDefaultRealmWithValue:(id _Nonnull)value;
		[Static]
		[Export ("createOrUpdateInDefaultRealmWithValue:")]
		RLMObject CreateOrUpdateInDefaultRealmWithValue (NSObject value);

		// +(instancetype _Nonnull)createOrUpdateInRealm:(RLMRealm * _Nonnull)realm withValue:(id _Nonnull)value;
		[Static]
		[Export ("createOrUpdateInRealm:withValue:")]
		RLMObject CreateOrUpdateInRealm (RLMRealm realm, NSObject value);

		// @property (readonly, nonatomic) RLMRealm * _Nullable realm;
		[NullAllowed, Export ("realm")]
		RLMRealm Realm { get; }

		// @property (readonly, nonatomic) RLMObjectSchema * _Nonnull objectSchema;
		[Export ("objectSchema")]
		RLMObjectSchema ObjectSchema { get; }

		// @property (readonly, getter = isInvalidated, nonatomic) BOOL invalidated;
		[Export ("invalidated")]
		bool Invalidated { [Bind ("isInvalidated")] get; }

		// +(NSArray<NSString *> * _Nonnull)indexedProperties;
		[Static]
		[Export ("indexedProperties")]
		[Verify (MethodToProperty)]
		string[] IndexedProperties { get; }

		// +(NSDictionary * _Nullable)defaultPropertyValues;
		[Static]
		[NullAllowed, Export ("defaultPropertyValues")]
		[Verify (MethodToProperty)]
		NSDictionary DefaultPropertyValues { get; }

		// +(NSString * _Nullable)primaryKey;
		[Static]
		[NullAllowed, Export ("primaryKey")]
		[Verify (MethodToProperty)]
		string PrimaryKey { get; }

		// +(NSArray<NSString *> * _Nullable)ignoredProperties;
		[Static]
		[NullAllowed, Export ("ignoredProperties")]
		[Verify (MethodToProperty)]
		string[] IgnoredProperties { get; }

		// +(NSArray<NSString *> * _Nonnull)requiredProperties;
		[Static]
		[Export ("requiredProperties")]
		[Verify (MethodToProperty)]
		string[] RequiredProperties { get; }

		// +(NSDictionary<NSString *,RLMPropertyDescriptor *> * _Nonnull)linkingObjectsProperties;
		[Static]
		[Export ("linkingObjectsProperties")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, RLMPropertyDescriptor> LinkingObjectsProperties { get; }

		// +(RLMResults * _Nonnull)allObjects;
		[Static]
		[Export ("allObjects")]
		[Verify (MethodToProperty)]
		RLMResults AllObjects { get; }

		// +(RLMResults * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Static, Internal]
		[Export ("objectsWhere:", IsVariadic = true)]
		RLMResults ObjectsWhere (string predicateFormat, IntPtr varArgs);

		// +(RLMResults * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Static]
		[Export ("objectsWhere:args:")]
		unsafe RLMResults ObjectsWhere (string predicateFormat, sbyte* args);

		// +(RLMResults * _Nonnull)objectsWithPredicate:(NSPredicate * _Nullable)predicate;
		[Static]
		[Export ("objectsWithPredicate:")]
		RLMResults ObjectsWithPredicate ([NullAllowed] NSPredicate predicate);

		// +(instancetype _Nullable)objectForPrimaryKey:(id _Nullable)primaryKey;
		[Static]
		[Export ("objectForPrimaryKey:")]
		[return: NullAllowed]
		RLMObject ObjectForPrimaryKey ([NullAllowed] NSObject primaryKey);

		// +(RLMResults * _Nonnull)allObjectsInRealm:(RLMRealm * _Nonnull)realm;
		[Static]
		[Export ("allObjectsInRealm:")]
		RLMResults AllObjectsInRealm (RLMRealm realm);

		// +(RLMResults * _Nonnull)objectsInRealm:(RLMRealm * _Nonnull)realm where:(NSString * _Nonnull)predicateFormat, ...;
		[Static, Internal]
		[Export ("objectsInRealm:where:", IsVariadic = true)]
		RLMResults ObjectsInRealm (RLMRealm realm, string predicateFormat, IntPtr varArgs);

		// +(RLMResults * _Nonnull)objectsInRealm:(RLMRealm * _Nonnull)realm where:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Static]
		[Export ("objectsInRealm:where:args:")]
		unsafe RLMResults ObjectsInRealm (RLMRealm realm, string predicateFormat, sbyte* args);

		// +(RLMResults * _Nonnull)objectsInRealm:(RLMRealm * _Nonnull)realm withPredicate:(NSPredicate * _Nullable)predicate;
		[Static]
		[Export ("objectsInRealm:withPredicate:")]
		RLMResults ObjectsInRealm (RLMRealm realm, [NullAllowed] NSPredicate predicate);

		// +(instancetype _Nullable)objectInRealm:(RLMRealm * _Nonnull)realm forPrimaryKey:(id _Nullable)primaryKey;
		[Static]
		[Export ("objectInRealm:forPrimaryKey:")]
		[return: NullAllowed]
		RLMObject ObjectInRealm (RLMRealm realm, [NullAllowed] NSObject primaryKey);

		// -(RLMNotificationToken * _Nonnull)addNotificationBlock:(RLMObjectChangeBlock _Nonnull)block;
		[Export ("addNotificationBlock:")]
		RLMNotificationToken AddNotificationBlock (RLMObjectChangeBlock block);

		// -(BOOL)isEqualToObject:(RLMObject * _Nonnull)object;
		[Export ("isEqualToObject:")]
		bool IsEqualToObject (RLMObject @object);

		// -(id _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		NSObject ObjectForKeyedSubscript (string key);

		// -(void)setObject:(id _Nullable)obj forKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("setObject:forKeyedSubscript:")]
		void SetObject ([NullAllowed] NSObject obj, string key);
	}

	// typedef void (^RLMObjectChangeBlock)(BOOL, NSArray<RLMPropertyChange *> * _Nullable, NSError * _Nullable);
	delegate void RLMObjectChangeBlock (bool arg0, [NullAllowed] RLMPropertyChange[] arg1, [NullAllowed] NSError arg2);

	// @interface RLMPropertyChange : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMPropertyChange
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) id _Nullable previousValue;
		[NullAllowed, Export ("previousValue", ArgumentSemantic.Strong)]
		NSObject PreviousValue { get; }

		// @property (readonly, nonatomic, strong) id _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; }
	}

	// @interface RLMObjectBase : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMObjectBase
	{
		// @property (readonly, getter = isInvalidated, nonatomic) BOOL invalidated;
		[Export ("invalidated")]
		bool Invalidated { [Bind ("isInvalidated")] get; }

		// +(NSString * _Nonnull)className;
		[Static]
		[Export ("className")]
		[Verify (MethodToProperty)]
		string ClassName { get; }

		// +(BOOL)shouldIncludeInDefaultSchema;
		[Static]
		[Export ("shouldIncludeInDefaultSchema")]
		[Verify (MethodToProperty)]
		bool ShouldIncludeInDefaultSchema { get; }

		// +(NSString * _Nullable)_realmObjectName;
		[Static]
		[NullAllowed, Export ("_realmObjectName")]
		[Verify (MethodToProperty)]
		string _realmObjectName { get; }
	}

	// @interface RLMObjectSchema : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface RLMObjectSchema : INSCopying
	{
		// @property (readonly, copy, nonatomic) NSArray<RLMProperty *> * _Nonnull properties;
		[Export ("properties", ArgumentSemantic.Copy)]
		RLMProperty[] Properties { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull className;
		[Export ("className")]
		string ClassName { get; }

		// @property (readonly, nonatomic) RLMProperty * _Nullable primaryKeyProperty;
		[NullAllowed, Export ("primaryKeyProperty")]
		RLMProperty PrimaryKeyProperty { get; }

		// -(RLMProperty * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)propertyName;
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RLMProperty ObjectForKeyedSubscript (string propertyName);

		// -(BOOL)isEqualToObjectSchema:(RLMObjectSchema * _Nonnull)objectSchema;
		[Export ("isEqualToObjectSchema:")]
		bool IsEqualToObjectSchema (RLMObjectSchema objectSchema);
	}

	// @protocol RLMInt
	[Protocol, Model]
	interface RLMInt
	{
	}

	// @protocol RLMBool
	[Protocol, Model]
	interface RLMBool
	{
	}

	// @protocol RLMDouble
	[Protocol, Model]
	interface RLMDouble
	{
	}

	// @protocol RLMFloat
	[Protocol, Model]
	interface RLMFloat
	{
	}

	// @interface  (NSNumber) <RLMInt, RLMBool, RLMDouble, RLMFloat>
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_ : IRLMInt, IRLMBool, IRLMDouble, IRLMFloat
	{
	}

	// @interface RLMProperty : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMProperty
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) RLMPropertyType type;
		[Export ("type")]
		RLMPropertyType Type { get; }

		// @property (readonly, nonatomic) BOOL indexed;
		[Export ("indexed")]
		bool Indexed { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable objectClassName;
		[NullAllowed, Export ("objectClassName")]
		string ObjectClassName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable linkOriginPropertyName;
		[NullAllowed, Export ("linkOriginPropertyName")]
		string LinkOriginPropertyName { get; }

		// @property (readonly, nonatomic) BOOL optional;
		[Export ("optional")]
		bool Optional { get; }

		// -(BOOL)isEqualToProperty:(RLMProperty * _Nonnull)property;
		[Export ("isEqualToProperty:")]
		bool IsEqualToProperty (RLMProperty property);
	}

	// @interface RLMPropertyDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMPropertyDescriptor
	{
		// +(instancetype _Nonnull)descriptorWithClass:(Class _Nonnull)objectClass propertyName:(NSString * _Nonnull)propertyName;
		[Static]
		[Export ("descriptorWithClass:propertyName:")]
		RLMPropertyDescriptor DescriptorWithClass (Class objectClass, string propertyName);

		// @property (readonly, nonatomic) Class _Nonnull objectClass;
		[Export ("objectClass")]
		Class ObjectClass { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull propertyName;
		[Export ("propertyName")]
		string PropertyName { get; }
	}

	// typedef void (^RLMAsyncOpenRealmCallback)(RLMRealm * _Nullable, NSError * _Nullable);
	delegate void RLMAsyncOpenRealmCallback ([NullAllowed] RLMRealm arg0, [NullAllowed] NSError arg1);

	// @interface RLMRealm : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMRealm
	{
		// +(instancetype _Nonnull)defaultRealm;
		[Static]
		[Export ("defaultRealm")]
		RLMRealm DefaultRealm ();

		// +(instancetype _Nullable)realmWithConfiguration:(RLMRealmConfiguration * _Nonnull)configuration error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("realmWithConfiguration:error:")]
		[return: NullAllowed]
		RLMRealm RealmWithConfiguration (RLMRealmConfiguration configuration, [NullAllowed] out NSError error);

		// +(instancetype _Nonnull)realmWithURL:(NSURL * _Nonnull)fileURL;
		[Static]
		[Export ("realmWithURL:")]
		RLMRealm RealmWithURL (NSUrl fileURL);

		// +(void)asyncOpenWithConfiguration:(RLMRealmConfiguration * _Nonnull)configuration callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue callback:(RLMAsyncOpenRealmCallback _Nonnull)callback;
		[Static]
		[Export ("asyncOpenWithConfiguration:callbackQueue:callback:")]
		void AsyncOpenWithConfiguration (RLMRealmConfiguration configuration, DispatchQueue callbackQueue, RLMAsyncOpenRealmCallback callback);

		// @property (readonly, nonatomic) RLMSchema * _Nonnull schema;
		[Export ("schema")]
		RLMSchema Schema { get; }

		// @property (readonly, nonatomic) BOOL inWriteTransaction;
		[Export ("inWriteTransaction")]
		bool InWriteTransaction { get; }

		// @property (readonly, nonatomic) RLMRealmConfiguration * _Nonnull configuration;
		[Export ("configuration")]
		RLMRealmConfiguration Configuration { get; }

		// @property (readonly, nonatomic) BOOL isEmpty;
		[Export ("isEmpty")]
		bool IsEmpty { get; }

		// -(RLMNotificationToken * _Nonnull)addNotificationBlock:(RLMNotificationBlock _Nonnull)block __attribute__((warn_unused_result));
		[Export ("addNotificationBlock:")]
		RLMNotificationToken AddNotificationBlock (RLMNotificationBlock block);

		// -(void)beginWriteTransaction;
		[Export ("beginWriteTransaction")]
		void BeginWriteTransaction ();

		// -(void)commitWriteTransaction;
		[Export ("commitWriteTransaction")]
		void CommitWriteTransaction ();

		// -(BOOL)commitWriteTransaction:(NSError * _Nullable * _Nullable)error;
		[Export ("commitWriteTransaction:")]
		bool CommitWriteTransaction ([NullAllowed] out NSError error);

		// -(BOOL)commitWriteTransactionWithoutNotifying:(NSArray<RLMNotificationToken *> * _Nonnull)tokens error:(NSError * _Nullable * _Nullable)error;
		[Export ("commitWriteTransactionWithoutNotifying:error:")]
		bool CommitWriteTransactionWithoutNotifying (RLMNotificationToken[] tokens, [NullAllowed] out NSError error);

		// -(void)cancelWriteTransaction;
		[Export ("cancelWriteTransaction")]
		void CancelWriteTransaction ();

		// -(void)transactionWithBlock:(void (^ _Nonnull)(void))block;
		[Export ("transactionWithBlock:")]
		void TransactionWithBlock (Action block);

		// -(BOOL)transactionWithBlock:(void (^ _Nonnull)(void))block error:(NSError * _Nullable * _Nullable)error;
		[Export ("transactionWithBlock:error:")]
		bool TransactionWithBlock (Action block, [NullAllowed] out NSError error);

		// -(BOOL)refresh;
		[Export ("refresh")]
		[Verify (MethodToProperty)]
		bool Refresh { get; }

		// @property (nonatomic) BOOL autorefresh;
		[Export ("autorefresh")]
		bool Autorefresh { get; set; }

		// -(BOOL)writeCopyToURL:(NSURL * _Nonnull)fileURL encryptionKey:(NSData * _Nullable)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("writeCopyToURL:encryptionKey:error:")]
		bool WriteCopyToURL (NSUrl fileURL, [NullAllowed] NSData key, [NullAllowed] out NSError error);

		// -(void)invalidate;
		[Export ("invalidate")]
		void Invalidate ();

		// -(id _Nullable)resolveThreadSafeReference:(RLMThreadSafeReference * _Nonnull)reference;
		[Export ("resolveThreadSafeReference:")]
		[return: NullAllowed]
		NSObject ResolveThreadSafeReference (RLMThreadSafeReference reference);

		// -(void)addObject:(RLMObject * _Nonnull)object;
		[Export ("addObject:")]
		void AddObject (RLMObject @object);

		// -(void)addObjects:(id<NSFastEnumeration> _Nonnull)array;
		[Export ("addObjects:")]
		void AddObjects (NSFastEnumeration array);

		// -(void)addOrUpdateObject:(RLMObject * _Nonnull)object;
		[Export ("addOrUpdateObject:")]
		void AddOrUpdateObject (RLMObject @object);

		// -(void)addOrUpdateObjectsFromArray:(id _Nonnull)array;
		[Export ("addOrUpdateObjectsFromArray:")]
		void AddOrUpdateObjectsFromArray (NSObject array);

		// -(void)deleteObject:(RLMObject * _Nonnull)object;
		[Export ("deleteObject:")]
		void DeleteObject (RLMObject @object);

		// -(void)deleteObjects:(id _Nonnull)array;
		[Export ("deleteObjects:")]
		void DeleteObjects (NSObject array);

		// -(void)deleteAllObjects;
		[Export ("deleteAllObjects")]
		void DeleteAllObjects ();

		// +(uint64_t)schemaVersionAtURL:(NSURL * _Nonnull)fileURL encryptionKey:(NSData * _Nullable)key error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("schemaVersionAtURL:encryptionKey:error:")]
		ulong SchemaVersionAtURL (NSUrl fileURL, [NullAllowed] NSData key, [NullAllowed] out NSError error);

		// +(NSError * _Nullable)migrateRealm:(RLMRealmConfiguration * _Nonnull)configuration __attribute__((deprecated("Use `performMigrationForConfiguration:error:`")));
		[Static]
		[Export ("migrateRealm:")]
		[return: NullAllowed]
		NSError MigrateRealm (RLMRealmConfiguration configuration);

		// +(BOOL)performMigrationForConfiguration:(RLMRealmConfiguration * _Nonnull)configuration error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("performMigrationForConfiguration:error:")]
		bool PerformMigrationForConfiguration (RLMRealmConfiguration configuration, [NullAllowed] out NSError error);
	}

	// typedef void (^RLMNotificationBlock)(RLMNotification _Nonnull, RLMRealm * _Nonnull);
	delegate void RLMNotificationBlock (string arg0, RLMRealm arg1);

	// typedef void (^RLMMigrationBlock)(RLMMigration * _Nonnull, uint64_t);
	delegate void RLMMigrationBlock (RLMMigration arg0, ulong arg1);

	// @interface RLMNotificationToken : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMNotificationToken
	{
		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kRLMSyncPathOfRealmBackupCopyKey;
		[Field ("kRLMSyncPathOfRealmBackupCopyKey", "__Internal")]
		NSString kRLMSyncPathOfRealmBackupCopyKey { get; }

		// extern NSString *const _Nonnull kRLMSyncInitiateClientResetBlockKey;
		[Field ("kRLMSyncInitiateClientResetBlockKey", "__Internal")]
		NSString kRLMSyncInitiateClientResetBlockKey { get; }

		// extern NSString *const _Nonnull RLMSyncErrorDomain;
		[Field ("RLMSyncErrorDomain", "__Internal")]
		NSString RLMSyncErrorDomain { get; }

		// extern NSString *const _Nonnull RLMSyncAuthErrorDomain;
		[Field ("RLMSyncAuthErrorDomain", "__Internal")]
		NSString RLMSyncAuthErrorDomain { get; }

		// extern NSString *const _Nonnull RLMSyncPermissionErrorDomain;
		[Field ("RLMSyncPermissionErrorDomain", "__Internal")]
		NSString RLMSyncPermissionErrorDomain { get; }
	}

	// @interface Sync (RLMRealmConfiguration)
	[Category]
	[BaseType (typeof(RLMRealmConfiguration))]
	interface RLMRealmConfiguration_Sync
	{
		// @property (nonatomic) RLMSyncConfiguration * _Nullable syncConfiguration;
		[NullAllowed, Export ("syncConfiguration", ArgumentSemantic.Assign)]
		RLMSyncConfiguration SyncConfiguration { }
	}

	// typedef BOOL (^RLMShouldCompactOnLaunchBlock)(NSUInteger, NSUInteger);
	delegate bool RLMShouldCompactOnLaunchBlock (nuint arg0, nuint arg1);

	// @interface RLMRealmConfiguration : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface RLMRealmConfiguration : INSCopying
	{
		// +(instancetype _Nonnull)defaultConfiguration;
		[Static]
		[Export ("defaultConfiguration")]
		RLMRealmConfiguration DefaultConfiguration ();

		// +(void)setDefaultConfiguration:(RLMRealmConfiguration * _Nonnull)configuration;
		[Static]
		[Export ("setDefaultConfiguration:")]
		void SetDefaultConfiguration (RLMRealmConfiguration configuration);

		// @property (copy, nonatomic) NSURL * _Nullable fileURL;
		[NullAllowed, Export ("fileURL", ArgumentSemantic.Copy)]
		NSUrl FileURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable inMemoryIdentifier;
		[NullAllowed, Export ("inMemoryIdentifier")]
		string InMemoryIdentifier { get; set; }

		// @property (copy, nonatomic) NSData * _Nullable encryptionKey;
		[NullAllowed, Export ("encryptionKey", ArgumentSemantic.Copy)]
		NSData EncryptionKey { get; set; }

		// @property (nonatomic) BOOL readOnly;
		[Export ("readOnly")]
		bool ReadOnly { get; set; }

		// @property (nonatomic) uint64_t schemaVersion;
		[Export ("schemaVersion")]
		ulong SchemaVersion { get; set; }

		// @property (copy, nonatomic) RLMMigrationBlock _Nullable migrationBlock;
		[NullAllowed, Export ("migrationBlock", ArgumentSemantic.Copy)]
		RLMMigrationBlock MigrationBlock { get; set; }

		// @property (nonatomic) BOOL deleteRealmIfMigrationNeeded;
		[Export ("deleteRealmIfMigrationNeeded")]
		bool DeleteRealmIfMigrationNeeded { get; set; }

		// @property (copy, nonatomic) RLMShouldCompactOnLaunchBlock _Nullable shouldCompactOnLaunch;
		[NullAllowed, Export ("shouldCompactOnLaunch", ArgumentSemantic.Copy)]
		RLMShouldCompactOnLaunchBlock ShouldCompactOnLaunch { get; set; }

		// @property (copy, nonatomic) NSArray * _Nullable objectClasses;
		[NullAllowed, Export ("objectClasses", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ObjectClasses { get; set; }
	}

	// @interface Dynamic (RLMRealm)
	[Category]
	[BaseType (typeof(RLMRealm))]
	interface RLMRealm_Dynamic
	{
		// -(RLMResults * _Nonnull)allObjects:(NSString * _Nonnull)className;
		[Export ("allObjects:")]
		RLMResults AllObjects (string className);

		// -(RLMResults * _Nonnull)objects:(NSString * _Nonnull)className where:(NSString * _Nonnull)predicateFormat, ...;
		[Internal]
		[Export ("objects:where:", IsVariadic = true)]
		RLMResults Objects (string className, string predicateFormat, IntPtr varArgs);

		// -(RLMResults * _Nonnull)objects:(NSString * _Nonnull)className withPredicate:(NSPredicate * _Nonnull)predicate;
		[Export ("objects:withPredicate:")]
		RLMResults Objects (string className, NSPredicate predicate);

		// -(RLMObject * _Nullable)objectWithClassName:(NSString * _Nonnull)className forPrimaryKey:(id _Nonnull)primaryKey;
		[Export ("objectWithClassName:forPrimaryKey:")]
		[return: NullAllowed]
		RLMObject ObjectWithClassName (string className, NSObject primaryKey);

		// -(RLMObject * _Nonnull)createObject:(NSString * _Nonnull)className withValue:(id _Nonnull)value;
		[Export ("createObject:withValue:")]
		RLMObject CreateObject (string className, NSObject value);
	}

	// audit-objc-generics: @interface RLMResults<RLMObjectType : RLMObject *> : NSObject <RLMCollection, NSFastEnumeration>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMResults : IRLMCollection, INSFastEnumeration
	{
		// @property (readonly, assign, nonatomic) NSUInteger count;
		[Export ("count")]
		nuint Count { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull objectClassName;
		[Export ("objectClassName")]
		string ObjectClassName { get; }

		// @property (readonly, nonatomic) RLMRealm * _Nonnull realm;
		[Export ("realm")]
		RLMRealm Realm { get; }

		// @property (readonly, getter = isInvalidated, nonatomic) BOOL invalidated;
		[Export ("invalidated")]
		bool Invalidated { [Bind ("isInvalidated")] get; }

		// -(RLMObjectType _Nonnull)objectAtIndex:(NSUInteger)index;
		[Export ("objectAtIndex:")]
		RLMObject ObjectAtIndex (nuint index);

		// -(RLMObjectType _Nullable)firstObject;
		[NullAllowed, Export ("firstObject")]
		[Verify (MethodToProperty)]
		RLMObject FirstObject { get; }

		// -(RLMObjectType _Nullable)lastObject;
		[NullAllowed, Export ("lastObject")]
		[Verify (MethodToProperty)]
		RLMObject LastObject { get; }

		// -(NSUInteger)indexOfObject:(RLMObjectType _Nonnull)object;
		[Export ("indexOfObject:")]
		nuint IndexOfObject (RLMObject @object);

		// -(NSUInteger)indexOfObjectWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Internal]
		[Export ("indexOfObjectWhere:", IsVariadic = true)]
		nuint IndexOfObjectWhere (string predicateFormat, IntPtr varArgs);

		// -(NSUInteger)indexOfObjectWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Export ("indexOfObjectWhere:args:")]
		unsafe nuint IndexOfObjectWhere (string predicateFormat, sbyte* args);

		// -(NSUInteger)indexOfObjectWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Export ("indexOfObjectWithPredicate:")]
		nuint IndexOfObjectWithPredicate (NSPredicate predicate);

		// -(RLMResults<RLMObjectType> * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat, ...;
		[Internal]
		[Export ("objectsWhere:", IsVariadic = true)]
		RLMResults<RLMObject> ObjectsWhere (string predicateFormat, IntPtr varArgs);

		// -(RLMResults<RLMObjectType> * _Nonnull)objectsWhere:(NSString * _Nonnull)predicateFormat args:(va_list _Nonnull)args;
		[Export ("objectsWhere:args:")]
		unsafe RLMResults<RLMObject> ObjectsWhere (string predicateFormat, sbyte* args);

		// -(RLMResults<RLMObjectType> * _Nonnull)objectsWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Export ("objectsWithPredicate:")]
		RLMResults<RLMObject> ObjectsWithPredicate (NSPredicate predicate);

		// -(RLMResults<RLMObjectType> * _Nonnull)sortedResultsUsingKeyPath:(NSString * _Nonnull)keyPath ascending:(BOOL)ascending;
		[Export ("sortedResultsUsingKeyPath:ascending:")]
		RLMResults<RLMObject> SortedResultsUsingKeyPath (string keyPath, bool ascending);

		// -(RLMResults<RLMObjectType> * _Nonnull)sortedResultsUsingProperty:(NSString * _Nonnull)property ascending:(BOOL)ascending __attribute__((deprecated("Use `-sortedResultsUsingKeyPath:ascending:`")));
		[Export ("sortedResultsUsingProperty:ascending:")]
		RLMResults<RLMObject> SortedResultsUsingProperty (string property, bool ascending);

		// -(RLMResults<RLMObjectType> * _Nonnull)sortedResultsUsingDescriptors:(NSArray<RLMSortDescriptor *> * _Nonnull)properties;
		[Export ("sortedResultsUsingDescriptors:")]
		RLMResults<RLMObject> SortedResultsUsingDescriptors (RLMSortDescriptor[] properties);

		// -(RLMNotificationToken * _Nonnull)addNotificationBlock:(void (^ _Nonnull)(RLMResults<RLMObjectType> * _Nullable, RLMCollectionChange * _Nullable, NSError * _Nullable))block __attribute__((warn_unused_result));
		[Export ("addNotificationBlock:")]
		RLMNotificationToken AddNotificationBlock (Action<RLMResults<RLMObject>, RLMCollectionChange, NSError> block);

		// -(id _Nullable)minOfProperty:(NSString * _Nonnull)property;
		[Export ("minOfProperty:")]
		[return: NullAllowed]
		NSObject MinOfProperty (string property);

		// -(id _Nullable)maxOfProperty:(NSString * _Nonnull)property;
		[Export ("maxOfProperty:")]
		[return: NullAllowed]
		NSObject MaxOfProperty (string property);

		// -(NSNumber * _Nonnull)sumOfProperty:(NSString * _Nonnull)property;
		[Export ("sumOfProperty:")]
		NSNumber SumOfProperty (string property);

		// -(NSNumber * _Nullable)averageOfProperty:(NSString * _Nonnull)property;
		[Export ("averageOfProperty:")]
		[return: NullAllowed]
		NSNumber AverageOfProperty (string property);

		// -(RLMObjectType _Nonnull)objectAtIndexedSubscript:(NSUInteger)index;
		[Export ("objectAtIndexedSubscript:")]
		RLMObject ObjectAtIndexedSubscript (nuint index);
	}

	// audit-objc-generics: @interface RLMLinkingObjects<RLMObjectType : RLMObject *> : RLMResults
	[BaseType (typeof(RLMResults))]
	interface RLMLinkingObjects
	{
	}

	// @interface RLMSchema : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface RLMSchema : INSCopying
	{
		// @property (readonly, copy, nonatomic) NSArray<RLMObjectSchema *> * _Nonnull objectSchema;
		[Export ("objectSchema", ArgumentSemantic.Copy)]
		RLMObjectSchema[] ObjectSchema { get; }

		// -(RLMObjectSchema * _Nullable)schemaForClassName:(NSString * _Nonnull)className;
		[Export ("schemaForClassName:")]
		[return: NullAllowed]
		RLMObjectSchema SchemaForClassName (string className);

		// -(RLMObjectSchema * _Nonnull)objectForKeyedSubscript:(NSString * _Nonnull)className;
		[Export ("objectForKeyedSubscript:")]
		RLMObjectSchema ObjectForKeyedSubscript (string className);

		// -(BOOL)isEqualToSchema:(RLMSchema * _Nonnull)schema;
		[Export ("isEqualToSchema:")]
		bool IsEqualToSchema (RLMSchema schema);
	}

	// @interface RLMSyncConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMSyncConfiguration
	{
		// @property (readonly, nonatomic) RLMSyncUser * _Nonnull user;
		[Export ("user")]
		RLMSyncUser User { get; }

		// @property (readonly, nonatomic) NSURL * _Nonnull realmURL;
		[Export ("realmURL")]
		NSUrl RealmURL { get; }

		// @property (nonatomic) BOOL enableSSLValidation;
		[Export ("enableSSLValidation")]
		bool EnableSSLValidation { get; set; }

		// -(instancetype _Nonnull)initWithUser:(RLMSyncUser * _Nonnull)user realmURL:(NSURL * _Nonnull)url;
		[Export ("initWithUser:realmURL:")]
		IntPtr Constructor (RLMSyncUser user, NSUrl url);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const RLMIdentityProvider _Nonnull RLMIdentityProviderDebug;
		[Field ("RLMIdentityProviderDebug", "__Internal")]
		NSString RLMIdentityProviderDebug { get; }

		// extern const RLMIdentityProvider _Nonnull RLMIdentityProviderUsernamePassword;
		[Field ("RLMIdentityProviderUsernamePassword", "__Internal")]
		NSString RLMIdentityProviderUsernamePassword { get; }

		// extern const RLMIdentityProvider _Nonnull RLMIdentityProviderFacebook;
		[Field ("RLMIdentityProviderFacebook", "__Internal")]
		NSString RLMIdentityProviderFacebook { get; }

		// extern const RLMIdentityProvider _Nonnull RLMIdentityProviderGoogle;
		[Field ("RLMIdentityProviderGoogle", "__Internal")]
		NSString RLMIdentityProviderGoogle { get; }

		// extern const RLMIdentityProvider _Nonnull RLMIdentityProviderCloudKit;
		[Field ("RLMIdentityProviderCloudKit", "__Internal")]
		NSString RLMIdentityProviderCloudKit { get; }
	}

	// @interface RLMSyncCredentials : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMSyncCredentials
	{
		// @property (readonly, nonatomic) RLMSyncCredentialsToken _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly, nonatomic) RLMIdentityProvider _Nonnull provider;
		[Export ("provider")]
		string Provider { get; }

		// @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull userInfo;
		[Export ("userInfo")]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// +(instancetype _Nonnull)credentialsWithFacebookToken:(RLMSyncCredentialsToken _Nonnull)token;
		[Static]
		[Export ("credentialsWithFacebookToken:")]
		RLMSyncCredentials CredentialsWithFacebookToken (string token);

		// +(instancetype _Nonnull)credentialsWithGoogleToken:(RLMSyncCredentialsToken _Nonnull)token;
		[Static]
		[Export ("credentialsWithGoogleToken:")]
		RLMSyncCredentials CredentialsWithGoogleToken (string token);

		// +(instancetype _Nonnull)credentialsWithCloudKitToken:(RLMSyncCredentialsToken _Nonnull)token;
		[Static]
		[Export ("credentialsWithCloudKitToken:")]
		RLMSyncCredentials CredentialsWithCloudKitToken (string token);

		// +(instancetype _Nonnull)credentialsWithUsername:(NSString * _Nonnull)username password:(NSString * _Nonnull)password register:(BOOL)shouldRegister;
		[Static]
		[Export ("credentialsWithUsername:password:register:")]
		RLMSyncCredentials CredentialsWithUsername (string username, string password, bool shouldRegister);

		// +(instancetype _Nonnull)credentialsWithAccessToken:(RLMServerToken _Nonnull)accessToken identity:(NSString * _Nonnull)identity;
		[Static]
		[Export ("credentialsWithAccessToken:identity:")]
		RLMSyncCredentials CredentialsWithAccessToken (string accessToken, string identity);

		// -(instancetype _Nonnull)initWithCustomToken:(RLMSyncCredentialsToken _Nonnull)token provider:(RLMIdentityProvider _Nonnull)provider userInfo:(NSDictionary * _Nullable)userInfo __attribute__((objc_designated_initializer));
		[Export ("initWithCustomToken:provider:userInfo:")]
		[DesignatedInitializer]
		IntPtr Constructor (string token, string provider, [NullAllowed] NSDictionary userInfo);
	}

	// typedef void (^RLMSyncErrorReportingBlock)(NSError * _Nonnull, RLMSyncSession * _Nullable);
	delegate void RLMSyncErrorReportingBlock (NSError arg0, [NullAllowed] RLMSyncSession arg1);

	// @interface RLMSyncManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMSyncManager
	{
		// @property (copy, nonatomic) RLMSyncErrorReportingBlock _Nullable errorHandler;
		[NullAllowed, Export ("errorHandler", ArgumentSemantic.Copy)]
		RLMSyncErrorReportingBlock ErrorHandler { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull appID;
		[Export ("appID")]
		string AppID { get; set; }

		// @property (nonatomic) BOOL disableSSLValidation __attribute__((deprecated("Set `enableSSLValidation` on individual configurations instead.")));
		[Export ("disableSSLValidation")]
		bool DisableSSLValidation { get; set; }

		// @property (nonatomic) RLMSyncLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		RLMSyncLogLevel LogLevel { get; set; }

		// +(instancetype _Nonnull)sharedManager;
		[Static]
		[Export ("sharedManager")]
		RLMSyncManager SharedManager ();
	}

	// @interface RLMSyncPermission : RLMObject
	[BaseType (typeof(RLMObject))]
	interface RLMSyncPermission
	{
		// @property (readonly) NSDate * _Nonnull updatedAt;
		[Export ("updatedAt")]
		NSDate UpdatedAt { get; }

		// @property (readonly) NSString * _Nonnull userId;
		[Export ("userId")]
		string UserId { get; }

		// @property (readonly) NSString * _Nonnull path;
		[Export ("path")]
		string Path { get; }

		// @property (readonly) BOOL mayRead;
		[Export ("mayRead")]
		bool MayRead { get; }

		// @property (readonly) BOOL mayWrite;
		[Export ("mayWrite")]
		bool MayWrite { get; }

		// @property (readonly) BOOL mayManage;
		[Export ("mayManage")]
		bool MayManage { get; }
	}

	// @interface RLMSyncPermissionChange : RLMObject
	[BaseType (typeof(RLMObject))]
	interface RLMSyncPermissionChange
	{
		// @property (readonly) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly) NSDate * _Nonnull createdAt;
		[Export ("createdAt")]
		NSDate CreatedAt { get; }

		// @property (readonly) NSDate * _Nonnull updatedAt;
		[Export ("updatedAt")]
		NSDate UpdatedAt { get; }

		// @property (readonly) NSNumber<RLMInt> * _Nullable statusCode;
		[NullAllowed, Export ("statusCode")]
		RLMInt StatusCode { get; }

		// @property (readonly) NSString * _Nullable statusMessage;
		[NullAllowed, Export ("statusMessage")]
		string StatusMessage { get; }

		// @property (readonly) RLMSyncManagementObjectStatus status;
		[Export ("status")]
		RLMSyncManagementObjectStatus Status { get; }

		// @property (readonly) NSString * _Nonnull realmUrl;
		[Export ("realmUrl")]
		string RealmUrl { get; }

		// @property (readonly) NSString * _Nonnull userId;
		[Export ("userId")]
		string UserId { get; }

		// @property (readonly) NSNumber<RLMBool> * _Nullable mayRead;
		[NullAllowed, Export ("mayRead")]
		RLMBool MayRead { get; }

		// @property (readonly) NSNumber<RLMBool> * _Nullable mayWrite;
		[NullAllowed, Export ("mayWrite")]
		RLMBool MayWrite { get; }

		// @property (readonly) NSNumber<RLMBool> * _Nullable mayManage;
		[NullAllowed, Export ("mayManage")]
		RLMBool MayManage { get; }

		// +(instancetype _Nonnull)permissionChangeWithRealmURL:(NSString * _Nonnull)realmURL userID:(NSString * _Nonnull)userID read:(NSNumber<RLMBool> * _Nullable)mayRead write:(NSNumber<RLMBool> * _Nullable)mayWrite manage:(NSNumber<RLMBool> * _Nullable)mayManage;
		[Static]
		[Export ("permissionChangeWithRealmURL:userID:read:write:manage:")]
		RLMSyncPermissionChange PermissionChangeWithRealmURL (string realmURL, string userID, [NullAllowed] RLMBool mayRead, [NullAllowed] RLMBool mayWrite, [NullAllowed] RLMBool mayManage);
	}

	// @interface RLMSyncPermissionOffer : RLMObject
	[BaseType (typeof(RLMObject))]
	interface RLMSyncPermissionOffer
	{
		// @property (readonly) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly) NSDate * _Nonnull createdAt;
		[Export ("createdAt")]
		NSDate CreatedAt { get; }

		// @property (readonly) NSDate * _Nonnull updatedAt;
		[Export ("updatedAt")]
		NSDate UpdatedAt { get; }

		// @property (readonly) NSNumber<RLMInt> * _Nullable statusCode;
		[NullAllowed, Export ("statusCode")]
		RLMInt StatusCode { get; }

		// @property (readonly) NSString * _Nullable statusMessage;
		[NullAllowed, Export ("statusMessage")]
		string StatusMessage { get; }

		// @property (readonly) RLMSyncManagementObjectStatus status;
		[Export ("status")]
		RLMSyncManagementObjectStatus Status { get; }

		// @property (readonly) NSString * _Nullable token;
		[NullAllowed, Export ("token")]
		string Token { get; }

		// @property (readonly) NSString * _Nonnull realmUrl;
		[Export ("realmUrl")]
		string RealmUrl { get; }

		// @property (readonly) BOOL mayRead;
		[Export ("mayRead")]
		bool MayRead { get; }

		// @property (readonly) BOOL mayWrite;
		[Export ("mayWrite")]
		bool MayWrite { get; }

		// @property (readonly) BOOL mayManage;
		[Export ("mayManage")]
		bool MayManage { get; }

		// @property (readonly) NSDate * _Nullable expiresAt;
		[NullAllowed, Export ("expiresAt")]
		NSDate ExpiresAt { get; }

		// +(instancetype _Nonnull)permissionOfferWithRealmURL:(NSString * _Nonnull)realmURL expiresAt:(NSDate * _Nullable)expiresAt read:(BOOL)mayRead write:(BOOL)mayWrite manage:(BOOL)mayManage;
		[Static]
		[Export ("permissionOfferWithRealmURL:expiresAt:read:write:manage:")]
		RLMSyncPermissionOffer PermissionOfferWithRealmURL (string realmURL, [NullAllowed] NSDate expiresAt, bool mayRead, bool mayWrite, bool mayManage);
	}

	// @interface RLMSyncPermissionOfferResponse : RLMObject
	[BaseType (typeof(RLMObject))]
	interface RLMSyncPermissionOfferResponse
	{
		// @property (readonly) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly) NSDate * _Nonnull createdAt;
		[Export ("createdAt")]
		NSDate CreatedAt { get; }

		// @property (readonly) NSDate * _Nonnull updatedAt;
		[Export ("updatedAt")]
		NSDate UpdatedAt { get; }

		// @property (readonly) NSNumber<RLMInt> * _Nullable statusCode;
		[NullAllowed, Export ("statusCode")]
		RLMInt StatusCode { get; }

		// @property (readonly) NSString * _Nullable statusMessage;
		[NullAllowed, Export ("statusMessage")]
		string StatusMessage { get; }

		// @property (readonly) RLMSyncManagementObjectStatus status;
		[Export ("status")]
		RLMSyncManagementObjectStatus Status { get; }

		// @property (readonly) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly) NSString * _Nullable realmUrl;
		[NullAllowed, Export ("realmUrl")]
		string RealmUrl { get; }

		// +(instancetype _Nonnull)permissionOfferResponseWithToken:(NSString * _Nonnull)token;
		[Static]
		[Export ("permissionOfferResponseWithToken:")]
		RLMSyncPermissionOfferResponse PermissionOfferResponseWithToken (string token);
	}

	// typedef void (^RLMUserCompletionBlock)(RLMSyncUser * _Nullable, NSError * _Nullable);
	delegate void RLMUserCompletionBlock ([NullAllowed] RLMSyncUser arg0, [NullAllowed] NSError arg1);

	// typedef void (^RLMPasswordChangeStatusBlock)(NSError * _Nullable);
	delegate void RLMPasswordChangeStatusBlock ([NullAllowed] NSError arg0);

	// typedef void (^RLMPermissionStatusBlock)(NSError * _Nullable);
	delegate void RLMPermissionStatusBlock ([NullAllowed] NSError arg0);

	// typedef void (^RLMPermissionResultsBlock)(RLMSyncPermissionResults * _Nullable, NSError * _Nullable);
	delegate void RLMPermissionResultsBlock ([NullAllowed] RLMSyncPermissionResults arg0, [NullAllowed] NSError arg1);

	// @interface RLMSyncUser : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMSyncUser
	{
		// +(NSDictionary<NSString *,RLMSyncUser *> * _Nonnull)allUsers;
		[Static]
		[Export ("allUsers")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, RLMSyncUser> AllUsers { get; }

		// +(RLMSyncUser * _Nullable)currentUser;
		[Static]
		[NullAllowed, Export ("currentUser")]
		[Verify (MethodToProperty)]
		RLMSyncUser CurrentUser { get; }

		// @property (readonly, nonatomic) NSString * _Nullable identity;
		[NullAllowed, Export ("identity")]
		string Identity { get; }

		// @property (readonly, nonatomic) NSURL * _Nullable authenticationServer;
		[NullAllowed, Export ("authenticationServer")]
		NSUrl AuthenticationServer { get; }

		// @property (readonly, nonatomic) BOOL isAdmin;
		[Export ("isAdmin")]
		bool IsAdmin { get; }

		// @property (readonly, nonatomic) RLMSyncUserState state;
		[Export ("state")]
		RLMSyncUserState State { get; }

		// +(void)logInWithCredentials:(RLMSyncCredentials * _Nonnull)credentials authServerURL:(NSURL * _Nonnull)authServerURL timeout:(NSTimeInterval)timeout onCompletion:(RLMUserCompletionBlock _Nonnull)completion;
		[Static]
		[Export ("logInWithCredentials:authServerURL:timeout:onCompletion:")]
		void LogInWithCredentials (RLMSyncCredentials credentials, NSUrl authServerURL, double timeout, RLMUserCompletionBlock completion);

		// +(void)logInWithCredentials:(RLMSyncCredentials * _Nonnull)credentials authServerURL:(NSURL * _Nonnull)authServerURL onCompletion:(RLMUserCompletionBlock _Nonnull)completion;
		[Static]
		[Export ("logInWithCredentials:authServerURL:onCompletion:")]
		void LogInWithCredentials (RLMSyncCredentials credentials, NSUrl authServerURL, RLMUserCompletionBlock completion);

		// -(void)logOut;
		[Export ("logOut")]
		void LogOut ();

		// -(RLMSyncSession * _Nullable)sessionForURL:(NSURL * _Nonnull)url;
		[Export ("sessionForURL:")]
		[return: NullAllowed]
		RLMSyncSession SessionForURL (NSUrl url);

		// -(NSArray<RLMSyncSession *> * _Nonnull)allSessions;
		[Export ("allSessions")]
		[Verify (MethodToProperty)]
		RLMSyncSession[] AllSessions { get; }

		// -(void)changePassword:(NSString * _Nonnull)newPassword completion:(RLMPasswordChangeStatusBlock _Nonnull)completion;
		[Export ("changePassword:completion:")]
		void ChangePassword (string newPassword, RLMPasswordChangeStatusBlock completion);

		// -(void)changePassword:(NSString * _Nonnull)newPassword forUserID:(NSString * _Nonnull)userID completion:(RLMPasswordChangeStatusBlock _Nonnull)completion;
		[Export ("changePassword:forUserID:completion:")]
		void ChangePassword (string newPassword, string userID, RLMPasswordChangeStatusBlock completion);

		// -(void)retrievePermissionsWithCallback:(RLMPermissionResultsBlock _Nonnull)callback;
		[Export ("retrievePermissionsWithCallback:")]
		void RetrievePermissionsWithCallback (RLMPermissionResultsBlock callback);

		// -(void)applyPermission:(RLMSyncPermissionValue * _Nonnull)permission callback:(RLMPermissionStatusBlock _Nonnull)callback;
		[Export ("applyPermission:callback:")]
		void ApplyPermission (RLMSyncPermissionValue permission, RLMPermissionStatusBlock callback);

		// -(void)revokePermission:(RLMSyncPermissionValue * _Nonnull)permission callback:(RLMPermissionStatusBlock _Nonnull)callback;
		[Export ("revokePermission:callback:")]
		void RevokePermission (RLMSyncPermissionValue permission, RLMPermissionStatusBlock callback);

		// -(RLMRealm * _Nonnull)managementRealmWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("managementRealmWithError:")]
		RLMRealm ManagementRealmWithError ([NullAllowed] out NSError error);

		// -(RLMRealm * _Nonnull)permissionRealmWithError:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("Use `-retrievePermissionsWithCallback:`")));
		[Export ("permissionRealmWithError:")]
		RLMRealm PermissionRealmWithError ([NullAllowed] out NSError error);
	}

	// @interface RLMSyncPermissionResults : NSObject <NSFastEnumeration>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMSyncPermissionResults : INSFastEnumeration
	{
		// @property (readonly, nonatomic) NSInteger count;
		[Export ("count")]
		nint Count { get; }

		// -(RLMSyncPermissionValue * _Nullable)firstObject;
		[NullAllowed, Export ("firstObject")]
		[Verify (MethodToProperty)]
		RLMSyncPermissionValue FirstObject { get; }

		// -(RLMSyncPermissionValue * _Nullable)lastObject;
		[NullAllowed, Export ("lastObject")]
		[Verify (MethodToProperty)]
		RLMSyncPermissionValue LastObject { get; }

		// -(RLMSyncPermissionValue * _Nonnull)objectAtIndex:(NSInteger)index;
		[Export ("objectAtIndex:")]
		RLMSyncPermissionValue ObjectAtIndex (nint index);

		// -(NSInteger)indexOfObject:(RLMSyncPermissionValue * _Nonnull)object;
		[Export ("indexOfObject:")]
		nint IndexOfObject (RLMSyncPermissionValue @object);

		// -(RLMNotificationToken * _Nonnull)addNotificationBlock:(RLMPermissionStatusBlock _Nonnull)block;
		[Export ("addNotificationBlock:")]
		RLMNotificationToken AddNotificationBlock (RLMPermissionStatusBlock block);

		// -(RLMSyncPermissionResults * _Nonnull)objectsWithPredicate:(NSPredicate * _Nonnull)predicate;
		[Export ("objectsWithPredicate:")]
		RLMSyncPermissionResults ObjectsWithPredicate (NSPredicate predicate);

		// -(RLMSyncPermissionResults * _Nonnull)sortedResultsUsingProperty:(RLMSyncPermissionResultsSortProperty)property ascending:(BOOL)ascending;
		[Export ("sortedResultsUsingProperty:ascending:")]
		RLMSyncPermissionResults SortedResultsUsingProperty (RLMSyncPermissionResultsSortProperty property, bool ascending);
	}

	// @interface RLMSyncPermissionValue : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RLMSyncPermissionValue
	{
		// @property (readonly, nonatomic) NSString * _Nonnull path;
		[Export ("path")]
		string Path { get; }

		// @property (readonly, nonatomic) RLMSyncAccessLevel accessLevel;
		[Export ("accessLevel")]
		RLMSyncAccessLevel AccessLevel { get; }

		// @property (readonly, nonatomic) BOOL mayRead;
		[Export ("mayRead")]
		bool MayRead { get; }

		// @property (readonly, nonatomic) BOOL mayWrite;
		[Export ("mayWrite")]
		bool MayWrite { get; }

		// @property (readonly, nonatomic) BOOL mayManage;
		[Export ("mayManage")]
		bool MayManage { get; }

		// -(instancetype _Nonnull)initWithRealmPath:(NSString * _Nonnull)path userID:(NSString * _Nonnull)userID accessLevel:(RLMSyncAccessLevel)accessLevel;
		[Export ("initWithRealmPath:userID:accessLevel:")]
		IntPtr Constructor (string path, string userID, RLMSyncAccessLevel accessLevel);

		// @property (readonly, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export ("userId")]
		string UserId { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull updatedAt;
		[Export ("updatedAt")]
		NSDate UpdatedAt { get; }
	}

	// typedef void (^RLMProgressNotificationBlock)(NSUInteger, NSUInteger);
	delegate void RLMProgressNotificationBlock (nuint arg0, nuint arg1);

	// @interface RLMProgressNotificationToken : RLMNotificationToken
	[BaseType (typeof(RLMNotificationToken))]
	interface RLMProgressNotificationToken
	{
	}

	// @interface RLMSyncSession : NSObject
	[BaseType (typeof(NSObject))]
	interface RLMSyncSession
	{
		// @property (readonly, nonatomic) RLMSyncSessionState state;
		[Export ("state")]
		RLMSyncSessionState State { get; }

		// @property (readonly, nonatomic) NSURL * _Nullable realmURL;
		[NullAllowed, Export ("realmURL")]
		NSUrl RealmURL { get; }

		// -(RLMSyncUser * _Nullable)parentUser;
		[NullAllowed, Export ("parentUser")]
		[Verify (MethodToProperty)]
		RLMSyncUser ParentUser { get; }

		// -(RLMSyncConfiguration * _Nullable)configuration;
		[NullAllowed, Export ("configuration")]
		[Verify (MethodToProperty)]
		RLMSyncConfiguration Configuration { get; }

		// -(RLMProgressNotificationToken * _Nullable)addProgressNotificationForDirection:(RLMSyncProgressDirection)direction mode:(RLMSyncProgress)mode block:(RLMProgressNotificationBlock _Nonnull)block;
		[Export ("addProgressNotificationForDirection:mode:block:")]
		[return: NullAllowed]
		RLMProgressNotificationToken AddProgressNotificationForDirection (RLMSyncProgressDirection direction, RLMSyncProgress mode, RLMProgressNotificationBlock block);
	}
}
