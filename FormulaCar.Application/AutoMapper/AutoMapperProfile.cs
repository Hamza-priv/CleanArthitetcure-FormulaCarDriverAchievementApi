using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormulaCar.Application.DTOS.Request;
using FormulaCar.Application.DTOS.Response;
using FormulaCar.Domain.Model;

namespace FormulaCar.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AchievementRequestDto, Achievement>()
                .ForMember(dest => dest.status, op => op.MapFrom(src => 1))
                .ForMember(dest => dest.createdDate, op => op.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.updatedDate, op => op.MapFrom(src => DateTime.UtcNow));

            CreateMap<UpdateAchievementRequestDto, Achievement>()
                .ForMember(dest => dest.updatedDate, op => op.MapFrom(src => DateTime.UtcNow));

            CreateMap<Achievement, AchievementResponeDto>();

            CreateMap<Driver, DriverResponseDto>()
                .ForMember(dest => dest.FullName, op => op.MapFrom(src => $"{src.firstName} {src.lastName}"));

            CreateMap<CreateDriverRequestDto, Driver>()
                .ForMember(dest => dest.status, op => op.MapFrom(src => 1))
                .ForMember(dest => dest.createdDate, op => op.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.updatedDate, op => op.MapFrom(src => DateTime.UtcNow));

            CreateMap<UpdateDriverRequestDTO, Driver>()
                .ForMember(dest => dest.updatedDate, op => op.MapFrom(src => DateTime.UtcNow));

            CreateMap<Achievement, Achievement>();
        }
    }
}