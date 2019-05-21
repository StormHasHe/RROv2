using Contracts.DTO;
using Contracts.Interface.Service;
using Exceptions.DataAccessExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/Aulas")]
    public class AuthController : ApiController
    {
        IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

    }
}
