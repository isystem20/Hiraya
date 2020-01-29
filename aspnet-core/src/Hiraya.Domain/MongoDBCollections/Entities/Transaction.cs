using Abp.Domain.Entities.Auditing;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// The lists of transactions, Status will be the critical points.
    /// 
    /// </summary>
    public class Transaction : AuditedEntity // AuditedEntity should have CreatAt/ModifiedAt/CreatedBy/ModifiedBy
    {
        public string ReferenceNumber { get; set; } //This must be given to taxpayer who submit their transaction to BIR
        public string Description { get; set; }
        public string UserId { get; set; }
        public Status Status { get; set; }
    }
}
