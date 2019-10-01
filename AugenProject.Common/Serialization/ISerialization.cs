using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugenProject.Common.Serialization
{
    public interface ISerialization
    {
        T DeserializeJsonToObject<T>(string jsonString);
        T ToObject<T>(object obj);
    }
}
