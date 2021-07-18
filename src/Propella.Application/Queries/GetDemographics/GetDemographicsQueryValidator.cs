using FluentValidation;

namespace Propella.Application.Queries.GetDemographics
{
    public class GetDemographicsQueryValidator : AbstractValidator<GetDemographicsQuery>
    {
        public GetDemographicsQueryValidator()
        {
            RuleFor(q => q.SomeVar)
                .NotNull();
        }
    }
}
