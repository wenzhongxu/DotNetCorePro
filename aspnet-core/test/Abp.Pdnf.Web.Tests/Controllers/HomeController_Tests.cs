using System.Threading.Tasks;
using Abp.Pdnf.Models.TokenAuth;
using Abp.Pdnf.Web.Controllers;
using Shouldly;
using Xunit;

namespace Abp.Pdnf.Web.Tests.Controllers
{
    public class HomeController_Tests: PdnfWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}