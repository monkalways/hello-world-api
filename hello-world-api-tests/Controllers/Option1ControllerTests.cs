using FluentAssertions;
using hello_world_api.Controllers;
using Xunit;

namespace hello_world_api_tests.Controllers
{
    public class Option1ControllerTests
    {
        [Fact]
        public void GenerateRandomNumberTest()
        {
            var controller = new Option1Controller();
            var output = controller.GenerateRandomNumber(1, 10);
            output.Should().BeGreaterOrEqualTo(1);
            output.Should().BeLessOrEqualTo(10);
        }
    }
}
