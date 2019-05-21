using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Context;
using DataAccessContracts.Interface.DataAccess;
using Entities.ControleAcesso;
using Exceptions.DataAccessExceptions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DataAccess.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationContext _ctx;

        public AuthRepository(ApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public User FindUser(string userName, string password)
        {
            var user = (from c in _ctx.Users
                        join l in _ctx.Login on c.ID equals l.UserID
                        where c.Email == userName && l.Password == password
                        select c).FirstOrDefault();

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}