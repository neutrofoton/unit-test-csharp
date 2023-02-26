using System;
using System.Threading.Tasks;
using NeutroLab.BusinessLogic.Models;

namespace NeutroLab.BusinessLogic.Services
{
    public interface ILogins
    {
        Task CreateUser(string email, string password);
        Task<User> GetUser(string email);
    }
}

