using Abp.AutoMapper;
using Hiraya.Domain.MongoDBCollections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.BIR.BankAccounts.Dto
{
    [AutoMapTo(typeof(BankAccount))]
    public class CreateBankAccountDto
    {
        
    }
}
