using Hiraya.Domain.MongoDBCollections.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// This will clasify the products or services of the particular business account which will help identify automatically the tax types linked to each account.
    /// </summary>
    public class BusinessPurpose : AuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
