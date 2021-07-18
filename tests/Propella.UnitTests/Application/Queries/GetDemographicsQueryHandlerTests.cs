using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Propella.Application.Interfaces;
using Propella.Application.Queries;
using Propella.Application.Queries.GetDemographics;

namespace Propella.UnitTests.Application.Queries
{
    public class GetDemographicsQueryHandlerTests
    {
        private GetDemographicsQuery.GetDemographicsQueryHandler Sut => new(DemographicsService);
        
        private IDemographicsService DemographicsService { get; set; }

        [SetUp]
        public void Setup()
        {
            DemographicsService = Substitute.For<IDemographicsService>();
        }

        [Test]
        public async Task It_Should_Return_Correct_Count()
        {
            // Arrange
            DemographicsService.GetCountAsync()
                .Returns(Task.FromResult(2));

            // Act
            var result = await Sut.Handle(new GetDemographicsQuery(5), CancellationToken.None);

            // Assert
            result.Data.Should().Be(2);
        }
    }
}