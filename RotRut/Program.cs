using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RotRut.Export;

namespace RotRut
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ExportRequest();
        }

        private static async Task ExportRequest()
        {
            var begaran1 = new Begaran()
            {
                NamnPaBegaran = "Foo",
                RotBegaran = new RotBegaran()
                {
                    Arenden = new RotBegaranArenden[] {
                        new() {
                            BetalningsDatum = DateTime.Now.Date,
                            FakturaNr = 1234,
                            Kopare = "195705277860",
                            BetaltBelopp = 2500,
                            BegartBelopp = 1250,
                            Fastighetsbeteckning = "",
                            LagenhetsNr = 1234,
                            BrfOrgNr = "232445",
                            UtfortArbete = new RotBegaranArendenUtfortArbete() {
                                Bygg = new RotBegaranArendenUtfortArbeteBygg() {
                                    AntalTimmar = 1.5
                                }
                            }
                        }
                    }
                }
            };

            var begaran2 = new Begaran()
            {
                HushallBegaran = new HushallBegaran()
                {
                    Arenden = new HushallBegaranArenden[]
                    {
                        new () {
                            BetalningsDatum = DateTime.Now.Date,
                            FakturaNr = 1234,
                            Kopare = "194805253640",
                            BetaltBelopp = 2500,
                            BegartBelopp = 1250,
                            UtfortArbete = new HushallBegaranArendenUtfortArbete() {
                                Stadning = new HushallBegaranArendenUtfortArbeteStadning() {
                                    AntalTimmar = 1.5
                                }
                            }
                        }
                    }
                }
            };

            if (File.Exists("Begaran.xml"))
                File.Delete("Begaran.xml");

            using var file2 = File.OpenWrite("Begaran.xml");
            RotRutRequest.Serialize(file2, begaran2);

            Begaran begaran = ImportRequest();

            await Task.CompletedTask;
        }

        private static Begaran ImportRequest()
        {
            using var file = File.OpenRead(Path.Combine("Begaran.xml"));
            return RotRutRequest.Deserialize(file);
        }
    }
}
