using Hiraya.Domain.MongoDBCollections.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// This will be the Tax Type for the tax payments.
    /// </summary>
    public class TaxType : AuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
