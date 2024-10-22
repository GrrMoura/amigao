using FluentValidation;

namespace AmigaoAPI.Application.DTO.Validations
{
    internal class UsuarioDTOValidations : AbstractValidator<UsuarioDTO>
    {
        public UsuarioDTOValidations()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("ID precisa ser informado e deve ser um valor positivo");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Nome precisa ser informado")
                .MaximumLength(100)
                .WithMessage("Nome não pode ter mais que 100 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("O e-mail precisa ser informado.")
                .EmailAddress()
                .WithMessage("O e-mail informado não é válido.")
                .MaximumLength(100)
                .WithMessage("O e-mail não pode ter mais que 100 caracteres.");

            RuleFor(x => x.IsCliente)
                .Must(x => x == true || x == false)
                .WithMessage("É necessário definir se o usuário é Cliente.");

            RuleFor(x => x.IsChurrasqueiro)
                .Must(x => x == true || x == false)
                .WithMessage("É necessário definir se o usuário é Churrasqueiro.");

            RuleForEach(x => x.Reservas)
                .SetValidator(new ReservaDTOValidations())  // Valida cada reserva associada
                .WithMessage("Erro nas reservas associadas.");
        }
    }
}
