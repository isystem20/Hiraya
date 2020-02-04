using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Common
{
    public class AuditedEntity : Entity<string>, IAudited
    {
        //Audit Creation
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        //Audit Modification
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }


    }
}
