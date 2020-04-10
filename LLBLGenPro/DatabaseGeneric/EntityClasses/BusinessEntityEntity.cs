﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'BusinessEntity'.<br/><br/></summary>
	[Serializable]
	public partial class BusinessEntityEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<BusinessEntityAddressEntity> _businessEntityAddresses;
		private EntityCollection<BusinessEntityContactEntity> _businessEntityContacts;
		private PersonEntity _person;
		private StoreEntity _store;
		private VendorEntity _vendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static BusinessEntityEntityStaticMetaData _staticMetaData = new BusinessEntityEntityStaticMetaData();
		private static BusinessEntityRelations _relationsFactory = new BusinessEntityRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntityAddresses</summary>
			public static readonly string BusinessEntityAddresses = "BusinessEntityAddresses";
			/// <summary>Member name BusinessEntityContacts</summary>
			public static readonly string BusinessEntityContacts = "BusinessEntityContacts";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name Store</summary>
			public static readonly string Store = "Store";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class BusinessEntityEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public BusinessEntityEntityStaticMetaData()
			{
				SetEntityCoreInfo("BusinessEntityEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityEntity, typeof(BusinessEntityEntity), typeof(BusinessEntityEntityFactory), false);
				AddNavigatorMetaData<BusinessEntityEntity, EntityCollection<BusinessEntityAddressEntity>>("BusinessEntityAddresses", a => a._businessEntityAddresses, (a, b) => a._businessEntityAddresses = b, a => a.BusinessEntityAddresses, () => new BusinessEntityRelations().BusinessEntityAddressEntityUsingBusinessEntityId, typeof(BusinessEntityAddressEntity), (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityAddressEntity);
				AddNavigatorMetaData<BusinessEntityEntity, EntityCollection<BusinessEntityContactEntity>>("BusinessEntityContacts", a => a._businessEntityContacts, (a, b) => a._businessEntityContacts = b, a => a.BusinessEntityContacts, () => new BusinessEntityRelations().BusinessEntityContactEntityUsingBusinessEntityId, typeof(BusinessEntityContactEntity), (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityContactEntity);
				AddNavigatorMetaData<BusinessEntityEntity, PersonEntity>("Person", "BusinessEntity", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticBusinessEntityRelations.PersonEntityUsingBusinessEntityIdStatic, ()=>new BusinessEntityRelations().PersonEntityUsingBusinessEntityId, null, null, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.PersonEntity);
				AddNavigatorMetaData<BusinessEntityEntity, StoreEntity>("Store", "BusinessEntity", (a, b) => a._store = b, a => a._store, (a, b) => a.Store = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticBusinessEntityRelations.StoreEntityUsingCustomerIdStatic, ()=>new BusinessEntityRelations().StoreEntityUsingCustomerId, null, null, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.StoreEntity);
				AddNavigatorMetaData<BusinessEntityEntity, VendorEntity>("Vendor", "BusinessEntity", (a, b) => a._vendor = b, a => a._vendor, (a, b) => a.Vendor = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticBusinessEntityRelations.VendorEntityUsingVendorIdStatic, ()=>new BusinessEntityRelations().VendorEntityUsingVendorId, null, null, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.VendorEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static BusinessEntityEntity()
		{
		}

		/// <summary> CTor</summary>
		public BusinessEntityEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BusinessEntityEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BusinessEntityEntity</param>
		public BusinessEntityEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for BusinessEntity which data should be fetched into this BusinessEntity object</param>
		public BusinessEntityEntity(System.Int32 businessEntityId) : this(businessEntityId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for BusinessEntity which data should be fetched into this BusinessEntity object</param>
		/// <param name="validator">The custom validator object for this BusinessEntityEntity</param>
		public BusinessEntityEntity(System.Int32 businessEntityId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BusinessEntityEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityAddress' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityAddresses() { return CreateRelationInfoForNavigator("BusinessEntityAddresses"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityContact' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityContacts() { return CreateRelationInfoForNavigator("BusinessEntityContacts"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson() { return CreateRelationInfoForNavigator("Person"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Store' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStore() { return CreateRelationInfoForNavigator("Store"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendor() { return CreateRelationInfoForNavigator("Vendor"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this BusinessEntityEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static BusinessEntityRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityAddresses { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntityAddresses", CommonEntityBase.CreateEntityCollection<BusinessEntityAddressEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityContacts { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntityContacts", CommonEntityBase.CreateEntityCollection<BusinessEntityContactEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStore { get { return _staticMetaData.GetPrefetchPathElement("Store", CommonEntityBase.CreateEntityCollection<StoreEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendor { get { return _staticMetaData.GetPrefetchPathElement("Vendor", CommonEntityBase.CreateEntityCollection<VendorEntity>()); } }

		/// <summary>The BusinessEntityId property of the Entity BusinessEntity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntity"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityFieldIndex.BusinessEntityId, true); }
			set { SetValue((int)BusinessEntityFieldIndex.BusinessEntityId, value); }		}

		/// <summary>The ModifiedDate property of the Entity BusinessEntity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntity"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BusinessEntityFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BusinessEntityFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Rowguid property of the Entity BusinessEntity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntity"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)BusinessEntityFieldIndex.Rowguid, true); }
			set	{ SetValue((int)BusinessEntityFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'BusinessEntityAddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityAddressEntity))]
		public virtual EntityCollection<BusinessEntityAddressEntity> BusinessEntityAddresses { get { return GetOrCreateEntityCollection<BusinessEntityAddressEntity, BusinessEntityAddressEntityFactory>("BusinessEntity", true, false, ref _businessEntityAddresses); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'BusinessEntityContactEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityContactEntity))]
		public virtual EntityCollection<BusinessEntityContactEntity> BusinessEntityContacts { get { return GetOrCreateEntityCollection<BusinessEntityContactEntity, BusinessEntityContactEntityFactory>("BusinessEntity", true, false, ref _businessEntityContacts); } }

		/// <summary>Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set { SetSingleRelatedEntityNavigator(value, "Person"); }
		}

		/// <summary>Gets / sets related entity of type 'StoreEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual StoreEntity Store
		{
			get { return _store; }
			set { SetSingleRelatedEntityNavigator(value, "Store"); }
		}

		/// <summary>Gets / sets related entity of type 'VendorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get { return _vendor; }
			set { SetSingleRelatedEntityNavigator(value, "Vendor"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum BusinessEntityFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: BusinessEntity. </summary>
	public partial class BusinessEntityRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and BusinessEntityAddressEntity over the 1:n relation they have, using the relation between the fields: BusinessEntity.BusinessEntityId - BusinessEntityAddress.BusinessEntityId</summary>
		public virtual IEntityRelation BusinessEntityAddressEntityUsingBusinessEntityId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "BusinessEntityAddresses", true, new[] { BusinessEntityFields.BusinessEntityId, BusinessEntityAddressFields.BusinessEntityId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and BusinessEntityContactEntity over the 1:n relation they have, using the relation between the fields: BusinessEntity.BusinessEntityId - BusinessEntityContact.BusinessEntityId</summary>
		public virtual IEntityRelation BusinessEntityContactEntityUsingBusinessEntityId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "BusinessEntityContacts", true, new[] { BusinessEntityFields.BusinessEntityId, BusinessEntityContactFields.BusinessEntityId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and PersonEntity over the 1:1 relation they have, using the relation between the fields: BusinessEntity.BusinessEntityId - Person.BusinessEntityId</summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "Person", true, new[] { BusinessEntityFields.BusinessEntityId, PersonFields.BusinessEntityId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and StoreEntity over the 1:1 relation they have, using the relation between the fields: BusinessEntity.BusinessEntityId - Store.CustomerId</summary>
		public virtual IEntityRelation StoreEntityUsingCustomerId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "Store", true, new[] { BusinessEntityFields.BusinessEntityId, StoreFields.CustomerId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and VendorEntity over the 1:1 relation they have, using the relation between the fields: BusinessEntity.BusinessEntityId - Vendor.VendorId</summary>
		public virtual IEntityRelation VendorEntityUsingVendorId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "Vendor", true, new[] { BusinessEntityFields.BusinessEntityId, VendorFields.VendorId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticBusinessEntityRelations
	{
		internal static readonly IEntityRelation BusinessEntityAddressEntityUsingBusinessEntityIdStatic = new BusinessEntityRelations().BusinessEntityAddressEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation BusinessEntityContactEntityUsingBusinessEntityIdStatic = new BusinessEntityRelations().BusinessEntityContactEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new BusinessEntityRelations().PersonEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation StoreEntityUsingCustomerIdStatic = new BusinessEntityRelations().StoreEntityUsingCustomerId;
		internal static readonly IEntityRelation VendorEntityUsingVendorIdStatic = new BusinessEntityRelations().VendorEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticBusinessEntityRelations() { }
	}
}
