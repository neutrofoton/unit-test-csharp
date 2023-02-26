using System;
using System.Threading.Tasks;
using NeutroLab.BusinessLogic.Models;

namespace NeutroLab.BusinessLogic.Services.Impl
{
    public class Logins : ILogins
    {
        public Task CreateUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}

