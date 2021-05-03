using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using RotRut.Validation;

#nullable disable

namespace RotRut.Begaran.Rut
{
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    [MetadataType(typeof(IBegaranArende))]
    public partial class HushallBegaranArenden : IBegaranArende
    {
        /// <inheritdoc />
         [RegularExpression(@"^(\d{10}|\d{12})$")]
        public string Kopare
        {
            get;
            set;
        }

        /// <inheritdoc />
        [XmlElement(DataType = "date")]
        public DateTime BetalningsDatum
        {
            get;
            set;
        }

        /// <inheritdoc />
        public int PrisForArbete
        {
            get;
            set;
        }

        /// <inheritdoc />
        public int BetaltBelopp
        {
            get;
            set;
        }

        /// <inheritdoc />
        public int BegartBelopp
        {
            get;
            set;
        }

        /// <inheritdoc />
        public string FakturaNr
        {
            get;
            set;
        }

        /// <inheritdoc />
        [XmlElement("Ovrigkostnad")]
        public int? OvrigKostnad
        {
            get;
            set;
        }

        /// <summary>
        /// Uppgifter om utfört arbete för Rut 
        /// </summary>
         [ValidateObject]
        public HushallBegaranArendenUtfortArbete UtfortArbete
        {
            get;
            set;
        }
    }
}