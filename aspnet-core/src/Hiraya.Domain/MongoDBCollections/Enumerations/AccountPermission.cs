using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    /// <summary>
    /// Classification of access permission given to the user to particular TaxpayerAccount
    /// </summary>
    public enum AccountPermission
    {
        Owned = 100,
        Delegated = 200
    }
}
