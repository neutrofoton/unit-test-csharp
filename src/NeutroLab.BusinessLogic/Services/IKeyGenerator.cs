using System;
namespace NeutroLab.BusinessLogic.Services
{
    public interface IKeyGenerator
    {
        string GetKey(string emailAddress);
    }
}

