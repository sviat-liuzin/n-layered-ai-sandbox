using AutoMapper;
using RedPanda.NLayered.Domain;

namespace RedPanda.NLayered.Application.Map.Dto;

public class MyMapMappingProfile : Profile
{
    public MyMapMappingProfile()
    {
        CreateMap<MyMap, MyMapDto>()
            .ForMember(dest => dest.CurrentForecast, opt => opt.MapFrom(src => src.CurrentForecast));
    }
}