using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RotRut.Validation
{
    public class ValidateObjectAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (value is IEnumerable enumerable)
            {
                return ValidateEnumerable(validationContext, enumerable);
            }
            else
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(value, null, null);

                Validator.TryValidateObject(value, context, results, true);

                if (results.Count != 0)
                {
                    var compositeResults = new CompositeValidationResult(String.Format("Validation for {0} failed!", validationContext.DisplayName));
                    results.ForEach(compositeResults.AddResult);

                    return compositeResults;
                }

                return ValidationResult.Success;
            }
        }

        private static ValidationResult ValidateEnumerable(ValidationContext validationContext, IEnumerable enumerable)
        {
            var compositeResults = new CompositeValidationResult(String.Format("Validation for {0} failed!", validationContext.DisplayName));

            foreach (object item in enumerable)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(item, null, null);

                Validator.TryValidateObject(item, context, results, true);

                if (results.Count != 0)
                {
                    results.ForEach(compositeResults.AddResult);
                }
            }

            if (compositeResults.Results.Any())
            {
                return compositeResults;
            }

            return ValidationResult.Success;
        }
    }
}