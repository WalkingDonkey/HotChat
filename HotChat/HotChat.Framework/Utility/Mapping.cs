using AutoMapper;
using HotChat.BO;
using HotChat.DAO;
using HotChat.DTO;

namespace HotChat.Framework.Utility
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureAutoMapper()
        {
            Mapper.CreateMap<UserBO, UserDTO>();
            Mapper.CreateMap<UserDTO, UserBO>();
            Mapper.CreateMap<UserBO, User>();
            Mapper.CreateMap<User, UserBO>();
        }
    }

    public static class Mapping
    {
        public static UserBO TOBO(this UserDTO userDTO)
        {
            return Mapper.Map<UserBO>(userDTO);
        }

        public static UserDTO TODTO(this UserBO userBO)
        {
            return Mapper.Map<UserDTO>(userBO);
        }

        public static UserBO TOBO(this User user)
        {
            return Mapper.Map<UserBO>(user);
        }

        public static User TODAO(this UserBO userBO)
        {
            return Mapper.Map<User>(userBO);
        }
    }
}
