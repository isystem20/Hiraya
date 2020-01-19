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
    /// Personal details and profile of tax payer
    /// </summary>
    public class TaxpayerProfile
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastNmae { get; set; }
    }
}
