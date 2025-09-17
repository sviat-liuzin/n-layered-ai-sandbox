using AutoMapper;
using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Application.Map.Dto;

public class MyMapMappingProfile : Profile
{
    public MyMapMappingProfile()
    {
        CreateMap<MyMap, MyMapDto>()
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.MapData, opt => opt.MapFrom(src => src.MapData))
            .ForMember(dest => dest.LastReportedTemperatureC, opt => opt.MapFrom(src => src.LastReportedTemperatureC));
    }
}