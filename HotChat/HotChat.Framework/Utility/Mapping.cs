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
         Mapper.CreateMap<UserBO, UserDAO>();
         Mapper.CreateMap<UserDAO, UserBO>();
         Mapper.CreateMap<RemarkDTO, RemarkBO>();
      }
   }

   public static class Mapping
   {
      public static TTo Map<TFrom, TTo>(this TFrom userDTO)
      {
         return Mapper.Map<TTo>(userDTO);
      }

      //public static UserDTO TODTO(this UserBO userBO)
      //{
      //    return Mapper.Map<UserDTO>(userBO);
      //}

      //public static UserBO TOBO(this User user)
      //{
      //    return Mapper.Map<UserBO>(user);
      //}

      //public static User TODAO(this UserBO userBO)
      //{
      //    return Mapper.Map<User>(userBO);
      //}
   }
}
