using System.Threading.Tasks;
using VODDY.Models.TokenAuth;
using VODDY.Web.Controllers;
using Shouldly;
using Xunit;

namespace VODDY.Web.Tests.Controllers
{
    public class HomeController_Tests: VODDYWebTestBase
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