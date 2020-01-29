using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    public class UserAttachment : AuditedEntity
    {
        public string Attachments { get; set; }
        public int UserId { get; set; }
        public string Remarks { get; set; }
    }
}
