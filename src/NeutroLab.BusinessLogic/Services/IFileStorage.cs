using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NeutroLab.BusinessLogic.Services
{
    public interface IFileStorage
    {
        Task StoreFile(IFormFile file, string key);
    }
}

