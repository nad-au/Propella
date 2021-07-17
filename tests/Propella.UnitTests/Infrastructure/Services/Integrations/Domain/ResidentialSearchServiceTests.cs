using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Api.V1.Client.Model;
using Domain.Api.V1.Client.Api;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Propella.Infrastructure.Services.Integrations.Domain;

namespace Propella.UnitTests.Infrastructure.Services.Integrations.Domain
{
    public class ResidentialSearchServiceTests
    {
        private ResidentialSearchService Sut => new(ListingsApi);
        
        private IListingsApiAsync ListingsApi { get; set; }

        [SetUp]
        public void Setup()
        {
            ListingsApi = Substitute.For<IListingsApiAsync>();
        }

        private static List<DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult> GoodResults =>
            new()
            {
                new DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult(DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult.TypeEnum.Project),
                new DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult(DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult.TypeEnum.PropertyListing),
            };

        [Test]
        public async Task It_Should_Return_Correct_Count()
        {
            ListingsApi.ListingsDetailedResidentialSearchAsync(default)
                .ReturnsForAnyArgs(Task.FromResult(GoodResults));
            
            var result = await Sut.GetCountAsync();

            result.Should().Be(2);
        }
    }
}