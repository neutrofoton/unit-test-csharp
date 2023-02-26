using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NeutroLab.BusinessLogic.Models;

namespace NeutroLab.BusinessLogic.Services.Impl
{
    public class PhotoMetaData : IPhotoMetaData
    {
        public Task<List<Photo>> GetUserPhotos(string userName)
        {
            throw new NotImplementedException();
        }

        public Task SavePhotoMetaData(string userName, string desciption, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}

