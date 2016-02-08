namespace _9.Decorator.Validators
{
    using Interfaces;

    public class AlphanumericValidator : IValidator
    {
        public AlphanumericValidator(IValidator validator)
        {

        }

        public bool Validate(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}