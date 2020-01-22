using Abp.Domain.Entities;
using Hiraya.Domain.MongoDBCollections.Common;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    public class Notice : AuditedEntity
    {
        public NoticeType NoticeType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool isPublic { get; set; }
        public DateTime DisplayStart { get; set; }
        public DateTime DisplayEnd { get; set; }
    }
}
