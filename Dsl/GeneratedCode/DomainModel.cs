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
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Ufba.Ev
{
	/// <summary>
	/// DomainModel EvDomainModel
	/// Description for Ufba.Ev.Ev
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.Ev.EvDomainModel.DisplayName", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.Ev.EvDomainModel.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("10960b28-2a5c-4690-bc14-a4463850e3d4")]
	public partial class EvDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// EvDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x10960b28, 0x2a5c, 0x4690, 0xbc, 0x14, 0xa4, 0x46, 0x38, 0x50, 0xe3, 0xd4);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public EvDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(EvModel),
				typeof(Option),
				typeof(Function),
				typeof(Property),
				typeof(Type),
				typeof(EvModelHasElements),
				typeof(OptionHasFunctions),
				typeof(OptionHasProperties),
				typeof(OptionHasTypes),
				typeof(EvDiagram),
				typeof(OptionConnector),
				typeof(FunctionShape),
				typeof(OptionShape),
				typeof(global::Ufba.Ev.FixUpDiagram),
				typeof(global::Ufba.Ev.DecoratorPropertyChanged),
				typeof(global::Ufba.Ev.ConnectorRolePlayerChanged),
				typeof(global::Ufba.Ev.CompartmentItemAddRule),
				typeof(global::Ufba.Ev.CompartmentItemDeleteRule),
				typeof(global::Ufba.Ev.CompartmentItemRolePlayerChangeRule),
				typeof(global::Ufba.Ev.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::Ufba.Ev.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(Option), "OptionType", Option.OptionTypeDomainPropertyId, typeof(Option.OptionTypePropertyHandler)),
				new DomainMemberInfo(typeof(Option), "CommandType", Option.CommandTypeDomainPropertyId, typeof(Option.CommandTypePropertyHandler)),
				new DomainMemberInfo(typeof(Function), "Name", Function.NameDomainPropertyId, typeof(Function.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "Name", Property.NameDomainPropertyId, typeof(Property.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Type), "Name", Type.NameDomainPropertyId, typeof(Type.NamePropertyHandler)),
				new DomainMemberInfo(typeof(OptionHasFunctions), "Var", OptionHasFunctions.VarDomainPropertyId, typeof(OptionHasFunctions.VarPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(EvModelHasElements), "EvModel", EvModelHasElements.EvModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(EvModelHasElements), "Element", EvModelHasElements.ElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(OptionHasFunctions), "Option", OptionHasFunctions.OptionDomainRoleId),
				new DomainRolePlayerInfo(typeof(OptionHasFunctions), "Function", OptionHasFunctions.FunctionDomainRoleId),
				new DomainRolePlayerInfo(typeof(OptionHasProperties), "Option", OptionHasProperties.OptionDomainRoleId),
				new DomainRolePlayerInfo(typeof(OptionHasProperties), "Property", OptionHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(OptionHasTypes), "Option", OptionHasTypes.OptionDomainRoleId),
				new DomainRolePlayerInfo(typeof(OptionHasTypes), "Type", OptionHasTypes.TypeDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(9);
				createElementMap.Add(typeof(EvModel), 0);
				createElementMap.Add(typeof(Option), 1);
				createElementMap.Add(typeof(Function), 2);
				createElementMap.Add(typeof(Property), 3);
				createElementMap.Add(typeof(Type), 4);
				createElementMap.Add(typeof(EvDiagram), 5);
				createElementMap.Add(typeof(OptionConnector), 6);
				createElementMap.Add(typeof(FunctionShape), 7);
				createElementMap.Add(typeof(OptionShape), 8);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Ufba.Ev.EvDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new EvModel(partition, propertyAssignments);
				case 1: return new Option(partition, propertyAssignments);
				case 2: return new Function(partition, propertyAssignments);
				case 3: return new Property(partition, propertyAssignments);
				case 4: return new Type(partition, propertyAssignments);
				case 5: return new EvDiagram(partition, propertyAssignments);
				case 6: return new OptionConnector(partition, propertyAssignments);
				case 7: return new FunctionShape(partition, propertyAssignments);
				case 8: return new OptionShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(4);
				createElementLinkMap.Add(typeof(EvModelHasElements), 0);
				createElementLinkMap.Add(typeof(OptionHasFunctions), 1);
				createElementLinkMap.Add(typeof(OptionHasProperties), 2);
				createElementLinkMap.Add(typeof(OptionHasTypes), 3);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Ufba.Ev.EvDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new EvModelHasElements(partition, roleAssignments, propertyAssignments);
				case 1: return new OptionHasFunctions(partition, roleAssignments, propertyAssignments);
				case 2: return new OptionHasProperties(partition, roleAssignments, propertyAssignments);
				case 3: return new OptionHasTypes(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Ufba.Ev.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return EvDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (EvDomainModel.resourceManager == null)
				{
					EvDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(EvDomainModel).Assembly);
				}
				return EvDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return EvDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return EvDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (EvDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new EvCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					EvDomainModel.copyClosure = copyFilter;
				}
				return EvDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (EvDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new EvDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					EvDomainModel.removeClosure = removeFilter;
				}
				return EvDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Ufba.Ev.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.DecoratorPropertyChanged));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::Ufba.Ev.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Ufba.Ev.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.DecoratorPropertyChanged));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::Ufba.Ev.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class EvDeleteClosure : EvDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public EvDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class EvDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public EvDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Ufba.Ev.EvModelHasElements.ElementDomainRoleId, true);
			DomainRoles.Add(global::Ufba.Ev.OptionHasFunctions.FunctionDomainRoleId, true);
			DomainRoles.Add(global::Ufba.Ev.OptionHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::Ufba.Ev.OptionHasTypes.TypeDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class EvCopyClosure : EvCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public EvCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class EvCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public EvCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainEnumeration: OptionTypes
	/// Description for Ufba.Ev.OptionTypes
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum OptionTypes
	{
		/// <summary>
		/// User
		/// Description for Ufba.Ev.OptionTypes.User
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/User.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		User,
		/// <summary>
		/// Speaker
		/// Description for Ufba.Ev.OptionTypes.Speaker
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Speaker.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Speaker,
		/// <summary>
		/// Organizer
		/// Description for Ufba.Ev.OptionTypes.Organizer
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Organizer.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Organizer,
		/// <summary>
		/// Event
		/// Description for Ufba.Ev.OptionTypes.Event
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Event.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Event,
		/// <summary>
		/// Assignment
		/// Description for Ufba.Ev.OptionTypes.Assignment
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Assignment.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Assignment,
		/// <summary>
		/// Payment
		/// Description for Ufba.Ev.OptionTypes.Payment
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Payment.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Payment,
		/// <summary>
		/// Submission
		/// Description for Ufba.Ev.OptionTypes.Submission
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Submission.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Submission,
		/// <summary>
		/// Reviewer
		/// Description for Ufba.Ev.OptionTypes.Reviewer
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Reviewer.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Reviewer,
		/// <summary>
		/// Activity
		/// Description for Ufba.Ev.OptionTypes.Activity
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Activity.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Activity,
		/// <summary>
		/// Author
		/// Description for Ufba.Ev.OptionTypes.Author
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Author.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Author,
		/// <summary>
		/// Receipt
		/// Description for Ufba.Ev.OptionTypes.Receipt
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/Receipt.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Receipt,
		/// <summary>
		/// CheckingCopy
		/// Description for Ufba.Ev.OptionTypes.CheckingCopy
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.OptionTypes/CheckingCopy.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		CheckingCopy,
	}
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainEnumeration: FunctionTypes
	/// Description for Ufba.Ev.FunctionTypes
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum FunctionTypes
	{
		/// <summary>
		/// askCardInfo
		/// Description for Ufba.Ev.FunctionTypes.askCardInfo
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/askCardInfo.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		askCardInfo,
		/// <summary>
		/// sendEmailNotification
		/// Description for Ufba.Ev.FunctionTypes.sendEmailNotification
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/sendEmailNotification.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		sendEmailNotification,
		/// <summary>
		/// assigmentConflictResolver
		/// Description for Ufba.Ev.FunctionTypes.assigmentConflictResolver
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/assigmentConflictResolver.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		assigmentConflictResolver,
		/// <summary>
		/// reportsFrequencyPerActivity
		/// Description for Ufba.Ev.FunctionTypes.reportsFrequencyPerActivity
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/reportsFrequencyPerActivity.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		reportsFrequencyPerActivity,
		/// <summary>
		/// checkingCopyAtestado
		/// Description for Ufba.Ev.FunctionTypes.checkingCopyAtestado
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/checkingCopyAtestado.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		checkingCopyAtestado,
		/// <summary>
		/// reportsListofAuthors
		/// Description for Ufba.Ev.FunctionTypes.reportsListofAuthors
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/reportsListofAuthors.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		reportsListofAuthors,
		/// <summary>
		/// checkingCopyCertificado
		/// Description for Ufba.Ev.FunctionTypes.checkingCopyCertificado
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/checkingCopyCertificado.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		checkingCopyCertificado,
		/// <summary>
		/// program
		/// Description for Ufba.Ev.FunctionTypes.program
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/program.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		program,
		/// <summary>
		/// importantDates
		/// Description for Ufba.Ev.FunctionTypes.importantDates
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/importantDates.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		importantDates,
		/// <summary>
		/// generateBoleto
		/// Description for Ufba.Ev.FunctionTypes.generateBoleto
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/generateBoleto.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		generateBoleto,
		/// <summary>
		/// reportsFrequencyPerEvent
		/// Description for Ufba.Ev.FunctionTypes.reportsFrequencyPerEvent
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/reportsFrequencyPerEvent.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		reportsFrequencyPerEvent,
		/// <summary>
		/// generateCarne
		/// Description for Ufba.Ev.FunctionTypes.generateCarne
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/generateCarne.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		generateCarne,
		/// <summary>
		/// sendBugTrackEmail
		/// Description for Ufba.Ev.FunctionTypes.sendBugTrackEmail
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/sendBugTrackEmail.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		sendBugTrackEmail,
		/// <summary>
		/// notificationsDeadline
		/// Description for Ufba.Ev.FunctionTypes.notificationsDeadline
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/notificationsDeadline.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		notificationsDeadline,
		/// <summary>
		/// interestConflict
		/// Description for Ufba.Ev.FunctionTypes.interestConflict
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/interestConflict.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		interestConflict,
		/// <summary>
		/// notificationsAceptanceRejection
		/// Description for Ufba.Ev.FunctionTypes.notificationsAceptanceRejection
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.FunctionTypes/notificationsAceptanceRejection.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		notificationsAceptanceRejection,
	}
}
namespace Ufba.Ev
{
	/// <summary>
	/// DomainEnumeration: CommandTypes
	/// Description for Ufba.Ev.CommandTypes
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum CommandTypes
	{
		/// <summary>
		/// Insert
		/// Description for Ufba.Ev.CommandTypes.Insert
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.CommandTypes/Insert.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Insert,
		/// <summary>
		/// Update
		/// Description for Ufba.Ev.CommandTypes.Update
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.CommandTypes/Update.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Update,
		/// <summary>
		/// Search
		/// Description for Ufba.Ev.CommandTypes.Search
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.CommandTypes/Search.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Search,
		/// <summary>
		/// Remove
		/// Description for Ufba.Ev.CommandTypes.Remove
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.CommandTypes/Remove.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		Remove,
		/// <summary>
		/// ListAll
		/// Description for Ufba.Ev.CommandTypes.ListAll
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.Ev.CommandTypes/ListAll.Description", typeof(global::Ufba.Ev.EvDomainModel), "Ufba.Ev.GeneratedCode.DomainModelResx")]
		ListAll,
	}
}

