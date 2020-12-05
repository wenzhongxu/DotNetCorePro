using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VODDY.Controllers
{
    public abstract class VODDYControllerBase: AbpController
    {
        protected VODDYControllerBase()
        {
            LocalizationSourceName = VODDYConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
