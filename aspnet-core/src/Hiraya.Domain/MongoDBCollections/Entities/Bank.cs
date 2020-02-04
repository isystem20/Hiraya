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
    /// Individual / Business Accounts of tax paying entity
    /// </summary>
    public class Bank
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        
    }
}
