using FluentValidation;

namespace AmigaoAPI.Application.DTO.Validations
{
    internal class ReservaDTOValidations : AbstractValidator<ReservaDTO>
    {
        public ReservaDTOValidations()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("ID da reserva precisa ser informado e deve ser um valor positivo");

            RuleFor(x => x.IdUsuario)
                .GreaterThan(0)
                .WithMessage("ID do cliente precisa ser informado e deve ser um valor positivo");

            RuleFor(x => x.IdChurrasqueiro)
                .GreaterThan(0)
                .WithMessage("ID do churrasqueiro precisa ser informado e deve ser um valor positivo");

            RuleFor(x => x.DataReserva)
                .GreaterThan(DateTime.Now)
                .WithMessage("A data da reserva deve ser no futuro");

            RuleFor(x => x.Status)
                .NotEmpty()
                .WithMessage("O status da reserva deve ser informado");

            
            RuleFor(x => x.Nota)
                .InclusiveBetween(0, 5)
                .WithMessage("A nota deve estar entre 0 e 5");

            RuleFor(x => x.Comentario)
                .MaximumLength(500)
                .WithMessage("O comentário não pode ter mais que 500 caracteres");
        }
    }
}
