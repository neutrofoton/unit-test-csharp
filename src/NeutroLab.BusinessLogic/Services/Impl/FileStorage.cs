using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NeutroLab.BusinessLogic.Services.Impl
{
    public class FileStorage : IFileStorage
    {
        public Task StoreFile(IFormFile file, string key)
        {
            throw new NotImplementedException();
        }
    }
}

