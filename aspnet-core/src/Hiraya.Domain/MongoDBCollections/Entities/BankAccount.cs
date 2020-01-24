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
        public long TaxpayerProfileId { get; set; } //??
        public long BankId { get; set; } //BPI, GCash, UnionBank, etc.

        // Note: details should be encrypted
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; } //MM/YY
        public string CVV { get; set; }

        public Boolean CardVerified { get; set; }

    }
}
