using Abp.Domain.Entities.Auditing;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// This will be the entity for each ticket/messages submitted to/from BIR.
    /// </summary>
    public class Post : AuditedEntity
    {
        public string ParentId { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public PostType PostType { get; set; }
        public string IsRead { get; set; }

    }
}
