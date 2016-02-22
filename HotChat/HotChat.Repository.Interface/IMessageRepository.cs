namespace HotChat.Repository.Interface
{
   using HotChat.BO;
   using System.Collections.Generic;

   public interface IMessageRepository
   {
      void AddMessage(string userId, MessageBO messageBO);

      IEnumerable<MessageBO> GetMessages(string userId);
   }
}
