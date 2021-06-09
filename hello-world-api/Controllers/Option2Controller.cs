using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;

namespace hello_world_api.Controllers
{
    [ApiController]
    public class Option2Controller : ControllerBase
    {
        [HttpGet("/reverse-word")]
        public string ReverseWord(string word)
        {
            StringBuilder output = new StringBuilder();
            for (int i = word.Length; i > 0; i--)
            {
                output.Append(word.ElementAt(i - 1));
            }
            return output.ToString();
        }
    }
}
