namespace _9.Decorator.Decorators
{
    using Interfaces;

    public abstract class BaseDecorator : IValidator
    {
        protected IValidator Validator;

        protected BaseDecorator(IValidator validator)
        {
            this.Validator = validator;
        }

        public abstract bool Validate(string input);
    }
}
