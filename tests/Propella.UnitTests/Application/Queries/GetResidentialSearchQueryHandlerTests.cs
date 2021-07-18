using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Propella.Application.Interfaces;
using Propella.Application.Queries;
using Propella.Application.Queries.GetResidentialSearch;

namespace Propella.UnitTests.Application.Queries
{
    public class GetResidentialSearchQueryHandlerTests
    {
        private GetResidentialSearchQuery.GetResidentialSearchQueryHandler Sut => new(ResidentialSearchService);
        
        private IResidentialSearchService ResidentialSearchService { get; set; }

        [SetUp]
        public void Setup()
        {
            ResidentialSearchService = Substitute.For<IResidentialSearchService>();
        }

        [Test]
        public async Task It_Should_Return_Correct_Count()
        {
            // Arrange
            ResidentialSearchService.GetCountAsync()
                .Returns(Task.FromResult(2));

            // Act
            var result = await Sut.Handle(new GetResidentialSearchQuery(), CancellationToken.None);

            // Assert
            result.Data.Should().Be(2);
        }
    }
}