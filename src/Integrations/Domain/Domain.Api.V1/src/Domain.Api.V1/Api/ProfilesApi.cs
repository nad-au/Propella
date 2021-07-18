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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Domain.Api.V1.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get location data based on the given domainLocationId
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <returns>DomainLocationProfilesServiceV1ModelLocation</returns>
        DomainLocationProfilesServiceV1ModelLocation LocationProfilesGet(string domainLocationId);

        /// <summary>
        /// Get location data based on the given domainLocationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <returns>ApiResponse of DomainLocationProfilesServiceV1ModelLocation</returns>
        ApiResponse<DomainLocationProfilesServiceV1ModelLocation> LocationProfilesGetWithHttpInfo(string domainLocationId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get location data based on the given domainLocationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainLocationProfilesServiceV1ModelLocation</returns>
        System.Threading.Tasks.Task<DomainLocationProfilesServiceV1ModelLocation> LocationProfilesGetAsync(string domainLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get location data based on the given domainLocationId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainLocationProfilesServiceV1ModelLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLocationProfilesServiceV1ModelLocation>> LocationProfilesGetWithHttpInfoAsync(string domainLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApi : IProfilesApiSync, IProfilesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProfilesApi : IProfilesApi
    {
        private Domain.Api.V1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfilesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfilesApi(String basePath)
        {
            this.Configuration = Domain.Api.V1.Client.Configuration.MergeConfigurations(
                Domain.Api.V1.Client.GlobalConfiguration.Instance,
                new Domain.Api.V1.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Domain.Api.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProfilesApi(Domain.Api.V1.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Domain.Api.V1.Client.Configuration.MergeConfigurations(
                Domain.Api.V1.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Domain.Api.V1.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Domain.Api.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProfilesApi(Domain.Api.V1.Client.ISynchronousClient client, Domain.Api.V1.Client.IAsynchronousClient asyncClient, Domain.Api.V1.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Domain.Api.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Domain.Api.V1.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Domain.Api.V1.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Domain.Api.V1.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Domain.Api.V1.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get location data based on the given domainLocationId 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <returns>DomainLocationProfilesServiceV1ModelLocation</returns>
        public DomainLocationProfilesServiceV1ModelLocation LocationProfilesGet(string domainLocationId)
        {
            Domain.Api.V1.Client.ApiResponse<DomainLocationProfilesServiceV1ModelLocation> localVarResponse = LocationProfilesGetWithHttpInfo(domainLocationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get location data based on the given domainLocationId 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <returns>ApiResponse of DomainLocationProfilesServiceV1ModelLocation</returns>
        public Domain.Api.V1.Client.ApiResponse<DomainLocationProfilesServiceV1ModelLocation> LocationProfilesGetWithHttpInfo(string domainLocationId)
        {
            // verify the required parameter 'domainLocationId' is set
            if (domainLocationId == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'domainLocationId' when calling ProfilesApi->LocationProfilesGet");

            Domain.Api.V1.Client.RequestOptions localVarRequestOptions = new Domain.Api.V1.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = Domain.Api.V1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Domain.Api.V1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("domainLocationId", Domain.Api.V1.Client.ClientUtils.ParameterToString(domainLocationId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DomainLocationProfilesServiceV1ModelLocation>("/v1/locations/profiles/{domainLocationId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LocationProfilesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get location data based on the given domainLocationId 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainLocationProfilesServiceV1ModelLocation</returns>
        public async System.Threading.Tasks.Task<DomainLocationProfilesServiceV1ModelLocation> LocationProfilesGetAsync(string domainLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Domain.Api.V1.Client.ApiResponse<DomainLocationProfilesServiceV1ModelLocation> localVarResponse = await LocationProfilesGetWithHttpInfoAsync(domainLocationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get location data based on the given domainLocationId 
        /// </summary>
        /// <exception cref="Domain.Api.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainLocationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainLocationProfilesServiceV1ModelLocation)</returns>
        public async System.Threading.Tasks.Task<Domain.Api.V1.Client.ApiResponse<DomainLocationProfilesServiceV1ModelLocation>> LocationProfilesGetWithHttpInfoAsync(string domainLocationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'domainLocationId' is set
            if (domainLocationId == null)
                throw new Domain.Api.V1.Client.ApiException(400, "Missing required parameter 'domainLocationId' when calling ProfilesApi->LocationProfilesGet");


            Domain.Api.V1.Client.RequestOptions localVarRequestOptions = new Domain.Api.V1.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };


            var localVarContentType = Domain.Api.V1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Domain.Api.V1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("domainLocationId", Domain.Api.V1.Client.ClientUtils.ParameterToString(domainLocationId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<DomainLocationProfilesServiceV1ModelLocation>("/v1/locations/profiles/{domainLocationId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LocationProfilesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}