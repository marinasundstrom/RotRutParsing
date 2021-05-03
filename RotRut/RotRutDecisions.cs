using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using RotRut.Export;
using RotRut.Import;

namespace RotRut
{
    public static class RotRutDecisions
    {
        public static BeslutsFil Deserialize(string str) 
        {
            var options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString |
                JsonNumberHandling.WriteAsString
            };

            return JsonSerializer.Deserialize<Import.BeslutsFil>(str, options);
        }

        public static string Serialize(BeslutsFil besluts) 
        {
            var options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString |
                JsonNumberHandling.WriteAsString
            };

            return JsonSerializer.Serialize(besluts, options);
        }
    }
}
