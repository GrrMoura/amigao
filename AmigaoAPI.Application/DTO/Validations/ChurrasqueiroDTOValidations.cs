using FluentValidation;

namespace AmigaoAPI.Application.DTO.Validations
{
    internal class ChurrasqueiroDTOValidations : AbstractValidator<ChurrasqueiroDTO>
    {
        public ChurrasqueiroDTOValidations()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("ID do churrasqueiro precisa ser informado e deve ser um valor positivo");

            RuleFor(x => x.PrecoPorHora)
                .GreaterThan(0)
                .WithMessage("O preço por hora deve ser maior que zero");

            RuleFor(x => x.Disponibilidade)
                .NotNull()
                .WithMessage("A disponibilidade deve ser informada");

            RuleFor(x => x.AvaliacaoMedia)
                .InclusiveBetween(0, 5)
                .WithMessage("A avaliação média deve estar entre 0 e 5");
        }
    }
}
