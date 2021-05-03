using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using RotRut.Validation;

#nullable disable

namespace RotRut.Begaran.Rot
{
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    [MetadataType(typeof(IBegaranArende))]
    public partial class RotBegaranArenden : IBegaranArende
    {
        /// <remarks/>
        public string Kopare
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime BetalningsDatum
        {
            get;
            set;
        }

        /// <remarks/>
        public int PrisForArbete
        {
            get;
            set;
        }

        /// <remarks/>
        public int BetaltBelopp
        {
            get;
            set;
        }

        /// <remarks/>
        public int BegartBelopp
        {
            get;
            set;
        }

        /// <remarks/>
        public string FakturaNr
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElement("Ovrigkostnad")]
        public int? OvrigKostnad
        {
            get;
            set;
        }

        /// <summary>
        /// Fastighetsbeteckning, ska fyllas i om rot-avdraget avser en fastighet 
        /// </summary>
        [XmlElement("Fastighetsbeteckning")]
        public string Fastighetsbeteckning
        {
            get;
            set;
        }

        /// <summary>
        /// Lägenhetsnummer, ska fyllas i om rot-avdraget avser en lägenhet
        /// </summary>
        [XmlElement("LagenhetsNr")]
        [StringLength(25)]
        public int? LagenhetsNr
        {
            get;
            set;
        }

        /// <summary>
        /// Bostadsrättsförenings organisationsnummer, ska fyllas i om rot-avdraget avser en lägenhet 
        /// </summary>
        [XmlElement("BrfOrgNr")]
        [RegularExpression(@"^(\d{10}|\d{12})$")]
        public string BrfOrgNr
        {
            get;
            set;
        }

        /// <summary>
        /// Uppgifter om utfört arbete för Rot 
        /// </summary>
        [ValidateObject]
        public RotBegaranArendenUtfortArbete UtfortArbete
        {
            get;
            set;
        }
    }
}