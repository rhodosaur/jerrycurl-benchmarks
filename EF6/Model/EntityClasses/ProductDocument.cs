﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductDocument'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ProductDocument : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ProductDocument"/> class.</summary>
		public ProductDocument() : base()
		{
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the DocumentNode field. </summary>
		[DataMember]
		public System.String DocumentNode { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the ProductId field. </summary>
		[DataMember]
		public System.Int32 ProductId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductDocument.Document - Document.ProductDocuments (m:1)'</summary>
		[DataMember]
		public virtual Document Document { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductDocument.Product - Product.ProductDocuments (m:1)'</summary>
		[DataMember]
		public virtual Product Product { get; set;}
		#endregion
	}
}
