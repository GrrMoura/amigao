using AmigaoAPI.Application.DTO;
using AmigaoAPI.Domain.Modelos;
using AutoMapper;

namespace Amigao.Api.Application.Mapeamento
{

    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<Usuario, UsuarioDTO>();

            //CreateMap<UsuarioUpdateDTO, User>()
            //    .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
            //    .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));}


        }
    }
}
