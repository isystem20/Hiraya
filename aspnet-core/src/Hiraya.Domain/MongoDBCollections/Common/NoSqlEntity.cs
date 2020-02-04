using Abp.Domain.Entities;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Common
{
    public class NoSqlEntity : Entity<ObjectId>
    {
        public RecordStatus Status { get; set; }
    }
}
