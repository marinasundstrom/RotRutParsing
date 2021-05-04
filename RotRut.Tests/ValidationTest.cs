using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using RotRut.Begaran;
using Xunit;

namespace RotRut.Tests
{
    public class ValidationTest
    {
        [Fact]
        public void Validate()
        {
            var begaran = new BegaranFil()
            {
                HushallBegaran = new Begaran.Rut.HushallBegaran
                {
                    Arenden = new[]
                    {
                        new Begaran.Rut.HushallBegaranArenden
                        {
                            Kopare = "ddd"
                        }
                    }
                }
            };

            List<ValidationResult> validationResults = new List<ValidationResult>();
            RotRutBegaran.Validate(begaran, validationResults);
        }
    }
}
