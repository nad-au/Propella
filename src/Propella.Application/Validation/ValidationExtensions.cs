using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using Propella.Application.Results;

namespace Propella.Application.Validation
{
    public static class ValidationExtensions
    {
        public static IRuleBuilderOptions<T, TProperty> WithError<T, TProperty>(
            this IRuleBuilderOptions<T, TProperty> options, Error error) {
            return options.Configure(rule => {
                rule.Current.ErrorCode = error.Code;
                if (error.Message != null)
                    rule.Current.SetErrorMessage(error.Message);
            });
        }

        public static void AddValidationFailures(this IHaveErrors errors, ValidationResult validationResult)
        {
            foreach (var validationFailure in validationResult.Errors)
            {
                errors.AddValidationFailure(validationFailure);
            }
        }
        
        public static void AddValidationFailure(this IHaveErrors errors, ValidationFailure failure) => 
            errors.Errors.Add(failure.AsError());

        public static ICollection<Error> AsErrors(this ValidationResult validationResult) => 
            validationResult.Errors.Select(validationFailure => validationFailure.AsError()).ToList();

        public static Error AsError(this ValidationFailure failure) => new()
        {
            Code = failure.ErrorCode,
            Message = failure.ErrorMessage,
            Field = failure.PropertyName,
            Level = failure.CustomState is ErrorLevel errorLevel ? errorLevel : ErrorLevel.Error
        };
    }
}