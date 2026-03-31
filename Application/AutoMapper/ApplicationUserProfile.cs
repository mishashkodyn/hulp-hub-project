using Application.DTOs.User;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile() 
        {
            CreateMap<ApplicationUser, UserProfileDto>()
            .ForMember(dest => dest.UserCategory, opt => opt.MapFrom(src => (int)src.UserCategory))
            .ForMember(dest => dest.Roles, opt => opt.Ignore())
            .ReverseMap()
            .ForMember(dest => dest.UserCategory, opt => opt.MapFrom(src => (UserCategory)src.UserCategory));
        }
    }
}
