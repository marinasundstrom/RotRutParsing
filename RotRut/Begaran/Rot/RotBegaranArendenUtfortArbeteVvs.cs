using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

#nullable disable

namespace RotRut.Begaran.Rot
{

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    [MetadataType(typeof(ITimmarMaterial))]
    public partial class RotBegaranArendenUtfortArbeteVvs : ITimmarMaterial
    {
        /// <remarks/>
        public double AntalTimmar
        {
            get;
            set;
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get;
            set;
        }
    }
}