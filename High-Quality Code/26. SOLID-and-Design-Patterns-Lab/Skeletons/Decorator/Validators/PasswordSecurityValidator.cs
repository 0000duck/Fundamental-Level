namespace _9.Decorator.Validators
{
    using Interfaces;

    public class PasswordSecurityValidator : IValidator
    {
        public PasswordSecurityValidator(IValidator validator)
        {
            
        }

        public bool Validate(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}