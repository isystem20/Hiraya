using Abp.Application.Services;
using Abp.Authorization;
using Hiraya.Authorization;
using Hiraya.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.BIR.BankAccounts
{
    [AbpAuthorize(PermissionNames.BIR_BankAccounts)]
    public class BankAccountsAppService : IApplicationService
    {
        private readonly HirayaMongoDbContext _mongoData;



        public BankAccountsAppService(HirayaMongoDbContext mongoData)
        {
            _mongoData = mongoData;
        }


        


    }
}
