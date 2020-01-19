using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// Bank accounts registered by the tax paying entities to use through bank transfer.
    /// </summary>
    public class BankAccount
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public long UserId { get; set; }


    }
}
