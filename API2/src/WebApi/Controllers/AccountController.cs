using Contracts.DTO;
using Contracts.Interface.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : BaseApiController
    {
        [Authorize]
        [Route("ValidateToken")]
        [HttpGet]
        public IHttpActionResult ValidateToken()
        {
            return Ok();
        }
    }
}
