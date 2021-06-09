using FluentAssertions;
using hello_world_api.Controllers;
using Xunit;

namespace hello_world_api_tests.Controllers
{
    public class Option2ControllerTests
    {
        [Fact]
        public void ReverseTest()
        {
            var controller = new Option2Controller();
            var output = controller.ReverseWord("asdf");
            output.Should().Be("fdsa");
        }
    }
}
