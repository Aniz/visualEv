﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace Ufba.Ev
{
	/// <summary>
	/// DomainClass EvModel
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.Ev.EvModel.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.Ev.EvModel.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.Ev.EvDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("2f5d49ad-6ddd-4b45-bfe7-98718ee823d3")]
	public partial class EvModel : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// EvModel domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2f5d49ad, 0x6ddd, 0x4b45, 0xbf, 0xe7, 0x98, 0x71, 0x8e, 0xe8, 0x23, 0xd3);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public EvModel(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public EvModel(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Elements opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Option> Elements
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Option>, Option>(global::Ufba.Ev.EvModelHasElements.EvModelDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Ufba.Ev.Option.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::Ufba.Ev.Option sourceOption1 = sourceElement as global::Ufba.Ev.Option;
			if (sourceOption1 != null)
			{
				// Create link for path EvModelHasElements.Elements
				this.Elements.Add(sourceOption1);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::Ufba.Ev.Option sourceOption1 = sourceElement as global::Ufba.Ev.Option;
			if (sourceOption1 != null)
			{
				// Delete link for path EvModelHasElements.Elements
				
				foreach (DslModeling::ElementLink link in global::Ufba.Ev.EvModelHasElements.GetLinks((global::Ufba.Ev.EvModel)this, sourceOption1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Ufba.Ev.EvModelHasElements.EvModelDomainRoleId, global::Ufba.Ev.EvModelHasElements.ElementDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainClass Option
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.Ev.Option.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.Ev.Option.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.Ev.EvDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Type = {typePropertyStorage})")]
	[DslModeling::DomainObjectId("5898829f-1494-4271-a5e2-ba4fc2f46d92")]
	public partial class Option : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Option domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x5898829f, 0x1494, 0x4271, 0xa5, 0xe2, 0xba, 0x4f, 0xc2, 0xf4, 0x6d, 0x92);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Option(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Option(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Type domain property code
		
		/// <summary>
		/// Type domain property Id.
		/// </summary>
		public static readonly global::System.Guid TypeDomainPropertyId = new global::System.Guid(0x978af1b3, 0x2cbf, 0x4733, 0x98, 0xa7, 0x7a, 0xba, 0xc8, 0x48, 0xa1, 0x8a);
		
		/// <summary>
		/// Storage for Type
		/// </summary>
		private global::System.String typePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Type domain property.
		/// Description for Ufba.Ev.Option.Type
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.Ev.Option/Type.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.Ev.Option/Type.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("978af1b3-2cbf-4733-98a7-7abac848a18a")]
		public global::System.String Type
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return typePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Option.Type domain property.
		/// </summary>
		internal sealed partial class TypePropertyHandler : DslModeling::DomainPropertyValueHandler<Option, global::System.String>
		{
			private TypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Option.Type domain property value handler.
			/// </summary>
			public static readonly TypePropertyHandler Instance = new TypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Option.Type domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Option element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.typePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Option element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.typePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region EvModel opposite domain role accessor
		/// <summary>
		/// Gets or sets EvModel.
		/// </summary>
		public virtual EvModel EvModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Ufba.Ev.EvModelHasElements.ElementDomainRoleId) as EvModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Ufba.Ev.EvModelHasElements.ElementDomainRoleId, value);
			}
		}
		#endregion
		#region Functions opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Functions.
		/// Description for Ufba.Ev.OptionHasFunctions.Option
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Function> Functions
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Function>, Function>(global::Ufba.Ev.OptionHasFunctions.OptionDomainRoleId);
			}
		}
		#endregion
		#region Properties opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Properties.
		/// Description for Ufba.Ev.OptionHasProperties.Option
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Property> Properties
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Property>, Property>(global::Ufba.Ev.OptionHasProperties.OptionDomainRoleId);
			}
		}
		#endregion
		#region Types opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Types.
		/// Description for Ufba.Ev.OptionHasTypes.Option
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Type> Types
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Type>, Type>(global::Ufba.Ev.OptionHasTypes.OptionDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Ufba.Ev.Function.DomainClassId)) 
				{
					return true;
				}
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Ufba.Ev.Property.DomainClassId)) 
				{
					return true;
				}
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Ufba.Ev.Type.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::Ufba.Ev.Function sourceFunction1 = sourceElement as global::Ufba.Ev.Function;
			if (sourceFunction1 != null)
			{
				// Create link for path OptionHasFunctions.Functions
				this.Functions.Add(sourceFunction1);

				return;
			}
				
			global::Ufba.Ev.Property sourceProperty2 = sourceElement as global::Ufba.Ev.Property;
			if (sourceProperty2 != null)
			{
				// Create link for path OptionHasProperties.Properties
				this.Properties.Add(sourceProperty2);

				return;
			}
				
			global::Ufba.Ev.Type sourceType3 = sourceElement as global::Ufba.Ev.Type;
			if (sourceType3 != null)
			{
				// Create link for path OptionHasTypes.Types
				this.Types.Add(sourceType3);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::Ufba.Ev.Function sourceFunction1 = sourceElement as global::Ufba.Ev.Function;
			if (sourceFunction1 != null)
			{
				// Delete link for path OptionHasFunctions.Functions
				
				foreach (DslModeling::ElementLink link in global::Ufba.Ev.OptionHasFunctions.GetLinks((global::Ufba.Ev.Option)this, sourceFunction1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Ufba.Ev.OptionHasFunctions.OptionDomainRoleId, global::Ufba.Ev.OptionHasFunctions.FunctionDomainRoleId);
				}

				return;
			}
				
			global::Ufba.Ev.Property sourceProperty2 = sourceElement as global::Ufba.Ev.Property;
			if (sourceProperty2 != null)
			{
				// Delete link for path OptionHasProperties.Properties
				
				foreach (DslModeling::ElementLink link in global::Ufba.Ev.OptionHasProperties.GetLinks((global::Ufba.Ev.Option)this, sourceProperty2))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Ufba.Ev.OptionHasProperties.OptionDomainRoleId, global::Ufba.Ev.OptionHasProperties.PropertyDomainRoleId);
				}

				return;
			}
				
			global::Ufba.Ev.Type sourceType3 = sourceElement as global::Ufba.Ev.Type;
			if (sourceType3 != null)
			{
				// Delete link for path OptionHasTypes.Types
				
				foreach (DslModeling::ElementLink link in global::Ufba.Ev.OptionHasTypes.GetLinks((global::Ufba.Ev.Option)this, sourceType3))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Ufba.Ev.OptionHasTypes.OptionDomainRoleId, global::Ufba.Ev.OptionHasTypes.TypeDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainClass Function
	/// Description for Ufba.Ev.Function
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.Ev.Function.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.Ev.Function.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.Ev.EvDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("a1d03807-55e4-4045-acb7-598e4eefae80")]
	public partial class Function : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Function domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xa1d03807, 0x55e4, 0x4045, 0xac, 0xb7, 0x59, 0x8e, 0x4e, 0xef, 0xae, 0x80);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Function(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Function(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x119461ac, 0xc927, 0x4f97, 0xbb, 0x68, 0x11, 0xee, 0xe9, 0x9e, 0x5d, 0x16);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for Ufba.Ev.Function.Name
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.Ev.Function/Name.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.Ev.Function/Name.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("119461ac-c927-4f97-bb68-11eee99e5d16")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Function.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Function, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Function.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Function.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Function element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Function element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Option opposite domain role accessor
		/// <summary>
		/// Gets or sets Option.
		/// Description for Ufba.Ev.OptionHasFunctions.Function
		/// </summary>
		public virtual Option Option
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Ufba.Ev.OptionHasFunctions.FunctionDomainRoleId) as Option;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Ufba.Ev.OptionHasFunctions.FunctionDomainRoleId, value);
			}
		}
		#endregion
	}
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainClass Property
	/// Description for Ufba.Ev.Property
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.Ev.Property.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.Ev.Property.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.Ev.EvDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("6a78b38d-b370-45fc-992c-ce5f1193a4a7")]
	public partial class Property : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Property domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x6a78b38d, 0xb370, 0x45fc, 0x99, 0x2c, 0xce, 0x5f, 0x11, 0x93, 0xa4, 0xa7);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Property(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Property(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x1a60111e, 0x9ed2, 0x4006, 0x87, 0xc0, 0x9f, 0x92, 0x23, 0x79, 0x9b, 0x79);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for Ufba.Ev.Property.Name
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.Ev.Property/Name.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.Ev.Property/Name.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("1a60111e-9ed2-4006-87c0-9f9223799b79")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Property.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Property, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Property.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Property.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Property element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Property element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Option opposite domain role accessor
		/// <summary>
		/// Gets or sets Option.
		/// Description for Ufba.Ev.OptionHasProperties.Property
		/// </summary>
		public virtual Option Option
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Ufba.Ev.OptionHasProperties.PropertyDomainRoleId) as Option;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Ufba.Ev.OptionHasProperties.PropertyDomainRoleId, value);
			}
		}
		#endregion
	}
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainClass Type
	/// Description for Ufba.Ev.Type
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.Ev.Type.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.Ev.Type.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.Ev.EvDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("2ac8ebca-adb0-4a57-b9e1-38c93f6f2517")]
	public partial class Type : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Type domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2ac8ebca, 0xadb0, 0x4a57, 0xb9, 0xe1, 0x38, 0xc9, 0x3f, 0x6f, 0x25, 0x17);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Type(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Type(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x748dea58, 0x1627, 0x4eea, 0x9a, 0x80, 0xfb, 0x92, 0x4f, 0xc8, 0x32, 0x91);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for Ufba.Ev.Type.Name
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.Ev.Type/Name.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.Ev.Type/Name.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("748dea58-1627-4eea-9a80-fb924fc83291")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Type.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Type, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Type.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Type.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Type element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Type element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Option opposite domain role accessor
		/// <summary>
		/// Gets or sets Option.
		/// Description for Ufba.Ev.OptionHasTypes.Type
		/// </summary>
		public virtual Option Option
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Ufba.Ev.OptionHasTypes.TypeDomainRoleId) as Option;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Ufba.Ev.OptionHasTypes.TypeDomainRoleId, value);
			}
		}
		#endregion
	}
}
