using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;

namespace RotRut.Import
{

        public partial class BeslutsFil
        {
            [JsonPropertyName("version")]
           //[JsonConverter(typeof(ParseStringConverter))]
            public long Version { get; set; }

            [JsonPropertyName("utforare")]
            public string Utforare { get; set; }

            [JsonPropertyName("beslut")]
            public Beslut[] Beslut { get; set; }
        }

        public partial class Beslut
        {
            [JsonPropertyName("namn")]
            public string Namn { get; set; }

            [JsonPropertyName("referensnummer")]
            public string Referensnummer { get; set; }

            [JsonPropertyName("arenden")]
            public Arenden[] Arenden { get; set; }
        }

        public partial class Arenden
        {
            [JsonPropertyName("personnummer")]
            public string Personnummer { get; set; }

            [JsonPropertyName("fakturanummer")]
            //[JsonConverter(typeof(ParseStringConverter))]
            public long? Fakturanummer { get; set; }

            [JsonPropertyName("godkantBelopp")]
            public long GodkantBelopp { get; set; }
        }
}
