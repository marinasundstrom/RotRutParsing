using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace RotRut
{
    public static class RotRutRequest
    {
        static XmlSerializer serializer = new XmlSerializer(typeof(RotRut.Begaran.BegaranFil));

        public static RotRut.Begaran.BegaranFil Deserialize(Stream stream)
        {
            return (RotRut.Begaran.BegaranFil)serializer.Deserialize(stream);
        }

        public static void Serialize(Stream stream, RotRut.Begaran.BegaranFil begaran)
        {
            serializer.Serialize(stream, begaran);
        }

        public static bool Validate(RotRut.Begaran.BegaranFil begaran, ICollection<ValidationResult> results)
        {
            var validationContext = new ValidationContext(begaran);
            return Validator.TryValidateObject(begaran, validationContext, results, true);
        }
    }
}
