using AmigaoAPI.Application.DTO;
using AmigaoAPI.Domain.Modelos;
using AutoMapper;

namespace Amigao.Api.Application.Mapeamento
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<UsuarioDTO, Usuario>();
            
            //CreateMap<UsuarioUpdateDTO, User>()
            //    .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
            //    .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}
