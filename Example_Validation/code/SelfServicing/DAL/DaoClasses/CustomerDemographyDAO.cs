﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:48:59
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.CollectionClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace SD.LLBLGen.Pro.Examples.DaoClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>General DAO class for the CustomerDemography Entity. It will perform database oriented actions for a entity of type 'CustomerDemographyEntity'.</summary>
	public partial class CustomerDemographyDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public CustomerDemographyDAO() : base(InheritanceHierarchyType.None, "CustomerDemographyEntity", new CustomerDemographyEntityFactory())
		{
		}





		/// <summary>Retrieves in the calling CustomerDemographyCollection object all CustomerDemographyEntity objects which are related via a relation of type 'm:n' with the passed in CustomerEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingCustomerCollectionViaCustomerCustomerDemo(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity customerInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(CustomerDemographyEntity.Relations.CustomerCustomerDemoEntityUsingCustomerTypeId, "CustomerCustomerDemo_");
			relations.Add(CustomerCustomerDemoEntity.Relations.CustomerEntityUsingCustomerId, "CustomerCustomerDemo_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(customerInstance.Fields[(int)CustomerFieldIndex.CustomerId], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}



		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
