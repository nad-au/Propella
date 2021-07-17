/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v1
 * Contact: api@domain.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Api;
// uncomment below to import models
//using Domain.Api.V1.Client.Model;

namespace Domain.Api.V1.Client.Test.Api
{
    /// <summary>
    ///  Class for testing AgenciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AgenciesApiTests : IDisposable
    {
        private AgenciesApi instance;

        public AgenciesApiTests()
        {
            instance = new AgenciesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AgenciesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AgenciesApi
            //Assert.IsType<AgenciesApi>(instance);
        }

        /// <summary>
        /// Test AgenciesCreateTestAgency
        /// </summary>
        [Fact]
        public void AgenciesCreateTestAgencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AgenciesCreateTestAgency();
            //Assert.IsType<DomainAgencyServiceV2ModelAgency>(response);
        }

        /// <summary>
        /// Test AgenciesGet
        /// </summary>
        [Fact]
        public void AgenciesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.AgenciesGet(id);
            //Assert.IsType<DomainAgencyServiceV2ModelAgency>(response);
        }

        /// <summary>
        /// Test AgenciesGetBundleContracts
        /// </summary>
        [Fact]
        public void AgenciesGetBundleContractsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.AgenciesGetBundleContracts(id);
            //Assert.IsType<List<DomainBookingServiceV1ModelProductBundleContractDetailsResponse>>(response);
        }

        /// <summary>
        /// Test AgenciesGetListings
        /// </summary>
        [Fact]
        public void AgenciesGetListingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string listingStatusFilter = null;
            //DateTime? dateUpdatedSince = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.AgenciesGetListings(id, listingStatusFilter, dateUpdatedSince, pageNumber, pageSize);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsListing>>(response);
        }

        /// <summary>
        /// Test AgenciesGetStatistics
        /// </summary>
        [Fact]
        public void AgenciesGetStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string timePeriod = null;
            //string statusFilter = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.AgenciesGetStatistics(id, timePeriod, statusFilter, pageNumber, pageSize);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsStatistics>>(response);
        }

        /// <summary>
        /// Test AgenciesGetSubscriptions
        /// </summary>
        [Fact]
        public void AgenciesGetSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string channel = null;
            //var response = instance.AgenciesGetSubscriptions(id, channel);
            //Assert.IsType<List<DomainAgencyServiceV1ModelAgencySubscriptionDto>>(response);
        }

        /// <summary>
        /// Test AgenciesHead
        /// </summary>
        [Fact]
        public void AgenciesHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //instance.AgenciesHead(q, pageNumber, pageSize);
        }

        /// <summary>
        /// Test AgenciesSearch
        /// </summary>
        [Fact]
        public void AgenciesSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.AgenciesSearch(q, pageNumber, pageSize);
            //Assert.IsType<List<DomainAgencyServiceV2ModelAgencySummary>>(response);
        }
    }
}