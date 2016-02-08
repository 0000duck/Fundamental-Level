namespace _9.Decorator.Validators
{
    using Interfaces;

    public class LengthValidator : IValidator
    {
        private IValidator validator;
        private int minLength;
        private int maxLength;

        public LengthValidator(int minLength, int maxLength, IValidator validator)
        {

        }

        public bool Validate(string input)
        {
            if (this.validator.Validate(input))
            {
                return input.Length >= this.minLength && input.Length <= this.maxLength;
            }

            return false;
        }
    }
}