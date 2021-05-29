using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Abp.Pdnf.Controllers
{
    public abstract class PdnfControllerBase: AbpController
    {
        protected PdnfControllerBase()
        {
            LocalizationSourceName = PdnfConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
