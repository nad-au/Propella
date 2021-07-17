using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Api.V2.Api;
using Domain.Api.V2.Model;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Propella.Infrastructure.Services.Integrations.Domain;

namespace Propella.UnitTests.Infrastructure.Services.Integrations.Domain
{
    public class DemographicsServiceTests
    {
        private DemographicsService Sut => new(DemographicsApi);
        
        private IDemographicsApiAsync DemographicsApi { get; set; }

        [SetUp]
        public void Setup()
        {
            DemographicsApi = Substitute.For<IDemographicsApiAsync>();
        }

        private static DemographicsV1DemographicsResults GoodResults => new()
        {
            Demographics = new List<DemographicsV1Demographics>
            {
                new("Type1", 3, 2000),
                new("Type2", 4, 1980),
            }
        };

        [Test]
        public async Task It_Should_Return_Correct_Count()
        {
            // Arrange
            DemographicsApi.DemographicsGetByNamedSuburbAsync(default, default, default)
                .ReturnsForAnyArgs(Task.FromResult(GoodResults));
            
            // Act
            var result = await Sut.GetCountAsync();

            // Assert
            result.Should().Be(2);
        }
    }
}