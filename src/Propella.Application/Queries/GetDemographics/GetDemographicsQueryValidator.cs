using FluentValidation;
using Propella.Application.Results;
using Propella.Application.Validation;

namespace Propella.Application.Queries.GetDemographics
{
    public class GetDemographicsQueryValidator : AbstractValidator<GetDemographicsQuery>
    {
        public GetDemographicsQueryValidator()
        {
            RuleFor(q => q.SomeVar)
                .NotNull()
                .WithError(Err.NotNull())
                .WithState(q => ErrorLevel.Critical);
        }
    }
}
