namespace Juniper.Core.Interfaces
{
    public abstract class ABaseHasRequiredObject : BaseHasRemoveablesViewModel
    {
        public ABaseHasRequiredObject():base()
        {
        }
        public static ValidationErrorModel? GetValidationErrorsString(object o)
        {
            ValidationContext context = new(o, serviceProvider: null, items: null);
            List<ValidationResult> results = new();
            bool isValid = Validator.TryValidateObject(o, context, results, true);
            if (isValid == false)
            {
                if(o is BaseAddressModel bad)
                {
                    if (bad.SelectedAddressTypeCode == "SF")
                        return null;
                }

                StringBuilder sbrErrors = new();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }

                return new ValidationErrorModel() { Error = sbrErrors.ToString() };
            }

            return null;
        }

        public override Task OnCommandActivated(string? commandParam)
        {
            throw new NotImplementedException();
        }
    }
}
