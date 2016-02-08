using SharpCompiler.Exceptions;

namespace SharpCompiler.ValidationStrategies
{
    public class SystemNetValidator
    {
        public void Validate(string code)
        {
            if (!code.Contains("using System.Net;"))
            {
                throw new CompilationException("Code does not contain 'using System.Net'");
            }
        }
    }
}