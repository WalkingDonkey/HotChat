﻿using MongoDB.Bson.Serialization.Attributes;

namespace HotChat.DAO
{
    public class User
    {
        [BsonId]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}