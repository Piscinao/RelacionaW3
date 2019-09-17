using System.Linq;
using AutoMapper;
using RelacionaW3.API.Dtos;
using RelacionaW3.Dominio;
using RelacionaW3.Dominio.Identity;

namespace RelacionaW3.API.Helpers {
    
    public class AutoMapperProfiles : Profile 
    {
        public AutoMapperProfiles(){
        //domínio classe e - "view"
        CreateMap<Evento, EventoDto>()
        .ForMember(dest => dest.Palestrantes, opt => {
        opt.MapFrom(src => src.PalestrantesEventos.Select(x => x.Palestrante).ToList());

        });

        CreateMap<EventoDto, Evento>();
        //any para any
        CreateMap<Palestrante, PalestranteDto>()
        .ForMember(dest => dest.Eventos, opt => {
        opt.MapFrom(src => src.PalestrantesEventos.Select(x => x.Evento).ToList());
        
        });

        CreateMap<Lote, LoteDto>().ReverseMap();
      
        CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();

        CreateMap<User, UserLoginDto>().ReverseMap();
      
        }

    }
} 