using System;
using System.IO;
using RotRut.Begaran;
using Xunit;

namespace RotRut.Tests
{
    public class SerializationTest
    {
        [Fact]
        public void Serialize()
        {
            var begaran = new BegaranFil()
            {

            };

            using var stream = File.OpenWrite(Path.Combine("Begaran.xml"));
            RotRutBegaran.Serialize(stream, begaran);
        }

        [Fact]
        public void Deserialize()
        {
            using var stream = File.OpenRead(Path.Combine("Begaran.xml"));
            var begaran = RotRutBegaran.Deserialize(stream);
        }
    }
}
