using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Common
{
    public class FullAudited : Entity<string>, IFullAudited
    {
        //Audit Creation
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        //Audit Modification
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        //Audit Delete
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
