using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Hiraya.Controllers
{
    public abstract class HirayaControllerBase: AbpController
    {
        protected HirayaControllerBase()
        {
            LocalizationSourceName = HirayaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
