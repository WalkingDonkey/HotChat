using AutoMapper;
using HotChat.BO;
using HotChat.DataContract.DTO;

namespace HotChat.Framework.Utility
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureAutoMapper()
        {
            Mapper.CreateMap<UserBO, UserDTO>();
            Mapper.CreateMap<UserDTO, UserBO>();
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
    }
}
