using AutoMapper;
using WebAPICurrentAccount.Dto;
using WebAPICurrentAccount.Models;

namespace WebAPICurrentAccount.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper() {

            CreateMap<User, UserListarDto>();
        }
    }
}
