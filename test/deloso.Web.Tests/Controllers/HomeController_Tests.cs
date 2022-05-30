using System.Threading.Tasks;
using deloso.Models.TokenAuth;
using deloso.Web.Controllers;
using Shouldly;
using Xunit;

namespace deloso.Web.Tests.Controllers
{
    public class HomeController_Tests: delosoWebTestBase
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