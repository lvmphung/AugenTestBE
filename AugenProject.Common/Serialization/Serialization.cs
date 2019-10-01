using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AugenProject.Common.Serialization
{
    public class SerializationHelper : ISerialization
    {
        public T DeserializeJsonToObject<T>(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
                throw new ArgumentNullException("Can not deserialize " + jsonString);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public T ToObject<T>(object obj)
        {
            return JObject.FromObject(obj).ToObject<T>();
        }
    }
}