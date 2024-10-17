using static AmigaoAPI.Domain.Validacoes.DomainValidationsExeptions;

namespace AmigaoAPI.Domain.Validacoes
{
    public class DomainValidationsExeptions(string error) : Exception(error)
    {
        public class DomainValidationExeception : Exception
        {
            public DomainValidationExeception(string error) : base(error)
            {

            }
            public static void When(bool hasError, string message)
            {
                if (hasError)
                {
                    throw new DomainValidationExeception(message);
                }

            }
        }
    }
}
