using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum RecordStatus
    {
        Active = 1,
        Updated = 2,
        Deleted = 0,
        Archived = 3
    }
}
