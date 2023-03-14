using JetlinkChallengeAlgorithm.Dtos;
using JetlinkChallengeAlgorithm.Helper;
using Microsoft.AspNetCore.Mvc;

namespace JetlinkChallengeAlgorithm.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public IActionResult ConvertTextToNumeric([FromBody] InputDto userInput)
        {
            string result = ConvertHelper.ConvertToNumber(userInput.UserText);

            return new JsonResult(new InputDto()
            {
                UserText = result,
            });
        }
    }
}