using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeutroLab.BusinessLogic.Services;
using NeutroLab.Web.Controllers;
using NeutroLab.Web.Models;
using System.Text;

namespace NeutroLab.Web.Test
{
    public class PhotosTests
    {
        [Fact]
        public async Task Upload__GivenFileName_ReturnsDisplayAction()
        {
            // Arrange
            var session = Mock.Of<ISession>();
            session.Set("User", Encoding.UTF8.GetBytes("a@b.com"));
            var context = Mock.Of<HttpContext>(x => x.Session == session);
            var accessor = Mock.Of<IHttpContextAccessor>(x => x.HttpContext == context);

            var fileStorage = Mock.Of<IFileStorage>();
            var keyGen = Mock.Of<IKeyGenerator>();
            var photoMetadata = Mock.Of<IPhotoMetaData>();

            var fromFile = Mock.Of<IFormFile>();
            var model = Mock.Of<PhotoUploadViewModel>(x => x.File == fromFile);

            var controller = new PhotosController(keyGen, accessor, photoMetadata, fileStorage);

            //Act
            var result = await controller.Upload(model) as RedirectToActionResult;

            //Assert
            Assert.Equal("Display", result.ActionName, ignoreCase: true);
        }
    }
}

