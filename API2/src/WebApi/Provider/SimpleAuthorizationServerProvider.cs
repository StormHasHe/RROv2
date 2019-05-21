﻿using Contracts.DTO;
using Contracts.Interface.Service;
using Exceptions.BusinessExceptions;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApi.Provider
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private IAuthService _authService;

        public SimpleAuthorizationServerProvider()
        {
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            UserDTO user;

            try
            {
                using (var scope = System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver.BeginScope())
                {
                    _authService = scope.GetService(typeof(IAuthService)) as IAuthService;
                    user = _authService.FindUser(context.UserName, context.Password);
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("sub", context.UserName));
                identity.AddClaim(new Claim("role", "user"));

                context.Validated(identity);
            }
            catch(WrongLoginOrPasswordException ex)
            {
                context.SetError("invalid_grant", ex.Message);
            }
        }
    }
}