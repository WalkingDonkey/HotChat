using AutoMapper;
using HotChat.BO;
using HotChat.Common;
using HotChat.DTO;
using HotChat.PO.Mongo;

namespace HotChat.Framework.Utility
{
   public static class AutoMapperConfiguration
   {
      public static void ConfigureAutoMapper()
      {
         Mapper.CreateMap<UserBO, UserDTO>();
         Mapper.CreateMap<UserDTO, UserBO>();
         Mapper.CreateMap<UserBO, UserPO>();
         Mapper.CreateMap<UserPO, UserBO>();
         Mapper.CreateMap<RemarkDTO, Remark>();
         Mapper.CreateMap<RemarksBO, RemarksDTO>();
      }
   }

   public static class Mapping
   {
      public static TTo Map<TFrom, TTo>(this TFrom from)
      {
         return Mapper.Map<TTo>(from);
      }

      //public static Remark RemarkBO2Remark<RemarkBO, Remark>(this RemarkBO remarkBO)
      //{
      //   Mapper.Map<Remark>(remarkBO).;
      //}
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
