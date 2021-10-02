using System;
using System.Collections.Generic;
using System.Text;

namespace MuviApp.Services
{
    public interface IJsonSerializerService
    {
        string Serialize(object payload);
        T Deserialize<T>(string payload);
    }
}
