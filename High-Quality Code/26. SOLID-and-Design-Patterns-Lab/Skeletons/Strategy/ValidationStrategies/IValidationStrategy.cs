namespace SharpCompiler.ValidationStrategies
{
    public interface IValidationStrategy
    {
        void Validate(string code);
    }
}