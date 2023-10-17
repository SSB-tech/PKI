using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PKI__Public_Key_Infrastructure_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PKIController : ControllerBase
    {
        [HttpGet]
        [Route("nocertificate")]
        public string Message()
        {
            return "Success";
        }

        [HttpGet]
        [Authorize]
        [Route("certificate")]
        public string Certificate()
        {
            return "Success";
        }
    }
}
