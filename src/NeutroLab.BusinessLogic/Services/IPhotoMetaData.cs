using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NeutroLab.BusinessLogic.Models;

namespace NeutroLab.BusinessLogic.Services
{
    public interface IPhotoMetaData
    {
        Task SavePhotoMetaData(string userName, string desciption, string fileName);
        Task<List<Photo>> GetUserPhotos(string userName);
    }
}

