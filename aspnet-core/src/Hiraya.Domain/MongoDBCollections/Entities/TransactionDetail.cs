using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    public class TransactionDetail : AuditedEntity
    {
        public string TransactionId { get; set; }

        //nde ku pa mapicture out yung ibang details
    }
}
