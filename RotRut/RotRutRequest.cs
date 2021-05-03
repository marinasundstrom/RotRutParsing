using System.IO;
using System.Xml.Serialization;
using RotRut.Export;

namespace RotRut
{
    public static class RotRutRequest
    {
        static XmlSerializer serializer = new XmlSerializer(typeof(Begaran));
        
        public static Begaran Deserialize(Stream stream) 
        {
            return (Begaran)serializer.Deserialize(stream);
        }

        public static void Serialize(Stream stream, Begaran begaran) 
        {
            serializer.Serialize(stream, begaran);
        }
    }
}
