using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    /// <summary>
    /// This will clasify the type of Payment Account.
    /// </summary>
    public enum PaymentAccountType
    {
        BankAccount = 1,
        PaymentService = 2,
        Card = 3,
        Cash = 4
    }
}
