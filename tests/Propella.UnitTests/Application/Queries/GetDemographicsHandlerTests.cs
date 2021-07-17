using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Propella.Application.Interfaces;
using Propella.Application.Queries;

namespace Propella.UnitTests.Application.Queries
{
    public class GetDemographicsHandlerTests
    {
        private GetDemographics.GetDemographicsHandler Sut => new(DemographicsService);
        
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
            var result = await Sut.Handle(new GetDemographics(), CancellationToken.None);

            // Assert
            result.Data.Should().Be(2);
        }
    }
}