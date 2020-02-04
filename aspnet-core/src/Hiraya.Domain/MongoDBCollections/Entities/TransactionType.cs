using Abp.Domain.Entities.Auditing;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// The list of all transaction types
    /// </summary>
    public class TransactionType : AuditedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
