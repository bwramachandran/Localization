using System.Linq;
using LocalizationTools.Model.DTO;
using LocalizationTools.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LocalizationTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocApiController : ControllerBase
    {
        private readonly ILogger m_logger;
        private readonly ILocAPIService m_locAPIService;
        public LocApiController(ILogger<LocApiController> logger, ILocAPIService locAPIService)
        {
            m_logger = logger;
            m_locAPIService = locAPIService;
        }
        public IActionResult EnglishStream()
        {
            EnglishStringPayload payload = new EnglishStringPayload();
            int pageNumber = 0;
            int pageSize = 1;
            if (ModelState.IsValid)
            {
                var result = m_locAPIService.GetAllEnglishString(payload, pageNumber, pageSize);
                return Ok(result);
            }
            else
            {
                string messages = string.Join(",", ModelState.Values
                                                        .SelectMany(x => x.Errors)
                                                        .Select(x => x.ErrorMessage));
                m_logger.LogError("Error in Payload: {0}", messages);
                return BadRequest();
            }
        }
    }     
}
